using MyPortfolio.Models.DTO;

namespace MyPortfolio.Services
{
    public class ExperienceService : IExperienceService
    {
        public async Task<IEnumerable<ExperienceDTO>> GetUserExperiences()
        {
            var experiences = new List<ExperienceDTO>
                        {
                            new ExperienceDTO
                            {
                                Role = "Developpeur FullStack (.NET - Ruby)",
                                EntrepriseName = "Akka Technology",
                                City = "Casablanca",
                                Country = "Maroc",
                                StartDate = new DateTime(2019, 1, 1),
                                EndDate = new DateTime(2022, 10, 06),
                                Missions = new List<MissionDTO>
                                {
                                    new MissionDTO
                                    {
                                        Description = "Lead in the design, development, and implementation of the graphic, layout, and production communication materials"
                                    },
                                    new MissionDTO
                                    {
                                        Description = "Delegate tasks to the 7 members of the design team and provide counsel on all aspects of the project"
                                    },
                                    new MissionDTO
                                    {
                                        Description = "Supervise the assessment of all graphic materials in order to ensure quality and accuracy of the design"
                                    },
                                    new MissionDTO
                                    {
                                        Description = "Oversee the efficient use of production project budgets ranging from $2,000 - $25,000"
                                    }
                                }
                            },
                            new ExperienceDTO
                            {
                                Role = "Consultant .NET/C#",
                                EntrepriseName = "Groupe BPCE",
                                City = "Paris",
                                Country = "France",
                                StartDate = new DateTime(2022, 1, 1),
                                EndDate = null,
                                Missions = new List<MissionDTO>
                                {
                                    new MissionDTO
                                    {
                                        Description = "Lead in the design, development, and implementation of the graphic, layout, and production communication materials"
                                    },
                                    new MissionDTO
                                    {
                                        Description = "Delegate tasks to the 7 members of the design team and provide counsel on all aspects of the project"
                                    },
                                    new MissionDTO
                                    {
                                        Description = "Supervise the assessment of all graphic materials in order to ensure quality and accuracy of the design"
                                    },
                                    new MissionDTO
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
