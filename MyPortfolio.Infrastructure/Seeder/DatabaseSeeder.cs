using Microsoft.AspNetCore.Identity;
using MyPortfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Infrastructure.Seeder
{
    public static class DatabaseSeeder
    {
        public static async Task SeedUserAsync(UserManager<ApplicationUser> userManager)
        {
            var email = "integredoumbouya@gmail.com";
            var adminUser = await userManager.FindByEmailAsync(email);

            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    FirstName = "Mohamed",
                    LastName = "Doumbouya",
                    ProfilImgUrl = string.Empty,
                    Summary = "Senior Software Engineer with extensive experience in financial systems, full-stack development, and platform modernization. Proven track record in designing and optimizing mission-critical applications, modernizing legacy systems, and implementing secure, high-performance architectures. Experienced in mentoring junior developers, leading technical initiatives, and delivering scalable solutions across banking, asset management, and enterprise platforms. Combines deep technical expertise with a strategic vision for digital transformation and educational impact.",
                    Adresses = new List<Address>
                    {
                        new Address
                        {
                            City = "Paris",
                            Country = "France",
                            IsActive = true
                        }
                    },
                    Email = email,
                    UserName = email,
                    Birthday = new DateTime(1994, 9, 16),
                    Degree = "Software and Information Systems Engineer",
                    Website = "www.example.com",
                    PhoneNumber = "+33 7 63 96 00 28",
                    Profession = "SoftWare Engineer",
                    FreelanceAvailable = false,
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            Name = "C# (.NET Core / Framework)",
                            Percentage = 95,
                            CreateAt = DateTime.Now,
                            Category = new SkillCategory
                            {
                                Name = "Programming"
                            }
                        },
                        new Skill
                        {
                            Name = "Ruby / Ruby on Rails",
                            Percentage = 90,
                            CreateAt = DateTime.Now,
                            Category = new SkillCategory
                            {
                                Name = "Programming"
                            }
                        },
                        new Skill
                        {
                            Name = "HTML / CSS / Media Query / jQuery",
                            Percentage = 100,
                            CreateAt = DateTime.Now,
                            Category = new SkillCategory
                            {
                                Name = "Frontend"
                            }
                        },
                        new Skill
                        {
                            Name = "SQL Server / Couchbase / MariaDB / MySQL",
                            Percentage = 95,
                            CreateAt = DateTime.Now,
                            Category = new SkillCategory
                            {
                                Name = "Database"
                            }
                        },
                        new Skill
                        {
                            Name = "APIs REST / Microservices",
                            Percentage = 90,
                            CreateAt = DateTime.Now,
                            Category = new SkillCategory
                            {
                                Name = "Architecture"
                            }
                        },
                        new Skill
                        {
                            Name = "Secure Coding & Application Security",
                            Percentage = 85,
                            CreateAt = DateTime.Now,
                            Category = new SkillCategory
                            {
                                Name = "Security"
                            }
                        },
                        new Skill
                        {
                            Name = "Agile / Scrum / Kanban",
                            Percentage = 90,
                            CreateAt = DateTime.Now,
                            Category = new SkillCategory
                            {
                                Name = "Methodology"
                            }
                        }
                    },
                    Resume = new Resume
                    {
                        Summary = "Innovative and deadline-driven Graphic Designer with 3+ years of experience designing and developing user-centered digital/print marketing material from initial concept to final, polished deliverable.",
                        Educations = new List<Education>
                        {
                           new Education
                           {
                               Description = "I completed my secondary education at Sainte Marie de Dixinn High School, one of the leading institutions in the Republic of Guinea. During my academic journey there, I developed a strong foundation in mathematics and scientific disciplines.\r\n\r\nI graduated with highest honors (“Très Bien”) in the Scientific Mathematics track and was ranked 12th nationally in the Republic of Guinea. This achievement earned me a merit-based scholarship to pursue my higher education in Morocco.",
                               Name = "Sainte Marie",
                               City = "Conakry",
                               Country = "Guinea",
                               Certification = "Baccalaureat Unique",
                               StartDate = new DateTime(2011, 9, 1),
                               EndDate = new DateTime(2014, 10, 1)
                           },
                           new Education
                           {
                               Description = "I pursued two years of higher education at the Faculty of Sciences and Technology in Errachidia, Morocco. This experience marked an important stage in both my academic and personal development.\r\n\r\nBeyond the classroom, living in Errachidia introduced me to the value of community engagement and collective responsibility. I became actively involved with CESAM Errachidia (Confederation of African Pupils, Students, and Trainees in Morocco), where I contributed to initiatives supporting African students.\r\n\r\nThis involvement strengthened my leadership skills, broadened my intercultural perspective, and deepened my commitment to service and collaboration.",
                               Name = "Faculté des Sciences et Techniques (FST)",
                               City = "Errachidia",
                               Country = "Maroc",
                               Certification = "Diplôme des Etudes Universitaires en Science et Technique (DEUST)",
                               StartDate = new DateTime(2014, 11, 2),
                               EndDate = new DateTime(2016, 10, 1)
                           },
                           new Education
                           {
                               Description = "At the end of these two enriching years marked by both scientific rigor and meaningful social engagement. I successfully passed the highly competitive entrance examination to join ENSIAS Rabat (National School of Computer Science and Systems Analysis), one of Morocco’s leading engineering schools in the field of Information and Communication Technologies.\r\n\r\nThis milestone reflected not only my academic dedication but also my determination to pursue excellence in technology and innovation.",
                               Name = "Software and Information Systems Engineer",
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
                                Role = "Full-Stack Software Engineer – Enterprise & E-commerce Platforms",
                                EntrepriseName = "Akka Technology",
                                City = "Casablanca",
                                Country = "Maroc",
                                StartDate = new DateTime(2019, 1, 1),
                                EndDate = new DateTime(2022, 10, 06),
                                Missions = new List<Mission>
                                {
                                    new Mission
                                    {
                                        Name = "E-commerce Platform Convergence & API Development",
                                        Description = "Contributed to the technical convergence of large-scale e-commerce platforms by designing and implementing strategic ASP.NET Core APIs using Domain-Driven Design principles. Delivered scalable backend services, automated testing pipelines, and improved deployment workflows."
                                    },
                                    new Mission
                                    {
                                        Name = "Full-Stack Performance Optimization & Legacy Refactoring",
                                        Description = "Optimized backend SQL queries and refactored legacy C# and JavaScript components to enhance platform performance and maintainability. Implemented feature flipping strategies to dynamically manage high-traffic commercial events (e.g., Black Friday)."
                                    },
                                    new Mission
                                    {
                                        Name = "Advanced Redmine Customization & Plugin Engineering",
                                        Description = "Customized and extended Redmine’s core functionalities through advanced Ruby metaprogramming and custom plugin development. Designed workflow automation solutions and real-time resource forecasting modules to improve enterprise project allocation efficiency."
                                    },
                                    new Mission
                                    {
                                        Name = "Technical Mentorship & Engineering Best Practices",
                                        Description = "Mentored junior developers on clean code principles, Ruby/Rails customization strategies, and software engineering best practices. Promoted DRY and Convention over Configuration principles while supporting critical production systems."
                                    }
                                }
                            },
                            new Experience
                            {
                                Role = "Senior .NET Engineer – Financial Systems & Data Processing",
                                EntrepriseName = "Ostrum Asset Management & Natixis (BPCE Group)",
                                City = "Paris",
                                Country = "France",
                                StartDate = new DateTime(2022, 11, 7),
                                EndDate = null,
                                Missions = new List<Mission>
                                {
                                    new Mission
                                    {
                                        Name = "Mission-Critical Data Processing Optimization",
                                        Description = "Led the maintenance and optimization of critical .NET batch jobs responsible for extracting, transforming, and processing financial market data (CDS spreads, sensitivities, curves, market data). Improved system reliability, enhanced multithreading performance, and reduced operational risks through structured refactoring and monitoring automation."
                                    },
                                    new Mission
                                    {
                                        Name = "Financial API Architecture & XVA Systems Development",
                                        Description = "Designed and maintained high-performance .NET APIs for financial data aggregation and XVA metrics computation. Integrated heterogeneous data sources including Sybase, Oracle, SQL Server, and external financial APIs, ensuring real-time consistency and scalability."
                                    },
                                    new Mission
                                    {
                                        Name = "Legacy System Modernization & Secure Architecture Implementation",
                                        Description = "Led the architectural modernization roadmap of a critical asset management application, transitioning from legacy WinForms to a Domain-Driven Design-based API architecture. Implemented SSO authentication, automated security scanning (Checkmarx), and resolved all identified critical vulnerabilities."
                                    },
                                    new Mission
                                    {
                                        Name = "Application Security & Compliance Reinforcement",
                                        Description = "Strengthened application security posture by integrating secure coding standards, vulnerability scanning pipelines, and access control systems. Ensured compliance with enterprise security policies while maintaining operational continuity for financial end-users."
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
                                Name = "SoftWare Engineer"
                            },
                            ProjectURL = "https://edu.dev.sinagui.com/",
                            ImageUrl = "~/images/portfolio/app-1.jpg",
                            Client = "SINAGUI",
                            Title = "SINAGUI",
                            Name = "Engineering Solutions for Digital Transformation in Guinea",
                            Description = "I currently work as a Software Engineer and consultant .NET on the development of an e-learning platform designed for the Republic of Guinea. This initiative aims to expand access to quality education through technology, addressing structural and geographical barriers to learning across the country.\r\n\r\nIn parallel, I am a founding associate of Sinagui, an emerging company with the ambition to become a key driver of digital transformation in Guinea. Our vision is to contribute meaningfully to the growth of the digital economy by building innovative, impactful, and locally adapted technological solutions.\r\n\r\nEducation has been the foundation of my journey. It has opened doors and created opportunities that shaped my path. This is why our first major initiative focuses on giving back by democratizing access to high-quality knowledge and making learning resources accessible throughout the entire Guinean territory.\r\n\r\nThrough technology, we aim not only to build platforms, but to empower people.",
                            Summary = "Technology professional dedicated to designing scalable digital solutions for education and economic growth. Currently leading the development of an e-learning platform for Guinea and co-founding Sinagui, a venture aimed at strengthening the nation’s digital ecosystem.",
                            StartDate = new DateTime(2019, 01, 15)
                        },
                        new Project
                        {
                            Category = new ProjectCategory
                            {
                                Name = "Empire Mandingue Schools"
                            },
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/empire-manding.png",
                            Client = "ASU Company",
                            Title = "Redefining Educational Excellence in West Africa",
                            Name = "Project information",
                            Description = "Empire Mandingue Schools is designed as a comprehensive educational institution from primary school to high school built on a foundation of excellence, discipline, innovation, and cultural pride.\r\n\r\nThe mission is to create a learning environment where African heritage and identity coexist with future-oriented education in technology, artificial intelligence, and applied sciences. While fully aligned with the official Guinean national curriculum, the program will be significantly enriched through practical learning, problem-solving methodologies, culture, creativity-driven projects, and early exposure to digital tools.\r\n\r\nThe objective is not only academic success, but the development of confident, skilled, and visionary young minds equipped to compete globally while remaining deeply rooted in their cultural values.\r\n\r\nEmpire Mandingue Schools aspires to become a benchmark institution in Guinea and across the sub-region, shaping future innovators, leaders, and change-makers.",
                            Summary = "Empire Mandingue Schools is a visionary educational initiative aimed at establishing a premier institution in Guinea and the wider West African region. The project seeks to combine academic excellence, African cultural identity, and emerging technologies to nurture a new generation of creative and forward-thinking leaders.",
                            StartDate = new DateTime(2025, 05, 15)
                        }
                    },
                    Services = new List<Service>
                    {
                        new Service
                        {
                            Title = "Technology & Software Architecture Advisory",
                            Description = "I provide technical consulting services to organizations seeking to modernize, optimize, or scale software systems. With strong expertise in .NET ecosystems, distributed systems, financial data processing, and secure coding practices, I help teams improve architecture quality, maintainability, and performance.\r\n\r\nMy services include legacy system modernization, API design using Domain-Driven Design principles, database optimization, application security reinforcement, and CI/CD implementation. I work with both startups and established organizations to deliver robust, production-ready solutions aligned with business objectives.",
                            Summary = "Senior software engineering consulting focused on designing scalable, secure, and high-performance systems."
                        },
                        new Service
                        {
                            Title = "Online Software Engineering Training & Mentorship",
                            Description = "I offer online training programs and personalized mentorship sessions for students, junior developers, and early-career engineers who want to accelerate their technical growth.\r\n\r\nTrainings cover topics such as .NET Core development, clean architecture, secure coding, API design, database optimization, and modern software development practices. My approach is hands-on, project-based, and aligned with industry standards.\r\n\r\nBeyond technical skills, I mentor developers on problem-solving methodology, code quality, professional mindset, and interview preparation — helping them transition confidently into high-level engineering environments.",
                            Summary = "Practical, industry-oriented software engineering training designed to bridge the gap between theory and real-world expertise.",
                            ImgUrl = "~/images/services.jpg"
                        },
                        new Service
                        {
                            Title = "Digital Education Strategy & Innovation Consulting",
                            Description = "I support educational institutions, entrepreneurs, and organizations in designing and implementing impactful digital learning solutions. With a strong belief in technology as a driver of access and opportunity, I contribute to the development of scalable e-learning platforms and digital education ecosystems.\r\n\r\nMy advisory services include technical architecture design for EdTech platforms, digital transformation roadmaps, integration of emerging technologies such as AI in learning systems, and strategic alignment between educational objectives and technological implementation.\r\n\r\nThe goal is to build sustainable, accessible, and future-ready educational infrastructures.",
                            Summary = "Advisory services at the intersection of technology, education, and digital transformation.",
                            ImgUrl = "~/images/services.jpg"
                        },
                        new Service
                        {
                            Title = "Financial Systems & Data Processing Engineering",
                            Description = "With professional experience in global financial environments, I contribute to the design, maintenance, and optimization of high-performance data processing systems.\r\n\r\nMy expertise includes development of .NET APIs, integration of heterogeneous data sources, financial metrics computation systems, secure application frameworks, and optimization of batch processing jobs.\r\n\r\nI bring a strong understanding of reliability, performance constraints, regulatory awareness, and secure software delivery essential components for mission-critical financial systems.",
                            Summary = "Advanced engineering expertise in financial systems, data processing, and mission-critical applications.",
                            ImgUrl = "~/images/services.jpg"
                        },
                        new Service
                        {
                            Title = "Tech & Digital Transformation Speaker",
                            Description = "I engage in knowledge-sharing initiatives through conferences, workshops, and technical talks focused on modern software engineering practices, secure application development, digital transformation in emerging markets, and the role of technology in education.\r\n\r\nMy perspective combines international engineering experience with a strong commitment to empowering the next generation of innovators — particularly within the African digital ecosystem.",
                            Summary = "Sharing knowledge on software engineering, digital transformation, and the future of education.",
                            ImgUrl = "~/images/services.jpg"
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

                await userManager.CreateAsync(adminUser, "Admin123!");
            }

            if (!await userManager.IsInRoleAsync(adminUser, "Admin"))
            {
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }

        public static async Task SeedRoleAsync(RoleManager<IdentityRole> roleManager)
        {
            var roleToAssign = new[] { "Admin", "User" };

            foreach (var role in roleToAssign)
            {
                var exist = await roleManager.RoleExistsAsync(role);
                if (!exist)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
