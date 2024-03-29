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
    [System.ComponentModel.DataAnnotations.Schema.Table("AdminBoundary", Schema = "dbo")]
    public partial class AdminBoundary : INotifyPropertyChanged
    {

        public AdminBoundary()
        {
            this.RoadsPerUsers = new ObservableListSource<RoadsPerUser>();
            this.PrioritizedRoads = new ObservableListSource<PrioritizedRoads>();
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public virtual int AdminID
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
        private int _AdminID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "geometry", Order = 1)]
        public virtual global::System.Data.Entity.Spatial.DbGeometry Shape
        {
            get
            {
                return _Shape;
            }
            set
            {
                if (_Shape != value)
                {
                    _Shape = value;
                    OnPropertyChanged("Shape");
                }
            }
        }
        private global::System.Data.Entity.Spatial.DbGeometry _Shape;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 2)]
        public virtual decimal? ObjectID
        {
            get
            {
                return _ObjectID;
            }
            set
            {
                if (_ObjectID != value)
                {
                    _ObjectID = value;
                    OnPropertyChanged("ObjectID");
                }
            }
        }
        private decimal? _ObjectID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 3)]
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

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 4)]
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

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 5)]
        public virtual string WoredaAltName
        {
            get
            {
                return _WoredaAltName;
            }
            set
            {
                if (_WoredaAltName != value)
                {
                    _WoredaAltName = value;
                    OnPropertyChanged("WoredaAltName");
                }
            }
        }
        private string _WoredaAltName;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 6)]
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

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 7)]
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

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 8)]
        public virtual string ZoneAltName
        {
            get
            {
                return _ZoneAltName;
            }
            set
            {
                if (_ZoneAltName != value)
                {
                    _ZoneAltName = value;
                    OnPropertyChanged("ZoneAltName");
                }
            }
        }
        private string _ZoneAltName;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 9)]
        public virtual string RegionName
        {
            get
            {
                return _RegionName;
            }
            set
            {
                if (_RegionName != value)
                {
                    _RegionName = value;
                    OnPropertyChanged("RegionName");
                }
            }
        }
        private string _RegionName;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 10)]
        public virtual string RegionCode
        {
            get
            {
                return _RegionCode;
            }
            set
            {
                if (_RegionCode != value)
                {
                    _RegionCode = value;
                    OnPropertyChanged("RegionCode");
                }
            }
        }
        private string _RegionCode;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 11)]
        public virtual string RegionAltName
        {
            get
            {
                return _RegionAltName;
            }
            set
            {
                if (_RegionAltName != value)
                {
                    _RegionAltName = value;
                    OnPropertyChanged("RegionAltName");
                }
            }
        }
        private string _RegionAltName;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 12)]
        public virtual decimal? ShapeLength
        {
            get
            {
                return _ShapeLength;
            }
            set
            {
                if (_ShapeLength != value)
                {
                    _ShapeLength = value;
                    OnPropertyChanged("ShapeLength");
                }
            }
        }
        private decimal? _ShapeLength;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 13)]
        public virtual decimal? ShapeAreaSqKm
        {
            get
            {
                return _ShapeAreaSqKm;
            }
            set
            {
                if (_ShapeAreaSqKm != value)
                {
                    _ShapeAreaSqKm = value;
                    OnPropertyChanged("ShapeAreaSqKm");
                }
            }
        }
        private decimal? _ShapeAreaSqKm;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 14)]
        public virtual decimal? Population
        {
            get
            {
                return _Population;
            }
            set
            {
                if (_Population != value)
                {
                    _Population = value;
                    OnPropertyChanged("Population");
                }
            }
        }
        private decimal? _Population;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 15)]
        public virtual decimal? RoadDensity
        {
            get
            {
                return _RoadDensity;
            }
            set
            {
                if (_RoadDensity != value)
                {
                    _RoadDensity = value;
                    OnPropertyChanged("RoadDensity");
                }
            }
        }
        private decimal? _RoadDensity;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 16)]
        public virtual int ShapeID
        {
            get
            {
                return _ShapeID;
            }
            set
            {
                if (_ShapeID != value)
                {
                    _ShapeID = value;
                    OnPropertyChanged("ShapeID");
                }
            }
        }
        private int _ShapeID;

        #endregion

        #region Navigation Properties
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("ShapeID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("AdminBoundaries")]
        public virtual ShapesCollection ShapesCollection
        {
            get
            {
                return _ShapesCollection;
            }
            set
            {
                if (_ShapesCollection != value)
                {
                    _ShapesCollection = value;
                    OnPropertyChanged("ShapesCollection");
                }
            }
        }
        private ShapesCollection _ShapesCollection;
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("AdminBoundary")]
        public virtual ObservableListSource<RoadsPerUser> RoadsPerUsers
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("AdminBoundary")]
        public virtual ObservableListSource<PrioritizedRoads> PrioritizedRoads
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
