using Repository.DAL.Context;
using Repository.DAL.Repository.Base;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Biblioteca2._1.Controllers
{
    public class ClienteController : ApiController
    {
        readonly IUnitOfWork uow;
        readonly IRepository<Cliente> clienteRepository;

        public ClienteController(IRepository<Cliente> _clienteRepository,
                                 IUnitOfWork _unitOfWork)
        {
            uow = _unitOfWork;
            clienteRepository = _clienteRepository;
        }

        // GET: api/Clientes
        public IQueryable<Cliente> GetCliente()
        {
            return clienteRepository.GetAll();
        }

        // GET: api/Clientes/5
        [ResponseType(typeof(Cliente))]
        public IHttpActionResult GetCliente(int id)
        {
            var cliente = clienteRepository.Get(c => c.Id.Equals(id)).Select(c => new Cliente
            {
                Id = c.Id,
                Nome = c.Nome,
                CPF = c.CPF,
                DataNascimento = c.DataNascimento,
                Sexo = c.Sexo,
                Telefone = c.Telefone,
                Email = c.Email,
                CidadeId = c.CidadeId,
                EstadoId = c.Cidade.EstadoId
            }).FirstOrDefault();

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        // PUT: api/Clientes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cliente.Id)
            {
                return BadRequest();
            }

            try
            {
                if (cliente.Id == 0)
                    clienteRepository.Save(cliente);
                else
                    clienteRepository.Update(cliente);

                uow.Commit();
            }
            catch (Exception)
            {
                throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Clientes
        [ResponseType(typeof(Cliente))]
        public IHttpActionResult PostCliente(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            clienteRepository.Save(cliente);
            uow.Commit();

            return CreatedAtRoute("DefaultApi", new { id = cliente.Id }, cliente);
        }

        // DELETE: api/Clientes/5
        [ResponseType(typeof(Cliente))]
        public IHttpActionResult DeleteCliente(int id)
        {
            Cliente cliente = clienteRepository.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }

            clienteRepository.Remove(c => c == cliente);
            uow.Commit();

            return Ok(cliente);
        }
    }
}
