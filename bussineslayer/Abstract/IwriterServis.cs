using dataacseslayer.abstrac;
using entity.conti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussineslayer.Abstract
{
	public interface IwriterServis : IGenericservis<writer>
    {
        List<writer> GetwrtierbyID(int id);


    }
}
