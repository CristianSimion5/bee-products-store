using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Polifloris.Models
{
    public class Order
    {
        [Key]
        [BindNever]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderLines { get; set; }
        
        [Display(Name = "Prenume", Prompt = "ex: Tudor")]
        [StringLength(50)]
        [Required(ErrorMessage = "Vă rugăm să vă introduceți prenumele")]
        public string FirstName { get; set; }

        [Display(Name = "Nume", Prompt = "ex: Popescu")]
        [StringLength(50)]
        [Required(ErrorMessage = "Vă rugăm să vă introduceți numele")]
        public string LastName { get; set; }

        [Display(Name = "Adresă", Prompt = "ex: Strada, numar, bloc, scara, etaj, apartament")]
        [StringLength(100)]
        [Required(ErrorMessage = "Vă rugăm să vă introduceți adresa")]
        public string Address { get; set; }

        [Display(Name = "Oraș", Prompt = "ex: Brașov")]
        [StringLength(100)]
        [Required(ErrorMessage = "Vă rugăm să vă introduceți orașul")]
        public string City { get; set; }

        [Display(Name = "Județ", Prompt = "ex: Ialomița")]
        [StringLength(100)]
        [Required(ErrorMessage = "Vă rugăm să vă introduceți județul")]
        public string Region { get; set; }

        [Display(Name = "Număr telefon", Prompt = "07xxxxxxxx")]
        [StringLength(12, MinimumLength = 10, ErrorMessage = "Numărul de telefon este prea scurt")]
        [Required(ErrorMessage = "Vă rugăm să vă introduceți numărul de telefon")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Adresă email", Prompt = "adresa@exemplu.com")]
        [StringLength(50)]
        [Required(ErrorMessage = "Vă rugăm să vă introduceți adresa de email")]
        [EmailAddress]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "Adresa de email nu are formatul corect!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
