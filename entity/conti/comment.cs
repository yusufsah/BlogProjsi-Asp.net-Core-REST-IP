using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.conti
{
    public class comment
    {

        [Key]
        public int commentID { get; set; }

        public string commentuserName { get; set; }

        public string commenttitle { get; set; }


        public string commentcontent { get; set; }

        public DateTime commentDate { get; set; }

        public  string commentstatus { get; set; }

        ////aşşağı bağlantı
        ///
        public int blogID { get; set; } //blog ID ile aynı olmak  zorunda

        public blog blogs { get; set; }  //blog beraber çalışıcaklar bu yüzden








    }
}
