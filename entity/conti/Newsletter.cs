using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.conti
{
	public class Newsletter
	{
		[Key]
        public int mailID { get; set; }

        public string mail { get; set; }

        public bool mailstatus { get; set; }

    }
}
