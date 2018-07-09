using System;
using System.Text;
using System.Collections;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maor_Hevron_trendemon;

namespace TestValidation.UnitTests
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void StringValidation_ExpectedBehavior()
        {
            Boolean isValidString;
            StringValidator strValidator = new BracketsStringValidator();

            //Valid scenarios
            string strToValidate = "{he1{}{}s(1)[2]}";
            isValidString = strValidator.ValidateString(strToValidate);
            Assert.IsTrue(isValidString);

            strToValidate = "string_without_brackets";
            isValidString = strValidator.ValidateString(strToValidate);
            Assert.IsTrue(isValidString);

            strToValidate = "3*{[(2+1)]}";
            isValidString = strValidator.ValidateString(strToValidate);
            Assert.IsTrue(isValidString);

            //NOT valid scenarios
            strToValidate = "25+23{([21*2]})";
            isValidString = strValidator.ValidateString(strToValidate);
            Assert.IsFalse(isValidString);

            strToValidate = "3*(2+1))";
            isValidString = strValidator.ValidateString(strToValidate);
            Assert.IsFalse(isValidString);
        }
    }
}