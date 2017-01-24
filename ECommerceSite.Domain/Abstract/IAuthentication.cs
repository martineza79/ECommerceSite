using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSite.Domain.Abstract
{
    public interface IAuthentication
    {
        bool Authenticate(string username, string password);
        bool Logout();
    }
}
