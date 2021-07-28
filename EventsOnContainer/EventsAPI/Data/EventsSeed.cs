using EventsAPI.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAPI.Data
{
    public static class EventsSeed
    {
        public static void Seed(EventsContext eventsContext)
        {
            eventsContext.Database.Migrate();

            if(!eventsContext.EventHosts.Any())
            {
                eventsContext.EventHosts.AddRange(GetEventsHosts());
                eventsContext.SaveChanges();
            }
            if (!eventsContext.EventTypes.Any())
            {
                eventsContext.EventTypes.AddRange(GetEventsType());
                eventsContext.SaveChanges();
            }
            if (!eventsContext.Locations.Any())
            {
                eventsContext.Locations.AddRange(GetEventsLocations());
                eventsContext.SaveChanges();
            }
            if (!eventsContext.Events.Any())
            {
                eventsContext.Events.AddRange(GetEvents());
                eventsContext.SaveChanges();
            }
        }

        private static IEnumerable<Location> GetEventsLocations()
        {
            return new List<Location>
            {
                new Location
                {
                    Lat = 47.6062M,
                    Lon = -122.33207M,
                    City = "Seattle",
                    State = "WA"
                },
                new Location
                {
                    Lat = 47.6739M,
                    Lon =  -122.1215M,
                    City = "Redmond",
                    State = "WA"
                },
                new Location
                {
                    Lat = 47.7623M,
                    Lon = -122.2054M,
                    City = "Bothell",
                    State = "WA"
                },
                new Location
                {
                    Lat = 47.6814M,
                    Lon = -122.2087M,
                    City = "Kirkland",
                    State = "WA"
                },
                new Location
                {
                    Lat = 47.6103M,
                    Lon = -122.2006M,
                    City = "Bellevue",
                    State = "WA"
                }
            };
        }

        private static IEnumerable<Event> GetEvents()
        {
            return new List<Event>
            {
                new Event
                {
                    EventsTypeId = 3,
                    EventCreaterId = 1,
                    LocationId = 1,
                    Description="Seattle Tech Career Fair:Exclusive Tech Hiring Event-New",
                    Name="Tech Career Fair",
                    Price=50.9M,PictureUrl="http://externaleventsbaseurltobereplaced/api/pic/1",
                    StartTime=new DateTime(2021,08,15,5,10,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,15,6,10,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 3,
                    EventCreaterId = 2,
                    LocationId = 1,
                    Description="Develop a Successful GreenTech / CleanTech Startup Business Today",
                    Name="GreenTech / CleanTech",
                    Price=50.9M,PictureUrl="http://externaleventsbaseurltobereplaced/api/pic/2",
                    StartTime=new DateTime(2021,08,16,5,10,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,16,6,10,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 3,
                    EventCreaterId = 3,
                    LocationId = 3,
                    Description="Thinkful Webinar | Getting Started in Tech",
                    Name="Getting Started in Tech",
                    Price=50.9M,PictureUrl="http://externaleventsbaseurltobereplaced/api/pic/3",
                    StartTime=new DateTime(2021,08,17,5,10,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,17,6,10,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 3,
                    EventCreaterId = 2,
                    LocationId = 4,
                    Description="Develop a Successful Healthcare Tech Startup Business Hackathon | Healthcare Tech Entrepreneurship Workshop | Medtech Entrepreneur Training",
                    Name="Healthcare Tech Startup Business",
                    Price=50.9M,PictureUrl="http://externaleventsbaseurltobereplaced/api/pic/4",
                    StartTime=new DateTime(2021,08,18,5,10,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,18,6,10,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 3,
                    EventCreaterId = 2,
                    LocationId = 3,
                    Description="Develop a Successful Food Tech Startup Business Hackathon | Startup Hackathon | Entrepreneur Hackathon | Entrepreneurship Hackathon",
                    Name="Food Tech Startup Business",
                    Price=50.9M,PictureUrl="http://externaleventsbaseurltobereplaced/api/pic/5",
                    StartTime=new DateTime(2021,08,19,5,10,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,19,6,10,20,DateTimeKind.Local),
                },
                               
                new Event
                {
                    Description = "Cooking Class ~ Homemade Tomato Risotto with Burrata and Basil ",
                    Name = " Tomato Risotto with Burrata and Basil",
                    Price = 5,
                    StartTime = new DateTime(2021, 9, 18, 16, 0, 0, DateTimeKind.Local),
                    EndTime = new DateTime(2021, 9, 18, 16, 0, 0, DateTimeKind.Local),
                    EventCreaterId = 6,
                    EventsTypeId = 5,
                    LocationId = 1,
                    PictureUrl = ""
                },
                new Event
                {
                    Description = "Cooking Class ~ Jambalaya with Saffron Aioli! Presented with our Buddies at SCANPAN & GLOBAL Cutlery",
                    Name = "Jambalaya with Saffron Aioli",
                    Price = 3,
                    StartTime = new DateTime(2021, 9, 9, 16, 0, 0, DateTimeKind.Local),
                    EndTime = new DateTime(2021, 9, 9, 16, 0, 0, DateTimeKind.Local),
                    EventCreaterId = 6,
                    EventsTypeId = 5,
                    LocationId = 1,
                    PictureUrl = ""
                },
                new Event
                {
                    Description = "Cooking Class ~ Vegan Pie with Sudha",
                    Name = "Vegan Pie",
                    Price = 5,
                    StartTime = new DateTime(2021, 9, 15, 16, 0, 0, DateTimeKind.Local),
                    EndTime = new DateTime(2021, 9, 15, 16, 0, 0, DateTimeKind.Local),
                    EventCreaterId = 6,
                    EventsTypeId = 5,
                    LocationId = 1,
                    PictureUrl = ""
                },
                new Event
                {
                    Description =" More and more people are interested in vegan/plant-based eating. Some are just curious, some want to get their feet wet, and some are ready to come to the V-side - ",
                    Name = "Vegan For Beginners",
                    Price = 3,
                    StartTime = new DateTime(2021, 9, 18, 17,0,0,DateTimeKind.Local),
                    EndTime = new DateTime(2021, 9, 18, 18,0,0,DateTimeKind.Local),
                    EventCreaterId = 7,
                    EventsTypeId = 5,
                    LocationId = 1,
                    PictureUrl = ""
                },
                new Event
                {
                    Description ="Homemade Free Cooking Class ~ Cheese Soufflé and Summer Salad with Green Goddess Dressing, with our Buddies at Cabot Cheese ",
                    Name = "Cheese Soufflé and Summer Salad",
                    Price = 0,
                    StartTime = new DateTime(2021, 9, 28, 16,0,0,DateTimeKind.Local),
                    EndTime = new DateTime(2021, 9, 28, 17,0,0,DateTimeKind.Local),
                    EventCreaterId = 6,
                    EventsTypeId = 5,
                    LocationId = 1,
                    PictureUrl = ""
                }

            };
        }

        private static IEnumerable<EventsType> GetEventsType()
        {
            return new List<EventsType>
            {
                new EventsType
                {
                    Type="For Kids"
                },
                new EventsType
                {
                    Type = "Fittness&Health"
                },
                new EventsType
                {
                    Type = "Technology"
                },
                new EventsType
                {
                    Type = "Art"
                },
                new EventsType
                {
                    Type = "Food&Drink"
                }
            };
        }

        private static IEnumerable<EventsHost> GetEventsHosts()
        {
            return new List<EventsHost>
            {
                new EventsHost
                {
                    Creater = "Tech Career Fair"
                },
                new EventsHost
                {
                    Creater = "Atechup.com"
                },
                new EventsHost
                {
                    Creater = "Thinkful Seattle"
                },
                new EventsHost
                {
                    Creater = "Women Hack"
                },
                new EventsHost
                {
                    Creater = " AnalyticsWEEK"
                },
                new EventsHost
                {
                    Creater = "Nola Ro"
                },
                new EventsHost
                {
                    Creater = "Homemade Events"
                }
            };
        }
    }
}
