using Microsoft.AspNetCore.Antiforgery;
using MyApp.BookList.Controllers;

namespace MyApp.BookList.Web.Host.Controllers
{
    public class AntiForgeryController : BookListControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
