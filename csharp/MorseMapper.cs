using System.Collections.Generic;

namespace ca.canthonyparkinson.gpio.morse {
    public class MorseMapper
    {
        public static IList<Morse> Map(char c) {
            switch (char.ToUpper(c)) {
                case 'A':
                    return new List<Morse> {Morse.DOT, Morse.DASH };
                case 'B':
                    return new List<Morse> { };
                case 'C':
                    return new List<Morse> { };
                case 'D':
                    return new List<Morse> { };
                case 'E':
                    return new List<Morse> { };
                case 'F':
                    return new List<Morse> { };
                case 'G':
                    return new List<Morse> { };
                case 'H':
                    return new List<Morse> { };
                case 'I':
                    return new List<Morse> { };
                case 'J':
                    return new List<Morse> { };
                case 'K':
                    return new List<Morse> { };
                case 'L':
                    return new List<Morse> { };
                case 'M':
                    return new List<Morse> { };
                case 'N':
                    return new List<Morse> { };
                case 'O':
                    return new List<Morse> { };
                case 'P':
                    return new List<Morse> { };
                case 'Q':
                    return new List<Morse> { };
                case 'R':
                    return new List<Morse> { };
                case 'S':
                    return new List<Morse> { };
                case 'T':
                    return new List<Morse> { };
                case 'U':
                    return new List<Morse> { };
                case 'V':
                    return new List<Morse> { };
                case 'W':
                    return new List<Morse> { };
                case 'X':
                    return new List<Morse> { };
                case 'Y':
                    return new List<Morse> { };
                case 'Z':
                    return new List<Morse> { };
                case '0':
                    return new List<Morse> { };
                case '1':
                    return new List<Morse> { };
                case '2':
                    return new List<Morse> { };
                case '3':
                    return new List<Morse> { };
                case '4':
                    return new List<Morse> { };
                case '5':
                    return new List<Morse> { };
                case '6':
                    return new List<Morse> { };
                case '7':
                    return new List<Morse> { };
                case '8':
                    return new List<Morse> { };
                case '9':
                    return new List<Morse> { };
                case ' ':
                    return new List<Morse> { Morse.INTER_WORD_GAP};
                default:
                    return new List<Morse> { };
            }
        }
    }
}