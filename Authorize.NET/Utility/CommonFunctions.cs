﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuthorizeNet
{
    public class CommonFunctions
    {
        public static bool ParseDateTime(int year, int month, int day, out DateTime dt)
        {
            bool bRet = false;
            dt = new DateTime();
            try
            {
                CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
                bRet = DateTime.TryParse(month.ToString() + "-1-" + year.ToString(), culture, DateTimeStyles.None, out dt);
            }
            catch (Exception)
            {
                bRet = false;
            }
            return bRet;
        }
    }
}
