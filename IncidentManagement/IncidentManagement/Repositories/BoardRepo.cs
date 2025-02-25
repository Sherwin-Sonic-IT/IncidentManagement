//using IncidentManagement.Client.Services;
//using IncidentManagement.Data;
//using Microsoft.EntityFrameworkCore;
//using SharedLibrary.Interfaces;
//using SharedLibrary.Models;

//namespace IncidentManagement.Repositories
//{
//    public class BoardRepo : IBoard
//    {
//        private readonly DataContext dbContext;

//        public BoardRepo(DataContext context)
//        {
//            dbContext = context;
//        }

//        public async Task<List<Board_TBL>> GetCommentsByIncidentIdAsync(int incidentId)
//        {
//            return await dbContext.Board_TBL
//                .Where(c => c.Incident_ID == incidentId)
//                //.OrderBy(c => c.CreatedAt)
//                .OrderByDescending(c => c.CreatedAt)
//                .ToListAsync();
//        }

//        public async Task<Board_TBL> AddCommentAsync(Board_TBL comment)
//        {
//            try
//            {
//                dbContext.Board_TBL.Add(comment);
//                await dbContext.SaveChangesAsync();

//                return comment;
//            }
//            catch (Exception ex)
//            {
//                // Log exception details (you can use a logging framework like Serilog or NLog)
//                Console.WriteLine($"Error saving comment: {ex.Message}");
//                return null; // Return null or handle appropriately
//            }
//        }

//    }
//}


using IncidentManagement.Data;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidentManagement.Repositories
{
    public class BoardRepo : IBoard
    {
        private readonly IDbContextFactory<DataContext> _dbContextFactory;

        public BoardRepo(IDbContextFactory<DataContext> contextFactory)
        {
            _dbContextFactory = contextFactory;
        }
        public async Task<List<Board_TBL>> GetAllCommentsAsync()
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            return await dbContext.Board_TBL
                .OrderByDescending(c => c.CreatedAt)
                .ToListAsync();
        }
        public async Task<List<Board_TBL>> GetCommentsByIncidentIdAsync(int incidentId)
        {
            using var dbContext = _dbContextFactory.CreateDbContext(); 
            return await dbContext.Board_TBL
                .Where(c => c.Incident_ID == incidentId)
                //.OrderBy(c => c.CreatedAt)
                .OrderByDescending(c => c.CreatedAt)
                .ToListAsync();
        }
        public async Task<List<Board_TBL>> GetCommentsByDateAndStatusAsync(DateTime date, string status)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            return await dbContext.Board_TBL
                .Where(c => c.CreatedAt.Date == date.Date && c.Status == status)
                .OrderByDescending(c => c.CreatedAt)
                .ToListAsync();
        }

        public async Task<Board_TBL> MarkCommentAsReadAsync(int commentId)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();

            var comment = await dbContext.Board_TBL
                .Where(c => c.Comment_ID == commentId)
                .FirstOrDefaultAsync();

            if (comment == null)
            {
                return null;
            }

            comment.Status = "read";
            dbContext.Board_TBL.Update(comment);
            await dbContext.SaveChangesAsync();

            return comment;
        }


        public async Task<Board_TBL> AddCommentAsync(Board_TBL comment)
        {
            using var dbContext = _dbContextFactory.CreateDbContext(); 
            try
            {
                dbContext.Board_TBL.Add(comment);
                await dbContext.SaveChangesAsync();
                return comment;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving comment: {ex.Message}");
                return null; 
            }
        }
    }
}
