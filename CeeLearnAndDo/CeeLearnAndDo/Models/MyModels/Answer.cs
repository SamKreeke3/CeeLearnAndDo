using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models.MyModels
{
    public class Answer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Question Question { get; set; }

        [Required]
        public int QuestionId { get; set; }
        
        public ApplicationUser User { get; set; }
        public string UserId { get; set; } 
    }
}