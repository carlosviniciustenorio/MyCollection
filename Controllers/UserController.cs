using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyCollection.Models;
using MyCollection.UnitOfWork;

namespace MyCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUnitOfWork unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: api/User
        [HttpGet]
        public IList<User> Get()
        {
            return this.unitOfWork.UserRepository.FindAll().OrderByDescending(x => x.Id).ToList();
        }

        //GET: api/User/4
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return this.unitOfWork.UserRepository.FindById(id);
        }

        // POST: api/User
        [HttpPost]
        public ActionResult<User> Post([FromBody] User value)
        {
            value.Vinculo = null;
            this.unitOfWork.UserRepository.Add(value);
            this.unitOfWork.Save();
            return value;
        }

        //PUT: api/User/2
        [HttpPut("{id}")]
        public User Put(int id, [FromBody] User value)
        {
            var userInDb = this.unitOfWork.UserRepository.FindById(id);
            userInDb.Name = value.Name;
            userInDb.Email = value.Email;
            userInDb.Phone = value.Phone;
            userInDb.Email = value.Email;
            userInDb.Endereco = value.Endereco;
            userInDb.Vinculo = null;
            if(value.Id > 0)
            {
                this.unitOfWork.UserRepository.Edit(userInDb);
                this.unitOfWork.Save();
            }
            return userInDb;
        }

        //DELETE: api/User/2
        [HttpDelete("{id}")]
        public User Delete(int id)
        {
            var userInDb = this.unitOfWork.UserRepository.FindById(id);
            this.unitOfWork.UserRepository.Remove(userInDb);
            this.unitOfWork.Save();
            return userInDb;
        }
        
    }
}