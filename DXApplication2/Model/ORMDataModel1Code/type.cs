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

    public partial class type : XPObject
    {
        string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association(@"case1Referencestype")]
        public XPCollection<case1> case1s { get { return GetCollection<case1>("case1s"); } }
        [Association(@"typetype_kindkindReferencestype")]
        public XPCollection<typetype_kindkind> typetype_kindkinds { get { return GetCollection<typetype_kindkind>("typetype_kindkinds"); } }
        [Association(@"typetype_ruleappliedruleappliedReferencestype")]
        public XPCollection<typetype_ruleappliedruleapplied> typetype_ruleappliedruleapplieds { get { return GetCollection<typetype_ruleappliedruleapplied>("typetype_ruleappliedruleapplieds"); } }
        public type(Session session) : base(session) { }
    }

}
