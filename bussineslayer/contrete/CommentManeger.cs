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
	public class CommentManeger : IcommentServis
	{

		IcommentDal _comment;

		public CommentManeger(IcommentDal comment)
		{
			_comment = comment;
		}

	
		/// ///////////////////////////  
	




		public void addcomment(comment comment)
		{
			_comment.insert(comment);
		}

		public comment getbyID(int id)
		{
			throw new NotImplementedException();
		}

		public List<comment> GETLİST(int id)
		{
		 return	_comment.getlisral(x => x.blogID == id); 
		}
	}
}
