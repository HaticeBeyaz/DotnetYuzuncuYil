﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Models
{
    public class Team : BaseEntity
    {
        public string TeamName { get; set; }

        //bire çok ilişki
        public ICollection<User> User { get; set; }
    }

}
