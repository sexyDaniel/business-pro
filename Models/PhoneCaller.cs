using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPro.Models
{
    public class PhoneCaller
    {
        [Key]
        public int PhoneCallerID { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
    }
}
