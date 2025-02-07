namespace DocAppointment.Infrastructure.Persistence.Repositories;
public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    #region Fields
    private readonly ApplicationDbContext _context;
    public DbSet<TEntity> Entities { get; }

    #endregion
    #region Constructor
    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        Entities = _context.Set<TEntity>();

    }
    #endregion
    public IQueryable<TEntity> Table => Entities;

    public IQueryable<TEntity> TableNoTracking => Entities.AsNoTracking();

    public virtual void Add(TEntity entity)
    {
        Entities.Add(entity);
        _context.SaveChanges();
    }

    public virtual async Task AddAsync(TEntity entity, CancellationToken cancellationToken)
    {
        await Entities.AddAsync(entity, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public virtual async void AddRange(IEnumerable<TEntity> entities)
    {

        await Entities.AddRangeAsync(entities);
        await _context.SaveChangesAsync();
    }

    public virtual async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
    {
        Entities.AddRangeAsync(entities);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public virtual void Delete(TEntity entity)
    {

        Entities.Remove(entity);
        _context.SaveChanges();
    }

    public virtual async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken)
    {
        Entities.Remove(entity);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public virtual void DeleteRange(IEnumerable<TEntity> entities)
    {
        Entities.RemoveRange(entities);
        _context.SaveChanges();
    }

    public virtual async Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation)
    {
        Entities.RemoveRange(Entities);
        await _context.SaveChangesAsync(cancellation);
    }

    public virtual TEntity Get(Expression<Func<TEntity,bool>> code)
    {
        return Entities.SingleOrDefault(code);
    }

    public virtual TEntity GetById(params object[] ids)
    {
        return Entities.Find(ids);
    }

    public virtual  async Task<TEntity> GetByIdAsync(CancellationToken cancellationToken, params object[] ids)
    {
        return await Entities.FindAsync(ids, cancellationToken);
    }

    public virtual void Update(TEntity entity)
    { 
        Entities.Update(entity);
        _context.SaveChanges();
    }

    public virtual async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken)
    {
     
        Entities.Update(entity);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
