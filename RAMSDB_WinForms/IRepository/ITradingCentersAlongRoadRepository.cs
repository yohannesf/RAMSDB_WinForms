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

namespace RAMSDB.Interface
{
    public partial interface ITradingCentersAlongRoadRepository : IRepository<RAMSDBModel.TradingCentersAlongRoad>
    {
        ICollection<RAMSDBModel.TradingCentersAlongRoad> GetAll();
        RAMSDBModel.TradingCentersAlongRoad GetByKey(int _TradingCenterAlongRoadID);
    }
}
