using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.conti
{
    public class cotact
    {

        [Key]
        public int contactID{ get; set; }

        public string contactusername { get; set; }

        public string contactmail { get; set; }

        public string contactitle { get; set; }

        public DateTime contactedate { get; set; }

        public bool contactstatus { get; set; }
    }
}
