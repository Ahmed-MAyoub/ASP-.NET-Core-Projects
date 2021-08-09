using Microsoft.AspNetCore.Mvc;
using RazorAPI.Models;
using RazorAPI.Services;
using System.Collections.Generic;

namespace RazorAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Car")]
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        // GET: api/Car
        [HttpGet]
        public List<Car> Get()
        {
            return _carService.ReadAll();
        }
        // GET: api/Car/5
        [HttpGet("{id}", Name = "Get")]
        public Car Get(int id)
        {
            return _carService.Read(id);
        }
        // POST: api/Car
        [HttpPost]
        public void Post([FromBody] Car car)
        {
            _carService.Create(car);
        }
        // PUT: api/Car/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Car car)
        {
            _carService.Update(car);
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _carService.Delete(id);
        }
    }
}