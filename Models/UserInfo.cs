using System.ComponentModel.DataAnnotations;

namespace MettingApp.Models{
    public class UserInfo{
        public int ID { get; set; }

        [Required(ErrorMessage = "Ad ve soyad alanı zorunludur.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon numarası zorunludur.")]
        [Phone(ErrorMessage ="Telefon numarasını uygun formatta girmeniz gerekmektedir.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Email adresi zorunludur.")]
        [EmailAddress(ErrorMessage ="Yanlış formatta mail adresi girdiniz. Lütfen Düzeltiniz.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Lütfen katılım durumunuzu belirtiniz.")]
        public bool? WillAttend { get; set; }
    }
}