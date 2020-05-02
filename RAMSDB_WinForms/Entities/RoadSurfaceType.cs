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
    [System.ComponentModel.DataAnnotations.Schema.Table("RoadSurfaceType", Schema = "dbo")]
    public partial class RoadSurfaceType : INotifyPropertyChanged
    {

        public RoadSurfaceType()
        {
            this.RoadsGISDatas = new ObservableListSource<RoadsGISData>();
            this.UnpavedRoadConditionSurveys = new ObservableListSource<UnpavedRoadConditionSurvey>();
            this.PavedRoadConditionSurveys = new ObservableListSource<PavedRoadConditionSurvey>();
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public virtual int SurfaceTypeID
        {
            get
            {
                return _SurfaceTypeID;
            }
            set
            {
                if (_SurfaceTypeID != value)
                {
                    _SurfaceTypeID = value;
                    OnPropertyChanged("SurfaceTypeID");
                }
            }
        }
        private int _SurfaceTypeID;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 1)]
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

        #endregion

        #region Navigation Properties
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadSurfaceType")]
        public virtual ObservableListSource<RoadsGISData> RoadsGISDatas
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadSurfaceType")]
        public virtual ObservableListSource<UnpavedRoadConditionSurvey> UnpavedRoadConditionSurveys
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("RoadSurfaceType")]
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