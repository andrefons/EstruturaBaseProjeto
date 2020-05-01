using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.Services
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> Get();
    }
}
