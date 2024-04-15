using ListaTareas.Model.Models;

namespace ListaTareas.Repo
{
    public interface ITareaRepo
    {
        Task<IEnumerable<Tarea>> GetTareas();
        Task<bool> AddTarea(Tarea tarea);
        Task<bool> EditStateTarea(int idTarea);
        Task<bool> DeleteTarea(int idTarea);
    }
}
