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
    [System.ComponentModel.DataAnnotations.Schema.Table("MarketsConnectByRoad", Schema = "dbo")]
    public partial class MarketsConnectByRoad : INotifyPropertyChanged
    {

        public MarketsConnectByRoad()
        {
            this.MultiCriteriaAnalysisDatas = new ObservableListSource<MultiCriteriaAnalysisData>();
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public virtual int MarketsConnectByRoadID
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
        private int _MarketsConnectByRoadID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 1)]
        public virtual string MarketsConnectByRoadDescription
        {
            get
            {
                return _MarketsConnectByRoadDescription;
            }
            set
            {
                if (_MarketsConnectByRoadDescription != value)
                {
                    _MarketsConnectByRoadDescription = value;
                    OnPropertyChanged("MarketsConnectByRoadDescription");
                }
            }
        }
        private string _MarketsConnectByRoadDescription;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 2)]
        public virtual decimal? CategoryMaxPoints
        {
            get
            {
                return _CategoryMaxPoints;
            }
            set
            {
                if (_CategoryMaxPoints != value)
                {
                    _CategoryMaxPoints = value;
                    OnPropertyChanged("CategoryMaxPoints");
                }
            }
        }
        private decimal? _CategoryMaxPoints;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 3)]
        public virtual int CriteriaWeightID
        {
            get
            {
                return _CriteriaWeightID;
            }
            set
            {
                if (_CriteriaWeightID != value)
                {
                    _CriteriaWeightID = value;
                    OnPropertyChanged("CriteriaWeightID");
                }
            }
        }
        private int _CriteriaWeightID;

        #endregion

        #region Navigation Properties
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("CriteriaWeightID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("MarketsConnectByRoads")]
        public virtual CriteriaWeight CriteriaWeight
        {
            get
            {
                return _CriteriaWeight;
            }
            set
            {
                if (_CriteriaWeight != value)
                {
                    _CriteriaWeight = value;
                    OnPropertyChanged("CriteriaWeight");
                }
            }
        }
        private CriteriaWeight _CriteriaWeight;
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("MarketsConnectByRoad")]
        public virtual ObservableListSource<MultiCriteriaAnalysisData> MultiCriteriaAnalysisDatas
        {
            get;
            set;
        }

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
