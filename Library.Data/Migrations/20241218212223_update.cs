using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowList_SubscribeList_SubscriberSubscribeID",
                table: "BorrowList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscribeList",
                table: "SubscribeList");

            migrationBuilder.DropIndex(
                name: "IX_BorrowList_SubscriberSubscribeID",
                table: "BorrowList");

            migrationBuilder.DropColumn(
                name: "SubscriberSubscribeID",
                table: "BorrowList");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SubscribeList",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "SubscribeID",
                table: "SubscribeList",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "SubscriberId",
                table: "BorrowList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscribeList",
                table: "SubscribeList",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowList_SubscriberId",
                table: "BorrowList",
                column: "SubscriberId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowList_SubscribeList_SubscriberId",
                table: "BorrowList",
                column: "SubscriberId",
                principalTable: "SubscribeList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowList_SubscribeList_SubscriberId",
                table: "BorrowList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscribeList",
                table: "SubscribeList");

            migrationBuilder.DropIndex(
                name: "IX_BorrowList_SubscriberId",
                table: "BorrowList");

            migrationBuilder.DropColumn(
                name: "SubscriberId",
                table: "BorrowList");

            migrationBuilder.AlterColumn<string>(
                name: "SubscribeID",
                table: "SubscribeList",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SubscribeList",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "SubscriberSubscribeID",
                table: "BorrowList",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscribeList",
                table: "SubscribeList",
                column: "SubscribeID");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowList_SubscriberSubscribeID",
                table: "BorrowList",
                column: "SubscriberSubscribeID");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowList_SubscribeList_SubscriberSubscribeID",
                table: "BorrowList",
                column: "SubscriberSubscribeID",
                principalTable: "SubscribeList",
                principalColumn: "SubscribeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
