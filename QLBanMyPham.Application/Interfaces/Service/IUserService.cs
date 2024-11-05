using QLBanMyPham.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Application.Interfaces.Service
{
    public interface IUserService
    {
        User Register(User user);
        User Login(string username, string password);
    }
}
