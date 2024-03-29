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
    [System.ComponentModel.DataAnnotations.Schema.Table("PavedOverallCondition", Schema = "dbo")]
    public partial class PavedOverallCondition : INotifyPropertyChanged
    {

        public PavedOverallCondition()
        {
            this.PavedRoadConditionSurveys_LeftDrainOverallCondition = new ObservableListSource<PavedRoadConditionSurvey>();
            this.PavedRoadConditionSurveys_RightDrainOverallCondition = new ObservableListSource<PavedRoadConditionSurvey>();
            this.PavedRoadConditionSurveys_CarriagewayOverallCondition = new ObservableListSource<PavedRoadConditionSurvey>();
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public virtual int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                    OnPropertyChanged("ID");
                }
            }
        }
        private int _ID;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 1)]
        public virtual int CarriagewayDrainageConditionRate
        {
            get
            {
                return _CarriagewayDrainageConditionRate;
            }
            set
            {
                if (_CarriagewayDrainageConditionRate != value)
                {
                    _CarriagewayDrainageConditionRate = value;
                    OnPropertyChanged("CarriagewayDrainageConditionRate");
                }
            }
        }
        private int _CarriagewayDrainageConditionRate;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "text", Order = 2)]
        public virtual string DefectCarriageway
        {
            get
            {
                return _DefectCarriageway;
            }
            set
            {
                if (_DefectCarriageway != value)
                {
                    _DefectCarriageway = value;
                    OnPropertyChanged("DefectCarriageway");
                }
            }
        }
        private string _DefectCarriageway;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "text", Order = 3)]
        public virtual string DefectDrainage
        {
            get
            {
                return _DefectDrainage;
            }
            set
            {
                if (_DefectDrainage != value)
                {
                    _DefectDrainage = value;
                    OnPropertyChanged("DefectDrainage");
                }
            }
        }
        private string _DefectDrainage;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 4)]
        public virtual string Condition
        {
            get
            {
                return _Condition;
            }
            set
            {
                if (_Condition != value)
                {
                    _Condition = value;
                    OnPropertyChanged("Condition");
                }
            }
        }
        private string _Condition;

        #endregion

        #region Navigation Properties
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("PavedOverallCondition_LeftDrainOverallCondition")]
        public virtual ObservableListSource<PavedRoadConditionSurvey> PavedRoadConditionSurveys_LeftDrainOverallCondition
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("PavedOverallCondition_RightDrainOverallCondition")]
        public virtual ObservableListSource<PavedRoadConditionSurvey> PavedRoadConditionSurveys_RightDrainOverallCondition
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("PavedOverallCondition_CarriagewayOverallCondition")]
        public virtual ObservableListSource<PavedRoadConditionSurvey> PavedRoadConditionSurveys_CarriagewayOverallCondition
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
