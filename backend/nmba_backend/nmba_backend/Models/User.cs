using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nmba_backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Status { get; set; }
        public Guid RegistrationSlug {get; set;}

        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<Qna> Qnas { get; set; }



    }
}