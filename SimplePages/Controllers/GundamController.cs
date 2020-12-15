using GundamsApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimplePages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplePages.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GundamController : ControllerBase
    {
        private readonly GundamService _gundamService;

        public GundamController(GundamService gundamService)
        {
            _gundamService = gundamService;
        }

        [HttpGet]
        public ActionResult<List<GundamModel>> Get() =>
            _gundamService.Get();

        [HttpGet("{id:length(24)}", Name = "GetGundam")]
        public ActionResult<GundamModel> Get(string id)
        {
            var gundam = _gundamService.Get(id);

            if (gundam == null)
            {
                return NotFound();
            }

            return gundam;
        }

        [HttpPost]
        public ActionResult<GundamModel> Create(GundamModel gnd)
        {
            _gundamService.Create(gnd);

            return CreatedAtRoute("GetGundam", new { id = gnd.Id.ToString() }, gnd);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, GundamModel bookIn)
        {
            var gundam = _gundamService.Get(id);
            if (gundam == null)
            {
                return NotFound();
            }

            _gundamService.Update(id, bookIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var gundam = _gundamService.Get(id);
            if (gundam == null)
            {
                return NotFound();
            }

            _gundamService.Remove(gundam.Id);

            return NoContent();
        }
    }
}
