﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating Repositories and a Unit of Work for Entity Framework model.
// Code is generated on: 4/15/2020 1:45:00 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using RAMSDB.Interface;

namespace RAMSDB.Data
{
    public partial class EntityFrameworkRepository<T> : IRepository<T> where T : class
    {
        private DbContext context;
        protected DbSet<T> objectSet;

        public EntityFrameworkRepository(DbContext context)
        {

            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.context = context;
            this.objectSet = context.Set<T>();
        }

        public virtual void Add(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            objectSet.Add(entity);
        }

        public virtual void Remove(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            objectSet.Remove(entity);
        }

        public DbContext Context 
        {
            get 
            {
                return context;
            }
        }
	}
}