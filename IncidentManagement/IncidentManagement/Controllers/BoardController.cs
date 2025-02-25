using IncidentManagement.Client.Services;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IBoard _commentService;

        public CommentController(IBoard commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Board_TBL>>> GetAllComments()
        {
            var comments = await _commentService.GetAllCommentsAsync();
            return Ok(comments);
        }

        [HttpGet("{incidentId}")]
        public async Task<ActionResult<List<Board_TBL>>> GetComments(int incidentId)
        {
            var comments = await _commentService.GetCommentsByIncidentIdAsync(incidentId);
            return Ok(comments);
        }

        [HttpGet("today/unread")]
        public async Task<ActionResult<List<Board_TBL>>> GetCommentsByDateAndStatus(DateTime date, string status)
        {
            var comments = await _commentService.GetCommentsByDateAndStatusAsync(date, status);
            return Ok(comments);
        }

        [HttpPut("{commentId}/mark-read")]
        public async Task<ActionResult<Board_TBL>> MarkCommentAsRead(int commentId)
        {
            var updatedComment = await _commentService.MarkCommentAsReadAsync(commentId);

            if (updatedComment == null)
            {
                return NotFound("Comment not found.");
            }

            return Ok(updatedComment);
        }


        [HttpPost]
        public async Task<ActionResult<Board_TBL>> PostComment([FromBody] Board_TBL comment)
        {
            if (comment.ImageVideoData == null)
            {
                comment.ImageVideoData = new byte[0];
            }

            if (comment == null)
            {
                Console.WriteLine("Received null comment.");
                return BadRequest("Comment cannot be null.");
            }

            Console.WriteLine($"Received comment: {comment.Comment}");

            var createdComment = await _commentService.AddCommentAsync(comment);

            if (createdComment == null)
            {
                Console.WriteLine("Error creating the comment.");
                return StatusCode(500, "Error creating the comment.");
            }

            return CreatedAtAction(nameof(GetComments), new { incidentId = createdComment.Incident_ID }, createdComment);
        }


    }
}
