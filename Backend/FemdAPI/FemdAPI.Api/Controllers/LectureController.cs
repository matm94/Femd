using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FemdAPI.Infrastructure.Commands.Lectures;
using FemdAPI.Infrastructure.Models;
using FemdAPI.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;

namespace FemdAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureController : ControllerBase
    {
        private readonly ILectureService _lectureService;
        private readonly ILogger<LectureController> _logger;

        public LectureController(ILectureService lectureService, ILogger<LectureController> logger)
        {
            _lectureService = lectureService;
            _logger = logger;
        }

        [HttpGet("name/{name}")]
        public ActionResult<LectureDTO> Get(string name)
        {
            var lecture = _lectureService.Get(name);
            _logger.LogInformation("wykonano zapytanie o wyklad");
            return Ok(lecture);
        }

        [HttpGet("LectureId/{id}")]
        public ActionResult<LectureDTO> Get(Guid id)
        {
            var lecture = _lectureService.Get(id);
            return Ok(lecture);
        }


        [HttpGet("CompleteLecture/{id}")]
        public ActionResult<CompleteLectureDTO> GetCompleteLectureDTO(Guid id)
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

        [HttpGet("Adjective/{id}")]
        public ActionResult<AdjectiveDTO> GetAdjective(Guid id)
        {
            var adjective = _lectureService.GetAdjective(id);
            return Ok(adjective);
        }

        [HttpGet("Adverb/{id}")]
        public ActionResult<AdverbDTO> GetAdverb(Guid id)
        {
            var adverb = _lectureService.GetAdverb(id);
            return Ok(adverb);
        }

        [HttpGet("Noun/{id}")]
        public ActionResult<NounDTO> GetNoun(Guid id)
        {
            var noun = _lectureService.GetNoun(id);
            return Ok(noun);
        }

        [HttpGet("PersonalPronoun/{id}")]
        public ActionResult<PersonalPronounDTO> GetPersonalPronoun(Guid id)
        {
            var personalPronoun = _lectureService.GetPersonalPronoun(id);
            return Ok(personalPronoun);
        }

        [HttpGet("Sentence/{id}")]
        public ActionResult<SentenceDTO> GetSentence(Guid id)
        {
            var sentence = _lectureService.GetSentence(id);
            return Ok(sentence);
        }

        [HttpGet("Verb/{id}")]
        public ActionResult<VerbDTO> GetVerb(Guid id)
        {
            var verb = _lectureService.GetVerb(id);
            return Ok(verb);
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