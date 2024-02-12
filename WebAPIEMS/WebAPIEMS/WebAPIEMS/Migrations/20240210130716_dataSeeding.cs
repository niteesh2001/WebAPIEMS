using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIEMS.Migrations
{
    public partial class dataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DeptMaster",
                columns: new[] { "DeptCode", "DeptName" },
                values: new object[,]
                {
                    { 1, "Human Resources" },
                    { 2, "Finance" },
                    { 3, "IT" },
                    { 4, "Marketing" },
                    { 5, "Sales" }
                });

            migrationBuilder.InsertData(
                table: "EmpProfile",
                columns: new[] { "EmpCode", "DateOfBirth", "DeptCode", "DeptMasterDeptCode", "Email", "EmpName" },
                values: new object[,]
                {
                    { 101, new DateTime(1985, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "johndoe@example.com", "John Doe" },
                    { 102, new DateTime(1990, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "janedoe@example.com", "Jane Doe" },
                    { 103, new DateTime(1988, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "jimbeam@example.com", "Jim Beam" },
                    { 104, new DateTime(1992, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "jackdaniels@example.com", "Jack Daniels" },
                    { 105, new DateTime(1986, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "josecuervo@example.com", "Jose Cuervo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 105);
        }
    }
}
