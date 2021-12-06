using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "module",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    module_key = table.Column<int>(nullable: false),
                    code = table.Column<string>(maxLength: 15, nullable: true),
                    display_order = table.Column<int>(nullable: false),
                    display_icon = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_module", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "organization",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    organization_name = table.Column<string>(maxLength: 50, nullable: false),
                    short_name = table.Column<string>(maxLength: 20, nullable: true),
                    description = table.Column<string>(maxLength: 300, nullable: true),
                    address = table.Column<string>(maxLength: 50, nullable: true),
                    contact_no = table.Column<string>(maxLength: 15, nullable: true),
                    email = table.Column<string>(maxLength: 30, nullable: true),
                    pan_no = table.Column<string>(maxLength: 15, nullable: true),
                    logo = table.Column<string>(nullable: true),
                    contact_person = table.Column<string>(maxLength: 15, nullable: true),
                    latitude = table.Column<string>(nullable: true),
                    longitude = table.Column<string>(nullable: true),
                    facebook_url = table.Column<string>(nullable: true),
                    twitter_url = table.Column<string>(nullable: true),
                    instagram_url = table.Column<string>(nullable: true),
                    youtube_url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "organizer",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    orgname = table.Column<string>(nullable: false),
                    orgaddress = table.Column<string>(nullable: false),
                    org_phone_no = table.Column<string>(nullable: false),
                    orgemail = table.Column<string>(nullable: false),
                    is_active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organizer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    fullname = table.Column<string>(nullable: false),
                    address = table.Column<string>(nullable: false),
                    phone_no = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    dob = table.Column<DateTime>(nullable: false),
                    is_active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: false),
                    username = table.Column<string>(maxLength: 50, nullable: false),
                    password = table.Column<string>(maxLength: 250, nullable: false),
                    registration_token = table.Column<string>(maxLength: 1000, nullable: true),
                    is_active = table.Column<bool>(nullable: false),
                    is_email_confirmed = table.Column<bool>(nullable: false),
                    password_change_count = table.Column<int>(nullable: false),
                    access_failed_count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user_loggedin_status_setup",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    user_id = table.Column<long>(nullable: false),
                    is_user_logged_in = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_loggedin_status_setup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user_role",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    is_enabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    module_id = table.Column<long>(nullable: false),
                    parent_menu_id = table.Column<long>(nullable: true),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    display_icon = table.Column<string>(maxLength: 20, nullable: true),
                    web_url = table.Column<string>(maxLength: 100, nullable: false),
                    api_url = table.Column<string>(maxLength: 100, nullable: true),
                    display_order = table.Column<int>(nullable: false),
                    is_active = table.Column<bool>(nullable: false),
                    is_visible_to_menu = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_menu_module_module_id",
                        column: x => x.module_id,
                        principalTable: "module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_menu_menu_parent_menu_id",
                        column: x => x.parent_menu_id,
                        principalTable: "menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "organization_module_map",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    module_id = table.Column<long>(nullable: false),
                    organization_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organization_module_map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_organization_module_map_module_module_id",
                        column: x => x.module_id,
                        principalTable: "module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_organization_module_map_organization_organization_id",
                        column: x => x.organization_id,
                        principalTable: "organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "seminar",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    org_id = table.Column<long>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    types = table.Column<int>(nullable: false),
                    is_active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seminar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_seminar_organizer_org_id",
                        column: x => x.org_id,
                        principalTable: "organizer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "jwt_tokens",
                columns: table => new
                {
                    jwt_token_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<long>(nullable: false),
                    old_token = table.Column<string>(maxLength: 50, nullable: false),
                    new_token = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jwt_tokens", x => x.jwt_token_id);
                    table.ForeignKey(
                        name: "FK_jwt_tokens_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_details",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<long>(nullable: false),
                    first_name = table.Column<string>(maxLength: 50, nullable: false),
                    last_name = table.Column<string>(maxLength: 50, nullable: false),
                    permanent_address = table.Column<string>(maxLength: 100, nullable: false),
                    temporary_address = table.Column<string>(maxLength: 100, nullable: true),
                    primary_contact = table.Column<string>(maxLength: 15, nullable: false),
                    secondary_contact = table.Column<string>(maxLength: 15, nullable: true),
                    image = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_details_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "role_permission_map",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    role_id = table.Column<long>(nullable: false),
                    permissions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role_permission_map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_role_permission_map_user_role_role_id",
                        column: x => x.role_id,
                        principalTable: "user_role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_role_map",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    user_id = table.Column<long>(nullable: false),
                    role_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_role_map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_role_map_user_role_role_id",
                        column: x => x.role_id,
                        principalTable: "user_role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_role_map_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "menu_permission_map",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    menu_id = table.Column<long>(nullable: false),
                    permissions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu_permission_map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_menu_permission_map_menu_menu_id",
                        column: x => x.menu_id,
                        principalTable: "menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "role_menu_map",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    role_id = table.Column<long>(nullable: false),
                    menu_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role_menu_map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_role_menu_map_menu_menu_id",
                        column: x => x.menu_id,
                        principalTable: "menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_role_menu_map_user_role_role_id",
                        column: x => x.role_id,
                        principalTable: "user_role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "register",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    student_id = table.Column<long>(nullable: false),
                    seminar_id = table.Column<long>(nullable: false),
                    attendance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_register", x => x.Id);
                    table.ForeignKey(
                        name: "FK_register_seminar_seminar_id",
                        column: x => x.seminar_id,
                        principalTable: "seminar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_register_student_student_id",
                        column: x => x.student_id,
                        principalTable: "student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "module",
                columns: new[] { "Id", "code", "created_by", "created_date", "display_icon", "display_order", "is_deleted", "modified_by", "modified_date", "module_key", "name" },
                values: new object[,]
                {
                    { 1L, null, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 650, DateTimeKind.Local).AddTicks(813), null, 0, false, null, null, 1, "User Management" },
                    { 2L, null, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 652, DateTimeKind.Local).AddTicks(1679), null, 0, false, null, null, 1, "CMS" }
                });

            migrationBuilder.InsertData(
                table: "organization",
                columns: new[] { "Id", "address", "contact_no", "contact_person", "created_by", "created_date", "description", "email", "facebook_url", "instagram_url", "is_deleted", "latitude", "logo", "longitude", "modified_by", "modified_date", "organization_name", "pan_no", "short_name", "twitter_url", "youtube_url" },
                values: new object[] { 1L, null, null, null, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 654, DateTimeKind.Local).AddTicks(3546), null, null, null, null, false, null, null, null, null, null, "Smart CMS", null, null, null, null });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "access_failed_count", "created_by", "created_date", "email", "is_active", "is_deleted", "is_email_confirmed", "modified_by", "modified_date", "password", "password_change_count", "registration_token", "username" },
                values: new object[] { 1L, 0, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 655, DateTimeKind.Local).AddTicks(5537), "admin@gmail.com", true, false, true, null, null, "1000:Q0OssukdAhOuAr8VRDN99CXP67LM3wFl:b4mKfWiU1y67bhEpjsolYhV5aP1bVNzC", 0, null, "admin" });

            migrationBuilder.InsertData(
                table: "user_role",
                columns: new[] { "Id", "created_by", "created_date", "is_deleted", "is_enabled", "modified_by", "modified_date", "name" },
                values: new object[] { 1L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 655, DateTimeKind.Local).AddTicks(22), false, true, null, null, "Admin" });

            migrationBuilder.InsertData(
                table: "menu",
                columns: new[] { "Id", "api_url", "created_by", "created_date", "display_icon", "display_order", "is_active", "is_deleted", "is_visible_to_menu", "modified_by", "modified_date", "module_id", "name", "parent_menu_id", "web_url" },
                values: new object[,]
                {
                    { 1L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(593), "", 1, true, false, true, null, null, 1L, "User", null, "/usermanagement/user/index" },
                    { 115L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8446), "", 3, true, false, true, null, null, 2L, "Setup", null, "#" },
                    { 74L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8299), "", 1, true, false, true, null, null, 2L, "Others", null, "#" },
                    { 68L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8277), "", 7, true, false, true, null, null, 2L, "Videos", null, "/cms/videos/index" },
                    { 62L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8257), "", 6, true, false, true, null, null, 2L, "Team", null, "/cms/team/index" },
                    { 50L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8203), "", 4, true, false, true, null, null, 2L, "Pages", null, "/cms/page/index" },
                    { 56L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8235), "", 5, true, false, true, null, null, 2L, "Gallery Images", null, "/cms/gallery-image/index" },
                    { 38L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8158), "", 2, true, false, true, null, null, 2L, "Events", null, "/cms/event/index" },
                    { 32L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8139), "", 1, true, false, true, null, null, 2L, "Notices", null, "/cms/notice/index" },
                    { 30L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8129), "", 2, true, false, true, null, null, 1L, "Reports", null, "#" },
                    { 27L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8117), "", 2, true, false, false, null, null, 1L, "Organization", null, "#" },
                    { 9L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8032), "", 1, true, false, true, null, null, 1L, "Setup", null, "#" },
                    { 44L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8182), "", 3, true, false, true, null, null, 2L, "Careers", null, "/cms/career/index" }
                });

            migrationBuilder.InsertData(
                table: "organization_module_map",
                columns: new[] { "Id", "created_by", "created_date", "is_deleted", "modified_by", "modified_date", "module_id", "organization_id" },
                values: new object[] { 1L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 654, DateTimeKind.Local).AddTicks(6370), false, null, null, 1L, 1L });

            migrationBuilder.InsertData(
                table: "role_permission_map",
                columns: new[] { "Id", "created_by", "created_date", "is_deleted", "modified_by", "modified_date", "permissions", "role_id" },
                values: new object[] { 1L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 655, DateTimeKind.Local).AddTicks(2619), false, null, null, "H4-0010001100120013", 1L });

            migrationBuilder.InsertData(
                table: "user_details",
                columns: new[] { "Id", "first_name", "image", "last_name", "permanent_address", "primary_contact", "secondary_contact", "temporary_address", "user_id" },
                values: new object[] { 1L, "Test", null, "Bahadur", "Mechinagar", "9814978788", null, null, 1L });

            migrationBuilder.InsertData(
                table: "user_role_map",
                columns: new[] { "Id", "created_by", "created_date", "is_deleted", "modified_by", "modified_date", "role_id", "user_id" },
                values: new object[] { 1L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 656, DateTimeKind.Local).AddTicks(7494), false, null, null, 1L, 1L });

            migrationBuilder.InsertData(
                table: "menu",
                columns: new[] { "Id", "api_url", "created_by", "created_date", "display_icon", "display_order", "is_active", "is_deleted", "is_visible_to_menu", "modified_by", "modified_date", "module_id", "name", "parent_menu_id", "web_url" },
                values: new object[,]
                {
                    { 2L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(7878), "", 1, true, false, false, null, null, 1L, "Create", 1L, "/usermanagement/user/create" },
                    { 146L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8558), "", 1, true, false, true, null, null, 2L, "Gallery", 115L, "/cms/gallery/index" },
                    { 154L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8586), "", 7, true, false, false, null, null, 2L, "Make Home Page", 50L, "/cms/page/make-homepage" },
                    { 57L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8239), "", 1, true, false, false, null, null, 2L, "Create", 56L, "/cms/gallery-image/create" },
                    { 58L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8242), "", 2, true, false, false, null, null, 2L, "Update", 56L, "/cms/galleryimage/update" },
                    { 59L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8245), "", 3, true, false, false, null, null, 2L, "Delete", 56L, "/cms/gallery-image/delete" },
                    { 60L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8248), "", 4, true, false, false, null, null, 2L, "Enable", 56L, "/cms/gallery-image/enable" },
                    { 61L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8253), "", 5, true, false, false, null, null, 2L, "Disable", 56L, "/cms/gallery-image/disable" },
                    { 152L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8580), "", 7, true, false, false, null, null, 2L, "Make Slider", 56L, "/cms/gallery-image/make-slider" },
                    { 153L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8583), "", 8, true, false, false, null, null, 2L, "Unmake Slider", 56L, "/cms/gallery-image/unmake-slider" },
                    { 63L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8260), "", 1, true, false, false, null, null, 2L, "Create", 62L, "/cms/team/create" },
                    { 64L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8264), "", 2, true, false, false, null, null, 2L, "Update", 62L, "/cms/team/update" },
                    { 65L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8267), "", 3, true, false, false, null, null, 2L, "Delete", 62L, "/cms/team/delete" },
                    { 66L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8271), "", 4, true, false, false, null, null, 2L, "Enable", 62L, "/cms/team/enable" },
                    { 67L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8274), "", 5, true, false, false, null, null, 2L, "Disable", 62L, "/cms/team/disable" },
                    { 69L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8281), "", 1, true, false, false, null, null, 2L, "Create", 68L, "/cms/videos/create" },
                    { 70L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8284), "", 2, true, false, false, null, null, 2L, "Update", 68L, "/cms/videos/update" },
                    { 71L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8288), "", 3, true, false, false, null, null, 2L, "Delete", 68L, "/cms/videos/delete" },
                    { 140L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8539), "", 1, true, false, true, null, null, 2L, "News Category", 115L, "/cms/news-category/index" },
                    { 134L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8517), "", 1, true, false, true, null, null, 2L, "Blog Category", 115L, "/cms/blog-category/index" },
                    { 128L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8492), "", 1, true, false, true, null, null, 2L, "Page Category", 115L, "/cms/page-category/index" },
                    { 122L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8470), "", 1, true, false, true, null, null, 2L, "Designation", 115L, "/cms/designation/index" },
                    { 116L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8450), "", 1, true, false, true, null, null, 2L, "Author", 115L, "/cms/author/index" },
                    { 109L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8426), "", 1, true, false, true, null, null, 2L, "Advertisement", 74L, "/cms/advertisement/index" },
                    { 54L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8229), "", 4, true, false, false, null, null, 2L, "Enable", 50L, "/cms/page/enable" },
                    { 105L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8413), "", 1, true, false, true, null, null, 2L, "Subscribers", 74L, "/cms/subscriber/index" },
                    { 93L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8370), "", 1, true, false, true, null, null, 2L, "Testimonials", 74L, "/cms/testimonials/index" },
                    { 87L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8345), "", 1, true, false, true, null, null, 2L, "FAQ", 74L, "/cms/faq/index" },
                    { 81L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8323), "", 1, true, false, true, null, null, 2L, "News", 74L, "/cms/news/index" },
                    { 75L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8303), "", 1, true, false, true, null, null, 2L, "Blogs", 74L, "/cms/blog/index" },
                    { 73L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8296), "", 5, true, false, false, null, null, 2L, "Disable", 68L, "/cms/videos/disable" },
                    { 72L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8292), "", 4, true, false, false, null, null, 2L, "Enable", 68L, "/cms/videos/enable" },
                    { 99L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8392), "", 1, true, false, true, null, null, 2L, "Clients", 74L, "/cms/our-clients/index" },
                    { 53L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8216), "", 3, true, false, false, null, null, 2L, "Delete", 50L, "/cms/page/delete" },
                    { 55L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8232), "", 5, true, false, false, null, null, 2L, "Disable", 50L, "/cms/page/disable" },
                    { 51L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8207), "", 1, true, false, false, null, null, 2L, "Create", 50L, "/cms/page/create" },
                    { 34L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8145), "", 2, true, false, false, null, null, 2L, "Update", 32L, "/cms/notice/update" },
                    { 33L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8142), "", 1, true, false, false, null, null, 2L, "Create", 32L, "/cms/notice/create" },
                    { 31L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8135), "", 1, true, false, true, null, null, 1L, "User Report", 30L, "#" },
                    { 29L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8126), "", 2, true, false, false, null, null, 1L, "Assign Module", 27L, "/usermanagement/organization/assign-module" },
                    { 28L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8122), "", 1, true, false, false, null, null, 1L, "Create", 27L, "/usermanagement/organization/create" },
                    { 21L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8097), "", 3, true, false, true, null, null, 1L, "Menu", 9L, "/usermanagement/menu/index" },
                    { 35L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8149), "", 3, true, false, false, null, null, 2L, "Delete", 32L, "/cms/notice/delete" },
                    { 17L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8083), "", 2, true, false, true, null, null, 1L, "Module", 9L, "/usermanagement/module/index" },
                    { 8L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8028), "", 7, true, false, false, null, null, 1L, "Mark Email Registered", 1L, "/usermanagement/user/mark-email-registered" },
                    { 7L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8025), "", 6, true, false, false, null, null, 1L, "Change Password", 1L, "/usermanagement/user/change-password" },
                    { 6L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8021), "", 5, true, false, false, null, null, 1L, "Disable", 1L, "/usermanagement/user/disable" },
                    { 5L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8016), "", 4, true, false, false, null, null, 1L, "Enable", 1L, "/usermanagement/user/enable" },
                    { 4L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8011), "", 3, true, false, false, null, null, 1L, "Delete", 1L, "/usermanagement/user/delete" },
                    { 3L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8003), "", 2, true, false, false, null, null, 1L, "Update", 1L, "/usermanagement/user/update" },
                    { 10L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8036), "", 1, true, false, true, null, null, 1L, "Role", 9L, "/usermanagement/role/index" },
                    { 52L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8213), "", 2, true, false, false, null, null, 2L, "Update", 50L, "/cms/page/update" },
                    { 36L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8152), "", 4, true, false, false, null, null, 2L, "Enable", 32L, "/cms/notice/enable" },
                    { 37L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8155), "", 5, true, false, false, null, null, 2L, "Disable", 32L, "/cms/notice/disable" },
                    { 49L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8199), "", 5, true, false, false, null, null, 2L, "Disable", 44L, "/cms/career/disable" },
                    { 48L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8196), "", 4, true, false, false, null, null, 2L, "Enable", 44L, "/cms/career/enable" },
                    { 47L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8192), "", 3, true, false, false, null, null, 2L, "Delete", 44L, "/cms/career/delete" },
                    { 46L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8189), "", 2, true, false, false, null, null, 2L, "Update", 44L, "/cms/career/update" },
                    { 45L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8186), "", 1, true, false, false, null, null, 2L, "Create", 44L, "/cms/career/create" },
                    { 43L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8179), "", 5, true, false, false, null, null, 2L, "Disable", 38L, "/cms/event/disable" },
                    { 155L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8590), "", 1, true, false, true, null, null, 2L, "Links", 115L, "/cms/links/index" },
                    { 41L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8173), "", 3, true, false, false, null, null, 2L, "Delete", 38L, "/cms/event/delete" },
                    { 40L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8170), "", 2, true, false, false, null, null, 2L, "Update", 38L, "/cms/event/update" },
                    { 39L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8166), "", 1, true, false, false, null, null, 2L, "Create", 38L, "/cms/event/create" },
                    { 42L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8176), "", 4, true, false, false, null, null, 2L, "Enable", 38L, "/cms/event/enable" }
                });

            migrationBuilder.InsertData(
                table: "menu_permission_map",
                columns: new[] { "Id", "created_by", "created_date", "is_deleted", "menu_id", "modified_by", "modified_date", "permissions" },
                values: new object[,]
                {
                    { 52L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2413), false, 56L, null, null, "H4-0010" },
                    { 58L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2437), false, 62L, null, null, "H4-0010" },
                    { 64L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2459), false, 68L, null, null, "H4-0010" },
                    { 1L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(1336), false, 1L, null, null, "H4-0010" },
                    { 46L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2391), false, 50L, null, null, "H4-0010" },
                    { 28L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2310), false, 32L, null, null, "H4-0010" },
                    { 40L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2355), false, 44L, null, null, "H4-0010" },
                    { 34L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2332), false, 38L, null, null, "H4-0010" }
                });

            migrationBuilder.InsertData(
                table: "menu",
                columns: new[] { "Id", "api_url", "created_by", "created_date", "display_icon", "display_order", "is_active", "is_deleted", "is_visible_to_menu", "modified_by", "modified_date", "module_id", "name", "parent_menu_id", "web_url" },
                values: new object[,]
                {
                    { 84L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8334), "", 3, true, false, false, null, null, 2L, "Delete", 81L, "/cms/news/delete" },
                    { 77L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8310), "", 2, true, false, false, null, null, 2L, "Update", 75L, "/cms/blog/update" },
                    { 76L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8306), "", 1, true, false, false, null, null, 2L, "Create", 75L, "/cms/blog/create" },
                    { 107L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8420), "", 2, true, false, false, null, null, 2L, "Update", 105L, "/cms/subscriber/update" },
                    { 108L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8423), "", 3, true, false, false, null, null, 2L, "Delete", 105L, "/cms/subscriber/delete" },
                    { 110L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8430), "", 1, true, false, false, null, null, 2L, "Create", 109L, "/cms/advertisement/create" },
                    { 111L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8433), "", 2, true, false, false, null, null, 2L, "Update", 109L, "/cms/advertisement/update" },
                    { 112L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8436), "", 3, true, false, false, null, null, 2L, "Delete", 109L, "/cms/advertisement/delete" },
                    { 113L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8440), "", 4, true, false, false, null, null, 2L, "Enable", 109L, "/cms/advertisement/enable" },
                    { 114L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8443), "", 5, true, false, false, null, null, 2L, "Disable", 109L, "/cms/advertisement/disable" },
                    { 117L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8454), "", 1, true, false, false, null, null, 2L, "Create", 116L, "/cms/author/create" },
                    { 118L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8457), "", 2, true, false, false, null, null, 2L, "Update", 116L, "/cms/author/update" },
                    { 119L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8461), "", 3, true, false, false, null, null, 2L, "Delete", 116L, "/cms/author/delete" },
                    { 120L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8464), "", 4, true, false, false, null, null, 2L, "Enable", 116L, "/cms/author/enable" },
                    { 121L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8467), "", 5, true, false, false, null, null, 2L, "Disable", 116L, "/cms/author/disable" },
                    { 123L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8473), "", 1, true, false, false, null, null, 2L, "Create", 122L, "/cms/designation/create" },
                    { 124L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8477), "", 2, true, false, false, null, null, 2L, "Update", 122L, "/cms/designation/update" },
                    { 125L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8480), "", 3, true, false, false, null, null, 2L, "Delete", 122L, "/cms/designation/delete" },
                    { 78L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8313), "", 3, true, false, false, null, null, 2L, "Delete", 75L, "/cms/blog/delete" },
                    { 79L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8316), "", 4, true, false, false, null, null, 2L, "Enable", 75L, "/cms/blog/enable" },
                    { 80L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8320), "", 5, true, false, false, null, null, 2L, "Disable", 75L, "/cms/blog/disable" },
                    { 106L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8417), "", 1, true, false, false, null, null, 2L, "Create", 105L, "/cms/subscriber/create" },
                    { 100L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8396), "", 1, true, false, false, null, null, 2L, "Create", 99L, "/cms/our-clients/create" },
                    { 103L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8405), "", 4, true, false, false, null, null, 2L, "Enable", 99L, "/cms/our-clients/enable" },
                    { 98L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8389), "", 5, true, false, false, null, null, 2L, "Disable", 93L, "/cms/testimonials/disable" },
                    { 97L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8386), "", 4, true, false, false, null, null, 2L, "Enable", 93L, "/cms/testimonials/enable" },
                    { 96L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8383), "", 3, true, false, false, null, null, 2L, "Delete", 93L, "/cms/testimonials/delete" },
                    { 95L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8380), "", 2, true, false, false, null, null, 2L, "Update", 93L, "/cms/testimonials/update" },
                    { 94L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8376), "", 1, true, false, false, null, null, 2L, "Create", 93L, "/cms/testimonials/create" },
                    { 104L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8408), "", 5, true, false, false, null, null, 2L, "Disable", 99L, "/cms/our-clients/disable" },
                    { 101L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8399), "", 2, true, false, false, null, null, 2L, "Update", 99L, "/cms/our-clients/update" },
                    { 92L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8360), "", 5, true, false, false, null, null, 2L, "Disable", 87L, "/cms/faq/disable" },
                    { 90L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8354), "", 3, true, false, false, null, null, 2L, "Delete", 87L, "/cms/faq/delete" },
                    { 89L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8351), "", 2, true, false, false, null, null, 2L, "Update", 87L, "/cms/faq/update" },
                    { 88L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8348), "", 1, true, false, false, null, null, 2L, "Create", 87L, "/cms/faq/create" },
                    { 86L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8341), "", 5, true, false, false, null, null, 2L, "Disable", 81L, "/cms/news/disable" },
                    { 85L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8338), "", 4, true, false, false, null, null, 2L, "Enable", 81L, "/cms/news/enable" },
                    { 160L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8606), "", 5, true, false, false, null, null, 2L, "Disable", 155L, "/cms/links/disable" },
                    { 83L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8331), "", 2, true, false, false, null, null, 2L, "Update", 81L, "/cms/news/update" },
                    { 82L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8327), "", 1, true, false, false, null, null, 2L, "Create", 81L, "/cms/news/create" },
                    { 91L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8357), "", 4, true, false, false, null, null, 2L, "Enable", 87L, "/cms/faq/enable" },
                    { 127L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8488), "", 5, true, false, false, null, null, 2L, "Disable", 122L, "/cms/designation/disable" },
                    { 126L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8483), "", 4, true, false, false, null, null, 2L, "Enable", 122L, "/cms/designation/enable" },
                    { 26L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8114), "", 5, true, false, false, null, null, 1L, "Disable", 21L, "/usermanagement/menu/disable" },
                    { 24L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8107), "", 3, true, false, false, null, null, 1L, "Delete", 21L, "/usermanagement/menu/delete" },
                    { 23L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8103), "", 2, true, false, false, null, null, 1L, "Update", 21L, "/usermanagement/menu/update" },
                    { 22L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8100), "", 1, true, false, false, null, null, 1L, "Create", 21L, "/usermanagement/menu/create" },
                    { 149L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8569), "", 3, true, false, false, null, null, 2L, "Delete", 146L, "/cms/gallery/delete" },
                    { 20L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8093), "", 3, true, false, false, null, null, 1L, "Delete", 17L, "/usermanagement/module/delete" },
                    { 19L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8090), "", 2, true, false, false, null, null, 1L, "Update", 17L, "/usermanagement/module/update" },
                    { 18L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8087), "", 1, true, false, false, null, null, 1L, "Create", 17L, "/usermanagement/module/create" },
                    { 150L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8573), "", 4, true, false, false, null, null, 2L, "Enable", 146L, "/cms/gallery/enable" },
                    { 16L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8078), "", 6, true, false, false, null, null, 1L, "Assign Role Menu", 10L, "/usermanagement/role/assign-role-menu" },
                    { 15L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8074), "", 5, true, false, false, null, null, 1L, "Disable", 10L, "/usermanagement/role/disable" },
                    { 14L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8070), "", 4, true, false, false, null, null, 1L, "Enable", 10L, "/usermanagement/role/enable" },
                    { 13L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8047), "", 3, true, false, false, null, null, 1L, "Delete", 10L, "/usermanagement/role/delete" },
                    { 12L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8043), "", 2, true, false, false, null, null, 1L, "Update", 10L, "/usermanagement/role/update" },
                    { 11L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8040), "", 1, true, false, false, null, null, 1L, "Create", 10L, "/usermanagement/role/create" },
                    { 151L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8576), "", 5, true, false, false, null, null, 2L, "Disable", 146L, "/cms/gallery/disable" },
                    { 156L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8593), "", 1, true, false, false, null, null, 2L, "Create", 155L, "/cms/links/create" },
                    { 157L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8596), "", 2, true, false, false, null, null, 2L, "Update", 155L, "/cms/links/update" },
                    { 158L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8599), "", 3, true, false, false, null, null, 2L, "Delete", 155L, "/cms/links/delete" },
                    { 159L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8602), "", 4, true, false, false, null, null, 2L, "Enable", 155L, "/cms/links/enable" },
                    { 25L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8110), "", 4, true, false, false, null, null, 1L, "Enable", 21L, "/usermanagement/menu/enable" },
                    { 129L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8496), "", 1, true, false, false, null, null, 2L, "Create", 128L, "/cms/page-category/create" },
                    { 102L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8402), "", 3, true, false, false, null, null, 2L, "Delete", 99L, "/cms/our-clients/delete" },
                    { 147L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8562), "", 1, true, false, false, null, null, 2L, "Create", 146L, "/cms/gallery/create" },
                    { 130L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8499), "", 2, true, false, false, null, null, 2L, "Update", 128L, "/cms/page-category/update" },
                    { 131L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8502), "", 3, true, false, false, null, null, 2L, "Delete", 128L, "/cms/page-category/delete" },
                    { 132L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8511), "", 4, true, false, false, null, null, 2L, "Enable", 128L, "/cms/page-category/enable" },
                    { 133L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8514), "", 5, true, false, false, null, null, 2L, "Disable", 128L, "/cms/page-category/disable" },
                    { 135L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8521), "", 1, true, false, false, null, null, 2L, "Create", 134L, "/cms/blog-category/create" },
                    { 136L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8524), "", 2, true, false, false, null, null, 2L, "Update", 134L, "/cms/blog-category/update" },
                    { 137L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8527), "", 3, true, false, false, null, null, 2L, "Delete", 134L, "/cms/blog-category/delete" },
                    { 148L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8565), "", 2, true, false, false, null, null, 2L, "Update", 146L, "/cms/gallery/update" },
                    { 139L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8536), "", 5, true, false, false, null, null, 2L, "Disable", 134L, "/cms/blog-category/disable" },
                    { 138L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8531), "", 4, true, false, false, null, null, 2L, "Enable", 134L, "/cms/blog-category/enable" },
                    { 141L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8542), "", 1, true, false, false, null, null, 2L, "Create", 140L, "/cms/news-category/create" },
                    { 142L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8546), "", 2, true, false, false, null, null, 2L, "Update", 140L, "/cms/news-category/update" },
                    { 143L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8549), "", 3, true, false, false, null, null, 2L, "Delete", 140L, "/cms/news-category/delete" },
                    { 144L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8552), "", 4, true, false, false, null, null, 2L, "Enable", 140L, "/cms/news-category/enable" },
                    { 145L, "", 1L, new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8555), "", 5, true, false, false, null, null, 2L, "Disable", 140L, "/cms/news-category/disable" }
                });

            migrationBuilder.InsertData(
                table: "menu_permission_map",
                columns: new[] { "Id", "created_by", "created_date", "is_deleted", "menu_id", "modified_by", "modified_date", "permissions" },
                values: new object[,]
                {
                    { 94L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2571), false, 99L, null, null, "H4-0010" },
                    { 128L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2709), false, 134L, null, null, "H4-0010" },
                    { 110L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2634), false, 116L, null, null, "H4-0010" },
                    { 122L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2680), false, 128L, null, null, "H4-0010" },
                    { 140L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2754), false, 146L, null, null, "H4-0010" },
                    { 100L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2597), false, 105L, null, null, "H4-0010" },
                    { 134L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2731), false, 140L, null, null, "H4-0010" },
                    { 104L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2612), false, 109L, null, null, "H4-0010" },
                    { 116L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2656), false, 122L, null, null, "H4-0010" },
                    { 2L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2202), false, 2L, null, null, "H4-0011" },
                    { 82L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2527), false, 87L, null, null, "H4-0010" },
                    { 42L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2363), false, 46L, null, null, "H4-0012" },
                    { 41L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2359), false, 45L, null, null, "H4-0011" },
                    { 39L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2352), false, 43L, null, null, "H4-0012" },
                    { 38L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2348), false, 42L, null, null, "H4-0012" },
                    { 37L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2343), false, 41L, null, null, "H4-0013" },
                    { 36L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2340), false, 40L, null, null, "H4-0012" },
                    { 35L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2336), false, 39L, null, null, "H4-0011" },
                    { 33L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2329), false, 37L, null, null, "H4-0012" },
                    { 32L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2325), false, 36L, null, null, "H4-0012" },
                    { 31L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2321), false, 35L, null, null, "H4-0013" },
                    { 30L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2318), false, 34L, null, null, "H4-0012" },
                    { 29L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2314), false, 33L, null, null, "H4-0011" },
                    { 27L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2307), false, 29L, null, null, "H4-0012" },
                    { 26L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2303), false, 28L, null, null, "H4-0011" },
                    { 20L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2281), false, 21L, null, null, "H4-0010" },
                    { 16L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2264), false, 17L, null, null, "H4-0010" },
                    { 9L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2238), false, 10L, null, null, "H4-0010" },
                    { 8L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2234), false, 8L, null, null, "H4-0012" },
                    { 7L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2230), false, 7L, null, null, "H4-0012" },
                    { 6L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2226), false, 6L, null, null, "H4-0012" },
                    { 5L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2223), false, 5L, null, null, "H4-0012" },
                    { 4L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2219), false, 4L, null, null, "H4-0013" },
                    { 3L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2215), false, 3L, null, null, "H4-0012" },
                    { 43L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2366), false, 47L, null, null, "H4-0013" },
                    { 44L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2370), false, 48L, null, null, "H4-0012" },
                    { 45L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2374), false, 49L, null, null, "H4-0012" },
                    { 47L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2395), false, 51L, null, null, "H4-0011" },
                    { 76L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2503), false, 81L, null, null, "H4-0010" },
                    { 70L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2481), false, 75L, null, null, "H4-0010" },
                    { 69L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2478), false, 73L, null, null, "H4-0012" },
                    { 68L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2474), false, 72L, null, null, "H4-0012" },
                    { 67L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2470), false, 71L, null, null, "H4-0013" },
                    { 66L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2467), false, 70L, null, null, "H4-0012" },
                    { 65L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2463), false, 69L, null, null, "H4-0011" },
                    { 63L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2456), false, 67L, null, null, "H4-0012" },
                    { 62L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2452), false, 66L, null, null, "H4-0012" },
                    { 61L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2448), false, 65L, null, null, "H4-0013" },
                    { 60L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2444), false, 64L, null, null, "H4-0012" },
                    { 88L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2549), false, 93L, null, null, "H4-0010" },
                    { 59L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2440), false, 63L, null, null, "H4-0011" },
                    { 146L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2776), false, 152L, null, null, "H4-0012" },
                    { 57L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2432), false, 61L, null, null, "H4-0012" },
                    { 56L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2428), false, 60L, null, null, "H4-0012" },
                    { 55L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2425), false, 59L, null, null, "H4-0013" },
                    { 54L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2421), false, 58L, null, null, "H4-0012" },
                    { 53L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2417), false, 57L, null, null, "H4-0011" },
                    { 148L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2783), false, 154L, null, null, "H4-0012" },
                    { 51L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2409), false, 55L, null, null, "H4-0012" },
                    { 50L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2406), false, 54L, null, null, "H4-0012" },
                    { 49L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2402), false, 53L, null, null, "H4-0013" },
                    { 48L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2398), false, 52L, null, null, "H4-0012" },
                    { 147L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2779), false, 153L, null, null, "H4-0012" },
                    { 149L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2787), false, 155L, null, null, "H4-0010" }
                });

            migrationBuilder.InsertData(
                table: "menu_permission_map",
                columns: new[] { "Id", "created_by", "created_date", "is_deleted", "menu_id", "modified_by", "modified_date", "permissions" },
                values: new object[,]
                {
                    { 10L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2241), false, 11L, null, null, "H4-0011" },
                    { 124L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2694), false, 130L, null, null, "H4-0012" },
                    { 123L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2684), false, 129L, null, null, "H4-0011" },
                    { 121L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2676), false, 127L, null, null, "H4-0012" },
                    { 120L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2673), false, 126L, null, null, "H4-0012" },
                    { 119L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2669), false, 125L, null, null, "H4-0013" },
                    { 118L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2664), false, 124L, null, null, "H4-0012" },
                    { 117L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2660), false, 123L, null, null, "H4-0011" },
                    { 125L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2698), false, 131L, null, null, "H4-0013" },
                    { 115L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2653), false, 121L, null, null, "H4-0012" },
                    { 113L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2645), false, 119L, null, null, "H4-0013" },
                    { 112L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2642), false, 118L, null, null, "H4-0012" },
                    { 111L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2638), false, 117L, null, null, "H4-0011" },
                    { 109L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2631), false, 114L, null, null, "H4-0012" },
                    { 108L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2627), false, 113L, null, null, "H4-0012" },
                    { 107L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2623), false, 112L, null, null, "H4-0013" },
                    { 106L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2619), false, 111L, null, null, "H4-0012" },
                    { 114L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2649), false, 120L, null, null, "H4-0012" },
                    { 126L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2701), false, 132L, null, null, "H4-0012" },
                    { 127L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2705), false, 133L, null, null, "H4-0012" },
                    { 129L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2713), false, 135L, null, null, "H4-0011" },
                    { 152L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2798), false, 158L, null, null, "H4-0013" },
                    { 151L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2794), false, 157L, null, null, "H4-0012" },
                    { 150L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2790), false, 156L, null, null, "H4-0011" },
                    { 145L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2772), false, 151L, null, null, "H4-0012" },
                    { 144L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2769), false, 150L, null, null, "H4-0012" },
                    { 143L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2765), false, 149L, null, null, "H4-0013" },
                    { 142L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2761), false, 148L, null, null, "H4-0012" },
                    { 141L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2758), false, 147L, null, null, "H4-0011" },
                    { 139L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2749), false, 145L, null, null, "H4-0012" },
                    { 138L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2746), false, 144L, null, null, "H4-0012" },
                    { 137L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2742), false, 143L, null, null, "H4-0013" },
                    { 136L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2739), false, 142L, null, null, "H4-0012" },
                    { 135L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2735), false, 141L, null, null, "H4-0011" },
                    { 133L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2727), false, 139L, null, null, "H4-0012" },
                    { 132L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2724), false, 138L, null, null, "H4-0012" },
                    { 131L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2720), false, 137L, null, null, "H4-0013" },
                    { 130L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2716), false, 136L, null, null, "H4-0012" },
                    { 105L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2616), false, 110L, null, null, "H4-0011" },
                    { 103L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2608), false, 108L, null, null, "H4-0013" },
                    { 102L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2605), false, 107L, null, null, "H4-0012" },
                    { 101L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2601), false, 106L, null, null, "H4-0011" },
                    { 74L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2496), false, 79L, null, null, "H4-0012" },
                    { 73L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2492), false, 78L, null, null, "H4-0013" },
                    { 72L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2489), false, 77L, null, null, "H4-0012" },
                    { 71L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2485), false, 76L, null, null, "H4-0011" },
                    { 25L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2299), false, 26L, null, null, "H4-0012" },
                    { 24L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2296), false, 25L, null, null, "H4-0012" },
                    { 23L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2292), false, 24L, null, null, "H4-0013" },
                    { 22L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2288), false, 23L, null, null, "H4-0012" },
                    { 21L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2285), false, 22L, null, null, "H4-0011" },
                    { 19L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2276), false, 20L, null, null, "H4-0013" },
                    { 18L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2272), false, 19L, null, null, "H4-0012" },
                    { 17L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2268), false, 18L, null, null, "H4-0011" },
                    { 15L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2260), false, 16L, null, null, "H4-0012" },
                    { 14L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2256), false, 15L, null, null, "H4-0012" },
                    { 13L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2253), false, 14L, null, null, "H4-0012" },
                    { 12L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2249), false, 13L, null, null, "H4-0013" },
                    { 11L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2245), false, 12L, null, null, "H4-0012" },
                    { 75L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2499), false, 80L, null, null, "H4-0012" },
                    { 153L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2801), false, 159L, null, null, "H4-0012" },
                    { 77L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2507), false, 82L, null, null, "H4-0011" },
                    { 79L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2516), false, 84L, null, null, "H4-0013" },
                    { 99L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2593), false, 104L, null, null, "H4-0012" },
                    { 98L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2586), false, 103L, null, null, "H4-0012" },
                    { 97L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2582), false, 102L, null, null, "H4-0013" },
                    { 96L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2579), false, 101L, null, null, "H4-0012" },
                    { 95L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2575), false, 100L, null, null, "H4-0011" },
                    { 93L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2567), false, 98L, null, null, "H4-0012" },
                    { 92L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2563), false, 97L, null, null, "H4-0012" },
                    { 91L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2560), false, 96L, null, null, "H4-0013" },
                    { 90L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2556), false, 95L, null, null, "H4-0012" },
                    { 89L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2553), false, 94L, null, null, "H4-0011" },
                    { 87L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2545), false, 92L, null, null, "H4-0012" },
                    { 86L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2542), false, 91L, null, null, "H4-0012" },
                    { 85L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2538), false, 90L, null, null, "H4-0013" },
                    { 84L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2534), false, 89L, null, null, "H4-0012" },
                    { 83L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2531), false, 88L, null, null, "H4-0011" },
                    { 81L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2523), false, 86L, null, null, "H4-0012" },
                    { 80L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2520), false, 85L, null, null, "H4-0012" },
                    { 78L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2512), false, 83L, null, null, "H4-0012" },
                    { 154L, 1L, new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2805), false, 160L, null, null, "H4-0012" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_jwt_tokens_user_id",
                table: "jwt_tokens",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_menu_module_id",
                table: "menu",
                column: "module_id");

            migrationBuilder.CreateIndex(
                name: "IX_menu_parent_menu_id",
                table: "menu",
                column: "parent_menu_id");

            migrationBuilder.CreateIndex(
                name: "IX_menu_permission_map_menu_id",
                table: "menu_permission_map",
                column: "menu_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_organization_module_map_module_id",
                table: "organization_module_map",
                column: "module_id");

            migrationBuilder.CreateIndex(
                name: "IX_organization_module_map_organization_id",
                table: "organization_module_map",
                column: "organization_id");

            migrationBuilder.CreateIndex(
                name: "IX_register_seminar_id",
                table: "register",
                column: "seminar_id");

            migrationBuilder.CreateIndex(
                name: "IX_register_student_id",
                table: "register",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_role_menu_map_menu_id",
                table: "role_menu_map",
                column: "menu_id");

            migrationBuilder.CreateIndex(
                name: "IX_role_menu_map_role_id",
                table: "role_menu_map",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_role_permission_map_role_id",
                table: "role_permission_map",
                column: "role_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_seminar_org_id",
                table: "seminar",
                column: "org_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_details_user_id",
                table: "user_details",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_role_map_role_id",
                table: "user_role_map",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_map_user_id",
                table: "user_role_map",
                column: "user_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jwt_tokens");

            migrationBuilder.DropTable(
                name: "menu_permission_map");

            migrationBuilder.DropTable(
                name: "organization_module_map");

            migrationBuilder.DropTable(
                name: "register");

            migrationBuilder.DropTable(
                name: "role_menu_map");

            migrationBuilder.DropTable(
                name: "role_permission_map");

            migrationBuilder.DropTable(
                name: "user_details");

            migrationBuilder.DropTable(
                name: "user_loggedin_status_setup");

            migrationBuilder.DropTable(
                name: "user_role_map");

            migrationBuilder.DropTable(
                name: "organization");

            migrationBuilder.DropTable(
                name: "seminar");

            migrationBuilder.DropTable(
                name: "student");

            migrationBuilder.DropTable(
                name: "menu");

            migrationBuilder.DropTable(
                name: "user_role");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "organizer");

            migrationBuilder.DropTable(
                name: "module");
        }
    }
}
