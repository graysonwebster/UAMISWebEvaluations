using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _360Evaluation3.Models
{
    public class Team
    {
        // Primary Key
        public int Id { get; set; }

        public string Name { get; set; }

        // Foreign Keys
        public int ClientId { get; set; }

        // Navigation Properties
        public virtual Client Client { get; set; }
    }
}