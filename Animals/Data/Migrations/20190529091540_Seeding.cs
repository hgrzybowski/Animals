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

            migrationBuilder.Sql("INSERT INTO Products (Name,Price,Available,ShadeColor,ProductTypeId,SpecialTagsID) VALUES ('Karino',2222,1,'gray',1,1)");
            migrationBuilder.Sql("INSERT INTO Products (Name,Price,Available,ShadeColor,ProductTypeId,SpecialTagsID) VALUES ('Elpasso',5555,1,'biały',1,2)");
            migrationBuilder.Sql("INSERT INTO Products (Name,Price,Available,ShadeColor,ProductTypeId,SpecialTagsID) VALUES ('Opty',2545,1,'szary',2,1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DLETE FROM ProductTypes");
            
            migrationBuilder.Sql("DLETE FROM SpecialTags");
            migrationBuilder.Sql("DLETE FROM Products");
        }
    }
}
