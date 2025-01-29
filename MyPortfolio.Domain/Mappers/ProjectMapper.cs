using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Models;
using System.Collections.Generic;

namespace MyPortfolio.Domain.Mappers
{
    public static class ProjectMapper
    {

        public static ProjectDto ConvertToProjectDTO(this Project project)
        {
            if(project == null)
            {
                return null;
            }

            var projectDto = new ProjectDto();

            projectDto.Name = project.Name;
            projectDto.ProjectURL = project.ProjectURL;
            projectDto.Id = project.Id;
            projectDto.Description = project.Description ?? string.Empty;
            projectDto.Summary = project.Summary ?? string.Empty;
            projectDto.Client = project.Client;
            projectDto.Category = project.Category?.Name ?? string.Empty;
            projectDto.StartDate = project.StartDate;
            projectDto.EndDate = project.EndDate;
            projectDto.ImageUrl = project.ImageUrl;
            projectDto.Title = project.Title;

            return projectDto;
        }     

        public static IEnumerable<ProjectDto> ConvertToProjectDtoList(this IEnumerable<Project> projects)
        {
            foreach( var project in projects)
            {
                yield return ConvertToProjectDTO(project);
            }
        }
    }
}
