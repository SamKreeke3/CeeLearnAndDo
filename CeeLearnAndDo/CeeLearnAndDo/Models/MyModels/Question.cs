using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models.MyModels
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Published { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}