﻿using FieldServiceManagement.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Services
{
    public interface IGenericService
    {
        public interface IGenericService<TEntity, TDto> where TEntity : class where TDto : class
        {
            Task<Response<TDto>> GetbyIdAsync(int id);
            Task<Response<IEnumerable<TDto>>> GetAllAsync();
            Task<Response<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate);
            Task<Response<TDto>> AddAsync(TDto entity);
            Task<Response<NoDataDto>> Remove(int id);
            Task<Response<NoDataDto>> UpdateAsync(TDto entity, int id);
        }
    }
}
