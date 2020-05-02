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
    [System.ComponentModel.DataAnnotations.Schema.Table("RoadsGISData", Schema = "dbo")]
    public partial class RoadsGISData : INotifyPropertyChanged
    {

        public RoadsGISData()
        {
            this.MultiCriteriaAnalysisDatas = new ObservableListSource<MultiCriteriaAnalysisData>();
            this.RoadsPerUsers = new ObservableListSource<RoadsPerUser>();
            this.TentativeRoadMaintenancePlans = new ObservableListSource<TentativeRoadMaintenancePlan>();
            this.TrafficSurveys = new ObservableListSource<TrafficSurvey>();
            this.UnpavedRoadConditionSurveys = new ObservableListSource<UnpavedRoadConditionSurvey>();
            this.PrioritizedRoads = new ObservableListSource<PrioritizedRoads>();
            this.PavedRoadConditionSurveys = new ObservableListSource<PavedRoadConditionSurvey>();
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
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

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 2)]
        public virtual int? ObjectID
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
        private int? _ObjectID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 3)]
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

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 4)]
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

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 5)]
        public virtual string RoadOwner
        {
            get
            {
                return _RoadOwner;
            }
            set
            {
                if (_RoadOwner != value)
                {
                    _RoadOwner = value;
                    OnPropertyChanged("RoadOwner");
                }
            }
        }
        private string _RoadOwner;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 6)]
        public virtual string RoadOriginName
        {
            get
            {
                return _RoadOriginName;
            }
            set
            {
                if (_RoadOriginName != value)
                {
                    _RoadOriginName = value;
                    OnPropertyChanged("RoadOriginName");
                }
            }
        }
        private string _RoadOriginName;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 7)]
        public virtual string RoadDestinationName
        {
            get
            {
                return _RoadDestinationName;
            }
            set
            {
                if (_RoadDestinationName != value)
                {
                    _RoadDestinationName = value;
                    OnPropertyChanged("RoadDestinationName");
                }
            }
        }
        private string _RoadDestinationName;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 8)]
        public virtual string OriginDestDescription
        {
            get
            {
                return _OriginDestDescription;
            }
            set
            {
                if (_OriginDestDescription != value)
                {
                    _OriginDestDescription = value;
                    OnPropertyChanged("OriginDestDescription");
                }
            }
        }
        private string _OriginDestDescription;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 9)]
        public virtual int? RoadClassID
        {
            get
            {
                return _RoadClassID;
            }
            set
            {
                if (_RoadClassID != value)
                {
                    _RoadClassID = value;
                    OnPropertyChanged("RoadClassID");
                }
            }
        }
        private int? _RoadClassID;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 10)]
        public virtual int? SurfaceType
        {
            get
            {
                return _SurfaceType;
            }
            set
            {
                if (_SurfaceType != value)
                {
                    _SurfaceType = value;
                    OnPropertyChanged("SurfaceType");
                }
            }
        }
        private int? _SurfaceType;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 11)]
        public virtual decimal? CarriagewayWidth
        {
            get
            {
                return _CarriagewayWidth;
            }
            set
            {
                if (_CarriagewayWidth != value)
                {
                    _CarriagewayWidth = value;
                    OnPropertyChanged("CarriagewayWidth");
                }
            }
        }
        private decimal? _CarriagewayWidth;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 12)]
        public virtual string RoadConstructedYear
        {
            get
            {
                return _RoadConstructedYear;
            }
            set
            {
                if (_RoadConstructedYear != value)
                {
                    _RoadConstructedYear = value;
                    OnPropertyChanged("RoadConstructedYear");
                }
            }
        }
        private string _RoadConstructedYear;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 13)]
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

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "nvarchar", Order = 14)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed)]
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

        #endregion

        #region Navigation Properties
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadsGISData")]
        public virtual ObservableListSource<MultiCriteriaAnalysisData> MultiCriteriaAnalysisDatas
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("ShapeID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadsGISDatas")]
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
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("RoadClassID")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadsGISDatas")]
        public virtual RoadClassification RoadClassification
        {
            get
            {
                return _RoadClassification;
            }
            set
            {
                if (_RoadClassification != value)
                {
                    _RoadClassification = value;
                    OnPropertyChanged("RoadClassification");
                }
            }
        }
        private RoadClassification _RoadClassification;
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("SurfaceType")]
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadsGISDatas")]
        public virtual RoadSurfaceType RoadSurfaceType
        {
            get
            {
                return _RoadSurfaceType;
            }
            set
            {
                if (_RoadSurfaceType != value)
                {
                    _RoadSurfaceType = value;
                    OnPropertyChanged("RoadSurfaceType");
                }
            }
        }
        private RoadSurfaceType _RoadSurfaceType;
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadsGISData")]
        public virtual ObservableListSource<RoadsPerUser> RoadsPerUsers
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadsGISData")]
        public virtual ObservableListSource<TentativeRoadMaintenancePlan> TentativeRoadMaintenancePlans
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadsGISData")]
        public virtual ObservableListSource<TrafficSurvey> TrafficSurveys
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadsGISData")]
        public virtual ObservableListSource<UnpavedRoadConditionSurvey> UnpavedRoadConditionSurveys
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadsGISData")]
        public virtual ObservableListSource<PrioritizedRoads> PrioritizedRoads
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadsGISData")]
        public virtual ObservableListSource<PavedRoadConditionSurvey> PavedRoadConditionSurveys
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
