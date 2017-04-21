using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _360Evaluation3.Models
{
    public class Answer
    {
        // Primary Key
        public int Id { get; set; }

        public string Response { get; set; }
        public int? Value { get; set; }

        // Foreign Keys
        public int RaterId { get; set; }
        public int? RateeId { get; set; }
        public int QuestionId { get; set; }

        // Navigation Properties
        public virtual User Rater { get; set; }
        public virtual User Ratee { get; set; }
        public virtual Question Question { get; set; }
    }
}