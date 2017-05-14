namespace patientregistry
{
    partial class diagram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diagram));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dEXABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrDataSet = new patientregistry.registrDataSet();
            this.dEXATableAdapter = new patientregistry.registrDataSetTableAdapters.DEXATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEXABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.dEXABindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "BMD,";
            series1.XValueMember = "code dexa";
            series1.YValueMembers = "BMD";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(296, 292);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "BMD";
            // 
            // dEXABindingSource
            // 
            this.dEXABindingSource.DataMember = "DEXA";
            this.dEXABindingSource.DataSource = this.registrDataSet;
            // 
            // registrDataSet
            // 
            this.registrDataSet.DataSetName = "registrDataSet";
            this.registrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEXATableAdapter
            // 
            this.dEXATableAdapter.ClearBeforeFill = true;
            // 
            // diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 292);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "diagram";
            this.Text = "График динамики BMD";
            this.Load += new System.EventHandler(this.diagram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEXABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private registrDataSet registrDataSet;
        private System.Windows.Forms.BindingSource dEXABindingSource;
        private registrDataSetTableAdapters.DEXATableAdapter dEXATableAdapter;
    }
}