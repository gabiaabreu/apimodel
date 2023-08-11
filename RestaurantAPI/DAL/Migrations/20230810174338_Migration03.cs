using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Migration03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Clients",
                newName: "ClientStatus");
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Clients",
                newName: "ClientName");
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Clients",
                newName: "ClientAddress");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Restaurants",
                newName: "RestaurantName");
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Restaurants",
                newName: "RestaurantAddress");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Dishes",
                newName: "DishName");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Orders",
                newName: "OrderStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
        name: "ClientStatus",
        table: "Clients",
        newName: "Status");
            migrationBuilder.RenameColumn(
                name: "ClientName",
                table: "Clients",
                newName: "Name");
            migrationBuilder.RenameColumn(
                name: "ClientAddress",
                table: "Clients",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "RestaurantName",
                table: "Restaurants",
                newName: "Name");
            migrationBuilder.RenameColumn(
                name: "RestaurantAddress",
                table: "Restaurants",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "DishName",
                table: "Dishes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "OrderStatus",
                table: "Orders",
                newName: "Status");
        }
    }
}
