using ListaTareas.Model.Models;

namespace ListaTareas.Repo
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ToDoContext _toDoContext;

        public ITareaRepo TareaRepo { get; private set; }

        public UnitOfWork(ToDoContext toDoContext)
        {
            _toDoContext = toDoContext;
            TareaRepo = new TareaRepo(toDoContext);
        }

        public void SaveChanges() => _toDoContext.SaveChanges();

        public async Task SaveChangesAsync() => await _toDoContext.SaveChangesAsync();

        public void Dispose() => _toDoContext.Dispose();
    }
}
