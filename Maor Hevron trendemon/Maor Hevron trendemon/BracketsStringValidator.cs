using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Maor_Hevron_trendemon
{
    public class BracketsStringValidator : StringValidator
    {
        public override Boolean ValidateString(string i_StrToValidate)
        {
            Boolean isRightBracket;
            Boolean isLeftBracket;
            char poppedChar;
            char leftBracketType;

            foreach (char c in i_StrToValidate)
            {
                isLeftBracket = checksIfLeftBracket(c);
                if (isLeftBracket == true)
                {
                    m_ValidationStack.Push(c);
                }
                else
                {
                    isRightBracket = checksIfRightBracket(c);
                    if (isRightBracket == true)
                    {
                        if (m_ValidationStack.Count == 0)
                            return false;

                        poppedChar = (char)m_ValidationStack.Pop();
                        leftBracketType = Brackets.m_BracketsDictionary[c]; //get the 'value' according to the 'key' from the Brackets dictionary
                        if (poppedChar != leftBracketType)
                            return false;
                    }
                }
            }

            if (m_ValidationStack.Count == 0)   //if m_ValidationStack is Empty
                return true;
            else
                return false;
        }

        private Boolean checksIfRightBracket(char i_CharToCheck)
        {
            Boolean isRightBracket = false;
            foreach (Brackets.eRightBracket enumVal in Enum.GetValues(typeof(Brackets.eRightBracket)))
            {
                if (i_CharToCheck == (char)enumVal)
                {
                    isRightBracket = true;
                    break;
                }
            }

            return isRightBracket;
        }

        private Boolean checksIfLeftBracket(char i_CharToCheck)
        {
            Boolean isLeftBracket = false;
            foreach (Brackets.eLeftBracket enumVal in Enum.GetValues(typeof(Brackets.eLeftBracket)))
            {
                if (i_CharToCheck == (char)enumVal)
                {
                    isLeftBracket = true;
                    break;
                }
            }

            return isLeftBracket;
        }
    }
}
