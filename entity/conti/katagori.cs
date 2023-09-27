using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.conti
{
    public class katagori
    {

        [Key]
        public int katagoriID { get; set; }

        public string katagoriName { get; set; }

        public string katagoriDescription { get; set; }

        public bool katagoristatus { get; set; }



        public List<blog> Blogs { get; set; } // üst sınıf katagri alt sınıf blog



    }
}
