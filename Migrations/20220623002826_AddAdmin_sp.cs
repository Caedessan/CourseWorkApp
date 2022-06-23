using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseWorkApp.Migrations
{
    public partial class AddAdmin_sp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE AddAdminRights

                        @Username nvarchar(MAX)

                        AS

                        BEGIN
	
                        DECLARE @DynamicSQL nvarchar(MAX) = 'ALTER ROLE AdminRole ADD MEMBER ' + QUOTENAME(@Username)
	
                        EXEC (@DynamicSQL)

                        END";

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sql = @"DROP PROCEDURE AddAdminRights";

            migrationBuilder.Sql(sql);
        }
    }
}
