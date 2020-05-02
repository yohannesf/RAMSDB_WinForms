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
    [System.ComponentModel.DataAnnotations.Schema.Table("Role", Schema = "dbo")]
    public partial class Role : INotifyPropertyChanged
    {

        public Role()
        {
            this.UserRoles = new ObservableListSource<UserRole>();
            OnCreated();
        }

        #region Properties

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "int", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public virtual int RoleID
        {
            get
            {
                return _RoleID;
            }
            set
            {
                if (_RoleID != value)
                {
                    _RoleID = value;
                    OnPropertyChanged("RoleID");
                }
            }
        }
        private int _RoleID;

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "varchar", Order = 1)]
        public virtual string RoleName
        {
            get
            {
                return _RoleName;
            }
            set
            {
                if (_RoleName != value)
                {
                    _RoleName = value;
                    OnPropertyChanged("RoleName");
                }
            }
        }
        private string _RoleName;

        #endregion

        #region Navigation Properties
        [System.ComponentModel.DataAnnotations.Schema.InverseProperty("Role")]
        public virtual ObservableListSource<UserRole> UserRoles
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
