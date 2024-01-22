using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Domain.Services
{
    public  interface IAuthenticationService
    {
        Task<string> GenerateJwtTokenAsync(string username, string password);
    }
}
