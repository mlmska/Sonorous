using System;
using System.Collections.Generic;
using System.Text;

namespace sonorous.Core.Convertors
{
    public class FixedText
    {
        public static string fixedemail(string email)
        {
            return email.Trim().ToLower();
        }

    }
}
