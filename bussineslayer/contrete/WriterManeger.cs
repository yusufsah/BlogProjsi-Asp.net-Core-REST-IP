using bussineslayer.Abstract;
using dataacseslayer.abstrac;
using entity.conti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussineslayer.contrete
{
	public class WriterManeger : IwriterServis
	{

		IwriterDal _IwriterDal;

		public WriterManeger(IwriterDal ıwriterDal)
		{
			_IwriterDal = ıwriterDal;
		}






		/// <summary>
		/// ////////////////////////////////////////////////////////

	
        public List<writer> GETLİST()
        {
            throw new NotImplementedException();
        }

        public List<writer> GetwrtierbyID(int id) // bu biz + oalrak ekledik 
        {
            return _IwriterDal.getlisral(x => x.yazarID == id);
        }

        public void Tadd(writer t)
        {
            _IwriterDal.insert(t);
        }

        public void Tdelete(writer t)
        {
            throw new NotImplementedException();
        }

        public writer TgetbyID(int id)
        {
           return _IwriterDal.getById(id);
        }

        public void Tupdate(writer t)
        {
            _IwriterDal.update(t);
        }
    }
}
