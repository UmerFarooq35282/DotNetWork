using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThirdSemesterProject.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public string ClientName { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        [Remote("SignUpClient", "SignUp")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please enter a valid email address")]
        public string ClientEmail { get; set; } = string.Empty;

        public string ClientPhoto { get; set; } = string.Empty;
        [Required]
        public string ClientAddress { get; set; } = string.Empty;
        [Required]
        public string ClientPhone { get; set; } = string.Empty;
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string ClientPassword { get; set; } = string.Empty;
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("ClientPassword")]
        [DataType(DataType.Password)]
        public string ClientCPassword { get; set; } = string.Empty;
    }
}