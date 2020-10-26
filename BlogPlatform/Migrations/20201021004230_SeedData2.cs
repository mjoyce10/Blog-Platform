using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Event Discussion");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "What's in Your Bag?");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Tips & Tricks");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "PublishDate", "Title" },
                values: new object[] { "John Smith", "09/14/20", "2020 MVP Open at Maple Hill" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CategoryId", "PublishDate", "Title" },
                values: new object[] { "John Smith", 1, "10/04/20", "2020 Jonesboro Open" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "CategoryId", "PublishDate", "Title" },
                values: new object[] { "John Smith", 1, "10/19/20", "Disc Golf Pro Tour Championship" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 4, "John Smith", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.", 2, "10/15/20", "A Beginner's Bag" },
                    { 5, "Duke Goldberg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.", 2, "10/18/20", "My Must-Have Discs" },
                    { 6, "Doug Discman", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.", 2, "10/20/20", "My Bag isn't Big Enough!" },
                    { 7, "Darlene Discman", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.", 3, "10/10/20", "Start with a Few Discs" },
                    { 8, "John Smith", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.", 3, "10/16/20", "Disc Release - Flat and Low" },
                    { 9, "Duke Goldberg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.", 3, "10/20/20", "Develop a Practice Routine" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Category1");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Category2");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Category3");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "PublishDate", "Title" },
                values: new object[] { "Author1", "01/01/01", "Title1" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CategoryId", "PublishDate", "Title" },
                values: new object[] { "Author2", 2, "01/01/01", "Title2" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "CategoryId", "PublishDate", "Title" },
                values: new object[] { "Author3", 2, "01/01/01", "Title3" });
        }
    }
}
