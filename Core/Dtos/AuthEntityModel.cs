using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Dtos
{
    public class AuthEntityModel
    {
        public User User { get; set; }
        public string Token { get; set; }
    }
}
