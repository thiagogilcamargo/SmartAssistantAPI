using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class FeedbacksController : ControllerBase
{
    private readonly IFeedbackService _feedbackService;

    public FeedbacksController(IFeedbackService feedbackService)
    {
        _feedbackService = feedbackService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var feedbacks = _feedbackService.GetAll();
        return Ok(feedbacks);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var feedback = _feedbackService.GetById(id);
        if (feedback == null) return NotFound();
        return Ok(feedback);
    }

    [HttpPost]
    public IActionResult Create([FromBody] Feedback feedback)
    {
        var createdFeedback = _feedbackService.Create(feedback);
        return CreatedAtAction(nameof(GetById), new { id = createdFeedback.Id }, createdFeedback);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Feedback feedback)
    {
        if (id != feedback.Id) return BadRequest();
        _feedbackService.Update(feedback);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _feedbackService.Delete(id);
        return NoContent();
    }
}
