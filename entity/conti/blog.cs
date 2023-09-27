using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.conti
{
     public class blog
    {
        [Key]
        
        public int blogID { get; set; }

        public string title { get; set; }


        public string blogküçükresim { get; set; }

        public string blogbüyükresim { get; set; }

        public string blogcontent { get; set; }

        public DateTime creatdate { get; set; }


        //1. bağlantı
        public int katagoriID { get; set; } //katagorideki ID ile aynı olmak  zorunda  //alt sınıf 2 tane yazıyoruz

        public katagori katagorı  { get; set; }  //katagariden beraber çalışıcaklar bu yüzden

        //////////////////////////////////////


		///2. bağlantı writer üst sınıf olucak

		public int  yazarID { get; set; } //katagorideki ID ile aynı olmak  zorunda  //alt sınıf 2 tane yazıyoruz

		public writer writer { get; set; }  //katagariden beraber çalışıcaklar bu yüzden



   
        /// /////////////////////////////////////////////////
     


		//başka bağlantı   // 3. bağlantı

		public List<comment> comments { get; set; }// üst sınıf blog alt snıf comment

    }
}
