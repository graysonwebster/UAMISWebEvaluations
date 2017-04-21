using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _360Evaluation3.Models
{
    public class Question
    {
        // Primary Keys
        public int Id { get; set; }

        public string Text { get; set; }
        public bool IsRatingQuestion { get; set; }

        // Foreign Keys
        public int QuestionGroupId { get; set; }

        // Navigation Properties
        public virtual QuestionGroup QuestionGroup { get; set; }
    }
}