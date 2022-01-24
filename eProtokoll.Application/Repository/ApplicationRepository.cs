using AutoMapper;
using eProtokoll.Application.Entity;
using eProtokoll.Application.Interface;
using System;
using System.Threading.Tasks;

namespace eProtokoll.Application.Repository
{
    public class ApplicationRepository : BaseQuery, IApplicationRepository
    {
        public ApplicationRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<bool> Add(Models.Application dto)
        {
            var app = _mapper.Map<Entity.ePApplication>(dto);
            await db.ePAplication.AddAsync(app);
            await db.SaveChangesAsync();
            return true;

        }
    }
}
