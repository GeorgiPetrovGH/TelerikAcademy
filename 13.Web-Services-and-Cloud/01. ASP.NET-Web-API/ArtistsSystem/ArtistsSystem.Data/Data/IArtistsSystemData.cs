namespace ArtistsSystem.Data.Data
{
    using Models;    
    using Repositories;

    public interface IArtistsSystemData
    {
        IArtistsSystemRepository<Country> CountriesRepository { get; }

        IArtistsSystemRepository<Song> SongsRepository { get; }

        IArtistsSystemRepository<Album> AlbumsRepository { get; }

        IArtistsSystemRepository<Artist> ArtistsRepository { get; }

        IArtistsSystemRepository<Producer> ProducersRepository { get; }

        int SaveChanges();
    }
}
