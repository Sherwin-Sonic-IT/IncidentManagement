using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SharedLibrary.Interfaces
{
    public interface IBoard
    {
        Task<List<Board_TBL>> GetAllCommentsAsync();
        Task<List<Board_TBL>> GetCommentsByIncidentIdAsync(int incidentId);
        Task<Board_TBL> AddCommentAsync(Board_TBL comment);
    }
}
