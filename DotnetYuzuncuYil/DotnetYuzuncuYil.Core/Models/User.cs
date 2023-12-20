using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //ilişkilerdirme kısmında foreing key
        public int TeamId { get; set; } //foreing key
        public Team Team { get; set; }
    }
}
