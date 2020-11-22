namespace AnegaNonLinearCurvesHelper
{
    partial class ShowCurves
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listTrend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectTrend = new System.Windows.Forms.ComboBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.curveTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialogJson = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.curveTrend)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Load nonlinearcurves.json\r\nto show each";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Show Nonlinear Curves";
            // 
            // listTrend
            // 
            this.listTrend.AcceptsReturn = true;
            this.listTrend.Location = new System.Drawing.Point(379, 118);
            this.listTrend.Multiline = true;
            this.listTrend.Name = "listTrend";
            this.listTrend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listTrend.Size = new System.Drawing.Size(98, 248);
            this.listTrend.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Show this nonlinear curve";
            // 
            // selectTrend
            // 
            this.selectTrend.FormattingEnabled = true;
            this.selectTrend.Location = new System.Drawing.Point(16, 118);
            this.selectTrend.Name = "selectTrend";
            this.selectTrend.Size = new System.Drawing.Size(53, 21);
            this.selectTrend.TabIndex = 8;
            this.selectTrend.SelectedIndexChanged += new System.EventHandler(this.selectTrend_SelectedIndexChanged);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(16, 89);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(156, 23);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // curveTrend
            // 
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.curveTrend.ChartAreas.Add(chartArea1);
            this.curveTrend.Location = new System.Drawing.Point(13, 145);
            this.curveTrend.Name = "curveTrend";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "TrendData";
            this.curveTrend.Series.Add(series1);
            this.curveTrend.Size = new System.Drawing.Size(360, 221);
            this.curveTrend.TabIndex = 11;
            this.curveTrend.Text = "chart1";
            // 
            // openFileDialogJson
            // 
            this.openFileDialogJson.FileName = "openFileDialog1";
            // 
            // ShowCurves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 379);
            this.Controls.Add(this.curveTrend);
            this.Controls.Add(this.listTrend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectTrend);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShowCurves";
            this.Text = "ShowCurves";
            ((System.ComponentModel.ISupportInitialize)(this.curveTrend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox listTrend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectTrend;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart curveTrend;
        private System.Windows.Forms.OpenFileDialog openFileDialogJson;
    }
}