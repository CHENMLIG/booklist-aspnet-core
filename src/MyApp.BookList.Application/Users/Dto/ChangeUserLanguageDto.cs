using System.ComponentModel.DataAnnotations;

namespace MyApp.BookList.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}