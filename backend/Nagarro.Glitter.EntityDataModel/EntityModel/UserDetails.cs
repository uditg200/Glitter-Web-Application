using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nagarro.Glitter.EntityDataModel.EntityModel
{
    public class UserDetails
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string  ProfileImage { get; set; }
        [Required]
        [MaxLength(10)]
        public string ContactNumber { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [EmailAddress]
        [Key]
        public string EmailId { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
