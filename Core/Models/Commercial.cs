﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Commercial : User
    {
        public List<Bungalow> Bungalows { get; set; }
    }
}
