using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Services
{
    public class ExperienceService : IExperienceService
    {
        public async Task<IEnumerable<ExperienceDto>> GetUserExperiences()
        {
            var experiences = new List<ExperienceDto>
                        {
                            new ExperienceDto
                            {
                                Role = "Developpeur FullStack (.NET - Ruby)",
                                EntrepriseName = "Akka Technology",
                                City = "Casablanca",
                                Country = "Maroc",
                                StartDate = new DateTime(2019, 1, 1),
                                EndDate = new DateTime(2022, 10, 06),
                                Missions = new List<MissionDto>
                                {
                                    new MissionDto
                                    {
                                        Description = "Lead in the design, development, and implementation of the graphic, layout, and production communication materials"
                                    },
                                    new MissionDto
                                    {
                                        Description = "Delegate tasks to the 7 members of the design team and provide counsel on all aspects of the project"
                                    },
                                    new MissionDto
                                    {
                                        Description = "Supervise the assessment of all graphic materials in order to ensure quality and accuracy of the design"
                                    },
                                    new MissionDto
                                    {
                                        Description = "Oversee the efficient use of production project budgets ranging from $2,000 - $25,000"
                                    }
                                }
                            },
                            new ExperienceDto
                            {
                                Role = "Consultant .NET/C#",
                                EntrepriseName = "Groupe BPCE",
                                City = "Paris",
                                Country = "France",
                                StartDate = new DateTime(2022, 1, 1),
                                EndDate = null,
                                Missions = new List<MissionDto>
                                {
                                    new MissionDto
                                    {
                                        Description = "Lead in the design, development, and implementation of the graphic, layout, and production communication materials"
                                    },
                                    new MissionDto
                                    {
                                        Description = "Delegate tasks to the 7 members of the design team and provide counsel on all aspects of the project"
                                    },
                                    new MissionDto
                                    {
                                        Description = "Supervise the assessment of all graphic materials in order to ensure quality and accuracy of the design"
                                    },
                                    new MissionDto
                                    {
                                        Description = "Oversee the efficient use of production project budgets ranging from $2,000 - $25,000"
                                    }
                                }
                            }
                        };

            return await Task.FromResult(experiences);
        }
    }
}
