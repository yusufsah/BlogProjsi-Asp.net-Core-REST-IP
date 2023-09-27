using entity.conti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataacseslayer.abstrac
{
    public interface IblogDel:Icenericdal<blog>
    {
       
        // buraya neden başka veri ekledik  Icenericdal dışında bloglan kotagroyi çekebilmek v blog 3 de yayınlamak için


        List<blog> GetlistWithkataori();    //burada efbloda 

        List<blog> GetlistWithkataoriwriter(int id);

    }
}
