using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class AuthEntityReadDto
    {
        public UserReadDto User { get; set; }
        public string Token { get; set; }
    }
}
