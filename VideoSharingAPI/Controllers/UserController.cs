using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoSharing.Repository;
using VideoSharing.Repository.Interfaces;
using VideoSharing.Data.Data.Models;
using VideoSharing.Data.Data.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace VideoSharingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;


        public UserController(IMapper mapper, IRepositoryWrapper repositoryWrapper,UserManager<User> userManager)
        {
            _repoWrapper = repositoryWrapper;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            var Users = _repoWrapper.UserRepository.FindAll();
            return Users;
        }
        
        public IEnumerable<User> GetUserByUserName(string userName)
        {
            var Users = _repoWrapper.UserRepository.FindByCondition(x=>x.UserName == userName);
            return Users;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> Register(UserRegistrationDTO userDTO)
        {
            if (!ModelState.IsValid)
            {
                return "Error in Model";
            }

            var user = _mapper.Map<User>(userDTO);
            var result = await _userManager.CreateAsync(user, userDTO.Password);
            if (!result.Succeeded)
            {
                return "Error in creating user";
            }
            await _userManager.AddToRoleAsync(user, "RegisteredUser");
            return "Success in registering user";
        }
    }
}
