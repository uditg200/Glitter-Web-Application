using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nagarro.Glitter.EntityDataModel.EntityModel
{
    public class TweetDetails
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string ProfileImage { get; set; }
        [Required]
        public string TweetDescription { get; set; }
        [Required]
        public string CreatedAt { get; set; }
        public int NoOfLikes { get; set; }
    }
}
