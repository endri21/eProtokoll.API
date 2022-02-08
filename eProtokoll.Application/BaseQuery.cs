using AutoMapper;
using eProtokoll.Application.Entity;


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
