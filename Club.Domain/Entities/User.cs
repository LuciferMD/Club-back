using System;
using System.Collections.Generic;
using System.Text;

namespace Club.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
