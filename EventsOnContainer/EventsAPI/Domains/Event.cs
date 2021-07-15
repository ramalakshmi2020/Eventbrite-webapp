using EventsAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAPI.Domains
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int LocationId { get; set; }
        public int EventsTypeId { get; set; }
        public int EventCreaterId { get; set; }

        public virtual Location Location { get; set; }
        public virtual EventsType EventsType { get; set; }

        public virtual EventsHost EventsCreater { get; set; }

    }
}
