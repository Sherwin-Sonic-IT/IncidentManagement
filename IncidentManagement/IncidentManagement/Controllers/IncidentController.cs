using IncidentManagement.Client.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentController : ControllerBase
    {
        private readonly IIncident _incidentRepo;

        public IncidentController(IIncident incidentRepo)
        {
            _incidentRepo = incidentRepo;
        }

        [HttpGet("All-Incidents")]
        public async Task<ActionResult<List<Incidents_TBL>>> GetAllIncidentsAsync()
        {
            var incident = await _incidentRepo.GetAllIncidentsAsync();
            return Ok(incident);
        }

        [HttpGet("Get-Incident/{ID}")]
        public async Task<ActionResult<Incidents_TBL>> GetIncidentAsync(int ID)
        {
            var incident = await _incidentRepo.GetIncidentByIdAsync(ID);
            return Ok(incident);
        }

        [HttpPost("Add-Incident")]
        public async Task<ActionResult<Incidents_TBL>> AddIncidentAsync(Incidents_TBL model)
        {
            var incident = await _incidentRepo.AddIncidentAsync(model);
            return Ok(incident);
        }

        [HttpPut("Update-Incident")]
        public async Task<ActionResult<Incidents_TBL>> UpdateIncidentAsync(Incidents_TBL model)
        {
            var incident = await _incidentRepo.UpdateIncidentAsync(model);
            return Ok(incident);
        }

        [HttpDelete("Delete-Incident/{ID}")]
        public async Task<ActionResult<Incidents_TBL>> DeleteIncidentAsync(int ID)
        {
            var incident = await _incidentRepo.DeleteIncidentAsync(ID);
            return Ok(incident);
        }

        [HttpGet("Get-Recurring-Incidents")]
        public async Task<IActionResult> IsIncidentRecurringAsync(string location, string incidentName, string reportedBy)
        {
            var recurringIncidents = await _incidentRepo.IsIncidentRecurringAsync(location, incidentName, reportedBy);
            return Ok(recurringIncidents);
        }

    }
}




