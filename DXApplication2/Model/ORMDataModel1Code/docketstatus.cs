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

    public partial class docketstatus : XPObject
    {
        string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"docketReferencesdocketstatus")]
        public XPCollection<docket> dockets { get { return GetCollection<docket>("dockets"); } }
        public docketstatus(Session session) : base(session) { }
    }

}