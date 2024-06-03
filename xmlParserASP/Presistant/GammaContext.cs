using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.Gamma;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using xmlParserASP.Entities.Users;
using Microsoft.AspNetCore.Identity;

namespace xmlParserASP.Presistant;

public partial class GammaContext : DbContext
{
    public GammaContext()
    {
    }

    public GammaContext(DbContextOptions<GammaContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSnakeCaseNamingConvention();
    }


    public virtual DbSet<AttributeDescription> AttributeDescriptions { get; set; }

    public virtual DbSet<EfmigrationsHistory> EfmigrationsHistories { get; set; }

    public virtual DbSet<MmSupplier> MmSuppliers { get; set; }

    public virtual DbSet<MmSupplierXmlSetting> MmSupplierXmlSettings { get; set; }

    public virtual DbSet<NgAddress> NgAddresses { get; set; }

    public virtual DbSet<NgAddressSimpleField> NgAddressSimpleFields { get; set; }

    public virtual DbSet<NgApi> NgApis { get; set; }

    public virtual DbSet<NgApiIp> NgApiIps { get; set; }

    public virtual DbSet<NgApiSession> NgApiSessions { get; set; }

    public virtual DbSet<NgArticle> NgArticles { get; set; }

    public virtual DbSet<NgArticleDescription> NgArticleDescriptions { get; set; }

    public virtual DbSet<NgArticleImage> NgArticleImages { get; set; }

    public virtual DbSet<NgArticleRelated> NgArticleRelateds { get; set; }

    public virtual DbSet<NgArticleRelatedMn> NgArticleRelatedMns { get; set; }

    public virtual DbSet<NgArticleRelatedProduct> NgArticleRelatedProducts { get; set; }

    public virtual DbSet<NgArticleRelatedWb> NgArticleRelatedWbs { get; set; }

    public virtual DbSet<NgArticleToBlogCategory> NgArticleToBlogCategories { get; set; }

    public virtual DbSet<NgArticleToDownload> NgArticleToDownloads { get; set; }

    public virtual DbSet<NgArticleToLayout> NgArticleToLayouts { get; set; }

    public virtual DbSet<NgArticleToStore> NgArticleToStores { get; set; }

    public virtual DbSet<NgAttribute> NgAttributes { get; set; }

    public virtual DbSet<NgAttributeDescription> NgAttributeDescriptions { get; set; }

    public virtual DbSet<NgAttributeGroup> NgAttributeGroups { get; set; }

    public virtual DbSet<NgAttributeGroupDescription> NgAttributeGroupDescriptions { get; set; }

    public virtual DbSet<NgBanner> NgBanners { get; set; }

    public virtual DbSet<NgBannerImage> NgBannerImages { get; set; }

    public virtual DbSet<NgBlogCategory> NgBlogCategories { get; set; }

    public virtual DbSet<NgBlogCategoryDescription> NgBlogCategoryDescriptions { get; set; }

    public virtual DbSet<NgBlogCategoryPath> NgBlogCategoryPaths { get; set; }

    public virtual DbSet<NgBlogCategoryToLayout> NgBlogCategoryToLayouts { get; set; }

    public virtual DbSet<NgBlogCategoryToStore> NgBlogCategoryToStores { get; set; }

    public virtual DbSet<NgCart> NgCarts { get; set; }

    public virtual DbSet<NgCategory> NgCategories { get; set; }

    public virtual DbSet<NgCategoryDescription> NgCategoryDescriptions { get; set; }

    public virtual DbSet<NgCategoryFilter> NgCategoryFilters { get; set; }

    public virtual DbSet<NgCategoryPath> NgCategoryPaths { get; set; }

    public virtual DbSet<NgCategoryToLayout> NgCategoryToLayouts { get; set; }

    public virtual DbSet<NgCategoryToPromCategory> NgCategoryToPromCategories { get; set; }

    public virtual DbSet<NgCategoryToStore> NgCategoryToStores { get; set; }

    public virtual DbSet<NgCountry> NgCountries { get; set; }

    public virtual DbSet<NgCoupon> NgCoupons { get; set; }

    public virtual DbSet<NgCouponCategory> NgCouponCategories { get; set; }

    public virtual DbSet<NgCouponHistory> NgCouponHistories { get; set; }

    public virtual DbSet<NgCouponProduct> NgCouponProducts { get; set; }

    public virtual DbSet<NgCurrency> NgCurrencies { get; set; }

    public virtual DbSet<NgCustomField> NgCustomFields { get; set; }

    public virtual DbSet<NgCustomFieldCustomerGroup> NgCustomFieldCustomerGroups { get; set; }

    public virtual DbSet<NgCustomFieldDescription> NgCustomFieldDescriptions { get; set; }

    public virtual DbSet<NgCustomFieldValue> NgCustomFieldValues { get; set; }

    public virtual DbSet<NgCustomFieldValueDescription> NgCustomFieldValueDescriptions { get; set; }

    public virtual DbSet<NgCustomer> NgCustomers { get; set; }

    public virtual DbSet<NgCustomerActivity> NgCustomerActivities { get; set; }

    public virtual DbSet<NgCustomerAffiliate> NgCustomerAffiliates { get; set; }

    public virtual DbSet<NgCustomerApproval> NgCustomerApprovals { get; set; }

    public virtual DbSet<NgCustomerGroup> NgCustomerGroups { get; set; }

    public virtual DbSet<NgCustomerGroupDescription> NgCustomerGroupDescriptions { get; set; }

    public virtual DbSet<NgCustomerHistory> NgCustomerHistories { get; set; }

    public virtual DbSet<NgCustomerIp> NgCustomerIps { get; set; }

    public virtual DbSet<NgCustomerLogin> NgCustomerLogins { get; set; }

    public virtual DbSet<NgCustomerOnline> NgCustomerOnlines { get; set; }

    public virtual DbSet<NgCustomerReward> NgCustomerRewards { get; set; }

    public virtual DbSet<NgCustomerSearch> NgCustomerSearches { get; set; }

    public virtual DbSet<NgCustomerSimpleField> NgCustomerSimpleFields { get; set; }

    public virtual DbSet<NgCustomerTransaction> NgCustomerTransactions { get; set; }

    public virtual DbSet<NgCustomerWishlist> NgCustomerWishlists { get; set; }

    public virtual DbSet<NgDownload> NgDownloads { get; set; }

    public virtual DbSet<NgDownloadDescription> NgDownloadDescriptions { get; set; }

    public virtual DbSet<NgEvent> NgEvents { get; set; }

    public virtual DbSet<NgExtension> NgExtensions { get; set; }

    public virtual DbSet<NgExtensionInstall> NgExtensionInstalls { get; set; }

    public virtual DbSet<NgExtensionPath> NgExtensionPaths { get; set; }

    public virtual DbSet<NgFilter> NgFilters { get; set; }

    public virtual DbSet<NgFilterDescription> NgFilterDescriptions { get; set; }

    public virtual DbSet<NgFilterGroup> NgFilterGroups { get; set; }

    public virtual DbSet<NgFilterGroupDescription> NgFilterGroupDescriptions { get; set; }

    public virtual DbSet<NgGeoZone> NgGeoZones { get; set; }

    public virtual DbSet<NgGoogleshoppingCategory> NgGoogleshoppingCategories { get; set; }

    public virtual DbSet<NgGoogleshoppingProduct> NgGoogleshoppingProducts { get; set; }

    public virtual DbSet<NgGoogleshoppingProductStatus> NgGoogleshoppingProductStatuses { get; set; }

    public virtual DbSet<NgGoogleshoppingProductTarget> NgGoogleshoppingProductTargets { get; set; }

    public virtual DbSet<NgGoogleshoppingTarget> NgGoogleshoppingTargets { get; set; }

    public virtual DbSet<NgInformation> NgInformations { get; set; }

    public virtual DbSet<NgInformationDescription> NgInformationDescriptions { get; set; }

    public virtual DbSet<NgInformationToLayout> NgInformationToLayouts { get; set; }

    public virtual DbSet<NgInformationToStore> NgInformationToStores { get; set; }

    public virtual DbSet<NgLanguage> NgLanguages { get; set; }

    public virtual DbSet<NgLayout> NgLayouts { get; set; }

    public virtual DbSet<NgLayoutModule> NgLayoutModules { get; set; }

    public virtual DbSet<NgLayoutRoute> NgLayoutRoutes { get; set; }

    public virtual DbSet<NgLengthClass> NgLengthClasses { get; set; }

    public virtual DbSet<NgLengthClassDescription> NgLengthClassDescriptions { get; set; }

    public virtual DbSet<NgLicensesKm> NgLicensesKms { get; set; }

    public virtual DbSet<NgLocation> NgLocations { get; set; }

    public virtual DbSet<NgManufacturer> NgManufacturers { get; set; }

    public virtual DbSet<NgManufacturerDescription> NgManufacturerDescriptions { get; set; }

    public virtual DbSet<NgManufacturerToLayout> NgManufacturerToLayouts { get; set; }

    public virtual DbSet<NgManufacturerToStore> NgManufacturerToStores { get; set; }

    public virtual DbSet<NgMarketing> NgMarketings { get; set; }

    public virtual DbSet<NgModification> NgModifications { get; set; }

    public virtual DbSet<NgModificationBackup> NgModificationBackups { get; set; }

    public virtual DbSet<NgModule> NgModules { get; set; }

    public virtual DbSet<NgMultiXml> NgMultiXmls { get; set; }

    public virtual DbSet<NgMultiplicityProduct> NgMultiplicityProducts { get; set; }

    public virtual DbSet<NgNovaposhtaCity> NgNovaposhtaCities { get; set; }

    public virtual DbSet<NgNovaposhtaDepartment> NgNovaposhtaDepartments { get; set; }

    public virtual DbSet<NgNovaposhtaReference> NgNovaposhtaReferences { get; set; }

    public virtual DbSet<NgNovaposhtaRegion> NgNovaposhtaRegions { get; set; }

    public virtual DbSet<NgOcfilterAttributeCache> NgOcfilterAttributeCaches { get; set; }

    public virtual DbSet<NgOcfilterCache> NgOcfilterCaches { get; set; }

    public virtual DbSet<NgOcfilterFilter> NgOcfilterFilters { get; set; }

    public virtual DbSet<NgOcfilterFilterDescription> NgOcfilterFilterDescriptions { get; set; }

    public virtual DbSet<NgOcfilterFilterRangeToProduct> NgOcfilterFilterRangeToProducts { get; set; }

    public virtual DbSet<NgOcfilterFilterToCategory> NgOcfilterFilterToCategories { get; set; }

    public virtual DbSet<NgOcfilterFilterToStore> NgOcfilterFilterToStores { get; set; }

    public virtual DbSet<NgOcfilterFilterValue> NgOcfilterFilterValues { get; set; }

    public virtual DbSet<NgOcfilterFilterValueDescription> NgOcfilterFilterValueDescriptions { get; set; }

    public virtual DbSet<NgOcfilterFilterValueToProduct> NgOcfilterFilterValueToProducts { get; set; }

    public virtual DbSet<NgOcfilterPage> NgOcfilterPages { get; set; }

    public virtual DbSet<NgOcfilterPageDescription> NgOcfilterPageDescriptions { get; set; }

    public virtual DbSet<NgOcfilterPageToLayout> NgOcfilterPageToLayouts { get; set; }

    public virtual DbSet<NgOcfilterPageToStore> NgOcfilterPageToStores { get; set; }

    public virtual DbSet<NgOcfilterSetting> NgOcfilterSettings { get; set; }

    public virtual DbSet<NgOmproAdminSetting> NgOmproAdminSettings { get; set; }

    public virtual DbSet<NgOmproFieldsAdded> NgOmproFieldsAddeds { get; set; }

    public virtual DbSet<NgOmproFieldsSetting> NgOmproFieldsSettings { get; set; }

    public virtual DbSet<NgOmproGroupSetting> NgOmproGroupSettings { get; set; }

    public virtual DbSet<NgOmproTplBlock> NgOmproTplBlocks { get; set; }

    public virtual DbSet<NgOmproTplComment> NgOmproTplComments { get; set; }

    public virtual DbSet<NgOmproTplExcelOrder> NgOmproTplExcelOrders { get; set; }

    public virtual DbSet<NgOmproTplExcelOrdersProduct> NgOmproTplExcelOrdersProducts { get; set; }

    public virtual DbSet<NgOmproTplFilter> NgOmproTplFilters { get; set; }

    public virtual DbSet<NgOmproTplFilterProduct> NgOmproTplFilterProducts { get; set; }

    public virtual DbSet<NgOmproTplHistory> NgOmproTplHistories { get; set; }

    public virtual DbSet<NgOmproTplMail> NgOmproTplMails { get; set; }

    public virtual DbSet<NgOmproTplOption> NgOmproTplOptions { get; set; }

    public virtual DbSet<NgOmproTplOrder> NgOmproTplOrders { get; set; }

    public virtual DbSet<NgOmproTplPage> NgOmproTplPages { get; set; }

    public virtual DbSet<NgOmproTplPageBlock> NgOmproTplPageBlocks { get; set; }

    public virtual DbSet<NgOmproTplPrintOrder> NgOmproTplPrintOrders { get; set; }

    public virtual DbSet<NgOmproTplPrintOrdersTable> NgOmproTplPrintOrdersTables { get; set; }

    public virtual DbSet<NgOmproTplPrintProductsTable> NgOmproTplPrintProductsTables { get; set; }

    public virtual DbSet<NgOmproTplProduct> NgOmproTplProducts { get; set; }

    public virtual DbSet<NgOmproTplSm> NgOmproTplSms { get; set; }

    public virtual DbSet<NgOmproTplTlgrm> NgOmproTplTlgrms { get; set; }

    public virtual DbSet<NgOption> NgOptions { get; set; }

    public virtual DbSet<NgOptionDescription> NgOptionDescriptions { get; set; }

    public virtual DbSet<NgOptionValue> NgOptionValues { get; set; }

    public virtual DbSet<NgOptionValueDescription> NgOptionValueDescriptions { get; set; }

    public virtual DbSet<NgOrder> NgOrders { get; set; }

    public virtual DbSet<NgOrderHistory> NgOrderHistories { get; set; }

    public virtual DbSet<NgOrderOption> NgOrderOptions { get; set; }

    public virtual DbSet<NgOrderProduct> NgOrderProducts { get; set; }

    public virtual DbSet<NgOrderRecurring> NgOrderRecurrings { get; set; }

    public virtual DbSet<NgOrderRecurringTransaction> NgOrderRecurringTransactions { get; set; }

    public virtual DbSet<NgOrderShipment> NgOrderShipments { get; set; }

    public virtual DbSet<NgOrderSimpleField> NgOrderSimpleFields { get; set; }

    public virtual DbSet<NgOrderStatus> NgOrderStatuses { get; set; }

    public virtual DbSet<NgOrderTotal> NgOrderTotals { get; set; }

    public virtual DbSet<NgOrderVoucher> NgOrderVouchers { get; set; }

    public virtual DbSet<NgProduct> NgProducts { get; set; }

    public virtual DbSet<NgProductAttribute> NgProductAttributes { get; set; }

    public virtual DbSet<NgProductDescription> NgProductDescriptions { get; set; }

    public virtual DbSet<NgProductDiscount> NgProductDiscounts { get; set; }

    public virtual DbSet<NgProductFilter> NgProductFilters { get; set; }

    public virtual DbSet<NgProductImage> NgProductImages { get; set; }

    public virtual DbSet<NgProductOption> NgProductOptions { get; set; }

    public virtual DbSet<NgProductOptionValue> NgProductOptionValues { get; set; }

    public virtual DbSet<NgProductRecurring> NgProductRecurrings { get; set; }

    public virtual DbSet<NgProductRelated> NgProductRelateds { get; set; }

    public virtual DbSet<NgProductRelatedArticle> NgProductRelatedArticles { get; set; }

    public virtual DbSet<NgProductRelatedMn> NgProductRelatedMns { get; set; }

    public virtual DbSet<NgProductRelatedWb> NgProductRelatedWbs { get; set; }

    public virtual DbSet<NgProductReward> NgProductRewards { get; set; }

    public virtual DbSet<NgProductSpecial> NgProductSpecials { get; set; }

    public virtual DbSet<NgProductToCategory> NgProductToCategories { get; set; }

    public virtual DbSet<NgProductToDownload> NgProductToDownloads { get; set; }

    public virtual DbSet<NgProductToLayout> NgProductToLayouts { get; set; }

    public virtual DbSet<NgProductToPromProduct> NgProductToPromProducts { get; set; }

    public virtual DbSet<NgProductToStore> NgProductToStores { get; set; }

    public virtual DbSet<NgProductToSupplier> NgProductToSuppliers { get; set; }

    public virtual DbSet<NgPromCategory> NgPromCategories { get; set; }

    public virtual DbSet<NgPromId> NgPromIds { get; set; }

    public virtual DbSet<NgRecurring> NgRecurrings { get; set; }

    public virtual DbSet<NgRecurringDescription> NgRecurringDescriptions { get; set; }

    public virtual DbSet<NgRemarketingOrder> NgRemarketingOrders { get; set; }

    public virtual DbSet<NgReturn> NgReturns { get; set; }

    public virtual DbSet<NgReturnAction> NgReturnActions { get; set; }

    public virtual DbSet<NgReturnHistory> NgReturnHistories { get; set; }

    public virtual DbSet<NgReturnReason> NgReturnReasons { get; set; }

    public virtual DbSet<NgReturnStatus> NgReturnStatuses { get; set; }

    public virtual DbSet<NgReview> NgReviews { get; set; }

    public virtual DbSet<NgReviewArticle> NgReviewArticles { get; set; }

    public virtual DbSet<NgSeoTagsGenerator> NgSeoTagsGenerators { get; set; }

    public virtual DbSet<NgSeoTagsGeneratorCategoryCopy> NgSeoTagsGeneratorCategoryCopies { get; set; }

    public virtual DbSet<NgSeoTagsGeneratorCategoryDeclension> NgSeoTagsGeneratorCategoryDeclensions { get; set; }

