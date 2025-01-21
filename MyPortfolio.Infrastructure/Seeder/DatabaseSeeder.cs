using MyPortfolio.Domain.Models;
using MyPortfolio.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPortfolio.Infrastructure.Seeder
{
    public static class DatabaseSeeder
    {
        public static void Seeder(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                var user = new ApplicationUser
                {
                    FirstName = "Mohamed",
                    LastName = "Doumbouya",
                    Adresses = new List<Address>
                    {
                        new Address
                        {
                            City = "Paris",
                            Country = "France",
                            IsActive = true
                        }
                    },
                    Email = "test.test@gmail.com",
                    Birthday = new DateTime(1999, 9, 16),
                    Degree = "SoftWare ingineer",
                    Website = "www.example.com",
                    PhoneNumber = "+123 456 7890",
                    Profession = "SoftWare ingineer",
                    Summary = "Summary Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore\r\nmagna aliqua.",
                    FreelanceAvailable = true,
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            Name = "HTML",
                            Percentage = 100,
                            CreateAt = DateTime.Now
                        },
                        new Skill
                        {
                            Name = "CSS",
                            Percentage = 90,
                            CreateAt = DateTime.Now
                        },
                        new Skill
                        {
                            Name = "JavaScript",
                            Percentage = 75,
                            CreateAt = DateTime.Now
                        }
                    },
                    Resume = new Resume
                    {
                        Summary = "Innovative and deadline-driven Graphic Designer with 3+ years of experience designing and developing user-centered digital/print marketing material from initial concept to final, polished deliverable.",
                        Educations = new List<Education>
                        {
                           new Education
                           {
                               Description = "Qui deserunt veniam. Et sed aliquam labore tempore sed quisquam iusto autem sit. Ea vero voluptatum qui ut dignissimos deleniti nerada porti sand markend",
                               Name = "Sainte Marie",
                               City = "Conakry",
                               Country = "Guinea",
                               Certification = "Baccalaureat Unique",
                               StartDate = new DateTime(2011, 9, 1),
                               EndDate = new DateTime(2014, 10, 1)
                           },
                           new Education
                           {
                               Description = "Qui deserunt veniam. Et sed aliquam labore tempore sed quisquam iusto autem sit. Ea vero voluptatum qui ut dignissimos deleniti nerada porti sand markend",
                               Name = "Faculté des Sciences et Techniques (FST)",
                               City = "Errachidia",
                               Country = "Maroc",
                               Certification = "Diplôme des Etudes Universitaires en Science et Technique (DEUST)",
                               StartDate = new DateTime(2014, 11, 2),
                               EndDate = new DateTime(2016, 10, 1)
                           },
                           new Education
                           {
                               Description = "Qui deserunt veniam. Et sed aliquam labore tempore sed quisquam iusto autem sit. Ea vero voluptatum qui ut dignissimos deleniti nerada porti sand markend",
                               Name = "Ingénierie Logiciel et Système d'Information",
                               City = "Rabat",
                               Country = "Maroc",
                               Certification = "Diplôme des études universitaires en science et technique (DEUST)",
                               StartDate = new DateTime(2016, 11, 2),
                               EndDate = new DateTime(2019, 06, 1)
                           }
                        },
                        Experiences = new List<Experience>
                        {
                            new Experience
                            {
                                Role = "Developpeur FullStack (.NET - Ruby)",
                                EntrepriseName = "Akka Technology",
                                City = "Casablanca",
                                Country = "Maroc",
                                StartDate = new DateTime(2019, 1, 1),
                                EndDate = new DateTime(2022, 10, 06),
                                Missions = new List<Mission>
                                {
                                    new Mission
                                    {
                                        Description = "Lead in the design, development, and implementation of the graphic, layout, and production communication materials"
                                    },
                                    new Mission
                                    {
                                        Description = "Delegate tasks to the 7 members of the design team and provide counsel on all aspects of the project"
                                    },
                                    new Mission
                                    {
                                        Description = "Supervise the assessment of all graphic materials in order to ensure quality and accuracy of the design"
                                    },
                                    new Mission
                                    {
                                        Description = "Oversee the efficient use of production project budgets ranging from $2,000 - $25,000"
                                    }
                                }
                            },
                            new Experience
                            {
                                Role = "Consultant .NET/C#",
                                EntrepriseName = "Groupe BPCE",
                                City = "Paris",
                                Country = "France",
                                StartDate = new DateTime(2022, 1, 1),
                                EndDate = null,
                                Missions = new List<Mission>
                                {
                                    new Mission
                                    {
                                        Description = "Lead in the design, development, and implementation of the graphic, layout, and production communication materials"
                                    },
                                    new Mission
                                    {
                                        Description = "Delegate tasks to the 7 members of the design team and provide counsel on all aspects of the project"
                                    },
                                    new Mission
                                    {
                                        Description = "Supervise the assessment of all graphic materials in order to ensure quality and accuracy of the design"
                                    },
                                    new Mission
                                    {
                                        Description = "Oversee the efficient use of production project budgets ranging from $2,000 - $25,000"
                                    }
                                }
                            }
                        }
                    },
                    Projects = new List<Project>
                    {
                        new Project
                        {
                            Category = new ProjectCategory
                            {
                                Name = "Web Design"
                            },                            
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/app-1.jpg",
                            Client = "ASU Company",
                            Title = "App 1",
                            Name = "Project information",
                            Description = "Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.",
                            Summary = "Lorem ipsum, dolor sit amet consectetur",
                            StartDate = new DateTime(2016, 01, 15)
                        },
                        new Project
                        {
                            Category = new ProjectCategory
                            {
                                Name = "Web Design"
                            },
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/product-1.jpg",
                            Client = "ASU Company",
                            Title = "Product 1",
                            Name = "Project information",
                            Description = "Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.",
                            Summary = "Lorem ipsum, dolor sit amet consectetur",
                            StartDate = new DateTime(2016, 01, 15)
                        },
                        new Project
                        {
                            Category = new ProjectCategory
                            {
                                Name = "Web Design"
                            },
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/branding-1.jpg",
                            Client = "ASU Company",
                            Title = "Branding 1",
                            Name = "Project information",
                            Description = "Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.",
                            Summary = "Lorem ipsum, dolor sit amet consectetur",
                            StartDate = new DateTime(2016, 01, 15)
                        },
                        new Project
                        {
                            Category = new ProjectCategory
                            {
                                Name = "Web Design"
                            },
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/books-1.jpg",
                            Client = "ASU Company",
                            Title = "Books 1",
                            Name = "Books 1",
                            Description = "Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.",
                            Summary = "Lorem ipsum, dolor sit amet consectetur",
                            StartDate = new DateTime(2016, 01, 15)
                        }
                    },
                    Services = new List<Service>
                    {
                        new Service
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new Service
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new Service
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new Service
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new Service
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        }
                    },
                    Testimonials = new List<Testimonial>
                    {
                        new Testimonial
                        {
                            Author = "Jena Karlis",
                            AuthorImage = "~/images/testimonials/testimonials-2.jpg",
                            Content = "Enim nisi quem export duis labore cillum quae magna enim sint quorum nulla quem veniam duis minim tempor labore quem eram duis noster aute amet eram fore quis sint minim.",
                            AuthorProfession = "Store Owner"
                        },
                        new Testimonial
                        {
                            Author = "Jena Karlis",
                            AuthorImage = "~/images/testimonials/testimonials-2.jpg",
                            Content = "Enim nisi quem export duis labore cillum quae magna enim sint quorum nulla quem veniam duis minim tempor labore quem eram duis noster aute amet eram fore quis sint minim.",
                            AuthorProfession = "Store Owner"
                        }
                    }
                };
            }
        }
    }
}
