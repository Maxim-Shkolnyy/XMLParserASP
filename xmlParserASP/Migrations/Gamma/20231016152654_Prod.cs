using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xmlParserASP.Migrations.Gamma
{
    /// <inheritdoc />
    public partial class Prod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "query1",
                table: "oc_url_alias_blog",
                newName: "ix_oc_url_alias_blog_query");

            migrationBuilder.RenameIndex(
                name: "language_id",
                table: "oc_url_alias_blog",
                newName: "ix_oc_url_alias_blog_language_id");

            migrationBuilder.RenameIndex(
                name: "keyword4",
                table: "oc_url_alias_blog",
                newName: "ix_oc_url_alias_blog_keyword");

            migrationBuilder.RenameIndex(
                name: "query",
                table: "oc_url_alias",
                newName: "ix_oc_url_alias_query");

            migrationBuilder.RenameIndex(
                name: "keyword3",
                table: "oc_url_alias",
                newName: "ix_oc_url_alias_keyword");

            migrationBuilder.RenameIndex(
                name: "category_id2",
                table: "oc_uni_banner_in_category_to_category",
                newName: "ix_oc_uni_banner_in_category_to_category_category_id");

            migrationBuilder.RenameIndex(
                name: "store_id",
                table: "oc_setting",
                newName: "ix_oc_setting_store_id");

            migrationBuilder.RenameIndex(
                name: "serialized",
                table: "oc_setting",
                newName: "ix_oc_setting_serialized");

            migrationBuilder.RenameIndex(
                name: "key",
                table: "oc_setting",
                newName: "ix_oc_setting_key");

            migrationBuilder.RenameIndex(
                name: "category_id",
                table: "oc_seo_tags_generator_category_setting",
                newName: "ix_oc_seo_tags_generator_category_setting_category_id");

            migrationBuilder.RenameIndex(
                name: "copy_category_id",
                table: "oc_seo_tags_generator_category_copy",
                newName: "ix_oc_seo_tags_generator_category_copy_copy_category_id");

            migrationBuilder.RenameIndex(
                name: "language_id",
                table: "oc_seo_tags_generator",
                newName: "ix_oc_seo_tags_generator_language_id");

            migrationBuilder.RenameIndex(
                name: "key",
                table: "oc_seo_tags_generator",
                newName: "ix_oc_seo_tags_generator_key");

            migrationBuilder.RenameIndex(
                name: "category_id",
                table: "oc_seo_tags_generator",
                newName: "ix_oc_seo_tags_generator_category_id");

            migrationBuilder.RenameIndex(
                name: "product_id8",
                table: "oc_review",
                newName: "ix_oc_review_product_id");

            migrationBuilder.RenameIndex(
                name: "name7",
                table: "oc_prom_category_description",
                newName: "ix_oc_prom_category_description_name");

            migrationBuilder.RenameIndex(
                name: "parent_id1",
                table: "oc_prom_category",
                newName: "ix_oc_prom_category_parent_id");

            migrationBuilder.RenameIndex(
                name: "supplier_id",
                table: "oc_product_to_supplier",
                newName: "ix_oc_product_to_supplier_supplier_id");

            migrationBuilder.RenameIndex(
                name: "prom_product_id",
                table: "oc_product_to_prom_product",
                newName: "ix_oc_product_to_prom_product_prom_product_id");

            migrationBuilder.RenameIndex(
                name: "category_id1",
                table: "oc_product_to_category",
                newName: "ix_oc_product_to_category_category_id");

            migrationBuilder.RenameIndex(
                name: "product_id7",
                table: "oc_product_special",
                newName: "ix_oc_product_special_product_id");

            migrationBuilder.RenameIndex(
                name: "product_id6",
                table: "oc_product_reward",
                newName: "ix_oc_product_reward_product_id");

            migrationBuilder.RenameIndex(
                name: "customer_group_id",
                table: "oc_product_reward",
                newName: "ix_oc_product_reward_customer_group_id");

            migrationBuilder.RenameIndex(
                name: "subtract",
                table: "oc_product_option_value",
                newName: "ix_oc_product_option_value_subtract");

            migrationBuilder.RenameIndex(
                name: "quantity",
                table: "oc_product_option_value",
                newName: "ix_oc_product_option_value_quantity");

            migrationBuilder.RenameIndex(
                name: "product_option_id",
                table: "oc_product_option_value",
                newName: "ix_oc_product_option_value_product_option_id");

            migrationBuilder.RenameIndex(
                name: "product_id5",
                table: "oc_product_option_value",
                newName: "ix_oc_product_option_value_product_id");

            migrationBuilder.RenameIndex(
                name: "option_value_id",
                table: "oc_product_option_value",
                newName: "ix_oc_product_option_value_option_value_id");

            migrationBuilder.RenameIndex(
                name: "option_id3",
                table: "oc_product_option_value",
                newName: "ix_oc_product_option_value_option_id");

            migrationBuilder.RenameIndex(
                name: "product_id4",
                table: "oc_product_option",
                newName: "ix_oc_product_option_product_id");

            migrationBuilder.RenameIndex(
                name: "option_id2",
                table: "oc_product_option",
                newName: "ix_oc_product_option_option_id");

            migrationBuilder.RenameIndex(
                name: "sort_order1",
                table: "oc_product_image",
                newName: "ix_oc_product_image_sort_order");

            migrationBuilder.RenameIndex(
                name: "product_id3",
                table: "oc_product_image",
                newName: "ix_oc_product_image_product_id");

            migrationBuilder.RenameIndex(
                name: "product_id2",
                table: "oc_product_discount",
                newName: "ix_oc_product_discount_product_id");

            migrationBuilder.RenameIndex(
                name: "name6",
                table: "oc_product_description",
                newName: "ix_oc_product_description_name");

            migrationBuilder.RenameIndex(
                name: "nix_supplier_product_id",
                table: "oc_product",
                newName: "ix_oc_product_nix_supplier_product_id");

            migrationBuilder.RenameIndex(
                name: "order_id3",
                table: "oc_order_total",
                newName: "ix_oc_order_total_order_id");

            migrationBuilder.RenameIndex(
                name: "product_id1",
                table: "oc_order_product",
                newName: "ix_oc_order_product_product_id");

            migrationBuilder.RenameIndex(
                name: "order_id2",
                table: "oc_order_product",
                newName: "ix_oc_order_product_order_id");

            migrationBuilder.RenameIndex(
                name: "order_id1",
                table: "oc_order_permissions",
                newName: "ix_oc_order_permissions_order_id");

            migrationBuilder.RenameIndex(
                name: "order_id",
                table: "oc_order_history",
                newName: "ix_oc_order_history_order_id");

            migrationBuilder.RenameIndex(
                name: "order_status_id",
                table: "oc_order",
                newName: "ix_oc_order_order_status_id");

            migrationBuilder.RenameIndex(
                name: "customer_id2",
                table: "oc_order",
                newName: "ix_oc_order_customer_id");

            migrationBuilder.RenameIndex(
                name: "on_order_status",
                table: "oc_on_order",
                newName: "ix_oc_on_order_on_order_status");

            migrationBuilder.RenameIndex(
                name: "keyword2",
                table: "oc_ocfilter_page",
                newName: "ix_oc_ocfilter_page_keyword");

            migrationBuilder.RenameIndex(
                name: "category_id_params",
                table: "oc_ocfilter_page",
                newName: "ix_oc_ocfilter_page_category_id_params");

            migrationBuilder.RenameIndex(
                name: "slide_value_min_slide_value_max",
                table: "oc_ocfilter_option_value_to_product",
                newName: "ix_oc_ocfilter_option_value_to_product_slide_value_min_slide_va");

            migrationBuilder.RenameIndex(
                name: "product_id",
                table: "oc_ocfilter_option_value_to_product",
                newName: "ix_oc_ocfilter_option_value_to_product_product_id");

            migrationBuilder.RenameIndex(
                name: "option_id_value_id_product_id",
                table: "oc_ocfilter_option_value_to_product",
                newName: "ix_oc_ocfilter_option_value_to_product_option_id_value_id_produ");

            migrationBuilder.RenameIndex(
                name: "option_id1",
                table: "oc_ocfilter_option_value_description",
                newName: "ix_oc_ocfilter_option_value_description_option_id");

            migrationBuilder.RenameIndex(
                name: "name5",
                table: "oc_ocfilter_option_value_description",
                newName: "ix_oc_ocfilter_option_value_description_name");

            migrationBuilder.RenameIndex(
                name: "option_id",
                table: "oc_ocfilter_option_value",
                newName: "ix_oc_ocfilter_option_value_option_id");

            migrationBuilder.RenameIndex(
                name: "keyword1",
                table: "oc_ocfilter_option_value",
                newName: "ix_oc_ocfilter_option_value_keyword");

            migrationBuilder.RenameIndex(
                name: "category_id",
                table: "oc_ocfilter_option_to_category",
                newName: "ix_oc_ocfilter_option_to_category_category_id");

            migrationBuilder.RenameIndex(
                name: "sort_order",
                table: "oc_ocfilter_option",
                newName: "ix_oc_ocfilter_option_sort_order");

            migrationBuilder.RenameIndex(
                name: "keyword",
                table: "oc_ocfilter_option",
                newName: "ix_oc_ocfilter_option_keyword");

            migrationBuilder.RenameColumn(
                name: "Schedule",
                table: "oc_novaposhta_warehouses",
                newName: "schedule");

            migrationBuilder.RenameColumn(
                name: "Reception",
                table: "oc_novaposhta_warehouses",
                newName: "reception");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "oc_novaposhta_warehouses",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "oc_novaposhta_warehouses",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "oc_novaposhta_warehouses",
                newName: "longitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "oc_novaposhta_warehouses",
                newName: "latitude");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "oc_novaposhta_warehouses",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Delivery",
                table: "oc_novaposhta_warehouses",
                newName: "delivery");

            migrationBuilder.RenameColumn(
                name: "Ref",
                table: "oc_novaposhta_warehouses",
                newName: "ref");

            migrationBuilder.RenameColumn(
                name: "WarehouseStatus",
                table: "oc_novaposhta_warehouses",
                newName: "warehouse_status");

            migrationBuilder.RenameColumn(
                name: "TypeOfWarehouse",
                table: "oc_novaposhta_warehouses",
                newName: "type_of_warehouse");

            migrationBuilder.RenameColumn(
                name: "TotalMaxWeightAllowed",
                table: "oc_novaposhta_warehouses",
                newName: "total_max_weight_allowed");

            migrationBuilder.RenameColumn(
                name: "SiteKey",
                table: "oc_novaposhta_warehouses",
                newName: "site_key");

            migrationBuilder.RenameColumn(
                name: "ShortAddressRu",
                table: "oc_novaposhta_warehouses",
                newName: "short_address_ru");

            migrationBuilder.RenameColumn(
                name: "ShortAddress",
                table: "oc_novaposhta_warehouses",
                newName: "short_address");

            migrationBuilder.RenameColumn(
                name: "PostFinance",
                table: "oc_novaposhta_warehouses",
                newName: "post_finance");

            migrationBuilder.RenameColumn(
                name: "PlaceMaxWeightAllowed",
                table: "oc_novaposhta_warehouses",
                newName: "place_max_weight_allowed");

            migrationBuilder.RenameColumn(
                name: "PaymentAccess",
                table: "oc_novaposhta_warehouses",
                newName: "payment_access");

            migrationBuilder.RenameColumn(
                name: "InternationalShipping",
                table: "oc_novaposhta_warehouses",
                newName: "international_shipping");

            migrationBuilder.RenameColumn(
                name: "DistrictCode",
                table: "oc_novaposhta_warehouses",
                newName: "district_code");

            migrationBuilder.RenameColumn(
                name: "DescriptionRu",
                table: "oc_novaposhta_warehouses",
                newName: "description_ru");

            migrationBuilder.RenameColumn(
                name: "CityRef",
                table: "oc_novaposhta_warehouses",
                newName: "city_ref");

            migrationBuilder.RenameColumn(
                name: "CityDescriptionRu",
                table: "oc_novaposhta_warehouses",
                newName: "city_description_ru");

            migrationBuilder.RenameColumn(
                name: "CityDescription",
                table: "oc_novaposhta_warehouses",
                newName: "city_description");

            migrationBuilder.RenameColumn(
                name: "CategoryOfWarehouse",
                table: "oc_novaposhta_warehouses",
                newName: "category_of_warehouse");

            migrationBuilder.RenameColumn(
                name: "BicycleParking",
                table: "oc_novaposhta_warehouses",
                newName: "bicycle_parking");

            migrationBuilder.RenameIndex(
                name: "TypeOfWarehouse",
                table: "oc_novaposhta_warehouses",
                newName: "ix_oc_novaposhta_warehouses_type_of_warehouse");

            migrationBuilder.RenameIndex(
                name: "SiteKey",
                table: "oc_novaposhta_warehouses",
                newName: "ix_oc_novaposhta_warehouses_site_key");

            migrationBuilder.RenameIndex(
                name: "CityRef",
                table: "oc_novaposhta_warehouses",
                newName: "ix_oc_novaposhta_warehouses_city_ref");

            migrationBuilder.RenameIndex(
                name: "type",
                table: "oc_novaposhta_references",
                newName: "ix_oc_novaposhta_references_type");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "oc_novaposhta_cities",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Delivery7",
                table: "oc_novaposhta_cities",
                newName: "delivery7");

            migrationBuilder.RenameColumn(
                name: "Delivery6",
                table: "oc_novaposhta_cities",
                newName: "delivery6");

            migrationBuilder.RenameColumn(
                name: "Delivery5",
                table: "oc_novaposhta_cities",
                newName: "delivery5");

            migrationBuilder.RenameColumn(
                name: "Delivery4",
                table: "oc_novaposhta_cities",
                newName: "delivery4");

            migrationBuilder.RenameColumn(
                name: "Delivery3",
                table: "oc_novaposhta_cities",
                newName: "delivery3");

            migrationBuilder.RenameColumn(
                name: "Delivery2",
                table: "oc_novaposhta_cities",
                newName: "delivery2");

            migrationBuilder.RenameColumn(
                name: "Delivery1",
                table: "oc_novaposhta_cities",
                newName: "delivery1");

            migrationBuilder.RenameColumn(
                name: "Conglomerates",
                table: "oc_novaposhta_cities",
                newName: "conglomerates");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "oc_novaposhta_cities",
                newName: "area");

            migrationBuilder.RenameColumn(
                name: "Ref",
                table: "oc_novaposhta_cities",
                newName: "ref");

            migrationBuilder.RenameColumn(
                name: "SpecialCashCheck",
                table: "oc_novaposhta_cities",
                newName: "special_cash_check");

            migrationBuilder.RenameColumn(
                name: "SettlementTypeDescriptionRu",
                table: "oc_novaposhta_cities",
                newName: "settlement_type_description_ru");

            migrationBuilder.RenameColumn(
                name: "SettlementTypeDescription",
                table: "oc_novaposhta_cities",
                newName: "settlement_type_description");

            migrationBuilder.RenameColumn(
                name: "SettlementType",
                table: "oc_novaposhta_cities",
                newName: "settlement_type");

            migrationBuilder.RenameColumn(
                name: "PreventEntryNewStreetsUser",
                table: "oc_novaposhta_cities",
                newName: "prevent_entry_new_streets_user");

            migrationBuilder.RenameColumn(
                name: "IsBranch",
                table: "oc_novaposhta_cities",
                newName: "is_branch");

            migrationBuilder.RenameColumn(
                name: "DescriptionRu",
                table: "oc_novaposhta_cities",
                newName: "description_ru");

            migrationBuilder.RenameIndex(
                name: "SettlementType",
                table: "oc_novaposhta_cities",
                newName: "ix_oc_novaposhta_cities_settlement_type");

            migrationBuilder.RenameIndex(
                name: "CityID",
                table: "oc_novaposhta_cities",
                newName: "ix_oc_novaposhta_cities_city_id");

            migrationBuilder.RenameIndex(
                name: "Area",
                table: "oc_novaposhta_cities",
                newName: "ix_oc_novaposhta_cities_area");

            migrationBuilder.RenameIndex(
                name: "menu_id",
                table: "oc_menu_module",
                newName: "ix_oc_menu_module_menu_id");

            migrationBuilder.RenameIndex(
                name: "losted_id",
                table: "oc_losted_cart_log",
                newName: "ix_oc_losted_cart_log_losted_id");

            migrationBuilder.RenameIndex(
                name: "session_id",
                table: "oc_losted_cart",
                newName: "ix_oc_losted_cart_session_id");

            migrationBuilder.RenameIndex(
                name: "name4",
                table: "oc_location",
                newName: "ix_oc_location_name");

            migrationBuilder.RenameIndex(
                name: "name3",
                table: "oc_language",
                newName: "ix_oc_language_name");

            migrationBuilder.RenameIndex(
                name: "kd_code",
                table: "oc_kd_warehouse_code",
                newName: "ix_oc_kd_warehouse_code_kd_code");

            migrationBuilder.RenameIndex(
                name: "ip2",
                table: "oc_customer_login",
                newName: "ix_oc_customer_login_ip");

            migrationBuilder.RenameIndex(
                name: "email6",
                table: "oc_customer_login",
                newName: "ix_oc_customer_login_email");

            migrationBuilder.RenameIndex(
                name: "ip1",
                table: "oc_customer_ip",
                newName: "ix_oc_customer_ip_ip");

            migrationBuilder.RenameIndex(
                name: "send_id4",
                table: "oc_contacts_views",
                newName: "ix_oc_contacts_views_send_id");

            migrationBuilder.RenameIndex(
                name: "send_id3",
                table: "oc_contacts_unsubscribe",
                newName: "ix_oc_contacts_unsubscribe_send_id");

            migrationBuilder.RenameIndex(
                name: "email5",
                table: "oc_contacts_unsubscribe",
                newName: "ix_oc_contacts_unsubscribe_email");

            migrationBuilder.RenameIndex(
                name: "revmail_id",
                table: "oc_contacts_reqreview_product",
                newName: "ix_oc_contacts_reqreview_product_revmail_id");

            migrationBuilder.RenameIndex(
                name: "email4",
                table: "oc_contacts_reqreview_mails",
                newName: "ix_oc_contacts_reqreview_mails_email");

            migrationBuilder.RenameIndex(
                name: "group_id",
                table: "oc_contacts_newsletter",
                newName: "ix_oc_contacts_newsletter_group_id");

            migrationBuilder.RenameIndex(
                name: "email3",
                table: "oc_contacts_newsletter",
                newName: "ix_oc_contacts_newsletter_email");

            migrationBuilder.RenameIndex(
                name: "customer_id1",
                table: "oc_contacts_newsletter",
                newName: "ix_oc_contacts_newsletter_customer_id");

            migrationBuilder.RenameIndex(
                name: "email2",
                table: "oc_contacts_cron_emails",
                newName: "ix_oc_contacts_cron_emails_email");

            migrationBuilder.RenameIndex(
                name: "cron_id2",
                table: "oc_contacts_cron_emails",
                newName: "ix_oc_contacts_cron_emails_cron_id");

            migrationBuilder.RenameIndex(
                name: "check_status",
                table: "oc_contacts_cron_emails",
                newName: "ix_oc_contacts_cron_emails_check_status");

            migrationBuilder.RenameIndex(
                name: "cron_id1",
                table: "oc_contacts_cron_data",
                newName: "ix_oc_contacts_cron_data_cron_id");

            migrationBuilder.RenameIndex(
                name: "date_send",
                table: "oc_contacts_count_mails",
                newName: "ix_oc_contacts_count_mails_date_send");

            migrationBuilder.RenameIndex(
                name: "send_id2",
                table: "oc_contacts_clicks",
                newName: "ix_oc_contacts_clicks_send_id");

            migrationBuilder.RenameIndex(
                name: "send_id1",
                table: "oc_contacts_cache_product",
                newName: "ix_oc_contacts_cache_product_send_id");

            migrationBuilder.RenameIndex(
                name: "cron_id",
                table: "oc_contacts_cache_product",
                newName: "ix_oc_contacts_cache_product_cron_id");

            migrationBuilder.RenameIndex(
                name: "send_id",
                table: "oc_contacts_cache_email",
                newName: "ix_oc_contacts_cache_email_send_id");

            migrationBuilder.RenameIndex(
                name: "email1",
                table: "oc_contacts_cache_email",
                newName: "ix_oc_contacts_cache_email_email");

            migrationBuilder.RenameIndex(
                name: "prom_category_id",
                table: "oc_category_to_prom_category",
                newName: "ix_oc_category_to_prom_category_prom_category_id");

            migrationBuilder.RenameIndex(
                name: "name2",
                table: "oc_category_description",
                newName: "ix_oc_category_description_name");

            migrationBuilder.RenameIndex(
                name: "parent_id",
                table: "oc_category",
                newName: "ix_oc_category_parent_id");

            migrationBuilder.RenameIndex(
                name: "nix_supplier_category_id",
                table: "oc_category",
                newName: "ix_oc_category_nix_supplier_category_id");

            migrationBuilder.RenameIndex(
                name: "cart_id",
                table: "oc_cart",
                newName: "ix_oc_cart_api_id_customer_id_session_id_product_id_recurring_id");

            migrationBuilder.RenameIndex(
                name: "name1",
                table: "oc_attribute_template_description",
                newName: "ix_oc_attribute_template_description_name");

            migrationBuilder.RenameIndex(
                name: "name",
                table: "oc_attribute_enumeration_description",
                newName: "ix_oc_attribute_enumeration_description_name");

            migrationBuilder.RenameIndex(
                name: "pointer",
                table: "oc_agoo_signer",
                newName: "ix_oc_agoo_signer_pointer");

            migrationBuilder.RenameIndex(
                name: "id",
                table: "oc_agoo_signer",
                newName: "ix_oc_agoo_signer_id");

            migrationBuilder.RenameIndex(
                name: "date",
                table: "oc_agoo_signer",
                newName: "ix_oc_agoo_signer_date");

            migrationBuilder.RenameIndex(
                name: "customer_id",
                table: "oc_agoo_signer",
                newName: "ix_oc_agoo_signer_customer_id");

            migrationBuilder.RenameIndex(
                name: "ip",
                table: "oc_affiliate_login",
                newName: "ix_oc_affiliate_login_ip");

            migrationBuilder.RenameIndex(
                name: "email",
                table: "oc_affiliate_login",
                newName: "ix_oc_affiliate_login_email");

            migrationBuilder.RenameIndex(
                name: "customer_id",
                table: "oc_address",
                newName: "ix_oc_address_customer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "ix_oc_url_alias_blog_query",
                table: "oc_url_alias_blog",
                newName: "query1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_url_alias_blog_language_id",
                table: "oc_url_alias_blog",
                newName: "language_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_url_alias_blog_keyword",
                table: "oc_url_alias_blog",
                newName: "keyword4");

            migrationBuilder.RenameIndex(
                name: "ix_oc_url_alias_query",
                table: "oc_url_alias",
                newName: "query");

            migrationBuilder.RenameIndex(
                name: "ix_oc_url_alias_keyword",
                table: "oc_url_alias",
                newName: "keyword3");

            migrationBuilder.RenameIndex(
                name: "ix_oc_uni_banner_in_category_to_category_category_id",
                table: "oc_uni_banner_in_category_to_category",
                newName: "category_id2");

            migrationBuilder.RenameIndex(
                name: "ix_oc_setting_store_id",
                table: "oc_setting",
                newName: "store_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_setting_serialized",
                table: "oc_setting",
                newName: "serialized");

            migrationBuilder.RenameIndex(
                name: "ix_oc_setting_key",
                table: "oc_setting",
                newName: "key");

            migrationBuilder.RenameIndex(
                name: "ix_oc_seo_tags_generator_category_setting_category_id",
                table: "oc_seo_tags_generator_category_setting",
                newName: "category_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_seo_tags_generator_category_copy_copy_category_id",
                table: "oc_seo_tags_generator_category_copy",
                newName: "copy_category_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_seo_tags_generator_language_id",
                table: "oc_seo_tags_generator",
                newName: "language_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_seo_tags_generator_key",
                table: "oc_seo_tags_generator",
                newName: "key");

            migrationBuilder.RenameIndex(
                name: "ix_oc_seo_tags_generator_category_id",
                table: "oc_seo_tags_generator",
                newName: "category_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_review_product_id",
                table: "oc_review",
                newName: "product_id8");

            migrationBuilder.RenameIndex(
                name: "ix_oc_prom_category_description_name",
                table: "oc_prom_category_description",
                newName: "name7");

            migrationBuilder.RenameIndex(
                name: "ix_oc_prom_category_parent_id",
                table: "oc_prom_category",
                newName: "parent_id1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_to_supplier_supplier_id",
                table: "oc_product_to_supplier",
                newName: "supplier_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_to_prom_product_prom_product_id",
                table: "oc_product_to_prom_product",
                newName: "prom_product_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_to_category_category_id",
                table: "oc_product_to_category",
                newName: "category_id1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_special_product_id",
                table: "oc_product_special",
                newName: "product_id7");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_reward_product_id",
                table: "oc_product_reward",
                newName: "product_id6");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_reward_customer_group_id",
                table: "oc_product_reward",
                newName: "customer_group_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_option_value_subtract",
                table: "oc_product_option_value",
                newName: "subtract");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_option_value_quantity",
                table: "oc_product_option_value",
                newName: "quantity");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_option_value_product_option_id",
                table: "oc_product_option_value",
                newName: "product_option_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_option_value_product_id",
                table: "oc_product_option_value",
                newName: "product_id5");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_option_value_option_value_id",
                table: "oc_product_option_value",
                newName: "option_value_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_option_value_option_id",
                table: "oc_product_option_value",
                newName: "option_id3");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_option_product_id",
                table: "oc_product_option",
                newName: "product_id4");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_option_option_id",
                table: "oc_product_option",
                newName: "option_id2");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_image_sort_order",
                table: "oc_product_image",
                newName: "sort_order1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_image_product_id",
                table: "oc_product_image",
                newName: "product_id3");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_discount_product_id",
                table: "oc_product_discount",
                newName: "product_id2");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_description_name",
                table: "oc_product_description",
                newName: "name6");

            migrationBuilder.RenameIndex(
                name: "ix_oc_product_nix_supplier_product_id",
                table: "oc_product",
                newName: "nix_supplier_product_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_order_total_order_id",
                table: "oc_order_total",
                newName: "order_id3");

            migrationBuilder.RenameIndex(
                name: "ix_oc_order_product_product_id",
                table: "oc_order_product",
                newName: "product_id1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_order_product_order_id",
                table: "oc_order_product",
                newName: "order_id2");

            migrationBuilder.RenameIndex(
                name: "ix_oc_order_permissions_order_id",
                table: "oc_order_permissions",
                newName: "order_id1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_order_history_order_id",
                table: "oc_order_history",
                newName: "order_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_order_order_status_id",
                table: "oc_order",
                newName: "order_status_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_order_customer_id",
                table: "oc_order",
                newName: "customer_id2");

            migrationBuilder.RenameIndex(
                name: "ix_oc_on_order_on_order_status",
                table: "oc_on_order",
                newName: "on_order_status");

            migrationBuilder.RenameIndex(
                name: "ix_oc_ocfilter_page_keyword",
                table: "oc_ocfilter_page",
                newName: "keyword2");

            migrationBuilder.RenameIndex(
                name: "ix_oc_ocfilter_page_category_id_params",
                table: "oc_ocfilter_page",
                newName: "category_id_params");

            migrationBuilder.RenameIndex(
                name: "ix_oc_ocfilter_option_value_to_product_slide_value_min_slide_va",
                table: "oc_ocfilter_option_value_to_product",
                newName: "slide_value_min_slide_value_max");

            migrationBuilder.RenameIndex(
                name: "ix_oc_ocfilter_option_value_to_product_product_id",
                table: "oc_ocfilter_option_value_to_product",
                newName: "product_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_ocfilter_option_value_to_product_option_id_value_id_produ",
                table: "oc_ocfilter_option_value_to_product",
                newName: "option_id_value_id_product_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_ocfilter_option_value_description_option_id",
                table: "oc_ocfilter_option_value_description",
                newName: "option_id1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_ocfilter_option_value_description_name",
                table: "oc_ocfilter_option_value_description",
                newName: "name5");

            migrationBuilder.RenameIndex(
                name: "ix_oc_ocfilter_option_value_option_id",
                table: "oc_ocfilter_option_value",
                newName: "option_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_ocfilter_option_value_keyword",
                table: "oc_ocfilter_option_value",
                newName: "keyword1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_ocfilter_option_to_category_category_id",
                table: "oc_ocfilter_option_to_category",
                newName: "category_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_ocfilter_option_sort_order",
                table: "oc_ocfilter_option",
                newName: "sort_order");

            migrationBuilder.RenameIndex(
                name: "ix_oc_ocfilter_option_keyword",
                table: "oc_ocfilter_option",
                newName: "keyword");

            migrationBuilder.RenameColumn(
                name: "schedule",
                table: "oc_novaposhta_warehouses",
                newName: "Schedule");

            migrationBuilder.RenameColumn(
                name: "reception",
                table: "oc_novaposhta_warehouses",
                newName: "Reception");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "oc_novaposhta_warehouses",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "oc_novaposhta_warehouses",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "longitude",
                table: "oc_novaposhta_warehouses",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "latitude",
                table: "oc_novaposhta_warehouses",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "oc_novaposhta_warehouses",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "delivery",
                table: "oc_novaposhta_warehouses",
                newName: "Delivery");

            migrationBuilder.RenameColumn(
                name: "ref",
                table: "oc_novaposhta_warehouses",
                newName: "Ref");

            migrationBuilder.RenameColumn(
                name: "warehouse_status",
                table: "oc_novaposhta_warehouses",
                newName: "WarehouseStatus");

            migrationBuilder.RenameColumn(
                name: "type_of_warehouse",
                table: "oc_novaposhta_warehouses",
                newName: "TypeOfWarehouse");

            migrationBuilder.RenameColumn(
                name: "total_max_weight_allowed",
                table: "oc_novaposhta_warehouses",
                newName: "TotalMaxWeightAllowed");

            migrationBuilder.RenameColumn(
                name: "site_key",
                table: "oc_novaposhta_warehouses",
                newName: "SiteKey");

            migrationBuilder.RenameColumn(
                name: "short_address_ru",
                table: "oc_novaposhta_warehouses",
                newName: "ShortAddressRu");

            migrationBuilder.RenameColumn(
                name: "short_address",
                table: "oc_novaposhta_warehouses",
                newName: "ShortAddress");

            migrationBuilder.RenameColumn(
                name: "post_finance",
                table: "oc_novaposhta_warehouses",
                newName: "PostFinance");

            migrationBuilder.RenameColumn(
                name: "place_max_weight_allowed",
                table: "oc_novaposhta_warehouses",
                newName: "PlaceMaxWeightAllowed");

            migrationBuilder.RenameColumn(
                name: "payment_access",
                table: "oc_novaposhta_warehouses",
                newName: "PaymentAccess");

            migrationBuilder.RenameColumn(
                name: "international_shipping",
                table: "oc_novaposhta_warehouses",
                newName: "InternationalShipping");

            migrationBuilder.RenameColumn(
                name: "district_code",
                table: "oc_novaposhta_warehouses",
                newName: "DistrictCode");

            migrationBuilder.RenameColumn(
                name: "description_ru",
                table: "oc_novaposhta_warehouses",
                newName: "DescriptionRu");

            migrationBuilder.RenameColumn(
                name: "city_ref",
                table: "oc_novaposhta_warehouses",
                newName: "CityRef");

            migrationBuilder.RenameColumn(
                name: "city_description_ru",
                table: "oc_novaposhta_warehouses",
                newName: "CityDescriptionRu");

            migrationBuilder.RenameColumn(
                name: "city_description",
                table: "oc_novaposhta_warehouses",
                newName: "CityDescription");

            migrationBuilder.RenameColumn(
                name: "category_of_warehouse",
                table: "oc_novaposhta_warehouses",
                newName: "CategoryOfWarehouse");

            migrationBuilder.RenameColumn(
                name: "bicycle_parking",
                table: "oc_novaposhta_warehouses",
                newName: "BicycleParking");

            migrationBuilder.RenameIndex(
                name: "ix_oc_novaposhta_warehouses_type_of_warehouse",
                table: "oc_novaposhta_warehouses",
                newName: "TypeOfWarehouse");

            migrationBuilder.RenameIndex(
                name: "ix_oc_novaposhta_warehouses_site_key",
                table: "oc_novaposhta_warehouses",
                newName: "SiteKey");

            migrationBuilder.RenameIndex(
                name: "ix_oc_novaposhta_warehouses_city_ref",
                table: "oc_novaposhta_warehouses",
                newName: "CityRef");

            migrationBuilder.RenameIndex(
                name: "ix_oc_novaposhta_references_type",
                table: "oc_novaposhta_references",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "oc_novaposhta_cities",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "delivery7",
                table: "oc_novaposhta_cities",
                newName: "Delivery7");

            migrationBuilder.RenameColumn(
                name: "delivery6",
                table: "oc_novaposhta_cities",
                newName: "Delivery6");

            migrationBuilder.RenameColumn(
                name: "delivery5",
                table: "oc_novaposhta_cities",
                newName: "Delivery5");

            migrationBuilder.RenameColumn(
                name: "delivery4",
                table: "oc_novaposhta_cities",
                newName: "Delivery4");

            migrationBuilder.RenameColumn(
                name: "delivery3",
                table: "oc_novaposhta_cities",
                newName: "Delivery3");

            migrationBuilder.RenameColumn(
                name: "delivery2",
                table: "oc_novaposhta_cities",
                newName: "Delivery2");

            migrationBuilder.RenameColumn(
                name: "delivery1",
                table: "oc_novaposhta_cities",
                newName: "Delivery1");

            migrationBuilder.RenameColumn(
                name: "conglomerates",
                table: "oc_novaposhta_cities",
                newName: "Conglomerates");

            migrationBuilder.RenameColumn(
                name: "area",
                table: "oc_novaposhta_cities",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "ref",
                table: "oc_novaposhta_cities",
                newName: "Ref");

            migrationBuilder.RenameColumn(
                name: "special_cash_check",
                table: "oc_novaposhta_cities",
                newName: "SpecialCashCheck");

            migrationBuilder.RenameColumn(
                name: "settlement_type_description_ru",
                table: "oc_novaposhta_cities",
                newName: "SettlementTypeDescriptionRu");

            migrationBuilder.RenameColumn(
                name: "settlement_type_description",
                table: "oc_novaposhta_cities",
                newName: "SettlementTypeDescription");

            migrationBuilder.RenameColumn(
                name: "settlement_type",
                table: "oc_novaposhta_cities",
                newName: "SettlementType");

            migrationBuilder.RenameColumn(
                name: "prevent_entry_new_streets_user",
                table: "oc_novaposhta_cities",
                newName: "PreventEntryNewStreetsUser");

            migrationBuilder.RenameColumn(
                name: "is_branch",
                table: "oc_novaposhta_cities",
                newName: "IsBranch");

            migrationBuilder.RenameColumn(
                name: "description_ru",
                table: "oc_novaposhta_cities",
                newName: "DescriptionRu");

            migrationBuilder.RenameIndex(
                name: "ix_oc_novaposhta_cities_settlement_type",
                table: "oc_novaposhta_cities",
                newName: "SettlementType");

            migrationBuilder.RenameIndex(
                name: "ix_oc_novaposhta_cities_city_id",
                table: "oc_novaposhta_cities",
                newName: "CityID");

            migrationBuilder.RenameIndex(
                name: "ix_oc_novaposhta_cities_area",
                table: "oc_novaposhta_cities",
                newName: "Area");

            migrationBuilder.RenameIndex(
                name: "ix_oc_menu_module_menu_id",
                table: "oc_menu_module",
                newName: "menu_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_losted_cart_log_losted_id",
                table: "oc_losted_cart_log",
                newName: "losted_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_losted_cart_session_id",
                table: "oc_losted_cart",
                newName: "session_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_location_name",
                table: "oc_location",
                newName: "name4");

            migrationBuilder.RenameIndex(
                name: "ix_oc_language_name",
                table: "oc_language",
                newName: "name3");

            migrationBuilder.RenameIndex(
                name: "ix_oc_kd_warehouse_code_kd_code",
                table: "oc_kd_warehouse_code",
                newName: "kd_code");

            migrationBuilder.RenameIndex(
                name: "ix_oc_customer_login_ip",
                table: "oc_customer_login",
                newName: "ip2");

            migrationBuilder.RenameIndex(
                name: "ix_oc_customer_login_email",
                table: "oc_customer_login",
                newName: "email6");

            migrationBuilder.RenameIndex(
                name: "ix_oc_customer_ip_ip",
                table: "oc_customer_ip",
                newName: "ip1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_views_send_id",
                table: "oc_contacts_views",
                newName: "send_id4");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_unsubscribe_send_id",
                table: "oc_contacts_unsubscribe",
                newName: "send_id3");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_unsubscribe_email",
                table: "oc_contacts_unsubscribe",
                newName: "email5");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_reqreview_product_revmail_id",
                table: "oc_contacts_reqreview_product",
                newName: "revmail_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_reqreview_mails_email",
                table: "oc_contacts_reqreview_mails",
                newName: "email4");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_newsletter_group_id",
                table: "oc_contacts_newsletter",
                newName: "group_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_newsletter_email",
                table: "oc_contacts_newsletter",
                newName: "email3");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_newsletter_customer_id",
                table: "oc_contacts_newsletter",
                newName: "customer_id1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_cron_emails_email",
                table: "oc_contacts_cron_emails",
                newName: "email2");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_cron_emails_cron_id",
                table: "oc_contacts_cron_emails",
                newName: "cron_id2");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_cron_emails_check_status",
                table: "oc_contacts_cron_emails",
                newName: "check_status");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_cron_data_cron_id",
                table: "oc_contacts_cron_data",
                newName: "cron_id1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_count_mails_date_send",
                table: "oc_contacts_count_mails",
                newName: "date_send");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_clicks_send_id",
                table: "oc_contacts_clicks",
                newName: "send_id2");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_cache_product_send_id",
                table: "oc_contacts_cache_product",
                newName: "send_id1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_cache_product_cron_id",
                table: "oc_contacts_cache_product",
                newName: "cron_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_cache_email_send_id",
                table: "oc_contacts_cache_email",
                newName: "send_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_contacts_cache_email_email",
                table: "oc_contacts_cache_email",
                newName: "email1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_category_to_prom_category_prom_category_id",
                table: "oc_category_to_prom_category",
                newName: "prom_category_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_category_description_name",
                table: "oc_category_description",
                newName: "name2");

            migrationBuilder.RenameIndex(
                name: "ix_oc_category_parent_id",
                table: "oc_category",
                newName: "parent_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_category_nix_supplier_category_id",
                table: "oc_category",
                newName: "nix_supplier_category_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_cart_api_id_customer_id_session_id_product_id_recurring_id",
                table: "oc_cart",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_attribute_template_description_name",
                table: "oc_attribute_template_description",
                newName: "name1");

            migrationBuilder.RenameIndex(
                name: "ix_oc_attribute_enumeration_description_name",
                table: "oc_attribute_enumeration_description",
                newName: "name");

            migrationBuilder.RenameIndex(
                name: "ix_oc_agoo_signer_pointer",
                table: "oc_agoo_signer",
                newName: "pointer");

            migrationBuilder.RenameIndex(
                name: "ix_oc_agoo_signer_id",
                table: "oc_agoo_signer",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_agoo_signer_date",
                table: "oc_agoo_signer",
                newName: "date");

            migrationBuilder.RenameIndex(
                name: "ix_oc_agoo_signer_customer_id",
                table: "oc_agoo_signer",
                newName: "customer_id");

            migrationBuilder.RenameIndex(
                name: "ix_oc_affiliate_login_ip",
                table: "oc_affiliate_login",
                newName: "ip");

            migrationBuilder.RenameIndex(
                name: "ix_oc_affiliate_login_email",
                table: "oc_affiliate_login",
                newName: "email");

            migrationBuilder.RenameIndex(
                name: "ix_oc_address_customer_id",
                table: "oc_address",
                newName: "customer_id");
        }
    }
}
