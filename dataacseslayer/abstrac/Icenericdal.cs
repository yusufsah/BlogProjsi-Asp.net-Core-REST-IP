using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dataacseslayer.abstrac
{
    public interface Icenericdal<T>where T : class  // t değeri class ağit tüm değerlerikullaıcak
    {

        void insert (T t); 

        void delete(T t);

        void update(T t);


        List<T> getlisrall();

        T getById(int id);


        List<T> getlisral(Expression<Func<T,bool>>filter);


    }
}
