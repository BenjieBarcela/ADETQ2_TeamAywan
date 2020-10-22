using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADETQ2_TeamAywan.Models
{
    public class Members 
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int  StudID { get; set; }
        public string LName { get; set; }
        public string Fname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
