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
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','magda',22222,'g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','henryk',22222,'d21g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','domi',22222,'c31g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','gabi',22222,'b41g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','wiki',22222,'g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','ABC',22222,'d21g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','DEF',22222,'c31g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','JGH',22222,'b41g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','magda',22222,'g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','henryk',22222,'d21g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','domi',22222,'c31g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','gabi',22222,'b41g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','wiki',22222,'g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','ABC',22222,'d21g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','DEF',22222,'c31g@gmail.com',1)");
            migrationBuilder.Sql("INSERT INTO Appointments (AppointmentDate,CustomerName,CustomerPhoneNumber,CustomerEmail,isConfirmed) VALUES ('2019-05-27','JGH',22222,'b41g@gmail.com',1)");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DLETE FROM ProductTypes");
            
            migrationBuilder.Sql("DLETE FROM SpecialTags");
            migrationBuilder.Sql("DLETE FROM Products");
            migrationBuilder.Sql("DLETE FROM Appointments");
        }
    }
}
