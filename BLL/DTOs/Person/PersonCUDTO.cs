using BLL.Helper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.DTOs.Person
{
    public class PersonCUDTO
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "ველი აუცილებელია")]
        [LanguageValidation(ErrorMessage = "უნდა შეიცავდეს სიმბოლოებს")]
        [StringLength(maximumLength:50, MinimumLength = 2, ErrorMessage = "ველი უნდა შეიცავდეს მინიმუმ 2 და მაქსიმუმ 50 სიმბოლოს")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "ველი აუცილებელია")]
        [LanguageValidation(ErrorMessage = "უნდა შეიცავდეს სიმბოლოებს")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "ველი უნდა შეიცავდეს მინიმუმ 2 და მაქსიმუმ 50 სიმბოლოს")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "ველი აუცილებელია")]
        [DataType(DataType.Date)]
        [MinimumAge(min:18, ErrorMessage = "პირი უნდა იყოს მინიმუმ 18 წლის")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "ველი აუცილებელია")]
        public int GenderId { get; set; }

        [Required(ErrorMessage = "ველი აუცილებელია")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "ველი უნდა შეიცავდეს 11 სიმბოლოს")]
        [RegularExpression("^[0-9]*", ErrorMessage = "ველი უნდა შეიცავდეს მხოლოდ ციფრებს")]
        public string PersonalNumber { get; set; }

        [Required(ErrorMessage = "ველი აუცილებელია")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ველი აუცილებელია")]
        public int PositionId { get; set; }

        public string Picture { get; set; }

        public IFormFile File { get; set; }

        public IList<PhoneDTO> Phones{ get; set; }

    }
}
