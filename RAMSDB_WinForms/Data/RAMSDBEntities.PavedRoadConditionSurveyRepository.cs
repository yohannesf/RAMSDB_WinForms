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
    public partial class PavedRoadConditionSurveyRepository : EntityFrameworkRepository<RAMSDBModel.PavedRoadConditionSurvey>, IPavedRoadConditionSurveyRepository
    {
        public PavedRoadConditionSurveyRepository(RAMSDBModel.RAMSDBEntities context) : base(context)
        {
        }

        public virtual ICollection<RAMSDBModel.PavedRoadConditionSurvey> GetAll()
        {
            return objectSet.ToList();
        }

        public virtual RAMSDBModel.PavedRoadConditionSurvey GetByKey(int _PRCSID)
        {
            return objectSet.SingleOrDefault(e => e.PRCSID == _PRCSID);
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
