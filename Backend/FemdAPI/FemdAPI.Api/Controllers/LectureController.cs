using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FemdAPI.Infrastructure.Commands.Lectures;
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

        [HttpGet("name/{name}")]
        public ActionResult<LectureDTO> Get(string name)
        {
            var lecture = _lectureService.Get(name);
            return Ok(lecture);
        }
        [HttpGet("CompleteLecture/{id}")]
        public ActionResult<LectureDTO> GetCompleteLectureDTO(Guid id)
        {
            var lecture = _lectureService.GetFullLecture(id);
            return Ok(lecture);
        }

        [HttpGet("OnlyDictionary/{id}")]
        public ActionResult<List<WordsDictionaryDTO>> GetOnlyDictionary(Guid id)
        {
            var lecture = _lectureService.GetOnlyDictionary(id);
            return Ok(lecture);
        }

        [HttpGet("All")]
        public ActionResult<List<LectureDTO>> GetAll()
        {
            var lecture = _lectureService.GetAll();
            return Ok(lecture);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CreateLecture command)
        {
            _lectureService.Create
                (command.Name,command.Number,command.Description);
            return Created("api/[controller]/" + command.Name, null);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _lectureService.Delete(id);
            return NoContent();

        }

    }
}