// See https://aka.ms/new-console-template for more information

using DesignPatternPractice;
var transportType = "Road";
if (transportType == "Road")
{
    var logistics = new RoadLogistics();
    var truck = logistics.createTransport();

    truck.deliver();
}
else if (transportType == "Ship")
{
    var logistics = new SeaLogistics();
    var ship = logistics.createTransport();

    ship.deliver();
}