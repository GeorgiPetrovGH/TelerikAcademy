namespace ArtistsSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using Models;  

    public interface IArtistsSystemDbContext
    {
        IDbSet<Album> Albums { get; set; }

        IDbSet<Country> Countries { get; set; }

        IDbSet<Producer> Producers { get; set; }

        IDbSet<Artist> Artists { get; set; }

        IDbSet<Song> Songs { get; set; }

        DbEntityEntry Entry(object entity);

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();
    }
}
