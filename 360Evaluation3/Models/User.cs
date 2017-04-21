using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _360Evaluation3.Models
{
    public class User
    {
        // Primary Key
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong CWID { get; set; }
        public bool IsProjectManager { get; set; }
        public bool IsFacultySponsor { get; set; }

        // Foreign Keys
        public int TeamId { get; set; }

        // Navigation Properties
        public virtual Team Team { get; set; }
    }
}