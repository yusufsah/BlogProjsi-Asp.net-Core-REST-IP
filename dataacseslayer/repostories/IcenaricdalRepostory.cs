using dataacseslayer.abstrac;
using dataacseslayer.concreat;
using entity.conti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dataacseslayer.repostories
{
    public class IcenaricdalRepostory<T> : Icenericdal<T> where T : class
    {


        context c = new context();   

        public void delete(T t)
        {


            c.Remove(t);
            c.SaveChanges();
        }


        public T getById(int id)
        {
            return c.Set<T>().Find(id);
        }


        public List<T> getlisrall()
        {
           
            return c.Set<T>().ToList();
        }


        public void insert(T t)
        {

            c.Add(t);
            c.SaveChanges();

        }

        public List<T> getlisral(Expression<Func<T, bool>> filter)
        {
           return c.Set<T>().Where(filter).ToList();
        }

        public void update(T t)
        {

            c.Update(t);
            c.SaveChanges();
        }
    }
}
