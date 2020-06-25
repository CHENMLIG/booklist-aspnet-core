using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyApp.BookList.MultiTenancy.Dto;

namespace MyApp.BookList.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
