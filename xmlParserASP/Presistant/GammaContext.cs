using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.Gamma;

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

    public virtual DbSet<OcAddress> OcAddresses { get; set; }

    public virtual DbSet<OcAddressSimpleField> OcAddressSimpleFields { get; set; }

    public virtual DbSet<OcAffiliate> OcAffiliates { get; set; }

    public virtual DbSet<OcAffiliateActivity> OcAffiliateActivities { get; set; }

    public virtual DbSet<OcAffiliateLogin> OcAffiliateLogins { get; set; }

    public virtual DbSet<OcAffiliateTransaction> OcAffiliateTransactions { get; set; }

    public virtual DbSet<OcAgooSigner> OcAgooSigners { get; set; }

    public virtual DbSet<OcApi> OcApis { get; set; }

    public virtual DbSet<OcApiIp> OcApiIps { get; set; }

    public virtual DbSet<OcApiSession> OcApiSessions { get; set; }

    public virtual DbSet<OcAttributableToAttribute> OcAttributableToAttributes { get; set; }

    public virtual DbSet<OcAttribute> OcAttributes { get; set; }

    public virtual DbSet<OcAttributeDescription> OcAttributeDescriptions { get; set; }

    public virtual DbSet<OcAttributeEnum> OcAttributeEnums { get; set; }

    public virtual DbSet<OcAttributeEnumDescription> OcAttributeEnumDescriptions { get; set; }

    public virtual DbSet<OcAttributeEnumeration> OcAttributeEnumerations { get; set; }

    public virtual DbSet<OcAttributeEnumerationDescription> OcAttributeEnumerationDescriptions { get; set; }

    public virtual DbSet<OcAttributeGroup> OcAttributeGroups { get; set; }

    public virtual DbSet<OcAttributeGroupDescription> OcAttributeGroupDescriptions { get; set; }

    public virtual DbSet<OcAttributeTemplate> OcAttributeTemplates { get; set; }

    public virtual DbSet<OcAttributeTemplateAttribute> OcAttributeTemplateAttributes { get; set; }

    public virtual DbSet<OcAttributeTemplateDescription> OcAttributeTemplateDescriptions { get; set; }

    public virtual DbSet<OcAttributeTemplateToAttributeToAttributable> OcAttributeTemplateToAttributeToAttributables { get; set; }

    public virtual DbSet<OcAttributeUnit> OcAttributeUnits { get; set; }

    public virtual DbSet<OcAttributeUnitDescription> OcAttributeUnitDescriptions { get; set; }

    public virtual DbSet<OcBanner> OcBanners { get; set; }

    public virtual DbSet<OcBannerImage> OcBannerImages { get; set; }

    public virtual DbSet<OcCart> OcCarts { get; set; }

    public virtual DbSet<OcCategory> OcCategories { get; set; }

    public virtual DbSet<OcCategoryDescription> OcCategoryDescriptions { get; set; }

    public virtual DbSet<OcCategoryFilter> OcCategoryFilters { get; set; }

    public virtual DbSet<OcCategoryPath> OcCategoryPaths { get; set; }

    public virtual DbSet<OcCategoryToLayout> OcCategoryToLayouts { get; set; }

    public virtual DbSet<OcCategoryToPromCategory> OcCategoryToPromCategories { get; set; }

    public virtual DbSet<OcCategoryToStore> OcCategoryToStores { get; set; }

    public virtual DbSet<OcContactsCacheEmail> OcContactsCacheEmails { get; set; }

    public virtual DbSet<OcContactsCacheProduct> OcContactsCacheProducts { get; set; }

    public virtual DbSet<OcContactsCacheSend> OcContactsCacheSends { get; set; }

    public virtual DbSet<OcContactsClick> OcContactsClicks { get; set; }

    public virtual DbSet<OcContactsCountMail> OcContactsCountMails { get; set; }

    public virtual DbSet<OcContactsCron> OcContactsCrons { get; set; }

    public virtual DbSet<OcContactsCronDatum> OcContactsCronData { get; set; }

    public virtual DbSet<OcContactsCronEmail> OcContactsCronEmails { get; set; }

    public virtual DbSet<OcContactsCronHistory> OcContactsCronHistories { get; set; }

    public virtual DbSet<OcContactsGroup> OcContactsGroups { get; set; }

    public virtual DbSet<OcContactsNewsletter> OcContactsNewsletters { get; set; }

    public virtual DbSet<OcContactsReqreviewMail> OcContactsReqreviewMails { get; set; }

    public virtual DbSet<OcContactsReqreviewProduct> OcContactsReqreviewProducts { get; set; }

    public virtual DbSet<OcContactsTemplate> OcContactsTemplates { get; set; }

    public virtual DbSet<OcContactsUnsubscribe> OcContactsUnsubscribes { get; set; }

    public virtual DbSet<OcContactsView> OcContactsViews { get; set; }

    public virtual DbSet<OcCountry> OcCountries { get; set; }

    public virtual DbSet<OcCoupon> OcCoupons { get; set; }

    public virtual DbSet<OcCouponCategory> OcCouponCategories { get; set; }

    public virtual DbSet<OcCouponHistory> OcCouponHistories { get; set; }

    public virtual DbSet<OcCouponProduct> OcCouponProducts { get; set; }

    public virtual DbSet<OcCurrency> OcCurrencies { get; set; }

    public virtual DbSet<OcCustomField> OcCustomFields { get; set; }

    public virtual DbSet<OcCustomFieldCustomerGroup> OcCustomFieldCustomerGroups { get; set; }

    public virtual DbSet<OcCustomFieldDescription> OcCustomFieldDescriptions { get; set; }

    public virtual DbSet<OcCustomFieldValue> OcCustomFieldValues { get; set; }

    public virtual DbSet<OcCustomFieldValueDescription> OcCustomFieldValueDescriptions { get; set; }

    public virtual DbSet<OcCustomMenu> OcCustomMenus { get; set; }

    public virtual DbSet<OcCustomMenuDescription> OcCustomMenuDescriptions { get; set; }

    public virtual DbSet<OcCustomer> OcCustomers { get; set; }

    public virtual DbSet<OcCustomerActivity> OcCustomerActivities { get; set; }

    public virtual DbSet<OcCustomerGroup> OcCustomerGroups { get; set; }

    public virtual DbSet<OcCustomerGroupDescription> OcCustomerGroupDescriptions { get; set; }

    public virtual DbSet<OcCustomerHistory> OcCustomerHistories { get; set; }

    public virtual DbSet<OcCustomerIp> OcCustomerIps { get; set; }

    public virtual DbSet<OcCustomerLogin> OcCustomerLogins { get; set; }

    public virtual DbSet<OcCustomerOnline> OcCustomerOnlines { get; set; }

    public virtual DbSet<OcCustomerReward> OcCustomerRewards { get; set; }

    public virtual DbSet<OcCustomerSearch> OcCustomerSearches { get; set; }

    public virtual DbSet<OcCustomerSimpleField> OcCustomerSimpleFields { get; set; }

    public virtual DbSet<OcCustomerTransaction> OcCustomerTransactions { get; set; }

    public virtual DbSet<OcCustomerWishlist> OcCustomerWishlists { get; set; }

    public virtual DbSet<OcDownload> OcDownloads { get; set; }

    public virtual DbSet<OcDownloadDescription> OcDownloadDescriptions { get; set; }

    public virtual DbSet<OcEvent> OcEvents { get; set; }

    public virtual DbSet<OcExtension> OcExtensions { get; set; }

    public virtual DbSet<OcFilter> OcFilters { get; set; }

    public virtual DbSet<OcFilterDescription> OcFilterDescriptions { get; set; }

    public virtual DbSet<OcFilterGroup> OcFilterGroups { get; set; }

    public virtual DbSet<OcFilterGroupDescription> OcFilterGroupDescriptions { get; set; }

    public virtual DbSet<OcGeoZone> OcGeoZones { get; set; }

    public virtual DbSet<OcInformation> OcInformations { get; set; }

    public virtual DbSet<OcInformationDescription> OcInformationDescriptions { get; set; }

    public virtual DbSet<OcInformationToLayout> OcInformationToLayouts { get; set; }

    public virtual DbSet<OcInformationToStore> OcInformationToStores { get; set; }

    public virtual DbSet<OcKdWarehouseCode> OcKdWarehouseCodes { get; set; }

    public virtual DbSet<OcKey> OcKeys { get; set; }

    public virtual DbSet<OcLanguage> OcLanguages { get; set; }

    public virtual DbSet<OcLayout> OcLayouts { get; set; }

    public virtual DbSet<OcLayoutModule> OcLayoutModules { get; set; }

    public virtual DbSet<OcLayoutRoute> OcLayoutRoutes { get; set; }

    public virtual DbSet<OcLengthClass> OcLengthClasses { get; set; }

    public virtual DbSet<OcLengthClassDescription> OcLengthClassDescriptions { get; set; }

    public virtual DbSet<OcLocation> OcLocations { get; set; }

    public virtual DbSet<OcLostedCart> OcLostedCarts { get; set; }

    public virtual DbSet<OcLostedCartLog> OcLostedCartLogs { get; set; }

    public virtual DbSet<OcManufacturer> OcManufacturers { get; set; }

    public virtual DbSet<OcManufacturerDescription> OcManufacturerDescriptions { get; set; }

    public virtual DbSet<OcManufacturerToStore> OcManufacturerToStores { get; set; }

    public virtual DbSet<OcMarketing> OcMarketings { get; set; }

    public virtual DbSet<OcMenu> OcMenus { get; set; }

    public virtual DbSet<OcMenuDescription> OcMenuDescriptions { get; set; }

    public virtual DbSet<OcMenuModule> OcMenuModules { get; set; }

    public virtual DbSet<OcModification> OcModifications { get; set; }

    public virtual DbSet<OcModule> OcModules { get; set; }

    public virtual DbSet<OcMultiXml> OcMultiXmls { get; set; }

    public virtual DbSet<OcMultiplicityProduct> OcMultiplicityProducts { get; set; }

    public virtual DbSet<OcNixSupplier> OcNixSuppliers { get; set; }

    public virtual DbSet<OcNovaposhtaCity> OcNovaposhtaCities { get; set; }

    public virtual DbSet<OcNovaposhtaReference> OcNovaposhtaReferences { get; set; }

    public virtual DbSet<OcNovaposhtaWarehouse> OcNovaposhtaWarehouses { get; set; }

    public virtual DbSet<OcOcfilterHref> OcOcfilterHrefs { get; set; }

    public virtual DbSet<OcOcfilterOption> OcOcfilterOptions { get; set; }

    public virtual DbSet<OcOcfilterOptionDescription> OcOcfilterOptionDescriptions { get; set; }

    public virtual DbSet<OcOcfilterOptionToCategory> OcOcfilterOptionToCategories { get; set; }

    public virtual DbSet<OcOcfilterOptionToStore> OcOcfilterOptionToStores { get; set; }

    public virtual DbSet<OcOcfilterOptionValue> OcOcfilterOptionValues { get; set; }

    public virtual DbSet<OcOcfilterOptionValueDescription> OcOcfilterOptionValueDescriptions { get; set; }

    public virtual DbSet<OcOcfilterOptionValueToProduct> OcOcfilterOptionValueToProducts { get; set; }

    public virtual DbSet<OcOcfilterOptionValueToProductDescription> OcOcfilterOptionValueToProductDescriptions { get; set; }

    public virtual DbSet<OcOcfilterPage> OcOcfilterPages { get; set; }

    public virtual DbSet<OcOcfilterPageDescription> OcOcfilterPageDescriptions { get; set; }

    public virtual DbSet<OcOnOrder> OcOnOrders { get; set; }

    public virtual DbSet<OcOption> OcOptions { get; set; }

    public virtual DbSet<OcOptionDescription> OcOptionDescriptions { get; set; }

    public virtual DbSet<OcOptionValue> OcOptionValues { get; set; }

    public virtual DbSet<OcOptionValueDescription> OcOptionValueDescriptions { get; set; }

    public virtual DbSet<OcOrder> OcOrders { get; set; }

    public virtual DbSet<OcOrderCustomField> OcOrderCustomFields { get; set; }

    public virtual DbSet<OcOrderHistory> OcOrderHistories { get; set; }

    public virtual DbSet<OcOrderOption> OcOrderOptions { get; set; }

    public virtual DbSet<OcOrderPermission> OcOrderPermissions { get; set; }

    public virtual DbSet<OcOrderProduct> OcOrderProducts { get; set; }

    public virtual DbSet<OcOrderRecurring> OcOrderRecurrings { get; set; }

    public virtual DbSet<OcOrderRecurringTransaction> OcOrderRecurringTransactions { get; set; }

    public virtual DbSet<OcOrderSimpleField> OcOrderSimpleFields { get; set; }

    public virtual DbSet<OcOrderStatus> OcOrderStatuses { get; set; }

    public virtual DbSet<OcOrderTotal> OcOrderTotals { get; set; }

    public virtual DbSet<OcOrderVoucher> OcOrderVouchers { get; set; }

    public virtual DbSet<OcProduct> OcProducts { get; set; }

    public virtual DbSet<OcProductAttribute> OcProductAttributes { get; set; }

    public virtual DbSet<OcProductDescription> OcProductDescriptions { get; set; }

    public virtual DbSet<OcProductDiscount> OcProductDiscounts { get; set; }

    public virtual DbSet<OcProductFilter> OcProductFilters { get; set; }

    public virtual DbSet<OcProductImage> OcProductImages { get; set; }

    public virtual DbSet<OcProductOption> OcProductOptions { get; set; }

    public virtual DbSet<OcProductOptionValue> OcProductOptionValues { get; set; }

    public virtual DbSet<OcProductOwnerPriority> OcProductOwnerPriorities { get; set; }

    public virtual DbSet<OcProductRecurring> OcProductRecurrings { get; set; }

    public virtual DbSet<OcProductRelated> OcProductRelateds { get; set; }

    public virtual DbSet<OcProductReward> OcProductRewards { get; set; }

    public virtual DbSet<OcProductSpecial> OcProductSpecials { get; set; }

    public virtual DbSet<OcProductToAttributeReserved> OcProductToAttributeReserveds { get; set; }

    public virtual DbSet<OcProductToAttributeToEnum> OcProductToAttributeToEnums { get; set; }

    public virtual DbSet<OcProductToCategory> OcProductToCategories { get; set; }

    public virtual DbSet<OcProductToDownload> OcProductToDownloads { get; set; }

    public virtual DbSet<OcProductToLayout> OcProductToLayouts { get; set; }

    public virtual DbSet<OcProductToPromProduct> OcProductToPromProducts { get; set; }

    public virtual DbSet<OcProductToStore> OcProductToStores { get; set; }

    public virtual DbSet<OcProductToSupplier> OcProductToSuppliers { get; set; }

    public virtual DbSet<OcProductToTranslate> OcProductToTranslates { get; set; }

    public virtual DbSet<OcPromCategory> OcPromCategories { get; set; }

    public virtual DbSet<OcPromCategoryDescription> OcPromCategoryDescriptions { get; set; }

    public virtual DbSet<OcPromId> OcPromIds { get; set; }

    public virtual DbSet<OcRecurring> OcRecurrings { get; set; }

    public virtual DbSet<OcRecurringDescription> OcRecurringDescriptions { get; set; }

    public virtual DbSet<OcRedirect> OcRedirects { get; set; }

    public virtual DbSet<OcRelated> OcRelateds { get; set; }

    public virtual DbSet<OcRelatedoption> OcRelatedoptions { get; set; }

    public virtual DbSet<OcRelatedoptionsDiscount> OcRelatedoptionsDiscounts { get; set; }

    public virtual DbSet<OcRelatedoptionsOption> OcRelatedoptionsOptions { get; set; }

    public virtual DbSet<OcRelatedoptionsSpecial> OcRelatedoptionsSpecials { get; set; }

    public virtual DbSet<OcRelatedoptionsToChar> OcRelatedoptionsToChars { get; set; }

    public virtual DbSet<OcRelatedoptionsVariant> OcRelatedoptionsVariants { get; set; }

    public virtual DbSet<OcRelatedoptionsVariantOption> OcRelatedoptionsVariantOptions { get; set; }

    public virtual DbSet<OcRelatedoptionsVariantProduct> OcRelatedoptionsVariantProducts { get; set; }

    public virtual DbSet<OcRemarketingOrder> OcRemarketingOrders { get; set; }

    public virtual DbSet<OcReturn> OcReturns { get; set; }

    public virtual DbSet<OcReturnAction> OcReturnActions { get; set; }

    public virtual DbSet<OcReturnHistory> OcReturnHistories { get; set; }

    public virtual DbSet<OcReturnReason> OcReturnReasons { get; set; }

    public virtual DbSet<OcReturnStatus> OcReturnStatuses { get; set; }

    public virtual DbSet<OcReview> OcReviews { get; set; }

    public virtual DbSet<OcSeoTagsGenerator> OcSeoTagsGenerators { get; set; }

    public virtual DbSet<OcSeoTagsGeneratorCategoryCopy> OcSeoTagsGeneratorCategoryCopies { get; set; }

    public virtual DbSet<OcSeoTagsGeneratorCategoryDeclension> OcSeoTagsGeneratorCategoryDeclensions { get; set; }

    public virtual DbSet<OcSeoTagsGeneratorCategorySetting> OcSeoTagsGeneratorCategorySettings { get; set; }

    public virtual DbSet<OcSeoTagsGeneratorNotUse> OcSeoTagsGeneratorNotUses { get; set; }

    public virtual DbSet<OcSetting> OcSettings { get; set; }

    public virtual DbSet<OcSimpleCart> OcSimpleCarts { get; set; }

    public virtual DbSet<OcStockStatus> OcStockStatuses { get; set; }

    public virtual DbSet<OcStore> OcStores { get; set; }

    public virtual DbSet<OcSuppler> OcSupplers { get; set; }

    public virtual DbSet<OcSupplerAttribute> OcSupplerAttributes { get; set; }

    public virtual DbSet<OcSupplerBasePrice> OcSupplerBasePrices { get; set; }

    public virtual DbSet<OcSupplerCron> OcSupplerCrons { get; set; }

    public virtual DbSet<OcSupplerDatum> OcSupplerData { get; set; }

    public virtual DbSet<OcSupplerOption> OcSupplerOptions { get; set; }

    public virtual DbSet<OcSupplerPrice> OcSupplerPrices { get; set; }

    public virtual DbSet<OcSupplerRef> OcSupplerRefs { get; set; }

    public virtual DbSet<OcSupplerSeo> OcSupplerSeos { get; set; }

    public virtual DbSet<OcSupplerSku> OcSupplerSkus { get; set; }

    public virtual DbSet<OcSupplerSkuDescription> OcSupplerSkuDescriptions { get; set; }

    public virtual DbSet<OcTaxClass> OcTaxClasses { get; set; }

    public virtual DbSet<OcTaxRate> OcTaxRates { get; set; }

    public virtual DbSet<OcTaxRateToCustomerGroup> OcTaxRateToCustomerGroups { get; set; }

    public virtual DbSet<OcTaxRule> OcTaxRules { get; set; }

    public virtual DbSet<OcTheme> OcThemes { get; set; }

    public virtual DbSet<OcTranslation> OcTranslations { get; set; }

    public virtual DbSet<OcUniBannerInCategory> OcUniBannerInCategories { get; set; }

    public virtual DbSet<OcUniBannerInCategoryDescription> OcUniBannerInCategoryDescriptions { get; set; }

    public virtual DbSet<OcUniBannerInCategoryToCategory> OcUniBannerInCategoryToCategories { get; set; }

    public virtual DbSet<OcUniBannerInCategoryToStore> OcUniBannerInCategoryToStores { get; set; }

    public virtual DbSet<OcUniGallery> OcUniGalleries { get; set; }

    public virtual DbSet<OcUniGalleryImage> OcUniGalleryImages { get; set; }

    public virtual DbSet<OcUniGalleryImageDescription> OcUniGalleryImageDescriptions { get; set; }

    public virtual DbSet<OcUniNews> OcUniNews { get; set; }

    public virtual DbSet<OcUniNewsDescription> OcUniNewsDescriptions { get; set; }

    public virtual DbSet<OcUniNewsToStore> OcUniNewsToStores { get; set; }

    public virtual DbSet<OcUniSetting> OcUniSettings { get; set; }

    public virtual DbSet<OcUnit> OcUnits { get; set; }

    public virtual DbSet<OcUpload> OcUploads { get; set; }

    public virtual DbSet<OcUrlAlias> OcUrlAliases { get; set; }

    public virtual DbSet<OcUrlAliasBlog> OcUrlAliasBlogs { get; set; }

    public virtual DbSet<OcUser> OcUsers { get; set; }

    public virtual DbSet<OcUserGroup> OcUserGroups { get; set; }

    public virtual DbSet<OcVoucher> OcVouchers { get; set; }

    public virtual DbSet<OcVoucherHistory> OcVoucherHistories { get; set; }

    public virtual DbSet<OcVoucherTheme> OcVoucherThemes { get; set; }

    public virtual DbSet<OcVoucherThemeDescription> OcVoucherThemeDescriptions { get; set; }

    public virtual DbSet<OcWeightClass> OcWeightClasses { get; set; }

    public virtual DbSet<OcWeightClassDescription> OcWeightClassDescriptions { get; set; }

    public virtual DbSet<OcZone> OcZones { get; set; }

    public virtual DbSet<OcZoneToGeoZone> OcZoneToGeoZones { get; set; }

    public virtual DbSet<ProductCustomerOrder> ProductCustomerOrders { get; set; }

    public virtual DbSet<ProductOrder> ProductOrders { get; set; }

    public virtual DbSet<ProductLimitQuantity> ProductLimitQuantities { get; set; }

    public virtual DbSet<ProductSetDiscount> ProductSetDiscounts { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Database=zi391919_gamma;Data Source=zi391919.mysql.tools;User Id=zi391919_gamma;Password=6+0i4rZtS_;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OcAddress>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PRIMARY");

            entity.ToTable("oc_address");

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

        modelBuilder.Entity<OcAddressSimpleField>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PRIMARY");

            entity.ToTable("oc_address_simple_fields");

            entity.Property(e => e.AddressId)
                .HasColumnType("int(11)")
                .HasColumnName("address_id");
            entity.Property(e => e.Metadata)
                .HasColumnType("text")
                .HasColumnName("metadata");
        });

        modelBuilder.Entity<OcAffiliate>(entity =>
        {
            entity.HasKey(e => e.AffiliateId).HasName("PRIMARY");

            entity.ToTable("oc_affiliate");

            entity.Property(e => e.AffiliateId)
                .HasColumnType("int(11)")
                .HasColumnName("affiliate_id");
            entity.Property(e => e.Address1)
                .HasMaxLength(128)
                .HasColumnName("address_1");
            entity.Property(e => e.Address2)
                .HasMaxLength(128)
                .HasColumnName("address_2");
            entity.Property(e => e.Approved).HasColumnName("approved");
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
            entity.Property(e => e.City)
                .HasMaxLength(128)
                .HasColumnName("city");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasColumnName("code");
            entity.Property(e => e.Commission)
                .HasPrecision(4)
                .HasColumnName("commission");
            entity.Property(e => e.Company)
                .HasMaxLength(40)
                .HasColumnName("company");
            entity.Property(e => e.CountryId)
                .HasColumnType("int(11)")
                .HasColumnName("country_id");
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
            entity.Property(e => e.Lastname)
                .HasMaxLength(32)
                .HasColumnName("lastname");
            entity.Property(e => e.Password)
                .HasMaxLength(40)
                .HasColumnName("password");
            entity.Property(e => e.Payment)
                .HasMaxLength(6)
                .HasColumnName("payment");
            entity.Property(e => e.Paypal)
                .HasMaxLength(64)
                .HasColumnName("paypal");
            entity.Property(e => e.Postcode)
                .HasMaxLength(10)
                .HasColumnName("postcode");
            entity.Property(e => e.Salt)
                .HasMaxLength(9)
                .HasColumnName("salt");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Tax)
                .HasMaxLength(64)
                .HasColumnName("tax");
            entity.Property(e => e.Telephone)
                .HasMaxLength(32)
                .HasColumnName("telephone");
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .HasColumnName("website");
            entity.Property(e => e.ZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("zone_id");
        });

        modelBuilder.Entity<OcAffiliateActivity>(entity =>
        {
            entity.HasKey(e => e.AffiliateActivityId).HasName("PRIMARY");

            entity.ToTable("oc_affiliate_activity");

            entity.Property(e => e.AffiliateActivityId)
                .HasColumnType("int(11)")
                .HasColumnName("affiliate_activity_id");
            entity.Property(e => e.AffiliateId)
                .HasColumnType("int(11)")
                .HasColumnName("affiliate_id");
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

        modelBuilder.Entity<OcAffiliateLogin>(entity =>
        {
            entity.HasKey(e => e.AffiliateLoginId).HasName("PRIMARY");

            entity.ToTable("oc_affiliate_login");

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.Ip, "ip");

            entity.Property(e => e.AffiliateLoginId)
                .HasColumnType("int(11)")
                .HasColumnName("affiliate_login_id");
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

        modelBuilder.Entity<OcAffiliateTransaction>(entity =>
        {
            entity.HasKey(e => e.AffiliateTransactionId).HasName("PRIMARY");

            entity.ToTable("oc_affiliate_transaction");

            entity.Property(e => e.AffiliateTransactionId)
                .HasColumnType("int(11)")
                .HasColumnName("affiliate_transaction_id");
            entity.Property(e => e.AffiliateId)
                .HasColumnType("int(11)")
                .HasColumnName("affiliate_id");
            entity.Property(e => e.Amount)
                .HasPrecision(15, 4)
                .HasColumnName("amount");
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

        modelBuilder.Entity<OcAgooSigner>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oc_agoo_signer");

            entity.HasIndex(e => e.CustomerId, "customer_id");

            entity.HasIndex(e => e.Date, "date");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.Pointer, "pointer");

            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Pointer)
                .HasMaxLength(128)
                .HasColumnName("pointer");
        });

        modelBuilder.Entity<OcApi>(entity =>
        {
            entity.HasKey(e => e.ApiId).HasName("PRIMARY");

            entity.ToTable("oc_api");

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
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<OcApiIp>(entity =>
        {
            entity.HasKey(e => e.ApiIpId).HasName("PRIMARY");

            entity.ToTable("oc_api_ip");

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

        modelBuilder.Entity<OcApiSession>(entity =>
        {
            entity.HasKey(e => e.ApiSessionId).HasName("PRIMARY");

            entity.ToTable("oc_api_session");

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
            entity.Property(e => e.SessionName)
                .HasMaxLength(32)
                .HasColumnName("session_name");
            entity.Property(e => e.Token)
                .HasMaxLength(32)
                .HasColumnName("token");
        });

        modelBuilder.Entity<OcAttributableToAttribute>(entity =>
        {
            entity.HasKey(e => new { e.AttributableId, e.AttributableType, e.AttributeId }).HasName("PRIMARY");

            entity.ToTable("oc_attributable_to_attribute");

            entity.Property(e => e.AttributableId)
                .HasColumnType("int(11)")
                .HasColumnName("attributable_id");
            entity.Property(e => e.AttributableType).HasColumnName("attributable_type");
            entity.Property(e => e.AttributeId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_id");
        });

        modelBuilder.Entity<OcAttribute>(entity =>
        {
            entity.HasKey(e => e.AttributeId).HasName("PRIMARY");

            entity.ToTable("oc_attribute");

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

        modelBuilder.Entity<OcAttributeDescription>(entity =>
        {
            entity.HasKey(e => new { e.AttributeId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_attribute_description");

            entity.Property(e => e.AttributeId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OcAttributeEnum>(entity =>
        {
            entity.HasKey(e => e.EnumId).HasName("PRIMARY");

            entity.ToTable("oc_attribute_enum");

            entity.Property(e => e.EnumId)
                .HasColumnType("int(11)")
                .HasColumnName("enum_id");
        });

        modelBuilder.Entity<OcAttributeEnumDescription>(entity =>
        {
            entity.HasKey(e => new { e.EnumId, e.EnumerationId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_attribute_enum_description");

            entity.Property(e => e.EnumId)
                .HasColumnType("int(11)")
                .HasColumnName("enum_id");
            entity.Property(e => e.EnumerationId)
                .HasColumnType("int(11)")
                .HasColumnName("enumeration_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
        });

        modelBuilder.Entity<OcAttributeEnumeration>(entity =>
        {
            entity.HasKey(e => e.EnumerationId).HasName("PRIMARY");

            entity.ToTable("oc_attribute_enumeration");

            entity.Property(e => e.EnumerationId)
                .HasColumnType("int(11)")
                .HasColumnName("enumeration_id");
        });

        modelBuilder.Entity<OcAttributeEnumerationDescription>(entity =>
        {
            entity.HasKey(e => new { e.EnumerationId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_attribute_enumeration_description");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.EnumerationId)
                .HasColumnType("int(11)")
                .HasColumnName("enumeration_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<OcAttributeGroup>(entity =>
        {
            entity.HasKey(e => e.AttributeGroupId).HasName("PRIMARY");

            entity.ToTable("oc_attribute_group");

            entity.Property(e => e.AttributeGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_group_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<OcAttributeGroupDescription>(entity =>
        {
            entity.HasKey(e => new { e.AttributeGroupId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_attribute_group_description");

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

        modelBuilder.Entity<OcAttributeTemplate>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("oc_attribute_template");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(11)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<OcAttributeTemplateAttribute>(entity =>
        {
            entity.HasKey(e => new { e.TemplateId, e.AttributeId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_attribute_template_attribute");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
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

        modelBuilder.Entity<OcAttributeTemplateDescription>(entity =>
        {
            entity.HasKey(e => new { e.TemplateId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_attribute_template_description");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<OcAttributeTemplateToAttributeToAttributable>(entity =>
        {
            entity.HasKey(e => new { e.AttributeTemplateId, e.AttributeId, e.AttributableId, e.AttributableType }).HasName("PRIMARY");

            entity.ToTable("oc_attribute_template_to_attribute_to_attributable");

            entity.Property(e => e.AttributeTemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_template_id");
            entity.Property(e => e.AttributeId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_id");
            entity.Property(e => e.AttributableId)
                .HasColumnType("int(11)")
                .HasColumnName("attributable_id");
            entity.Property(e => e.AttributableType).HasColumnName("attributable_type");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(11)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<OcAttributeUnit>(entity =>
        {
            entity.HasKey(e => e.AttributeUnitId).HasName("PRIMARY");

            entity.ToTable("oc_attribute_unit");

            entity.Property(e => e.AttributeUnitId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_unit_id");
        });

        modelBuilder.Entity<OcAttributeUnitDescription>(entity =>
        {
            entity.HasKey(e => new { e.AttributeUnitId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_attribute_unit_description");

            entity.Property(e => e.AttributeUnitId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_unit_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcBanner>(entity =>
        {
            entity.HasKey(e => e.BannerId).HasName("PRIMARY");

            entity.ToTable("oc_banner");

            entity.Property(e => e.BannerId)
                .HasColumnType("int(11)")
                .HasColumnName("banner_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<OcBannerImage>(entity =>
        {
            entity.HasKey(e => e.BannerImageId).HasName("PRIMARY");

            entity.ToTable("oc_banner_image");

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

        modelBuilder.Entity<OcCart>(entity =>
        {
            entity.HasKey(e => e.CartId).HasName("PRIMARY");

            entity.ToTable("oc_cart");

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
            entity.Property(e => e.Price)
                .HasPrecision(15, 4)
                .HasColumnName("price");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductRow)
                .HasMaxLength(5)
                .HasColumnName("product_row");
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

        modelBuilder.Entity<OcCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PRIMARY");

            entity.ToTable("oc_category");

            entity.HasIndex(e => e.NixSupplierCategoryId, "nix_supplier_category_id");

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
            entity.Property(e => e.NixSupplierCategoryId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("nix_supplier_category_id");
            entity.Property(e => e.NixSupplierId)
                .HasColumnType("int(3) unsigned")
                .HasColumnName("nix_supplier_id");
            entity.Property(e => e.ParentId)
                .HasColumnType("int(11)")
                .HasColumnName("parent_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Top).HasColumnName("top");
        });

        modelBuilder.Entity<OcCategoryDescription>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_category_description");

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

        modelBuilder.Entity<OcCategoryFilter>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.FilterId }).HasName("PRIMARY");

            entity.ToTable("oc_category_filter");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.FilterId)
                .HasColumnType("int(11)")
                .HasColumnName("filter_id");
        });

        modelBuilder.Entity<OcCategoryPath>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.PathId }).HasName("PRIMARY");

            entity.ToTable("oc_category_path");

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

        modelBuilder.Entity<OcCategoryToLayout>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("oc_category_to_layout");

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

        modelBuilder.Entity<OcCategoryToPromCategory>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.PromCategoryId }).HasName("PRIMARY");

            entity.ToTable("oc_category_to_prom_category");

            entity.HasIndex(e => e.PromCategoryId, "prom_category_id");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.PromCategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("prom_category_id");
        });

        modelBuilder.Entity<OcCategoryToStore>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("oc_category_to_store");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<OcContactsCacheEmail>(entity =>
        {
            entity.HasKey(e => e.EmailId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_cache_email");

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.SendId, "send_id");

            entity.Property(e => e.EmailId)
                .HasColumnType("int(11)")
                .HasColumnName("email_id");
            entity.Property(e => e.Country)
                .HasMaxLength(32)
                .HasColumnName("country");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(64)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(32)
                .HasColumnName("lastname");
            entity.Property(e => e.SendId)
                .HasColumnType("int(11)")
                .HasColumnName("send_id");
            entity.Property(e => e.Zone)
                .HasMaxLength(32)
                .HasColumnName("zone");
        });

        modelBuilder.Entity<OcContactsCacheProduct>(entity =>
        {
            entity.HasKey(e => e.ProductCacheId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_cache_product");

            entity.HasIndex(e => e.CronId, "cron_id");

            entity.HasIndex(e => e.SendId, "send_id");

            entity.Property(e => e.ProductCacheId)
                .HasColumnType("int(11)")
                .HasColumnName("product_cache_id");
            entity.Property(e => e.CatEach).HasColumnName("cat_each");
            entity.Property(e => e.CatId)
                .HasColumnType("text")
                .HasColumnName("cat_id");
            entity.Property(e => e.CronId)
                .HasColumnType("int(11)")
                .HasColumnName("cron_id");
            entity.Property(e => e.ProdId)
                .HasColumnType("text")
                .HasColumnName("prod_id");
            entity.Property(e => e.Qty)
                .HasColumnType("int(11)")
                .HasColumnName("qty");
            entity.Property(e => e.SendId)
                .HasColumnType("int(11)")
                .HasColumnName("send_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(32)
                .HasColumnName("type");
        });

        modelBuilder.Entity<OcContactsCacheSend>(entity =>
        {
            entity.HasKey(e => e.SendId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_cache_send");

            entity.Property(e => e.SendId)
                .HasColumnType("int(11)")
                .HasColumnName("send_id");
            entity.Property(e => e.Attachments)
                .HasColumnType("text")
                .HasColumnName("attachments");
            entity.Property(e => e.AttachmentsCat)
                .HasColumnType("text")
                .HasColumnName("attachments_cat");
            entity.Property(e => e.ControlUnsub).HasColumnName("control_unsub");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Dopurl)
                .HasColumnType("text")
                .HasColumnName("dopurl");
            entity.Property(e => e.EmailTotal)
                .HasColumnType("int(11)")
                .HasColumnName("email_total");
            entity.Property(e => e.Errors)
                .HasColumnType("int(11)")
                .HasColumnName("errors");
            entity.Property(e => e.InversAffiliate).HasColumnName("invers_affiliate");
            entity.Property(e => e.InversCategory).HasColumnName("invers_category");
            entity.Property(e => e.InversClient).HasColumnName("invers_client");
            entity.Property(e => e.InversCustomer).HasColumnName("invers_customer");
            entity.Property(e => e.InversProduct).HasColumnName("invers_product");
            entity.Property(e => e.InversRegion).HasColumnName("invers_region");
            entity.Property(e => e.LangProducts)
                .HasColumnType("int(11)")
                .HasColumnName("lang_products");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Newmessage).HasColumnName("newmessage");
            entity.Property(e => e.Reqreview).HasColumnName("reqreview");
            entity.Property(e => e.SendCountryId)
                .HasColumnType("int(11)")
                .HasColumnName("send_country_id");
            entity.Property(e => e.SendProducts).HasColumnName("send_products");
            entity.Property(e => e.SendRegion).HasColumnName("send_region");
            entity.Property(e => e.SendTo)
                .HasMaxLength(32)
                .HasColumnName("send_to");
            entity.Property(e => e.SendToData)
                .HasColumnType("text")
                .HasColumnName("send_to_data");
            entity.Property(e => e.SendType)
                .HasColumnType("int(11)")
                .HasColumnName("send_type");
            entity.Property(e => e.SendZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("send_zone_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.Subject)
                .HasColumnType("text")
                .HasColumnName("subject");
            entity.Property(e => e.UnsubUrl).HasColumnName("unsub_url");
        });

        modelBuilder.Entity<OcContactsClick>(entity =>
        {
            entity.HasKey(e => e.ClickId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_clicks");

            entity.HasIndex(e => e.SendId, "send_id");

            entity.Property(e => e.ClickId)
                .HasColumnType("int(11)")
                .HasColumnName("click_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.SendId)
                .HasColumnType("int(11)")
                .HasColumnName("send_id");
            entity.Property(e => e.Target)
                .HasColumnType("text")
                .HasColumnName("target");
        });

        modelBuilder.Entity<OcContactsCountMail>(entity =>
        {
            entity.HasKey(e => e.CountId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_count_mails");

            entity.HasIndex(e => e.DateSend, "date_send");

            entity.Property(e => e.CountId)
                .HasColumnType("int(11)")
                .HasColumnName("count_id");
            entity.Property(e => e.CronId)
                .HasColumnType("int(11)")
                .HasColumnName("cron_id");
            entity.Property(e => e.DateSend)
                .HasColumnType("int(11)")
                .HasColumnName("date_send");
            entity.Property(e => e.Items)
                .HasColumnType("int(11)")
                .HasColumnName("items");
            entity.Property(e => e.SendId)
                .HasColumnType("int(11)")
                .HasColumnName("send_id");
        });

        modelBuilder.Entity<OcContactsCron>(entity =>
        {
            entity.HasKey(e => e.CronId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_cron");

            entity.Property(e => e.CronId)
                .HasColumnType("int(11)")
                .HasColumnName("cron_id");
            entity.Property(e => e.Checking).HasColumnName("checking");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateNext)
                .HasColumnType("datetime")
                .HasColumnName("date_next");
            entity.Property(e => e.DateStart)
                .HasColumnType("datetime")
                .HasColumnName("date_start");
            entity.Property(e => e.Errors)
                .HasColumnType("int(11)")
                .HasColumnName("errors");
            entity.Property(e => e.HistoryId)
                .HasColumnType("int(11)")
                .HasColumnName("history_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Period)
                .HasColumnType("int(11)")
                .HasColumnName("period");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Step)
                .HasColumnType("int(11)")
                .HasColumnName("step");
        });

        modelBuilder.Entity<OcContactsCronDatum>(entity =>
        {
            entity.HasKey(e => e.CronDataId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_cron_data");

            entity.HasIndex(e => e.CronId, "cron_id");

            entity.Property(e => e.CronDataId)
                .HasColumnType("int(11)")
                .HasColumnName("cron_data_id");
            entity.Property(e => e.Attachments)
                .HasColumnType("text")
                .HasColumnName("attachments");
            entity.Property(e => e.AttachmentsCat)
                .HasColumnType("text")
                .HasColumnName("attachments_cat");
            entity.Property(e => e.ControlUnsub).HasColumnName("control_unsub");
            entity.Property(e => e.CronId)
                .HasColumnType("int(11)")
                .HasColumnName("cron_id");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
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
            entity.Property(e => e.Dopurl)
                .HasColumnType("text")
                .HasColumnName("dopurl");
            entity.Property(e => e.EmailTotal)
                .HasColumnType("int(11)")
                .HasColumnName("email_total");
            entity.Property(e => e.EmbadAction).HasColumnName("embad_action");
            entity.Property(e => e.EmnovalidAction).HasColumnName("emnovalid_action");
            entity.Property(e => e.EmsuspectAction).HasColumnName("emsuspect_action");
            entity.Property(e => e.InversAffiliate).HasColumnName("invers_affiliate");
            entity.Property(e => e.InversCategory).HasColumnName("invers_category");
            entity.Property(e => e.InversClient).HasColumnName("invers_client");
            entity.Property(e => e.InversCustomer).HasColumnName("invers_customer");
            entity.Property(e => e.InversProduct).HasColumnName("invers_product");
            entity.Property(e => e.InversRegion).HasColumnName("invers_region");
            entity.Property(e => e.LangProducts)
                .HasColumnType("int(11)")
                .HasColumnName("lang_products");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.LimitEnd)
                .HasColumnType("int(11)")
                .HasColumnName("limit_end");
            entity.Property(e => e.LimitStart)
                .HasColumnType("int(11)")
                .HasColumnName("limit_start");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Reqreview).HasColumnName("reqreview");
            entity.Property(e => e.SendCountryId)
                .HasColumnType("int(11)")
                .HasColumnName("send_country_id");
            entity.Property(e => e.SendProducts).HasColumnName("send_products");
            entity.Property(e => e.SendRegion).HasColumnName("send_region");
            entity.Property(e => e.SendTo)
                .HasMaxLength(32)
                .HasColumnName("send_to");
            entity.Property(e => e.SendToData)
                .HasColumnType("text")
                .HasColumnName("send_to_data");
            entity.Property(e => e.SendZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("send_zone_id");
            entity.Property(e => e.Static)
                .HasMaxLength(32)
                .HasColumnName("static");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.Subject)
                .HasColumnType("text")
                .HasColumnName("subject");
            entity.Property(e => e.UnsubUrl).HasColumnName("unsub_url");
        });

        modelBuilder.Entity<OcContactsCronEmail>(entity =>
        {
            entity.HasKey(e => e.CemailId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_cron_emails");

            entity.HasIndex(e => e.CheckStatus, "check_status");

            entity.HasIndex(e => e.CronId, "cron_id");

            entity.HasIndex(e => e.Email, "email");

            entity.Property(e => e.CemailId)
                .HasColumnType("int(11)")
                .HasColumnName("cemail_id");
            entity.Property(e => e.CheckStatus).HasColumnName("check_status");
            entity.Property(e => e.CheckText)
                .HasColumnType("text")
                .HasColumnName("check_text");
            entity.Property(e => e.Country)
                .HasMaxLength(32)
                .HasColumnName("country");
            entity.Property(e => e.CronId)
                .HasColumnType("int(11)")
                .HasColumnName("cron_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(64)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(32)
                .HasColumnName("lastname");
            entity.Property(e => e.Zone)
                .HasMaxLength(32)
                .HasColumnName("zone");
        });

        modelBuilder.Entity<OcContactsCronHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_cron_history");

            entity.Property(e => e.HistoryId)
                .HasColumnType("int(11)")
                .HasColumnName("history_id");
            entity.Property(e => e.CountEmails)
                .HasColumnType("int(11)")
                .HasColumnName("count_emails");
            entity.Property(e => e.CronId)
                .HasColumnType("int(11)")
                .HasColumnName("cron_id");
            entity.Property(e => e.CronStatus).HasColumnName("cron_status");
            entity.Property(e => e.DateCronrun)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_cronrun");
            entity.Property(e => e.DateCronstop)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_cronstop");
            entity.Property(e => e.LogFile)
                .HasMaxLength(255)
                .HasColumnName("log_file");
            entity.Property(e => e.SendId)
                .HasColumnType("int(11)")
                .HasColumnName("send_id");
            entity.Property(e => e.TextError)
                .HasMaxLength(255)
                .HasColumnName("text_error");
        });

        modelBuilder.Entity<OcContactsGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_group");

            entity.Property(e => e.GroupId)
                .HasColumnType("int(11)")
                .HasColumnName("group_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OcContactsNewsletter>(entity =>
        {
            entity.HasKey(e => e.NewsletterId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_newsletter");

            entity.HasIndex(e => e.CustomerId, "customer_id");

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.Property(e => e.NewsletterId)
                .HasColumnType("int(11)")
                .HasColumnName("newsletter_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(64)
                .HasColumnName("firstname");
            entity.Property(e => e.GroupId)
                .HasColumnType("int(11)")
                .HasColumnName("group_id");
            entity.Property(e => e.Lastname)
                .HasMaxLength(32)
                .HasColumnName("lastname");
            entity.Property(e => e.UnsubscribeId)
                .HasColumnType("int(11)")
                .HasColumnName("unsubscribe_id");
        });

        modelBuilder.Entity<OcContactsReqreviewMail>(entity =>
        {
            entity.HasKey(e => e.RevmailId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_reqreview_mails");

            entity.HasIndex(e => e.Email, "email");

            entity.Property(e => e.RevmailId)
                .HasColumnType("int(11)")
                .HasColumnName("revmail_id");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
        });

        modelBuilder.Entity<OcContactsReqreviewProduct>(entity =>
        {
            entity.HasKey(e => e.ReqreviewProductId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_reqreview_product");

            entity.HasIndex(e => e.RevmailId, "revmail_id");

            entity.Property(e => e.ReqreviewProductId)
                .HasColumnType("int(11)")
                .HasColumnName("reqreview_product_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.RevmailId)
                .HasColumnType("int(11)")
                .HasColumnName("revmail_id");
        });

        modelBuilder.Entity<OcContactsTemplate>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_template");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("template_id");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Subject)
                .HasColumnType("text")
                .HasColumnName("subject");
        });

        modelBuilder.Entity<OcContactsUnsubscribe>(entity =>
        {
            entity.HasKey(e => e.UnsubscribeId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_unsubscribe");

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.SendId, "send_id");

            entity.Property(e => e.UnsubscribeId)
                .HasColumnType("int(11)")
                .HasColumnName("unsubscribe_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.SendId)
                .HasColumnType("int(11)")
                .HasColumnName("send_id");
        });

        modelBuilder.Entity<OcContactsView>(entity =>
        {
            entity.HasKey(e => e.ViewId).HasName("PRIMARY");

            entity.ToTable("oc_contacts_views");

            entity.HasIndex(e => e.SendId, "send_id");

            entity.Property(e => e.ViewId)
                .HasColumnType("int(11)")
                .HasColumnName("view_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Email)
                .HasMaxLength(96)
                .HasColumnName("email");
            entity.Property(e => e.SendId)
                .HasColumnType("int(11)")
                .HasColumnName("send_id");
        });

        modelBuilder.Entity<OcCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PRIMARY");

            entity.ToTable("oc_country");

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

        modelBuilder.Entity<OcCoupon>(entity =>
        {
            entity.HasKey(e => e.CouponId).HasName("PRIMARY");

            entity.ToTable("oc_coupon");

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

        modelBuilder.Entity<OcCouponCategory>(entity =>
        {
            entity.HasKey(e => new { e.CouponId, e.CategoryId }).HasName("PRIMARY");

            entity.ToTable("oc_coupon_category");

            entity.Property(e => e.CouponId)
                .HasColumnType("int(11)")
                .HasColumnName("coupon_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
        });

        modelBuilder.Entity<OcCouponHistory>(entity =>
        {
            entity.HasKey(e => e.CouponHistoryId).HasName("PRIMARY");

            entity.ToTable("oc_coupon_history");

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

        modelBuilder.Entity<OcCouponProduct>(entity =>
        {
            entity.HasKey(e => e.CouponProductId).HasName("PRIMARY");

            entity.ToTable("oc_coupon_product");

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

        modelBuilder.Entity<OcCurrency>(entity =>
        {
            entity.HasKey(e => e.CurrencyId).HasName("PRIMARY");

            entity.ToTable("oc_currency");

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
                .HasColumnType("float(15,8)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcCustomField>(entity =>
        {
            entity.HasKey(e => e.CustomFieldId).HasName("PRIMARY");

            entity.ToTable("oc_custom_field");

            entity.Property(e => e.CustomFieldId)
                .HasColumnType("int(11)")
                .HasColumnName("custom_field_id");
            entity.Property(e => e.Location)
                .HasMaxLength(7)
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

        modelBuilder.Entity<OcCustomFieldCustomerGroup>(entity =>
        {
            entity.HasKey(e => new { e.CustomFieldId, e.CustomerGroupId }).HasName("PRIMARY");

            entity.ToTable("oc_custom_field_customer_group");

            entity.Property(e => e.CustomFieldId)
                .HasColumnType("int(11)")
                .HasColumnName("custom_field_id");
            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
            entity.Property(e => e.Required).HasColumnName("required");
        });

        modelBuilder.Entity<OcCustomFieldDescription>(entity =>
        {
            entity.HasKey(e => new { e.CustomFieldId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_custom_field_description");

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

        modelBuilder.Entity<OcCustomFieldValue>(entity =>
        {
            entity.HasKey(e => e.CustomFieldValueId).HasName("PRIMARY");

            entity.ToTable("oc_custom_field_value");

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

        modelBuilder.Entity<OcCustomFieldValueDescription>(entity =>
        {
            entity.HasKey(e => new { e.CustomFieldValueId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_custom_field_value_description");

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

        modelBuilder.Entity<OcCustomMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PRIMARY");

            entity.ToTable("oc_custom_menu");

            entity.Property(e => e.MenuId)
                .HasColumnType("int(11)")
                .HasColumnName("menu_id");
            entity.Property(e => e.Column)
                .HasColumnType("int(11)")
                .HasColumnName("column");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
            entity.Property(e => e.ParentId)
                .HasColumnType("int(11)")
                .HasColumnName("parent_id");
            entity.Property(e => e.ParentParentId)
                .HasColumnType("int(11)")
                .HasColumnName("parent_parent_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(11)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status)
                .HasColumnType("int(11)")
                .HasColumnName("status");
        });

        modelBuilder.Entity<OcCustomMenuDescription>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oc_custom_menu_description");

            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.MenuId)
                .HasColumnType("int(11)")
                .HasColumnName("menu_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OcCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PRIMARY");

            entity.ToTable("oc_customer");

            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.AddressId)
                .HasColumnType("int(11)")
                .HasColumnName("address_id");
            entity.Property(e => e.Approved).HasColumnName("approved");
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

        modelBuilder.Entity<OcCustomerActivity>(entity =>
        {
            entity.HasKey(e => e.CustomerActivityId).HasName("PRIMARY");

            entity.ToTable("oc_customer_activity");

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

        modelBuilder.Entity<OcCustomerGroup>(entity =>
        {
            entity.HasKey(e => e.CustomerGroupId).HasName("PRIMARY");

            entity.ToTable("oc_customer_group");

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

        modelBuilder.Entity<OcCustomerGroupDescription>(entity =>
        {
            entity.HasKey(e => new { e.CustomerGroupId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_customer_group_description");

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

        modelBuilder.Entity<OcCustomerHistory>(entity =>
        {
            entity.HasKey(e => e.CustomerHistoryId).HasName("PRIMARY");

            entity.ToTable("oc_customer_history");

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

        modelBuilder.Entity<OcCustomerIp>(entity =>
        {
            entity.HasKey(e => e.CustomerIpId).HasName("PRIMARY");

            entity.ToTable("oc_customer_ip");

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

        modelBuilder.Entity<OcCustomerLogin>(entity =>
        {
            entity.HasKey(e => e.CustomerLoginId).HasName("PRIMARY");

            entity.ToTable("oc_customer_login");

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

        modelBuilder.Entity<OcCustomerOnline>(entity =>
        {
            entity.HasKey(e => e.Ip).HasName("PRIMARY");

            entity.ToTable("oc_customer_online");

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

        modelBuilder.Entity<OcCustomerReward>(entity =>
        {
            entity.HasKey(e => e.CustomerRewardId).HasName("PRIMARY");

            entity.ToTable("oc_customer_reward");

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

        modelBuilder.Entity<OcCustomerSearch>(entity =>
        {
            entity.HasKey(e => e.CustomerSearchId).HasName("PRIMARY");

            entity.ToTable("oc_customer_search");

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

        modelBuilder.Entity<OcCustomerSimpleField>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PRIMARY");

            entity.ToTable("oc_customer_simple_fields");

            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.Metadata)
                .HasColumnType("text")
                .HasColumnName("metadata");
        });

        modelBuilder.Entity<OcCustomerTransaction>(entity =>
        {
            entity.HasKey(e => e.CustomerTransactionId).HasName("PRIMARY");

            entity.ToTable("oc_customer_transaction");

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

        modelBuilder.Entity<OcCustomerWishlist>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.ProductId }).HasName("PRIMARY");

            entity.ToTable("oc_customer_wishlist");

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

        modelBuilder.Entity<OcDownload>(entity =>
        {
            entity.HasKey(e => e.DownloadId).HasName("PRIMARY");

            entity.ToTable("oc_download");

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

        modelBuilder.Entity<OcDownloadDescription>(entity =>
        {
            entity.HasKey(e => new { e.DownloadId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_download_description");

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

        modelBuilder.Entity<OcEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PRIMARY");

            entity.ToTable("oc_event");

            entity.Property(e => e.EventId)
                .HasColumnType("int(11)")
                .HasColumnName("event_id");
            entity.Property(e => e.Action)
                .HasColumnType("text")
                .HasColumnName("action");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Trigger)
                .HasColumnType("text")
                .HasColumnName("trigger");
        });

        modelBuilder.Entity<OcExtension>(entity =>
        {
            entity.HasKey(e => e.ExtensionId).HasName("PRIMARY");

            entity.ToTable("oc_extension");

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

        modelBuilder.Entity<OcFilter>(entity =>
        {
            entity.HasKey(e => e.FilterId).HasName("PRIMARY");

            entity.ToTable("oc_filter");

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

        modelBuilder.Entity<OcFilterDescription>(entity =>
        {
            entity.HasKey(e => new { e.FilterId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_filter_description");

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

        modelBuilder.Entity<OcFilterGroup>(entity =>
        {
            entity.HasKey(e => e.FilterGroupId).HasName("PRIMARY");

            entity.ToTable("oc_filter_group");

            entity.Property(e => e.FilterGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("filter_group_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<OcFilterGroupDescription>(entity =>
        {
            entity.HasKey(e => new { e.FilterGroupId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_filter_group_description");

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

        modelBuilder.Entity<OcGeoZone>(entity =>
        {
            entity.HasKey(e => e.GeoZoneId).HasName("PRIMARY");

            entity.ToTable("oc_geo_zone");

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

        modelBuilder.Entity<OcInformation>(entity =>
        {
            entity.HasKey(e => e.InformationId).HasName("PRIMARY");

            entity.ToTable("oc_information");

            entity.Property(e => e.InformationId)
                .HasColumnType("int(11)")
                .HasColumnName("information_id");
            entity.Property(e => e.Bottom)
                .HasColumnType("int(1)")
                .HasColumnName("bottom");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<OcInformationDescription>(entity =>
        {
            entity.HasKey(e => new { e.InformationId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_information_description");

            entity.Property(e => e.InformationId)
                .HasColumnType("int(11)")
                .HasColumnName("information_id");
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
            entity.Property(e => e.Title)
                .HasMaxLength(64)
                .HasColumnName("title");
        });

        modelBuilder.Entity<OcInformationToLayout>(entity =>
        {
            entity.HasKey(e => new { e.InformationId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("oc_information_to_layout");

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

        modelBuilder.Entity<OcInformationToStore>(entity =>
        {
            entity.HasKey(e => new { e.InformationId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("oc_information_to_store");

            entity.Property(e => e.InformationId)
                .HasColumnType("int(11)")
                .HasColumnName("information_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<OcKdWarehouseCode>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("oc_kd_warehouse_code");

            entity.HasIndex(e => e.KdCode, "kd_code");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.KdCode)
                .HasMaxLength(64)
                .HasColumnName("kd_code");
        });

        modelBuilder.Entity<OcKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("oc_key");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.LicenseKey)
                .HasColumnType("text")
                .HasColumnName("license_key");
            entity.Property(e => e.MainKey)
                .HasMaxLength(256)
                .HasColumnName("main_key");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcLanguage>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PRIMARY");

            entity.ToTable("oc_language");

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

        modelBuilder.Entity<OcLayout>(entity =>
        {
            entity.HasKey(e => e.LayoutId).HasName("PRIMARY");

            entity.ToTable("oc_layout");

            entity.Property(e => e.LayoutId)
                .HasColumnType("int(11)")
                .HasColumnName("layout_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OcLayoutModule>(entity =>
        {
            entity.HasKey(e => e.LayoutModuleId).HasName("PRIMARY");

            entity.ToTable("oc_layout_module");

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

        modelBuilder.Entity<OcLayoutRoute>(entity =>
        {
            entity.HasKey(e => e.LayoutRouteId).HasName("PRIMARY");

            entity.ToTable("oc_layout_route");

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

        modelBuilder.Entity<OcLengthClass>(entity =>
        {
            entity.HasKey(e => e.LengthClassId).HasName("PRIMARY");

            entity.ToTable("oc_length_class");

            entity.Property(e => e.LengthClassId)
                .HasColumnType("int(11)")
                .HasColumnName("length_class_id");
            entity.Property(e => e.Value)
                .HasPrecision(15)
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcLengthClassDescription>(entity =>
        {
            entity.HasKey(e => new { e.LengthClassId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_length_class_description");

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

        modelBuilder.Entity<OcLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PRIMARY");

            entity.ToTable("oc_location");

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

        modelBuilder.Entity<OcLostedCart>(entity =>
        {
            entity.HasKey(e => e.LostedId).HasName("PRIMARY");

            entity.ToTable("oc_losted_cart");

            entity.HasIndex(e => e.SessionId, "session_id");

            entity.Property(e => e.LostedId)
                .HasColumnType("int(11)")
                .HasColumnName("losted_id");
            entity.Property(e => e.Coupon)
                .HasMaxLength(50)
                .HasColumnName("coupon");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .HasColumnName("currency_code");
            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateNotified)
                .HasColumnType("datetime")
                .HasColumnName("date_notified");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("firstname");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(2)")
                .HasColumnName("language_id");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("lastname");
            entity.Property(e => e.Notified).HasColumnName("notified");
            entity.Property(e => e.SessionId)
                .HasMaxLength(32)
                .HasColumnName("session_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(2)")
                .HasColumnName("store_id");
            entity.Property(e => e.Telephone)
                .HasMaxLength(255)
                .HasColumnName("telephone");
            entity.Property(e => e.Token)
                .HasMaxLength(64)
                .HasColumnName("token");
        });

        modelBuilder.Entity<OcLostedCartLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oc_losted_cart_log");

            entity.HasIndex(e => e.LostedId, "losted_id");

            entity.Property(e => e.DateSend)
                .HasColumnType("datetime")
                .HasColumnName("date_send");
            entity.Property(e => e.LostedId)
                .HasColumnType("int(11)")
                .HasColumnName("losted_id");
        });

        modelBuilder.Entity<OcManufacturer>(entity =>
        {
            entity.HasKey(e => e.ManufacturerId).HasName("PRIMARY");

            entity.ToTable("oc_manufacturer");

            entity.Property(e => e.ManufacturerId)
                .HasColumnType("int(11)")
                .HasColumnName("manufacturer_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<OcManufacturerDescription>(entity =>
        {
            entity.HasKey(e => new { e.ManufacturerId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_manufacturer_description");

            entity.Property(e => e.ManufacturerId)
                .HasColumnType("int(11)")
                .HasColumnName("manufacturer_id");
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
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OcManufacturerToStore>(entity =>
        {
            entity.HasKey(e => new { e.ManufacturerId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("oc_manufacturer_to_store");

            entity.Property(e => e.ManufacturerId)
                .HasColumnType("int(11)")
                .HasColumnName("manufacturer_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<OcMarketing>(entity =>
        {
            entity.HasKey(e => e.MarketingId).HasName("PRIMARY");

            entity.ToTable("oc_marketing");

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

        modelBuilder.Entity<OcMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PRIMARY");

            entity.ToTable("oc_menu");

            entity.Property(e => e.MenuId)
                .HasColumnType("int(11)")
                .HasColumnName("menu_id");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.Type)
                .HasMaxLength(6)
                .HasColumnName("type");
        });

        modelBuilder.Entity<OcMenuDescription>(entity =>
        {
            entity.HasKey(e => new { e.MenuId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_menu_description");

            entity.Property(e => e.MenuId)
                .HasColumnType("int(11)")
                .HasColumnName("menu_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OcMenuModule>(entity =>
        {
            entity.HasKey(e => e.MenuModuleId).HasName("PRIMARY");

            entity.ToTable("oc_menu_module");

            entity.HasIndex(e => e.MenuId, "menu_id");

            entity.Property(e => e.MenuModuleId)
                .HasColumnType("int(11)")
                .HasColumnName("menu_module_id");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasColumnName("code");
            entity.Property(e => e.MenuId)
                .HasColumnType("int(11)")
                .HasColumnName("menu_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(3)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<OcModification>(entity =>
        {
            entity.HasKey(e => e.ModificationId).HasName("PRIMARY");

            entity.ToTable("oc_modification");

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

        modelBuilder.Entity<OcModule>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PRIMARY");

            entity.ToTable("oc_module");

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

        modelBuilder.Entity<OcMultiXml>(entity =>
        {
            entity.HasKey(e => e.XmlId).HasName("PRIMARY");

            entity.ToTable("oc_multi_xml");

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

        modelBuilder.Entity<OcMultiplicityProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("oc_multiplicity_product");

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

        modelBuilder.Entity<OcNixSupplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PRIMARY");

            entity.ToTable("oc_nix_suppliers");

            entity.Property(e => e.SupplierId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("supplier_id");
            entity.Property(e => e.Attributes)
                .HasColumnType("mediumtext")
                .HasColumnName("attributes");
            entity.Property(e => e.LinkPrice)
                .HasColumnType("text")
                .HasColumnName("link_price");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.Tags)
                .HasColumnType("mediumtext")
                .HasColumnName("tags");
        });

        modelBuilder.Entity<OcNovaposhtaCity>(entity =>
        {
            entity.HasKey(e => e.Ref).HasName("PRIMARY");

            entity.ToTable("oc_novaposhta_cities");

            entity.HasIndex(e => e.Area, "Area");

            entity.HasIndex(e => e.CityId, "CityID");

            entity.HasIndex(e => e.SettlementType, "SettlementType");

            entity.Property(e => e.Ref).HasMaxLength(36);
            entity.Property(e => e.Area).HasMaxLength(36);
            entity.Property(e => e.CityId)
                .HasColumnType("int(11)")
                .HasColumnName("CityID");
            entity.Property(e => e.Conglomerates).HasColumnType("text");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.DescriptionRu).HasMaxLength(200);
            entity.Property(e => e.PreventEntryNewStreetsUser).HasColumnType("text");
            entity.Property(e => e.SettlementType).HasMaxLength(36);
            entity.Property(e => e.SettlementTypeDescription).HasMaxLength(200);
            entity.Property(e => e.SettlementTypeDescriptionRu).HasMaxLength(200);
        });

        modelBuilder.Entity<OcNovaposhtaReference>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oc_novaposhta_references");

            entity.HasIndex(e => e.Type, "type").IsUnique();

            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasColumnType("mediumtext")
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcNovaposhtaWarehouse>(entity =>
        {
            entity.HasKey(e => e.Ref).HasName("PRIMARY");

            entity.ToTable("oc_novaposhta_warehouses");

            entity.HasIndex(e => e.CityRef, "CityRef");

            entity.HasIndex(e => e.SiteKey, "SiteKey");

            entity.HasIndex(e => e.TypeOfWarehouse, "TypeOfWarehouse");

            entity.Property(e => e.Ref).HasMaxLength(36);
            entity.Property(e => e.CategoryOfWarehouse).HasMaxLength(20);
            entity.Property(e => e.CityDescription).HasMaxLength(200);
            entity.Property(e => e.CityDescriptionRu).HasMaxLength(200);
            entity.Property(e => e.CityRef).HasMaxLength(36);
            entity.Property(e => e.Delivery).HasColumnType("text");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DescriptionRu).HasMaxLength(500);
            entity.Property(e => e.DistrictCode).HasMaxLength(20);
            entity.Property(e => e.Number).HasColumnType("int(11)");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PlaceMaxWeightAllowed).HasColumnType("int(11)");
            entity.Property(e => e.Posterminal).HasColumnName("POSTerminal");
            entity.Property(e => e.Reception).HasColumnType("text");
            entity.Property(e => e.Schedule).HasColumnType("text");
            entity.Property(e => e.ShortAddress).HasMaxLength(500);
            entity.Property(e => e.ShortAddressRu).HasMaxLength(500);
            entity.Property(e => e.SiteKey).HasColumnType("int(11)");
            entity.Property(e => e.TotalMaxWeightAllowed).HasColumnType("int(11)");
            entity.Property(e => e.TypeOfWarehouse).HasMaxLength(36);
            entity.Property(e => e.WarehouseStatus).HasMaxLength(20);
        });

        modelBuilder.Entity<OcOcfilterHref>(entity =>
        {
            entity.HasKey(e => e.OcfHrefId).HasName("PRIMARY");

            entity.ToTable("oc_ocfilter_href");

            entity.Property(e => e.OcfHrefId)
                .HasColumnType("int(11)")
                .HasColumnName("ocf_href_id");
            entity.Property(e => e.Canonical)
                .HasMaxLength(255)
                .HasColumnName("canonical");
            entity.Property(e => e.Link)
                .HasColumnType("text")
                .HasColumnName("link");
            entity.Property(e => e.Robots)
                .HasMaxLength(255)
                .HasColumnName("robots");
        });

        modelBuilder.Entity<OcOcfilterOption>(entity =>
        {
            entity.HasKey(e => e.OptionId).HasName("PRIMARY");

            entity.ToTable("oc_ocfilter_option");

            entity.HasIndex(e => e.Keyword, "keyword");

            entity.HasIndex(e => e.SortOrder, "sort_order");

            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.Color).HasColumnName("color");
            entity.Property(e => e.Grouping)
                .HasColumnType("tinyint(2)")
                .HasColumnName("grouping");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Keyword)
                .HasDefaultValueSql("''")
                .HasColumnName("keyword");
            entity.Property(e => e.Selectbox).HasColumnName("selectbox");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(11)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(16)
                .HasDefaultValueSql("'checkbox'")
                .HasColumnName("type");
        });

        modelBuilder.Entity<OcOcfilterOptionDescription>(entity =>
        {
            entity.HasKey(e => new { e.OptionId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_ocfilter_option_description");

            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("tinyint(2)")
                .HasColumnName("language_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Postfix)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("postfix");
        });

        modelBuilder.Entity<OcOcfilterOptionToCategory>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.OptionId }).HasName("PRIMARY");

            entity.ToTable("oc_ocfilter_option_to_category");

            entity.HasIndex(e => e.CategoryId, "category_id");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
        });

        modelBuilder.Entity<OcOcfilterOptionToStore>(entity =>
        {
            entity.HasKey(e => new { e.StoreId, e.OptionId }).HasName("PRIMARY");

            entity.ToTable("oc_ocfilter_option_to_store");

            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
        });

        modelBuilder.Entity<OcOcfilterOptionValue>(entity =>
        {
            entity.HasKey(e => e.ValueId).HasName("PRIMARY");

            entity.ToTable("oc_ocfilter_option_value");

            entity.HasIndex(e => e.Keyword, "keyword");

            entity.HasIndex(e => e.OptionId, "option_id");

            entity.Property(e => e.ValueId)
                .HasColumnType("bigint(20)")
                .HasColumnName("value_id");
            entity.Property(e => e.Color)
                .HasMaxLength(6)
                .HasDefaultValueSql("''")
                .HasColumnName("color");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("image");
            entity.Property(e => e.Keyword)
                .HasDefaultValueSql("''")
                .HasColumnName("keyword");
            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(11)")
                .HasColumnName("sort_order");
        });

        modelBuilder.Entity<OcOcfilterOptionValueDescription>(entity =>
        {
            entity.HasKey(e => new { e.ValueId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_ocfilter_option_value_description");

            entity.HasIndex(e => e.Name, "name");

            entity.HasIndex(e => e.OptionId, "option_id");

            entity.Property(e => e.ValueId)
                .HasColumnType("bigint(20)")
                .HasColumnName("value_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("tinyint(2)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
        });

        modelBuilder.Entity<OcOcfilterOptionValueToProduct>(entity =>
        {
            entity.HasKey(e => e.OcfilterOptionValueToProductId).HasName("PRIMARY");

            entity.ToTable("oc_ocfilter_option_value_to_product");

            entity.HasIndex(e => new { e.OptionId, e.ValueId, e.ProductId }, "option_id_value_id_product_id").IsUnique();

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.HasIndex(e => new { e.SlideValueMin, e.SlideValueMax }, "slide_value_min_slide_value_max");

            entity.Property(e => e.OcfilterOptionValueToProductId)
                .HasColumnType("int(11)")
                .HasColumnName("ocfilter_option_value_to_product_id");
            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.SlideValueMax)
                .HasPrecision(15, 4)
                .HasColumnName("slide_value_max");
            entity.Property(e => e.SlideValueMin)
                .HasPrecision(15, 4)
                .HasColumnName("slide_value_min");
            entity.Property(e => e.ValueId)
                .HasColumnType("bigint(20)")
                .HasColumnName("value_id");
        });

        modelBuilder.Entity<OcOcfilterOptionValueToProductDescription>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.ValueId, e.OptionId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_ocfilter_option_value_to_product_description");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.ValueId)
                .HasColumnType("bigint(20)")
                .HasColumnName("value_id");
            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("tinyint(2)")
                .HasColumnName("language_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
        });

        modelBuilder.Entity<OcOcfilterPage>(entity =>
        {
            entity.HasKey(e => e.OcfilterPageId).HasName("PRIMARY");

            entity.ToTable("oc_ocfilter_page");

            entity.HasIndex(e => new { e.CategoryId, e.Params }, "category_id_params");

            entity.HasIndex(e => e.Keyword, "keyword");

            entity.Property(e => e.OcfilterPageId)
                .HasColumnType("int(11)")
                .HasColumnName("ocfilter_page_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.Keyword).HasColumnName("keyword");
            entity.Property(e => e.Over)
                .HasDefaultValueSql("'category'")
                .HasColumnType("set('domain','category')")
                .HasColumnName("over");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<OcOcfilterPageDescription>(entity =>
        {
            entity.HasKey(e => new { e.OcfilterPageId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_ocfilter_page_description");

            entity.Property(e => e.OcfilterPageId)
                .HasColumnType("int(11)")
                .HasColumnName("ocfilter_page_id");
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
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.Title)
                .HasMaxLength(128)
                .HasColumnName("title");
        });

        modelBuilder.Entity<OcOnOrder>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("oc_on_order");

            entity.HasIndex(e => e.OnOrderStatus, "on_order_status");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.OnOrderStatus).HasColumnName("on_order_status");
        });

        modelBuilder.Entity<OcOption>(entity =>
        {
            entity.HasKey(e => e.OptionId).HasName("PRIMARY");

            entity.ToTable("oc_option");

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

        modelBuilder.Entity<OcOptionDescription>(entity =>
        {
            entity.HasKey(e => new { e.OptionId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_option_description");

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

        modelBuilder.Entity<OcOptionValue>(entity =>
        {
            entity.HasKey(e => e.OptionValueId).HasName("PRIMARY");

            entity.ToTable("oc_option_value");

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

        modelBuilder.Entity<OcOptionValueDescription>(entity =>
        {
            entity.HasKey(e => new { e.OptionValueId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_option_value_description");

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

        modelBuilder.Entity<OcOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("oc_order");

            entity.HasIndex(e => e.CustomerId, "customer_id");

            entity.HasIndex(e => e.OrderStatusId, "order_status_id");

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
            entity.Property(e => e.MarketingId)
                .HasColumnType("int(11)")
                .HasColumnName("marketing_id");
            entity.Property(e => e.NovaposhtaCnNumber)
                .HasMaxLength(100)
                .HasColumnName("novaposhta_cn_number");
            entity.Property(e => e.NovaposhtaCnRef)
                .HasMaxLength(100)
                .HasColumnName("novaposhta_cn_ref");
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
            entity.Property(e => e.ShippingCountry)
                .HasMaxLength(128)
                .HasColumnName("shipping_country");
            entity.Property(e => e.ShippingCountryId)
                .HasColumnType("int(11)")
                .HasColumnName("shipping_country_id");
            entity.Property(e => e.ShippingCustomField)
                .HasColumnType("text")
                .HasColumnName("shipping_custom_field");
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

        modelBuilder.Entity<OcOrderCustomField>(entity =>
        {
            entity.HasKey(e => e.OrderCustomFieldId).HasName("PRIMARY");

            entity.ToTable("oc_order_custom_field");

            entity.Property(e => e.OrderCustomFieldId)
                .HasColumnType("int(11)")
                .HasColumnName("order_custom_field_id");
            entity.Property(e => e.CustomFieldId)
                .HasColumnType("int(11)")
                .HasColumnName("custom_field_id");
            entity.Property(e => e.CustomFieldValueId)
                .HasColumnType("int(11)")
                .HasColumnName("custom_field_value_id");
            entity.Property(e => e.Location)
                .HasMaxLength(16)
                .HasColumnName("location");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.Type)
                .HasMaxLength(32)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcOrderHistory>(entity =>
        {
            entity.HasKey(e => e.OrderHistoryId).HasName("PRIMARY");

            entity.ToTable("oc_order_history");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.Property(e => e.OrderHistoryId)
                .HasColumnType("int(11)")
                .HasColumnName("order_history_id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Notify).HasColumnName("notify");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.OrderStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("order_status_id");
        });

        modelBuilder.Entity<OcOrderOption>(entity =>
        {
            entity.HasKey(e => e.OrderOptionId).HasName("PRIMARY");

            entity.ToTable("oc_order_option");

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

        modelBuilder.Entity<OcOrderPermission>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.OrderId }).HasName("PRIMARY");

            entity.ToTable("oc_order_permissions");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
        });

        modelBuilder.Entity<OcOrderProduct>(entity =>
        {
            entity.HasKey(e => e.OrderProductId).HasName("PRIMARY");

            entity.ToTable("oc_order_product");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.OrderProductId)
                .HasColumnType("int(11)")
                .HasColumnName("order_product_id");
            entity.Property(e => e.DiscountAmount)
                .HasPrecision(15, 4)
                .HasColumnName("discount_amount");
            entity.Property(e => e.DiscountType)
                .HasMaxLength(1)
                .HasColumnName("discount_type");
            entity.Property(e => e.Ean)
                .HasMaxLength(64)
                .HasColumnName("ean");
            entity.Property(e => e.Isbn)
                .HasMaxLength(64)
                .HasColumnName("isbn");
            entity.Property(e => e.Jan)
                .HasMaxLength(64)
                .HasColumnName("jan");
            entity.Property(e => e.Location)
                .HasMaxLength(128)
                .HasColumnName("location");
            entity.Property(e => e.Model)
                .HasMaxLength(64)
                .HasColumnName("model");
            entity.Property(e => e.Mpn)
                .HasMaxLength(64)
                .HasColumnName("mpn");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.Price)
                .HasPrecision(15, 4)
                .HasColumnName("price");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(4)")
                .HasColumnName("quantity");
            entity.Property(e => e.Reward)
                .HasColumnType("int(8)")
                .HasColumnName("reward");
            entity.Property(e => e.Sku)
                .HasMaxLength(64)
                .HasColumnName("sku");
            entity.Property(e => e.Tax)
                .HasPrecision(15, 4)
                .HasColumnName("tax");
            entity.Property(e => e.Total)
                .HasPrecision(15, 4)
                .HasColumnName("total");
            entity.Property(e => e.Upc)
                .HasMaxLength(64)
                .HasColumnName("upc");
            entity.Property(e => e.Weight)
                .HasPrecision(15)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<OcOrderRecurring>(entity =>
        {
            entity.HasKey(e => e.OrderRecurringId).HasName("PRIMARY");

            entity.ToTable("oc_order_recurring");

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

        modelBuilder.Entity<OcOrderRecurringTransaction>(entity =>
        {
            entity.HasKey(e => e.OrderRecurringTransactionId).HasName("PRIMARY");

            entity.ToTable("oc_order_recurring_transaction");

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

        modelBuilder.Entity<OcOrderSimpleField>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("oc_order_simple_fields");

            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("order_id");
            entity.Property(e => e.Metadata)
                .HasColumnType("text")
                .HasColumnName("metadata");
        });

        modelBuilder.Entity<OcOrderStatus>(entity =>
        {
            entity.HasKey(e => new { e.OrderStatusId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_order_status");

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

        modelBuilder.Entity<OcOrderTotal>(entity =>
        {
            entity.HasKey(e => e.OrderTotalId).HasName("PRIMARY");

            entity.ToTable("oc_order_total");

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

        modelBuilder.Entity<OcOrderVoucher>(entity =>
        {
            entity.HasKey(e => e.OrderVoucherId).HasName("PRIMARY");

            entity.ToTable("oc_order_voucher");

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

        modelBuilder.Entity<OcProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("oc_product");

            entity.HasIndex(e => e.NixSupplierProductId, "nix_supplier_product_id");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Cost)
                .HasPrecision(12, 4)
                .HasColumnName("cost");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.DateAvailable)
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
                .HasPrecision(15)
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
                .HasPrecision(15)
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
            entity.Property(e => e.NixSupplierId)
                .HasColumnType("int(3) unsigned")
                .HasColumnName("nix_supplier_id");
            entity.Property(e => e.NixSupplierProductId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("nix_supplier_product_id");
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
            entity.Property(e => e.SupplerCode)
                .HasColumnType("int(2)")
                .HasColumnName("suppler_code");
            entity.Property(e => e.SupplerType)
                .HasColumnType("int(2)")
                .HasColumnName("suppler_type");
            entity.Property(e => e.TaxClassId)
                .HasColumnType("int(11)")
                .HasColumnName("tax_class_id");
            entity.Property(e => e.UnitId)
                .HasColumnType("int(11)")
                .HasColumnName("unit_id");
            entity.Property(e => e.Upc)
                .HasMaxLength(255)
                .HasColumnName("upc");
            entity.Property(e => e.Viewed)
                .HasColumnType("int(5)")
                .HasColumnName("viewed");
            entity.Property(e => e.Weight)
                .HasPrecision(15)
                .HasColumnName("weight");
            entity.Property(e => e.WeightClassId)
                .HasColumnType("int(11)")
                .HasColumnName("weight_class_id");
            entity.Property(e => e.Width)
                .HasPrecision(15)
                .HasColumnName("width");
        });

        modelBuilder.Entity<OcProductAttribute>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.AttributeId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_product_attribute");

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

        modelBuilder.Entity<OcProductDescription>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_product_description");

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

        modelBuilder.Entity<OcProductDiscount>(entity =>
        {
            entity.HasKey(e => e.ProductDiscountId).HasName("PRIMARY");

            entity.ToTable("oc_product_discount");

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

        modelBuilder.Entity<OcProductFilter>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.FilterId }).HasName("PRIMARY");

            entity.ToTable("oc_product_filter");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.FilterId)
                .HasColumnType("int(11)")
                .HasColumnName("filter_id");
        });

        modelBuilder.Entity<OcProductImage>(entity =>
        {
            entity.HasKey(e => e.ProductImageId).HasName("PRIMARY");

            entity.ToTable("oc_product_image");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.HasIndex(e => e.SortOrder, "sort_order");

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

        modelBuilder.Entity<OcProductOption>(entity =>
        {
            entity.HasKey(e => e.ProductOptionId).HasName("PRIMARY");

            entity.ToTable("oc_product_option");

            entity.HasIndex(e => e.OptionId, "option_id");

            entity.HasIndex(e => e.ProductId, "product_id");

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

        modelBuilder.Entity<OcProductOptionValue>(entity =>
        {
            entity.HasKey(e => e.ProductOptionValueId).HasName("PRIMARY");

            entity.ToTable("oc_product_option_value");

            entity.HasIndex(e => e.OptionId, "option_id");

            entity.HasIndex(e => e.OptionValueId, "option_value_id");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.HasIndex(e => e.ProductOptionId, "product_option_id");

            entity.HasIndex(e => e.Quantity, "quantity");

            entity.HasIndex(e => e.Subtract, "subtract");

            entity.Property(e => e.ProductOptionValueId)
                .HasColumnType("int(11)")
                .HasColumnName("product_option_value_id");
            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.OptionValueId)
                .HasColumnType("int(11)")
                .HasColumnName("option_value_id");
            entity.Property(e => e.Optsku)
                .HasMaxLength(64)
                .HasColumnName("optsku");
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
                .HasPrecision(15)
                .HasColumnName("weight");
            entity.Property(e => e.WeightPrefix)
                .HasMaxLength(1)
                .HasColumnName("weight_prefix");
        });

        modelBuilder.Entity<OcProductOwnerPriority>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("oc_product_owner_priority");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.OwnerPriority)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("owner_priority");
        });

        modelBuilder.Entity<OcProductRecurring>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.RecurringId, e.CustomerGroupId }).HasName("PRIMARY");

            entity.ToTable("oc_product_recurring");

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

        modelBuilder.Entity<OcProductRelated>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.RelatedId }).HasName("PRIMARY");

            entity.ToTable("oc_product_related");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.RelatedId)
                .HasColumnType("int(11)")
                .HasColumnName("related_id");
        });

        modelBuilder.Entity<OcProductReward>(entity =>
        {
            entity.HasKey(e => e.ProductRewardId).HasName("PRIMARY");

            entity.ToTable("oc_product_reward");

            entity.HasIndex(e => e.CustomerGroupId, "customer_group_id");

            entity.HasIndex(e => e.ProductId, "product_id");

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

        modelBuilder.Entity<OcProductSpecial>(entity =>
        {
            entity.HasKey(e => e.ProductSpecialId).HasName("PRIMARY");

            entity.ToTable("oc_product_special");

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

        modelBuilder.Entity<OcProductToAttributeReserved>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.AttributeId, e.AttributableId, e.AttributableType }).HasName("PRIMARY");

            entity.ToTable("oc_product_to_attribute_reserved");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.AttributeId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_id");
            entity.Property(e => e.AttributableId)
                .HasColumnType("int(11)")
                .HasColumnName("attributable_id");
            entity.Property(e => e.AttributableType).HasColumnName("attributable_type");
        });

        modelBuilder.Entity<OcProductToAttributeToEnum>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.AttributeId, e.EnumId }).HasName("PRIMARY");

            entity.ToTable("oc_product_to_attribute_to_enum");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.AttributeId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_id");
            entity.Property(e => e.EnumId)
                .HasColumnType("int(11)")
                .HasColumnName("enum_id");
        });

        modelBuilder.Entity<OcProductToCategory>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.CategoryId }).HasName("PRIMARY");

            entity.ToTable("oc_product_to_category");

            entity.HasIndex(e => e.CategoryId, "category_id");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.MainCategory).HasColumnName("main_category");
        });

        modelBuilder.Entity<OcProductToDownload>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.DownloadId }).HasName("PRIMARY");

            entity.ToTable("oc_product_to_download");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.DownloadId)
                .HasColumnType("int(11)")
                .HasColumnName("download_id");
        });

        modelBuilder.Entity<OcProductToLayout>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("oc_product_to_layout");

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

        modelBuilder.Entity<OcProductToPromProduct>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.PromProductId }).HasName("PRIMARY");

            entity.ToTable("oc_product_to_prom_product");

            entity.HasIndex(e => e.PromProductId, "prom_product_id");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.PromProductId)
                .HasColumnType("int(11)")
                .HasColumnName("prom_product_id");
        });

        modelBuilder.Entity<OcProductToStore>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("oc_product_to_store");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<OcProductToSupplier>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.SupplierId }).HasName("PRIMARY");

            entity.ToTable("oc_product_to_supplier");

            entity.HasIndex(e => e.SupplierId, "supplier_id");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(64)
                .HasColumnName("supplier_id");
        });

        modelBuilder.Entity<OcProductToTranslate>(entity =>
        {
            entity.HasKey(e => e.TranslateId).HasName("PRIMARY");

            entity.ToTable("oc_product_to_translate");

            entity.Property(e => e.TranslateId)
                .HasColumnType("int(11)")
                .HasColumnName("translate_id");
            entity.Property(e => e.TransDate)
                .HasColumnType("date")
                .HasColumnName("trans_date");
            entity.Property(e => e.TransProductId)
                .HasColumnType("int(11)")
                .HasColumnName("trans_product_id");
            entity.Property(e => e.TransStatus)
                .HasColumnType("int(11)")
                .HasColumnName("trans_status");
        });

        modelBuilder.Entity<OcPromCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PRIMARY");

            entity.ToTable("oc_prom_category");

            entity.HasIndex(e => e.ParentId, "parent_id");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.ParentId)
                .HasColumnType("int(11)")
                .HasColumnName("parent_id");
        });

        modelBuilder.Entity<OcPromCategoryDescription>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_prom_category_description");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<OcPromId>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("oc_prom_id");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.PromId)
                .HasMaxLength(64)
                .HasColumnName("prom_id");
        });

        modelBuilder.Entity<OcRecurring>(entity =>
        {
            entity.HasKey(e => e.RecurringId).HasName("PRIMARY");

            entity.ToTable("oc_recurring");

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

        modelBuilder.Entity<OcRecurringDescription>(entity =>
        {
            entity.HasKey(e => new { e.RecurringId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_recurring_description");

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

        modelBuilder.Entity<OcRedirect>(entity =>
        {
            entity.HasKey(e => e.RedirectId).HasName("PRIMARY");

            entity.ToTable("oc_redirect");

            entity.Property(e => e.RedirectId)
                .HasColumnType("int(11)")
                .HasColumnName("redirect_id");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'0'")
                .HasColumnName("active");
            entity.Property(e => e.DateEnd)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_end");
            entity.Property(e => e.DateStart)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_start");
            entity.Property(e => e.FromUrl)
                .HasColumnType("text")
                .HasColumnName("from_url");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.ResponseCode)
                .HasDefaultValueSql("'301'")
                .HasColumnType("int(3)")
                .HasColumnName("response_code");
            entity.Property(e => e.TimesUsed)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("times_used");
            entity.Property(e => e.ToUrl)
                .HasColumnType("text")
                .HasColumnName("to_url");
        });

        modelBuilder.Entity<OcRelated>(entity =>
        {
            entity.HasKey(e => e.RelatedId).HasName("PRIMARY");

            entity.ToTable("oc_related");

            entity.Property(e => e.RelatedId)
                .HasColumnType("int(11)")
                .HasColumnName("related_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.RelatedProductStrId)
                .HasColumnType("text")
                .HasColumnName("related_product_str_id");
            entity.Property(e => e.RelatedTitle)
                .HasColumnType("text")
                .HasColumnName("related_title");
        });

        modelBuilder.Entity<OcRelatedoption>(entity =>
        {
            entity.HasKey(e => e.RelatedoptionsId).HasName("PRIMARY");

            entity.ToTable("oc_relatedoptions");

            entity.Property(e => e.RelatedoptionsId)
                .HasColumnType("int(11)")
                .HasColumnName("relatedoptions_id");
            entity.Property(e => e.Defaultselect).HasColumnName("defaultselect");
            entity.Property(e => e.Defaultselectpriority)
                .HasColumnType("int(11)")
                .HasColumnName("defaultselectpriority");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Ean)
                .HasMaxLength(14)
                .HasColumnName("ean");
            entity.Property(e => e.Location)
                .HasMaxLength(128)
                .HasColumnName("location");
            entity.Property(e => e.Model)
                .HasMaxLength(64)
                .HasColumnName("model");
            entity.Property(e => e.Price)
                .HasPrecision(15, 4)
                .HasColumnName("price");
            entity.Property(e => e.PricePrefix)
                .HasMaxLength(1)
                .HasColumnName("price_prefix");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(4)")
                .HasColumnName("quantity");
            entity.Property(e => e.RelatedoptionsVariantProductId)
                .HasColumnType("int(11)")
                .HasColumnName("relatedoptions_variant_product_id");
            entity.Property(e => e.Sku)
                .HasMaxLength(64)
                .HasColumnName("sku");
            entity.Property(e => e.StockStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("stock_status_id");
            entity.Property(e => e.Upc)
                .HasMaxLength(12)
                .HasColumnName("upc");
            entity.Property(e => e.Weight)
                .HasPrecision(15, 8)
                .HasColumnName("weight");
            entity.Property(e => e.WeightPrefix)
                .HasMaxLength(1)
                .HasColumnName("weight_prefix");
        });

        modelBuilder.Entity<OcRelatedoptionsDiscount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oc_relatedoptions_discount");

            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
            entity.Property(e => e.Price)
                .HasPrecision(15, 4)
                .HasColumnName("price");
            entity.Property(e => e.Priority)
                .HasColumnType("int(5)")
                .HasColumnName("priority");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(4)")
                .HasColumnName("quantity");
            entity.Property(e => e.RelatedoptionsId)
                .HasColumnType("int(11)")
                .HasColumnName("relatedoptions_id");
        });

        modelBuilder.Entity<OcRelatedoptionsOption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oc_relatedoptions_option");

            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.OptionValueId)
                .HasColumnType("int(11)")
                .HasColumnName("option_value_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.RelatedoptionsId)
                .HasColumnType("int(11)")
                .HasColumnName("relatedoptions_id");
        });

        modelBuilder.Entity<OcRelatedoptionsSpecial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oc_relatedoptions_special");

            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
            entity.Property(e => e.Price)
                .HasPrecision(15, 4)
                .HasColumnName("price");
            entity.Property(e => e.Priority)
                .HasColumnType("int(5)")
                .HasColumnName("priority");
            entity.Property(e => e.RelatedoptionsId)
                .HasColumnType("int(11)")
                .HasColumnName("relatedoptions_id");
        });

        modelBuilder.Entity<OcRelatedoptionsToChar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oc_relatedoptions_to_char");

            entity.Property(e => e.CharId)
                .HasMaxLength(255)
                .HasColumnName("char_id");
            entity.Property(e => e.RelatedoptionsId)
                .HasColumnType("int(11)")
                .HasColumnName("relatedoptions_id");
        });

        modelBuilder.Entity<OcRelatedoptionsVariant>(entity =>
        {
            entity.HasKey(e => e.RelatedoptionsVariantId).HasName("PRIMARY");

            entity.ToTable("oc_relatedoptions_variant");

            entity.Property(e => e.RelatedoptionsVariantId)
                .HasColumnType("int(11)")
                .HasColumnName("relatedoptions_variant_id");
            entity.Property(e => e.RelatedoptionsVariantName)
                .HasMaxLength(255)
                .HasColumnName("relatedoptions_variant_name");
        });

        modelBuilder.Entity<OcRelatedoptionsVariantOption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oc_relatedoptions_variant_option");

            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.RelatedoptionsVariantId)
                .HasColumnType("int(11)")
                .HasColumnName("relatedoptions_variant_id");
        });

        modelBuilder.Entity<OcRelatedoptionsVariantProduct>(entity =>
        {
            entity.HasKey(e => e.RelatedoptionsVariantProductId).HasName("PRIMARY");

            entity.ToTable("oc_relatedoptions_variant_product");

            entity.Property(e => e.RelatedoptionsVariantProductId)
                .HasColumnType("int(11)")
                .HasColumnName("relatedoptions_variant_product_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.RelatedoptionsUse).HasColumnName("relatedoptions_use");
            entity.Property(e => e.RelatedoptionsVariantId)
                .HasColumnType("int(11)")
                .HasColumnName("relatedoptions_variant_id");
        });

        modelBuilder.Entity<OcRemarketingOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("oc_remarketing_orders");

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

        modelBuilder.Entity<OcReturn>(entity =>
        {
            entity.HasKey(e => e.ReturnId).HasName("PRIMARY");

            entity.ToTable("oc_return");

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

        modelBuilder.Entity<OcReturnAction>(entity =>
        {
            entity.HasKey(e => new { e.ReturnActionId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_return_action");

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

        modelBuilder.Entity<OcReturnHistory>(entity =>
        {
            entity.HasKey(e => e.ReturnHistoryId).HasName("PRIMARY");

            entity.ToTable("oc_return_history");

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

        modelBuilder.Entity<OcReturnReason>(entity =>
        {
            entity.HasKey(e => new { e.ReturnReasonId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_return_reason");

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

        modelBuilder.Entity<OcReturnStatus>(entity =>
        {
            entity.HasKey(e => new { e.ReturnStatusId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_return_status");

            entity.Property(e => e.ReturnStatusId)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11)")
                .HasColumnName("return_status_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OcReview>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PRIMARY");

            entity.ToTable("oc_review");

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
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
        });

        modelBuilder.Entity<OcSeoTagsGenerator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oc_seo_tags_generator");

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

        modelBuilder.Entity<OcSeoTagsGeneratorCategoryCopy>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.CopyCategoryId }).HasName("PRIMARY");

            entity.ToTable("oc_seo_tags_generator_category_copy");

            entity.HasIndex(e => e.CopyCategoryId, "copy_category_id");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.CopyCategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("copy_category_id");
        });

        modelBuilder.Entity<OcSeoTagsGeneratorCategoryDeclension>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_seo_tags_generator_category_declension");

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
            entity.Property(e => e.CategoryNameSingularNominative)
                .HasMaxLength(255)
                .HasColumnName("category_name_singular_nominative");
        });

        modelBuilder.Entity<OcSeoTagsGeneratorCategorySetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oc_seo_tags_generator_category_setting");

            entity.HasIndex(e => e.CategoryId, "category_id").IsUnique();

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.Setting)
                .HasMaxLength(255)
                .HasColumnName("setting");
        });

        modelBuilder.Entity<OcSeoTagsGeneratorNotUse>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.EssenceId }).HasName("PRIMARY");

            entity.ToTable("oc_seo_tags_generator_not_use");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.EssenceId)
                .HasColumnType("int(1)")
                .HasColumnName("essence_id");
        });

        modelBuilder.Entity<OcSetting>(entity =>
        {
            entity.HasKey(e => e.SettingId).HasName("PRIMARY");

            entity.ToTable("oc_setting");

            entity.HasIndex(e => e.Key, "key");

            entity.HasIndex(e => e.Serialized, "serialized");

            entity.HasIndex(e => e.StoreId, "store_id");

            entity.Property(e => e.SettingId)
                .HasColumnType("int(11)")
                .HasColumnName("setting_id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.Key)
                .HasMaxLength(64)
                .HasColumnName("key");
            entity.Property(e => e.Serialized).HasColumnName("serialized");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.Value)
                .HasColumnType("mediumtext")
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcSimpleCart>(entity =>
        {
            entity.HasKey(e => e.SimpleCartId).HasName("PRIMARY");

            entity.ToTable("oc_simple_cart");

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

        modelBuilder.Entity<OcStockStatus>(entity =>
        {
            entity.HasKey(e => new { e.StockStatusId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_stock_status");

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

        modelBuilder.Entity<OcStore>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PRIMARY");

            entity.ToTable("oc_store");

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

        modelBuilder.Entity<OcSuppler>(entity =>
        {
            entity.HasKey(e => e.FormId).HasName("PRIMARY");

            entity.ToTable("oc_suppler");

            entity.Property(e => e.FormId)
                .HasColumnType("int(10)")
                .HasColumnName("form_id");
            entity.Property(e => e.Ad)
                .HasMaxLength(2)
                .HasColumnName("ad");
            entity.Property(e => e.Addattr)
                .HasMaxLength(2)
                .HasColumnName("addattr");
            entity.Property(e => e.Addopt)
                .HasMaxLength(1)
                .HasColumnName("addopt");
            entity.Property(e => e.Addseo)
                .HasMaxLength(1)
                .HasColumnName("addseo");
            entity.Property(e => e.Bonus)
                .HasMaxLength(64)
                .HasColumnName("bonus");
            entity.Property(e => e.Bprice)
                .HasMaxLength(3)
                .HasColumnName("bprice");
            entity.Property(e => e.Cat)
                .HasColumnType("text")
                .HasColumnName("cat");
            entity.Property(e => e.Catcreate)
                .HasMaxLength(1)
                .HasColumnName("catcreate");
            entity.Property(e => e.Chcode)
                .HasMaxLength(1)
                .HasColumnName("chcode");
            entity.Property(e => e.Cheap)
                .HasMaxLength(3)
                .HasColumnName("cheap");
            entity.Property(e => e.Cod)
                .HasMaxLength(128)
                .HasColumnName("cod");
            entity.Property(e => e.Codedonor)
                .HasColumnType("int(1)")
                .HasColumnName("codedonor");
            entity.Property(e => e.Codeprice)
                .HasColumnType("int(1)")
                .HasColumnName("codeprice");
            entity.Property(e => e.Cprice)
                .HasColumnType("text")
                .HasColumnName("cprice");
            entity.Property(e => e.Ddata)
                .HasMaxLength(3)
                .HasColumnName("ddata");
            entity.Property(e => e.Ddesc)
                .HasMaxLength(1)
                .HasColumnName("ddesc");
            entity.Property(e => e.Delimiter)
                .HasMaxLength(64)
                .HasColumnName("delimiter");
            entity.Property(e => e.Descrip)
                .HasMaxLength(128)
                .HasColumnName("descrip");
            entity.Property(e => e.Disc)
                .HasMaxLength(12)
                .HasColumnName("disc");
            entity.Property(e => e.Ean)
                .HasMaxLength(3)
                .HasColumnName("ean");
            entity.Property(e => e.Exsame)
                .HasMaxLength(1)
                .HasColumnName("exsame");
            entity.Property(e => e.Ffile)
                .HasMaxLength(1)
                .HasColumnName("ffile");
            entity.Property(e => e.Formdate)
                .HasColumnType("datetime")
                .HasColumnName("formdate");
            entity.Property(e => e.Height)
                .HasMaxLength(3)
                .HasColumnName("height");
            entity.Property(e => e.Hide)
                .HasMaxLength(1)
                .HasColumnName("hide");
            entity.Property(e => e.Idcat)
                .HasMaxLength(1)
                .HasColumnName("idcat");
            entity.Property(e => e.Importseo)
                .HasMaxLength(1)
                .HasColumnName("importseo");
            entity.Property(e => e.Isbn)
                .HasMaxLength(3)
                .HasColumnName("isbn");
            entity.Property(e => e.Item)
                .HasMaxLength(128)
                .HasColumnName("item");
            entity.Property(e => e.Jan)
                .HasMaxLength(3)
                .HasColumnName("jan");
            entity.Property(e => e.Joen)
                .HasMaxLength(1)
                .HasColumnName("joen");
            entity.Property(e => e.Jopt)
                .HasColumnType("int(2)")
                .HasColumnName("jopt");
            entity.Property(e => e.Kmenu)
                .HasMaxLength(3)
                .HasColumnName("kmenu");
            entity.Property(e => e.Lang)
                .HasMaxLength(2)
                .HasColumnName("lang");
            entity.Property(e => e.Length)
                .HasMaxLength(3)
                .HasColumnName("length");
            entity.Property(e => e.Location)
                .HasMaxLength(3)
                .HasColumnName("location");
            entity.Property(e => e.Main)
                .HasColumnType("int(1)")
                .HasColumnName("main");
            entity.Property(e => e.Manuf)
                .HasMaxLength(128)
                .HasColumnName("manuf");
            entity.Property(e => e.Metka)
                .HasMaxLength(1)
                .HasColumnName("metka");
            entity.Property(e => e.Minopt)
                .HasColumnType("int(1)")
                .HasColumnName("minopt");
            entity.Property(e => e.Minus)
                .HasMaxLength(1)
                .HasColumnName("minus");
            entity.Property(e => e.Model)
                .HasColumnType("int(1)")
                .HasColumnName("model");
            entity.Property(e => e.Mpn)
                .HasMaxLength(3)
                .HasColumnName("mpn");
            entity.Property(e => e.MyCat)
                .HasMaxLength(64)
                .HasColumnName("my_cat");
            entity.Property(e => e.MyDescrip)
                .HasMaxLength(512)
                .HasColumnName("my_descrip");
            entity.Property(e => e.MyManuf)
                .HasMaxLength(64)
                .HasColumnName("my_manuf");
            entity.Property(e => e.MyMark)
                .HasColumnType("text")
                .HasColumnName("my_mark");
            entity.Property(e => e.MyPhoto)
                .HasMaxLength(512)
                .HasColumnName("my_photo");
            entity.Property(e => e.MyPrice)
                .HasColumnType("int(2)")
                .HasColumnName("my_price");
            entity.Property(e => e.MyQu)
                .HasColumnType("text")
                .HasColumnName("my_qu");
            entity.Property(e => e.Myplus)
                .HasMaxLength(3)
                .HasColumnName("myplus");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Newonly)
                .HasColumnType("int(1)")
                .HasColumnName("newonly");
            entity.Property(e => e.Newphoto)
                .HasMaxLength(1)
                .HasColumnName("newphoto");
            entity.Property(e => e.Newproduct)
                .HasMaxLength(5)
                .HasColumnName("newproduct");
            entity.Property(e => e.Newurl)
                .HasMaxLength(1)
                .HasColumnName("newurl");
            entity.Property(e => e.Off)
                .HasMaxLength(1)
                .HasColumnName("off");
            entity.Property(e => e.Onn)
                .HasMaxLength(12)
                .HasColumnName("onn");
            entity.Property(e => e.Onoff)
                .HasMaxLength(1)
                .HasColumnName("onoff");
            entity.Property(e => e.OptFotos)
                .HasMaxLength(1)
                .HasColumnName("opt_fotos");
            entity.Property(e => e.OptPrices)
                .HasMaxLength(1)
                .HasColumnName("opt_prices");
            entity.Property(e => e.Optsku)
                .HasMaxLength(1)
                .HasColumnName("optsku");
            entity.Property(e => e.Parent)
                .HasMaxLength(1)
                .HasColumnName("parent");
            entity.Property(e => e.Parsc)
                .HasMaxLength(3)
                .HasColumnName("parsc");
            entity.Property(e => e.Parsd)
                .HasMaxLength(3)
                .HasColumnName("parsd");
            entity.Property(e => e.Parsi)
                .HasMaxLength(3)
                .HasColumnName("parsi");
            entity.Property(e => e.Parsk)
                .HasMaxLength(3)
                .HasColumnName("parsk");
            entity.Property(e => e.Parsm)
                .HasMaxLength(3)
                .HasColumnName("parsm");
            entity.Property(e => e.Parsp)
                .HasMaxLength(3)
                .HasColumnName("parsp");
            entity.Property(e => e.Parsq)
                .HasMaxLength(3)
                .HasColumnName("parsq");
            entity.Property(e => e.Parss)
                .HasMaxLength(3)
                .HasColumnName("parss");
            entity.Property(e => e.PicExt)
                .HasColumnType("text")
                .HasColumnName("pic_ext");
            entity.Property(e => e.Placec)
                .HasMaxLength(5)
                .HasColumnName("placec");
            entity.Property(e => e.Placed)
                .HasMaxLength(5)
                .HasColumnName("placed");
            entity.Property(e => e.Placei)
                .HasMaxLength(5)
                .HasColumnName("placei");
            entity.Property(e => e.Placem)
                .HasMaxLength(5)
                .HasColumnName("placem");
            entity.Property(e => e.Placep)
                .HasMaxLength(5)
                .HasColumnName("placep");
            entity.Property(e => e.Placeq)
                .HasMaxLength(5)
                .HasColumnName("placeq");
            entity.Property(e => e.Places)
                .HasMaxLength(5)
                .HasColumnName("places");
            entity.Property(e => e.Plusopt)
                .HasMaxLength(1)
                .HasColumnName("plusopt");
            entity.Property(e => e.Pmanuf)
                .HasMaxLength(1)
                .HasColumnName("pmanuf");
            entity.Property(e => e.Pointc)
                .HasMaxLength(64)
                .HasColumnName("pointc");
            entity.Property(e => e.Pointd)
                .HasMaxLength(64)
                .HasColumnName("pointd");
            entity.Property(e => e.Pointi)
                .HasMaxLength(64)
                .HasColumnName("pointi");
            entity.Property(e => e.Pointm)
                .HasMaxLength(64)
                .HasColumnName("pointm");
            entity.Property(e => e.Pointp)
                .HasMaxLength(64)
                .HasColumnName("pointp");
            entity.Property(e => e.Pointq)
                .HasMaxLength(64)
                .HasColumnName("pointq");
            entity.Property(e => e.Points)
                .HasMaxLength(64)
                .HasColumnName("points");
            entity.Property(e => e.Price)
                .HasMaxLength(128)
                .HasColumnName("price");
            entity.Property(e => e.Qu)
                .HasMaxLength(128)
                .HasColumnName("qu");
            entity.Property(e => e.QuDiscount)
                .HasMaxLength(128)
                .HasColumnName("qu_discount");
            entity.Property(e => e.Rate)
                .HasMaxLength(8)
                .HasColumnName("rate");
            entity.Property(e => e.Ratek)
                .HasPrecision(12, 4)
                .HasColumnName("ratek");
            entity.Property(e => e.Ratep)
                .HasMaxLength(8)
                .HasColumnName("ratep");
            entity.Property(e => e.Ref)
                .HasMaxLength(128)
                .HasColumnName("ref");
            entity.Property(e => e.Ref1)
                .HasMaxLength(128)
                .HasColumnName("ref1");
            entity.Property(e => e.Ref2)
                .HasMaxLength(128)
                .HasColumnName("ref2");
            entity.Property(e => e.Ref3)
                .HasMaxLength(128)
                .HasColumnName("ref3");
            entity.Property(e => e.Refer)
                .HasMaxLength(3)
                .HasColumnName("refer");
            entity.Property(e => e.Related)
                .HasMaxLength(3)
                .HasColumnName("related");
            entity.Property(e => e.Rprice)
                .HasMaxLength(3)
                .HasColumnName("rprice");
            entity.Property(e => e.Serie)
                .HasMaxLength(16)
                .HasColumnName("serie");
            entity.Property(e => e.Sku2)
                .HasMaxLength(3)
                .HasColumnName("sku2");
            entity.Property(e => e.Skuprefix)
                .HasMaxLength(24)
                .HasColumnName("skuprefix");
            entity.Property(e => e.Sleep)
                .HasMaxLength(1)
                .HasColumnName("sleep");
            entity.Property(e => e.Sorder)
                .HasMaxLength(3)
                .HasColumnName("sorder");
            entity.Property(e => e.SortOrder)
                .HasColumnType("int(13)")
                .HasColumnName("sort_order");
            entity.Property(e => e.Spec)
                .HasMaxLength(128)
                .HasColumnName("spec");
            entity.Property(e => e.Status)
                .HasColumnType("int(2)")
                .HasColumnName("status");
            entity.Property(e => e.Stay)
                .HasMaxLength(1)
                .HasColumnName("stay");
            entity.Property(e => e.Subfolder)
                .HasMaxLength(1)
                .HasColumnName("subfolder");
            entity.Property(e => e.SupplerId)
                .HasColumnType("int(11)")
                .HasColumnName("suppler_id");
            entity.Property(e => e.TRef)
                .HasMaxLength(3)
                .HasColumnName("t_ref");
            entity.Property(e => e.TRef1)
                .HasMaxLength(3)
                .HasColumnName("t_ref1");
            entity.Property(e => e.TRef2)
                .HasMaxLength(3)
                .HasColumnName("t_ref2");
            entity.Property(e => e.TRef3)
                .HasMaxLength(3)
                .HasColumnName("t_ref3");
            entity.Property(e => e.TStatus)
                .HasMaxLength(255)
                .HasColumnName("t_status");
            entity.Property(e => e.Termin)
                .HasMaxLength(3)
                .HasColumnName("termin");
            entity.Property(e => e.Umanuf)
                .HasMaxLength(1)
                .HasColumnName("umanuf");
            entity.Property(e => e.Upattr)
                .HasMaxLength(1)
                .HasColumnName("upattr");
            entity.Property(e => e.Upc)
                .HasMaxLength(3)
                .HasColumnName("upc");
            entity.Property(e => e.Updte)
                .HasMaxLength(1)
                .HasColumnName("updte");
            entity.Property(e => e.Upname)
                .HasMaxLength(1)
                .HasColumnName("upname");
            entity.Property(e => e.Upopt)
                .HasMaxLength(1)
                .HasColumnName("upopt");
            entity.Property(e => e.Upurl)
                .HasMaxLength(3)
                .HasColumnName("upurl");
            entity.Property(e => e.Usd)
                .HasMaxLength(3)
                .HasColumnName("usd");
            entity.Property(e => e.Warranty)
                .HasColumnType("text")
                .HasColumnName("warranty");
            entity.Property(e => e.Weight)
                .HasMaxLength(3)
                .HasColumnName("weight");
            entity.Property(e => e.Width)
                .HasMaxLength(3)
                .HasColumnName("width");
            entity.Property(e => e.Zero)
                .HasMaxLength(1)
                .HasColumnName("zero");
        });

        modelBuilder.Entity<OcSupplerAttribute>(entity =>
        {
            entity.HasKey(e => e.NomId).HasName("PRIMARY");

            entity.ToTable("oc_suppler_attributes");

            entity.Property(e => e.NomId)
                .HasColumnType("int(11)")
                .HasColumnName("nom_id");
            entity.Property(e => e.AttrExt)
                .HasColumnType("text")
                .HasColumnName("attr_ext");
            entity.Property(e => e.AttrPoint)
                .HasColumnType("text")
                .HasColumnName("attr_point");
            entity.Property(e => e.AttributeId)
                .HasColumnType("int(11)")
                .HasColumnName("attribute_id");
            entity.Property(e => e.FilterGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("filter_group_id");
            entity.Property(e => e.FormId)
                .HasColumnType("int(11)")
                .HasColumnName("form_id");
            entity.Property(e => e.Tags)
                .HasMaxLength(1)
                .HasColumnName("tags");
        });

        modelBuilder.Entity<OcSupplerBasePrice>(entity =>
        {
            entity.HasKey(e => e.NomId).HasName("PRIMARY");

            entity.ToTable("oc_suppler_base_price");

            entity.Property(e => e.NomId)
                .HasColumnType("int(11)")
                .HasColumnName("nom_id");
            entity.Property(e => e.Bav)
                .HasPrecision(12, 4)
                .HasColumnName("bav");
            entity.Property(e => e.Bdisc)
                .HasPrecision(12, 4)
                .HasColumnName("bdisc");
            entity.Property(e => e.Bmax)
                .HasPrecision(12, 4)
                .HasColumnName("bmax");
            entity.Property(e => e.Bmin)
                .HasPrecision(12, 4)
                .HasColumnName("bmin");
            entity.Property(e => e.Bpack)
                .HasColumnType("int(11)")
                .HasColumnName("bpack");
            entity.Property(e => e.Bprice)
                .HasPrecision(12, 4)
                .HasColumnName("bprice");
            entity.Property(e => e.Brate)
                .HasPrecision(12, 4)
                .HasColumnName("brate");
            entity.Property(e => e.Bsuppler)
                .HasMaxLength(2)
                .HasColumnName("bsuppler");
            entity.Property(e => e.MarketPercentToBdprice)
                .HasPrecision(6, 3)
                .HasColumnName("market_percent_to_bdprice");
            entity.Property(e => e.MarketPercentToBprice)
                .HasPrecision(6, 3)
                .HasColumnName("market_percent_to_bprice");
            entity.Property(e => e.MarketPercentToPrice)
                .HasPrecision(6, 3)
                .HasColumnName("market_percent_to_price");
            entity.Property(e => e.Model)
                .HasMaxLength(64)
                .HasColumnName("model");
            entity.Property(e => e.Optimal)
                .HasPrecision(12, 4)
                .HasColumnName("optimal");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
        });

        modelBuilder.Entity<OcSupplerCron>(entity =>
        {
            entity.HasKey(e => e.NomId).HasName("PRIMARY");

            entity.ToTable("oc_suppler_cron");

            entity.Property(e => e.NomId)
                .HasColumnType("int(11)")
                .HasColumnName("nom_id");
            entity.Property(e => e.ActChange)
                .HasColumnType("text")
                .HasColumnName("act_change");
            entity.Property(e => e.ActChange1)
                .HasColumnType("text")
                .HasColumnName("act_change1");
            entity.Property(e => e.ActChange2)
                .HasColumnType("text")
                .HasColumnName("act_change2");
            entity.Property(e => e.ActChange3)
                .HasColumnType("text")
                .HasColumnName("act_change3");
            entity.Property(e => e.ActChange4)
                .HasColumnType("text")
                .HasColumnName("act_change4");
            entity.Property(e => e.ActChange5)
                .HasColumnType("text")
                .HasColumnName("act_change5");
            entity.Property(e => e.ActChange6)
                .HasColumnType("text")
                .HasColumnName("act_change6");
            entity.Property(e => e.ActChange7)
                .HasColumnType("text")
                .HasColumnName("act_change7");
            entity.Property(e => e.ActChange8)
                .HasColumnType("text")
                .HasColumnName("act_change8");
            entity.Property(e => e.ActChange9)
                .HasColumnType("text")
                .HasColumnName("act_change9");
            entity.Property(e => e.ActFind)
                .HasColumnType("text")
                .HasColumnName("act_find");
            entity.Property(e => e.ActFind1)
                .HasColumnType("text")
                .HasColumnName("act_find1");
            entity.Property(e => e.ActFind2)
                .HasColumnType("text")
                .HasColumnName("act_find2");
            entity.Property(e => e.ActFind3)
                .HasColumnType("text")
                .HasColumnName("act_find3");
            entity.Property(e => e.ActFind4)
                .HasColumnType("text")
                .HasColumnName("act_find4");
            entity.Property(e => e.ActFind5)
                .HasColumnType("text")
                .HasColumnName("act_find5");
            entity.Property(e => e.ActFind6)
                .HasColumnType("text")
                .HasColumnName("act_find6");
            entity.Property(e => e.ActFind7)
                .HasColumnType("text")
                .HasColumnName("act_find7");
            entity.Property(e => e.ActFind8)
                .HasColumnType("text")
                .HasColumnName("act_find8");
            entity.Property(e => e.ActFind9)
                .HasColumnType("text")
                .HasColumnName("act_find9");
            entity.Property(e => e.All0)
                .HasColumnType("int(1)")
                .HasColumnName("all0");
            entity.Property(e => e.All1)
                .HasColumnType("int(1)")
                .HasColumnName("all1");
            entity.Property(e => e.All2)
                .HasColumnType("int(1)")
                .HasColumnName("all2");
            entity.Property(e => e.All3)
                .HasColumnType("int(1)")
                .HasColumnName("all3");
            entity.Property(e => e.All4)
                .HasColumnType("int(1)")
                .HasColumnName("all4");
            entity.Property(e => e.All5)
                .HasColumnType("int(1)")
                .HasColumnName("all5");
            entity.Property(e => e.All6)
                .HasColumnType("int(1)")
                .HasColumnName("all6");
            entity.Property(e => e.All7)
                .HasColumnType("int(1)")
                .HasColumnName("all7");
            entity.Property(e => e.All8)
                .HasColumnType("int(1)")
                .HasColumnName("all8");
            entity.Property(e => e.All9)
                .HasColumnType("int(1)")
                .HasColumnName("all9");
            entity.Property(e => e.Cmd)
                .HasColumnType("int(1)")
                .HasColumnName("cmd");
            entity.Property(e => e.Cmd1)
                .HasColumnType("int(1)")
                .HasColumnName("cmd1");
            entity.Property(e => e.Cmd2)
                .HasColumnType("int(1)")
                .HasColumnName("cmd2");
            entity.Property(e => e.Cmd3)
                .HasColumnType("int(1)")
                .HasColumnName("cmd3");
            entity.Property(e => e.Cmd4)
                .HasColumnType("int(1)")
                .HasColumnName("cmd4");
            entity.Property(e => e.Cmd5)
                .HasColumnType("int(1)")
                .HasColumnName("cmd5");
            entity.Property(e => e.Cmd6)
                .HasColumnType("int(1)")
                .HasColumnName("cmd6");
            entity.Property(e => e.Cmd7)
                .HasColumnType("int(1)")
                .HasColumnName("cmd7");
            entity.Property(e => e.Cmd8)
                .HasColumnType("int(1)")
                .HasColumnName("cmd8");
            entity.Property(e => e.Cmd9)
                .HasColumnType("int(1)")
                .HasColumnName("cmd9");
            entity.Property(e => e.CronStatus)
                .HasColumnType("int(11)")
                .HasColumnName("cron_status");
            entity.Property(e => e.Csort)
                .HasColumnType("int(3)")
                .HasColumnName("csort");
            entity.Property(e => e.Ctime)
                .HasColumnType("date")
                .HasColumnName("ctime");
            entity.Property(e => e.Ctime1)
                .HasColumnType("date")
                .HasColumnName("ctime1");
            entity.Property(e => e.Errors)
                .HasColumnType("int(5)")
                .HasColumnName("errors");
            entity.Property(e => e.Ext)
                .HasColumnType("int(1)")
                .HasColumnName("ext");
            entity.Property(e => e.Flag)
                .HasColumnType("int(1)")
                .HasColumnName("flag");
            entity.Property(e => e.Flag1)
                .HasColumnType("int(1)")
                .HasColumnName("flag1");
            entity.Property(e => e.FormId)
                .HasColumnType("int(11)")
                .HasColumnName("form_id");
            entity.Property(e => e.FtpName)
                .HasColumnType("text")
                .HasColumnName("ftp_name");
            entity.Property(e => e.FtpPass)
                .HasColumnType("text")
                .HasColumnName("ftp_pass");
            entity.Property(e => e.Go)
                .HasColumnType("int(1)")
                .HasColumnName("go");
            entity.Property(e => e.Imap)
                .HasMaxLength(32)
                .HasColumnName("imap");
            entity.Property(e => e.Ip)
                .HasMaxLength(32)
                .HasColumnName("ip");
            entity.Property(e => e.Ip1)
                .HasMaxLength(32)
                .HasColumnName("ip1");
            entity.Property(e => e.Isno)
                .HasMaxLength(20)
                .HasColumnName("isno");
            entity.Property(e => e.Isno1)
                .HasMaxLength(20)
                .HasColumnName("isno1");
            entity.Property(e => e.Isno2)
                .HasMaxLength(20)
                .HasColumnName("isno2");
            entity.Property(e => e.Isno3)
                .HasMaxLength(20)
                .HasColumnName("isno3");
            entity.Property(e => e.Isno4)
                .HasMaxLength(20)
                .HasColumnName("isno4");
            entity.Property(e => e.Isno5)
                .HasMaxLength(20)
                .HasColumnName("isno5");
            entity.Property(e => e.Isno6)
                .HasMaxLength(20)
                .HasColumnName("isno6");
            entity.Property(e => e.Isno7)
                .HasMaxLength(20)
                .HasColumnName("isno7");
            entity.Property(e => e.Isno8)
                .HasMaxLength(20)
                .HasColumnName("isno8");
            entity.Property(e => e.Isno9)
                .HasMaxLength(20)
                .HasColumnName("isno9");
            entity.Property(e => e.Link)
                .HasColumnType("text")
                .HasColumnName("link");
            entity.Property(e => e.Mail)
                .HasColumnType("text")
                .HasColumnName("mail");
            entity.Property(e => e.OnOff)
                .HasColumnType("int(1)")
                .HasColumnName("on_off");
            entity.Property(e => e.PlStatus)
                .HasColumnType("int(1)")
                .HasColumnName("pl_status");
            entity.Property(e => e.Pop3)
                .HasMaxLength(32)
                .HasColumnName("pop3");
            entity.Property(e => e.Port)
                .HasMaxLength(8)
                .HasColumnName("port");
            entity.Property(e => e.Port1)
                .HasMaxLength(8)
                .HasColumnName("port1");
            entity.Property(e => e.PrName)
                .HasColumnType("text")
                .HasColumnName("pr_name");
            entity.Property(e => e.Report)
                .HasColumnType("int(5)")
                .HasColumnName("report");
            entity.Property(e => e.Rtype)
                .HasColumnType("int(1)")
                .HasColumnName("rtype");
            entity.Property(e => e.SaveBrTime)
                .HasColumnType("int(11)")
                .HasColumnName("save_br_time");
            entity.Property(e => e.SaveForm)
                .HasColumnType("int(11)")
                .HasColumnName("save_form");
            entity.Property(e => e.SaveNom)
                .HasColumnType("int(11)")
                .HasColumnName("save_nom");
            entity.Property(e => e.SaveOnOff)
                .HasColumnType("int(1)")
                .HasColumnName("save_on_off");
            entity.Property(e => e.Smtp)
                .HasMaxLength(32)
                .HasColumnName("smtp");
            entity.Property(e => e.SupplerId)
                .HasColumnType("int(11)")
                .HasColumnName("suppler_id");
            entity.Property(e => e.Task)
                .HasColumnType("int(1)")
                .HasColumnName("task");
            entity.Property(e => e.Text)
                .HasMaxLength(64)
                .HasColumnName("text");
            entity.Property(e => e.Text1)
                .HasMaxLength(64)
                .HasColumnName("text1");
            entity.Property(e => e.Text2)
                .HasMaxLength(64)
                .HasColumnName("text2");
            entity.Property(e => e.User)
                .HasMaxLength(64)
                .HasColumnName("user");
            entity.Property(e => e.User1)
                .HasMaxLength(64)
                .HasColumnName("user1");
        });

        modelBuilder.Entity<OcSupplerDatum>(entity =>
        {
            entity.HasKey(e => e.NomId).HasName("PRIMARY");

            entity.ToTable("oc_suppler_data");

            entity.Property(e => e.NomId)
                .HasColumnType("int(11)")
                .HasColumnName("nom_id");
            entity.Property(e => e.CatExt)
                .HasColumnType("text")
                .HasColumnName("cat_ext");
            entity.Property(e => e.CatPlus)
                .HasColumnType("text")
                .HasColumnName("cat_plus");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.FormId)
                .HasColumnType("int(11)")
                .HasColumnName("form_id");
            entity.Property(e => e.PicInt)
                .HasColumnType("text")
                .HasColumnName("pic_int");
        });

        modelBuilder.Entity<OcSupplerOption>(entity =>
        {
            entity.HasKey(e => e.NomId).HasName("PRIMARY");

            entity.ToTable("oc_suppler_options");

            entity.Property(e => e.NomId)
                .HasColumnType("int(11)")
                .HasColumnName("nom_id");
            entity.Property(e => e.Art)
                .HasMaxLength(3)
                .HasColumnName("art");
            entity.Property(e => e.FormId)
                .HasColumnType("int(11)")
                .HasColumnName("form_id");
            entity.Property(e => e.Foto)
                .HasMaxLength(3)
                .HasColumnName("foto");
            entity.Property(e => e.Ko)
                .HasMaxLength(16)
                .HasColumnName("ko");
            entity.Property(e => e.Opt)
                .HasMaxLength(128)
                .HasColumnName("opt");
            entity.Property(e => e.OptMargin)
                .HasMaxLength(1)
                .HasColumnName("opt_margin");
            entity.Property(e => e.OptPoint)
                .HasMaxLength(128)
                .HasColumnName("opt_point");
            entity.Property(e => e.OptPref)
                .HasMaxLength(1)
                .HasColumnName("opt_pref");
            entity.Property(e => e.OptionId)
                .HasColumnType("int(11)")
                .HasColumnName("option_id");
            entity.Property(e => e.OptionRequired)
                .HasMaxLength(1)
                .HasColumnName("option_required");
            entity.Property(e => e.Po)
                .HasMaxLength(3)
                .HasColumnName("po");
            entity.Property(e => e.Pr)
                .HasMaxLength(128)
                .HasColumnName("pr");
            entity.Property(e => e.We)
                .HasMaxLength(3)
                .HasColumnName("we");
        });

        modelBuilder.Entity<OcSupplerPrice>(entity =>
        {
            entity.HasKey(e => e.NomId).HasName("PRIMARY");

            entity.ToTable("oc_suppler_price");

            entity.Property(e => e.NomId)
                .HasColumnType("int(11)")
                .HasColumnName("nom_id");
            entity.Property(e => e.Baseprice)
                .HasColumnType("int(1)")
                .HasColumnName("baseprice");
            entity.Property(e => e.FormId)
                .HasColumnType("int(11)")
                .HasColumnName("form_id");
            entity.Property(e => e.Ident)
                .HasMaxLength(128)
                .HasColumnName("ident");
            entity.Property(e => e.Mratek)
                .HasPrecision(15, 4)
                .HasColumnName("mratek");
            entity.Property(e => e.Nom)
                .HasMaxLength(3)
                .HasColumnName("nom");
            entity.Property(e => e.Noprice)
                .HasMaxLength(128)
                .HasColumnName("noprice");
            entity.Property(e => e.Param)
                .HasMaxLength(128)
                .HasColumnName("param");
            entity.Property(e => e.Paramnp)
                .HasMaxLength(128)
                .HasColumnName("paramnp");
            entity.Property(e => e.Point)
                .HasMaxLength(128)
                .HasColumnName("point");
            entity.Property(e => e.Pointnp)
                .HasMaxLength(128)
                .HasColumnName("pointnp");
        });

        modelBuilder.Entity<OcSupplerRef>(entity =>
        {
            entity.HasKey(e => e.NomId).HasName("PRIMARY");

            entity.ToTable("oc_suppler_ref");

            entity.Property(e => e.NomId)
                .HasColumnType("int(11)")
                .HasColumnName("nom_id");
            entity.Property(e => e.Ident)
                .HasMaxLength(128)
                .HasColumnName("ident");
            entity.Property(e => e.Price)
                .HasPrecision(15, 4)
                .HasColumnName("price");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
        });

        modelBuilder.Entity<OcSupplerSeo>(entity =>
        {
            entity.HasKey(e => e.NomId).HasName("PRIMARY");

            entity.ToTable("oc_suppler_seo");

            entity.Property(e => e.NomId)
                .HasColumnType("int(11)")
                .HasColumnName("nom_id");
            entity.Property(e => e.CatDesc)
                .HasColumnType("text")
                .HasColumnName("cat_desc");
            entity.Property(e => e.CatH1)
                .HasColumnType("text")
                .HasColumnName("cat_h1");
            entity.Property(e => e.CatKeyword)
                .HasColumnType("text")
                .HasColumnName("cat_keyword");
            entity.Property(e => e.CatMetaDesc)
                .HasColumnType("text")
                .HasColumnName("cat_meta_desc");
            entity.Property(e => e.CatTitle)
                .HasColumnType("text")
                .HasColumnName("cat_title");
            entity.Property(e => e.FormId)
                .HasColumnType("int(11)")
                .HasColumnName("form_id");
            entity.Property(e => e.ManufDesc)
                .HasColumnType("text")
                .HasColumnName("manuf_desc");
            entity.Property(e => e.ManufH1)
                .HasColumnType("text")
                .HasColumnName("manuf_h1");
            entity.Property(e => e.ManufKeyword)
                .HasColumnType("text")
                .HasColumnName("manuf_keyword");
            entity.Property(e => e.ManufMetaDesc)
                .HasColumnType("text")
                .HasColumnName("manuf_meta_desc");
            entity.Property(e => e.ManufTitle)
                .HasColumnType("text")
                .HasColumnName("manuf_title");
            entity.Property(e => e.ProdDesc)
                .HasColumnType("text")
                .HasColumnName("prod_desc");
            entity.Property(e => e.ProdH1)
                .HasColumnType("text")
                .HasColumnName("prod_h1");
            entity.Property(e => e.ProdKeyword)
                .HasColumnType("text")
                .HasColumnName("prod_keyword");
            entity.Property(e => e.ProdMetaDesc)
                .HasColumnType("text")
                .HasColumnName("prod_meta_desc");
            entity.Property(e => e.ProdPhoto)
                .HasColumnType("text")
                .HasColumnName("prod_photo");
            entity.Property(e => e.ProdTitle)
                .HasColumnType("text")
                .HasColumnName("prod_title");
            entity.Property(e => e.ProdUrl)
                .HasColumnType("text")
                .HasColumnName("prod_url");
            entity.Property(e => e.Seo1)
                .HasColumnType("text")
                .HasColumnName("seo_1");
            entity.Property(e => e.Seo10)
                .HasColumnType("text")
                .HasColumnName("seo_10");
            entity.Property(e => e.Seo11)
                .HasColumnType("text")
                .HasColumnName("seo_11");
            entity.Property(e => e.Seo12)
                .HasColumnType("text")
                .HasColumnName("seo_12");
            entity.Property(e => e.Seo13)
                .HasColumnType("text")
                .HasColumnName("seo_13");
            entity.Property(e => e.Seo14)
                .HasColumnType("text")
                .HasColumnName("seo_14");
            entity.Property(e => e.Seo15)
                .HasColumnType("text")
                .HasColumnName("seo_15");
            entity.Property(e => e.Seo16)
                .HasColumnType("text")
                .HasColumnName("seo_16");
            entity.Property(e => e.Seo17)
                .HasColumnType("text")
                .HasColumnName("seo_17");
            entity.Property(e => e.Seo18)
                .HasColumnType("text")
                .HasColumnName("seo_18");
            entity.Property(e => e.Seo19)
                .HasColumnType("text")
                .HasColumnName("seo_19");
            entity.Property(e => e.Seo2)
                .HasColumnType("text")
                .HasColumnName("seo_2");
            entity.Property(e => e.Seo20)
                .HasColumnType("text")
                .HasColumnName("seo_20");
            entity.Property(e => e.Seo3)
                .HasColumnType("text")
                .HasColumnName("seo_3");
            entity.Property(e => e.Seo4)
                .HasColumnType("text")
                .HasColumnName("seo_4");
            entity.Property(e => e.Seo5)
                .HasColumnType("text")
                .HasColumnName("seo_5");
            entity.Property(e => e.Seo6)
                .HasColumnType("text")
                .HasColumnName("seo_6");
            entity.Property(e => e.Seo7)
                .HasColumnType("text")
                .HasColumnName("seo_7");
            entity.Property(e => e.Seo8)
                .HasColumnType("text")
                .HasColumnName("seo_8");
            entity.Property(e => e.Seo9)
                .HasColumnType("text")
                .HasColumnName("seo_9");
            entity.Property(e => e.SeoR1)
                .HasColumnType("text")
                .HasColumnName("seo_r1");
            entity.Property(e => e.SeoR2)
                .HasColumnType("text")
                .HasColumnName("seo_r2");
            entity.Property(e => e.SeoR3)
                .HasColumnType("text")
                .HasColumnName("seo_r3");
            entity.Property(e => e.SeoR4)
                .HasColumnType("text")
                .HasColumnName("seo_r4");
            entity.Property(e => e.SeoR5)
                .HasColumnType("text")
                .HasColumnName("seo_r5");
            entity.Property(e => e.SeoR6)
                .HasColumnType("text")
                .HasColumnName("seo_r6");
        });

        modelBuilder.Entity<OcSupplerSku>(entity =>
        {
            entity.HasKey(e => e.NomId).HasName("PRIMARY");

            entity.ToTable("oc_suppler_sku");

            entity.Property(e => e.NomId)
                .HasColumnType("int(11)")
                .HasColumnName("nom_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.SkuId)
                .HasColumnType("int(11)")
                .HasColumnName("sku_id");
        });

        modelBuilder.Entity<OcSupplerSkuDescription>(entity =>
        {
            entity.HasKey(e => e.NomId).HasName("PRIMARY");

            entity.ToTable("oc_suppler_sku_description");

            entity.Property(e => e.NomId)
                .HasColumnType("int(11)")
                .HasColumnName("nom_id");
            entity.Property(e => e.Sku)
                .HasMaxLength(64)
                .HasColumnName("sku");
            entity.Property(e => e.SkuId)
                .HasColumnType("int(11)")
                .HasColumnName("sku_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(2)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<OcTaxClass>(entity =>
        {
            entity.HasKey(e => e.TaxClassId).HasName("PRIMARY");

            entity.ToTable("oc_tax_class");

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

        modelBuilder.Entity<OcTaxRate>(entity =>
        {
            entity.HasKey(e => e.TaxRateId).HasName("PRIMARY");

            entity.ToTable("oc_tax_rate");

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

        modelBuilder.Entity<OcTaxRateToCustomerGroup>(entity =>
        {
            entity.HasKey(e => new { e.TaxRateId, e.CustomerGroupId }).HasName("PRIMARY");

            entity.ToTable("oc_tax_rate_to_customer_group");

            entity.Property(e => e.TaxRateId)
                .HasColumnType("int(11)")
                .HasColumnName("tax_rate_id");
            entity.Property(e => e.CustomerGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("customer_group_id");
        });

        modelBuilder.Entity<OcTaxRule>(entity =>
        {
            entity.HasKey(e => e.TaxRuleId).HasName("PRIMARY");

            entity.ToTable("oc_tax_rule");

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

        modelBuilder.Entity<OcTheme>(entity =>
        {
            entity.HasKey(e => e.ThemeId).HasName("PRIMARY");

            entity.ToTable("oc_theme");

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

        modelBuilder.Entity<OcTranslation>(entity =>
        {
            entity.HasKey(e => e.TranslationId).HasName("PRIMARY");

            entity.ToTable("oc_translation");

            entity.Property(e => e.TranslationId)
                .HasColumnType("int(11)")
                .HasColumnName("translation_id");
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

        modelBuilder.Entity<OcUniBannerInCategory>(entity =>
        {
            entity.HasKey(e => e.BannerId).HasName("PRIMARY");

            entity.ToTable("oc_uni_banner_in_category");

            entity.Property(e => e.BannerId)
                .HasColumnType("int(11)")
                .HasColumnName("banner_id");
            entity.Property(e => e.DateEnd)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_end");
            entity.Property(e => e.DateStart)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("date_start");
            entity.Property(e => e.Height)
                .HasColumnType("int(11)")
                .HasColumnName("height");
            entity.Property(e => e.Position)
                .HasColumnType("int(11)")
                .HasColumnName("position");
            entity.Property(e => e.Position2)
                .HasColumnType("int(11)")
                .HasColumnName("position2");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("type");
            entity.Property(e => e.Width)
                .HasColumnType("int(11)")
                .HasColumnName("width");
        });

        modelBuilder.Entity<OcUniBannerInCategoryDescription>(entity =>
        {
            entity.HasKey(e => new { e.BannerId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_uni_banner_in_category_description");

            entity.Property(e => e.BannerId)
                .HasColumnType("int(11)")
                .HasColumnName("banner_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Button)
                .HasMaxLength(255)
                .HasColumnName("button");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OcUniBannerInCategoryToCategory>(entity =>
        {
            entity.HasKey(e => new { e.BannerId, e.CategoryId }).HasName("PRIMARY");

            entity.ToTable("oc_uni_banner_in_category_to_category");

            entity.HasIndex(e => e.CategoryId, "category_id");

            entity.Property(e => e.BannerId)
                .HasColumnType("int(11)")
                .HasColumnName("banner_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
        });

        modelBuilder.Entity<OcUniBannerInCategoryToStore>(entity =>
        {
            entity.HasKey(e => new { e.BannerId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("oc_uni_banner_in_category_to_store");

            entity.Property(e => e.BannerId)
                .HasColumnType("int(11)")
                .HasColumnName("banner_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<OcUniGallery>(entity =>
        {
            entity.HasKey(e => e.GalleryId).HasName("PRIMARY");

            entity.ToTable("oc_uni_gallery");

            entity.Property(e => e.GalleryId)
                .HasColumnType("int(11)")
                .HasColumnName("gallery_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<OcUniGalleryImage>(entity =>
        {
            entity.HasKey(e => e.GalleryImageId).HasName("PRIMARY");

            entity.ToTable("oc_uni_gallery_image");

            entity.Property(e => e.GalleryImageId)
                .HasColumnType("int(11)")
                .HasColumnName("gallery_image_id");
            entity.Property(e => e.GalleryId)
                .HasColumnType("int(11)")
                .HasColumnName("gallery_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OcUniGalleryImageDescription>(entity =>
        {
            entity.HasKey(e => new { e.GalleryImageId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_uni_gallery_image_description");

            entity.Property(e => e.GalleryImageId)
                .HasColumnType("int(11)")
                .HasColumnName("gallery_image_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.GalleryId)
                .HasColumnType("int(11)")
                .HasColumnName("gallery_id");
            entity.Property(e => e.Title)
                .HasMaxLength(64)
                .HasColumnName("title");
        });

        modelBuilder.Entity<OcUniNews>(entity =>
        {
            entity.HasKey(e => e.NewsId).HasName("PRIMARY");

            entity.ToTable("oc_uni_news");

            entity.Property(e => e.NewsId)
                .HasColumnType("int(11)")
                .HasColumnName("news_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("date")
                .HasColumnName("date_added");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Viewed)
                .HasColumnType("int(11)")
                .HasColumnName("viewed");
        });

        modelBuilder.Entity<OcUniNewsDescription>(entity =>
        {
            entity.HasKey(e => new { e.NewsId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_uni_news_description");

            entity.Property(e => e.NewsId)
                .HasColumnType("int(11)")
                .HasColumnName("news_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Keyword)
                .HasMaxLength(255)
                .HasColumnName("keyword");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<OcUniNewsToStore>(entity =>
        {
            entity.HasKey(e => new { e.NewsId, e.StoreId }).HasName("PRIMARY");

            entity.ToTable("oc_uni_news_to_store");

            entity.Property(e => e.NewsId)
                .HasColumnType("int(11)")
                .HasColumnName("news_id");
            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<OcUniSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oc_uni_setting");

            entity.Property(e => e.Data)
                .HasColumnType("mediumtext")
                .HasColumnName("data");
        });

        modelBuilder.Entity<OcUnit>(entity =>
        {
            entity.HasKey(e => e.UnitId).HasName("PRIMARY");

            entity.ToTable("oc_unit");

            entity.Property(e => e.UnitId)
                .HasColumnType("int(11)")
                .HasColumnName("unit_id");
            entity.Property(e => e.Code)
                .HasColumnType("int(11)")
                .HasColumnName("code");
            entity.Property(e => e.SymbolIntl)
                .HasMaxLength(20)
                .HasColumnName("symbol_intl");
            entity.Property(e => e.SymbolLetterIntl)
                .HasMaxLength(20)
                .HasColumnName("symbol_letter_intl");
            entity.Property(e => e.SymbolRus)
                .HasMaxLength(20)
                .HasColumnName("symbol_rus");
            entity.Property(e => e.Title)
                .HasMaxLength(32)
                .HasColumnName("title");
        });

        modelBuilder.Entity<OcUpload>(entity =>
        {
            entity.HasKey(e => e.UploadId).HasName("PRIMARY");

            entity.ToTable("oc_upload");

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

        modelBuilder.Entity<OcUrlAlias>(entity =>
        {
            entity.HasKey(e => e.UrlAliasId).HasName("PRIMARY");

            entity.ToTable("oc_url_alias");

            entity.HasIndex(e => e.Keyword, "keyword");

            entity.HasIndex(e => e.Query, "query");

            entity.Property(e => e.UrlAliasId)
                .HasColumnType("int(11)")
                .HasColumnName("url_alias_id");
            entity.Property(e => e.Keyword).HasColumnName("keyword");
            entity.Property(e => e.Query).HasColumnName("query");
        });

        modelBuilder.Entity<OcUrlAliasBlog>(entity =>
        {
            entity.HasKey(e => e.UrlAliasId).HasName("PRIMARY");

            entity.ToTable("oc_url_alias_blog");

            entity.HasIndex(e => e.Keyword, "keyword");

            entity.HasIndex(e => e.LanguageId, "language_id");

            entity.HasIndex(e => e.Query, "query");

            entity.Property(e => e.UrlAliasId)
                .HasColumnType("int(11)")
                .HasColumnName("url_alias_id");
            entity.Property(e => e.Keyword).HasColumnName("keyword");
            entity.Property(e => e.LanguageId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Query).HasColumnName("query");
        });

        modelBuilder.Entity<OcUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("oc_user");

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
            entity.Property(e => e.UserGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("user_group_id");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasColumnName("username");
        });

        modelBuilder.Entity<OcUserGroup>(entity =>
        {
            entity.HasKey(e => e.UserGroupId).HasName("PRIMARY");

            entity.ToTable("oc_user_group");

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

        modelBuilder.Entity<OcVoucher>(entity =>
        {
            entity.HasKey(e => e.VoucherId).HasName("PRIMARY");

            entity.ToTable("oc_voucher");

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

        modelBuilder.Entity<OcVoucherHistory>(entity =>
        {
            entity.HasKey(e => e.VoucherHistoryId).HasName("PRIMARY");

            entity.ToTable("oc_voucher_history");

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

        modelBuilder.Entity<OcVoucherTheme>(entity =>
        {
            entity.HasKey(e => e.VoucherThemeId).HasName("PRIMARY");

            entity.ToTable("oc_voucher_theme");

            entity.Property(e => e.VoucherThemeId)
                .HasColumnType("int(11)")
                .HasColumnName("voucher_theme_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
        });

        modelBuilder.Entity<OcVoucherThemeDescription>(entity =>
        {
            entity.HasKey(e => new { e.VoucherThemeId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_voucher_theme_description");

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

        modelBuilder.Entity<OcWeightClass>(entity =>
        {
            entity.HasKey(e => e.WeightClassId).HasName("PRIMARY");

            entity.ToTable("oc_weight_class");

            entity.Property(e => e.WeightClassId)
                .HasColumnType("int(11)")
                .HasColumnName("weight_class_id");
            entity.Property(e => e.Value)
                .HasPrecision(15)
                .HasColumnName("value");
        });

        modelBuilder.Entity<OcWeightClassDescription>(entity =>
        {
            entity.HasKey(e => new { e.WeightClassId, e.LanguageId }).HasName("PRIMARY");

            entity.ToTable("oc_weight_class_description");

            entity.Property(e => e.WeightClassId)
                .ValueGeneratedOnAdd()
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

        modelBuilder.Entity<OcZone>(entity =>
        {
            entity.HasKey(e => e.ZoneId).HasName("PRIMARY");

            entity.ToTable("oc_zone");

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

        modelBuilder.Entity<OcZoneToGeoZone>(entity =>
        {
            entity.HasKey(e => e.ZoneToGeoZoneId).HasName("PRIMARY");

            entity.ToTable("oc_zone_to_geo_zone");

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

        modelBuilder.Entity<ProductCustomerOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("product_customer_order");

            entity.Property(e => e.Email).HasMaxLength(96);
            entity.Property(e => e.Артикул).HasMaxLength(64);
            entity.Property(e => e.Количество).HasColumnType("int(4)");
            entity.Property(e => e.НазваниеТовара)
                .HasMaxLength(255)
                .HasColumnName("Название товара");
            entity.Property(e => e.ОтКомпании)
                .HasMaxLength(60)
                .HasColumnName("От компании");
            entity.Property(e => e.Статус).HasMaxLength(32);
            entity.Property(e => e.СуммаUah)
                .HasPrecision(20)
                .HasColumnName("Сумма UAH");
            entity.Property(e => e.Телефон).HasMaxLength(32);
            entity.Property(e => e.ФИО)
                .HasMaxLength(32)
                .HasColumnName("Ф.И.О.");
        });

        modelBuilder.Entity<ProductOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("product_order");

            entity.Property(e => e.КоличествоЗаказов)
                .HasColumnType("bigint(21)")
                .HasColumnName("Количество заказов");
            entity.Property(e => e.Статус).HasMaxLength(32);
            entity.Property(e => e.ФИО)
                .HasMaxLength(32)
                .HasColumnName("Ф.И.О.");
        });

        modelBuilder.Entity<ProductLimitQuantity>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");
            entity.Property(e => e.ProductId)
            .HasColumnType("int(11)")
            .HasColumnName("product_id"); 

            entity.ToTable("product_limit_quantity");

            entity.Property(e => e.MinQuantity)
                .HasColumnType("int(11)")
                .HasColumnName("min_quantity");
            entity.Property(e => e.MaxQuantity)
                .HasColumnType("int(11)")
                .HasColumnName("max_quantity");
        });

        modelBuilder.Entity<ProductSetDiscount>(entity =>
        {
            entity.HasKey(e => e.product_id).HasName("PRIMARY");

            entity.ToTable("product_set_discount");

            entity.Property(e => e.PercentDiscount)
                .HasColumnType("decimal(11)")
                .HasColumnName("percent_discount");
            entity.Property(e => e.InGrnDiscount)
                .HasColumnType("decimal(11)")
               .HasColumnName("in_grn_discount");
            //entity.Property(e => e.TotalDiscount)
            //    .HasColumnType("decimal(11)")
            //    .HasColumnName("total_discount");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
