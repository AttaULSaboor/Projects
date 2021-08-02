using assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment2_test
{
	class TestRepository : ICarRepository
	{
		private static List<Car> cars = new List<Car>
		{
			new Car
			{
				Id = 1,
				Make = "Toyota",
				Model = "Corolla Hatchback",
				Colour = "Black",
				Year = 2019,
				PurchaseDate = new DateTime(2019,12,04),
				Kilometeres = 15000
			},
			new Car
			{
				Id = 2,
				Make = "Audi",
				Model = "SQ5 3.0T",
				Colour = "Blue",
				Year = 2016,
				PurchaseDate = new DateTime(2020,10,07),
				Kilometeres = 60022
			},
			new Car
			{
				Id = 3,
				Make = "Honda",
				Model = "HR-V Sport",
				Colour = "Crystal Black Pearl",
				Year = 2020,
				PurchaseDate = new DateTime(2021,01,20),
				Kilometeres = 100
			}
		};

		public void CreateCar(Car car)
		{
			var maxId = 0;
			if (cars.Count != 0)
			{
				maxId = cars.Max(c => c.Id);
			}

			car.Id = maxId + 1;
			cars.Add(car);
		}

		public void DeleteCar(int id)
		{
			var index = cars.FindIndex(c => c.Id == id);
			cars.RemoveAt(index);
		}

		public void EditCar(Car car)
		{
			var index = cars.FindIndex(c => c.Id == car.Id);
			cars[index] = car;
		}

		public Car GetCar(int id)
		{
			return cars.Find(c => c.Id == id);
		}

		public IEnumerable<Car> GetCars()
		{
			return cars;
		}
	}
}
