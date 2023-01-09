using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Addings
{
    public class SliderItemViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Status vacibdir!")]
        public bool Status { get; set; }

        [Required]
        public int OrderBy { get; set; }

        [Required(ErrorMessage ="Əsas mətn vacibdir!")]
        [MaxLength(100,ErrorMessage ="Əsas mətn maximum 100 xarakter ola bilər")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Slogan vacibdir!")]
        [MaxLength(150, ErrorMessage = "Slogan maximum 150 xarakter ola bilər")]
        public string Slogan { get; set; }

        [Required(ErrorMessage = "Şəkil vacibdir!")]
        [MaxLength(100, ErrorMessage = "Şəkilin adı maximum 150 xarakter ola bilər")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Düymənin üzərində mətn olan mətn vacibdir!")]
        [MaxLength(50, ErrorMessage = "Düymənin üzərində mətn maximum 50 xarakter ola bilər")]
        public string ActionText { get; set; }

        [Required(ErrorMessage = "Düymənin keçid yeri vacibdir!")]
        [MaxLength(200, ErrorMessage = "Düymənin keçid yeri maximum 200 xarakter ola bilər")]
        public string EndPoint { get; set; }
    }
}
