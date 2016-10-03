using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication2
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeDataSource()
        {
            xpCollection1.Session = new DevExpress.Xpo.Session(Model.j_embuscado_cms.ConnectionHelper.GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema));

            xpCollection1.Reload();

            //gridControl1.DataSource = xpCollection1;

            xpView1.Session = new DevExpress.Xpo.Session(Model.j_embuscado_cms.ConnectionHelper.GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema));
            xpView1.Criteria = CriteriaOperator.Parse("ResetTo is not null");
            xpView1.Reload();
            gridControl1.DataSource = xpView1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataSource();
        }
    }
}
