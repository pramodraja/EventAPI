﻿// <auto-generated />
using System;
using EventAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventDAL.Migrations
{
    [DbContext(typeof(EventContext))]
    partial class EventContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventAPI.Models.Event", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Notes");

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Date = new DateTime(2019, 10, 25, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "monthly commitee meeting of board of directors",
                            Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.  Quis auctor elit sed vulputate mi sit. A iaculis at erat pellentesque adipiscing commodo elit. Volutpat ac tincidunt vitae semper quis. Fringilla urna porttitor rhoncus dolor purus non enim praesent elementum. Quam nulla porttitor massa id neque aliquam vestibulum morbi blandit.",
                            Title = "Commitee Meeting"
                        },
                        new
                        {
                            Id = 2L,
                            Date = new DateTime(2019, 10, 5, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            Description = "Annual Fund raising event",
                            Notes = "Eu feugiat pretium nibh ipsum consequat. Integer feugiat scelerisque varius morbi enim nunc faucibus. Pellentesque elit ullamcorper dignissim cras tincidunt lobortis. Dui accumsan sit amet nulla facilisi morbi tempus iaculis urna.",
                            Title = "Annual Charity"
                        },
                        new
                        {
                            Id = 3L,
                            Date = new DateTime(2019, 11, 2, 8, 15, 0, 0, DateTimeKind.Unspecified),
                            Description = "API Project progress meeting",
                            Notes = "Ut porttitor leo a diam. Placerat duis ultricies lacus sed turpis tincidunt id aliquet risus. Fermentum et sollicitudin ac orci phasellus egestas. Id aliquet risus feugiat in ante metus dictum at tempor. Aliquam purus sit amet luctus venenatis lectus.",
                            Title = "Project Meeting"
                        },
                        new
                        {
                            Id = 4L,
                            Date = new DateTime(2019, 11, 2, 8, 15, 0, 0, DateTimeKind.Unspecified),
                            Description = "Event 4 description",
                            Notes = "Sapien faucibus et molestie ac. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique senectus. Viverra vitae congue eu consequat ac felis donec et. Nec nam aliquam sem et tortor. Aliquam nulla facilisi cras fermentum odio eu.",
                            Title = "Event 4"
                        },
                        new
                        {
                            Id = 5L,
                            Date = new DateTime(2019, 11, 2, 8, 15, 0, 0, DateTimeKind.Unspecified),
                            Description = "Event 5 description",
                            Notes = "Ullamcorper eget nulla facilisi etiam. Turpis egestas maecenas pharetra convallis posuere morbi leo urna. Elementum integer enim neque volutpat ac tincidunt vitae semper. Tristique magna sit amet purus gravida quis blandit.",
                            Title = "Event 5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
