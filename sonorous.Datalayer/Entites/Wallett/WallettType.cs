
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using sonorous.Datalayer.Entites.Wallett;

namespace sonorous.Datalayer.Entites.Wallett
{
    public class WallettType
    {
        public WallettType()
        {

        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeID { get; set; }

        [Required]
        [MaxLength(150)]
        public string TypeTitle { get; set; }


        #region Relations

        public virtual List<Wallett> Walletts { get; set; }


        #endregion

    }
}
