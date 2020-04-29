using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FemdAPI.Infrastructure.Models;
using FemdAPI.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FemdAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureController : ControllerBase
    {
        private readonly ILectureService _lectureService;

        public LectureController(ILectureService lectureService)
        {
            _lectureService = lectureService;
        }

        [HttpGet("{name}")]
        public ActionResult<LectureDTO> Get(string name)
        {
            var lecture = _lectureService.Get(name);
            return Ok(lecture);
        }

        [HttpGet]
        public ActionResult<List<LectureDTO>> GetAll(string name)
        {
            var lecture = _lectureService.GetAll();
            return Ok(lecture);
        }

        [HttpPost]
        public ActionResult Post([FromBody] LectureDTO model)
        {
            _lectureService.Create(model);
            return Created("api/[controller]/" + model.Name, null);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _lectureService.Delete(id);
            return NoContent();

        }

    }
}