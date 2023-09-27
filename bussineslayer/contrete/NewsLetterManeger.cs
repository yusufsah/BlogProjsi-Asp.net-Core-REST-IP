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
	public class NewsLetterManeger : InewsletterServis
	{

		InewsLetterdal _ınewsLetterdal;

		public NewsLetterManeger(InewsLetterdal ınewsLetterdal)
		{
			_ınewsLetterdal = ınewsLetterdal;
		}


		/// <summary>
		/// 



		public void addnewslitter(Newsletter newsletter)
		{
			
		       _ınewsLetterdal.insert(newsletter);
		}
	}
}
