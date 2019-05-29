using Microsoft.EntityFrameworkCore.Migrations;

namespace Animals.Data.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
  
            migrationBuilder.Sql("INSERT INTO SpecialTags (Name) VALUES ('siodlo')");
            migrationBuilder.Sql("INSERT INTO ProductTypes (Name) VALUES ('arab')");
            migrationBuilder.Sql("INSERT INTO SpecialTags (Name) VALUES ('zaprzęg')");
            migrationBuilder.Sql("INSERT INTO ProductTypes (Name) VALUES ('krwi angielskiej')");

            //migrationBuilder.Sql("INSERT INTO Products (Name,Price,Available,ProductTypeId,SpecialTagsID) VALUES ('Karino',2,1,1,1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DLETE FROM ProductTypes");
            
            migrationBuilder.Sql("DLETE FROM SpecialTags");
            //migrationBuilder.Sql("DLETE FROM Products");
        }
    }
}
