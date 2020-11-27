using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace BLL.Helper
{
    public class LanguageValidationAttribute : ValidationAttribute
    {
        public LanguageValidationAttribute() { }

        public override bool IsValid(object value)
        {
            string strValue = value as string;
            if(!string.IsNullOrEmpty(strValue))
            {
                string englishLetters = @"[A-Za-z]+";
                string georgianLetters = @"[ა-ჰ]+";
                string symbols = @"[^a-zA-Zა-ჰ.]";

                bool containsEnglish = Regex.IsMatch(strValue, englishLetters);
                bool containsGeorgian = Regex.IsMatch(strValue, georgianLetters);
                bool containsSymbols = Regex.IsMatch(strValue, symbols);

                if(containsSymbols || (containsEnglish && containsGeorgian))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
