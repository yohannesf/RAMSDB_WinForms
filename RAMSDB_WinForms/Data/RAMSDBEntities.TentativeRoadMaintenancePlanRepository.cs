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
    public partial class TentativeRoadMaintenancePlanRepository : EntityFrameworkRepository<RAMSDBModel.TentativeRoadMaintenancePlan>, ITentativeRoadMaintenancePlanRepository
    {
        public TentativeRoadMaintenancePlanRepository(RAMSDBModel.RAMSDBEntities context) : base(context)
        {
        }

        public virtual ICollection<RAMSDBModel.TentativeRoadMaintenancePlan> GetAll()
        {
            return objectSet.ToList();
        }

        public virtual RAMSDBModel.TentativeRoadMaintenancePlan GetByKey(int _TentRMaintPlan)
        {
            return objectSet.SingleOrDefault(e => e.TentRMaintPlan == _TentRMaintPlan);
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