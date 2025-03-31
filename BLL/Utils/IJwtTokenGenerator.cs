using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Utils
{
    public interface IJwtTokenGenerator
    {
        public string GenerateToken(string userName);
    }
}
