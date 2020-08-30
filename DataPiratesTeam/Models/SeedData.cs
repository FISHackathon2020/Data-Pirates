using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
namespace DataPiratesTeam.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesInfoSContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesInfoSContext>>()))
            {
                if (context.InfoS.Any())
                {
                    return;   // DB has been seeded
                }

                context.InfoS.AddRange(

                    new InfoS
                    {
                        Name = "Akshita Lathar",
                        Email = "akshitalathar@gmail.com",
                        Phone = "0000000000",
                        Address = "123 xyz",
                        Major = "Computer Science",
                        Degree = "Bachelors",
                        University = "Miami University",
                        Interest = "Artificial Intelligence",
                        Work_Experience = "Web developement",
                        Gpa = "4",
                        Graduation_Date = "2021"
                    },

                    new InfoS
                    {
                        Name = "Bhuvan Shah",
                        Email = "bhuvanshah@gmail.com",
                        Phone = "0000000000",
                        Address = "123 xyz",
                        Major = "Software E",
                        Degree = "Masters",
                        University = "Miami University",
                        Interest = "Analytics",
                        Work_Experience = "Startup",
                        Gpa = "4",
                        Graduation_Date = "2023"
                    },

                    new InfoS
                    {
                        Name = "Reetik Chandra",
                        Email = "reetik@gmail.com",
                        Phone = "0000000000",
                        Address = "123 xyz",
                        Major = "Mathematics",
                        Degree = "Bachelors",
                        University = "Miami University",
                        Interest = "Cyber Security",
                        Work_Experience = "Tutor",
                        Gpa = "4",
                        Graduation_Date = "2023"
                    },

                    new InfoS
                    {
                        Name = "Debjyoti",
                        Email = "Debjyoti@gmail.com",
                        Phone = "0000000000",
                        Address = "123 xyz",
                        Major = "Finance",
                        Degree = "Bachelors",
                        University = "abc University",
                        Interest = "Consultancy",
                        Work_Experience = "None",
                        Gpa = "4",
                        Graduation_Date = "2022"
                    },

                    new InfoS
                    {
                        Name = "Mounika",
                        Email = "Mounika@gmail.com",
                        Phone = "0000000000",
                        Address = "1234 xyz",
                        Major = "Computer Science",
                        Degree = "Masters",
                        University = "xyz University",
                        Interest = "Machine Learning",
                        Work_Experience = "None",
                        Gpa = "4",
                        Graduation_Date = "2020"
                    },

                    new InfoS
                    {
                        Name = "Saranya",
                        Email = "Saranya@gmail.com",
                        Phone = "0000000000",
                        Address = "675 xyz",
                        Major = "Computer Science",
                        Degree = "Bachelors",
                        University = "xyz University",
                        Interest = "Back end",
                        Work_Experience = "None",
                        Gpa = "4",
                        Graduation_Date = "2024"
                    }


                    );
                context.SaveChanges();
            }
        }
    }
}