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

        //api/Itens/Alugado/6
        [HttpGet("Alugado/{id}")]
        public Itens GetComInclud(int id)
        {
            return this.unitOfWork.ItensRepository.BuscarComInclud(id);
        }

        //api/Itens
        [HttpPost]
        public ActionResult<Itens> Post([FromBody] Itens value)
        {
            value.Loan = false;
            value.Vinculo = null;
            this.unitOfWork.ItensRepository.Add(value);
            this.unitOfWork.Save();
            return value;
        }

        //api/Itens/Alugar
        [HttpPost("Alugar")]
        public ActionResult<Vinculo> PostAlugar([FromBody] Vinculo value)
        {
            var itemInDb = this.unitOfWork.ItensRepository.FindById(value.Itens.Id);
            value.Itens = itemInDb;

            var userInDb = this.unitOfWork.UserRepository.FindById(value.User.Id);
            value.User = userInDb;


            if (value.Itens.Id > 0 && value.Itens.Loan == false && value.User.Id > 0)
            {
                itemInDb.Loan = true;
                this.unitOfWork.VinculoRepository.Add(value);
                this.unitOfWork.Save();
                return Ok();
            }

            return BadRequest();

        }

        //api/Itens/Devolver/6
        [HttpPost("Devolver/{id}")]
        public ActionResult<Vinculo> PostDevolver(int id, [FromBody] Vinculo value)
        {
            var vinculo = this.unitOfWork.VinculoRepository.FindById(id);

            var itemInDb = this.unitOfWork.ItensRepository.FindById(value.Itens.Id);
            value.Itens = itemInDb;

            var userInDb = this.unitOfWork.UserRepository.FindById(value.User.Id);
            value.User = userInDb;

            if (value.Itens.Id > 0 && value.Itens.Loan == true && value.User.Id > 0)
            {
                value.Itens.Loan = false;
                value.Itens.Vinculo = null;
                value.User.Vinculo = null;
                this.unitOfWork.VinculoRepository.Remove(vinculo);
                this.unitOfWork.Save();
                return Ok();
            }

            return BadRequest();
        }

        //api/Itens/6
        [HttpPut("{id}")]
        public Itens Put(int id, [FromBody] Itens value)
        {
            var itensInDb = this.unitOfWork.ItensRepository.FindById(id);
            itensInDb.Name = value.Name;
            itensInDb.Loan = false;
            itensInDb.Type = value.Type;
            itensInDb.Vinculo = null;

            if (value.Id > 0)
            {
                this.unitOfWork.ItensRepository.Add(itensInDb);
                this.unitOfWork.Save();
            }
            return itensInDb;
        }

        //api/Itens/6
        [HttpDelete("{id}")]
        public Itens Delete(int id)
        {
            var itemInDb = this.unitOfWork.ItensRepository.FindById(id);
            this.unitOfWork.ItensRepository.Remove(itemInDb);
            this.unitOfWork.Save();
            return itemInDb;
        }

    }
}
