using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseWorkApp.Migrations
{
    public partial class AddUser_sp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE AddUser

                        @Username nvarchar(MAX),

                        @Password nvarchar(MAX)

                        AS

                        BEGIN

	                        DECLARE @DynamicSQL nvarchar(MAX) = 'CREATE LOGIN ' + QUOTENAME(@Username) + ' WITH PASSWORD = ' + QUOTENAME(@Password,'''') 

	                        EXEC (@DynamicSQL)

	                        SET @DynamicSQL = 'CREATE USER ' + QUOTENAME(@Username) + ' FOR LOGIN ' + QUOTENAME(@Username)

	                        EXEC (@DynamicSQL)

	                        SET @DynamicSQL = 'ALTER ROLE UserRole ADD MEMBER ' + QUOTENAME(@Username)

	                        EXEC (@DynamicSQL)

                        END";

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sql = @"DROP PROCEDURE AddUser";

            migrationBuilder.Sql(sql);
        }
    }
}
