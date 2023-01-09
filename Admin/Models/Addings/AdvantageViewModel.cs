using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Addings
{
    public class AdvantageViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Status vacibdir!")]
        public bool Status { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Mətn maximum 100 xarakter ola bilər!")]
        public string Icon { get; set; }

        [Required (ErrorMessage ="Başlıq vacibdir!")]
        [MaxLength(100,ErrorMessage ="Mətn maximum 100 xarakter ola bilər!")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Mətn vacibdir!")]
        [MaxLength(150, ErrorMessage = "Mətn maximum 150 xarakter ola bilər!")]
        public string Description { get; set; }
    }
}
