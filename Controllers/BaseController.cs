using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteBook.IConfig;

namespace NoteBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        // INTEAD OF USING THE context WE GONNA UTILIZE THE UOW //
        public IUnitOfWork _unitOfWork;
        public BaseController(IUnitOfWork unitOfWork)   //AppDbContext context
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

    }
}