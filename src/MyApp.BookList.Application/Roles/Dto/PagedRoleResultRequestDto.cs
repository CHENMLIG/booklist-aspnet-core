using Abp.Application.Services.Dto;

namespace MyApp.BookList.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

