using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BA.DTO;
using BA.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        #region Private Members
        private readonly IUserManagementLogic _IUserManagementLogic;
        #endregion

        #region Constructor
        public UserManagementController(IUserManagementLogic iUserManagementLogic)
        {
            _IUserManagementLogic = iUserManagementLogic;
        }
        #endregion

        #region Public
        [HttpGet("GetAllUserList")]
        public async Task<IActionResult> GetAllUserList()
        {
            try
            {
                var res = await _IUserManagementLogic.GetAllUserList();
                return Ok(res);

            }
            catch (Exception ex)
            {
                return BadRequest(" " + ex.Message);
            }
        }

        [HttpGet("GetUserDetailsById")]
        public async Task<IActionResult> GetUserDetailsById(int UserId)
        {
            try
            {
                var res = await _IUserManagementLogic.GetUserDetailsById(UserId);
                return Ok(res);

            }
            catch (Exception ex)
            {
                return BadRequest(" " + ex.Message);
            }
        }
        #endregion
    }
}