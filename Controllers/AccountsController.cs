using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NoteBook.Config.Models;
using NoteBook.IConfig;
using NoteBook.Models.DTO.Incoming;

namespace NoteBook.Controllers
{
    public class AccountsController : BaseController
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtConfig _jwtConfig;
        public AccountsController(IUnitOfWork unitOfWork, UserManager<IdentityUser> userManager, IOptionsMonitor<JwtConfig> optionMonitor)
            : base(unitOfWork)
        {
            _userManager = userManager;
            _jwtConfig = optionMonitor.CurrentValue;   //connect to the app setings and pulling the info out (startup)
        }

        //Register Action
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequestDTO registrationDto )
    }
}