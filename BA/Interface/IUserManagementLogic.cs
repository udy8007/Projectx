using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DTO;

namespace BA.Interface
{
    public interface IUserManagementLogic
    {
        Task<List<UserDTO>> GetAllUserList();
        Task<UserDTO> GetUserDetailsById(int UserId);
    }
}
