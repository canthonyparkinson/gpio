using System;
using System.Threading;
using System.Collections.Generic;

namespace ca.canthonyparkinson.gpio.morse {
    class Program {
        static void Main (string[] args) {
            String msg = String.Join(' ', args);
            process(msg);

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
                    Console.Write('.');
                    break;
                case Morse.DASH:
                    Console.Write('-');
                    break;
                case Morse.INTER_LETTER_GAP:
                    Console.Write(' ');
                    break;
                case Morse.INTER_WORD_GAP:
                    Console.Write("   ");
                    break;
            }
        }
    }
}