    public virtual DbSet<NgSeoTagsGeneratorCategorySetting> NgSeoTagsGeneratorCategorySettings { get; set; }

    public virtual DbSet<NgSeoTagsGeneratorNotUse> NgSeoTagsGeneratorNotUses { get; set; }

    public virtual DbSet<NgSeoUrl> NgSeoUrls { get; set; }

    public virtual DbSet<NgSession> NgSessions { get; set; }

    public virtual DbSet<NgSetting> NgSettings { get; set; }

    public virtual DbSet<NgSettingSeolang> NgSettingSeolangs { get; set; }

    public virtual DbSet<NgShippingCourier> NgShippingCouriers { get; set; }

    public virtual DbSet<NgSimpleCart> NgSimpleCarts { get; set; }

    public virtual DbSet<NgStatistic> NgStatistics { get; set; }

    public virtual DbSet<NgStockStatus> NgStockStatuses { get; set; }

    public virtual DbSet<NgStore> NgStores { get; set; }

    public virtual DbSet<NgTaxClass> NgTaxClasses { get; set; }

    public virtual DbSet<NgTaxRate> NgTaxRates { get; set; }

    public virtual DbSet<NgTaxRateToCustomerGroup> NgTaxRateToCustomerGroups { get; set; }

    public virtual DbSet<NgTaxRule> NgTaxRules { get; set; }

    public virtual DbSet<NgTheme> NgThemes { get; set; }

    public virtual DbSet<NgTranslation> NgTranslations { get; set; }

    public virtual DbSet<NgUniGallery> NgUniGalleries { get; set; }

    public virtual DbSet<NgUniGalleryDescription> NgUniGalleryDescriptions { get; set; }

    public virtual DbSet<NgUniGalleryImage> NgUniGalleryImages { get; set; }

    public virtual DbSet<NgUniGalleryImageDescription> NgUniGalleryImageDescriptions { get; set; }

    public virtual DbSet<NgUniGalleryToStore> NgUniGalleryToStores { get; set; }

    public virtual DbSet<NgUniNewsCategory> NgUniNewsCategories { get; set; }

    public virtual DbSet<NgUniNewsCategoryDescription> NgUniNewsCategoryDescriptions { get; set; }

    public virtual DbSet<NgUniNewsCategoryPath> NgUniNewsCategoryPaths { get; set; }

    public virtual DbSet<NgUniNewsCategoryToStore> NgUniNewsCategoryToStores { get; set; }

    public virtual DbSet<NgUniNewsProductRelated> NgUniNewsProductRelateds { get; set; }

    public virtual DbSet<NgUniNewsStory> NgUniNewsStories { get; set; }

    public virtual DbSet<NgUniNewsStoryDescription> NgUniNewsStoryDescriptions { get; set; }

    public virtual DbSet<NgUniNewsStoryToCategory> NgUniNewsStoryToCategories { get; set; }

    public virtual DbSet<NgUniNewsStoryToStore> NgUniNewsStoryToStores { get; set; }

    public virtual DbSet<NgUniRequest> NgUniRequests { get; set; }

    public virtual DbSet<NgUniSetting> NgUniSettings { get; set; }

    public virtual DbSet<NgUpload> NgUploads { get; set; }

    public virtual DbSet<NgUser> NgUsers { get; set; }

    public virtual DbSet<NgUserGroup> NgUserGroups { get; set; }

    public virtual DbSet<NgVoucher> NgVouchers { get; set; }

    public virtual DbSet<NgVoucherHistory> NgVoucherHistories { get; set; }

    public virtual DbSet<NgVoucherTheme> NgVoucherThemes { get; set; }

    public virtual DbSet<NgVoucherThemeDescription> NgVoucherThemeDescriptions { get; set; }

    public virtual DbSet<NgWeightClass> NgWeightClasses { get; set; }

    public virtual DbSet<NgWeightClassDescription> NgWeightClassDescriptions { get; set; }

    public virtual DbSet<NgZone> NgZones { get; set; }

    public virtual DbSet<NgZoneToGeoZone> NgZoneToGeoZones { get; set; }

    public virtual DbSet<MmProductsManualSetPrice> ProductsManualSetPrices { get; set; }

    public virtual DbSet<MmProductsManualSetQuanity> ProductsManualSetQuanitys { get; set; }

    public virtual DbSet<MmProductsSetQuantityWhenMin> ProductsSetQuantityWhenMin { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
        //modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();
        //modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();


        modelBuilder.Entity<AttributeDescription>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("attribute_description");

            entity.Property(e => e.AttributeId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
        });

        modelBuilder.Entity<EfmigrationsHistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.ToTable("__EFMigrationsHistory");

