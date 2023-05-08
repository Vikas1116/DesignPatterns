// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");

var furnitureModel = "victorian";
var furnitureType = "chair";

if (furnitureType == "chair" && furnitureModel == "victorian")
{
    var furnitureFactory = new VictorainFurnitureFactory();
    var victorianChair = furnitureFactory.createChair();

    victorianChair.sit();
}
else if (furnitureType == "chair" && furnitureModel == "modern")
{
    var furnitureFactory = new ModernFurnitureFactory();
    var modernChair = furnitureFactory.createChair();

    modernChair.sit();
}
//so on, not implemented all conditions but similar