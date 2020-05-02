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
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using RAMSDB.Interface;

namespace RAMSDB.Data
{
    public partial class YearConditionSurveyConductedRepository : EntityFrameworkRepository<RAMSDBModel.YearConditionSurveyConducted>, IYearConditionSurveyConductedRepository
    {
        public YearConditionSurveyConductedRepository(RAMSDBModel.RAMSDBEntities context) : base(context)
        {
        }

        public virtual ICollection<RAMSDBModel.YearConditionSurveyConducted> GetAll()
        {
            return objectSet.ToList();
        }

        public virtual RAMSDBModel.YearConditionSurveyConducted GetByKey(int _YearCSID)
        {
            return objectSet.SingleOrDefault(e => e.YearCSID == _YearCSID);
        }

        public new RAMSDBModel.RAMSDBEntities Context 
        {
            get 
            {
                return (RAMSDBModel.RAMSDBEntities)base.Context;
            }
        }
    }
}
