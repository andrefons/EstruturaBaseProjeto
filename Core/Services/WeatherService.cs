using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    public class WeatherService : IWeatherService
    {        
        private readonly IWeatherRepository _repository;
        public WeatherService(IWeatherRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<WeatherForecast> Get()
        {
            return _repository.Get();
        }
    }
}
