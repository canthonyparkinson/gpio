using System.Collections.Generic;

namespace ca.canthonyparkinson.gpio.morse {
    public class MorseMapper
    {
        public static IList<Morse> Map(char c) {
            switch (char.ToUpper(c)) {
                case 'A':
                    return new List<Morse> {Morse.DOT, Morse.DASH };
                case 'B':
                    return new List<Morse> {Morse.DASH, Morse.DOT, Morse.DOT, Morse.DOT };
                case 'C':
                    return new List<Morse> {Morse.DASH, Morse.DOT, Morse.DASH, Morse.DOT };
                case 'D':
                    return new List<Morse> {Morse.DASH, Morse.DOT, Morse.DOT };
                case 'E':
                    return new List<Morse> {Morse.DOT };
                case 'F':
                    return new List<Morse> {Morse.DOT, Morse.DOT, Morse.DASH, Morse.DOT };
                case 'G':
                    return new List<Morse> {Morse.DASH, Morse.DASH, Morse.DOT };
                case 'H':
                    return new List<Morse> {Morse.DOT, Morse.DOT, Morse.DOT, Morse.DOT };
                case 'I':
                    return new List<Morse> {Morse.DOT, Morse.DOT };
                case 'J':
                    return new List<Morse> {Morse.DOT, Morse.DASH, Morse.DASH, Morse.DASH };
                case 'K':
                    return new List<Morse> {Morse.DASH, Morse.DOT, Morse.DASH };
                case 'L':
                    return new List<Morse> {Morse.DOT, Morse.DASH, Morse.DOT, Morse.DOT };
                case 'M':
                    return new List<Morse> {Morse.DASH, Morse.DASH };
                case 'N':
                    return new List<Morse> {Morse.DASH, Morse.DOT };
                case 'O':
                    return new List<Morse> {Morse.DASH, Morse.DASH, Morse.DASH };
                case 'P':
                    return new List<Morse> {Morse.DOT, Morse.DASH, Morse.DASH, Morse.DOT };
                case 'Q':
                    return new List<Morse> {Morse.DASH, Morse.DASH, Morse.DOT, Morse.DASH };
                case 'R':
                    return new List<Morse> {Morse.DOT, Morse.DASH, Morse.DOT };
                case 'S':
                    return new List<Morse> {Morse.DOT, Morse.DOT, Morse.DOT };
                case 'T':
                    return new List<Morse> {Morse.DASH };
                case 'U':
                    return new List<Morse> {Morse.DOT, Morse.DOT, Morse.DASH };
                case 'V':
                    return new List<Morse> {Morse.DOT, Morse.DOT, Morse.DOT, Morse.DASH };
                case 'W':
                    return new List<Morse> {Morse.DOT, Morse.DASH, Morse.DASH };
                case 'X':
                    return new List<Morse> {Morse.DASH, Morse.DOT, Morse.DOT, Morse.DASH };
                case 'Y':
                    return new List<Morse> {Morse.DASH, Morse.DOT, Morse.DASH, Morse.DASH };
                case 'Z':
                    return new List<Morse> { Morse.DASH, Morse.DASH, Morse.DOT, Morse.DOT};
                case '0':
                    return new List<Morse> {Morse.DASH, Morse.DASH, Morse.DASH, Morse.DASH, Morse.DASH };
                case '1':
                    return new List<Morse> {Morse.DOT, Morse.DASH, Morse.DASH, Morse.DASH, Morse.DASH };
                case '2':
                    return new List<Morse> {Morse.DOT, Morse.DOT, Morse.DASH, Morse.DASH, Morse.DASH };
                case '3':
                    return new List<Morse> {Morse.DOT, Morse.DOT, Morse.DOT, Morse.DASH, Morse.DASH };
                case '4':
                    return new List<Morse> {Morse.DOT, Morse.DOT, Morse.DOT, Morse.DOT, Morse.DASH };
                case '5':
                    return new List<Morse> {Morse.DOT, Morse.DOT, Morse.DOT, Morse.DOT, Morse.DOT };
                case '6':
                    return new List<Morse> {Morse.DASH, Morse.DOT, Morse.DOT, Morse.DOT, Morse.DOT };
                case '7':
                    return new List<Morse> {Morse.DASH, Morse.DASH, Morse.DOT, Morse.DOT, Morse.DOT };
                case '8':
                    return new List<Morse> {Morse.DASH, Morse.DASH, Morse.DASH, Morse.DOT, Morse.DOT };
                case '9':
                    return new List<Morse> {Morse.DASH, Morse.DASH, Morse.DASH, Morse.DASH, Morse.DOT };
                case ' ':
                    return new List<Morse> { Morse.INTER_WORD_GAP};
                default:
                    return new List<Morse> { };
            }
        }
    }
}