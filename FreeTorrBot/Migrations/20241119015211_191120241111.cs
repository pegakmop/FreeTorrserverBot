﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdTorrBot.Migrations
{
    /// <inheritdoc />
    public partial class _191120241111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CacheSizeInBytes",
                table: "BitTorrConfig");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CacheSizeInBytes",
                table: "BitTorrConfig",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
