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

        [HttpPost]
        public ActionResult<Itens> Post([FromBody] Itens value)
        {
            this.unitOfWork.ItensRepository.Add(value);
            this.unitOfWork.Save();
            return value;
        }

    }
}