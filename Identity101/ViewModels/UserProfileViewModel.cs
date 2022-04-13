﻿using System.ComponentModel.DataAnnotations;

namespace Identity101.ViewModels
{
    public class UserProfileViewModel
    {
        [Required(ErrorMessage = "Ad alanı gereklidir")]
        [Display(Name = "Ad")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı gereklidir")]
        [Display(Name = "Soyad")]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "E-posta alanı gereklidir")]
        [Display(Name = "E-posta")]
        public string Email { get; set; }
    }
}
