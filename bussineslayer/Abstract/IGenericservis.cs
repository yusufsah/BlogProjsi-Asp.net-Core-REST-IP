using entity.conti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussineslayer.Abstract
{
    public interface IGenericservis<T>
    {
      

        void Tadd(T t);              
        void Tdelete(T t);

        void Tupdate(T t);

        List<T> GETLİST();


        T TgetbyID(int id); 



    }
}
