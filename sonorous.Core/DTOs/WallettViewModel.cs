﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Core.DTOs
{
    public class ChargeWallettViewModel
    {
        [Display(Name ="مبلغ")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public int Amount { get; set; }

    }
    public class WallettViewModel
    {
        public int Amount { get; set; }

        public int Type { get; set; }

        public string Description { get; set; }

        public DateTime Createtime { get; set; }


    }
    
}
