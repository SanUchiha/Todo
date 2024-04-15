namespace ListaTareas.Repo
{
    public interface IUnitOfWork : IDisposable
    {
        ITareaRepo TareaRepo { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
