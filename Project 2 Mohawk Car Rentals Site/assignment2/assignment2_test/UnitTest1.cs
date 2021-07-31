using assignment2.Controllers;
using assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Priority;

namespace assignment2_test
{
	[TestCaseOrderer(PriorityOrderer.Name, PriorityOrderer.Assembly)]
	public class UnitTest1
	{
		private ICarRepository db;

		public UnitTest1()
		{
			db = new TestRepository();
		}
		[Fact, Priority(10)]
		public void Index_NoInput_returnsCars()
		{
			//Arrange
			var  carsController = new CarsController(db);

			// Act
			var actionResult = carsController.Index();

			// Assert
			Assert.IsType<ViewResult>(actionResult);
			var viewResult = actionResult as ViewResult;
			Assert.IsType<List<Car>>(viewResult.Model);
			var cars = viewResult.Model as List<Car>;
			// Check the number of cars and a portion of every record and all fields
			Assert.Equal(3, cars.Count);
			Assert.Equal(1, cars[0].Id);
			Assert.Equal("Audi", cars[1].Make);
			Assert.Equal("Corolla Hatchback", cars[0].Model);
			Assert.Equal("Crystal Black Pearl", cars[2].Colour);
			Assert.Equal(2020, cars[2].Year);
			Assert.Equal(new DateTime(2020, 10, 07), cars[1].PurchaseDate);
			Assert.Equal(100, cars[2].Kilometeres);
		}

		[Fact, Priority(20)]
		public void Details_CarId_ReturnsCar()
		{
			//Arrange
			var carsController = new CarsController(db);

			// Act
			var actionResult = carsController.Details(1);

			// Assert
			Assert.IsType<ViewResult>(actionResult);
			var viewResult = actionResult as ViewResult;
			Assert.IsType<Car>(viewResult.Model);
			var car = viewResult.Model as Car;
			// Fully Test One Car
			Assert.Equal(1, car.Id);
			Assert.Equal("Toyota", car.Make);
			Assert.Equal("Corolla Hatchback", car.Model);
			Assert.Equal("Black", car.Colour);
			Assert.Equal(2019, car.Year);
			Assert.Equal(new DateTime(2019, 12, 04), car.PurchaseDate);
			Assert.Equal(15000, car.Kilometeres);
		}

		[Fact, Priority(30)]
		public void Create_Car_RedirectsToIndex()
		{
			//Arrange
			var carsController = new CarsController(db);

			// Act
			var actionResult = carsController.Create(
				new Car
				{
					Make = "Audi",
					Model = "SQ5 3.0T",
					Colour = "Blue",
					Year = 2016,
					PurchaseDate = DateTime.Now.Date,
					Kilometeres = 980
				});

			// Assert
			Assert.IsType<RedirectToActionResult>(actionResult);
			var redirectToActionResult = actionResult as RedirectToActionResult;
			Assert.Equal("Index", redirectToActionResult.ActionName);
		}

		[Fact, Priority(40)]
		public void Edit_Car_RedirectsToIndex()
		{
			//Arrange
			var carsController = new CarsController(db);

			// Act
			var actionResult = carsController.Create(
				new Car
				{
					Make = "Audi",
					Model = "SQ5 3.0T",
					Colour = "Blue",
					Year = 2016,
					PurchaseDate = DateTime.Now.Date,
					Kilometeres = 980
				});

			// Assert
			Assert.IsType<RedirectToActionResult>(actionResult);
			var redirectToActionResult = actionResult as RedirectToActionResult;
			Assert.Equal("Index", redirectToActionResult.ActionName);
		}

		[Fact, Priority(50)]
		public void Delete_Car_RedirectsToIndex()
		{
			//Arrange
			var carsController = new CarsController(db);

			// Act
			var actionResult = carsController.Create(
				new Car
				{
					Make = "Audi",
					Model = "SQ5 3.0T",
					Colour = "Blue",
					Year = 2016,
					PurchaseDate = DateTime.Now.Date,
					Kilometeres = 980
				});

			// Assert
			Assert.IsType<RedirectToActionResult>(actionResult);
			var redirectToActionResult = actionResult as RedirectToActionResult;
			Assert.Equal("Index", redirectToActionResult.ActionName);
		}
	}
}
