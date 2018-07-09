using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maor_Hevron_trendemon
{
    public class Brackets
    {
        public static Dictionary<char, char> m_BracketsDictionary = new Dictionary<char, char>();

        static Brackets()
        {
            eRightBracket rightBracket;
            eLeftBracket leftBracket;
            eLeftBracket eLeftBrObj = eLeftBracket.LeftBracket;
            eRightBracket eRightBrObj = eRightBracket.RightBracket;

            for (int i = 0; i < Enum.GetNames(typeof(eRightBracket)).Length; i++)
            {
                leftBracket = (eLeftBracket)(Enum.GetValues(eLeftBrObj.GetType())).GetValue(i);
                rightBracket = (eRightBracket)(Enum.GetValues(eRightBrObj.GetType())).GetValue(i);
                m_BracketsDictionary.Add((char)rightBracket, (char)leftBracket);
            } 
        }

        public enum eRightBracket
        {
            RightParenthesis = ')',
            RightCurlyBrackets = '}',
            RightBracket = ']'
        }

        public enum eLeftBracket
        {
            LeftParenthesis = '(',
            LeftCurlyBrackets = '{',
            LeftBracket = '['
        }
    }
}
