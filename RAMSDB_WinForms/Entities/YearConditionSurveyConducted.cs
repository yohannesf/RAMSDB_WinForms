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
    [System.ComponentModel.DataAnnotations.Schema.Table("YearConditionSurveyConducted", Schema = "dbo")]
    public partial class YearConditionSurveyConducted : INotifyPropertyChanged
    {

        public YearConditionSurveyConducted()
        {
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public virtual int YearCSID
        {
            get
            {
                return _YearCSID;
            }
            set
            {
                if (_YearCSID != value)
                {
                    _YearCSID = value;
                    OnPropertyChanged("YearCSID");
                }
            }
        }
        private int _YearCSID;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 1)]
        public virtual string YearCSEC
        {
            get
            {
                return _YearCSEC;
            }
            set
            {
                if (_YearCSEC != value)
                {
                    _YearCSEC = value;
                    OnPropertyChanged("YearCSEC");
                }
            }
        }
        private string _YearCSEC;

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
