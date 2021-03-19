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
            private readonly IStaffRepository _staffRepository;
            public StaffController(IStaffRepository repository)
            {
                  _staffRepository = repository;
            }

            [HttpGet]
            public async Task<ActionResult<IReadOnlyList<Staff>>> GetStaffAsync()
            {
                  var staff = await _staffRepository.GetStaffAsync();
                  if (staff.Count < 0)
                  {
                        return BadRequest("Unable to retrieve stuff members");
                  }
                  return Ok(staff);
            }

            [HttpGet("{staffId}")]
            public async Task<ActionResult<Staff>> GetStaffByIdAsync(int staffId)
            {
                  var staff = await _staffRepository.GetStaffByIdAsync(staffId);
                  if (staff == null) { return NotFound("Staff member not found."); }
                  return Ok(staff);
            }
      }
}