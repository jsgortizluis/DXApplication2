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

    public partial class typetype_ruleappliedruleapplied : XPObject
    {
        ruleapplied fRuleApplied;
        [Association(@"typetype_ruleappliedruleappliedReferencesruleapplied")]
        public ruleapplied RuleApplied
        {
            get { return fRuleApplied; }
            set { SetPropertyValue<ruleapplied>("RuleApplied", ref fRuleApplied, value); }
        }
        type fType;
        [Association(@"typetype_ruleappliedruleappliedReferencestype")]
        public type Type
        {
            get { return fType; }
            set { SetPropertyValue<type>("Type", ref fType, value); }
        }
        public typetype_ruleappliedruleapplied(Session session) : base(session) { }
    }

}
