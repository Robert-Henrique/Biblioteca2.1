using Repository.DAL.Context;
using Repository.DAL.Repository.Base;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL.Repository
{
    public class CidadeRepository : Repository<Cidade>
    {
        public CidadeRepository(UnitOfWork uow)
            : base(uow)
        {

        }
    }
}
