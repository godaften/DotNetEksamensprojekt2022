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
            //this.SeedComments(builder);
            this.SeedEvents(builder);
        }

        public DbSet<Post> Post { get; set; }

        public DbSet<cbsStudents.Models.Entities.Comment> Comment { get; set; }


        private void UsersSeed(ModelBuilder builder)
        {
            //var user1 = new IdentityUser
            //{
            //    Id = "1",
            //    Email = "christian@kea.dk",
            //    EmailConfirmed = true,
            //    UserName = "christian@kea.dk",
            //};

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

            //var user2 = new IdentityUser
            //{
            //    Id = "2",
            //    Email = "test@kea.dk",
            //    EmailConfirmed = true,
            //    UserName = "test@kea.dk",
            //};
            
            //var user3 = new IdentityUser
            //{
            //    Id = "3",
            //    Email = "admin@kea.dk",
            //    EmailConfirmed = true,
            //    UserName = "admin@kea.dk",
            //};

            PasswordHasher<IdentityUser> passHash = new PasswordHasher<IdentityUser>();
            user1.PasswordHash = passHash.HashPassword(user1, "aA123456!");
            user2.PasswordHash = passHash.HashPassword(user2, "aA123456!");
            //user3.PasswordHash = passHash.HashPassword(user2, "aA123456!");
            //user5.PasswordHash = passHash.HashPassword(user5, "aA123456!");


            builder.Entity<IdentityUser>().HasData(
                user1, user2
            );
        }
        private void SeedPosts(ModelBuilder builder)
        {
            builder.Entity<Post>().HasData(
                new Post() { Id = 11, Created = DateTime.Now, Text = "This is post 1", Title = "Post no 1", Status = PostStatus.DRAFT },
                new Post() { Id = 12, Created = DateTime.Now, Text = "This is post 2", Title = "Post no 2", Status = PostStatus.DRAFT },
                new Post() { Id = 14, Created = DateTime.Now, Text = "This is post 3", Title = "Post no 3", Status = PostStatus.DRAFT }
            );
        }

        //private void SeedComments(ModelBuilder builder)
        //{
        //    builder.Entity<Comment>().HasData(
        //        new Comment() { CommentId = 1, Text = "Hello", TimeStamp = DateTime.Now, PostId = 4, UserId = "1" },
        //        new Comment() { CommentId = 2, Text = "Hello again", TimeStamp = DateTime.Now, PostId = 4, UserId = "2" },
        //        new Comment() { CommentId = 3, Text = "Hi", TimeStamp = DateTime.Now, PostId = 5, UserId = "1" },
        //        new Comment() { CommentId = 4, Text = "Bye", TimeStamp = DateTime.Now, PostId = 6, UserId = "1" }
        //    );
        //}

        private void SeedEvents(ModelBuilder builder)
        {
            builder.Entity<Event>().HasData(
                new Event() { Id = 1, Title = "Party", Description = "going on!" },
                new Event() { Id = 2, Title = "PartyUartig", Description = "going on again!" }

               );
        }
        //private void SeedPosts(ModelBuilder builder)
        //{
        //    builder.Entity<Post>().HasData(
        //        new Post() { Id = 4, Created = DateTime.Now, Text = "This is post 1", Title = "Post no 1", Status = PostStatus.DRAFT },
        //        new Post() { Id = 5, Created = DateTime.Now, Text = "This is post 2", Title = "Post no 2", Status = PostStatus.DRAFT },
        //        new Post() { Id = 6, Created = DateTime.Now, Text = "This is post 3", Title = "Post no 3", Status = PostStatus.DRAFT }
        //    );
        //}

        //private void SeedComments(ModelBuilder builder)
        //{
        //    builder.Entity<Comment>().HasData(
        //        new Comment() { CommentId = 1, Text = "Hello", TimeStamp = DateTime.Now, PostId = 4, UserId = "1" },
        //        new Comment() { CommentId = 2, Text = "Hello again", TimeStamp = DateTime.Now, PostId = 4, UserId = "2" },
        //        new Comment() { CommentId = 3, Text = "Hi", TimeStamp = DateTime.Now, PostId = 5, UserId = "1" },
        //        new Comment() { CommentId = 4, Text = "Bye", TimeStamp = DateTime.Now, PostId = 6, UserId = "1" }
        //    );
        //}

        public DbSet<cbsStudents.Models.Entities.Event> Event { get; set; }

    }
}


//#nullable disable
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using cbsStudents.Models;

//namespace cbsStudents.Data
//{
//    public class CbsStudentsContext : DbContext
//    {
//        public CbsStudentsContext(DbContextOptions<CbsStudentsContext> options)
//            : base(options)
//        {
//        }

//        public DbSet<cbsStudents.Models.Entities.Post> Post { get; set; }
//    }
//}
