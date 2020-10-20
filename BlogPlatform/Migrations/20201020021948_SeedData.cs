using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Category1" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Category2" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Category3" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 1, "Author1", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.", 1, "01/01/01", "Title1" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 2, "Author2", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.", 2, "01/01/01", "Title2" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 3, "Author3", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.", 2, "01/01/01", "Title3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
