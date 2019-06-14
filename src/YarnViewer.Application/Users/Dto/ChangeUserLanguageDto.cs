using System.ComponentModel.DataAnnotations;

namespace YarnViewer.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}