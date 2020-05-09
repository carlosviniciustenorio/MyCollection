using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCollection.Context;
using MyCollection.UnitOfWork;

namespace MyCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItensController : ControllerBase
    {
        IUnitOfWork unitOfWork;
        readonly ContextCT _context;

        [HttpGet]

    }
}