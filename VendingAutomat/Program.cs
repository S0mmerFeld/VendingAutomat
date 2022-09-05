using VendingAutomat;

List<AutomatMachine> AutomatMachines = new List<AutomatMachine>();
List<Card> Cards = new List<Card>();
List<DiscountCard> DiscountCards = new List<DiscountCard>();
List<Goods> Goods = new List<Goods>();
List<ProductSale> ProductSales = new List<ProductSale>();
List<ServiceCard> ServiceCards = new List<ServiceCard>();
List<ServiceMan> ServiceMen = new List<ServiceMan>();
List<Sold> Solds = new List<Sold>();

Seed_Data();
PrintAutomatMachineInfo();
PrintDiscountCardInfo();
PrintServiceCardInfo();





void Seed_Data()
{
    Card card_1 = new() { Id = 1, Discount = 20 };
    Card card_2 = new() { Id = 2, Discount = 10 };
    Card card_3 = new() { Id = 3, Discount = 30 };
    Card card_4 = new() { Id = 4, Discount = 40 };
    Card card_5 = new() { Id = 5, Discount = 10 };
    Cards.Add(card_1);
    Cards.Add(card_2);
    Cards.Add(card_3);
    Cards.Add(card_4);
    Cards.Add(card_5);

    ServiceCard servicecard_1 = new(card_1);
    ServiceCard servicecard_2 = new(card_2);
    ServiceCards.Add(servicecard_1);
    ServiceCards.Add(servicecard_2);

    DiscountCard discountcard_1 = new(card_3);
    DiscountCard discountcard_2 = new(card_4);
    DiscountCard discountcard_3 = new(card_5);
    DiscountCards.Add(discountcard_1);
    DiscountCards.Add(discountcard_2);
    DiscountCards.Add(discountcard_3);

    ServiceMan serviceMan1 = new() { Id = 1, Name = "Pavel", Surname = "Smirenko", SMCard = servicecard_1 };
    ServiceMan serviceMan2 = new() { Id = 2, Name = "Ivan" , Surname = "Smirko"  , SMCard = servicecard_2 };
    ServiceMen.Add(serviceMan1);
    ServiceMen.Add(serviceMan2);


    Goods goods1 = new() { Id = 1, Name = "Snickers", Description = "Batonchick with nuts", ShortDescription = "Batonchick" };
    Goods goods2 = new() { Id = 2, Name = "Cola"    , Description = "Coca cola 500 ml"    , ShortDescription = "0.5l Cola" };
    Goods.Add(goods1);
    Goods.Add(goods2);

    ProductSale productSale1 = new ProductSale() { Id = 1, SellQuantity = 3, SoldId = 1, Goods = goods1 };
    ProductSale productSale2 = new ProductSale() { Id = 2, SellQuantity = 2, SoldId = 2, Goods = goods2 };
    ProductSales.Add(productSale1);
    ProductSales.Add(productSale2);

    Sold sold1 = new() { Id = 1, Price = 20, AutomatMachineId = 1, SellsDateTime = new DateTime(2022, 3, 3), Tax = 20, ProductSales = ProductSales };
    Sold sold2 = new() { Id = 2, Price = 44, AutomatMachineId = 1, SellsDateTime = new DateTime(2022, 3, 4), Tax = 20, ProductSales = ProductSales };
    Solds.Add(sold1);
    Solds.Add(sold2);


    AutomatMachine automatMachine1 = new() { Id = 1, InventoryNum = 1234567, Address = "Klochkovska 279", Name = "Automat of snacks sold", Solds = Solds, CurrentProductNumber = 33, MaxProductCapacity = 50 };
    AutomatMachines.Add(automatMachine1);
}

void PrintAutomatMachineInfo()
{
    Console.WriteLine("*****************AutomatMachineInfo********************");
    foreach (var am in AutomatMachines)
    {
        Console.WriteLine(am);
    }
    Console.WriteLine("*******************************************");
}

void PrintDiscountCardInfo()
{
    Console.WriteLine("*****************DiscountCardsInfo********************");
    foreach (var dc in DiscountCards)
    {
        Console.WriteLine(dc);
    }
    Console.WriteLine("*******************************************");
}

void PrintServiceCardInfo()
{
    Console.WriteLine("*****************PrintServiceCardsInfo********************");
    foreach (var sc in ServiceCards)
    {
        Console.WriteLine(sc);
    }
    Console.WriteLine("*******************************************");
}