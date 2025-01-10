using MyPortfolio.Models.DTO;

namespace MyPortfolio.Services
{
    public class ProjectService : IProjectService
    {
        public async Task<IEnumerable<ProjectDTO>> GetUserProjectsAsync()
        {
            var projects = new List<ProjectDTO>
                    {
                        new ProjectDTO
                        {
                            Category = "Web Design",
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/app-1.jpg",
                            Client = "ASU Company",
                            Title = "App 1",
                            Name = "Project information",
                            Description = "Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.",
                            Summary = "Lorem ipsum, dolor sit amet consectetur",
                            StartDate = new DateTime(2016, 01, 15)
                        },
                        new ProjectDTO
                        {
                            Category = "Web Design",
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/product-1.jpg",
                            Client = "ASU Company",
                            Title = "Product 1",
                            Name = "Project information",
                            Description = "Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.",
                            Summary = "Lorem ipsum, dolor sit amet consectetur",
                            StartDate = new DateTime(2016, 01, 15)
                        },
                        new ProjectDTO
                        {
                            Category = "Web Design",
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/branding-1.jpg",
                            Client = "ASU Company",
                            Title = "Branding 1",
                            Name = "Project information",
                            Description = "Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.",
                            Summary = "Lorem ipsum, dolor sit amet consectetur",
                            StartDate = new DateTime(2016, 01, 15)
                        },
                        new ProjectDTO
                        {
                            Category = "Web Design",
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/books-1.jpg",
                            Client = "ASU Company",
                            Title = "Books 1",
                            Name = "Books 1",
                            Description = "Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.",
                            Summary = "Lorem ipsum, dolor sit amet consectetur",
                            StartDate = new DateTime(2016, 01, 15)
                        }
                    };

            return await Task.FromResult(projects);
        }
    }
}
