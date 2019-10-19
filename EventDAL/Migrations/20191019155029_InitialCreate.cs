using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventDAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "Notes", "Title" },
                values: new object[,]
                {
                    { 1L, new DateTime(2019, 10, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), "monthly commitee meeting of board of directors", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.  Quis auctor elit sed vulputate mi sit. A iaculis at erat pellentesque adipiscing commodo elit. Volutpat ac tincidunt vitae semper quis. Fringilla urna porttitor rhoncus dolor purus non enim praesent elementum. Quam nulla porttitor massa id neque aliquam vestibulum morbi blandit.", "Commitee Meeting" },
                    { 2L, new DateTime(2019, 10, 5, 12, 30, 0, 0, DateTimeKind.Unspecified), "Annual Fund raising event", "Eu feugiat pretium nibh ipsum consequat. Integer feugiat scelerisque varius morbi enim nunc faucibus. Pellentesque elit ullamcorper dignissim cras tincidunt lobortis. Dui accumsan sit amet nulla facilisi morbi tempus iaculis urna.", "Annual Charity" },
                    { 3L, new DateTime(2019, 11, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), "API Project progress meeting", "Ut porttitor leo a diam. Placerat duis ultricies lacus sed turpis tincidunt id aliquet risus. Fermentum et sollicitudin ac orci phasellus egestas. Id aliquet risus feugiat in ante metus dictum at tempor. Aliquam purus sit amet luctus venenatis lectus.", "Project Meeting" },
                    { 4L, new DateTime(2019, 11, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), "Event 4 description", "Sapien faucibus et molestie ac. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique senectus. Viverra vitae congue eu consequat ac felis donec et. Nec nam aliquam sem et tortor. Aliquam nulla facilisi cras fermentum odio eu.", "Event 4" },
                    { 5L, new DateTime(2019, 11, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), "Event 5 description", "Ullamcorper eget nulla facilisi etiam. Turpis egestas maecenas pharetra convallis posuere morbi leo urna. Elementum integer enim neque volutpat ac tincidunt vitae semper. Tristique magna sit amet purus gravida quis blandit.", "Event 5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
