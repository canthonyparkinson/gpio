using System;
using System.Threading;
using System.Collections.Generic;
using System.Device.Gpio;
using System.Threading.Tasks;

namespace ca.canthonyparkinson.gpio.morse {
    class Program {
    private static GpioController controller;
    // GPIO 26 which is physical pin 37
    private static int ledPin1 = 26;

    private const int dotTimeInMilliseconds = 333;
    private const int dashTimeInMilliseconds = 1000;
    private const int endTimeInMilliseconds = 333;
    private const int endOfCharTimeInMilliseconds = 1000;
    private const int endOfWordTimeInMilliseconds = 3000;

        static void Main (string[] args) {
            String msg = String.Join(' ', args);
            init();
            process(msg);
            finish();
        }

        static void init() {
            Console.WriteLine ("Beginning");
            controller = new GpioController ();
            // Sets the pin to output mode so we can switch something on
            controller.OpenPin (ledPin1, PinMode.Output);
            controller.Write (ledPin1, PinValue.Low);
        }

        static void finish() {
            controller.Write (ledPin1, PinValue.Low);
            Console.WriteLine ("Finished");
        }

        static void process(String msg) {
            foreach (char c in msg.ToCharArray()) {
                process(c);
            }
        }

        static void process(char c) {
            IList<Morse> code = MorseMapper.Map(c);
            if (code?.Count > 0) {
                foreach (Morse m in code) {
                    output(m);
                }
                output(Morse.INTER_LETTER_GAP);
            } else {
                if (c == ' ') {
                    output(Morse.INTER_WORD_GAP);
                }
            }
        }

        static void output(Morse m) {
            switch (m) {
                case Morse.DOT:
                    controller.Write (ledPin1, PinValue.High);
                    Thread.Sleep (dotTimeInMilliseconds);
                    controller.Write (ledPin1, PinValue.Low);
                    Thread.Sleep (endTimeInMilliseconds);
                    break;
                case Morse.DASH:
                    controller.Write (ledPin1, PinValue.High);
                    Thread.Sleep (dashTimeInMilliseconds);
                    controller.Write (ledPin1, PinValue.Low);
                    Thread.Sleep (endTimeInMilliseconds);
                    break;
                case Morse.INTER_LETTER_GAP:
                    controller.Write (ledPin1, PinValue.Low);
                    Thread.Sleep (endOfCharTimeInMilliseconds);
                    break;
                case Morse.INTER_WORD_GAP:
                    controller.Write (ledPin1, PinValue.Low);
                    Thread.Sleep (endOfWordTimeInMilliseconds);
                    break;
            }
        }
    }
}