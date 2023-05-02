using ShoppingTest.BusinessLogic;
using ShoppingTest.Entity;
using System;
using System.Collections.Generic;

namespace ShoppingTest
{
    public class Checkout
        {

            private List<IOffer> offers;
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            Dictionary<string, int> purchaseMap = new Dictionary<string, int>();
            private decimal sumBeforeDiscount = 0;
            public Checkout(PricingRules pricingRules)
            {
                this.products = pricingRules.getProductList();
                this.offers = pricingRules.getOfferList();
                purchaseMap = new Dictionary<string, int>();
        }
            public void scan(String item)
            {
            if (!purchaseMap.ContainsKey(item))
                purchaseMap.Add(item, 1);
            else
            {
                int count = purchaseMap[item];
                purchaseMap[item] = ++count;
            }
            sumBeforeDiscount += products[item].getPrice();
            }

            public decimal computeBill()
            {
                foreach (IOffer offer in offers)
                {
                    string productKey = offer.getOfferWith();
                    if (purchaseMap.ContainsKey(productKey))
                    {
                        int quantity = purchaseMap[offer.getOfferWith()];
                        decimal discount = offer.computeDiscountForTheOffer(quantity, products[productKey].getPrice());
                        sumBeforeDiscount -= discount;
                    }
                }
                return sumBeforeDiscount;
            }

        }
    }
