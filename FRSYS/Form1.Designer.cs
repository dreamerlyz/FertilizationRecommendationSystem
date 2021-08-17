namespace FRSYS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.BtnIDT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frTYield = new System.Windows.Forms.TextBox();
            this.frBYield = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frLbl11 = new System.Windows.Forms.Label();
            this.frLbl2 = new System.Windows.Forms.Label();
            this.frLbl1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.frRTB = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.CausesValidation = false;
            this.axToolbarControl1.Location = new System.Drawing.Point(13, 13);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(639, 28);
            this.axToolbarControl1.TabIndex = 0;
            this.axToolbarControl1.OnItemClick += new ESRI.ArcGIS.Controls.IToolbarControlEvents_Ax_OnItemClickEventHandler(this.axToolbarControl1_OnItemClick);
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Location = new System.Drawing.Point(13, 47);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(237, 600);
            this.axTOCControl1.TabIndex = 1;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(256, 54);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(396, 600);
            this.axMapControl1.TabIndex = 2;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            // 
            // BtnIDT
            // 
            this.BtnIDT.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnIDT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIDT.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnIDT.Location = new System.Drawing.Point(706, 12);
            this.BtnIDT.Name = "BtnIDT";
            this.BtnIDT.Size = new System.Drawing.Size(176, 36);
            this.BtnIDT.TabIndex = 3;
            this.BtnIDT.Text = "开始施肥推荐";
            this.BtnIDT.UseVisualStyleBackColor = false;
            this.BtnIDT.Click += new System.EventHandler(this.BtnIDT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frTYield);
            this.groupBox1.Controls.Add(this.frBYield);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.frLbl11);
            this.groupBox1.Controls.Add(this.frLbl2);
            this.groupBox1.Controls.Add(this.frLbl1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "水稻产量设定";
            // 
            // frTYield
            // 
            this.frTYield.Location = new System.Drawing.Point(110, 119);
            this.frTYield.Name = "frTYield";
            this.frTYield.Size = new System.Drawing.Size(100, 31);
            this.frTYield.TabIndex = 5;
            this.frTYield.Text = "5700";
            // 
            // frBYield
            // 
            this.frBYield.Location = new System.Drawing.Point(110, 55);
            this.frBYield.Name = "frBYield";
            this.frBYield.Size = new System.Drawing.Size(100, 31);
            this.frBYield.TabIndex = 4;
            this.frBYield.Text = "3000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kg/ha";
            // 
            // frLbl11
            // 
            this.frLbl11.AutoSize = true;
            this.frLbl11.Location = new System.Drawing.Point(210, 58);
            this.frLbl11.Name = "frLbl11";
            this.frLbl11.Size = new System.Drawing.Size(62, 24);
            this.frLbl11.TabIndex = 2;
            this.frLbl11.Text = "Kg/ha";
            // 
            // frLbl2
            // 
            this.frLbl2.AutoSize = true;
            this.frLbl2.Location = new System.Drawing.Point(24, 120);
            this.frLbl2.Name = "frLbl2";
            this.frLbl2.Size = new System.Drawing.Size(82, 24);
            this.frLbl2.TabIndex = 1;
            this.frLbl2.Text = "目标产量";
            // 
            // frLbl1
            // 
            this.frLbl1.AutoSize = true;
            this.frLbl1.Location = new System.Drawing.Point(24, 58);
            this.frLbl1.Name = "frLbl1";
            this.frLbl1.Size = new System.Drawing.Size(82, 24);
            this.frLbl1.TabIndex = 0;
            this.frLbl1.Text = "基础产量";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.frRTB);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(13, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 358);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "施肥推荐结果";
            // 
            // frRTB
            // 
            this.frRTB.Location = new System.Drawing.Point(17, 41);
            this.frRTB.Name = "frRTB";
            this.frRTB.Size = new System.Drawing.Size(335, 317);
            this.frRTB.TabIndex = 0;
            this.frRTB.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(1032, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 633);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "施肥推荐";
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(273, 604);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 733);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.BtnIDT);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.axTOCControl1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "施肥推荐地理信息系统 V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.Button BtnIDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox frTYield;
        private System.Windows.Forms.TextBox frBYield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label frLbl11;
        private System.Windows.Forms.Label frLbl2;
        private System.Windows.Forms.Label frLbl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox frRTB;
        private System.Windows.Forms.GroupBox groupBox3;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
    }
}

