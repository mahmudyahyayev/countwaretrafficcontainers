﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountwareTraffic.Services.Events.Infrastructure.Migrations
{
    public partial class OutboxAddFieldsChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EventRecordId",
                schema: "event.app",
                table: "OutboxMessages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsTryFromQueue",
                schema: "event.app",
                table: "OutboxMessages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastException",
                schema: "event.app",
                table: "OutboxMessages",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventRecordId",
                schema: "event.app",
                table: "OutboxMessages");

            migrationBuilder.DropColumn(
                name: "IsTryFromQueue",
                schema: "event.app",
                table: "OutboxMessages");

            migrationBuilder.DropColumn(
                name: "LastException",
                schema: "event.app",
                table: "OutboxMessages");
        }
    }
}
