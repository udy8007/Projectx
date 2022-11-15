using BA.Interface;
using DA.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DTO;
using AutoMapper;
using AutoMapper.Configuration;


namespace BA.Class
{
    public class UserManagementLogic : IUserManagementLogic
    {
        #region Private Members
        private readonly IUserManagementRepository _IUserManagementRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public UserManagementLogic(IUserManagementRepository iUserManagementRepository, IMapper mapper)
        {
            _IUserManagementRepository = iUserManagementRepository;
            _mapper = mapper;
        }
        #endregion

        public async Task<List<UserDTO>> GetAllUserList()
        {
            var response =await _IUserManagementRepository.GetAllUserList();
            return _mapper.Map<List<UserDTO>>(response); 
        }
        public async Task<UserDTO> GetUserDetailsById(int UserId)
        {
            var response =await _IUserManagementRepository.GetUserDetailsById(UserId);
            return _mapper.Map<UserDTO>(response); 
        }
    }
}
