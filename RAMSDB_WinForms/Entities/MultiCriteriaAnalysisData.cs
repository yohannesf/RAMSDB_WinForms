﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 4/15/2020 1:44:59 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RAMSDBModel
{
    [System.ComponentModel.DataAnnotations.Schema.Table("MultiCriteriaAnalysisData", Schema = "dbo")]
    public partial class MultiCriteriaAnalysisData : INotifyPropertyChanged
    {

        public MultiCriteriaAnalysisData()
        {
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public virtual int MCAnalysisID
        {
            get
            {
                return _MCAnalysisID;
            }
            set
            {
                if (_MCAnalysisID != value)
                {
                    _MCAnalysisID = value;
                    OnPropertyChanged("MCAnalysisID");
                }
            }
        }
        private int _MCAnalysisID;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "smallint", Order = 1)]
        public virtual short Year
        {
            get
            {
                return _Year;
            }
            set
            {
                if (_Year != value)
                {
                    _Year = value;
                    OnPropertyChanged("Year");
                }
            }
        }
        private short _Year;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 2)]
        public virtual int RoadID
        {
            get
            {
                return _RoadID;
            }
            set
            {
                if (_RoadID != value)
                {
                    _RoadID = value;
                    OnPropertyChanged("RoadID");
                }
            }
        }
        private int _RoadID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 3)]
        public virtual int? TradingCenterAlongRoadID
        {
            get
            {
                return _TradingCenterAlongRoadID;
            }
            set
            {
                if (_TradingCenterAlongRoadID != value)
                {
                    _TradingCenterAlongRoadID = value;
                    OnPropertyChanged("TradingCenterAlongRoadID");
                }
            }
        }
        private int? _TradingCenterAlongRoadID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 4)]
        public virtual int? KVCConnectedID
        {
            get
            {
                return _KVCConnectedID;
            }
            set
            {
                if (_KVCConnectedID != value)
                {
                    _KVCConnectedID = value;
                    OnPropertyChanged("KVCConnectedID");
                }
            }
        }
        private int? _KVCConnectedID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 5)]
        public virtual int? RoadTravFarmID
        {
            get
            {
                return _RoadTravFarmID;
            }
            set
            {
                if (_RoadTravFarmID != value)
                {
                    _RoadTravFarmID = value;
                    OnPropertyChanged("RoadTravFarmID");
                }
            }
        }
        private int? _RoadTravFarmID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 6)]
        public virtual int? CcentersAlongRoadID
        {
            get
            {
                return _CcentersAlongRoadID;
            }
            set
            {
                if (_CcentersAlongRoadID != value)
                {
                    _CcentersAlongRoadID = value;
                    OnPropertyChanged("CcentersAlongRoadID");
                }
            }
        }
        private int? _CcentersAlongRoadID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 7)]
        public virtual int? MarketsConnectByRoadID
        {
            get
            {
                return _MarketsConnectByRoadID;
            }
            set
            {
                if (_MarketsConnectByRoadID != value)
                {
                    _MarketsConnectByRoadID = value;
                    OnPropertyChanged("MarketsConnectByRoadID");
                }
            }
        }
        private int? _MarketsConnectByRoadID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 8)]
        public virtual int? HealthCentersAlongRoadID
        {
            get
            {
                return _HealthCentersAlongRoadID;
            }
            set
            {
                if (_HealthCentersAlongRoadID != value)
                {
                    _HealthCentersAlongRoadID = value;
                    OnPropertyChanged("HealthCentersAlongRoadID");
                }
            }
        }
        private int? _HealthCentersAlongRoadID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 9)]
        public virtual int? EducationCentersAlongRoadID
        {
            get
            {
                return _EducationCentersAlongRoadID;
            }
            set
            {
                if (_EducationCentersAlongRoadID != value)
                {
                    _EducationCentersAlongRoadID = value;
                    OnPropertyChanged("EducationCentersAlongRoadID");
                }
            }
        }
        private int? _EducationCentersAlongRoadID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 10)]
        public virtual int? OtherProjectsAlongRoadID
        {
            get
            {
                return _OtherProjectsAlongRoadID;
            }
            set
            {
                if (_OtherProjectsAlongRoadID != value)
                {
                    _OtherProjectsAlongRoadID = value;
                    OnPropertyChanged("OtherProjectsAlongRoadID");
                }
            }
        }
        private int? _OtherProjectsAlongRoadID;

        #endregion

        #region Navigation Properties
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("CcentersAlongRoadID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("MultiCriteriaAnalysisDatas")]
        public virtual CooperativeCentersAlongRoad CooperativeCentersAlongRoad
        {
            get
            {
                return _CooperativeCentersAlongRoad;
            }
            set
            {
                if (_CooperativeCentersAlongRoad != value)
                {
                    _CooperativeCentersAlongRoad = value;
                    OnPropertyChanged("CooperativeCentersAlongRoad");
                }
            }
        }
        private CooperativeCentersAlongRoad _CooperativeCentersAlongRoad;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("EducationCentersAlongRoadID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("MultiCriteriaAnalysisDatas")]
        public virtual EducationCentersAlongRoad EducationCentersAlongRoad
        {
            get
            {
                return _EducationCentersAlongRoad;
            }
            set
            {
                if (_EducationCentersAlongRoad != value)
                {
                    _EducationCentersAlongRoad = value;
                    OnPropertyChanged("EducationCentersAlongRoad");
                }
            }
        }
        private EducationCentersAlongRoad _EducationCentersAlongRoad;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("KVCConnectedID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("MultiCriteriaAnalysisDatas")]
        public virtual KebelesVillagesCommunitiesConnected KebelesVillagesCommunitiesConnected
        {
            get
            {
                return _KebelesVillagesCommunitiesConnected;
            }
            set
            {
                if (_KebelesVillagesCommunitiesConnected != value)
                {
                    _KebelesVillagesCommunitiesConnected = value;
                    OnPropertyChanged("KebelesVillagesCommunitiesConnected");
                }
            }
        }
        private KebelesVillagesCommunitiesConnected _KebelesVillagesCommunitiesConnected;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("HealthCentersAlongRoadID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("MultiCriteriaAnalysisDatas")]
        public virtual HealthCentersAlongRoad HealthCentersAlongRoad
        {
            get
            {
                return _HealthCentersAlongRoad;
            }
            set
            {
                if (_HealthCentersAlongRoad != value)
                {
                    _HealthCentersAlongRoad = value;
                    OnPropertyChanged("HealthCentersAlongRoad");
                }
            }
        }
        private HealthCentersAlongRoad _HealthCentersAlongRoad;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("MarketsConnectByRoadID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("MultiCriteriaAnalysisDatas")]
        public virtual MarketsConnectByRoad MarketsConnectByRoad
        {
            get
            {
                return _MarketsConnectByRoad;
            }
            set
            {
                if (_MarketsConnectByRoad != value)
                {
                    _MarketsConnectByRoad = value;
                    OnPropertyChanged("MarketsConnectByRoad");
                }
            }
        }
        private MarketsConnectByRoad _MarketsConnectByRoad;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("OtherProjectsAlongRoadID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("MultiCriteriaAnalysisDatas")]
        public virtual OtherProjectsAlongRoad OtherProjectsAlongRoad
        {
            get
            {
                return _OtherProjectsAlongRoad;
            }
            set
            {
                if (_OtherProjectsAlongRoad != value)
                {
                    _OtherProjectsAlongRoad = value;
                    OnPropertyChanged("OtherProjectsAlongRoad");
                }
            }
        }
        private OtherProjectsAlongRoad _OtherProjectsAlongRoad;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("RoadID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("MultiCriteriaAnalysisDatas")]
        public virtual RoadsGISData RoadsGISData
        {
            get
            {
                return _RoadsGISData;
            }
            set
            {
                if (_RoadsGISData != value)
                {
                    _RoadsGISData = value;
                    OnPropertyChanged("RoadsGISData");
                }
            }
        }
        private RoadsGISData _RoadsGISData;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("TradingCenterAlongRoadID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("MultiCriteriaAnalysisDatas")]
        public virtual TradingCentersAlongRoad TradingCentersAlongRoad
        {
            get
            {
                return _TradingCentersAlongRoad;
            }
            set
            {
                if (_TradingCentersAlongRoad != value)
                {
                    _TradingCentersAlongRoad = value;
                    OnPropertyChanged("TradingCentersAlongRoad");
                }
            }
        }
        private TradingCentersAlongRoad _TradingCentersAlongRoad;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("RoadTravFarmID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("MultiCriteriaAnalysisDatas")]
        public virtual RoadTraversesFarmland RoadTraversesFarmland
        {
            get
            {
                return _RoadTraversesFarmland;
            }
            set
            {
                if (_RoadTraversesFarmland != value)
                {
                    _RoadTraversesFarmland = value;
                    OnPropertyChanged("RoadTraversesFarmland");
                }
            }
        }
        private RoadTraversesFarmland _RoadTraversesFarmland;

        #endregion

        #region Extensibility Method Definitions
        partial void OnCreated();
        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) {

          if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

}
