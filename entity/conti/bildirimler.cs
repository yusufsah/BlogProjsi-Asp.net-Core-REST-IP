using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.conti
{
    public class bildirimler
    {
        [Key]
        public int bildirimID { get; set; }

        public string bildirimtype { get; set; }

        public string bildirimsenbol { get; set; }

        public string bildirimdetayları { get; set; }

        public string bildirimstatus { get; set; }
    }
}
