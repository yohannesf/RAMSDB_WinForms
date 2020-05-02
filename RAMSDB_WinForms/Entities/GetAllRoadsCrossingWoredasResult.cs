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
    [System.ComponentModel.DataAnnotations.Schema.ComplexType]
    public partial class GetAllRoadsCrossingWoredasResult : INotifyPropertyChanged
    {
        #region Properties

        public virtual int? RoadID
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
        private int? _RoadID;

        public virtual int? AdminID
        {
            get
            {
                return _AdminID;
            }
            set
            {
                if (_AdminID != value)
                {
                    _AdminID = value;
                    OnPropertyChanged("AdminID");
                }
            }
        }
        private int? _AdminID;

        public virtual decimal? RoadLengthInKm
        {
            get
            {
                return _RoadLengthInKm;
            }
            set
            {
                if (_RoadLengthInKm != value)
                {
                    _RoadLengthInKm = value;
                    OnPropertyChanged("RoadLengthInKm");
                }
            }
        }
        private decimal? _RoadLengthInKm;

        public virtual string RoadIdentifier
        {
            get
            {
                return _RoadIdentifier;
            }
            set
            {
                if (_RoadIdentifier != value)
                {
                    _RoadIdentifier = value;
                    OnPropertyChanged("RoadIdentifier");
                }
            }
        }
        private string _RoadIdentifier;

        public virtual string RoadOriginDestination
        {
            get
            {
                return _RoadOriginDestination;
            }
            set
            {
                if (_RoadOriginDestination != value)
                {
                    _RoadOriginDestination = value;
                    OnPropertyChanged("RoadOriginDestination");
                }
            }
        }
        private string _RoadOriginDestination;

        public virtual string RoadClassificationDescription
        {
            get
            {
                return _RoadClassificationDescription;
            }
            set
            {
                if (_RoadClassificationDescription != value)
                {
                    _RoadClassificationDescription = value;
                    OnPropertyChanged("RoadClassificationDescription");
                }
            }
        }
        private string _RoadClassificationDescription;

        public virtual string SurfaceTypeName
        {
            get
            {
                return _SurfaceTypeName;
            }
            set
            {
                if (_SurfaceTypeName != value)
                {
                    _SurfaceTypeName = value;
                    OnPropertyChanged("SurfaceTypeName");
                }
            }
        }
        private string _SurfaceTypeName;

        public virtual string ZoneName
        {
            get
            {
                return _ZoneName;
            }
            set
            {
                if (_ZoneName != value)
                {
                    _ZoneName = value;
                    OnPropertyChanged("ZoneName");
                }
            }
        }
        private string _ZoneName;

        public virtual string ZoneCode
        {
            get
            {
                return _ZoneCode;
            }
            set
            {
                if (_ZoneCode != value)
                {
                    _ZoneCode = value;
                    OnPropertyChanged("ZoneCode");
                }
            }
        }
        private string _ZoneCode;

        public virtual string WoredaName
        {
            get
            {
                return _WoredaName;
            }
            set
            {
                if (_WoredaName != value)
                {
                    _WoredaName = value;
                    OnPropertyChanged("WoredaName");
                }
            }
        }
        private string _WoredaName;

        public virtual string WoredaCode
        {
            get
            {
                return _WoredaCode;
            }
            set
            {
                if (_WoredaCode != value)
                {
                    _WoredaCode = value;
                    OnPropertyChanged("WoredaCode");
                }
            }
        }
        private string _WoredaCode;

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