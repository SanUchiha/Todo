using ListaTareas.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaTareas.Repo
{
    public class TareaRepo : ITareaRepo
    {

        private readonly ToDoContext _toDoContext;

        public TareaRepo(ToDoContext toDoContext)
        {
            _toDoContext = toDoContext;
        }

        // Agregar una tarea
        public async Task<bool> AddTarea(Tarea tarea)
        {
            try
            {
                tarea.Completada = false;
                await _toDoContext.Tareas.AddAsync(tarea);
                await _toDoContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        // Eliminar una tarea
        public async Task<bool> DeleteTarea(int idTarea)
        {
            try
            {
                var tarea = await _toDoContext.Tareas.FindAsync(idTarea);
                if (tarea == null)
                {
                    return false;
                }

                _toDoContext.Tareas.Remove(tarea);
                await _toDoContext.SaveChangesAsync();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
                    }
        
        // Modificar el estado de una tarea
        public async Task<bool> EditStateTarea(int idTarea)
        {
            if (!TareaExists(idTarea))
            {
                return false;
            }

            try
            {
                var tareaEncontrada = await _toDoContext.Tareas.FindAsync(idTarea);

                tareaEncontrada!.Completada = !tareaEncontrada.Completada;

                await _toDoContext.SaveChangesAsync();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        // Obtener todas las tareas
        public async Task<IEnumerable<Tarea>> GetTareas()
        {
            var resultado = await _toDoContext.Tareas.ToListAsync();

            if(resultado == null)
            {
                Console.WriteLine("no hay tareas");
                return Enumerable.Empty<Tarea>();
            }
            else
            {
                return resultado;
            }
        }

        // Comprobar si una tarea existe
        private bool TareaExists(int id) => _toDoContext.Tareas.Any(e => e.IdTarea == id);
    }
}
