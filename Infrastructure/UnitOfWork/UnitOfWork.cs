using Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly DemoDbContext _context; 

    public UnitOfWork(DemoDbContext context)
    {
        _context = context;
    }

    public void BeginTransaction()
    {
        _context.Database.BeginTransaction();
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public void Rollback()
    {
        _context.Database.CurrentTransaction.Rollback();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}