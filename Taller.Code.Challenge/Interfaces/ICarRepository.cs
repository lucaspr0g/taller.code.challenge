﻿using Taller.Code.Challenge.Models;

namespace Taller.Code.Challenge.Interfaces
{
	public interface ICarRepository
	{
		IEnumerable<Car> GetAllCars();
		Car GetCar(int id);
		void CreateCar(Car car);
		void DeleteCar(int id);
		void SaveCar(Car car);
		int RetriveCarPrice(int carId);
	}
}