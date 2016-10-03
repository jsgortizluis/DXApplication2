namespace DXApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoadCount = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLoadWeight = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.xpView1 = new DevExpress.Xpo.XPView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoadWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLoadWeight,
            this.repLoadCount});
            this.gridControl1.Size = new System.Drawing.Size(737, 342);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Date";
            this.gridColumn1.FieldName = "ResetTo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Load Count";
            this.gridColumn2.ColumnEdit = this.repLoadCount;
            this.gridColumn2.FieldName = "LoadCount";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // repLoadCount
            // 
            this.repLoadCount.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.repLoadCount.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repLoadCount.Maximum = 20;
            this.repLoadCount.Name = "repLoadCount";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Load Weight";
            this.gridColumn3.ColumnEdit = this.repLoadWeight;
            this.gridColumn3.FieldName = "LoadWeight";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // repLoadWeight
            // 
            this.repLoadWeight.EndColor = System.Drawing.Color.SandyBrown;
            this.repLoadWeight.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.repLoadWeight.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repLoadWeight.Maximum = 180;
            this.repLoadWeight.Name = "repLoadWeight";
            this.repLoadWeight.PercentView = false;
            this.repLoadWeight.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.repLoadWeight.ShowTitle = true;
            this.repLoadWeight.StartColor = System.Drawing.Color.Maroon;
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(DXApplication2.Model.j_embuscado_cms.docket);
            // 
            // xpView1
            // 
            this.xpView1.ObjectType = typeof(DXApplication2.Model.j_embuscado_cms.docket);
            this.xpView1.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("ResetTo", DevExpress.Xpo.SortDirection.None, "GetDate([ResetTo])", true, true),
            new DevExpress.Xpo.ViewProperty("LoadCount", DevExpress.Xpo.SortDirection.None, "Count()", false, true),
            new DevExpress.Xpo.ViewProperty("LoadWeight", DevExpress.Xpo.SortDirection.None, "Sum([Case.Stage.Weight])", false, true)});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 342);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLoadWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.XPView xpView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repLoadWeight;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repLoadCount;
    }
}

