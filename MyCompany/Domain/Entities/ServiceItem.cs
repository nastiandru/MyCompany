using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название услуги")]
        [Display(Name = "Назва послуги")]
        public override string Title { get; set; }

        [Display(Name = "Короткий опис послуги")]
        public override string Subtitle { get; set; }

        [Display(Name = "Повний опис послуги")]
        public override string Text { get; set; }
    }
}
