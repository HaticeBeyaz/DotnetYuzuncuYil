using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Models
{
    public class UserProfile
    {
        public int Id { get; set; } //primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }

        //foreing key
        public int UserId { get; set; }

        //birebir ilişki
        public User User { get; set; }
        public Team Team { get; set; }
    }
}
