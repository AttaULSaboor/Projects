using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace assignment2.Models
{
	public class CarRepository : ICarRepository
	{
		private string carFile = "cars.json";

		public void CreateCar(Car car)
		{
			var cars = ReadCars();
			var maxId = 0;

			if (cars.Count != 0)
			{
				maxId = cars.Max(c => c.Id);
			}

			car.Id = maxId + 1;
			cars.Add(car);
			WriteCars(cars);
		}

		public void DeleteCar(int id)
		{
			var cars = ReadCars();
			var index = cars.FindIndex(c => c.Id == id);
			cars.RemoveAt(index);
			WriteCars(cars);
		}

		public void EditCar(Car car)
		{
			var cars = ReadCars();
			var index = cars.FindIndex(c => c.Id == car.Id);
			cars[index] = car;
			WriteCars(cars);
		}

		public Car GetCar(int id)
		{
			var cars = ReadCars();
			return cars.Find(c => c.Id == id);
		}

		public IEnumerable<Car> GetCars()
		{
			return ReadCars();
		}

		private void WriteCars(List<Car> cars)
		{
			var json = JsonSerializer.Serialize(cars);
			File.WriteAllText(carFile, json);
		}

		private List<Car> ReadCars()
		{
			var cars = new List<Car>();
			
			if( File.Exists(carFile))
			{
				var json = File.ReadAllText(carFile);
				cars = JsonSerializer.Deserialize<List<Car>>(json);
			}

			return cars;
		}
	}
}
