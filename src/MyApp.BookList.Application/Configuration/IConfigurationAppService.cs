using System.Threading.Tasks;
using MyApp.BookList.Configuration.Dto;

namespace MyApp.BookList.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
