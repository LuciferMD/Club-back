using System;

namespace Club.Domain.Entities
{
    public class UserInfo
    {
        public Guid User_id { get; set; }
        public string Email { get; set; }
        public int Number_books { get; set; }
        public int Number_films { get; set; }
        public string Image { get; set; }

    }
}
