using System;
using System.Collections.Generic;
using System.Text;

namespace Club.Domain.Entities
{
    public class Review
    {
        public Guid Id { get; set; }
        public Guid User_id { get; set; }
        public Guid Enter_id { get; set; }
        public int Rating { get; set; }
        public string Text { get; set; }
    }
}
