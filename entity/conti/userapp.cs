using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.conti
{
    public class userapp: IdentityUser<int>

    {
        public string namesurname  { get; set; }

        public string imageurl { get; set; }
    }
}
