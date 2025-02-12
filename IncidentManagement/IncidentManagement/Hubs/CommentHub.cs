using Microsoft.AspNetCore.SignalR;

namespace IncidentManagement.Hubs
{
    public class CommentHub : Hub
    {
        public async Task SendComment(string username, string newComment, byte[] imageVideoData)
        {
            await Clients.All.SendAsync("NewComment", username, newComment, imageVideoData);
            Console.WriteLine("RealTimeData sent to all clients.");
        }
    }
}