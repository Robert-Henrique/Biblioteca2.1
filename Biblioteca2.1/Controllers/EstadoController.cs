using Repository.DAL.Context;
using Repository.DAL.Repository.Base;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Biblioteca2._1.Controllers
{
    public class EstadoController : ApiController
    {
        readonly IUnitOfWork uow;
        readonly IRepository<Estado> estadoRepository;

        public EstadoController(IRepository<Estado> _estadoRepository,
                                IUnitOfWork _unitOfWork)
        {
            uow = _unitOfWork;
            estadoRepository = _estadoRepository;
        }

        // GET: api/Estado
        public IQueryable<Estado> GetEstado()
        {
            return estadoRepository.GetAll();
        }
    }
}
