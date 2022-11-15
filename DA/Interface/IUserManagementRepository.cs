using DA.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DA.Interface
{
    public interface IUserManagementRepository
    {
        Task<List<UserDBModel>> GetAllUserList();
        Task<UserDBModel> GetUserDetailsById(int UserId);
    }
}
