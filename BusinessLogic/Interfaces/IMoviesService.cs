﻿using BusinessLogic.DTOs;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IMoviesService
    {
        Task<IEnumerable<MovieDto>> GetAllAsync();
        Task<IEnumerable<GenreDto>> GetGenresAsync();
        Task<MovieDto?> GetByIdAsync(int id);
        Task CreateAsync(CreateMovieDto movie);
        Task EditAsync(MovieDto movie);
        Task DeleteAsync(int id);
    }
}
