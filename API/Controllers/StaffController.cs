using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Contracts;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
      [ApiController]
      [Route("api/[controller]")]
      public class StaffController : ControllerBase
      {
            private readonly IStaffRepository _repository;
            public StaffController(IStaffRepository repository)
            {
                  _repository = repository;

            }

            [HttpGet]
            public async Task<ActionResult<IReadOnlyList<Staff>>> GetStaffAsync()
            {
                  try
                  {
                        var staff = await _repository.GetStaffAsync();
                        return Ok(staff);
                  }
                  catch
                  {
                        return BadRequest("Unable to retrieve staff.");
                  }
            }

            [HttpGet("{staffId}")]
            public async Task<ActionResult<Staff>> GetStaffByIdAsync(int staffId)
            {
                  try
                  {
                        var staff = await _repository.GetStaffByIdAsync(staffId);
                        return Ok(staff);
                  }
                  catch
                  {
                        return BadRequest("Unable to find requested staff.");
                  }
            }
      }
}