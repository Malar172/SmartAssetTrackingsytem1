using SmartAssetTrackingSystem.Data;
using SmartAssetTrackingSystem.Models;


using AssetDbContext context = new AssetDbContext();

if (!context.Assets.Any())
{
    context.Assets.Add(new Asset
    {
        AssetType = "Laptop",
        Brand = "Lenovo",
        ModelName = "ThinkPad X1",
        PurchaseDate = new DateTime(2024, 2, 11),
        PurchasePriceUSD = 1500,
        LocalPrice = 1500,
        OfficeLocation = "Stockholm",
        SerialNumber = "LEN001",
        EmployeeUserName = "John",
        WarrantyExpirationDate = new DateTime(2027, 2, 11)
    });

    context.Assets.Add(new Asset
    {
        AssetType = "Mobile",
        Brand = "Apple",
        ModelName = "iPhone 15",
        PurchaseDate = new DateTime(2025, 1, 10),
        PurchasePriceUSD = 1200,
        LocalPrice = 1200,
        OfficeLocation = "Malmo",
        SerialNumber = "APP001",
        EmployeeUserName = "Mary",
        WarrantyExpirationDate = new DateTime(2028, 1, 10)
    });

    context.Assets.Add(new Asset
    {
        AssetType = "Desktop",
        Brand = "Asus",
        ModelName = "ROG Station",
        PurchaseDate = new DateTime(2023, 9, 15),
        PurchasePriceUSD = 1300,
        LocalPrice = 1300,
        OfficeLocation = "Gothenburg",
        SerialNumber = "ASU001",
        EmployeeUserName = "David",
        WarrantyExpirationDate = new DateTime(2026, 9, 15)
    });

    context.SaveChanges();
}

var assets = context.Assets.ToList();

Console.WriteLine();
Console.WriteLine("============== ASSET LIST ==============");
Console.WriteLine();

Console.WriteLine(
    "{0,-5}{1,-12}{2,-12}{3,-20}{4,-15}",
    "ID",
    "Type",
    "Brand",
    "Model",
    "Purchase Date");

Console.WriteLine("--------------------------------------------------------");

foreach (var asset in assets)
{
    Console.WriteLine(
        "{0,-5}{1,-12}{2,-12}{3,-20}{4,-15}",
        asset.Id,
        asset.AssetType,
        asset.Brand,
        asset.ModelName,
        asset.PurchaseDate.ToString("yyyy-MM-dd"));
}

Console.WriteLine();
Console.WriteLine("========================================================");

Console.ReadKey();
