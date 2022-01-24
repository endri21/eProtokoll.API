using System;
using System.Threading.Tasks;

namespace eProtokoll.Application.Interface
{
    public interface IApplicationRepository
    {
        Task<bool> Add(Models.Application dto);
    }
}
