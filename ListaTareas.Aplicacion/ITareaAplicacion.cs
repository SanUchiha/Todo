using ListaTareas.Model.Models;

namespace ListaTareas.Aplicacion
{
    public interface ITareaAplicacion
    {
        Task<IEnumerable<Tarea>> GetTareas();
        Task<bool> AddTarea(TareaDTO tareaDTO);
        Task<bool> EditStateTarea(int idTarea);
        Task<bool> DeleteTarea(int idTarea);
    }
}
