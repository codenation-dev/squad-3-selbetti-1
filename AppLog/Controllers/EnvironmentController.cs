using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppLog.Dto;
using AppLog.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppLog.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class EnvironmentController : ControllerBase
    {
        private IEnvironmentService _environmentService;
        private IMapper _mapper;
        public EnvironmentController(
             IEnvironmentService environmentService,
             IMapper mapper)
        {
            this._environmentService = environmentService;
            this._mapper = mapper;
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var app = this._environmentService.GetById(id);
            var envDto = this._mapper.Map<EnvironmentDto>(app);
            return Ok(envDto);
        }

        [HttpGet("App/{id}")]
        public IActionResult GetByAppId(int id)
        {
            var env = this._environmentService.FindByAppId(id);
            IList<EnvironmentDto> envDto = new List<EnvironmentDto>();
            foreach(var e in env)
            {
                envDto.Add(e.ConvertToDTO());
            }
            return Ok(envDto);
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] EnvironmentDto envDto)
        {
            var app = this._mapper.Map<Domain.Models.Environment>(envDto);
            var listOfValidation = app.ValidateObj();
            if (listOfValidation.Count != 0)
            {
                return BadRequest(listOfValidation);
            }

            try
            {
                this._environmentService.Create(app);
                return Created("", "Environment Criada com Sucesso!");
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}