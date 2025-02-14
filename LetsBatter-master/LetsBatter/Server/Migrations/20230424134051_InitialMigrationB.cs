using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsBatter.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Publishers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Publishers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Publishers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Publishers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Publishers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Condition",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PhotoID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PublisherID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Chats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ClientEmail",
                table: "Chats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Chats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ClientPhoneNumber",
                table: "Chats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ClientReferenceNumber",
                table: "Chats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Chats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "Chats",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActionType",
                table: "Analytics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BrowserFingerprint",
                table: "Analytics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CookieID",
                table: "Analytics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OfferType",
                table: "Analytics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Analytics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ReferrerUrl",
                table: "Analytics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "Analytics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_PublisherID",
                table: "Products",
                column: "PublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductID",
                table: "ProductImages",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductID",
                table: "ProductCategories",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chats_AdminID",
                table: "Chats",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ProductID",
                table: "Chats",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductCategoryId",
                table: "Categories",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_ProductID",
                table: "Analytics",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Analytics_Products_ProductID",
                table: "Analytics",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_ProductCategories_ProductCategoryId",
                table: "Categories",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Admins_AdminID",
                table: "Chats",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Products_ProductID",
                table: "Chats",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductID",
                table: "ProductCategories",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductID",
                table: "ProductImages",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Publishers_PublisherID",
                table: "Products",
                column: "PublisherID",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analytics_Products_ProductID",
                table: "Analytics");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_ProductCategories_ProductCategoryId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Admins_AdminID",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Products_ProductID",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductID",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductID",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Publishers_PublisherID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PublisherID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductID",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategories_ProductID",
                table: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_Chats_AdminID",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_ProductID",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ProductCategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Analytics_ProductID",
                table: "Analytics");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PhotoID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductCategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PublisherID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "ClientEmail",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "ClientPhoneNumber",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "ClientReferenceNumber",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ActionType",
                table: "Analytics");

            migrationBuilder.DropColumn(
                name: "BrowserFingerprint",
                table: "Analytics");

            migrationBuilder.DropColumn(
                name: "CookieID",
                table: "Analytics");

            migrationBuilder.DropColumn(
                name: "OfferType",
                table: "Analytics");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Analytics");

            migrationBuilder.DropColumn(
                name: "ReferrerUrl",
                table: "Analytics");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Analytics");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Admins");
        }
    }
}
