using System;
using System.Collections.Generic;
using System.Text;

namespace Azf.Services
{
    public class UserService : IUserService
    {
        public Guid GetUserId()
        {
            return Guid.NewGuid();
        }
    }
}
