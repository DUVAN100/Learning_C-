using Application.Dto;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace PruebaFIX.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserControler : Controller
    {
        private readonly IUserApplication _userApplication;
        //injection

        public UserControler(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }
        [HttpPost]
        public async Task<IActionResult> Add(UserDto dto)
        {
            try
            {
                if (dto == null)
                    return BadRequest();
                var response = await _userApplication.Add(dto);
                if (response.IsSuccess)
                    return Ok(response);

                return BadRequest(response.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UserDto userDto)
        {
            if (userDto == null)
                return BadRequest();
            var response = await _userApplication.Update(userDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _userApplication.Delete(id);
                if (response.IsSuccess)
                {
                    return Ok(response);
                }
                else
                {
                    return NotFound("No found");
                }

        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _userApplication.Get(id);
            if (response.IsSuccess)
            {
                return Ok(response);
            }
            else
            {
                return NotFound("No found");
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _userApplication.GetAll();
            
                if (response.IsSuccess)
                {
                    return Ok(response);
                }
                else
                {
                    return NotFound("No found");
                }
        }
    }
}
