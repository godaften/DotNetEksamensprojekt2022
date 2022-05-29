//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Linq;
////using cbsStudents.Data;
//using CbsStudents.Data;
//using cbsStudents.Models.Entities;

//namespace cbsStudents.Models

//{
//    public static class SeedDataPosts
//    {
//        public static void Initialize(IServiceProvider serviceProvider)
//        {
//            using (var context = new CbsStudentsContext(
//                serviceProvider.GetRequiredService<
//                    DbContextOptions<CbsStudentsContext>>()))
//            {
//                // Look for any movies.
//                if (context.Post.Any())
//                {
//                    return;   // DB has been seeded
//                }

//                context.Post.AddRange(
//                    new Post()
//                    {
//                        Title = "Party 2",
//                        Text = "Great",
//                        Created = DateTime.Parse("1989-2-12"),
//                    }
                    
//                );
//                context.SaveChanges();
//            }
//        }
//    }
//}