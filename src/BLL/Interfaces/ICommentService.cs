using System.Threading.Tasks;
using BLL.Models;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface ICommentService : ICrud<Comment>
    {
         Task Edit(int id, string message);
         Comment GetById(int id);
    }
}