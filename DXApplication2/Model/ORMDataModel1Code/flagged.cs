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

    public partial class flagged : XPObject
    {
        string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"case1Referencesflagged")]
        public XPCollection<case1> case1s { get { return GetCollection<case1>("case1s"); } }
        public flagged(Session session) : base(session) { }
    }

}