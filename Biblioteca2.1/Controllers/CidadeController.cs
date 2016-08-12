using Repository.DAL.Context;
using Repository.DAL.Repository.Base;
using Repository.Entities;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace Biblioteca2._1.Controllers
{
    public class CidadeController : ApiController
    {
        readonly IUnitOfWork uow;
        readonly IRepository<Cidade> cidadeRepository;

        public CidadeController(IRepository<Cidade> _cidadeRepository,
                                 IUnitOfWork _unitOfWork)
        {
            uow = _unitOfWork;
            cidadeRepository = _cidadeRepository;
        }

        // GET: api/Cidade
        public IQueryable<Cidade> GetCidade()
        {
            return cidadeRepository.GetAll();
        }

        // GET: api/Cidade/5
        [ResponseType(typeof(Cidade))]
        public IHttpActionResult GetCidadePorEstadoId(int id)
        {
            var cidades = cidadeRepository.GetAll().Where(c => c.EstadoId.Equals(id));
            if (cidades.Count() == 0)
            {
                return NotFound();
            }

            return Ok(cidades);
        }
    }
}
