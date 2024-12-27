// See https://aka.ms/new-console-template for more information
using SolarQubeTest;
using System.Text.Json;

Car car = new Car("Tesla");

car.Id = 1;
car.WheelCount = 4;
car.DoorCount = 2;

Console.WriteLine(JsonSerializer.Serialize(car));
