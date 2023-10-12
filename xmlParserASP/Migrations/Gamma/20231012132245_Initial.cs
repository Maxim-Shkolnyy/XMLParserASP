using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace xmlParserASP.Migrations.Gamma
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "oc_address");

            migrationBuilder.DropTable(
                name: "oc_address_simple_fields");

            migrationBuilder.DropTable(
                name: "oc_affiliate");

            migrationBuilder.DropTable(
                name: "oc_affiliate_activity");

            migrationBuilder.DropTable(
                name: "oc_affiliate_login");

            migrationBuilder.DropTable(
                name: "oc_affiliate_transaction");

            migrationBuilder.DropTable(
                name: "oc_agoo_signer");

            migrationBuilder.DropTable(
                name: "oc_api");

            migrationBuilder.DropTable(
                name: "oc_api_ip");

            migrationBuilder.DropTable(
                name: "oc_api_session");

            migrationBuilder.DropTable(
                name: "oc_attributable_to_attribute");

            migrationBuilder.DropTable(
                name: "oc_attribute");

            migrationBuilder.DropTable(
                name: "oc_attribute_description");

            migrationBuilder.DropTable(
                name: "oc_attribute_enum");

            migrationBuilder.DropTable(
                name: "oc_attribute_enum_description");

            migrationBuilder.DropTable(
                name: "oc_attribute_enumeration");

            migrationBuilder.DropTable(
                name: "oc_attribute_enumeration_description");

            migrationBuilder.DropTable(
                name: "oc_attribute_group");

            migrationBuilder.DropTable(
                name: "oc_attribute_group_description");

            migrationBuilder.DropTable(
                name: "oc_attribute_template");

            migrationBuilder.DropTable(
                name: "oc_attribute_template_attribute");

            migrationBuilder.DropTable(
                name: "oc_attribute_template_description");

            migrationBuilder.DropTable(
                name: "oc_attribute_template_to_attribute_to_attributable");

            migrationBuilder.DropTable(
                name: "oc_attribute_unit");

            migrationBuilder.DropTable(
                name: "oc_attribute_unit_description");

            migrationBuilder.DropTable(
                name: "oc_banner");

            migrationBuilder.DropTable(
                name: "oc_banner_image");

            migrationBuilder.DropTable(
                name: "oc_cart");

            migrationBuilder.DropTable(
                name: "oc_category");

            migrationBuilder.DropTable(
                name: "oc_category_description");

            migrationBuilder.DropTable(
                name: "oc_category_filter");

            migrationBuilder.DropTable(
                name: "oc_category_path");

            migrationBuilder.DropTable(
                name: "oc_category_to_layout");

            migrationBuilder.DropTable(
                name: "oc_category_to_prom_category");

            migrationBuilder.DropTable(
                name: "oc_category_to_store");

            migrationBuilder.DropTable(
                name: "oc_contacts_cache_email");

            migrationBuilder.DropTable(
                name: "oc_contacts_cache_product");

            migrationBuilder.DropTable(
                name: "oc_contacts_cache_send");

            migrationBuilder.DropTable(
                name: "oc_contacts_clicks");

            migrationBuilder.DropTable(
                name: "oc_contacts_count_mails");

            migrationBuilder.DropTable(
                name: "oc_contacts_cron");

            migrationBuilder.DropTable(
                name: "oc_contacts_cron_data");

            migrationBuilder.DropTable(
                name: "oc_contacts_cron_emails");

            migrationBuilder.DropTable(
                name: "oc_contacts_cron_history");

            migrationBuilder.DropTable(
                name: "oc_contacts_group");

            migrationBuilder.DropTable(
                name: "oc_contacts_newsletter");

            migrationBuilder.DropTable(
                name: "oc_contacts_reqreview_mails");

            migrationBuilder.DropTable(
                name: "oc_contacts_reqreview_product");

            migrationBuilder.DropTable(
                name: "oc_contacts_template");

            migrationBuilder.DropTable(
                name: "oc_contacts_unsubscribe");

            migrationBuilder.DropTable(
                name: "oc_contacts_views");

            migrationBuilder.DropTable(
                name: "oc_country");

            migrationBuilder.DropTable(
                name: "oc_coupon");

            migrationBuilder.DropTable(
                name: "oc_coupon_category");

            migrationBuilder.DropTable(
                name: "oc_coupon_history");

            migrationBuilder.DropTable(
                name: "oc_coupon_product");

            migrationBuilder.DropTable(
                name: "oc_currency");

            migrationBuilder.DropTable(
                name: "oc_custom_field");

            migrationBuilder.DropTable(
                name: "oc_custom_field_customer_group");

            migrationBuilder.DropTable(
                name: "oc_custom_field_description");

            migrationBuilder.DropTable(
                name: "oc_custom_field_value");

            migrationBuilder.DropTable(
                name: "oc_custom_field_value_description");

            migrationBuilder.DropTable(
                name: "oc_custom_menu");

            migrationBuilder.DropTable(
                name: "oc_custom_menu_description");

            migrationBuilder.DropTable(
                name: "oc_customer");

            migrationBuilder.DropTable(
                name: "oc_customer_activity");

            migrationBuilder.DropTable(
                name: "oc_customer_group");

            migrationBuilder.DropTable(
                name: "oc_customer_group_description");

            migrationBuilder.DropTable(
                name: "oc_customer_history");

            migrationBuilder.DropTable(
                name: "oc_customer_ip");

            migrationBuilder.DropTable(
                name: "oc_customer_login");

            migrationBuilder.DropTable(
                name: "oc_customer_online");

            migrationBuilder.DropTable(
                name: "oc_customer_reward");

            migrationBuilder.DropTable(
                name: "oc_customer_search");

            migrationBuilder.DropTable(
                name: "oc_customer_simple_fields");

            migrationBuilder.DropTable(
                name: "oc_customer_transaction");

            migrationBuilder.DropTable(
                name: "oc_customer_wishlist");

            migrationBuilder.DropTable(
                name: "oc_download");

            migrationBuilder.DropTable(
                name: "oc_download_description");

            migrationBuilder.DropTable(
                name: "oc_event");

            migrationBuilder.DropTable(
                name: "oc_extension");

            migrationBuilder.DropTable(
                name: "oc_filter");

            migrationBuilder.DropTable(
                name: "oc_filter_description");

            migrationBuilder.DropTable(
                name: "oc_filter_group");

            migrationBuilder.DropTable(
                name: "oc_filter_group_description");

            migrationBuilder.DropTable(
                name: "oc_geo_zone");

            migrationBuilder.DropTable(
                name: "oc_information");

            migrationBuilder.DropTable(
                name: "oc_information_description");

            migrationBuilder.DropTable(
                name: "oc_information_to_layout");

            migrationBuilder.DropTable(
                name: "oc_information_to_store");

            migrationBuilder.DropTable(
                name: "oc_kd_warehouse_code");

            migrationBuilder.DropTable(
                name: "oc_key");

            migrationBuilder.DropTable(
                name: "oc_language");

            migrationBuilder.DropTable(
                name: "oc_layout");

            migrationBuilder.DropTable(
                name: "oc_layout_module");

            migrationBuilder.DropTable(
                name: "oc_layout_route");

            migrationBuilder.DropTable(
                name: "oc_length_class");

            migrationBuilder.DropTable(
                name: "oc_length_class_description");

            migrationBuilder.DropTable(
                name: "oc_location");

            migrationBuilder.DropTable(
                name: "oc_losted_cart");

            migrationBuilder.DropTable(
                name: "oc_losted_cart_log");

            migrationBuilder.DropTable(
                name: "oc_manufacturer");

            migrationBuilder.DropTable(
                name: "oc_manufacturer_description");

            migrationBuilder.DropTable(
                name: "oc_manufacturer_to_store");

            migrationBuilder.DropTable(
                name: "oc_marketing");

            migrationBuilder.DropTable(
                name: "oc_menu");

            migrationBuilder.DropTable(
                name: "oc_menu_description");

            migrationBuilder.DropTable(
                name: "oc_menu_module");

            migrationBuilder.DropTable(
                name: "oc_modification");

            migrationBuilder.DropTable(
                name: "oc_module");

            migrationBuilder.DropTable(
                name: "oc_multi_xml");

            migrationBuilder.DropTable(
                name: "oc_multiplicity_product");

            migrationBuilder.DropTable(
                name: "oc_nix_suppliers");

            migrationBuilder.DropTable(
                name: "oc_novaposhta_cities");

            migrationBuilder.DropTable(
                name: "oc_novaposhta_references");

            migrationBuilder.DropTable(
                name: "oc_novaposhta_warehouses");

            migrationBuilder.DropTable(
                name: "oc_ocfilter_href");

            migrationBuilder.DropTable(
                name: "oc_ocfilter_option");

            migrationBuilder.DropTable(
                name: "oc_ocfilter_option_description");

            migrationBuilder.DropTable(
                name: "oc_ocfilter_option_to_category");

            migrationBuilder.DropTable(
                name: "oc_ocfilter_option_to_store");

            migrationBuilder.DropTable(
                name: "oc_ocfilter_option_value");

            migrationBuilder.DropTable(
                name: "oc_ocfilter_option_value_description");

            migrationBuilder.DropTable(
                name: "oc_ocfilter_option_value_to_product");

            migrationBuilder.DropTable(
                name: "oc_ocfilter_option_value_to_product_description");

            migrationBuilder.DropTable(
                name: "oc_ocfilter_page");

            migrationBuilder.DropTable(
                name: "oc_ocfilter_page_description");

            migrationBuilder.DropTable(
                name: "oc_on_order");

            migrationBuilder.DropTable(
                name: "oc_option");

            migrationBuilder.DropTable(
                name: "oc_option_description");

            migrationBuilder.DropTable(
                name: "oc_option_value");

            migrationBuilder.DropTable(
                name: "oc_option_value_description");

            migrationBuilder.DropTable(
                name: "oc_order");

            migrationBuilder.DropTable(
                name: "oc_order_custom_field");

            migrationBuilder.DropTable(
                name: "oc_order_history");

            migrationBuilder.DropTable(
                name: "oc_order_option");

            migrationBuilder.DropTable(
                name: "oc_order_permissions");

            migrationBuilder.DropTable(
                name: "oc_order_product");

            migrationBuilder.DropTable(
                name: "oc_order_recurring");

            migrationBuilder.DropTable(
                name: "oc_order_recurring_transaction");

            migrationBuilder.DropTable(
                name: "oc_order_simple_fields");

            migrationBuilder.DropTable(
                name: "oc_order_status");

            migrationBuilder.DropTable(
                name: "oc_order_total");

            migrationBuilder.DropTable(
                name: "oc_order_voucher");

            migrationBuilder.DropTable(
                name: "oc_product");

            migrationBuilder.DropTable(
                name: "oc_product_attribute");

            migrationBuilder.DropTable(
                name: "oc_product_description");

            migrationBuilder.DropTable(
                name: "oc_product_discount");

            migrationBuilder.DropTable(
                name: "oc_product_filter");

            migrationBuilder.DropTable(
                name: "oc_product_image");

            migrationBuilder.DropTable(
                name: "oc_product_option");

            migrationBuilder.DropTable(
                name: "oc_product_option_value");

            migrationBuilder.DropTable(
                name: "oc_product_owner_priority");

            migrationBuilder.DropTable(
                name: "oc_product_recurring");

            migrationBuilder.DropTable(
                name: "oc_product_related");

            migrationBuilder.DropTable(
                name: "oc_product_reward");

            migrationBuilder.DropTable(
                name: "oc_product_special");

            migrationBuilder.DropTable(
                name: "oc_product_to_attribute_reserved");

            migrationBuilder.DropTable(
                name: "oc_product_to_attribute_to_enum");

            migrationBuilder.DropTable(
                name: "oc_product_to_category");

            migrationBuilder.DropTable(
                name: "oc_product_to_download");

            migrationBuilder.DropTable(
                name: "oc_product_to_layout");

            migrationBuilder.DropTable(
                name: "oc_product_to_prom_product");

            migrationBuilder.DropTable(
                name: "oc_product_to_store");

            migrationBuilder.DropTable(
                name: "oc_product_to_supplier");

            migrationBuilder.DropTable(
                name: "oc_product_to_translate");

            migrationBuilder.DropTable(
                name: "oc_prom_category");

            migrationBuilder.DropTable(
                name: "oc_prom_category_description");

            migrationBuilder.DropTable(
                name: "oc_prom_id");

            migrationBuilder.DropTable(
                name: "oc_recurring");

            migrationBuilder.DropTable(
                name: "oc_recurring_description");

            migrationBuilder.DropTable(
                name: "oc_redirect");

            migrationBuilder.DropTable(
                name: "oc_related");

            migrationBuilder.DropTable(
                name: "oc_relatedoptions");

            migrationBuilder.DropTable(
                name: "oc_relatedoptions_discount");

            migrationBuilder.DropTable(
                name: "oc_relatedoptions_option");

            migrationBuilder.DropTable(
                name: "oc_relatedoptions_special");

            migrationBuilder.DropTable(
                name: "oc_relatedoptions_to_char");

            migrationBuilder.DropTable(
                name: "oc_relatedoptions_variant");

            migrationBuilder.DropTable(
                name: "oc_relatedoptions_variant_option");

            migrationBuilder.DropTable(
                name: "oc_relatedoptions_variant_product");

            migrationBuilder.DropTable(
                name: "oc_remarketing_orders");

            migrationBuilder.DropTable(
                name: "oc_return");

            migrationBuilder.DropTable(
                name: "oc_return_action");

            migrationBuilder.DropTable(
                name: "oc_return_history");

            migrationBuilder.DropTable(
                name: "oc_return_reason");

            migrationBuilder.DropTable(
                name: "oc_return_status");

            migrationBuilder.DropTable(
                name: "oc_review");

            migrationBuilder.DropTable(
                name: "oc_seo_tags_generator");

            migrationBuilder.DropTable(
                name: "oc_seo_tags_generator_category_copy");

            migrationBuilder.DropTable(
                name: "oc_seo_tags_generator_category_declension");

            migrationBuilder.DropTable(
                name: "oc_seo_tags_generator_category_setting");

            migrationBuilder.DropTable(
                name: "oc_seo_tags_generator_not_use");

            migrationBuilder.DropTable(
                name: "oc_setting");

            migrationBuilder.DropTable(
                name: "oc_simple_cart");

            migrationBuilder.DropTable(
                name: "oc_stock_status");

            migrationBuilder.DropTable(
                name: "oc_store");

            migrationBuilder.DropTable(
                name: "oc_suppler");

            migrationBuilder.DropTable(
                name: "oc_suppler_attributes");

            migrationBuilder.DropTable(
                name: "oc_suppler_base_price");

            migrationBuilder.DropTable(
                name: "oc_suppler_cron");

            migrationBuilder.DropTable(
                name: "oc_suppler_data");

            migrationBuilder.DropTable(
                name: "oc_suppler_options");

            migrationBuilder.DropTable(
                name: "oc_suppler_price");

            migrationBuilder.DropTable(
                name: "oc_suppler_ref");

            migrationBuilder.DropTable(
                name: "oc_suppler_seo");

            migrationBuilder.DropTable(
                name: "oc_suppler_sku");

            migrationBuilder.DropTable(
                name: "oc_suppler_sku_description");

            migrationBuilder.DropTable(
                name: "oc_tax_class");

            migrationBuilder.DropTable(
                name: "oc_tax_rate");

            migrationBuilder.DropTable(
                name: "oc_tax_rate_to_customer_group");

            migrationBuilder.DropTable(
                name: "oc_tax_rule");

            migrationBuilder.DropTable(
                name: "oc_theme");

            migrationBuilder.DropTable(
                name: "oc_translation");

            migrationBuilder.DropTable(
                name: "oc_uni_banner_in_category");

            migrationBuilder.DropTable(
                name: "oc_uni_banner_in_category_description");

            migrationBuilder.DropTable(
                name: "oc_uni_banner_in_category_to_category");

            migrationBuilder.DropTable(
                name: "oc_uni_banner_in_category_to_store");

            migrationBuilder.DropTable(
                name: "oc_uni_gallery");

            migrationBuilder.DropTable(
                name: "oc_uni_gallery_image");

            migrationBuilder.DropTable(
                name: "oc_uni_gallery_image_description");

            migrationBuilder.DropTable(
                name: "oc_uni_news");

            migrationBuilder.DropTable(
                name: "oc_uni_news_description");

            migrationBuilder.DropTable(
                name: "oc_uni_news_to_store");

            migrationBuilder.DropTable(
                name: "oc_uni_setting");

            migrationBuilder.DropTable(
                name: "oc_unit");

            migrationBuilder.DropTable(
                name: "oc_upload");

            migrationBuilder.DropTable(
                name: "oc_url_alias");

            migrationBuilder.DropTable(
                name: "oc_url_alias_blog");

            migrationBuilder.DropTable(
                name: "oc_user");

            migrationBuilder.DropTable(
                name: "oc_user_group");

            migrationBuilder.DropTable(
                name: "oc_voucher");

            migrationBuilder.DropTable(
                name: "oc_voucher_history");

            migrationBuilder.DropTable(
                name: "oc_voucher_theme");

            migrationBuilder.DropTable(
                name: "oc_voucher_theme_description");

            migrationBuilder.DropTable(
                name: "oc_weight_class");

            migrationBuilder.DropTable(
                name: "oc_weight_class_description");

            migrationBuilder.DropTable(
                name: "oc_zone");

            migrationBuilder.DropTable(
                name: "oc_zone_to_geo_zone");
        }
    }
}
