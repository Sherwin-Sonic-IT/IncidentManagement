using SharedLibrary.Interfaces;
using SharedLibrary.Models;
using System.Net.Http.Json;

namespace IncidentManagement.Client.Services
{
    public class BoardService : IBoard
    {
        private readonly HttpClient _httpClient;

        public BoardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Board_TBL>> GetAllCommentsAsync()
        {
            var response = await _httpClient.GetAsync("api/Comment"); 
            var comments = await response.Content.ReadFromJsonAsync<List<Board_TBL>>();
            return comments!;
        }

        public async Task<List<Board_TBL>> GetCommentsByIncidentIdAsync(int incidentId)
        {
            var response = await _httpClient.GetAsync($"api/Comment/{incidentId}");
            var comments = await response.Content.ReadFromJsonAsync<List<Board_TBL>>();
            return comments!;
        }

        public async Task<List<Board_TBL>> GetCommentsByDateAndStatusAsync(DateTime date, string status)
        {
            var formattedDate = date.ToString("yyyy-MM-dd");
            var response = await _httpClient.GetAsync($"api/Comment/today/unread?date={formattedDate}&status={status}");
            var comments = await response.Content.ReadFromJsonAsync<List<Board_TBL>>();
            return comments!;
        }

        public async Task<Board_TBL> MarkCommentAsReadAsync(int commentId)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Comment/{commentId}/mark-read", new { });

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Failed to mark comment as read. Status: {response.StatusCode}");
                return null;
            }

            var updatedComment = await response.Content.ReadFromJsonAsync<Board_TBL>();
            return updatedComment!;
        }


        public async Task<Board_TBL> AddCommentAsync(Board_TBL comment)
        {
            Console.WriteLine($"Sending comment: {comment.Comment}");

            if (comment.ImageVideoData == null)
            {
                comment.ImageVideoData = new byte[0];
            }

            var response = await _httpClient.PostAsJsonAsync("api/Comment", comment);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Failed to post comment. Status: {response.StatusCode}");
                return null; 
            }

            var addedComment = await response.Content.ReadFromJsonAsync<Board_TBL>();
            return addedComment!;
        }

    }
}
