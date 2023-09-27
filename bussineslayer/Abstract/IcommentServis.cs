using entity.conti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussineslayer.Abstract
{
	public interface IcommentServis
	{
		List<comment> GETLİST(int id);

		void addcomment(comment comment);                 //kaydetme


		//  void deletcomment(comment comment);    şu an ihtiyaç yok

		//   void updatcomment(comment comment);


		comment getbyID(int id);  //ID GÖRE GETİR



	}
}
