using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace HomeworkWeek1.DataTypeAttributes
{
    public class PhoneFormat : DataTypeAttribute
    {// from here https://stackoverflow.com/questions/36428862/mvc-5-custom-validation-attribute-not-triggered
        private static Regex regex = new Regex(@"\d{4}-\d{6}", RegexOptions.Compiled);
        public string[] Words { get; set; }

        public PhoneFormat() : base(DataType.Text)
        {
            Words = new string[]
            {
                "Will",
                "Admin"
            };

            ErrorMessage = "電話號碼格式錯誤，需為09xx-xxxxxx";
        }
        
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            
            string phoneNumber = (string)value;
            if (regex.Match(phoneNumber).Success)
            {

                return true;
            }

            return false;
        }
    }
}
