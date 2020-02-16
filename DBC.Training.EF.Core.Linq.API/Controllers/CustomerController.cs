using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBC.Training.EF.Core.Linq.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBC.Training.EF.Core.Linq.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private DataRepository _dataRepository;
        public CustomerController(DataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet("GetAll")]
        public List<Customer> Get()
        {
            _dataRepository.InitCustomer();
            
            return _dataRepository.GetAllCustomers();
        }
    }
}