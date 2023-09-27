using dataacseslayer.abstrac;
using dataacseslayer.concreat;
using dataacseslayer.repostories;
using entity.conti;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataacseslayer.entityframwork
{
	public class EFblogRepository : IcenaricdalRepostory<blog>, IblogDel
	{
		public List<blog> GetlistWithkataori() // bunu ayrıyeten bloda katagriye göre listeleme işlemi yapmak için yaptık
		{
			// diğerlerinden farklı
			using (var c = new context())
			{




				return c.blogs.Include(x=>x.katagorı).ToList();
			}







			
		}

        public List<blog> GetlistWithkataoriwriter(int id)  // burası writer panel için
        {
            // diğerlerinden farklı
            using (var c = new context())
            {




                return c.blogs.Include(x => x.katagorı).Where(x=>x.yazarID==id).ToList();
            }
        }
    }
}
