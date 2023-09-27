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
	public class contactManeger : Icontactservis
	{
		IcontactDal _ıcontactDal;

		public contactManeger(IcontactDal ıcontactDal)
		{
			_ıcontactDal = ıcontactDal;
		}


		/// <summary>
		/// 
		/// </summary>
		

		public void contactadd(cotact cotact)
		{
			_ıcontactDal.insert(cotact);
		}
	}
}
