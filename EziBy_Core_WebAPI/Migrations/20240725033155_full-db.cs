using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EziBy_Core_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class fulldb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CyrstalReportPath",
                table: "Setups",
                newName: "CrystalReportPath");

            migrationBuilder.AlterColumn<string>(
                name: "MainAPIUri",
                table: "Setups",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "AdvertisementImageUri",
                table: "Setups",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    AdvertisementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    AdvertisementImage = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    AdvertisementLink = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PhoneNumber1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Slogan = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.AdvertisementId);
                    table.ForeignKey(
                        name: "FK_Advertisements_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    BrandName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    BrandImage = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DisplayableInMobileApp = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                    table.ForeignKey(
                        name: "FK_Brands_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "CarouselImages",
                columns: table => new
                {
                    CarouselId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CarouselDetails = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    CarouselImageName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    CarouselLink = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    CarouselType = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarouselImages", x => x.CarouselId);
                    table.ForeignKey(
                        name: "FK_CarouselImages_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    CategoryImage = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    CategoryHeaderImage = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    MaxDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    IsGuestMode = table.Column<bool>(type: "bit", nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    GuestId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    PhoneVerified = table.Column<bool>(type: "bit", nullable: false),
                    EmailVerified = table.Column<bool>(type: "bit", nullable: false),
                    SubscribedForNewsLetters = table.Column<bool>(type: "bit", nullable: false),
                    Suspended = table.Column<bool>(type: "bit", nullable: false),
                    SuspendedReason = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLastLogged = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Clients_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Mobile = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "DeliveryCities",
                columns: table => new
                {
                    DeliveryCityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DeliveryCityName = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    DeliveryCharge = table.Column<decimal>(type: "money", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryCities", x => x.DeliveryCityId);
                    table.ForeignKey(
                        name: "FK_DeliveryCities_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "DeliveryTimes",
                columns: table => new
                {
                    DeliveryTimeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DeliveryTimeName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryTimes", x => x.DeliveryTimeId);
                    table.ForeignKey(
                        name: "FK_DeliveryTimes_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "MailSettings",
                columns: table => new
                {
                    MailSettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    OrderEmailAddress = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    OrderEmailDisplayName = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    OrderEmailPassword = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    OrderEmailPortNo = table.Column<int>(type: "int", nullable: false),
                    OrderEmailHost = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    OrderEmailCCAddress = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    OrderEmailBCCAddress = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    UnsubscribeLink = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailSettings", x => x.MailSettingId);
                    table.ForeignKey(
                        name: "FK_MailSettings_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "Serials",
                columns: table => new
                {
                    SerialType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    SerialDescription = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    AddYearPrefix = table.Column<bool>(type: "bit", nullable: false),
                    CharacterPrefix = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    CurrentYear = table.Column<int>(type: "int", nullable: false),
                    NumberOfDigitsInSerial = table.Column<int>(type: "int", nullable: false),
                    NextSerialNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serials", x => x.SerialType);
                    table.ForeignKey(
                        name: "FK_Serials_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    SupplierName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Mobile = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                    table.ForeignKey(
                        name: "FK_Suppliers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "UOMs",
                columns: table => new
                {
                    UOMId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    UOMName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    UOMFullName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UOMs", x => x.UOMId);
                    table.ForeignKey(
                        name: "FK_UOMs_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    UserGUID = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserFullName = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Remarks = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    SubCategoryImage = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => new { x.CategoryId, x.SubCategoryId });
                    table.ForeignKey(
                        name: "FK_SubCategories_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "CustomerPointRedeems",
                columns: table => new
                {
                    RedeepmedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PointsRedeemped = table.Column<int>(type: "int", nullable: false),
                    RedeepedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPointRedeems", x => x.RedeepmedId);
                    table.ForeignKey(
                        name: "FK_CustomerPointRedeems_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_CustomerPointRedeems_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "MobileOrderMains",
                columns: table => new
                {
                    MobileOrderMainId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    OrderGUID = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatusId = table.Column<int>(type: "int", nullable: false),
                    OrderStatusUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    PaidStatusId = table.Column<int>(type: "int", nullable: false),
                    DeliveredDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryFullName = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    DeliveryEmail = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    DeliveryPhone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DeliveryAddress = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    DeliveryCityId = table.Column<int>(type: "int", nullable: false),
                    DeliveryNote = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PointAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryGoogleGeoLocation = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    PaymentMethod = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Environment = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileOrderMains", x => x.MobileOrderMainId);
                    table.ForeignKey(
                        name: "FK_MobileOrderMains_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_MobileOrderMains_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_MobileOrderMains_DeliveryCities_DeliveryCityId",
                        column: x => x.DeliveryCityId,
                        principalTable: "DeliveryCities",
                        principalColumn: "DeliveryCityId");
                });

            migrationBuilder.CreateTable(
                name: "CustomerPaymentMains",
                columns: table => new
                {
                    CustomerPaymentMainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    Remarks = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CardVisa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CardMaster = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CardAmex = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankTransferAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankTransferReference = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ChequeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChequeNumber = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ChequeValueDate = table.Column<DateTime>(type: "date", nullable: true),
                    Prepared_UserId = table.Column<int>(type: "int", nullable: false),
                    Prepared_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_UserId = table.Column<int>(type: "int", nullable: false),
                    Modified_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPaymentMains", x => x.CustomerPaymentMainId);
                    table.ForeignKey(
                        name: "FK_CustomerPaymentMains_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_CustomerPaymentMains_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_CustomerPaymentMains_Users_Modified_UserId",
                        column: x => x.Modified_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_CustomerPaymentMains_Users_Prepared_UserId",
                        column: x => x.Prepared_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "GrnMains",
                columns: table => new
                {
                    GrnMainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    GrnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    SupplierInvoiceNo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    SupplierInvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    GrossAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeductionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Posted = table.Column<bool>(type: "bit", nullable: false),
                    Prepared_UserId = table.Column<int>(type: "int", nullable: false),
                    Prepared_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_UserId = table.Column<int>(type: "int", nullable: false),
                    Modified_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrnMains", x => x.GrnMainId);
                    table.ForeignKey(
                        name: "FK_GrnMains_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_GrnMains_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId");
                    table.ForeignKey(
                        name: "FK_GrnMains_Users_Modified_UserId",
                        column: x => x.Modified_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_GrnMains_Users_Prepared_UserId",
                        column: x => x.Prepared_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "PosMains",
                columns: table => new
                {
                    PosMainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    PosGUID = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PosDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    GrossAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PermissableFraction = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CardVisa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CardMaster = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CardAmex = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankTransferAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankTransferReference = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ChequeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChequeNumber = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ChequeValueDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BalanceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prepared_UserId = table.Column<int>(type: "int", nullable: false),
                    Prepared_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_UserId = table.Column<int>(type: "int", nullable: false),
                    Modified_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosMains", x => x.PosMainId);
                    table.ForeignKey(
                        name: "FK_PosMains_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_PosMains_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_PosMains_Users_Modified_UserId",
                        column: x => x.Modified_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_PosMains_Users_Prepared_UserId",
                        column: x => x.Prepared_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "SupplierPaymentMains",
                columns: table => new
                {
                    SupplierPaymentMainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    Remarks = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CardVisa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CardMaster = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CardAmex = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankTransferAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankTransferReference = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ChequeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChequeNumber = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ChequeValueDate = table.Column<DateTime>(type: "date", nullable: true),
                    Prepared_UserId = table.Column<int>(type: "int", nullable: false),
                    Prepared_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_UserId = table.Column<int>(type: "int", nullable: false),
                    Modified_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPaymentMains", x => x.SupplierPaymentMainId);
                    table.ForeignKey(
                        name: "FK_SupplierPaymentMains_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_SupplierPaymentMains_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId");
                    table.ForeignKey(
                        name: "FK_SupplierPaymentMains_Users_Modified_UserId",
                        column: x => x.Modified_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_SupplierPaymentMains_Users_Prepared_UserId",
                        column: x => x.Prepared_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Specification = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    SKUBarcode = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Dimension = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ItemImage1 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ItemImage2 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ItemImage3 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    DeliveryTimeId = table.Column<int>(type: "int", nullable: false),
                    UOMId = table.Column<int>(type: "int", nullable: false),
                    StopReOrder = table.Column<bool>(type: "bit", nullable: false),
                    ReOrderLevel = table.Column<int>(type: "int", nullable: false),
                    ReOrderQty = table.Column<int>(type: "int", nullable: false),
                    AllowFractionInQty = table.Column<bool>(type: "bit", nullable: false),
                    NonExchangable = table.Column<bool>(type: "bit", nullable: false),
                    OneTimePurchasableQty = table.Column<int>(type: "int", nullable: false),
                    IsAvailableInMobileApp = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailableInPOS = table.Column<bool>(type: "bit", nullable: false),
                    IsNewArrival = table.Column<bool>(type: "bit", nullable: false),
                    IsTrending = table.Column<bool>(type: "bit", nullable: false),
                    IsExpress = table.Column<bool>(type: "bit", nullable: false),
                    TotalSold = table.Column<int>(type: "int", nullable: false),
                    TotalClicked = table.Column<int>(type: "int", nullable: false),
                    AverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_Items_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId");
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_Items_DeliveryTimes_DeliveryTimeId",
                        column: x => x.DeliveryTimeId,
                        principalTable: "DeliveryTimes",
                        principalColumn: "DeliveryTimeId");
                    table.ForeignKey(
                        name: "FK_Items_SubCategories_CategoryId_SubCategoryId",
                        columns: x => new { x.CategoryId, x.SubCategoryId },
                        principalTable: "SubCategories",
                        principalColumns: new[] { "CategoryId", "SubCategoryId" });
                    table.ForeignKey(
                        name: "FK_Items_UOMs_UOMId",
                        column: x => x.UOMId,
                        principalTable: "UOMs",
                        principalColumn: "UOMId");
                });

            migrationBuilder.CreateTable(
                name: "GrnReturnMains",
                columns: table => new
                {
                    GrnReturnMainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    GrnMainId = table.Column<int>(type: "int", nullable: false),
                    GrnReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    AdditionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeductionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Posted = table.Column<bool>(type: "bit", nullable: false),
                    Prepared_UserId = table.Column<int>(type: "int", nullable: false),
                    Prepared_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_UserId = table.Column<int>(type: "int", nullable: false),
                    Modified_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrnReturnMains", x => x.GrnReturnMainId);
                    table.ForeignKey(
                        name: "FK_GrnReturnMains_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_GrnReturnMains_GrnMains_GrnMainId",
                        column: x => x.GrnMainId,
                        principalTable: "GrnMains",
                        principalColumn: "GrnMainId");
                    table.ForeignKey(
                        name: "FK_GrnReturnMains_Users_Modified_UserId",
                        column: x => x.Modified_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_GrnReturnMains_Users_Prepared_UserId",
                        column: x => x.Prepared_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "CustomerPaymentSubs",
                columns: table => new
                {
                    CustomerPaymentSubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CustomerPaymentMainId = table.Column<int>(type: "int", nullable: false),
                    PosMainId = table.Column<int>(type: "int", nullable: false),
                    SettledAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPaymentSubs", x => x.CustomerPaymentSubId);
                    table.ForeignKey(
                        name: "FK_CustomerPaymentSubs_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_CustomerPaymentSubs_CustomerPaymentMains_CustomerPaymentMainId",
                        column: x => x.CustomerPaymentMainId,
                        principalTable: "CustomerPaymentMains",
                        principalColumn: "CustomerPaymentMainId");
                    table.ForeignKey(
                        name: "FK_CustomerPaymentSubs_PosMains_PosMainId",
                        column: x => x.PosMainId,
                        principalTable: "PosMains",
                        principalColumn: "PosMainId");
                });

            migrationBuilder.CreateTable(
                name: "PosReturnMains",
                columns: table => new
                {
                    PosReturnMainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    PosReturnGUID = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PosMainId = table.Column<int>(type: "int", nullable: false),
                    PosReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    GrossAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeductionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RedeemableAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditSettledAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Used = table.Column<bool>(type: "bit", nullable: false),
                    Prepared_UserId = table.Column<int>(type: "int", nullable: false),
                    Prepared_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_UserId = table.Column<int>(type: "int", nullable: false),
                    Modified_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosReturnMains", x => x.PosReturnMainId);
                    table.ForeignKey(
                        name: "FK_PosReturnMains_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_PosReturnMains_PosMains_PosMainId",
                        column: x => x.PosMainId,
                        principalTable: "PosMains",
                        principalColumn: "PosMainId");
                    table.ForeignKey(
                        name: "FK_PosReturnMains_Users_Modified_UserId",
                        column: x => x.Modified_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_PosReturnMains_Users_Prepared_UserId",
                        column: x => x.Prepared_UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "SupplierPaymentSubs",
                columns: table => new
                {
                    SupplierPaymentSubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    SupplierPaymentMainId = table.Column<int>(type: "int", nullable: false),
                    GrnMainId = table.Column<int>(type: "int", nullable: false),
                    SettledAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPaymentSubs", x => x.SupplierPaymentSubId);
                    table.ForeignKey(
                        name: "FK_SupplierPaymentSubs_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_SupplierPaymentSubs_GrnMains_GrnMainId",
                        column: x => x.GrnMainId,
                        principalTable: "GrnMains",
                        principalColumn: "GrnMainId");
                    table.ForeignKey(
                        name: "FK_SupplierPaymentSubs_SupplierPaymentMains_SupplierPaymentMainId",
                        column: x => x.SupplierPaymentMainId,
                        principalTable: "SupplierPaymentMains",
                        principalColumn: "SupplierPaymentMainId");
                });

            migrationBuilder.CreateTable(
                name: "ItemPriceVariants",
                columns: table => new
                {
                    ItemPriceVariantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    MRP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    POS_MaxDiscountPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    POS_MaxDiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MOB_DiscountPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MOB_DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPriceVariants", x => new { x.ItemId, x.ItemPriceVariantId });
                    table.ForeignKey(
                        name: "FK_ItemPriceVariants_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_ItemPriceVariants_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "GrnSubs",
                columns: table => new
                {
                    GrnSubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrnMainId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemPriceVariantId = table.Column<int>(type: "int", nullable: false),
                    CostPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrnQty = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrnSubs", x => new { x.GrnMainId, x.GrnSubId });
                    table.ForeignKey(
                        name: "FK_GrnSubs_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_GrnSubs_GrnMains_GrnMainId",
                        column: x => x.GrnMainId,
                        principalTable: "GrnMains",
                        principalColumn: "GrnMainId");
                    table.ForeignKey(
                        name: "FK_GrnSubs_ItemPriceVariants_ItemId_ItemPriceVariantId",
                        columns: x => new { x.ItemId, x.ItemPriceVariantId },
                        principalTable: "ItemPriceVariants",
                        principalColumns: new[] { "ItemId", "ItemPriceVariantId" });
                    table.ForeignKey(
                        name: "FK_GrnSubs_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "MobileOrderSubs",
                columns: table => new
                {
                    MobileOrderSubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    MobileOrderMainId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemPriceVariantId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountedSellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileOrderSubs", x => x.MobileOrderSubId);
                    table.ForeignKey(
                        name: "FK_MobileOrderSubs_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_MobileOrderSubs_ItemPriceVariants_ItemId_ItemPriceVariantId",
                        columns: x => new { x.ItemId, x.ItemPriceVariantId },
                        principalTable: "ItemPriceVariants",
                        principalColumns: new[] { "ItemId", "ItemPriceVariantId" });
                    table.ForeignKey(
                        name: "FK_MobileOrderSubs_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                    table.ForeignKey(
                        name: "FK_MobileOrderSubs_MobileOrderMains_MobileOrderMainId",
                        column: x => x.MobileOrderMainId,
                        principalTable: "MobileOrderMains",
                        principalColumn: "MobileOrderMainId");
                });

            migrationBuilder.CreateTable(
                name: "PosSubs",
                columns: table => new
                {
                    PosSubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosMainId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemPriceVariantId = table.Column<int>(type: "int", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountedSellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PosQty = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosSubs", x => new { x.PosMainId, x.PosSubId });
                    table.ForeignKey(
                        name: "FK_PosSubs_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_PosSubs_ItemPriceVariants_ItemId_ItemPriceVariantId",
                        columns: x => new { x.ItemId, x.ItemPriceVariantId },
                        principalTable: "ItemPriceVariants",
                        principalColumns: new[] { "ItemId", "ItemPriceVariantId" });
                    table.ForeignKey(
                        name: "FK_PosSubs_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                    table.ForeignKey(
                        name: "FK_PosSubs_PosMains_PosMainId",
                        column: x => x.PosMainId,
                        principalTable: "PosMains",
                        principalColumn: "PosMainId");
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemPriceVariantId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    RatingStar = table.Column<int>(type: "int", nullable: false),
                    RatingReview = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_Ratings_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_Ratings_ItemPriceVariants_ItemId_ItemPriceVariantId",
                        columns: x => new { x.ItemId, x.ItemPriceVariantId },
                        principalTable: "ItemPriceVariants",
                        principalColumns: new[] { "ItemId", "ItemPriceVariantId" });
                    table.ForeignKey(
                        name: "FK_Ratings_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemPriceVariantId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ShoppingCartId);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_ItemPriceVariants_ItemId_ItemPriceVariantId",
                        columns: x => new { x.ItemId, x.ItemPriceVariantId },
                        principalTable: "ItemPriceVariants",
                        principalColumns: new[] { "ItemId", "ItemPriceVariantId" });
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "ViewedItems",
                columns: table => new
                {
                    ViewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemPriceVariantId = table.Column<int>(type: "int", nullable: false),
                    ViewedCount = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLastViewed = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewedItems", x => x.ViewId);
                    table.ForeignKey(
                        name: "FK_ViewedItems_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_ViewedItems_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_ViewedItems_ItemPriceVariants_ItemId_ItemPriceVariantId",
                        columns: x => new { x.ItemId, x.ItemPriceVariantId },
                        principalTable: "ItemPriceVariants",
                        principalColumns: new[] { "ItemId", "ItemPriceVariantId" });
                    table.ForeignKey(
                        name: "FK_ViewedItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    WishListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemPriceVariantId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.WishListId);
                    table.ForeignKey(
                        name: "FK_WishLists_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_WishLists_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_WishLists_ItemPriceVariants_ItemId_ItemPriceVariantId",
                        columns: x => new { x.ItemId, x.ItemPriceVariantId },
                        principalTable: "ItemPriceVariants",
                        principalColumns: new[] { "ItemId", "ItemPriceVariantId" });
                    table.ForeignKey(
                        name: "FK_WishLists_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "GrnReturnSubs",
                columns: table => new
                {
                    GrnReturnSubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    GrnReturnMainId = table.Column<int>(type: "int", nullable: false),
                    GrnMainId = table.Column<int>(type: "int", nullable: false),
                    GrnSubId = table.Column<int>(type: "int", nullable: false),
                    ReturnedQty = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrnReturnSubs", x => x.GrnReturnSubId);
                    table.ForeignKey(
                        name: "FK_GrnReturnSubs_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_GrnReturnSubs_GrnMains_GrnMainId",
                        column: x => x.GrnMainId,
                        principalTable: "GrnMains",
                        principalColumn: "GrnMainId");
                    table.ForeignKey(
                        name: "FK_GrnReturnSubs_GrnReturnMains_GrnReturnMainId",
                        column: x => x.GrnReturnMainId,
                        principalTable: "GrnReturnMains",
                        principalColumn: "GrnReturnMainId");
                    table.ForeignKey(
                        name: "FK_GrnReturnSubs_GrnSubs_GrnMainId_GrnSubId",
                        columns: x => new { x.GrnMainId, x.GrnSubId },
                        principalTable: "GrnSubs",
                        principalColumns: new[] { "GrnMainId", "GrnSubId" });
                });

            migrationBuilder.CreateTable(
                name: "PosReturnSubs",
                columns: table => new
                {
                    PosReturnSubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    PosReturnMainId = table.Column<int>(type: "int", nullable: false),
                    PosMainId = table.Column<int>(type: "int", nullable: false),
                    PosSubId = table.Column<int>(type: "int", nullable: false),
                    ReturnedQty = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    DiscountedSellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosReturnSubs", x => x.PosReturnSubId);
                    table.ForeignKey(
                        name: "FK_PosReturnSubs_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_PosReturnSubs_PosMains_PosMainId",
                        column: x => x.PosMainId,
                        principalTable: "PosMains",
                        principalColumn: "PosMainId");
                    table.ForeignKey(
                        name: "FK_PosReturnSubs_PosReturnMains_PosReturnMainId",
                        column: x => x.PosReturnMainId,
                        principalTable: "PosReturnMains",
                        principalColumn: "PosReturnMainId");
                    table.ForeignKey(
                        name: "FK_PosReturnSubs_PosSubs_PosMainId_PosSubId",
                        columns: x => new { x.PosMainId, x.PosSubId },
                        principalTable: "PosSubs",
                        principalColumns: new[] { "PosMainId", "PosSubId" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_BranchId",
                table: "Advertisements",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_BranchId",
                table: "Brands",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CarouselImages_BranchId",
                table: "CarouselImages",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BranchId",
                table: "Categories",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_BranchId",
                table: "Clients",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPaymentMains_BranchId",
                table: "CustomerPaymentMains",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPaymentMains_CustomerId",
                table: "CustomerPaymentMains",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPaymentMains_Modified_UserId",
                table: "CustomerPaymentMains",
                column: "Modified_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPaymentMains_Prepared_UserId",
                table: "CustomerPaymentMains",
                column: "Prepared_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPaymentSubs_BranchId",
                table: "CustomerPaymentSubs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPaymentSubs_CustomerPaymentMainId",
                table: "CustomerPaymentSubs",
                column: "CustomerPaymentMainId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPaymentSubs_PosMainId",
                table: "CustomerPaymentSubs",
                column: "PosMainId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPointRedeems_BranchId",
                table: "CustomerPointRedeems",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPointRedeems_CustomerId",
                table: "CustomerPointRedeems",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BranchId",
                table: "Customers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryCities_BranchId",
                table: "DeliveryCities",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryTimes_BranchId",
                table: "DeliveryTimes",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnMains_BranchId",
                table: "GrnMains",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnMains_Modified_UserId",
                table: "GrnMains",
                column: "Modified_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnMains_Prepared_UserId",
                table: "GrnMains",
                column: "Prepared_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnMains_SupplierId",
                table: "GrnMains",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnReturnMains_BranchId",
                table: "GrnReturnMains",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnReturnMains_GrnMainId",
                table: "GrnReturnMains",
                column: "GrnMainId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnReturnMains_Modified_UserId",
                table: "GrnReturnMains",
                column: "Modified_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnReturnMains_Prepared_UserId",
                table: "GrnReturnMains",
                column: "Prepared_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnReturnSubs_BranchId",
                table: "GrnReturnSubs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnReturnSubs_GrnMainId_GrnSubId",
                table: "GrnReturnSubs",
                columns: new[] { "GrnMainId", "GrnSubId" });

            migrationBuilder.CreateIndex(
                name: "IX_GrnReturnSubs_GrnReturnMainId_GrnReturnSubId_GrnSubId",
                table: "GrnReturnSubs",
                columns: new[] { "GrnReturnMainId", "GrnReturnSubId", "GrnSubId" });

            migrationBuilder.CreateIndex(
                name: "IX_GrnSubs_BranchId",
                table: "GrnSubs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GrnSubs_GrnMainId_GrnSubId_ItemId_ItemPriceVariantId",
                table: "GrnSubs",
                columns: new[] { "GrnMainId", "GrnSubId", "ItemId", "ItemPriceVariantId" });

            migrationBuilder.CreateIndex(
                name: "IX_GrnSubs_ItemId_ItemPriceVariantId",
                table: "GrnSubs",
                columns: new[] { "ItemId", "ItemPriceVariantId" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemPriceVariants_BranchId",
                table: "ItemPriceVariants",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPriceVariants_ItemPriceVariantId_ItemId",
                table: "ItemPriceVariants",
                columns: new[] { "ItemPriceVariantId", "ItemId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_BranchId",
                table: "Items",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_BrandId",
                table: "Items",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId_SubCategoryId",
                table: "Items",
                columns: new[] { "CategoryId", "SubCategoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_Items_DeliveryTimeId",
                table: "Items",
                column: "DeliveryTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemName",
                table: "Items",
                column: "ItemName");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemName_SKUBarcode",
                table: "Items",
                columns: new[] { "ItemName", "SKUBarcode" });

            migrationBuilder.CreateIndex(
                name: "IX_Items_SKUBarcode",
                table: "Items",
                column: "SKUBarcode");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UOMId",
                table: "Items",
                column: "UOMId");

            migrationBuilder.CreateIndex(
                name: "IX_MailSettings_BranchId_Active",
                table: "MailSettings",
                columns: new[] { "BranchId", "Active" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MobileOrderMains_BranchId",
                table: "MobileOrderMains",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileOrderMains_ClientId",
                table: "MobileOrderMains",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileOrderMains_DeliveryCityId",
                table: "MobileOrderMains",
                column: "DeliveryCityId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileOrderMains_OrderGUID",
                table: "MobileOrderMains",
                column: "OrderGUID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MobileOrderMains_OrderStatusId",
                table: "MobileOrderMains",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileOrderMains_PaidStatusId",
                table: "MobileOrderMains",
                column: "PaidStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileOrderSubs_BranchId",
                table: "MobileOrderSubs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileOrderSubs_ItemId_ItemPriceVariantId_OrderStatusId",
                table: "MobileOrderSubs",
                columns: new[] { "ItemId", "ItemPriceVariantId", "OrderStatusId" });

            migrationBuilder.CreateIndex(
                name: "IX_MobileOrderSubs_MobileOrderMainId",
                table: "MobileOrderSubs",
                column: "MobileOrderMainId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileOrderSubs_MobileOrderMainId_MobileOrderSubId",
                table: "MobileOrderSubs",
                columns: new[] { "MobileOrderMainId", "MobileOrderSubId" });

            migrationBuilder.CreateIndex(
                name: "IX_PosMains_BranchId",
                table: "PosMains",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_PosMains_CustomerId",
                table: "PosMains",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PosMains_Modified_UserId",
                table: "PosMains",
                column: "Modified_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PosMains_PosGUID",
                table: "PosMains",
                column: "PosGUID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PosMains_Prepared_UserId",
                table: "PosMains",
                column: "Prepared_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PosReturnMains_BranchId",
                table: "PosReturnMains",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_PosReturnMains_Modified_UserId",
                table: "PosReturnMains",
                column: "Modified_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PosReturnMains_PosMainId",
                table: "PosReturnMains",
                column: "PosMainId");

            migrationBuilder.CreateIndex(
                name: "IX_PosReturnMains_PosReturnGUID",
                table: "PosReturnMains",
                column: "PosReturnGUID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PosReturnMains_Prepared_UserId",
                table: "PosReturnMains",
                column: "Prepared_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PosReturnSubs_BranchId",
                table: "PosReturnSubs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_PosReturnSubs_PosMainId_PosSubId",
                table: "PosReturnSubs",
                columns: new[] { "PosMainId", "PosSubId" });

            migrationBuilder.CreateIndex(
                name: "IX_PosReturnSubs_PosReturnMainId_PosReturnSubId_PosSubId",
                table: "PosReturnSubs",
                columns: new[] { "PosReturnMainId", "PosReturnSubId", "PosSubId" });

            migrationBuilder.CreateIndex(
                name: "IX_PosSubs_BranchId",
                table: "PosSubs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_PosSubs_ItemId_ItemPriceVariantId",
                table: "PosSubs",
                columns: new[] { "ItemId", "ItemPriceVariantId" });

            migrationBuilder.CreateIndex(
                name: "IX_PosSubs_PosMainId_PosSubId_ItemId_ItemPriceVariantId",
                table: "PosSubs",
                columns: new[] { "PosMainId", "PosSubId", "ItemId", "ItemPriceVariantId" });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_BranchId",
                table: "Ratings",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ClientId",
                table: "Ratings",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ItemId_ItemPriceVariantId",
                table: "Ratings",
                columns: new[] { "ItemId", "ItemPriceVariantId" });

            migrationBuilder.CreateIndex(
                name: "IX_Serials_BranchId",
                table: "Serials",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_BranchId",
                table: "ShoppingCarts",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ClientId",
                table: "ShoppingCarts",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ClientId_ItemId_ItemPriceVariantId",
                table: "ShoppingCarts",
                columns: new[] { "ClientId", "ItemId", "ItemPriceVariantId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ItemId_ItemPriceVariantId",
                table: "ShoppingCarts",
                columns: new[] { "ItemId", "ItemPriceVariantId" });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_BranchId",
                table: "SubCategories",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId_SubCategoryId",
                table: "SubCategories",
                columns: new[] { "CategoryId", "SubCategoryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId_SubCategoryName",
                table: "SubCategories",
                columns: new[] { "CategoryId", "SubCategoryName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentMains_BranchId",
                table: "SupplierPaymentMains",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentMains_Modified_UserId",
                table: "SupplierPaymentMains",
                column: "Modified_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentMains_Prepared_UserId",
                table: "SupplierPaymentMains",
                column: "Prepared_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentMains_SupplierId",
                table: "SupplierPaymentMains",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentSubs_BranchId",
                table: "SupplierPaymentSubs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentSubs_GrnMainId",
                table: "SupplierPaymentSubs",
                column: "GrnMainId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentSubs_SupplierPaymentMainId",
                table: "SupplierPaymentSubs",
                column: "SupplierPaymentMainId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_BranchId",
                table: "Suppliers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_UOMs_BranchId",
                table: "UOMs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BranchId",
                table: "Users",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName_Password",
                table: "Users",
                columns: new[] { "UserName", "Password" });

            migrationBuilder.CreateIndex(
                name: "IX_ViewedItems_BranchId",
                table: "ViewedItems",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewedItems_ClientId",
                table: "ViewedItems",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewedItems_ClientId_ItemId_ItemPriceVariantId",
                table: "ViewedItems",
                columns: new[] { "ClientId", "ItemId", "ItemPriceVariantId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ViewedItems_ItemId_ItemPriceVariantId",
                table: "ViewedItems",
                columns: new[] { "ItemId", "ItemPriceVariantId" });

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_BranchId",
                table: "WishLists",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_ClientId",
                table: "WishLists",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_ClientId_ItemId_ItemPriceVariantId",
                table: "WishLists",
                columns: new[] { "ClientId", "ItemId", "ItemPriceVariantId" });

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_ItemId_ItemPriceVariantId",
                table: "WishLists",
                columns: new[] { "ItemId", "ItemPriceVariantId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "CarouselImages");

            migrationBuilder.DropTable(
                name: "CustomerPaymentSubs");

            migrationBuilder.DropTable(
                name: "CustomerPointRedeems");

            migrationBuilder.DropTable(
                name: "GrnReturnSubs");

            migrationBuilder.DropTable(
                name: "MailSettings");

            migrationBuilder.DropTable(
                name: "MobileOrderSubs");

            migrationBuilder.DropTable(
                name: "PosReturnSubs");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Serials");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "SupplierPaymentSubs");

            migrationBuilder.DropTable(
                name: "ViewedItems");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "CustomerPaymentMains");

            migrationBuilder.DropTable(
                name: "GrnReturnMains");

            migrationBuilder.DropTable(
                name: "GrnSubs");

            migrationBuilder.DropTable(
                name: "MobileOrderMains");

            migrationBuilder.DropTable(
                name: "PosReturnMains");

            migrationBuilder.DropTable(
                name: "PosSubs");

            migrationBuilder.DropTable(
                name: "SupplierPaymentMains");

            migrationBuilder.DropTable(
                name: "GrnMains");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "DeliveryCities");

            migrationBuilder.DropTable(
                name: "ItemPriceVariants");

            migrationBuilder.DropTable(
                name: "PosMains");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "DeliveryTimes");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "UOMs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropColumn(
                name: "AdvertisementImageUri",
                table: "Setups");

            migrationBuilder.RenameColumn(
                name: "CrystalReportPath",
                table: "Setups",
                newName: "CyrstalReportPath");

            migrationBuilder.AlterColumn<string>(
                name: "MainAPIUri",
                table: "Setups",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
