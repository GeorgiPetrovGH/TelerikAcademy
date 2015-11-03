﻿namespace ArtistsSystem.Data.Data
{
    using System;
    using System.Collections.Generic;
    
    using Repositories;
    using Models; 

    public class ArtistsSystemData : IArtistsSystemData
    {
        private readonly IArtistsSystemDbContext context;
        private readonly IDictionary<Type, object> repositories;

        public ArtistsSystemData(IArtistsSystemDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IArtistsSystemRepository<Album> AlbumsRepository
        {
            get
            {
                return this.GetRepository<Album>();
            }
        }

        public IArtistsSystemRepository<Country> CountriesRepository
        {
            get
            {
                return this.GetRepository<Country>();
            }
        }

        public IArtistsSystemRepository<Producer> ProducersRepository
        {
            get
            {
                return this.GetRepository<Producer>();
            }
        }

        public IArtistsSystemRepository<Artist> ArtistsRepository
        {
            get
            {
                return this.GetRepository<Artist>();
            }
        }

        public IArtistsSystemRepository<Song> SongsRepository
        {
            get
            {
                return this.GetRepository<Song>();
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IArtistsSystemRepository<TEntity> GetRepository<TEntity>()
            where TEntity : class
        {
            Type repositoryType = typeof(TEntity);
            if (!this.repositories.ContainsKey(repositoryType))
            {
                var repository = new ArtistsSystemRepository<TEntity>(this.context);
                this.repositories.Add(repositoryType, repository);
            }

            return (IArtistsSystemRepository<TEntity>)this.repositories[repositoryType];
        }
    }
}
