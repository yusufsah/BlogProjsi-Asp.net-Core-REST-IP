using entity.conti;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussineslayer.Abstract
{
	public interface Iblogservis :IGenericservis<blog>
	{
	

		//ekle  güncelle ve silmeyi  ıgenericserviseten miras alıyor  liste be ıd göre getiride yolladım


	

		List<blog> getbloglistWithKataogri();   //blog listesinin içinde katagori çağırmak için yaptık ama bu EFblogentityframework te yaptık


		List<blog> GetBloglistbyWriter(int id);   //  blog yazısının içinde writerları çağırıma için yaptık

	}
}
