using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyCollection.Models;
using MyCollection.UnitOfWork;

namespace MyCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItensController : ControllerBase
    {
        IUnitOfWork unitOfWork;
        
        public ItensController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        //api/Itens
        [HttpGet]
        public IList<Itens> Get()
        {
            return this.unitOfWork.ItensRepository.FindAll().OrderByDescending(x => x.Id).ToList();
        }

        //api/Itens/6
        [HttpGet("{id}")]
        public Itens Get(int id)
        {
            return this.unitOfWork.ItensRepository.FindById(id);
        }

        //api/Itens
        [HttpPost]
        public ActionResult<Itens> Post([FromBody] Itens value)
        {
            this.unitOfWork.ItensRepository.Add(value);
            this.unitOfWork.Save();
            return value;
        }

        //api/Itens/6
        [HttpPut("{id}")]
        public Itens Put(int id, [FromBody] Itens value)
        {
            var itensInDb = this.unitOfWork.ItensRepository.FindById(id);
            itensInDb.Name = value.Name;
            itensInDb.Loan = value.Loan;
            itensInDb.Type = value.Type;

            if(value.Id > 0)
            {
                this.unitOfWork.ItensRepository.Add(itensInDb);
                this.unitOfWork.Save();
            }
            return itensInDb;
        }





    }
}