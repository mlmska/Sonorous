using System;
using System.Collections.Generic;
using System.Text;

namespace sonorous.Core.DTOs
{
    public class ShowProductForAdminViewModel
    {
        public int ProductID { get; set; }

        public string ImageName { get; set; }

        public int Price { get; set; }

        public string Title { get; set; }
    }
}
