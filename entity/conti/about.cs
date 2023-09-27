using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.conti
{
    public class about
    {

        [Key]
        public int aboutID { get; set; }

        public string  aboutdetails1 { get; set; }

        public string aboutdetails2 { get; set; }




    }
}
