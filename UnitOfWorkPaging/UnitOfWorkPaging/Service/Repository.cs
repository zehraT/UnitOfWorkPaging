﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkPaging.Interfaces;

namespace UnitOfWorkPaging.Service
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _repository;
        public Repository(DataContext dataContext)
        {
            _repository = dataContext.Set<T>();

        }
        public T Add(T entity)
        {
            _repository.Add(entity);
            return entity;
        }

        public T Delete(int id)
        {
            T entity = Get(id);
            if (entity!=null)
            {
                _repository.Remove(entity);
            }
            return entity;
        }

        public T Get(int id)
        {
            return _repository.Find(id);
           
        }

        public IEnumerable<T> List()
        {
            return _repository.ToList();
        }

        public T Update(T entity)
        {
             _repository.Update(entity);
            return entity;
        }
    }
}
