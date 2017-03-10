﻿using System;
namespace Weather
{
	public class CurrentWeatherModel
	{
		public string Title { get; set; }
		public double Temperature { get; set; }
		public double Temp_min { get; set; }
		public double Temp_max { get; set; }
		public double Wind { get; set; }
		public double Humidity { get; set; }
		public double Rain { get; set; }
		public string Visibility { get; set; }
		public DateTime Sunrise { get; set; }
		public DateTime Sunset { get; set; }
		public string Country { get; set; }

		public CurrentWeatherModel(RootObject weatherRootObject)
		{
			Title = weatherRootObject.name;
			Temperature = weatherRootObject.main.temp;
			Temp_min = weatherRootObject.main.temp_min;
			Wind = weatherRootObject.wind.speed;
			Humidity = weatherRootObject.main.humidity;
			Rain = weatherRootObject.rain == null ? 0 : weatherRootObject.rain.__invalid_name__3h;
			DateTime time = new System.DateTime(1970, 1, 1, 1, 0, 0, 0);
			Sunrise = time.AddSeconds(weatherRootObject.sys.sunrise);
			Sunset = time.AddSeconds(weatherRootObject.sys.sunset);
			Country = weatherRootObject.sys.country;
		}
	}
}