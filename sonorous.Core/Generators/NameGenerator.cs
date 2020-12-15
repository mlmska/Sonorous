using System;
using System.Collections.Generic;
using System.Text;

namespace sonorous.Core.Generators
{
    public class NameGenerator
    {

        public static string Generateuniqcode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }


    }
}
