using System.Threading.Tasks;
using Abp.Application.Services;
using MyApp.BookList.Sessions.Dto;

namespace MyApp.BookList.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
