using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cbsStudents.Models;
using cbsStudents.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CbsStudents.Data
{
    public class CbsStudentsContext : IdentityDbContext
    {
        public CbsStudentsContext(DbContextOptions<CbsStudentsContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); 

            this.UsersSeed(builder);
            this.SeedPosts(builder);
            this.SeedVenues(builder);
            this.SeedComments(builder);
            this.SeedEvents(builder);
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Venue> Venues { get; set; }

        public DbSet<Comment> Comments { get; set; }

        
        private void UsersSeed(ModelBuilder builder)
        {
            var user1 = new IdentityUser
            {
                Id = "1",
                UserName = "test@kea.dk",
                NormalizedUserName = "TEST@KEA.DK",
                Email = "test@kea.dk",
                NormalizedEmail = "TEST@KEA.DK",
                EmailConfirmed = true,
            };

            var user2 = new IdentityUser
            {
                Id = "2",
                UserName = "jj@kea.dk",
                NormalizedUserName = "JJ@KEA.DK",
                Email = "jj@kea.dk",
                NormalizedEmail = "JJ@KEA.DK",
                EmailConfirmed = true,
            };


            PasswordHasher<IdentityUser> passHash = new PasswordHasher<IdentityUser>();
            user1.PasswordHash = passHash.HashPassword(user1, "aA123456!");
            user2.PasswordHash = passHash.HashPassword(user2, "aA123456!");

                       
            builder.Entity<IdentityUser>().HasData(
                user1, user2
            );
        }
        private void SeedPosts(ModelBuilder builder)
        {
            builder.Entity<Post>().HasData(
                new Post() { Id = 1, Created = DateTime.Now, Text = "This is post 1", Title = "Post no 1", Status = PostStatus.DRAFT },
                new Post() { Id = 22, Created = DateTime.Now, Text = "This is post 2", Title = "Post no 2", Status = PostStatus.DRAFT },
                new Post() { Id = 24, Created = DateTime.Now, Text = "This is post 3", Title = "Post no 3", Status = PostStatus.DRAFT }
            );
        }
        private void SeedComments(ModelBuilder builder)
        {
            builder.Entity<Comment>().HasData(
                new Comment() { CommentId = 1, Text = "Hello", TimeStamp = DateTime.Now, PostId = 1, UserId = "1" }
            );
        }


        private void SeedVenues(ModelBuilder builder)
        {
            builder.Entity<Venue>().HasData(
                new Venue() { VenueId = "Green", Name = "Green Stage", NumberOfSeats = 100 },
                new Venue() { VenueId = "Small", Name = "Small Room", NumberOfSeats = 200 },
                new Venue() { VenueId = "Hall", Name = "Hall", NumberOfSeats = 250 });

        }

        private void SeedEvents(ModelBuilder builder)
        {
            builder.Entity<Event>().HasData(
                new Event()
                {
                    Id = 100,
                    Title = "All night Fun with Jokes",
                    EventGenre = "Comedy",
                    EventStartDateTime = DateTime.Now,
                    EventEndDateTime = DateTime.Now,
                    Adress = "Funnystreet 10",
                    City = "Copenhagen",
                    Country = "Denmark",
                    Description = "Come join everybody having fun!",
                    ImageName = "77a05c90-f3e1-46df-8bae-9e2098da08b6_AA9EA89A-CDF9-4DE0-8FC6-0D17D573BADF.jpeg"
                },

                new Event()
                {
                    Id = 101,
                    Title = "John live at the stage",
                    EventGenre = "Concert",
                    EventStartDateTime = DateTime.Now,
                    EventEndDateTime = DateTime.Now,
                    Adress = "Funnystreet 10",
                    City = "Copenhagen",
                    Country = "Denmark",
                    Description = "Greatest voice alive!",
                    ImageName = ""
                },

                new Event()
                {
                    Id = 102,
                    Title = "Fun at home?",
                    EventGenre = "Comedy",
                    EventStartDateTime = DateTime.Now,
                    EventEndDateTime = DateTime.Now,
                    Adress = "",
                    City = "",
                    Country = "",
                    Description = "Laugh out loud alone!",
                    ImageName = ""
                }

             );
        }

    }
}
