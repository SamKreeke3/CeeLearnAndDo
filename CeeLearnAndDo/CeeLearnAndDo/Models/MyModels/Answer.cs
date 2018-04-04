using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models.MyModels
{
    public class Answer
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public Question Question { get; set; }
        public int QuestionId { get; set; }
        
        public ApplicationUser User { get; set; }
        public int UserId { get; set; } 
    }
}