using FormaOne_MVC.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormaOne_MVC.Models
{
    
    public class FormaOneTeam
    {
       
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }


        [DateRange("1915/01/01", "2085/01/01")]
        [DataType(DataType.Date)]
        public DateTime Founded { get; set; }

        [Range(0,50)]
        public int WinCup { get; set; }
     
        public bool Payed { get; set; }
    }
}