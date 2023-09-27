using bussineslayer.Abstract;
using dataacseslayer.abstrac;
using entity.conti;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussineslayer.contrete
{
	public class BlogManeger : Iblogservis
	{
		IblogDel _blogDel;

		public BlogManeger(IblogDel blogDel)
		{
			_blogDel = blogDel;
		}

	
		/// //////////////////////////////////////////////////////
	


	

	
		//


		public List<blog> getbloglistWithKataogri()
		{
			return _blogDel.GetlistWithkataori();
		}

		//

		public List<blog> test(int id) {



			return _blogDel.GetlistWithkataoriwriter(id);  // bunu datalayrt blölümde blog serviste yaptık 
		}

		//
		public blog TgetbyID(int id)
		{
			return _blogDel.getById(id);
		}

		public List<blog> GETLİST()
		{
		   return _blogDel.getlisrall();
		}

		//

		 public List<blog> getlast3blog()  // son eklene 3 blogu getirmek için 
		{

			return _blogDel.getlisrall().Take(3).ToList();

		}

		//
		

		public List<blog> getblogbyID(int id) // 
		{

			return _blogDel.getlisral(x=>x.blogID == id);	

		}

		public List<blog> GetBloglistbyWriter(int id)
		{
			return _blogDel.getlisral(x => x.yazarID == id);
		}
		
		/// /////////////////////////////////////////////////////////////////////////
		
        public void Tadd(blog t)
        {
              _blogDel.insert(t);
        }

        public void Tdelete(blog t)
        {
            _blogDel.delete(t);
        }

        public void Tupdate(blog t)
        {
           _blogDel.update(t);
        }
      
    }
}
