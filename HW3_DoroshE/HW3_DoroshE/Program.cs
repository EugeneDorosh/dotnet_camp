﻿using HW1;
using HW3_DoroshE;
using static HW3_DoroshE.Meat;

Meat pork = new Meat(new Product { Currency = Product.Currencies.UAH, Name = "Pork", Price = 250, Weight = 1, WeightUnit = Product.WeightUnits.KILOGRAMM}, Categories.HIGHEST, MeatTypes.PORK);
Meat chicken = new Meat(new Product { Currency = Product.Currencies.UAH, Name = "Chicken", Price = 125, Weight = 1, WeightUnit = Product.WeightUnits.KILOGRAMM }, Categories.SECOND, MeatTypes.CHICKEN);

Dairy_products milk = new Dairy_products(new Product { Currency = Product.Currencies.UAH, Name = "Milk", Price = 45, Weight = 1, WeightUnit = Product.WeightUnits.LITTERS }, 11);
Dairy_products yougurt = new Dairy_products(new Product { Currency = Product.Currencies.UAH, Name = "Yougurt", Price = 65, Weight = 1, WeightUnit = Product.WeightUnits.LITTERS }, 30);
Dairy_products kefir = new Dairy_products(new Product { Currency = Product.Currencies.UAH, Name = "Kefir", Price = 50, Weight = 1, WeightUnit = Product.WeightUnits.LITTERS }, 3);

Product banana = new Product("Bananas", Product.WeightUnits.KILOGRAMM, 1, Product.Currencies.UAH, 65);

Dictionary<Product, int> tempDict = new Dictionary<Product, int>()
{
    [pork] = 3,
    [chicken] = 25,
    [milk] = 15,
    [yougurt] = 10,
    [kefir] = 9
};

Console.WriteLine("----------------------------\n");

Storage storage = new Storage(tempDict);
Console.WriteLine($"Before:\n{storage}");

Console.WriteLine("----------------------------\n");

storage.AddNewProductToStorage(banana, 45);
Console.WriteLine($"After:\n{storage}");

Console.WriteLine("----------------------------\n");

storage.ChangePriceAllOfTheProducts(50);
Console.WriteLine($"After changing prices:\n{storage}");

Console.WriteLine("----------------------------\n");

// finding all meat product
Console.WriteLine("All meat products: \n");
foreach (var item in storage.FindMeatProducts())
{
    Console.WriteLine(item);
}

Console.WriteLine("----------------------------\n");

// printing all info
storage.PrintAllInfo();

Console.WriteLine("----------------------------\n");

// getting storage from user
// uncomment to check
/*Storage storage2 = new Storage();
storage2.GetProductsFromUser();
storage2.PrintAllInfo();*/

Console.WriteLine("----------------------------\n");
Console.WriteLine("HW5:\n");
Console.WriteLine("Before sorting:\n");
Console.WriteLine(storage);

// SortBy can compare only by numbers
Console.WriteLine("\nAfter sorting by price:\n");
Console.WriteLine(storage.SortBy(x => x.Key.Price));

Console.WriteLine("Before sorting:\n");
Console.WriteLine(storage);

Console.WriteLine("\nAfter sorting by name:\n");
Console.WriteLine(storage.SortByName());