            entity.Property(e => e.MigrationId)
                .HasMaxLength(50)
                .HasColumnName("migration_id");
            entity.Property(e => e.ProductVersion)
                .HasMaxLength(50)
                .HasColumnName("product_version");
        });

        modelBuilder.Entity<MmSupplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PRIMARY");

            entity.ToTable("mm_supplier");

            entity.Property(e => e.SupplierId)
                .HasColumnType("int(11)")
                .HasColumnName("supplier_id");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(50)
                .HasColumnName("supplier_name");
        });

        modelBuilder.Entity<MmSupplierXmlSetting>(entity =>
        {
            entity.HasKey(e => e.SupplierXmlSettingId).HasName("PRIMARY");

            entity.ToTable("mm_supplier_xml_settings");

            entity.HasIndex(e => e.SupplierId, "ix_mm_supplier_xml_settings_supplier_id");

            entity.Property(e => e.SupplierXmlSettingId)
                .HasColumnType("int(11)")
                .HasColumnName("supplier_xml_setting_id");
            entity.Property(e => e.CurrencyNode).HasColumnName("currency_node");
            entity.Property(e => e.DescriptionNode).HasColumnName("description_node");
            entity.Property(e => e.MainProductNode).HasColumnName("main_product_node");
            entity.Property(e => e.ModelNode).HasColumnName("model_node");
            entity.Property(e => e.ModelXlColumn).HasColumnName("model_xl_column");
            entity.Property(e => e.NameNode).HasColumnName("name_node");
            entity.Property(e => e.ParamAttrNode).HasColumnName("param_attr_node");
            entity.Property(e => e.ParamAttribute).HasColumnName("param_attribute");
            entity.Property(e => e.ParamNode).HasColumnName("param_node");
            entity.Property(e => e.Path).HasColumnName("path");
            entity.Property(e => e.PhotoFolder).HasColumnName("photo_folder");
            entity.Property(e => e.PictureNode).HasColumnName("picture_node");
            entity.Property(e => e.PricePictureXlColumn).HasColumnName("price_picture_xl_column");
            entity.Property(e => e.PriceNode).HasColumnName("price_node");
            entity.Property(e => e.ProductNode).HasColumnName("product_node");
            entity.Property(e => e.QtyInBoxColumnNumber).HasColumnName("qty_in_box_column_number");
            entity.Property(e => e.QuantityDbStock1).HasColumnName("quantity_db_stock1");
            entity.Property(e => e.QuantityDbStock2).HasColumnName("quantity_db_stock2");
            entity.Property(e => e.QuantityDbStock3).HasColumnName("quantity_db_stock3");
            entity.Property(e => e.QuantityDbStock4).HasColumnName("quantity_db_stock4");
            entity.Property(e => e.QuantityDbStock5).HasColumnName("quantity_db_stock5");
            entity.Property(e => e.QuantityLongTermNode).HasColumnName("quantity_long_term_node");
            entity.Property(e => e.QuantityNode).HasColumnName("quantity_node");
            entity.Property(e => e.SettingName).HasColumnName("setting_name");
            entity.Property(e => e.SupplierId)
                .HasColumnType("int(11)")
                .HasColumnName("supplier_id");
            entity.Property(e => e.SupplierNode).HasColumnName("supplier_node");
        });

        modelBuilder.Entity<NgAddress>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PRIMARY");

            entity.ToTable("ng_address");

            entity.HasIndex(e => e.CustomerId, "customer_id");

            entity.Property(e => e.AddressId)
                .HasColumnType("int(11)")
                .HasColumnName("address_id");
            entity.Property(e => e.Address1)
                .HasMaxLength(128)
                .HasColumnName("address_1");
            entity.Property(e => e.Address2)
                .HasMaxLength(128)
                .HasColumnName("address_2");
            entity.Property(e => e.City)
                .HasMaxLength(128)
                .HasColumnName("city");
            entity.Property(e => e.Company)
                .HasMaxLength(40)
                .HasColumnName("company");
            entity.Property(e => e.CountryId)
                .HasColumnType("int(11)")
                .HasColumnName("country_id");
            entity.Property(e => e.CustomField)
                .HasColumnType("text")
                .HasColumnName("custom_field");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.Firstname)
                .HasMaxLength(32)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(32)
                .HasColumnName("lastname");
            entity.Property(e => e.Postcode)
                .HasMaxLength(10)
                .HasColumnName("postcode");
            entity.Property(e => e.ZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("zone_id");
        });

        modelBuilder.Entity<NgAddressSimpleField>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PRIMARY");

            entity.ToTable("ng_address_simple_fields");

            entity.Property(e => e.AddressId)
                .HasColumnType("int(11)")
                .HasColumnName("address_id");
            entity.Property(e => e.Metadata)
                .HasColumnType("text")
                .HasColumnName("metadata");
        });

        modelBuilder.Entity<NgApi>(entity =>
        {
            entity.HasKey(e => e.ApiId).HasName("PRIMARY");

            entity.ToTable("ng_api");

            entity.Property(e => e.ApiId)
                .HasColumnType("int(11)")
                .HasColumnName("api_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Key)
                .HasColumnType("text")
                .HasColumnName("key");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .HasColumnName("username");
        });

        modelBuilder.Entity<NgApiIp>(entity =>
        {
            entity.HasKey(e => e.ApiIpId).HasName("PRIMARY");

            entity.ToTable("ng_api_ip");

            entity.Property(e => e.ApiIpId)
                .HasColumnType("int(11)")
                .HasColumnName("api_ip_id");
            entity.Property(e => e.ApiId)
                .HasColumnType("int(11)")
                .HasColumnName("api_id");
            entity.Property(e => e.Ip)
                .HasMaxLength(40)
                .HasColumnName("ip");
        });

        modelBuilder.Entity<NgApiSession>(entity =>
        {
            entity.HasKey(e => e.ApiSessionId).HasName("PRIMARY");

            entity.ToTable("ng_api_session");

            entity.Property(e => e.ApiSessionId)
                .HasColumnType("int(11)")
                .HasColumnName("api_session_id");
            entity.Property(e => e.ApiId)
                .HasColumnType("int(11)")
                .HasColumnName("api_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Ip)
                .HasMaxLength(40)
                .HasColumnName("ip");
            entity.Property(e => e.SessionId)
                .HasMaxLength(32)
                .HasColumnName("session_id");
        });

        modelBuilder.Entity<NgArticle>(entity =>
        {
            entity.HasKey(e => e.ArticleId).HasName("PRIMARY");

            entity.ToTable("ng_article");

            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.ArticleReview).HasColumnName("article_review");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateAvailable)
                .HasColumnType("date")
                .HasColumnName("date_available");
            entity.Property(e => e.DateModified)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Gstatus)
                .HasColumnType("int(11)")
                .HasColumnName("gstatus");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Noindex)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("noindex");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(11)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Viewed)
                .HasColumnType("int(5)")
                .HasColumnName("viewed");
        });

        modelBuilder.Entity<NgArticleDescription>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_article_description");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaH1)
                .HasMaxLength(255)
                .HasColumnName("meta_h1");
            entity.Property(e => e.MetaKeyword)
                .HasMaxLength(255)
                .HasColumnName("meta_keyword");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("tag");
        });

        modelBuilder.Entity<NgArticleImage>(entity =>
        {
            entity.HasKey(e => e.ArticleImageId).HasName("PRIMARY");

            entity.ToTable("ng_article_image");

            entity.Property(e => e.ArticleImageId)
                .HasColumnType("int(11)")
                .HasColumnName("article_image_id");
            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgArticleRelated>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.RelatedId }).HasName("PRIMARY");

            entity.ToTable("ng_article_related");

            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.RelatedId)
                .HasColumnType("int(11)")
                .HasColumnName("related_id");
        });

        modelBuilder.Entity<NgArticleRelatedMn>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.ManufacturerId }).HasName("PRIMARY");

            entity.ToTable("ng_article_related_mn");

            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.ManufacturerId)
                .HasColumnType("int(11)")
                .HasColumnName("manufacturer_id");
        });

        modelBuilder.Entity<NgArticleRelatedProduct>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.ProductId }).HasName("PRIMARY");

            entity.ToTable("ng_article_related_product");

            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
        });

        modelBuilder.Entity<NgArticleRelatedWb>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.CategoryId }).HasName("PRIMARY");

            entity.ToTable("ng_article_related_wb");

            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
        });

        modelBuilder.Entity<NgArticleToBlogCategory>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.BlogCategoryId }).HasName("PRIMARY");

            entity.ToTable("ng_article_to_blog_category");

            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.BlogCategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("blog_category_id");
            entity.Property(e => e.MainBlogCategory).HasColumnName("main_blog_category");
        });

        modelBuilder.Entity<NgArticleToDownload>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.DownloadId }).HasName("PRIMARY");

            entity.ToTable("ng_article_to_download");

            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.DownloadId)
                .HasColumnType("int(11)")
                .HasColumnName("download_id");
        });

        modelBuilder.Entity<NgArticleToLayout>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_article_to_layout");

            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.LayoutId)
                .HasColumnType("int(11)")
                .HasColumnName("layout_id");
        });

        modelBuilder.Entity<NgArticleToStore>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_article_to_store");

            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgAttribute>(entity =>
        {
            entity.HasKey(e => e.AttributeId).HasName("PRIMARY");

            entity.ToTable("ng_attribute");

            entity.Property(e => e.AttributeId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_id");
            entity.Property(e => e.AttributeGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_group_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgAttributeDescription>(entity =>
        {
            entity.HasKey(e => new { e.AttributeId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_attribute_description");

            entity.Property(e => e.AttributeId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgAttributeGroup>(entity =>
        {
            entity.HasKey(e => e.AttributeGroupId).HasName("PRIMARY");

            entity.ToTable("ng_attribute_group");

            entity.Property(e => e.AttributeGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_group_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgAttributeGroupDescription>(entity =>
        {
            entity.HasKey(e => new { e.AttributeGroupId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_attribute_group_description");

            entity.Property(e => e.AttributeGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_group_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgBanner>(entity =>
        {
            entity.HasKey(e => e.BannerId).HasName("PRIMARY");

            entity.ToTable("ng_banner");

            entity.Property(e => e.BannerId)
                .HasColumnType("int(11)")
                .HasColumnName("banner_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<NgBannerImage>(entity =>
        {
            entity.HasKey(e => e.BannerImageId).HasName("PRIMARY");

            entity.ToTable("ng_banner_image");

            entity.Property(e => e.BannerImageId)
                .HasColumnType("int(11)")
                .HasColumnName("banner_image_id");
            entity.Property(e => e.BannerId)
                .HasColumnType("int(11)")
                .HasColumnName("banner_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Title)
                .HasMaxLength(64)
                .HasColumnName("title");
        });

        modelBuilder.Entity<NgBlogCategory>(entity =>
        {
            entity.HasKey(e => e.BlogCategoryId).HasName("PRIMARY");

            entity.ToTable("ng_blog_category");

            entity.Property(e => e.BlogCategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("blog_category_id");
            entity.Property(e => e.Column)
                .HasColumnType("int(3)")
                .HasColumnName("column");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Noindex)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("noindex");
            entity.Property(e => e.ParentId)
                .HasColumnType("int(11)")
                .HasColumnName("parent_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Top).HasColumnName("top");
        });

        modelBuilder.Entity<NgBlogCategoryDescription>(entity =>
        {
            entity.HasKey(e => new { e.BlogCategoryId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_blog_category_description");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.BlogCategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("blog_category_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaH1)
                .HasMaxLength(255)
                .HasColumnName("meta_h1");
            entity.Property(e => e.MetaKeyword)
                .HasMaxLength(255)
                .HasColumnName("meta_keyword");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgBlogCategoryPath>(entity =>
        {
            entity.HasKey(e => new { e.BlogCategoryId, e.PathId }).HasName("PRIMARY");

            entity.ToTable("ng_blog_category_path");

            entity.Property(e => e.BlogCategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("blog_category_id");
            entity.Property(e => e.PathId)
                .HasColumnType("int(11)")
                .HasColumnName("path_id");
            entity.Property(e => e.Level)
                .HasColumnType("int(11)")
                .HasColumnName("level");
        });

        modelBuilder.Entity<NgBlogCategoryToLayout>(entity =>
        {
            entity.HasKey(e => new { e.BlogCategoryId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_blog_category_to_layout");

            entity.Property(e => e.BlogCategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("blog_category_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.LayoutId)
                .HasColumnType("int(11)")
                .HasColumnName("layout_id");
        });

        modelBuilder.Entity<NgBlogCategoryToStore>(entity =>
        {
            entity.HasKey(e => new { e.BlogCategoryId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_blog_category_to_store");

            entity.Property(e => e.BlogCategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("blog_category_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgCart>(entity =>
        {
            entity.HasKey(e => e.CartId).HasName("PRIMARY");

            entity.ToTable("ng_cart");

            entity.HasIndex(e => new { e.ApiId, e.CustomerId, e.SessionId, e.ProductId, e.RecurringId }, "cart_id");

            entity.Property(e => e.CartId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("cart_id");
            entity.Property(e => e.ApiId)
                .HasColumnType("int(11)")
                .HasColumnName("api_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Option)
                .HasColumnType("text")
                .HasColumnName("option");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(5)")
                .HasColumnName("quantity");
            entity.Property(e => e.RecurringId)
                .HasColumnType("int(11)")
                .HasColumnName("recurring_id");
            entity.Property(e => e.SessionId)
                .HasMaxLength(32)
                .HasColumnName("session_id");
        });

        modelBuilder.Entity<NgCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PRIMARY");

            entity.ToTable("ng_category");

            entity.HasIndex(e => e.ParentId, "parent_id");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.Column)
                .HasColumnType("int(3)")
                .HasColumnName("column");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Noindex)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("noindex");
            entity.Property(e => e.ParentId)
                .HasColumnType("int(11)")
                .HasColumnName("parent_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Top).HasColumnName("top");
        });

        modelBuilder.Entity<NgCategoryDescription>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_category_description");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaH1)
                .HasMaxLength(255)
                .HasColumnName("meta_h1");
            entity.Property(e => e.MetaKeyword)
                .HasMaxLength(255)
                .HasColumnName("meta_keyword");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<NgCategoryFilter>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.FilterId }).HasName("PRIMARY");

            entity.ToTable("ng_category_filter");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.FilterId)
                .HasColumnType("int(11)")
                .HasColumnName("filter_id");
        });

        modelBuilder.Entity<NgCategoryPath>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.PathId }).HasName("PRIMARY");

            entity.ToTable("ng_category_path");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.PathId)
                .HasColumnType("int(11)")
                .HasColumnName("path_id");
            entity.Property(e => e.Level)
                .HasColumnType("int(11)")
                .HasColumnName("level");
        });

        modelBuilder.Entity<NgCategoryToLayout>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_category_to_layout");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.LayoutId)
                .HasColumnType("int(11)")
                .HasColumnName("layout_id");
        });

        modelBuilder.Entity<NgCategoryToPromCategory>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.PromCategoryId }).HasName("PRIMARY");

            entity.ToTable("ng_category_to_prom_category");

            entity.HasIndex(e => e.PromCategoryId, "prom_category_id");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.PromCategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("prom_category_id");
        });

        modelBuilder.Entity<NgCategoryToStore>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_category_to_store");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PRIMARY");

            entity.ToTable("ng_country");

            entity.Property(e => e.CountryId)
                .HasColumnType("int(11)")
                .HasColumnName("country_id");
            entity.Property(e => e.AddressFormat)
                .HasColumnType("text")
                .HasColumnName("address_format");
            entity.Property(e => e.IsoCode2)
                .HasMaxLength(2)
                .HasColumnName("iso_code_2");
            entity.Property(e => e.IsoCode3)
                .HasMaxLength(3)
                .HasColumnName("iso_code_3");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.PostcodeRequired).HasColumnName("postcode_required");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<NgCoupon>(entity =>
        {
            entity.HasKey(e => e.CouponId).HasName("PRIMARY");

            entity.ToTable("ng_coupon");

            entity.Property(e => e.CouponId)
                .HasColumnType("int(11)")
                .HasColumnName("coupon_id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateEnd)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_end");
            entity.Property(e => e.DateStart)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_start");
            entity.Property(e => e.Discount)
                .HasPrecision(15, 4)
                .HasColumnName("discount");
            entity.Property(e => e.Logged).HasColumnName("logged");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.Shipping).HasColumnName("shipping");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Total)
                .HasPrecision(15, 4)
                .HasColumnName("total");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("type");
            entity.Property(e => e.UsesCustomer)
                .HasMaxLength(11)
                .HasColumnName("uses_customer");
            entity.Property(e => e.UsesTotal)
                .HasColumnType("int(11)")
                .HasColumnName("uses_total");
        });

        modelBuilder.Entity<NgCouponCategory>(entity =>
        {
            entity.HasKey(e => new { e.CouponId, e.CategoryId }).HasName("PRIMARY");

            entity.ToTable("ng_coupon_category");

            entity.Property(e => e.CouponId)
                .HasColumnType("int(11)")
                .HasColumnName("coupon_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
        });

        modelBuilder.Entity<NgCouponHistory>(entity =>
        {
            entity.HasKey(e => e.CouponHistoryId).HasName("PRIMARY");

            entity.ToTable("ng_coupon_history");

            entity.Property(e => e.CouponHistoryId)
                .HasColumnType("int(11)")
                .HasColumnName("coupon_history_id");
            entity.Property(e => e.Amount)
                .HasPrecision(15, 4)
                .HasColumnName("amount");
            entity.Property(e => e.CouponId)
                .HasColumnType("int(11)")
                .HasColumnName("coupon_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
        });

        modelBuilder.Entity<NgCouponProduct>(entity =>
        {
            entity.HasKey(e => e.CouponProductId).HasName("PRIMARY");

            entity.ToTable("ng_coupon_product");

            entity.Property(e => e.CouponProductId)
                .HasColumnType("int(11)")
                .HasColumnName("coupon_product_id");
            entity.Property(e => e.CouponId)
                .HasColumnType("int(11)")
                .HasColumnName("coupon_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
        });

        modelBuilder.Entity<NgCurrency>(entity =>
        {
            entity.HasKey(e => e.CurrencyId).HasName("PRIMARY");

            entity.ToTable("ng_currency");

            entity.Property(e => e.CurrencyId)
                .HasColumnType("int(11)")
                .HasColumnName("currency_id");
            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .HasColumnName("code");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.DecimalPlace)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("decimal_place");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SymbolLeft)
                .HasMaxLength(12)
                .HasColumnName("symbol_left");
            entity.Property(e => e.SymbolRight)
                .HasMaxLength(12)
                .HasColumnName("symbol_right");
            entity.Property(e => e.Title)
                .HasMaxLength(32)
                .HasColumnName("title");
            entity.Property(e => e.Value)
                .HasColumnType("double(15,8)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgCustomField>(entity =>
        {
            entity.HasKey(e => e.CustomFieldId).HasName("PRIMARY");

            entity.ToTable("ng_custom_field");

            entity.Property(e => e.CustomFieldId)
                .HasColumnType("int(11)")
                .HasColumnName("custom_field_id");
            entity.Property(e => e.Location)
                .HasMaxLength(10)
                .HasColumnName("location");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(32)
                .HasColumnName("type");
            entity.Property(e => e.Validation)
                .HasMaxLength(255)
                .HasColumnName("validation");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgCustomFieldCustomerGroup>(entity =>
        {
            entity.HasKey(e => new { e.CustomFieldId, e.CustomerGroupId }).HasName("PRIMARY");

            entity.ToTable("ng_custom_field_customer_group");

            entity.Property(e => e.CustomFieldId)
                .HasColumnType("int(11)")
                .HasColumnName("custom_field_id");
            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
            entity.Property(e => e.Required).HasColumnName("required");
        });

        modelBuilder.Entity<NgCustomFieldDescription>(entity =>
        {
            entity.HasKey(e => new { e.CustomFieldId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_custom_field_description");

            entity.Property(e => e.CustomFieldId)
                .HasColumnType("int(11)")
                .HasColumnName("custom_field_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgCustomFieldValue>(entity =>
        {
            entity.HasKey(e => e.CustomFieldValueId).HasName("PRIMARY");

            entity.ToTable("ng_custom_field_value");

            entity.Property(e => e.CustomFieldValueId)
                .HasColumnType("int(11)")
                .HasColumnName("custom_field_value_id");
            entity.Property(e => e.CustomFieldId)
                .HasColumnType("int(11)")
                .HasColumnName("custom_field_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgCustomFieldValueDescription>(entity =>
        {
            entity.HasKey(e => new { e.CustomFieldValueId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_custom_field_value_description");

            entity.Property(e => e.CustomFieldValueId)
                .HasColumnType("int(11)")
                .HasColumnName("custom_field_value_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.CustomFieldId)
                .HasColumnType("int(11)")
                .HasColumnName("custom_field_id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PRIMARY");

            entity.ToTable("ng_customer");

            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.AddressId)
                .HasColumnType("int(11)")
                .HasColumnName("address_id");
            entity.Property(e => e.Cart)
                .HasColumnType("text")
                .HasColumnName("cart");
            entity.Property(e => e.Code)
                .HasMaxLength(40)
                .HasColumnName("code");
            entity.Property(e => e.CustomField)
                .HasColumnType("text")
                .HasColumnName("custom_field");
            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(32)
                .HasColumnName("fax");
            entity.Property(e => e.Firstname)
                .HasMaxLength(32)
                .HasColumnName("firstname");
            entity.Property(e => e.Ip)
                .HasMaxLength(40)
                .HasColumnName("ip");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Lastname)
                .HasMaxLength(32)
                .HasColumnName("lastname");
            entity.Property(e => e.Newsletter).HasColumnName("newsletter");
            entity.Property(e => e.Password)
                .HasMaxLength(40)
                .HasColumnName("password");
            entity.Property(e => e.Safe).HasColumnName("safe");
            entity.Property(e => e.Salt)
                .HasMaxLength(9)
                .HasColumnName("salt");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.TelegramId)
                .HasColumnType("text")
                .HasColumnName("telegram_id");
            entity.Property(e => e.Telephone)
                .HasMaxLength(32)
                .HasColumnName("telephone");
            entity.Property(e => e.Token)
                .HasColumnType("text")
                .HasColumnName("token");
            entity.Property(e => e.Wishlist)
                .HasColumnType("text")
                .HasColumnName("wishlist");
        });

        modelBuilder.Entity<NgCustomerActivity>(entity =>
        {
            entity.HasKey(e => e.CustomerActivityId).HasName("PRIMARY");

            entity.ToTable("ng_customer_activity");

            entity.Property(e => e.CustomerActivityId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_activity_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Ip)
                .HasMaxLength(40)
                .HasColumnName("ip");
            entity.Property(e => e.Key)
                .HasMaxLength(64)
                .HasColumnName("key");
        });

        modelBuilder.Entity<NgCustomerAffiliate>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PRIMARY");

            entity.ToTable("ng_customer_affiliate");

            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.BankAccountName)
                .HasMaxLength(64)
                .HasColumnName("bank_account_name");
            entity.Property(e => e.BankAccountNumber)
                .HasMaxLength(64)
                .HasColumnName("bank_account_number");
            entity.Property(e => e.BankBranchNumber)
                .HasMaxLength(64)
                .HasColumnName("bank_branch_number");
            entity.Property(e => e.BankName)
                .HasMaxLength(64)
                .HasColumnName("bank_name");
            entity.Property(e => e.BankSwiftCode)
                .HasMaxLength(64)
                .HasColumnName("bank_swift_code");
            entity.Property(e => e.Cheque)
                .HasMaxLength(100)
                .HasColumnName("cheque");
            entity.Property(e => e.Commission)
                .HasPrecision(4)
                .HasColumnName("commission");
            entity.Property(e => e.Company)
                .HasMaxLength(40)
                .HasColumnName("company");
            entity.Property(e => e.CustomField)
                .HasColumnType("text")
                .HasColumnName("custom_field");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Payment)
                .HasMaxLength(6)
                .HasColumnName("payment");
            entity.Property(e => e.Paypal)
                .HasMaxLength(64)
                .HasColumnName("paypal");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Tax)
                .HasMaxLength(64)
                .HasColumnName("tax");
            entity.Property(e => e.Tracking)
                .HasMaxLength(64)
                .HasColumnName("tracking");
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .HasColumnName("website");
        });

        modelBuilder.Entity<NgCustomerApproval>(entity =>
        {
            entity.HasKey(e => e.CustomerApprovalId).HasName("PRIMARY");

            entity.ToTable("ng_customer_approval");

            entity.Property(e => e.CustomerApprovalId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_approval_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Type)
                .HasMaxLength(9)
                .HasColumnName("type");
        });

        modelBuilder.Entity<NgCustomerGroup>(entity =>
        {
            entity.HasKey(e => e.CustomerGroupId).HasName("PRIMARY");

            entity.ToTable("ng_customer_group");

            entity.HasIndex(e => e.CustomerGroupId, "customer_group_id");

            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
            entity.Property(e => e.Approval)
                .HasColumnType("int(1)")
                .HasColumnName("approval");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgCustomerGroupDescription>(entity =>
        {
            entity.HasKey(e => new { e.CustomerGroupId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_customer_group_description");

            entity.HasIndex(e => e.CustomerGroupId, "customer_group_id");

            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgCustomerHistory>(entity =>
        {
            entity.HasKey(e => e.CustomerHistoryId).HasName("PRIMARY");

            entity.ToTable("ng_customer_history");

            entity.Property(e => e.CustomerHistoryId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_history_id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
        });

        modelBuilder.Entity<NgCustomerIp>(entity =>
        {
            entity.HasKey(e => e.CustomerIpId).HasName("PRIMARY");

            entity.ToTable("ng_customer_ip");

            entity.HasIndex(e => e.Ip, "ip");

            entity.Property(e => e.CustomerIpId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_ip_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Ip)
                .HasMaxLength(40)
                .HasColumnName("ip");
        });

        modelBuilder.Entity<NgCustomerLogin>(entity =>
        {
            entity.HasKey(e => e.CustomerLoginId).HasName("PRIMARY");

            entity.ToTable("ng_customer_login");

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.Ip, "ip");

            entity.Property(e => e.CustomerLoginId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_login_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.Ip)
                .HasMaxLength(40)
                .HasColumnName("ip");
            entity.Property(e => e.Total)
                .HasColumnType("int(4)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<NgCustomerOnline>(entity =>
        {
            entity.HasKey(e => e.Ip).HasName("PRIMARY");

            entity.ToTable("ng_customer_online");

            entity.Property(e => e.Ip)
                .HasMaxLength(40)
                .HasColumnName("ip");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Referer)
                .HasColumnType("text")
                .HasColumnName("referer");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
        });

        modelBuilder.Entity<NgCustomerReward>(entity =>
        {
            entity.HasKey(e => e.CustomerRewardId).HasName("PRIMARY");

            entity.ToTable("ng_customer_reward");

            entity.HasIndex(e => e.CustomerId, "customer_id");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.Property(e => e.CustomerRewardId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_reward_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.Points)
                .HasColumnType("int(8)")
                .HasColumnName("points");
        });

        modelBuilder.Entity<NgCustomerSearch>(entity =>
        {
            entity.HasKey(e => e.CustomerSearchId).HasName("PRIMARY");

            entity.ToTable("ng_customer_search");

            entity.Property(e => e.CustomerSearchId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_search_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Ip)
                .HasMaxLength(40)
                .HasColumnName("ip");
            entity.Property(e => e.Keyword)
                .HasMaxLength(255)
                .HasColumnName("keyword");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Products)
                .HasColumnType("int(11)")
                .HasColumnName("products");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.SubCategory).HasColumnName("sub_category");
        });

        modelBuilder.Entity<NgCustomerSimpleField>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PRIMARY");

            entity.ToTable("ng_customer_simple_fields");

            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.Metadata)
                .HasColumnType("text")
                .HasColumnName("metadata");
        });

        modelBuilder.Entity<NgCustomerTransaction>(entity =>
        {
            entity.HasKey(e => e.CustomerTransactionId).HasName("PRIMARY");

            entity.ToTable("ng_customer_transaction");

            entity.Property(e => e.CustomerTransactionId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_transaction_id");
            entity.Property(e => e.Amount)
                .HasPrecision(15, 4)
                .HasColumnName("amount");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
        });

        modelBuilder.Entity<NgCustomerWishlist>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.ProductId }).HasName("PRIMARY");

            entity.ToTable("ng_customer_wishlist");

            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
        });

        modelBuilder.Entity<NgDownload>(entity =>
        {
            entity.HasKey(e => e.DownloadId).HasName("PRIMARY");

            entity.ToTable("ng_download");

            entity.Property(e => e.DownloadId)
                .HasColumnType("int(11)")
                .HasColumnName("download_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Filename)
                .HasMaxLength(160)
                .HasColumnName("filename");
            entity.Property(e => e.Mask)
                .HasMaxLength(128)
                .HasColumnName("mask");
        });

        modelBuilder.Entity<NgDownloadDescription>(entity =>
        {
            entity.HasKey(e => new { e.DownloadId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_download_description");

            entity.Property(e => e.DownloadId)
                .HasColumnType("int(11)")
                .HasColumnName("download_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PRIMARY");

            entity.ToTable("ng_event");

            entity.Property(e => e.EventId)
                .HasColumnType("int(11)")
                .HasColumnName("event_id");
            entity.Property(e => e.Action)
                .HasColumnType("text")
                .HasColumnName("action");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasColumnName("code");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Trigger)
                .HasColumnType("text")
                .HasColumnName("trigger");
        });

        modelBuilder.Entity<NgExtension>(entity =>
        {
            entity.HasKey(e => e.ExtensionId).HasName("PRIMARY");

            entity.ToTable("ng_extension");

            entity.Property(e => e.ExtensionId)
                .HasColumnType("int(11)")
                .HasColumnName("extension_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.Type)
                .HasMaxLength(32)
                .HasColumnName("type");
        });

        modelBuilder.Entity<NgExtensionInstall>(entity =>
        {
            entity.HasKey(e => e.ExtensionInstallId).HasName("PRIMARY");

            entity.ToTable("ng_extension_install");

            entity.Property(e => e.ExtensionInstallId)
                .HasColumnType("int(11)")
                .HasColumnName("extension_install_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.ExtensionDownloadId)
                .HasColumnType("int(11)")
                .HasColumnName("extension_download_id");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("filename");
        });

        modelBuilder.Entity<NgExtensionPath>(entity =>
        {
            entity.HasKey(e => e.ExtensionPathId).HasName("PRIMARY");

            entity.ToTable("ng_extension_path");

            entity.Property(e => e.ExtensionPathId)
                .HasColumnType("int(11)")
                .HasColumnName("extension_path_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.ExtensionInstallId)
                .HasColumnType("int(11)")
                .HasColumnName("extension_install_id");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasColumnName("path");
        });

        modelBuilder.Entity<NgFilter>(entity =>
        {
            entity.HasKey(e => e.FilterId).HasName("PRIMARY");

            entity.ToTable("ng_filter");

            entity.Property(e => e.FilterId)
                .HasColumnType("int(11)")
                .HasColumnName("filter_id");
            entity.Property(e => e.FilterGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("filter_group_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgFilterDescription>(entity =>
        {
            entity.HasKey(e => new { e.FilterId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_filter_description");

            entity.Property(e => e.FilterId)
                .HasColumnType("int(11)")
                .HasColumnName("filter_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.FilterGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("filter_group_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgFilterGroup>(entity =>
        {
            entity.HasKey(e => e.FilterGroupId).HasName("PRIMARY");

            entity.ToTable("ng_filter_group");

            entity.Property(e => e.FilterGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("filter_group_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgFilterGroupDescription>(entity =>
        {
            entity.HasKey(e => new { e.FilterGroupId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_filter_group_description");

            entity.Property(e => e.FilterGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("filter_group_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgGeoZone>(entity =>
        {
            entity.HasKey(e => e.GeoZoneId).HasName("PRIMARY");

            entity.ToTable("ng_geo_zone");

            entity.Property(e => e.GeoZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("geo_zone_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgGoogleshoppingCategory>(entity =>
        {
            entity.HasKey(e => new { e.GoogleProductCategory, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_googleshopping_category");

            entity.HasIndex(e => new { e.CategoryId, e.StoreId }, "category_id_store_id");

            entity.Property(e => e.GoogleProductCategory)
                .HasMaxLength(10)
                .HasColumnName("google_product_category");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
        });

        modelBuilder.Entity<NgGoogleshoppingProduct>(entity =>
        {
            entity.HasKey(e => e.ProductAdvertiseGoogleId).HasName("PRIMARY");

            entity.ToTable("ng_googleshopping_product");

            entity.HasIndex(e => new { e.ProductId, e.StoreId }, "product_id_store_id").IsUnique();

            entity.Property(e => e.ProductAdvertiseGoogleId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("product_advertise_google_id");
            entity.Property(e => e.Adult).HasColumnName("adult");
            entity.Property(e => e.AgeGroup)
                .HasColumnType("enum('newborn','infant','toddler','kids','adult')")
                .HasColumnName("age_group");
            entity.Property(e => e.Clicks)
                .HasColumnType("int(11)")
                .HasColumnName("clicks");
            entity.Property(e => e.Color)
                .HasColumnType("int(11)")
                .HasColumnName("color");
            entity.Property(e => e.Condition)
                .HasColumnType("enum('new','refurbished','used')")
                .HasColumnName("condition");
            entity.Property(e => e.ConversionValue)
                .HasPrecision(15, 4)
                .HasColumnName("conversion_value");
            entity.Property(e => e.Conversions)
                .HasColumnType("int(11)")
                .HasColumnName("conversions");
            entity.Property(e => e.Cost)
                .HasPrecision(15, 4)
                .HasColumnName("cost");
            entity.Property(e => e.DestinationStatus)
                .HasDefaultValueSql("'pending'")
                .HasColumnType("enum('pending','approved','disapproved')")
                .HasColumnName("destination_status");
            entity.Property(e => e.Gender)
                .HasColumnType("enum('male','female','unisex')")
                .HasColumnName("gender");
            entity.Property(e => e.GoogleProductCategory)
                .HasMaxLength(10)
                .HasColumnName("google_product_category");
            entity.Property(e => e.HasIssues).HasColumnName("has_issues");
            entity.Property(e => e.Impressions)
                .HasColumnType("int(11)")
                .HasColumnName("impressions");
            entity.Property(e => e.IsBundle).HasColumnName("is_bundle");
            entity.Property(e => e.IsModified).HasColumnName("is_modified");
            entity.Property(e => e.Multipack)
                .HasColumnType("int(11)")
                .HasColumnName("multipack");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Size)
                .HasColumnType("int(11)")
                .HasColumnName("size");
            entity.Property(e => e.SizeSystem)
                .HasColumnType("enum('AU','BR','CN','DE','EU','FR','IT','JP','MEX','UK','US')")
                .HasColumnName("size_system");
            entity.Property(e => e.SizeType)
                .HasColumnType("enum('regular','petite','plus','big and tall','maternity')")
                .HasColumnName("size_type");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgGoogleshoppingProductStatus>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.StoreId, e.ProductVariationId }).HasName("PRIMARY");

            entity.ToTable("ng_googleshopping_product_status");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.ProductVariationId)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("product_variation_id");
            entity.Property(e => e.DataQualityIssues)
                .HasColumnType("text")
                .HasColumnName("data_quality_issues");
            entity.Property(e => e.DestinationStatuses)
                .HasColumnType("text")
                .HasColumnName("destination_statuses");
            entity.Property(e => e.GoogleExpirationDate)
                .HasColumnType("int(11)")
                .HasColumnName("google_expiration_date");
            entity.Property(e => e.ItemLevelIssues)
                .HasColumnType("text")
                .HasColumnName("item_level_issues");
        });

        modelBuilder.Entity<NgGoogleshoppingProductTarget>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.AdvertiseGoogleTargetId }).HasName("PRIMARY");

            entity.ToTable("ng_googleshopping_product_target");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.AdvertiseGoogleTargetId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("advertise_google_target_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgGoogleshoppingTarget>(entity =>
        {
            entity.HasKey(e => e.AdvertiseGoogleTargetId).HasName("PRIMARY");

            entity.ToTable("ng_googleshopping_target");

            entity.HasIndex(e => e.StoreId, "store_id");

            entity.Property(e => e.AdvertiseGoogleTargetId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("advertise_google_target_id");
            entity.Property(e => e.Budget)
                .HasPrecision(15, 4)
                .HasColumnName("budget");
            entity.Property(e => e.CampaignName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("campaign_name");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .HasColumnName("country");
            entity.Property(e => e.DateAdded)
                .HasColumnType("date")
                .HasColumnName("date_added");
            entity.Property(e => e.Feeds)
                .HasColumnType("text")
                .HasColumnName("feeds");
            entity.Property(e => e.Roas)
                .HasColumnType("int(11)")
                .HasColumnName("roas");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'paused'")
                .HasColumnType("enum('paused','active')")
                .HasColumnName("status");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgInformation>(entity =>
        {
            entity.HasKey(e => e.InformationId).HasName("PRIMARY");

            entity.ToTable("ng_information");

            entity.Property(e => e.InformationId)
                .HasColumnType("int(11)")
                .HasColumnName("information_id");
            entity.Property(e => e.Bottom)
                .HasColumnType("int(1)")
                .HasColumnName("bottom");
            entity.Property(e => e.Noindex)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("noindex");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<NgInformationDescription>(entity =>
        {
            entity.HasKey(e => new { e.InformationId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_information_description");

            entity.Property(e => e.InformationId)
                .HasColumnType("int(11)")
                .HasColumnName("information_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Description)
                .HasColumnType("mediumtext")
                .HasColumnName("description");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaH1)
                .HasMaxLength(255)
                .HasColumnName("meta_h1");
            entity.Property(e => e.MetaKeyword)
                .HasMaxLength(255)
                .HasColumnName("meta_keyword");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.Title)
                .HasMaxLength(64)
                .HasColumnName("title");
        });

        modelBuilder.Entity<NgInformationToLayout>(entity =>
        {
            entity.HasKey(e => new { e.InformationId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_information_to_layout");

            entity.Property(e => e.InformationId)
                .HasColumnType("int(11)")
                .HasColumnName("information_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.LayoutId)
                .HasColumnType("int(11)")
                .HasColumnName("layout_id");
        });

        modelBuilder.Entity<NgInformationToStore>(entity =>
        {
            entity.HasKey(e => new { e.InformationId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_information_to_store");

            entity.Property(e => e.InformationId)
                .HasColumnType("int(11)")
                .HasColumnName("information_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgLanguage>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PRIMARY");

            entity.ToTable("ng_language");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .HasColumnName("code");
            entity.Property(e => e.Directory)
                .HasMaxLength(32)
                .HasColumnName("directory");
            entity.Property(e => e.Image)
                .HasMaxLength(64)
                .HasColumnName("image");
            entity.Property(e => e.Locale)
                .HasMaxLength(255)
                .HasColumnName("locale");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<NgLayout>(entity =>
        {
            entity.HasKey(e => e.LayoutId).HasName("PRIMARY");

            entity.ToTable("ng_layout");

            entity.Property(e => e.LayoutId)
                .HasColumnType("int(11)")
                .HasColumnName("layout_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgLayoutModule>(entity =>
        {
            entity.HasKey(e => e.LayoutModuleId).HasName("PRIMARY");

            entity.ToTable("ng_layout_module");

            entity.Property(e => e.LayoutModuleId)
                .HasColumnType("int(11)")
                .HasColumnName("layout_module_id");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasColumnName("code");
            entity.Property(e => e.LayoutId)
                .HasColumnType("int(11)")
                .HasColumnName("layout_id");
            entity.Property(e => e.Position)
                .HasMaxLength(14)
                .HasColumnName("position");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgLayoutRoute>(entity =>
        {
            entity.HasKey(e => e.LayoutRouteId).HasName("PRIMARY");

            entity.ToTable("ng_layout_route");

            entity.Property(e => e.LayoutRouteId)
                .HasColumnType("int(11)")
                .HasColumnName("layout_route_id");
            entity.Property(e => e.LayoutId)
                .HasColumnType("int(11)")
                .HasColumnName("layout_id");
            entity.Property(e => e.Route)
                .HasMaxLength(64)
                .HasColumnName("route");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgLengthClass>(entity =>
        {
            entity.HasKey(e => e.LengthClassId).HasName("PRIMARY");

            entity.ToTable("ng_length_class");

            entity.Property(e => e.LengthClassId)
                .HasColumnType("int(11)")
                .HasColumnName("length_class_id");
            entity.Property(e => e.Value)
                .HasPrecision(15, 8)
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgLengthClassDescription>(entity =>
        {
            entity.HasKey(e => new { e.LengthClassId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_length_class_description");

            entity.Property(e => e.LengthClassId)
                .HasColumnType("int(11)")
                .HasColumnName("length_class_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Title)
                .HasMaxLength(32)
                .HasColumnName("title");
            entity.Property(e => e.Unit)
                .HasMaxLength(4)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<NgLicensesKm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ng_licenses_km");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Key)
                .HasColumnType("text")
                .HasColumnName("key");
            entity.Property(e => e.LicenseKey)
                .HasColumnType("text")
                .HasColumnName("license_key");
            entity.Property(e => e.PCode)
                .HasColumnType("text")
                .HasColumnName("p_code");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PRIMARY");

            entity.ToTable("ng_location");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.LocationId)
                .HasColumnType("int(11)")
                .HasColumnName("location_id");
            entity.Property(e => e.Address)
                .HasColumnType("text")
                .HasColumnName("address");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.Fax)
                .HasMaxLength(32)
                .HasColumnName("fax");
            entity.Property(e => e.Geocode)
                .HasMaxLength(32)
                .HasColumnName("geocode");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
            entity.Property(e => e.Open)
                .HasColumnType("text")
                .HasColumnName("open");
            entity.Property(e => e.Telephone)
                .HasMaxLength(32)
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<NgManufacturer>(entity =>
        {
            entity.HasKey(e => e.ManufacturerId).HasName("PRIMARY");

            entity.ToTable("ng_manufacturer");

            entity.Property(e => e.ManufacturerId)
                .HasColumnType("int(11)")
                .HasColumnName("manufacturer_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Noindex)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("noindex");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgManufacturerDescription>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ng_manufacturer_description");

            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Description3)
                .HasColumnType("text")
                .HasColumnName("description3");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.ManufacturerId)
                .HasColumnType("int(11)")
                .HasColumnName("manufacturer_id");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaH1)
                .HasMaxLength(255)
                .HasColumnName("meta_h1");
            entity.Property(e => e.MetaKeyword)
                .HasMaxLength(255)
                .HasColumnName("meta_keyword");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
        });

        modelBuilder.Entity<NgManufacturerToLayout>(entity =>
        {
            entity.HasKey(e => new { e.ManufacturerId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_manufacturer_to_layout");

            entity.Property(e => e.ManufacturerId)
                .HasColumnType("int(11)")
                .HasColumnName("manufacturer_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.LayoutId)
                .HasColumnType("int(11)")
                .HasColumnName("layout_id");
        });

        modelBuilder.Entity<NgManufacturerToStore>(entity =>
        {
            entity.HasKey(e => new { e.ManufacturerId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_manufacturer_to_store");

            entity.Property(e => e.ManufacturerId)
                .HasColumnType("int(11)")
                .HasColumnName("manufacturer_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgMarketing>(entity =>
        {
            entity.HasKey(e => e.MarketingId).HasName("PRIMARY");

            entity.ToTable("ng_marketing");

            entity.Property(e => e.MarketingId)
                .HasColumnType("int(11)")
                .HasColumnName("marketing_id");
            entity.Property(e => e.Clicks)
                .HasColumnType("int(5)")
                .HasColumnName("clicks");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgModification>(entity =>
        {
            entity.HasKey(e => e.ModificationId).HasName("PRIMARY");

            entity.ToTable("ng_modification");

            entity.Property(e => e.ModificationId)
                .HasColumnType("int(11)")
                .HasColumnName("modification_id");
            entity.Property(e => e.Author)
                .HasMaxLength(64)
                .HasColumnName("author");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.ExtensionInstallId)
                .HasColumnType("int(11)")
                .HasColumnName("extension_install_id");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Version)
                .HasMaxLength(32)
                .HasColumnName("version");
            entity.Property(e => e.Xml)
                .HasColumnType("mediumtext")
                .HasColumnName("xml");
        });

        modelBuilder.Entity<NgModificationBackup>(entity =>
        {
            entity.HasKey(e => e.BackupId).HasName("PRIMARY");

            entity.ToTable("ng_modification_backup");

            entity.Property(e => e.BackupId)
                .HasColumnType("int(11)")
                .HasColumnName("backup_id");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.ModificationId)
                .HasColumnType("int(11)")
                .HasColumnName("modification_id");
            entity.Property(e => e.Xml)
                .HasColumnType("mediumtext")
                .HasColumnName("xml");
        });

        modelBuilder.Entity<NgModule>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PRIMARY");

            entity.ToTable("ng_module");

            entity.Property(e => e.ModuleId)
                .HasColumnType("int(11)")
                .HasColumnName("module_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Setting)
                .HasColumnType("text")
                .HasColumnName("setting");
        });

        modelBuilder.Entity<NgMultiXml>(entity =>
        {
            entity.HasKey(e => e.XmlId).HasName("PRIMARY");

            entity.ToTable("ng_multi_xml");

            entity.Property(e => e.XmlId)
                .HasColumnType("int(11)")
                .HasColumnName("xml_id");
            entity.Property(e => e.Categories)
                .HasColumnType("text")
                .HasColumnName("categories");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Products)
                .HasColumnType("text")
                .HasColumnName("products");
            entity.Property(e => e.Settings)
                .HasColumnType("text")
                .HasColumnName("settings");
            entity.Property(e => e.Suppliers)
                .HasColumnType("text")
                .HasColumnName("suppliers");
        });

        modelBuilder.Entity<NgMultiplicityProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("ng_multiplicity_product");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.Step)
                .HasColumnType("int(11)")
                .HasColumnName("step");
        });

        modelBuilder.Entity<NgNovaposhtaCity>(entity =>
        {
            entity.HasKey(e => e.Ref).HasName("PRIMARY");

            entity.ToTable("ng_novaposhta_cities");

            entity.HasIndex(e => e.Area, "Area");

            entity.Property(e => e.Ref).HasMaxLength(36);
            entity.Property(e => e.Area).HasMaxLength(36);
            entity.Property(e => e.AreaDescription).HasMaxLength(50);
            entity.Property(e => e.AreaDescriptionRu).HasMaxLength(50);
            entity.Property(e => e.CityId)
                .HasColumnType("int(11)")
                .HasColumnName("CityID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.DescriptionRu).HasMaxLength(200);
            entity.Property(e => e.PreventEntryNewStreetsUser).HasColumnType("text");
            entity.Property(e => e.SettlementType).HasMaxLength(36);
            entity.Property(e => e.SettlementTypeDescription).HasMaxLength(50);
            entity.Property(e => e.SettlementTypeDescriptionRu).HasMaxLength(50);
        });

        modelBuilder.Entity<NgNovaposhtaDepartment>(entity =>
        {
            entity.HasKey(e => e.Ref).HasName("PRIMARY");

            entity.ToTable("ng_novaposhta_departments");

            entity.HasIndex(e => e.CityRef, "CityRef");

            entity.HasIndex(e => e.TypeOfWarehouse, "TypeOfWarehouse");

            entity.Property(e => e.Ref).HasMaxLength(36);
            entity.Property(e => e.CategoryOfWarehouse).HasMaxLength(20);
            entity.Property(e => e.CityDescription).HasMaxLength(200);
            entity.Property(e => e.CityDescriptionRu).HasMaxLength(200);
            entity.Property(e => e.CityRef).HasMaxLength(36);
            entity.Property(e => e.DeliveryFriday)
                .HasMaxLength(20)
                .HasColumnName("Delivery_friday");
            entity.Property(e => e.DeliveryMonday)
                .HasMaxLength(20)
                .HasColumnName("Delivery_monday");
            entity.Property(e => e.DeliverySaturday)
                .HasMaxLength(20)
                .HasColumnName("Delivery_saturday");
            entity.Property(e => e.DeliverySunday)
                .HasMaxLength(20)
                .HasColumnName("Delivery_sunday");
            entity.Property(e => e.DeliveryThursday)
                .HasMaxLength(20)
                .HasColumnName("Delivery_thursday");
            entity.Property(e => e.DeliveryTuesday)
                .HasMaxLength(20)
                .HasColumnName("Delivery_tuesday");
            entity.Property(e => e.DeliveryWednesday)
                .HasMaxLength(20)
                .HasColumnName("Delivery_wednesday");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DescriptionRu).HasMaxLength(500);
            entity.Property(e => e.Direct).HasMaxLength(20);
            entity.Property(e => e.DistrictCode).HasMaxLength(20);
            entity.Property(e => e.Number).HasColumnType("int(11)");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PlaceMaxWeightAllowed).HasColumnType("int(11)");
            entity.Property(e => e.Posterminal).HasColumnName("POSTerminal");
            entity.Property(e => e.ReceivingLimitationsOnDimensionsHeight)
                .HasColumnType("int(11)")
                .HasColumnName("ReceivingLimitationsOnDimensions_height");
            entity.Property(e => e.ReceivingLimitationsOnDimensionsLength)
                .HasColumnType("int(11)")
                .HasColumnName("ReceivingLimitationsOnDimensions_length");
            entity.Property(e => e.ReceivingLimitationsOnDimensionsWidth)
                .HasColumnType("int(11)")
                .HasColumnName("ReceivingLimitationsOnDimensions_width");
            entity.Property(e => e.ReceptionFriday)
                .HasMaxLength(20)
                .HasColumnName("Reception_friday");
            entity.Property(e => e.ReceptionMonday)
                .HasMaxLength(20)
                .HasColumnName("Reception_monday");
            entity.Property(e => e.ReceptionSaturday)
                .HasMaxLength(20)
                .HasColumnName("Reception_saturday");
            entity.Property(e => e.ReceptionSunday)
                .HasMaxLength(20)
                .HasColumnName("Reception_sunday");
            entity.Property(e => e.ReceptionThursday)
                .HasMaxLength(20)
                .HasColumnName("Reception_thursday");
            entity.Property(e => e.ReceptionTuesday)
                .HasMaxLength(20)
                .HasColumnName("Reception_tuesday");
            entity.Property(e => e.ReceptionWednesday)
                .HasMaxLength(20)
                .HasColumnName("Reception_wednesday");
            entity.Property(e => e.RegionCity).HasMaxLength(20);
            entity.Property(e => e.ScheduleFriday)
                .HasMaxLength(20)
                .HasColumnName("Schedule_friday");
            entity.Property(e => e.ScheduleMonday)
                .HasMaxLength(20)
                .HasColumnName("Schedule_monday");
            entity.Property(e => e.ScheduleSaturday)
                .HasMaxLength(20)
                .HasColumnName("Schedule_saturday");
            entity.Property(e => e.ScheduleSunday)
                .HasMaxLength(20)
                .HasColumnName("Schedule_sunday");
            entity.Property(e => e.ScheduleThursday)
                .HasMaxLength(20)
                .HasColumnName("Schedule_thursday");
            entity.Property(e => e.ScheduleTuesday)
                .HasMaxLength(20)
                .HasColumnName("Schedule_tuesday");
            entity.Property(e => e.ScheduleWednesday)
                .HasMaxLength(20)
                .HasColumnName("Schedule_wednesday");
            entity.Property(e => e.SendingLimitationsOnDimensionsHeight)
                .HasColumnType("int(11)")
                .HasColumnName("SendingLimitationsOnDimensions_height");
            entity.Property(e => e.SendingLimitationsOnDimensionsLength)
                .HasColumnType("int(11)")
                .HasColumnName("SendingLimitationsOnDimensions_length");
            entity.Property(e => e.SendingLimitationsOnDimensionsWidth)
                .HasColumnType("int(11)")
                .HasColumnName("SendingLimitationsOnDimensions_width");
            entity.Property(e => e.SettlementAreaDescription).HasMaxLength(200);
            entity.Property(e => e.SettlementDescription).HasMaxLength(200);
            entity.Property(e => e.SettlementRef).HasMaxLength(36);
            entity.Property(e => e.SettlementRegionsDescription).HasMaxLength(200);
            entity.Property(e => e.SettlementTypeDescription).HasMaxLength(50);
            entity.Property(e => e.ShortAddress).HasMaxLength(500);
            entity.Property(e => e.ShortAddressRu).HasMaxLength(500);
            entity.Property(e => e.SiteKey).HasColumnType("int(11)");
            entity.Property(e => e.TotalMaxWeightAllowed).HasColumnType("int(11)");
            entity.Property(e => e.TypeOfWarehouse).HasMaxLength(36);
            entity.Property(e => e.WarehouseStatus).HasMaxLength(20);
            entity.Property(e => e.WarehouseStatusDate).HasMaxLength(20);
        });

        modelBuilder.Entity<NgNovaposhtaReference>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ng_novaposhta_references");

            entity.HasIndex(e => e.Type, "type").IsUnique();

            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasColumnType("mediumtext")
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgNovaposhtaRegion>(entity =>
        {
            entity.HasKey(e => e.Ref).HasName("PRIMARY");

            entity.ToTable("ng_novaposhta_regions");

            entity.Property(e => e.Ref).HasMaxLength(36);
            entity.Property(e => e.AreasCenter).HasMaxLength(36);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.DescriptionRu).HasMaxLength(50);
        });

        modelBuilder.Entity<NgOcfilterAttributeCache>(entity =>
        {
            entity.HasKey(e => e.AttributeCacheId).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_attribute_cache");

            entity.HasIndex(e => e.AttributeId, "attribute_id");

            entity.HasIndex(e => e.Key, "key");

            entity.HasIndex(e => e.LanguageId, "language_id");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.AttributeCacheId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_cache_id");
            entity.Property(e => e.AttributeId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("attribute_id");
            entity.Property(e => e.Key)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("key");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("language_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("product_id");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
        });

        modelBuilder.Entity<NgOcfilterCache>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_cache");

            entity.HasIndex(e => e.Expire, "expire");

            entity.HasIndex(e => e.Path, "path");

            entity.Property(e => e.Key)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("key");
            entity.Property(e => e.Expire)
                .HasColumnType("int(11)")
                .HasColumnName("expire");
            entity.Property(e => e.Path)
                .HasMaxLength(128)
                .HasColumnName("path");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<NgOcfilterFilter>(entity =>
        {
            entity.HasKey(e => new { e.FilterId, e.Source }).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_filter");

            entity.HasIndex(e => e.Status, "slider_status");

            entity.HasIndex(e => e.SortOrder, "sort_order");

            entity.Property(e => e.FilterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11) unsigned")
                .HasColumnName("filter_id");
            entity.Property(e => e.Source)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("source");
            entity.Property(e => e.Color).HasColumnName("color");
            entity.Property(e => e.Dropdown).HasColumnName("dropdown");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(11)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'checkbox'")
                .HasColumnType("set('checkbox','radio','slide','slide_dual')")
                .HasColumnName("type");
        });

        modelBuilder.Entity<NgOcfilterFilterDescription>(entity =>
        {
            entity.HasKey(e => new { e.FilterId, e.LanguageId, e.Source }).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_filter_description");

            entity.HasIndex(e => e.LanguageId, "language_id");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.FilterId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("filter_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("language_id");
            entity.Property(e => e.Source)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("source");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Suffix)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("suffix");
        });

        modelBuilder.Entity<NgOcfilterFilterRangeToProduct>(entity =>
        {
            entity.HasKey(e => new { e.FilterId, e.Source, e.ProductId }).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_filter_range_to_product");

            entity.HasIndex(e => new { e.Min, e.Max }, "min_max");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.FilterId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("filter_id");
            entity.Property(e => e.Source)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("source");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("product_id");
            entity.Property(e => e.Max)
                .HasPrecision(15, 3)
                .HasColumnName("max");
            entity.Property(e => e.Min)
                .HasPrecision(15, 3)
                .HasColumnName("min");
        });

        modelBuilder.Entity<NgOcfilterFilterToCategory>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.FilterId, e.Source }).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_filter_to_category");

            entity.HasIndex(e => e.CategoryId, "category_id");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("category_id");
            entity.Property(e => e.FilterId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("filter_id");
            entity.Property(e => e.Source)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("source");
        });

        modelBuilder.Entity<NgOcfilterFilterToStore>(entity =>
        {
            entity.HasKey(e => new { e.StoreId, e.FilterId, e.Source }).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_filter_to_store");

            entity.HasIndex(e => e.StoreId, "store_id");

            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.FilterId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("filter_id");
            entity.Property(e => e.Source)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("source");
        });

        modelBuilder.Entity<NgOcfilterFilterValue>(entity =>
        {
            entity.HasKey(e => new { e.ValueId, e.Source }).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_filter_value");

            entity.HasIndex(e => e.FilterId, "option_id");

            entity.HasIndex(e => e.SortOrder, "sort_order");

            entity.HasIndex(e => e.Key, "translit");

            entity.Property(e => e.ValueId)
                .ValueGeneratedOnAdd()
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("value_id");
            entity.Property(e => e.Source)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("source");
            entity.Property(e => e.Color)
                .HasMaxLength(6)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("color");
            entity.Property(e => e.FilterId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("filter_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("image");
            entity.Property(e => e.Key)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("key");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(11)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgOcfilterFilterValueDescription>(entity =>
        {
            entity.HasKey(e => new { e.ValueId, e.LanguageId, e.Source }).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_filter_value_description");

            entity.HasIndex(e => e.FilterId, "filter_id");

            entity.HasIndex(e => e.LanguageId, "language_id");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.ValueId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("value_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("language_id");
            entity.Property(e => e.Source)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("source");
            entity.Property(e => e.AttributeText)
                .HasColumnType("text")
                .HasColumnName("attribute_text");
            entity.Property(e => e.FilterId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("filter_id");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgOcfilterFilterValueToProduct>(entity =>
        {
            entity.HasKey(e => new { e.FilterId, e.ValueId, e.Source, e.ProductId }).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_filter_value_to_product");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.FilterId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("filter_id");
            entity.Property(e => e.ValueId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("value_id");
            entity.Property(e => e.Source)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("source");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("product_id");
        });

        modelBuilder.Entity<NgOcfilterPage>(entity =>
        {
            entity.HasKey(e => e.PageId).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_page");

            entity.HasIndex(e => e.CategoryId, "category_id");

            entity.HasIndex(e => e.DynamicId, "dynamic_id");

            entity.HasIndex(e => e.ParamsCount, "params_count");

            entity.HasIndex(e => e.ParamsKey, "params_key");

            entity.Property(e => e.PageId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("page_id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("category_id");
            entity.Property(e => e.Dynamic).HasColumnName("dynamic");
            entity.Property(e => e.DynamicId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("dynamic_id");
            entity.Property(e => e.Module).HasColumnName("module");
            entity.Property(e => e.Params)
                .HasColumnType("text")
                .HasColumnName("params");
            entity.Property(e => e.ParamsCount)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("params_count");
            entity.Property(e => e.ParamsKey)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("params_key");
            entity.Property(e => e.Product).HasColumnName("product");
            entity.Property(e => e.Sitemap).HasColumnName("sitemap");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<NgOcfilterPageDescription>(entity =>
        {
            entity.HasKey(e => new { e.PageId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_page_description");

            entity.HasIndex(e => e.LanguageId, "language_id");

            entity.Property(e => e.PageId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("page_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("language_id");
            entity.Property(e => e.DescriptionBottom)
                .HasColumnType("text")
                .HasColumnName("description_bottom");
            entity.Property(e => e.DescriptionTop)
                .HasColumnType("text")
                .HasColumnName("description_top");
            entity.Property(e => e.HeadingTitle)
                .HasMaxLength(255)
                .HasColumnName("heading_title");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaKeyword)
                .HasMaxLength(255)
                .HasColumnName("meta_keyword");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgOcfilterPageToLayout>(entity =>
        {
            entity.HasKey(e => new { e.PageId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_page_to_layout");

            entity.HasIndex(e => e.StoreId, "store_id");

            entity.Property(e => e.PageId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("page_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("store_id");
            entity.Property(e => e.LayoutId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("layout_id");
        });

        modelBuilder.Entity<NgOcfilterPageToStore>(entity =>
        {
            entity.HasKey(e => new { e.StoreId, e.PageId }).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_page_to_store");

            entity.HasIndex(e => e.StoreId, "store_id");

            entity.Property(e => e.StoreId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("store_id");
            entity.Property(e => e.PageId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("page_id");
        });

        modelBuilder.Entity<NgOcfilterSetting>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PRIMARY");

            entity.ToTable("ng_ocfilter_setting");

            entity.Property(e => e.Key)
                .HasMaxLength(64)
                .HasColumnName("key");
            entity.Property(e => e.Serialized)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("serialized");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<NgOmproAdminSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ng_ompro_admin_setting");

            entity.Property(e => e.Groupdefault)
                .HasColumnType("int(11)")
                .HasColumnName("groupdefault");
            entity.Property(e => e.LogSql).HasColumnName("log_sql");
            entity.Property(e => e.TargetMailTemplate).HasColumnName("target_mail_template");
            entity.Property(e => e.TargetSmsTemplate).HasColumnName("target_sms_template");
            entity.Property(e => e.TargetTlgrmTemplate).HasColumnName("target_tlgrm_template");
            entity.Property(e => e.TlgrmAdminIdes)
                .HasColumnType("text")
                .HasColumnName("tlgrm_admin_ides");
            entity.Property(e => e.TlgrmBotToken)
                .HasColumnType("text")
                .HasColumnName("tlgrm_bot_token");
        });

        modelBuilder.Entity<NgOmproFieldsAdded>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ng_ompro_fields_added");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Field)
                .HasMaxLength(128)
                .HasColumnName("field");
            entity.Property(e => e.Table)
                .HasColumnType("text")
                .HasColumnName("table");
        });

        modelBuilder.Entity<NgOmproFieldsSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ng_ompro_fields_setting");

            entity.Property(e => e.Id)
                .HasColumnType("int(1)")
                .HasColumnName("id");
            entity.Property(e => e.OrderAsFields).HasColumnName("order_as_fields");
            entity.Property(e => e.OrderFields).HasColumnName("order_fields");
            entity.Property(e => e.OrderSimpleFields).HasColumnName("order_simple_fields");
            entity.Property(e => e.ProductAsFields).HasColumnName("product_as_fields");
            entity.Property(e => e.ProductFields).HasColumnName("product_fields");
        });

        modelBuilder.Entity<NgOmproGroupSetting>(entity =>
        {
            entity.HasKey(e => e.UserGroupId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_group_setting");

            entity.Property(e => e.UserGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("user_group_id");
            entity.Property(e => e.AccessActions).HasColumnName("access_actions");
            entity.Property(e => e.CommentTemplates)
                .HasColumnType("mediumtext")
                .HasColumnName("comment_templates");
            entity.Property(e => e.DaysToShip)
                .HasColumnType("mediumtext")
                .HasColumnName("days_to_ship");
            entity.Property(e => e.FiltersDefault)
                .HasColumnType("mediumtext")
                .HasColumnName("filters_default");
            entity.Property(e => e.GroupTarget)
                .HasColumnType("tinytext")
                .HasColumnName("group_target");
            entity.Property(e => e.OrderFormats)
                .HasColumnType("mediumtext")
                .HasColumnName("order_formats");
            entity.Property(e => e.OrderPayments)
                .HasColumnType("mediumtext")
                .HasColumnName("order_payments");
            entity.Property(e => e.OrderShippings)
                .HasColumnType("mediumtext")
                .HasColumnName("order_shippings");
            entity.Property(e => e.OrderStatuses)
                .HasColumnType("mediumtext")
                .HasColumnName("order_statuses");
            entity.Property(e => e.Pages)
                .HasColumnType("text")
                .HasColumnName("pages");
            entity.Property(e => e.PaymentsList)
                .HasColumnType("text")
                .HasColumnName("payments_list");
            entity.Property(e => e.ProductFormats)
                .HasColumnType("mediumtext")
                .HasColumnName("product_formats");
            entity.Property(e => e.SelectOrders).HasColumnName("select_orders");
            entity.Property(e => e.ShippingsList)
                .HasColumnType("text")
                .HasColumnName("shippings_list");
        });

        modelBuilder.Entity<NgOmproTplBlock>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_block");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Target)
                .HasMaxLength(255)
                .HasColumnName("target");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplComment>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_comment");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplExcelOrder>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_excel_orders");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplExcelOrdersProduct>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_excel_orders_products");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplFilter>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_filter");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.FilterId)
                .HasMaxLength(255)
                .HasColumnName("filter_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplFilterProduct>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_filter_product");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.FilterId)
                .HasMaxLength(255)
                .HasColumnName("filter_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplHistory>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_history");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplMail>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_mail");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplOption>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_option");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplOrder>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_orders");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplPage>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_pages");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Icon)
                .HasColumnType("tinytext")
                .HasColumnName("icon");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplPageBlock>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_page_block");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Target)
                .HasMaxLength(255)
                .HasColumnName("target");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplPrintOrder>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_print_orders");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplPrintOrdersTable>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_print_orders_table");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplPrintProductsTable>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_print_products_table");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplProduct>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_product");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplSm>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_sms");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOmproTplTlgrm>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("ng_ompro_tpl_tlgrm");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<NgOption>(entity =>
        {
            entity.HasKey(e => e.OptionId).HasName("PRIMARY");

            entity.ToTable("ng_option");

            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Type)
                .HasMaxLength(32)
                .HasColumnName("type");
        });

        modelBuilder.Entity<NgOptionDescription>(entity =>
        {
            entity.HasKey(e => new { e.OptionId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_option_description");

            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgOptionValue>(entity =>
        {
            entity.HasKey(e => e.OptionValueId).HasName("PRIMARY");

            entity.ToTable("ng_option_value");

            entity.Property(e => e.OptionValueId)
                .HasColumnType("int(11)")
                .HasColumnName("option_value_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgOptionValueDescription>(entity =>
        {
            entity.HasKey(e => new { e.OptionValueId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_option_value_description");

            entity.Property(e => e.OptionValueId)
                .HasColumnType("int(11)")
                .HasColumnName("option_value_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
        });

        modelBuilder.Entity<NgOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("ng_order");

            entity.HasIndex(e => e.CourierUserId, "courier_user_id");

            entity.HasIndex(e => e.CustomerGroupId, "customer_group_id");

            entity.HasIndex(e => e.CustomerId, "customer_id");

            entity.HasIndex(e => e.DateAdded, "date_added");

            entity.HasIndex(e => e.DateModified, "date_modified");

            entity.HasIndex(e => e.ManagerUserId, "manager_user_id");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.HasIndex(e => e.OrderStatusId, "order_status_id");

            entity.HasIndex(e => e.PaymentCode, "payment_code");

            entity.HasIndex(e => e.ShippingCode, "shipping_code");

            entity.HasIndex(e => e.Total, "total");

            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.AcceptLanguage)
                .HasMaxLength(255)
                .HasColumnName("accept_language");
            entity.Property(e => e.AffiliateId)
                .HasColumnType("int(11)")
                .HasColumnName("affiliate_id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.Commission)
                .HasPrecision(15, 4)
                .HasColumnName("commission");
            entity.Property(e => e.CourierUserId)
                .HasColumnType("int(11)")
                .HasColumnName("courier_user_id");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .HasColumnName("currency_code");
            entity.Property(e => e.CurrencyId)
                .HasColumnType("int(11)")
                .HasColumnName("currency_id");
            entity.Property(e => e.CurrencyValue)
                .HasPrecision(15, 8)
                .HasDefaultValueSql("'1.00000000'")
                .HasColumnName("currency_value");
            entity.Property(e => e.CustomField)
                .HasColumnType("text")
                .HasColumnName("custom_field");
            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(32)
                .HasColumnName("fax");
            entity.Property(e => e.Firstname)
                .HasMaxLength(32)
                .HasColumnName("firstname");
            entity.Property(e => e.ForwardedIp)
                .HasMaxLength(40)
                .HasColumnName("forwarded_ip");
            entity.Property(e => e.InvoiceNo)
                .HasColumnType("int(11)")
                .HasColumnName("invoice_no");
            entity.Property(e => e.InvoicePrefix)
                .HasMaxLength(26)
                .HasColumnName("invoice_prefix");
            entity.Property(e => e.Ip)
                .HasMaxLength(40)
                .HasColumnName("ip");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Lastname)
                .HasMaxLength(32)
                .HasColumnName("lastname");
            entity.Property(e => e.ManagerUserId)
                .HasColumnType("int(11)")
                .HasColumnName("manager_user_id");
            entity.Property(e => e.MarketingId)
                .HasColumnType("int(11)")
                .HasColumnName("marketing_id");
            entity.Property(e => e.NovaposhtaCnNumber)
                .HasMaxLength(100)
                .HasColumnName("novaposhta_cn_number");
            entity.Property(e => e.NovaposhtaCnRef)
                .HasMaxLength(100)
                .HasColumnName("novaposhta_cn_ref");
            entity.Property(e => e.OrderCustomFile)
                .HasColumnType("text")
                .HasColumnName("order_custom_file");
            entity.Property(e => e.OrderCustomImage)
                .HasColumnType("text")
                .HasColumnName("order_custom_image");
            entity.Property(e => e.OrderDiscount)
                .HasPrecision(15, 4)
                .HasColumnName("order_discount");
            entity.Property(e => e.OrderPresent)
                .HasColumnType("text")
                .HasColumnName("order_present");
            entity.Property(e => e.OrderPresentCost)
                .HasPrecision(15, 4)
                .HasColumnName("order_present_cost");
            entity.Property(e => e.OrderStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("order_status_id");
            entity.Property(e => e.PaymentAddress1)
                .HasMaxLength(128)
                .HasColumnName("payment_address_1");
            entity.Property(e => e.PaymentAddress2)
                .HasMaxLength(128)
                .HasColumnName("payment_address_2");
            entity.Property(e => e.PaymentAddressFormat)
                .HasColumnType("text")
                .HasColumnName("payment_address_format");
            entity.Property(e => e.PaymentCity)
                .HasMaxLength(128)
                .HasColumnName("payment_city");
            entity.Property(e => e.PaymentCode)
                .HasMaxLength(128)
                .HasColumnName("payment_code");
            entity.Property(e => e.PaymentCompany)
                .HasMaxLength(60)
                .HasColumnName("payment_company");
            entity.Property(e => e.PaymentCountry)
                .HasMaxLength(128)
                .HasColumnName("payment_country");
            entity.Property(e => e.PaymentCountryId)
                .HasColumnType("int(11)")
                .HasColumnName("payment_country_id");
            entity.Property(e => e.PaymentCustomField)
                .HasColumnType("text")
                .HasColumnName("payment_custom_field");
            entity.Property(e => e.PaymentFirstname)
                .HasMaxLength(32)
                .HasColumnName("payment_firstname");
            entity.Property(e => e.PaymentLastname)
                .HasMaxLength(32)
                .HasColumnName("payment_lastname");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(128)
                .HasColumnName("payment_method");
            entity.Property(e => e.PaymentPostcode)
                .HasMaxLength(10)
                .HasColumnName("payment_postcode");
            entity.Property(e => e.PaymentStatusId)
                .HasMaxLength(32)
                .HasColumnName("payment_status_id");
            entity.Property(e => e.PaymentZone)
                .HasMaxLength(128)
                .HasColumnName("payment_zone");
            entity.Property(e => e.PaymentZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("payment_zone_id");
            entity.Property(e => e.ShippingAddress1)
                .HasMaxLength(128)
                .HasColumnName("shipping_address_1");
            entity.Property(e => e.ShippingAddress2)
                .HasMaxLength(128)
                .HasColumnName("shipping_address_2");
            entity.Property(e => e.ShippingAddressFormat)
                .HasColumnType("text")
                .HasColumnName("shipping_address_format");
            entity.Property(e => e.ShippingCity)
                .HasMaxLength(128)
                .HasColumnName("shipping_city");
            entity.Property(e => e.ShippingCode)
                .HasMaxLength(128)
                .HasColumnName("shipping_code");
            entity.Property(e => e.ShippingCompany)
                .HasMaxLength(40)
                .HasColumnName("shipping_company");
            entity.Property(e => e.ShippingCostFact)
                .HasPrecision(15, 4)
                .HasColumnName("shipping_cost_fact");
            entity.Property(e => e.ShippingCountry)
                .HasMaxLength(128)
                .HasColumnName("shipping_country");
            entity.Property(e => e.ShippingCountryId)
                .HasColumnType("int(11)")
                .HasColumnName("shipping_country_id");
            entity.Property(e => e.ShippingCustomField)
                .HasColumnType("text")
                .HasColumnName("shipping_custom_field");
            entity.Property(e => e.ShippingDate)
                .HasColumnType("date")
                .HasColumnName("shipping_date");
            entity.Property(e => e.ShippingDatetimeEnd)
                .HasColumnType("datetime")
                .HasColumnName("shipping_datetime_end");
            entity.Property(e => e.ShippingDatetimeStart)
                .HasColumnType("datetime")
                .HasColumnName("shipping_datetime_start");
            entity.Property(e => e.ShippingFirstname)
                .HasMaxLength(32)
                .HasColumnName("shipping_firstname");
            entity.Property(e => e.ShippingLastname)
                .HasMaxLength(32)
                .HasColumnName("shipping_lastname");
            entity.Property(e => e.ShippingLatitude)
                .HasColumnType("float(9,6)")
                .HasColumnName("shipping_latitude");
            entity.Property(e => e.ShippingLongitude)
                .HasColumnType("float(9,6)")
                .HasColumnName("shipping_longitude");
            entity.Property(e => e.ShippingMethod)
                .HasMaxLength(128)
                .HasColumnName("shipping_method");
            entity.Property(e => e.ShippingPostcode)
                .HasMaxLength(10)
                .HasColumnName("shipping_postcode");
            entity.Property(e => e.ShippingStatusId)
                .HasMaxLength(32)
                .HasColumnName("shipping_status_id");
            entity.Property(e => e.ShippingTimeEnd)
                .HasColumnType("time")
                .HasColumnName("shipping_time_end");
            entity.Property(e => e.ShippingTimeStart)
                .HasColumnType("time")
                .HasColumnName("shipping_time_start");
            entity.Property(e => e.ShippingZone)
                .HasMaxLength(128)
                .HasColumnName("shipping_zone");
            entity.Property(e => e.ShippingZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("shipping_zone_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.StoreName)
                .HasMaxLength(64)
                .HasColumnName("store_name");
            entity.Property(e => e.StoreUrl)
                .HasMaxLength(255)
                .HasColumnName("store_url");
            entity.Property(e => e.Telephone)
                .HasMaxLength(32)
                .HasColumnName("telephone");
            entity.Property(e => e.Total)
                .HasPrecision(15, 4)
                .HasColumnName("total");
            entity.Property(e => e.TrackNo)
                .HasMaxLength(32)
                .HasColumnName("track_no");
            entity.Property(e => e.Tracking)
                .HasMaxLength(64)
                .HasColumnName("tracking");
            entity.Property(e => e.UserAgent)
                .HasMaxLength(255)
                .HasColumnName("user_agent");
        });

        modelBuilder.Entity<NgOrderHistory>(entity =>
        {
            entity.HasKey(e => e.OrderHistoryId).HasName("PRIMARY");

            entity.ToTable("ng_order_history");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.HasIndex(e => e.OrderStatusId, "order_status_id");

            entity.Property(e => e.OrderHistoryId)
                .HasColumnType("int(11)")
                .HasColumnName("order_history_id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.FileName)
                .HasMaxLength(124)
                .HasColumnName("file_name");
            entity.Property(e => e.Log)
                .HasColumnType("text")
                .HasColumnName("log");
            entity.Property(e => e.Notify).HasColumnName("notify");
            entity.Property(e => e.NotifySms).HasColumnName("notify_sms");
            entity.Property(e => e.NotifyTlgrm).HasColumnName("notify_tlgrm");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.OrderStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("order_status_id");
            entity.Property(e => e.PaymentStatusId)
                .HasMaxLength(32)
                .HasColumnName("payment_status_id");
            entity.Property(e => e.ShippingStatusId)
                .HasMaxLength(32)
                .HasColumnName("shipping_status_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<NgOrderOption>(entity =>
        {
            entity.HasKey(e => e.OrderOptionId).HasName("PRIMARY");

            entity.ToTable("ng_order_option");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.HasIndex(e => e.OrderOptionId, "order_option_id");

            entity.HasIndex(e => e.OrderProductId, "order_product_id");

            entity.HasIndex(e => e.ProductOptionValueId, "product_option_value_id");

            entity.Property(e => e.OrderOptionId)
                .HasColumnType("int(11)")
                .HasColumnName("order_option_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.OrderProductId)
                .HasColumnType("int(11)")
                .HasColumnName("order_product_id");
            entity.Property(e => e.ProductOptionId)
                .HasColumnType("int(11)")
                .HasColumnName("product_option_id");
            entity.Property(e => e.ProductOptionValueId)
                .HasColumnType("int(11)")
                .HasColumnName("product_option_value_id");
            entity.Property(e => e.Type)
                .HasMaxLength(32)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgOrderProduct>(entity =>
        {
            entity.HasKey(e => e.OrderProductId).HasName("PRIMARY");

            entity.ToTable("ng_order_product");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.HasIndex(e => e.OrderProductId, "order_product_id");

            entity.Property(e => e.OrderProductId)
                .HasColumnType("int(11)")
                .HasColumnName("order_product_id");
            entity.Property(e => e.Model)
                .HasMaxLength(64)
                .HasColumnName("model");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.Price)
                .HasPrecision(15, 4)
                .HasColumnName("price");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Purchase)
                .HasPrecision(15, 4)
                .HasColumnName("purchase");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(4)")
                .HasColumnName("quantity");
            entity.Property(e => e.Reward)
                .HasColumnType("int(8)")
                .HasColumnName("reward");
            entity.Property(e => e.Tax)
                .HasPrecision(15, 4)
                .HasColumnName("tax");
            entity.Property(e => e.Total)
                .HasPrecision(15, 4)
                .HasColumnName("total");
        });

        modelBuilder.Entity<NgOrderRecurring>(entity =>
        {
            entity.HasKey(e => e.OrderRecurringId).HasName("PRIMARY");

            entity.ToTable("ng_order_recurring");

            entity.Property(e => e.OrderRecurringId)
                .HasColumnType("int(11)")
                .HasColumnName("order_recurring_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .HasColumnName("product_name");
            entity.Property(e => e.ProductQuantity)
                .HasColumnType("int(11)")
                .HasColumnName("product_quantity");
            entity.Property(e => e.RecurringCycle)
                .HasColumnType("smallint(6)")
                .HasColumnName("recurring_cycle");
            entity.Property(e => e.RecurringDescription)
                .HasMaxLength(255)
                .HasColumnName("recurring_description");
            entity.Property(e => e.RecurringDuration)
                .HasColumnType("smallint(6)")
                .HasColumnName("recurring_duration");
            entity.Property(e => e.RecurringFrequency)
                .HasMaxLength(25)
                .HasColumnName("recurring_frequency");
            entity.Property(e => e.RecurringId)
                .HasColumnType("int(11)")
                .HasColumnName("recurring_id");
            entity.Property(e => e.RecurringName)
                .HasMaxLength(255)
                .HasColumnName("recurring_name");
            entity.Property(e => e.RecurringPrice)
                .HasPrecision(10, 4)
                .HasColumnName("recurring_price");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasColumnName("reference");
            entity.Property(e => e.Status)
                .HasColumnType("tinyint(4)")
                .HasColumnName("status");
            entity.Property(e => e.Trial).HasColumnName("trial");
            entity.Property(e => e.TrialCycle)
                .HasColumnType("smallint(6)")
                .HasColumnName("trial_cycle");
            entity.Property(e => e.TrialDuration)
                .HasColumnType("smallint(6)")
                .HasColumnName("trial_duration");
            entity.Property(e => e.TrialFrequency)
                .HasMaxLength(25)
                .HasColumnName("trial_frequency");
            entity.Property(e => e.TrialPrice)
                .HasPrecision(10, 4)
                .HasColumnName("trial_price");
        });

        modelBuilder.Entity<NgOrderRecurringTransaction>(entity =>
        {
            entity.HasKey(e => e.OrderRecurringTransactionId).HasName("PRIMARY");

            entity.ToTable("ng_order_recurring_transaction");

            entity.Property(e => e.OrderRecurringTransactionId)
                .HasColumnType("int(11)")
                .HasColumnName("order_recurring_transaction_id");
            entity.Property(e => e.Amount)
                .HasPrecision(10, 4)
                .HasColumnName("amount");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.OrderRecurringId)
                .HasColumnType("int(11)")
                .HasColumnName("order_recurring_id");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasColumnName("reference");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
        });

        modelBuilder.Entity<NgOrderShipment>(entity =>
        {
            entity.HasKey(e => e.OrderShipmentId).HasName("PRIMARY");

            entity.ToTable("ng_order_shipment");

            entity.Property(e => e.OrderShipmentId)
                .HasColumnType("int(11)")
                .HasColumnName("order_shipment_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.ShippingCourierId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shipping_courier_id");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("tracking_number");
        });

        modelBuilder.Entity<NgOrderSimpleField>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("ng_order_simple_fields");

            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.Metadata)
                .HasColumnType("text")
                .HasColumnName("metadata");
        });

        modelBuilder.Entity<NgOrderStatus>(entity =>
        {
            entity.HasKey(e => new { e.OrderStatusId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_order_status");

            entity.HasIndex(e => e.OrderStatusId, "order_status_id");

            entity.Property(e => e.OrderStatusId)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11)")
                .HasColumnName("order_status_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgOrderTotal>(entity =>
        {
            entity.HasKey(e => e.OrderTotalId).HasName("PRIMARY");

            entity.ToTable("ng_order_total");

            entity.HasIndex(e => e.Code, "code");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.Property(e => e.OrderTotalId)
                .HasColumnType("int(10)")
                .HasColumnName("order_total_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Value)
                .HasPrecision(15, 4)
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgOrderVoucher>(entity =>
        {
            entity.HasKey(e => e.OrderVoucherId).HasName("PRIMARY");

            entity.ToTable("ng_order_voucher");

            entity.Property(e => e.OrderVoucherId)
                .HasColumnType("int(11)")
                .HasColumnName("order_voucher_id");
            entity.Property(e => e.Amount)
                .HasPrecision(15, 4)
                .HasColumnName("amount");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.FromEmail)
                .HasMaxLength(96)
                .HasColumnName("from_email");
            entity.Property(e => e.FromName)
                .HasMaxLength(64)
                .HasColumnName("from_name");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.ToEmail)
                .HasMaxLength(96)
                .HasColumnName("to_email");
            entity.Property(e => e.ToName)
                .HasMaxLength(64)
                .HasColumnName("to_name");
            entity.Property(e => e.VoucherId)
                .HasColumnType("int(11)")
                .HasColumnName("voucher_id");
            entity.Property(e => e.VoucherThemeId)
                .HasColumnType("int(11)")
                .HasColumnName("voucher_theme_id");
        });

        modelBuilder.Entity<NgProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("ng_product");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Cost)
                .HasPrecision(15, 4)
                .HasColumnName("cost");
            entity.Property(e => e.DateAdded)       //gf
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateAvailable) // ddf
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_available");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Ean)
                .HasMaxLength(255)
                .HasColumnName("ean");
            entity.Property(e => e.Height)
                .HasPrecision(15, 8)
                .HasColumnName("height");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Isbn)
                .HasMaxLength(255)
                .HasColumnName("isbn");
            entity.Property(e => e.Jan)
                .HasMaxLength(255)
                .HasColumnName("jan");
            entity.Property(e => e.Length)
                .HasPrecision(15, 8)
                .HasColumnName("length");
            entity.Property(e => e.LengthClassId)
                .HasColumnType("int(11)")
                .HasColumnName("length_class_id");
            entity.Property(e => e.Location)
                .HasMaxLength(128)
                .HasColumnName("location");
            entity.Property(e => e.ManufacturerId)
                .HasColumnType("int(11)")
                .HasColumnName("manufacturer_id");
            entity.Property(e => e.Minimum)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("minimum");
            entity.Property(e => e.Model)
                .HasMaxLength(64)
                .HasColumnName("model");
            entity.Property(e => e.Mpn)
                .HasMaxLength(255)
                .HasColumnName("mpn");
            entity.Property(e => e.Noindex)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("noindex");
            entity.Property(e => e.Points)
                .HasColumnType("int(8)")
                .HasColumnName("points");
            entity.Property(e => e.Price)
                .HasPrecision(15, 4)
                .HasColumnName("price");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(4)")
                .HasColumnName("quantity");
            entity.Property(e => e.Shipping)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("shipping");
            entity.Property(e => e.Sku)
                .HasMaxLength(64)
                .HasColumnName("sku");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(11)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.StockStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("stock_status_id");
            entity.Property(e => e.Subtract)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("subtract");
            entity.Property(e => e.TaxClassId)
                .HasColumnType("int(11)")
                .HasColumnName("tax_class_id");
            entity.Property(e => e.Upc)
                .HasMaxLength(255)
                .HasColumnName("upc");
            entity.Property(e => e.Viewed)
                .HasColumnType("int(5)")
                .HasColumnName("viewed");
            entity.Property(e => e.Weight)
                .HasPrecision(15, 8)
                .HasColumnName("weight");
            entity.Property(e => e.WeightClassId)
                .HasColumnType("int(11)")
                .HasColumnName("weight_class_id");
            entity.Property(e => e.Width)
                .HasPrecision(15, 8)
                .HasColumnName("width");
        });

        modelBuilder.Entity<NgProductAttribute>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.AttributeId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_product_attribute");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.AttributeId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
        });

        modelBuilder.Entity<NgProductDescription>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_product_description");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaH1)
                .HasMaxLength(255)
                .HasColumnName("meta_h1");
            entity.Property(e => e.MetaKeyword)
                .HasMaxLength(255)
                .HasColumnName("meta_keyword");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("tag");
        });

        modelBuilder.Entity<NgProductDiscount>(entity =>
        {
            entity.HasKey(e => e.ProductDiscountId).HasName("PRIMARY");

            entity.ToTable("ng_product_discount");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.ProductDiscountId)
                .HasColumnType("int(11)")
                .HasColumnName("product_discount_id");
            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
            entity.Property(e => e.DateEnd)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_end");
            entity.Property(e => e.DateStart)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_start");
            entity.Property(e => e.Price)
                .HasPrecision(15, 4)
                .HasColumnName("price");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(5)")
                .HasColumnName("priority");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(4)")
                .HasColumnName("quantity");
        });

        modelBuilder.Entity<NgProductFilter>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.FilterId }).HasName("PRIMARY");

            entity.ToTable("ng_product_filter");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.FilterId)
                .HasColumnType("int(11)")
                .HasColumnName("filter_id");
        });

        modelBuilder.Entity<NgProductImage>(entity =>
        {
            entity.HasKey(e => e.ProductImageId).HasName("PRIMARY");

            entity.ToTable("ng_product_image");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.ProductImageId)
                .HasColumnType("int(11)")
                .HasColumnName("product_image_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgProductOption>(entity =>
        {
            entity.HasKey(e => e.ProductOptionId).HasName("PRIMARY");

            entity.ToTable("ng_product_option");

            entity.Property(e => e.ProductOptionId)
                .HasColumnType("int(11)")
                .HasColumnName("product_option_id");
            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Required).HasColumnName("required");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgProductOptionValue>(entity =>
        {
            entity.HasKey(e => e.ProductOptionValueId).HasName("PRIMARY");

            entity.ToTable("ng_product_option_value");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.HasIndex(e => e.ProductOptionId, "product_option_id");

            entity.HasIndex(e => e.ProductOptionValueId, "product_option_value_id");

            entity.Property(e => e.ProductOptionValueId)
                .HasColumnType("int(11)")
                .HasColumnName("product_option_value_id");
            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.OptionValueId)
                .HasColumnType("int(11)")
                .HasColumnName("option_value_id");
            entity.Property(e => e.Points)
                .HasColumnType("int(8)")
                .HasColumnName("points");
            entity.Property(e => e.PointsPrefix)
                .HasMaxLength(1)
                .HasColumnName("points_prefix");
            entity.Property(e => e.Price)
                .HasPrecision(15, 4)
                .HasColumnName("price");
            entity.Property(e => e.PricePrefix)
                .HasMaxLength(1)
                .HasColumnName("price_prefix");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductOptionId)
                .HasColumnType("int(11)")
                .HasColumnName("product_option_id");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(3)")
                .HasColumnName("quantity");
            entity.Property(e => e.Subtract).HasColumnName("subtract");
            entity.Property(e => e.Weight)
                .HasPrecision(15, 8)
                .HasColumnName("weight");
            entity.Property(e => e.WeightPrefix)
                .HasMaxLength(1)
                .HasColumnName("weight_prefix");
        });

        modelBuilder.Entity<NgProductRecurring>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.RecurringId, e.CustomerGroupId }).HasName("PRIMARY");

            entity.ToTable("ng_product_recurring");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.RecurringId)
                .HasColumnType("int(11)")
                .HasColumnName("recurring_id");
            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
        });

        modelBuilder.Entity<NgProductRelated>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.RelatedId }).HasName("PRIMARY");

            entity.ToTable("ng_product_related");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.RelatedId)
                .HasColumnType("int(11)")
                .HasColumnName("related_id");
        });

        modelBuilder.Entity<NgProductRelatedArticle>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.ProductId }).HasName("PRIMARY");

            entity.ToTable("ng_product_related_article");

            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
        });

        modelBuilder.Entity<NgProductRelatedMn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ng_product_related_mn");

            entity.Property(e => e.ManufacturerId)
                .HasColumnType("int(11)")
                .HasColumnName("manufacturer_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
        });

        modelBuilder.Entity<NgProductRelatedWb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ng_product_related_wb");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
        });

        modelBuilder.Entity<NgProductReward>(entity =>
        {
            entity.HasKey(e => e.ProductRewardId).HasName("PRIMARY");

            entity.ToTable("ng_product_reward");

            entity.Property(e => e.ProductRewardId)
                .HasColumnType("int(11)")
                .HasColumnName("product_reward_id");
            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
            entity.Property(e => e.Points)
                .HasColumnType("int(8)")
                .HasColumnName("points");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
        });

        modelBuilder.Entity<NgProductSpecial>(entity =>
        {
            entity.HasKey(e => e.ProductSpecialId).HasName("PRIMARY");

            entity.ToTable("ng_product_special");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.ProductSpecialId)
                .HasColumnType("int(11)")
                .HasColumnName("product_special_id");
            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
            entity.Property(e => e.DateEnd)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_end");
            entity.Property(e => e.DateStart)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_start");
            entity.Property(e => e.Price)
                .HasPrecision(15, 4)
                .HasColumnName("price");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(5)")
                .HasColumnName("priority");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
        });

        modelBuilder.Entity<NgProductToCategory>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.CategoryId }).HasName("PRIMARY");

            entity.ToTable("ng_product_to_category");

            entity.HasIndex(e => e.CategoryId, "category_id");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.MainCategory).HasColumnName("main_category");
        });

        modelBuilder.Entity<NgProductToDownload>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.DownloadId }).HasName("PRIMARY");

            entity.ToTable("ng_product_to_download");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.DownloadId)
                .HasColumnType("int(11)")
                .HasColumnName("download_id");
        });

        modelBuilder.Entity<NgProductToLayout>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_product_to_layout");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.LayoutId)
                .HasColumnType("int(11)")
                .HasColumnName("layout_id");
        });

        modelBuilder.Entity<NgProductToPromProduct>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.PromProductId }).HasName("PRIMARY");

            entity.ToTable("ng_product_to_prom_product");

            entity.HasIndex(e => e.PromProductId, "prom_product_id");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.PromProductId)
                .HasColumnType("int(11)")
                .HasColumnName("prom_product_id");
        });

        modelBuilder.Entity<NgProductToStore>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_product_to_store");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgProductToSupplier>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.SupplierId }).HasName("PRIMARY");

            entity.ToTable("ng_product_to_supplier");

            entity.HasIndex(e => e.SupplierId, "supplier_id");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(64)
                .HasColumnName("supplier_id");
        });

        modelBuilder.Entity<NgPromCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PRIMARY");

            entity.ToTable("ng_prom_category");

            entity.HasIndex(e => e.ParentId, "parent_id");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.ParentId)
                .HasColumnType("int(11)")
                .HasColumnName("parent_id");
        });

        modelBuilder.Entity<NgPromId>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("ng_prom_id");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.PromId)
                .HasMaxLength(64)
                .HasColumnName("prom_id");
        });

        modelBuilder.Entity<NgRecurring>(entity =>
        {
            entity.HasKey(e => e.RecurringId).HasName("PRIMARY");

            entity.ToTable("ng_recurring");

            entity.Property(e => e.RecurringId)
                .HasColumnType("int(11)")
                .HasColumnName("recurring_id");
            entity.Property(e => e.Cycle)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cycle");
            entity.Property(e => e.Duration)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("duration");
            entity.Property(e => e.Frequency)
                .HasColumnType("enum('day','week','semi_month','month','year')")
                .HasColumnName("frequency");
            entity.Property(e => e.Price)
                .HasPrecision(10, 4)
                .HasColumnName("price");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(11)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status)
                .HasColumnType("tinyint(4)")
                .HasColumnName("status");
            entity.Property(e => e.TrialCycle)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("trial_cycle");
            entity.Property(e => e.TrialDuration)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("trial_duration");
            entity.Property(e => e.TrialFrequency)
                .HasColumnType("enum('day','week','semi_month','month','year')")
                .HasColumnName("trial_frequency");
            entity.Property(e => e.TrialPrice)
                .HasPrecision(10, 4)
                .HasColumnName("trial_price");
            entity.Property(e => e.TrialStatus)
                .HasColumnType("tinyint(4)")
                .HasColumnName("trial_status");
        });

        modelBuilder.Entity<NgRecurringDescription>(entity =>
        {
            entity.HasKey(e => new { e.RecurringId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_recurring_description");

            entity.Property(e => e.RecurringId)
                .HasColumnType("int(11)")
                .HasColumnName("recurring_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgRemarketingOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("ng_remarketing_orders");

            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Dclid)
                .HasMaxLength(255)
                .HasColumnName("dclid");
            entity.Property(e => e.Ecommerce)
                .HasColumnType("datetime")
                .HasColumnName("ecommerce");
            entity.Property(e => e.EcommerceGa4)
                .HasColumnType("datetime")
                .HasColumnName("ecommerce_ga4");
            entity.Property(e => e.Esputnik)
                .HasColumnType("datetime")
                .HasColumnName("esputnik");
            entity.Property(e => e.Facebook)
                .HasColumnType("datetime")
                .HasColumnName("facebook");
            entity.Property(e => e.FacebookLead)
                .HasColumnType("datetime")
                .HasColumnName("facebook_lead");
            entity.Property(e => e.FbEventId)
                .HasMaxLength(255)
                .HasColumnName("fb_event_id");
            entity.Property(e => e.FbLeadEventId)
                .HasMaxLength(255)
                .HasColumnName("fb_lead_event_id");
            entity.Property(e => e.Fbc)
                .HasMaxLength(255)
                .HasColumnName("fbc");
            entity.Property(e => e.Fbclid)
                .HasMaxLength(255)
                .HasColumnName("fbclid");
            entity.Property(e => e.Fbp)
                .HasMaxLength(255)
                .HasColumnName("fbp");
            entity.Property(e => e.Ga4Uuid)
                .HasMaxLength(255)
                .HasColumnName("ga4_uuid");
            entity.Property(e => e.Gclid)
                .HasMaxLength(255)
                .HasColumnName("gclid");
            entity.Property(e => e.OrderData).HasColumnName("order_data");
            entity.Property(e => e.SuccessPage)
                .HasColumnType("datetime")
                .HasColumnName("success_page");
            entity.Property(e => e.Telegram)
                .HasColumnType("datetime")
                .HasColumnName("telegram");
            entity.Property(e => e.Tiktok)
                .HasColumnType("datetime")
                .HasColumnName("tiktok");
            entity.Property(e => e.TtEventId)
                .HasMaxLength(255)
                .HasColumnName("tt_event_id");
            entity.Property(e => e.Ttclid)
                .HasMaxLength(255)
                .HasColumnName("ttclid");
            entity.Property(e => e.UtmCampaign)
                .HasMaxLength(255)
                .HasColumnName("utm_campaign");
            entity.Property(e => e.UtmContent)
                .HasMaxLength(255)
                .HasColumnName("utm_content");
            entity.Property(e => e.UtmMedium)
                .HasMaxLength(255)
                .HasColumnName("utm_medium");
            entity.Property(e => e.UtmSource)
                .HasMaxLength(255)
                .HasColumnName("utm_source");
            entity.Property(e => e.UtmTerm)
                .HasMaxLength(255)
                .HasColumnName("utm_term");
            entity.Property(e => e.Uuid)
                .HasMaxLength(255)
                .HasColumnName("uuid");
        });

        modelBuilder.Entity<NgReturn>(entity =>
        {
            entity.HasKey(e => e.ReturnId).HasName("PRIMARY");

            entity.ToTable("ng_return");

            entity.Property(e => e.ReturnId)
                .HasColumnType("int(11)")
                .HasColumnName("return_id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.DateOrdered)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_ordered");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(32)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(32)
                .HasColumnName("lastname");
            entity.Property(e => e.Model)
                .HasMaxLength(64)
                .HasColumnName("model");
            entity.Property(e => e.Opened).HasColumnName("opened");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.Product)
                .HasMaxLength(255)
                .HasColumnName("product");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(4)")
                .HasColumnName("quantity");
            entity.Property(e => e.ReturnActionId)
                .HasColumnType("int(11)")
                .HasColumnName("return_action_id");
            entity.Property(e => e.ReturnReasonId)
                .HasColumnType("int(11)")
                .HasColumnName("return_reason_id");
            entity.Property(e => e.ReturnStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("return_status_id");
            entity.Property(e => e.Telephone)
                .HasMaxLength(32)
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<NgReturnAction>(entity =>
        {
            entity.HasKey(e => new { e.ReturnActionId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_return_action");

            entity.Property(e => e.ReturnActionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11)")
                .HasColumnName("return_action_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgReturnHistory>(entity =>
        {
            entity.HasKey(e => e.ReturnHistoryId).HasName("PRIMARY");

            entity.ToTable("ng_return_history");

            entity.Property(e => e.ReturnHistoryId)
                .HasColumnType("int(11)")
                .HasColumnName("return_history_id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Notify).HasColumnName("notify");
            entity.Property(e => e.ReturnId)
                .HasColumnType("int(11)")
                .HasColumnName("return_id");
            entity.Property(e => e.ReturnStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("return_status_id");
        });

        modelBuilder.Entity<NgReturnReason>(entity =>
        {
            entity.HasKey(e => new { e.ReturnReasonId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_return_reason");

            entity.Property(e => e.ReturnReasonId)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11)")
                .HasColumnName("return_reason_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgReturnStatus>(entity =>
        {
            entity.HasKey(e => new { e.ReturnStatusId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_return_status");

            entity.Property(e => e.ReturnStatusId)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11)")
                .HasColumnName("return_status_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgReview>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PRIMARY");

            entity.ToTable("ng_review");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.ReviewId)
                .HasColumnType("int(11)")
                .HasColumnName("review_id");
            entity.Property(e => e.AdminReply)
                .HasColumnType("text")
                .HasColumnName("admin_reply");
            entity.Property(e => e.Author)
                .HasMaxLength(64)
                .HasColumnName("author");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Images)
                .HasColumnType("tinytext")
                .HasColumnName("images");
            entity.Property(e => e.Minus)
                .HasColumnType("text")
                .HasColumnName("minus");
            entity.Property(e => e.Plus)
                .HasColumnType("text")
                .HasColumnName("plus");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Rating)
                .HasColumnType("int(1)")
                .HasColumnName("rating");
            entity.Property(e => e.RealBuyer).HasColumnName("real_buyer");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.VotesMinus)
                .HasColumnType("int(11)")
                .HasColumnName("votes_minus");
            entity.Property(e => e.VotesPlus)
                .HasColumnType("int(11)")
                .HasColumnName("votes_plus");
        });

        modelBuilder.Entity<NgReviewArticle>(entity =>
        {
            entity.HasKey(e => e.ReviewArticleId).HasName("PRIMARY");

            entity.ToTable("ng_review_article");

            entity.HasIndex(e => e.ArticleId, "article_id");

            entity.Property(e => e.ReviewArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("review_article_id");
            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");
            entity.Property(e => e.Author)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("author");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Rating)
                .HasColumnType("int(1)")
                .HasColumnName("rating");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
        });

        modelBuilder.Entity<NgSeoTagsGenerator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ng_seo_tags_generator");

            entity.HasIndex(e => e.CategoryId, "category_id");

            entity.HasIndex(e => e.Key, "key");

            entity.HasIndex(e => e.LanguageId, "language_id");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.Key)
                .HasMaxLength(15)
                .HasColumnName("key");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(2)")
                .HasColumnName("language_id");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgSeoTagsGeneratorCategoryCopy>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.CopyCategoryId }).HasName("PRIMARY");

            entity.ToTable("ng_seo_tags_generator_category_copy");

            entity.HasIndex(e => e.CopyCategoryId, "copy_category_id");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.CopyCategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("copy_category_id");
        });

        modelBuilder.Entity<NgSeoTagsGeneratorCategoryDeclension>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_seo_tags_generator_category_declension");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(3)")
                .HasColumnName("language_id");
            entity.Property(e => e.CategoryNamePluralGenitive)
                .HasMaxLength(255)
                .HasColumnName("category_name_plural_genitive");
            entity.Property(e => e.CategoryNamePluralNominative)
                .HasMaxLength(255)
                .HasColumnName("category_name_plural_nominative");
            entity.Property(e => e.CategoryNameSingularGenitive)
                .HasMaxLength(255)
                .HasColumnName("category_name_singular_genitive");
            entity.Property(e => e.CategoryNameSingularNominative)
                .HasMaxLength(255)
                .HasColumnName("category_name_singular_nominative");
        });

        modelBuilder.Entity<NgSeoTagsGeneratorCategorySetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ng_seo_tags_generator_category_setting");

            entity.HasIndex(e => e.CategoryId, "category_id").IsUnique();

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.Setting)
                .HasColumnType("text")
                .HasColumnName("setting");
        });

        modelBuilder.Entity<NgSeoTagsGeneratorNotUse>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.EssenceId }).HasName("PRIMARY");

            entity.ToTable("ng_seo_tags_generator_not_use");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.EssenceId)
                .HasColumnType("int(1)")
                .HasColumnName("essence_id");
        });

        modelBuilder.Entity<NgSeoUrl>(entity =>
        {
            entity.HasKey(e => e.SeoUrlId).HasName("PRIMARY");

            entity.ToTable("ng_seo_url");

            entity.HasIndex(e => e.Keyword, "keyword");

            entity.HasIndex(e => e.Query, "query");

            entity.Property(e => e.SeoUrlId)
                .HasColumnType("int(11)")
                .HasColumnName("seo_url_id");
            entity.Property(e => e.Keyword).HasColumnName("keyword");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgSession>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PRIMARY");

            entity.ToTable("ng_session");

            entity.Property(e => e.SessionId)
                .HasMaxLength(32)
                .HasColumnName("session_id");
            entity.Property(e => e.Data)
                .HasColumnType("mediumtext")
                .HasColumnName("data");
            entity.Property(e => e.Expire)
                .HasColumnType("datetime")
                .HasColumnName("expire");
        });

        modelBuilder.Entity<NgSetting>(entity =>
        {
            entity.HasKey(e => e.SettingId).HasName("PRIMARY");

            entity.ToTable("ng_setting");

            entity.Property(e => e.SettingId)
                .HasColumnType("int(11)")
                .HasColumnName("setting_id");
            entity.Property(e => e.Code)
                .HasMaxLength(128)
                .HasColumnName("code");
            entity.Property(e => e.Key)
                .HasMaxLength(128)
                .HasColumnName("key");
            entity.Property(e => e.Serialized).HasColumnName("serialized");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.Value)
                .HasColumnType("mediumtext")
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgSettingSeolang>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ng_setting_seolang");

            entity.HasIndex(e => e.Codekey, "codekey");

            entity.HasIndex(e => e.SettingId, "setting_id").IsUnique();

            entity.HasIndex(e => e.StoreId, "store_id");

            entity.Property(e => e.Codekey)
                .HasMaxLength(128)
                .HasColumnName("codekey");
            entity.Property(e => e.Serialized).HasColumnName("serialized");
            entity.Property(e => e.SettingId)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11)")
                .HasColumnName("setting_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<NgShippingCourier>(entity =>
        {
            entity.HasKey(e => e.ShippingCourierId).HasName("PRIMARY");

            entity.ToTable("ng_shipping_courier");

            entity.Property(e => e.ShippingCourierId)
                .HasColumnType("int(11)")
                .HasColumnName("shipping_courier_id");
            entity.Property(e => e.ShippingCourierCode)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shipping_courier_code");
            entity.Property(e => e.ShippingCourierName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shipping_courier_name");
        });

        modelBuilder.Entity<NgSimpleCart>(entity =>
        {
            entity.HasKey(e => e.SimpleCartId).HasName("PRIMARY");

            entity.ToTable("ng_simple_cart");

            entity.Property(e => e.SimpleCartId)
                .HasColumnType("int(11)")
                .HasColumnName("simple_cart_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(32)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(32)
                .HasColumnName("lastname");
            entity.Property(e => e.Products)
                .HasColumnType("text")
                .HasColumnName("products");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.Telephone)
                .HasMaxLength(32)
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<NgStatistic>(entity =>
        {
            entity.HasKey(e => e.StatisticsId).HasName("PRIMARY");

            entity.ToTable("ng_statistics");

            entity.Property(e => e.StatisticsId)
                .HasColumnType("int(11)")
                .HasColumnName("statistics_id");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasColumnName("code");
            entity.Property(e => e.Value)
                .HasPrecision(15, 4)
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgStockStatus>(entity =>
        {
            entity.HasKey(e => new { e.StockStatusId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_stock_status");

            entity.Property(e => e.StockStatusId)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11)")
                .HasColumnName("stock_status_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgStore>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PRIMARY");

            entity.ToTable("ng_store");

            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Ssl)
                .HasMaxLength(255)
                .HasColumnName("ssl");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
        });

        modelBuilder.Entity<NgTaxClass>(entity =>
        {
            entity.HasKey(e => e.TaxClassId).HasName("PRIMARY");

            entity.ToTable("ng_tax_class");

            entity.Property(e => e.TaxClassId)
                .HasColumnType("int(11)")
                .HasColumnName("tax_class_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Title)
                .HasMaxLength(32)
                .HasColumnName("title");
        });

        modelBuilder.Entity<NgTaxRate>(entity =>
        {
            entity.HasKey(e => e.TaxRateId).HasName("PRIMARY");

            entity.ToTable("ng_tax_rate");

            entity.Property(e => e.TaxRateId)
                .HasColumnType("int(11)")
                .HasColumnName("tax_rate_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.GeoZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("geo_zone_id");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
            entity.Property(e => e.Rate)
                .HasPrecision(15, 4)
                .HasColumnName("rate");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("type");
        });

        modelBuilder.Entity<NgTaxRateToCustomerGroup>(entity =>
        {
            entity.HasKey(e => new { e.TaxRateId, e.CustomerGroupId }).HasName("PRIMARY");

            entity.ToTable("ng_tax_rate_to_customer_group");

            entity.Property(e => e.TaxRateId)
                .HasColumnType("int(11)")
                .HasColumnName("tax_rate_id");
            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
        });

        modelBuilder.Entity<NgTaxRule>(entity =>
        {
            entity.HasKey(e => e.TaxRuleId).HasName("PRIMARY");

            entity.ToTable("ng_tax_rule");

            entity.Property(e => e.TaxRuleId)
                .HasColumnType("int(11)")
                .HasColumnName("tax_rule_id");
            entity.Property(e => e.Based)
                .HasMaxLength(10)
                .HasColumnName("based");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(5)")
                .HasColumnName("priority");
            entity.Property(e => e.TaxClassId)
                .HasColumnType("int(11)")
                .HasColumnName("tax_class_id");
            entity.Property(e => e.TaxRateId)
                .HasColumnType("int(11)")
                .HasColumnName("tax_rate_id");
        });

        modelBuilder.Entity<NgTheme>(entity =>
        {
            entity.HasKey(e => e.ThemeId).HasName("PRIMARY");

            entity.ToTable("ng_theme");

            entity.Property(e => e.ThemeId)
                .HasColumnType("int(11)")
                .HasColumnName("theme_id");
            entity.Property(e => e.Code)
                .HasColumnType("mediumtext")
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Route)
                .HasMaxLength(64)
                .HasColumnName("route");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.Theme)
                .HasMaxLength(64)
                .HasColumnName("theme");
        });

        modelBuilder.Entity<NgTranslation>(entity =>
        {
            entity.HasKey(e => e.TranslationId).HasName("PRIMARY");

            entity.ToTable("ng_translation");

            entity.Property(e => e.TranslationId)
                .HasColumnType("int(11)")
                .HasColumnName("translation_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Key)
                .HasMaxLength(64)
                .HasColumnName("key");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Route)
                .HasMaxLength(64)
                .HasColumnName("route");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgUniGallery>(entity =>
        {
            entity.HasKey(e => e.GalleryId).HasName("PRIMARY");

            entity.ToTable("ng_uni_gallery");

            entity.Property(e => e.GalleryId)
                .HasColumnType("int(11)")
                .HasColumnName("gallery_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<NgUniGalleryDescription>(entity =>
        {
            entity.HasKey(e => new { e.GalleryId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_uni_gallery_description");

            entity.Property(e => e.GalleryId)
                .HasColumnType("int(11)")
                .HasColumnName("gallery_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaKeyword)
                .HasMaxLength(255)
                .HasColumnName("meta_keyword");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgUniGalleryImage>(entity =>
        {
            entity.HasKey(e => e.ImageId).HasName("PRIMARY");

            entity.ToTable("ng_uni_gallery_image");

            entity.Property(e => e.ImageId)
                .HasColumnType("int(11)")
                .HasColumnName("image_id");
            entity.Property(e => e.GalleryId)
                .HasColumnType("int(11)")
                .HasColumnName("gallery_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<NgUniGalleryImageDescription>(entity =>
        {
            entity.HasKey(e => new { e.ImageId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_uni_gallery_image_description");

            entity.Property(e => e.ImageId)
                .HasColumnType("int(11)")
                .HasColumnName("image_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<NgUniGalleryToStore>(entity =>
        {
            entity.HasKey(e => new { e.GalleryId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_uni_gallery_to_store");

            entity.Property(e => e.GalleryId)
                .HasColumnType("int(11)")
                .HasColumnName("gallery_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgUniNewsCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PRIMARY");

            entity.ToTable("ng_uni_news_category");

            entity.HasIndex(e => e.ParentId, "parent_id");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.ParentId)
                .HasColumnType("int(11)")
                .HasColumnName("parent_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<NgUniNewsCategoryDescription>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_uni_news_category_description");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaH1)
                .HasMaxLength(255)
                .HasColumnName("meta_h1");
            entity.Property(e => e.MetaKeyword)
                .HasMaxLength(255)
                .HasColumnName("meta_keyword");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<NgUniNewsCategoryPath>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.PathId }).HasName("PRIMARY");

            entity.ToTable("ng_uni_news_category_path");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.PathId)
                .HasColumnType("int(11)")
                .HasColumnName("path_id");
            entity.Property(e => e.Level)
                .HasColumnType("int(11)")
                .HasColumnName("level");
        });

        modelBuilder.Entity<NgUniNewsCategoryToStore>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_uni_news_category_to_store");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgUniNewsProductRelated>(entity =>
        {
            entity.HasKey(e => new { e.NewsId, e.ProductId }).HasName("PRIMARY");

            entity.ToTable("ng_uni_news_product_related");

            entity.Property(e => e.NewsId)
                .HasColumnType("int(11)")
                .HasColumnName("news_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
        });

        modelBuilder.Entity<NgUniNewsStory>(entity =>
        {
            entity.HasKey(e => e.NewsId).HasName("PRIMARY");

            entity.ToTable("ng_uni_news_story");

            entity.Property(e => e.NewsId)
                .HasColumnType("int(11)")
                .HasColumnName("news_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Viewed)
                .HasColumnType("int(11)")
                .HasColumnName("viewed");
        });

        modelBuilder.Entity<NgUniNewsStoryDescription>(entity =>
        {
            entity.HasKey(e => new { e.NewsId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_uni_news_story_description");

            entity.Property(e => e.NewsId)
                .HasColumnType("int(11)")
                .HasColumnName("news_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaH1)
                .HasMaxLength(255)
                .HasColumnName("meta_h1");
            entity.Property(e => e.MetaKeyword)
                .HasMaxLength(255)
                .HasColumnName("meta_keyword");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgUniNewsStoryToCategory>(entity =>
        {
            entity.HasKey(e => new { e.NewsId, e.CategoryId }).HasName("PRIMARY");

            entity.ToTable("ng_uni_news_story_to_category");

            entity.HasIndex(e => e.CategoryId, "category_id");

            entity.Property(e => e.NewsId)
                .HasColumnType("int(11)")
                .HasColumnName("news_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
        });

        modelBuilder.Entity<NgUniNewsStoryToStore>(entity =>
        {
            entity.HasKey(e => new { e.NewsId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("ng_uni_news_story_to_store");

            entity.Property(e => e.NewsId)
                .HasColumnType("int(11)")
                .HasColumnName("news_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgUniRequest>(entity =>
        {
            entity.HasKey(e => e.RequestId).HasName("PRIMARY");

            entity.ToTable("ng_uni_request");

            entity.Property(e => e.RequestId)
                .HasColumnType("int(11)")
                .HasColumnName("request_id");
            entity.Property(e => e.AdminComment)
                .HasColumnType("text")
                .HasColumnName("admin_comment");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_modified");
            entity.Property(e => e.Mail)
                .HasMaxLength(64)
                .HasColumnName("mail");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(64)
                .HasColumnName("phone");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.RequestList).HasColumnName("request_list");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(64)
                .HasColumnName("type");
        });

        modelBuilder.Entity<NgUniSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ng_uni_setting");

            entity.Property(e => e.Data)
                .HasColumnType("mediumtext")
                .HasColumnName("data");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<NgUpload>(entity =>
        {
            entity.HasKey(e => e.UploadId).HasName("PRIMARY");

            entity.ToTable("ng_upload");

            entity.Property(e => e.UploadId)
                .HasColumnType("int(11)")
                .HasColumnName("upload_id");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("filename");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("ng_user");

            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
            entity.Property(e => e.Code)
                .HasMaxLength(40)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(32)
                .HasColumnName("firstname");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Ip)
                .HasMaxLength(40)
                .HasColumnName("ip");
            entity.Property(e => e.Lastname)
                .HasMaxLength(32)
                .HasColumnName("lastname");
            entity.Property(e => e.Password)
                .HasMaxLength(40)
                .HasColumnName("password");
            entity.Property(e => e.Salt)
                .HasMaxLength(9)
                .HasColumnName("salt");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TelegramId)
                .HasColumnType("text")
                .HasColumnName("telegram_id");
            entity.Property(e => e.Telephone)
                .HasMaxLength(32)
                .HasColumnName("telephone");
            entity.Property(e => e.UserGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("user_group_id");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasColumnName("username");
        });

        modelBuilder.Entity<NgUserGroup>(entity =>
        {
            entity.HasKey(e => e.UserGroupId).HasName("PRIMARY");

            entity.ToTable("ng_user_group");

            entity.Property(e => e.UserGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("user_group_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Permission)
                .HasColumnType("text")
                .HasColumnName("permission");
        });

        modelBuilder.Entity<NgVoucher>(entity =>
        {
            entity.HasKey(e => e.VoucherId).HasName("PRIMARY");

            entity.ToTable("ng_voucher");

            entity.Property(e => e.VoucherId)
                .HasColumnType("int(11)")
                .HasColumnName("voucher_id");
            entity.Property(e => e.Amount)
                .HasPrecision(15, 4)
                .HasColumnName("amount");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.FromEmail)
                .HasMaxLength(96)
                .HasColumnName("from_email");
            entity.Property(e => e.FromName)
                .HasMaxLength(64)
                .HasColumnName("from_name");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.ToEmail)
                .HasMaxLength(96)
                .HasColumnName("to_email");
            entity.Property(e => e.ToName)
                .HasMaxLength(64)
                .HasColumnName("to_name");
            entity.Property(e => e.VoucherThemeId)
                .HasColumnType("int(11)")
                .HasColumnName("voucher_theme_id");
        });

        modelBuilder.Entity<NgVoucherHistory>(entity =>
        {
            entity.HasKey(e => e.VoucherHistoryId).HasName("PRIMARY");

            entity.ToTable("ng_voucher_history");

            entity.Property(e => e.VoucherHistoryId)
                .HasColumnType("int(11)")
                .HasColumnName("voucher_history_id");
            entity.Property(e => e.Amount)
                .HasPrecision(15, 4)
                .HasColumnName("amount");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.VoucherId)
                .HasColumnType("int(11)")
                .HasColumnName("voucher_id");
        });

        modelBuilder.Entity<NgVoucherTheme>(entity =>
        {
            entity.HasKey(e => e.VoucherThemeId).HasName("PRIMARY");

            entity.ToTable("ng_voucher_theme");

            entity.Property(e => e.VoucherThemeId)
                .HasColumnType("int(11)")
                .HasColumnName("voucher_theme_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
        });

        modelBuilder.Entity<NgVoucherThemeDescription>(entity =>
        {
            entity.HasKey(e => new { e.VoucherThemeId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_voucher_theme_description");

            entity.Property(e => e.VoucherThemeId)
                .HasColumnType("int(11)")
                .HasColumnName("voucher_theme_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NgWeightClass>(entity =>
        {
            entity.HasKey(e => e.WeightClassId).HasName("PRIMARY");

            entity.ToTable("ng_weight_class");

            entity.Property(e => e.WeightClassId)
                .HasColumnType("int(11)")
                .HasColumnName("weight_class_id");
            entity.Property(e => e.Value)
                .HasPrecision(15, 8)
                .HasColumnName("value");
        });

        modelBuilder.Entity<NgWeightClassDescription>(entity =>
        {
            entity.HasKey(e => new { e.WeightClassId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("ng_weight_class_description");

            entity.Property(e => e.WeightClassId)
                .HasColumnType("int(11)")
                .HasColumnName("weight_class_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Title)
                .HasMaxLength(32)
                .HasColumnName("title");
            entity.Property(e => e.Unit)
                .HasMaxLength(4)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<NgZone>(entity =>
        {
            entity.HasKey(e => e.ZoneId).HasName("PRIMARY");

            entity.ToTable("ng_zone");

            entity.Property(e => e.ZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("zone_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.CountryId)
                .HasColumnType("int(11)")
                .HasColumnName("country_id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<NgZoneToGeoZone>(entity =>
        {
            entity.HasKey(e => e.ZoneToGeoZoneId).HasName("PRIMARY");

            entity.ToTable("ng_zone_to_geo_zone");

            entity.Property(e => e.ZoneToGeoZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("zone_to_geo_zone_id");
            entity.Property(e => e.CountryId)
                .HasColumnType("int(11)")
                .HasColumnName("country_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.GeoZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("geo_zone_id");
            entity.Property(e => e.ZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("zone_id");
        });

        modelBuilder.Entity<MmProductsManualSetPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mm_products_manual_set_prices");

            entity.HasIndex(e => e.Sku).IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DateEnd)
                .HasMaxLength(6)
                .HasColumnName("date_end");
            entity.Property(e => e.DateStart)
                .HasMaxLength(6)
                .HasColumnName("date_start");
            entity.Property(e => e.SetInStockPrice)
                .HasColumnType("int(11)")
                .HasColumnName("set_in_stock_price");
            entity.Property(e => e.Sku).HasColumnName("sku");
        });

        modelBuilder.Entity<MmProductsManualSetQuanity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mm_products_manual_set_quanitys");

            entity.HasIndex(e => e.Sku, "ix_products_manual_set_quanitys_sku").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DateEnd)
                .HasMaxLength(6)
                .HasColumnName("date_end");
            entity.Property(e => e.DateStart)
                .HasMaxLength(6)
                .HasColumnName("date_start");
            entity.Property(e => e.SetInStockQty)
                .HasColumnType("int(11)")
                .HasColumnName("set_in_stock_qty");
            entity.Property(e => e.Sku).HasColumnName("sku");
        });

        modelBuilder.Entity<MmProductsSetQuantityWhenMin>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
                entity.ToTable("mm_products_set_quantity_when_min");
                
                entity.HasIndex(e => e.Sku).IsUnique();
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
            });
            

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
