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

    public partial class appearance : XPObject
    {
        party fParty;
        [Association(@"appearanceReferencesparty")]
        public party Party
        {
            get { return fParty; }
            set { SetPropertyValue<party>("Party", ref fParty, value); }
        }
        notice fNotice;
        [Association(@"appearanceReferencesnotice")]
        public notice Notice
        {
            get { return fNotice; }
            set { SetPropertyValue<notice>("Notice", ref fNotice, value); }
        }
        remarksitems fRemarks;
        [Association(@"appearanceReferencesremarksitems")]
        public remarksitems Remarks
        {
            get { return fRemarks; }
            set { SetPropertyValue<remarksitems>("Remarks", ref fRemarks, value); }
        }
        attendance fAttendance;
        [Association(@"appearanceReferencesattendance")]
        public attendance Attendance
        {
            get { return fAttendance; }
            set { SetPropertyValue<attendance>("Attendance", ref fAttendance, value); }
        }
        docket fDocket;
        [Association(@"appearanceReferencesdocket")]
        public docket Docket
        {
            get { return fDocket; }
            set { SetPropertyValue<docket>("Docket", ref fDocket, value); }
        }
        standing fStanding;
        [Association(@"appearanceReferencesstanding")]
        public standing Standing
        {
            get { return fStanding; }
            set { SetPropertyValue<standing>("Standing", ref fStanding, value); }
        }
        string fNotes;
        public string Notes
        {
            get { return fNotes; }
            set { SetPropertyValue<string>("Notes", ref fNotes, value); }
        }
        public appearance(Session session) : base(session) { }
    }

}
