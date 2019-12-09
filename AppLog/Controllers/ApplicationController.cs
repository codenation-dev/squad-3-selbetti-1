using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppLog.Domain.Models;
using AppLog.Dto;
using AppLog.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppLog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private IApplicationService _applicationService;
        private IMapper _mapper;

        public ApplicationController(
            IApplicationService applicationService,
            IMapper mapper)
        {
            this._applicationService = applicationService;
            this._mapper = mapper;
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var app = this._applicationService.GetById(id);
            var appDto = _mapper.Map<ApplicationDto>(app);
            return Ok(appDto);
        }
    
        [HttpPost("Register")]
        public IActionResult Register([FromBody] ApplicationDto appDto)
        {
            var app = _mapper.Map<Application>(appDto);
            var listOfValidation = app.ValidateObj();
            if (listOfValidation.Count != 0)
            {
                return BadRequest(listOfValidation);
            }

            try
            {
                this._applicationService.Create(app);
                return Created("", "Application Criada com Sucesso!");
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}