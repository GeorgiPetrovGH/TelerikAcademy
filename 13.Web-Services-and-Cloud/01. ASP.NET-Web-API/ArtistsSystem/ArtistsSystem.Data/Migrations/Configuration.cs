namespace ArtistsSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<ArtistsSystem.Data.ArtistsSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ArtistsSystem.Data.ArtistsSystemDbContext context)
        {
            if (context.Artists.Count() == 0)
            {
                var artist = new Artist
                {
                    FirstName = "The",
                    LastName = "Greatest",
                    Age = 26
                };

                var producer = new Producer
                {
                    FirstName = "Best",
                    LastName = "OfTheBest",
                    Age = 46
                };

                var firstSong = new Song
                {
                    Title = "SongToSong",
                    Year = 2009,
                    Genre = "Trip-Hop"
                };

                var secondSong = new Song
                {
                    Title = "SingToSing",
                    Year = 2012,
                    Genre = "Electronic"
                };

                var album = new Album
                {
                    Title = "BestAlbum",
                    Year = 2013
                };


                var firstCountry = new Country
                {
                    Name = "England"
                };

                var secondCountry = new Country
                {
                    Name = "Norway"
                };

                producer.Country = firstCountry;
                album.Producer = producer;
                artist.Country = secondCountry;
                artist.Songs.Add(firstSong);
                artist.Songs.Add(secondSong);
                artist.Albums.Add(album);

                context.Artists.AddOrUpdate(artist);
            }
        }
    }
}

