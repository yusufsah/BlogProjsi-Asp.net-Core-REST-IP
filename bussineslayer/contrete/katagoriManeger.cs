using bussineslayer.Abstract;
using dataacseslayer.abstrac;
using dataacseslayer.entityframwork;
using entity.conti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussineslayer.contrete
{
    public class katagoriManeger : Ikatagoriservis
    {
        // buraya dikkat bussinesleyer katmanında kuralları takiğ etmek için  dataleyerdan kamalarınad uluşıcaz


        IkatagoriDel _ıkatagoriDel;

        public katagoriManeger(IkatagoriDel ıkatagoriDel)
        {
            _ıkatagoriDel = ıkatagoriDel;
        }




        /// <summary>
        /// ///////////////////////////////////////////////// aşşagıda başlıyot yukarda nesne tanımlıyoruz




     

        public katagori TgetbyID(int id)
        {
            return _ıkatagoriDel.getById(id);
        }

       

        public List<katagori> GETLİST()
        {
            return _ıkatagoriDel.getlisrall();
        }


        /// <summary>
        /// //
        /// </summary>
      
        public void Tadd(katagori t)
        {
            _ıkatagoriDel.insert(t);
        }

        public void Tdelete(katagori t)
        {
            _ıkatagoriDel.delete(t);
        }

        public void Tupdate(katagori t)
        {
            _ıkatagoriDel.update(t);
        }

      
    }
}
