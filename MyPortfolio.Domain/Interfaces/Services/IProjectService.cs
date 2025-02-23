﻿using MyPortfolio.Domain.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Services
{
    public interface IProjectService
    {
        Task<ProjectDto> GetProjectByIdAsync(int id);
        Task<IEnumerable<ProjectDto>> GetProjectsAsync();
    }
}