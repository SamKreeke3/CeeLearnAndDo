using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models.MyModels
{
    public class Question
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public bool Published { get; set; }

        public string Answer { get; set; }

        [ScaffoldColumn(false)]
        public ApplicationUser User { get; set; }
        [ScaffoldColumn(false)]
        public string UserId { get; set; }
    }
}