using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EziBy_Core_WebAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    BranchDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    BranchAddress = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    BranchLandPhone = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    BranchMobile = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "Setups",
                columns: table => new
                {
                    SetupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CurrencyMark = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    CurrencyDecimals = table.Column<int>(type: "int", nullable: false),
                    TokenExpiryDays = table.Column<int>(type: "int", nullable: false),
                    InitialDeliveryDays = table.Column<int>(type: "int", nullable: false),
                    MaximumDeliveryDays = table.Column<int>(type: "int", nullable: false),
                    Android_OnGoingMaintenance = table.Column<bool>(type: "bit", nullable: false),
                    Android_ForceUpdate = table.Column<bool>(type: "bit", nullable: false),
                    Android_BuildNumber = table.Column<int>(type: "int", nullable: false),
                    MainAPIUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    MainSlideShowImagesUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    CategoryImagesUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    CategoryHeaderUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    SubCategoryImagesUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    ItemsImageUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    BrandImageUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    SocialMediaUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    OtherImageUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    TermsAndConditionsUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    PrivacyPolicyUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    OurServicesUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    ContactUsUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    AboutUsUri = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    ServerMappedImagePath = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    NewOrderRefreshInterval = table.Column<int>(type: "int", nullable: false),
                    AllowDiscountInPOS = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CrystalReportPath = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setups", x => x.SetupId);
                    table.ForeignKey(
                        name: "FK_Setups_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_BranchId",
                table: "Branches",
                column: "BranchId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Branches_BranchName",
                table: "Branches",
                column: "BranchName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Setups_BranchId_Active",
                table: "Setups",
                columns: new[] { "BranchId", "Active" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Setups");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
