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
    [System.ComponentModel.DataAnnotations.Schema.Table("TrafficSurvey", Schema = "dbo")]
    public partial class TrafficSurvey : INotifyPropertyChanged
    {

        public TrafficSurvey()
        {
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public virtual int TrafficSurveyID
        {
            get
            {
                return _TrafficSurveyID;
            }
            set
            {
                if (_TrafficSurveyID != value)
                {
                    _TrafficSurveyID = value;
                    OnPropertyChanged("TrafficSurveyID");
                }
            }
        }
        private int _TrafficSurveyID;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "smallint", Order = 1)]
        public virtual short TrafficSurveyYear
        {
            get
            {
                return _TrafficSurveyYear;
            }
            set
            {
                if (_TrafficSurveyYear != value)
                {
                    _TrafficSurveyYear = value;
                    OnPropertyChanged("TrafficSurveyYear");
                }
            }
        }
        private short _TrafficSurveyYear;

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

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 3)]
        public virtual int VehicleTypeID
        {
            get
            {
                return _VehicleTypeID;
            }
            set
            {
                if (_VehicleTypeID != value)
                {
                    _VehicleTypeID = value;
                    OnPropertyChanged("VehicleTypeID");
                }
            }
        }
        private int _VehicleTypeID;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 4)]
        public virtual int TCHourID
        {
            get
            {
                return _TCHourID;
            }
            set
            {
                if (_TCHourID != value)
                {
                    _TCHourID = value;
                    OnPropertyChanged("TCHourID");
                }
            }
        }
        private int _TCHourID;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 5)]
        public virtual decimal TrafficCount
        {
            get
            {
                return _TrafficCount;
            }
            set
            {
                if (_TrafficCount != value)
                {
                    _TrafficCount = value;
                    OnPropertyChanged("TrafficCount");
                }
            }
        }
        private decimal _TrafficCount;

        #endregion

        #region Navigation Properties
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("VehicleTypeID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("TrafficSurveys")]
        public virtual VehicleType VehicleType
        {
            get
            {
                return _VehicleType;
            }
            set
            {
                if (_VehicleType != value)
                {
                    _VehicleType = value;
                    OnPropertyChanged("VehicleType");
                }
            }
        }
        private VehicleType _VehicleType;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("TCHourID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("TrafficSurveys")]
        public virtual TrafficCountHour TrafficCountHour
        {
            get
            {
                return _TrafficCountHour;
            }
            set
            {
                if (_TrafficCountHour != value)
                {
                    _TrafficCountHour = value;
                    OnPropertyChanged("TrafficCountHour");
                }
            }
        }
        private TrafficCountHour _TrafficCountHour;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("RoadID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("TrafficSurveys")]
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
