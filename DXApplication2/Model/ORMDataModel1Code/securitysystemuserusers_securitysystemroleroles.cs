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

    public partial class securitysystemuserusers_securitysystemroleroles : XPObject
    {
        securitysystemrole fRoles;
        [Size(38)]
        [Association(@"securitysystemuserusers_securitysystemrolerolesReferencessecuritysystemrole")]
        public securitysystemrole Roles
        {
            get { return fRoles; }
            set { SetPropertyValue<securitysystemrole>("Roles", ref fRoles, value); }
        }
        securitysystemuser fUsers;
        [Size(38)]
        [Association(@"securitysystemuserusers_securitysystemrolerolesReferencessecuritysystemuser")]
        public securitysystemuser Users
        {
            get { return fUsers; }
            set { SetPropertyValue<securitysystemuser>("Users", ref fUsers, value); }
        }
        public securitysystemuserusers_securitysystemroleroles(Session session) : base(session) { }
    }

}
