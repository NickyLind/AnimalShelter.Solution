using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Description", "Gender", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 9, "Chocoloate Lab", "Spayed, needs a loving home with older childred/no children", "Female", "Ted", "Cat" },
                    { 2, 2, "Pug", "Neutered, spunky and likes a lot of attention", "Male", "Bradley", "Dog" },
                    { 3, 3, "Husky", "Neutered, needs a LOT of exercise", "Male", "Ghost", "Dog" },
                    { 4, 1, "Australian Shepherd", "BNeutered, needs to be given tasks for feel important", "Male", "Sparky", "Dog" },
                    { 5, 9, "Persian", "Spayed, Very shy. Better suited to a home with no/older children", "Female", "Molly", "Cat" },
                    { 6, 1, "Tabby(Orange)", "Neutered, very active loves to play", "Male", "Jose", "Cat" },
                    { 7, 3, "Great Dane", "Neutered, dumb sweetheart. Needs a lot of room to move around", "Male", "Thor", "Dog" },
                    { 8, 2, "Chocoloate Lab", "Spayed, loves playing fetch and being active", "Female", "Charlie", "Dog" },
                    { 9, 2, "Calico", "Spayed, waiting for owner pickup", "Female", "Chloe", "Cat" },
                    { 10, 9, "English Bulldog", "Neutered, will need surgery on knees and potentially nose", "Male", "Rocket", "Dog" },
                    { 11, 4, "Persian", "Spayed, loves sleeping doesn't mind children", "Female", "Tina Turner", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);
        }
    }
}
