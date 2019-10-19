using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EventAPI.Models
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(
                new Event 
                    {
                        Id = 1,
                        Title = "Commitee Meeting",
                        Date = DateTime.Parse("10-25-2019 10:00"),
                        Description = "monthly commitee meeting of board of directors",
                        Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                                " Quis auctor elit sed vulputate mi sit. A iaculis at erat pellentesque adipiscing commodo elit. Volutpat ac tincidunt vitae semper quis. " +
                                "Fringilla urna porttitor rhoncus dolor purus non enim praesent elementum. Quam nulla porttitor massa id neque aliquam vestibulum morbi blandit."

                }, 
                new Event
                    {
                        Id = 2,
                        Title = "Annual Charity",
                        Date = DateTime.Parse("10-05-2019 12:30"),
                        Description = "Annual Fund raising event",
                        Notes = "Eu feugiat pretium nibh ipsum consequat. Integer feugiat scelerisque varius morbi enim nunc faucibus. " +
                                "Pellentesque elit ullamcorper dignissim cras tincidunt lobortis. Dui accumsan sit amet nulla facilisi morbi tempus iaculis urna."
                },
                new Event
                {
                    Id = 3,
                    Title = "Project Meeting",
                    Date = DateTime.Parse("11-02-2019 08:15"),
                    Description = "API Project progress meeting",
                    Notes = "Ut porttitor leo a diam. Placerat duis ultricies lacus sed turpis tincidunt id aliquet risus. Fermentum et sollicitudin ac orci phasellus egestas. " +
                            "Id aliquet risus feugiat in ante metus dictum at tempor. Aliquam purus sit amet luctus venenatis lectus."
                },
                new Event
                {
                    Id = 4,
                    Title = "Event 4",
                    Date = DateTime.Parse("11-02-2019 08:15"),
                    Description = "Event 4 description",
                    Notes = "Sapien faucibus et molestie ac. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique senectus. " +
                            "Viverra vitae congue eu consequat ac felis donec et. Nec nam aliquam sem et tortor. Aliquam nulla facilisi cras fermentum odio eu."
                },
                new Event
                {
                    Id = 5,
                    Title = "Event 5",
                    Date = DateTime.Parse("11-02-2019 08:15"),
                    Description = "Event 5 description",
                    Notes = "Ullamcorper eget nulla facilisi etiam. Turpis egestas maecenas pharetra convallis posuere morbi leo urna. Elementum integer enim neque volutpat ac tincidunt vitae semper. " +
                            "Tristique magna sit amet purus gravida quis blandit."
                }

                );
        }
    }
}
