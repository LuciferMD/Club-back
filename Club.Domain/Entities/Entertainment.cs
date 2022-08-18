using System;
using System.Collections.Generic;
using System.Text;

namespace Club.Domain.Entities
{
    public class Entertainment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public DateTime Production_date { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
    }
}
