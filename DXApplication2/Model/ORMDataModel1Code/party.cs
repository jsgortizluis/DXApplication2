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

    public partial class party : XPObject
    {
        string fFullname;
        public string Fullname
        {
            get { return fFullname; }
            set { SetPropertyValue<string>("Fullname", ref fFullname, value); }
        }
        string fAddress1;
        public string Address1
        {
            get { return fAddress1; }
            set { SetPropertyValue<string>("Address1", ref fAddress1, value); }
        }
        string fAddress3;
        public string Address3
        {
            get { return fAddress3; }
            set { SetPropertyValue<string>("Address3", ref fAddress3, value); }
        }
        string fAddress2;
        public string Address2
        {
            get { return fAddress2; }
            set { SetPropertyValue<string>("Address2", ref fAddress2, value); }
        }
        string fMobile;
        public string Mobile
        {
            get { return fMobile; }
            set { SetPropertyValue<string>("Mobile", ref fMobile, value); }
        }
        string fLandline;
        public string Landline
        {
            get { return fLandline; }
            set { SetPropertyValue<string>("Landline", ref fLandline, value); }
        }
        string feMail;
        public string eMail
        {
            get { return feMail; }
            set { SetPropertyValue<string>("eMail", ref feMail, value); }
        }
        DateTime fBirthday;
        public DateTime Birthday
        {
            get { return fBirthday; }
            set { SetPropertyValue<DateTime>("Birthday", ref fBirthday, value); }
        }
        string fAttribute;
        public string Attribute
        {
            get { return fAttribute; }
            set { SetPropertyValue<string>("Attribute", ref fAttribute, value); }
        }
        [Association(@"appearanceReferencesparty")]
        public XPCollection<appearance> appearances { get { return GetCollection<appearance>("appearances"); } }
        [Association(@"case1Referencesparty")]
        public XPCollection<case1> case1s { get { return GetCollection<case1>("case1s"); } }
        [Association(@"case1Referencesparty1")]
        public XPCollection<case1> case1s1 { get { return GetCollection<case1>("case1s1"); } }
        [Association(@"case1Referencesparty2")]
        public XPCollection<case1> case1s2 { get { return GetCollection<case1>("case1s2"); } }
        [Association(@"case1Referencesparty3")]
        public XPCollection<case1> case1s3 { get { return GetCollection<case1>("case1s3"); } }
        public party(Session session) : base(session) { }
    }

}