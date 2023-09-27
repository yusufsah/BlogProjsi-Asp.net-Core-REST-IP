using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.conti
{
    public class writer
    {
        [Key]
        public int yazarID { get; private set; }

        public string yazarName { get; set; }

        public string writerabout { get; set; }

        public string writeriamge { get; set; }

        public string writerstatuc { get; set; }


        public string writermail { get; set; }

        public string writerpassword { get; set; }


		public List<blog>blogs { get; set; }// üst sınıf write alt snıf blog
	}
}
