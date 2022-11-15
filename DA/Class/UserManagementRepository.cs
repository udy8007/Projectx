using AutoMapper;
using DA.DB_Context;
using DA.Interface;
using DA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Class
{
    public class UserManagementRepository : IUserManagementRepository
    {
        private MysqlDBContext myDbContext;
        private readonly IMapper _mapper;

        public UserManagementRepository(MysqlDBContext context, IMapper mapper)
        {
            myDbContext = context;
            _mapper = mapper;
        }

        public async Task<List<UserDBModel>> GetAllUserList()
        {
            var response = this.myDbContext.Users.ToList();
            return _mapper.Map<List<UserDBModel>>(response); ;
        }
        public async Task<UserDBModel> GetUserDetailsById(int UserId)
        {
            var response = this.myDbContext.Users.Where(X => X.UserId == UserId).FirstOrDefault();
            return _mapper.Map<UserDBModel>(response); ;
        }

    }
}
