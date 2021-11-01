using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteBook.Data;
using NoteBook.DbSet;
using NoteBook.Dtos.Incoming;
using NoteBook.IConfig;

namespace NoteBook.Controllers
{
    public class UsersController : BaseController
    {
        
        //private AppDbContext _context;

        public UsersController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        //Get All
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            //var users = _context.Users.Where(x => x.Status == 1).ToList();   we directly connected to the db context, we directly searched for the users table and added our condition and converting into list
            //return Ok(users);
            var users = await _unitOfWork.Users.All();
            return Ok(users);
        }

        //Post
        [HttpPost]
        public async Task<IActionResult> AddUser(UserDto user)
        {
            var _user = new User();
            _user.LastName = user.LastName;
            _user.FirstName = user.FirstName;
            _user.Email = user.Email;
            _user.Country = user.Country;
            _user.DateOfBirth = Convert.ToDateTime(user.DateOfBirth);
            _user.Phone = user.Phone;

            _user.Status = 1;

            await _unitOfWork.Users.Add(_user);   //prepei na paroume to Add() apo Users
            await _unitOfWork.CompleteAsync();

            // _context.Users.Add(_user);
            // _context.SaveChanges();

            return CreatedAtRoute("GetUser", new { _user.Id }, user);
        }

        //Get
        [HttpGet]   //[HttpGet("{id}")
        [Route("GetUser", Name = "GetUser")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            // var user = _context.Users.FirstOrDefault(p => p.Id == id);
            var user = await _unitOfWork.Users.GetById(id);

            return  Ok(user);
        }


    }
}