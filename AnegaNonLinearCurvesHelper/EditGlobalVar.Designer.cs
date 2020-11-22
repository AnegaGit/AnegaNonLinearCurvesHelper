namespace AnegaNonLinearCurvesHelper
{
    partial class EditGlobalVar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGlobalVar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ioFileName = new System.Windows.Forms.TextBox();
            this.ioDirectorx = new System.Windows.Forms.TextBox();
            this.ioMaxCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ioMaxCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Directory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Max curve count:";
            // 
            // ioFileName
            // 
            this.ioFileName.Location = new System.Drawing.Point(83, 15);
            this.ioFileName.Name = "ioFileName";
            this.ioFileName.Size = new System.Drawing.Size(320, 20);
            this.ioFileName.TabIndex = 2;
            this.ioFileName.TextChanged += new System.EventHandler(this.ioFileName_TextChanged);
            // 
            // ioDirectorx
            // 
            this.ioDirectorx.Location = new System.Drawing.Point(83, 41);
            this.ioDirectorx.Name = "ioDirectorx";
            this.ioDirectorx.Size = new System.Drawing.Size(320, 20);
            this.ioDirectorx.TabIndex = 2;
            this.ioDirectorx.TextChanged += new System.EventHandler(this.ioDirectorx_TextChanged);
            // 
            // ioMaxCount
            // 
            this.ioMaxCount.Location = new System.Drawing.Point(118, 67);
            this.ioMaxCount.Name = "ioMaxCount";
            this.ioMaxCount.Size = new System.Drawing.Size(62, 20);
            this.ioMaxCount.TabIndex = 3;
            this.ioMaxCount.ValueChanged += new System.EventHandler(this.ioMaxCount_ValueChanged);
            // 
            // EditGlobalVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 218);
            this.Controls.Add(this.ioMaxCount);
            this.Controls.Add(this.ioDirectorx);
            this.Controls.Add(this.ioFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditGlobalVar";
            this.Text = "Edit GlobalVar\'s";
            ((System.ComponentModel.ISupportInitialize)(this.ioMaxCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ioFileName;
        private System.Windows.Forms.TextBox ioDirectorx;
        private System.Windows.Forms.NumericUpDown ioMaxCount;
    }
}