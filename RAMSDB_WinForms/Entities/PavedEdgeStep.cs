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
    [System.ComponentModel.DataAnnotations.Schema.Table("PavedEdgeStep", Schema = "dbo")]
    public partial class PavedEdgeStep : INotifyPropertyChanged
    {

        public PavedEdgeStep()
        {
            this.PavedRoadConditionSurveys_LeftShoulderEdgeStep = new ObservableListSource<PavedRoadConditionSurvey>();
            this.PavedRoadConditionSurveys_RightShoulderEdgeStep = new ObservableListSource<PavedRoadConditionSurvey>();
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
        public virtual int EdgeStepRate
        {
            get
            {
                return _EdgeStepRate;
            }
            set
            {
                if (_EdgeStepRate != value)
                {
                    _EdgeStepRate = value;
                    OnPropertyChanged("EdgeStepRate");
                }
            }
        }
        private int _EdgeStepRate;

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "text", Order = 2)]
        public virtual string Defect
        {
            get
            {
                return _Defect;
            }
            set
            {
                if (_Defect != value)
                {
                    _Defect = value;
                    OnPropertyChanged("Defect");
                }
            }
        }
        private string _Defect;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric", Order = 3)]
        public virtual decimal QtyM3
        {
            get
            {
                return _QtyM3;
            }
            set
            {
                if (_QtyM3 != value)
                {
                    _QtyM3 = value;
                    OnPropertyChanged("QtyM3");
                }
            }
        }
        private decimal _QtyM3;

        #endregion

        #region Navigation Properties
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("PavedEdgeStep_LeftShoulderEdgeStep")]
        public virtual ObservableListSource<PavedRoadConditionSurvey> PavedRoadConditionSurveys_LeftShoulderEdgeStep
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("PavedEdgeStep_RightShoulderEdgeStep")]
        public virtual ObservableListSource<PavedRoadConditionSurvey> PavedRoadConditionSurveys_RightShoulderEdgeStep
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
