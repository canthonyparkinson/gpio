using System;
using System.Device.Gpio;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleFlasher {
    class Program {
        static void Main (string[] args) {
            // GPIO 26 which is physical pin 37
            int ledPin1 = 26;
            GpioController controller = new GpioController ();
            // Sets the pin to output mode so we can switch something on
            controller.OpenPin (ledPin1, PinMode.Output);

            int lightTimeInMilliseconds = 10000;
            int dimTimeInMilliseconds = 5000;

            Console.CancelKeyPress += delegate {
                    controller.Write (ledPin1, PinValue.Low);
                };


            while (true) {
                Console.WriteLine ($"LED1 on for {lightTimeInMilliseconds}ms");
                // turn on the LED
                controller.Write (ledPin1, PinValue.High);
                Thread.Sleep (lightTimeInMilliseconds);
                Console.WriteLine ($"LED1 off for {dimTimeInMilliseconds}ms");
                // turn off the LED
                controller.Write (ledPin1, PinValue.Low);
                Thread.Sleep (dimTimeInMilliseconds);
            }
        }
    }
}