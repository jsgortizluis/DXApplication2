﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DXApplication2.Model.j_embuscado_cms
{

    public partial class securitysystemuser : XPCustomObject
    {
        string fOid;
        [Key]
        [Size(38)]
        public string Oid
        {
            get { return fOid; }
            set { SetPropertyValue<string>("Oid", ref fOid, value); }
        }
        string fStoredPassword;
        [Size(SizeAttribute.Unlimited)]
        public string StoredPassword
        {
            get { return fStoredPassword; }
            set { SetPropertyValue<string>("StoredPassword", ref fStoredPassword, value); }
        }
        byte fChangePasswordOnFirstLogon;
        public byte ChangePasswordOnFirstLogon
        {
            get { return fChangePasswordOnFirstLogon; }
            set { SetPropertyValue<byte>("ChangePasswordOnFirstLogon", ref fChangePasswordOnFirstLogon, value); }
        }
        string fUserName;
        public string UserName
        {
            get { return fUserName; }
            set { SetPropertyValue<string>("UserName", ref fUserName, value); }
        }
        byte fIsActive;
        public byte IsActive
        {
            get { return fIsActive; }
            set { SetPropertyValue<byte>("IsActive", ref fIsActive, value); }
        }
        [Association(@"securitysystemuserusers_securitysystemrolerolesReferencessecuritysystemuser")]
        public XPCollection<securitysystemuserusers_securitysystemroleroles> securitysystemuserusers_securitysystemroleroless { get { return GetCollection<securitysystemuserusers_securitysystemroleroles>("securitysystemuserusers_securitysystemroleroless"); } }
        public securitysystemuser(Session session) : base(session) { }
    }

}
