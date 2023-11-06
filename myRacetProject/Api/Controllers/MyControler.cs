//using Api.model;
//using Api.serivce;
using api_models;
using api_service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
namespace Api.Controllers
{
    [ApiController]
        [Route("[controller]")]
    public class MyControler: ControllerBase
    {
        public MyControler()
        {

        }
        TodoService service = new TodoService();
        [Route("AllMissile")]
        [HttpGet]
       
        public IEnumerable<Racet> Get()
        {
            return service.GetData();
        }
        [Route("GetByCity")]
        [HttpGet]
        
        public IEnumerable<Racet> Getbyid(string city)
        {
            return service.GetData(city);
        }
        [Route("GetMissileIn")]
        [HttpGet]

        public IEnumerable<string> GetMissileIn()
        {
            return service.GetCity();
        }
        [HttpPost]
        public bool post(Racet racet)
        {
            return service.add(racet);
        }
     

    }
}
