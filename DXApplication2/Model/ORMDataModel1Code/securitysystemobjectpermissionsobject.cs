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

    public partial class securitysystemobjectpermissionsobject : XPCustomObject
    {
        string fOid;
        [Key]
        [Size(38)]
        public string Oid
        {
            get { return fOid; }
            set { SetPropertyValue<string>("Oid", ref fOid, value); }
        }
        string fCriteria;
        [Size(SizeAttribute.Unlimited)]
        public string Criteria
        {
            get { return fCriteria; }
            set { SetPropertyValue<string>("Criteria", ref fCriteria, value); }
        }
        byte fAllowRead;
        public byte AllowRead
        {
            get { return fAllowRead; }
            set { SetPropertyValue<byte>("AllowRead", ref fAllowRead, value); }
        }
        byte fAllowWrite;
        public byte AllowWrite
        {
            get { return fAllowWrite; }
            set { SetPropertyValue<byte>("AllowWrite", ref fAllowWrite, value); }
        }
        byte fAllowDelete;
        public byte AllowDelete
        {
            get { return fAllowDelete; }
            set { SetPropertyValue<byte>("AllowDelete", ref fAllowDelete, value); }
        }
        byte fAllowNavigate;
        public byte AllowNavigate
        {
            get { return fAllowNavigate; }
            set { SetPropertyValue<byte>("AllowNavigate", ref fAllowNavigate, value); }
        }
        securitysystemtypepermissionsobject fOwner;
        [Size(38)]
        [Association(@"securitysystemobjectpermissionsobjectReferencessecuritysystemtypepermissionsobject")]
        public securitysystemtypepermissionsobject Owner
        {
            get { return fOwner; }
            set { SetPropertyValue<securitysystemtypepermissionsobject>("Owner", ref fOwner, value); }
        }
        public securitysystemobjectpermissionsobject(Session session) : base(session) { }
    }

}