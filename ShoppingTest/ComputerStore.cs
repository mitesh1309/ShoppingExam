using ShoppingTest.BusinessLogic;
using ShoppingTest.Entity;
using System;
using System.Collections.Generic;

namespace ShoppingTest
{
    public static class ComputerStore
    {
        private static string SUPER_IPAD = "ipd";
        private static string MACBOOK_PRO = "mbp";
        private static string APPLE_TV = "atv";
        private static string VGA_ADATER = "vga";

        private static String[] shopingList1 = { "atv", "atv", "atv", "vga" };
        private static String[] shopingList2 = { "atv", "ipd", "ipd", "atv", "ipd", "ipd", "ipd" };
        private static String[] shopingList3 = { "mbp", "vga", "ipd" };
        public static string[] shoppingList = shopingList1;
        public static void getProductList(Dictionary<String, Product> products)
        {
            products.Add(SUPER_IPAD, new Product(SUPER_IPAD, "Super iPad", 549.99M));
            products.Add(MACBOOK_PRO, new Product(MACBOOK_PRO, "MacBook Pro", 1399.99M));
            products.Add(APPLE_TV, new Product(APPLE_TV, "Apple TV", 109.50M));
            products.Add(VGA_ADATER, new Product(VGA_ADATER, "VGA adapter", 30));
        }
        public static void getOfferList(List<IOffer> offers)
        {

            IOffer percentageDiscountOffer = new BuyXGetYOffer(3, 2);
            percentageDiscountOffer.setOfferWith(APPLE_TV);
            offers.Add(percentageDiscountOffer);

            IOffer freeVGAAdapterOffer = new FreeVGAAdapter(30.0M);
            freeVGAAdapterOffer.setOfferWith(MACBOOK_PRO);
            offers.Add(freeVGAAdapterOffer);

            IOffer bulkDiscountOffer = new BulkDiscount(4, 499.99M);
            bulkDiscountOffer.setOfferWith(SUPER_IPAD);
            offers.Add(bulkDiscountOffer);

        }
        public static PricingRules getPricingRules()
        {
            Dictionary<String, Product> productMap = new Dictionary<String, Product>();
            List<IOffer> offers = new List<IOffer>();
            getProductList(productMap);
            getOfferList(offers);
            return new PricingRules(productMap, offers);
        }
    }

}
