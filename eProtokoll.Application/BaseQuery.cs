using AutoMapper;
using eProtokoll.Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProtokoll.Application
{
    public class BaseQuery
    {
        protected readonly ApplicationDbContext db;
        protected readonly IMapper _mapper;

        public BaseQuery(ApplicationDbContext dbContext, IMapper mapper)
        {
            db = dbContext;
            _mapper = mapper;
        }
    }
}
