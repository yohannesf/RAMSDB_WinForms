namespace RAMSDB_WinForms.Administration
{
    partial class UserAdmin
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
            this.unpavedRoadConditionSurveyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadSurfaceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadsPerUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.unpavedRoadConditionSurveyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadSurfaceTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsPerUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // unpavedRoadConditionSurveyBindingSource
            // 
            this.unpavedRoadConditionSurveyBindingSource.DataSource = typeof(RAMSDBModel.UnpavedRoadConditionSurvey);
            // 
            // roadSurfaceTypeBindingSource
            // 
            this.roadSurfaceTypeBindingSource.DataSource = typeof(RAMSDBModel.RoadSurfaceType);
            // 
            // roadsPerUserBindingSource
            // 
            this.roadsPerUserBindingSource.DataSource = typeof(RAMSDBModel.RoadsPerUser);
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(800, 450);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // UserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl2);
            this.Name = "UserAdmin";
            this.Text = "UserAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.unpavedRoadConditionSurveyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadSurfaceTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsPerUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRCSYear;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadIDMain;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanSet;
        private DevExpress.XtraGrid.Columns.GridColumn colZone;
        private DevExpress.XtraGrid.Columns.GridColumn colWoreda;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadID;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadClass;
        private DevExpress.XtraGrid.Columns.GridColumn colRCSID;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadSectionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionChainageStartKM;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionChainageEndKM;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionLengthKM;
        private DevExpress.XtraGrid.Columns.GridColumn colSurfaceType;
        private DevExpress.XtraGrid.Columns.GridColumn colXBegin;
        private DevExpress.XtraGrid.Columns.GridColumn colYBegin;
        private DevExpress.XtraGrid.Columns.GridColumn colXEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colYEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colStartNodeID;
        private DevExpress.XtraGrid.Columns.GridColumn colEndNodeID;
        private DevExpress.XtraGrid.Columns.GridColumn colDrainageConditionLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colDrainageConditionRight;
        private DevExpress.XtraGrid.Columns.GridColumn colShoulderConditionLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colShoulderConditionRight;
        private DevExpress.XtraGrid.Columns.GridColumn colSurfaceCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colBottleneck;
        private DevExpress.XtraGrid.Columns.GridColumn colBottleneckSize;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfAssessment;
        private DevExpress.XtraGrid.Columns.GridColumn colAssessedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_ShoulderConditionLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_ShoulderConditionRight;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_SurfaceCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_DrainageConditionLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_DrainageConditionRight;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadSurfaceType;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadsGISData;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.BindingSource unpavedRoadConditionSurveyBindingSource;
        private System.Windows.Forms.BindingSource roadSurfaceTypeBindingSource;
        private System.Windows.Forms.BindingSource roadsPerUserBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}