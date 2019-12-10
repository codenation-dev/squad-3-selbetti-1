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
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class LogController : Controller
    {
        private ILogService _logService;
        private IMapper _mapper;
        public LogController(
            ILogService logService, IMapper mapper)
        {
            this._logService = logService;
            this._mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var app = this._logService.GetById(id);
            var logDto = _mapper.Map<Log>(app);
            return Ok(logDto);
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] LogDto logDto)
        {
            var log = _mapper.Map<Log>(logDto);
            var listOfValidation = log.ValidateObj();
            if (listOfValidation.Count != 0)
            {
                return BadRequest(listOfValidation);
            }

            try
            {
                this._logService.Create(log);
                return Created("", "Log Criada com Sucesso!");
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] LogDto logDto)
        {
            var log = _mapper.Map<Log>(logDto);
            var listOfValidation = log.ValidateObj();
            if (listOfValidation.Count != 0)
            {
                return BadRequest(listOfValidation);
            }

            try
            {
                this._logService.Update(log);
                return Created("", "Log Criada com Sucesso!");
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }
    }

}