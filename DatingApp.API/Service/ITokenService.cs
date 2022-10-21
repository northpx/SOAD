using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Service
{
    public interface ITokenService
    {
        string CreateToken(string username);
    }
}