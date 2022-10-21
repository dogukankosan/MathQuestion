
namespace MatematikIslemleri.Forms
{
    partial class MathFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathFrm));
            this.Lbl_Number1 = new System.Windows.Forms.Label();
            this.Lbl_Type = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tOPLAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKARMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çARPMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Number2 = new System.Windows.Forms.Label();
            this.Txt_Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn_Start = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Lbl_timer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.Lbl_true = new System.Windows.Forms.Label();
            this.Lbl_FalseCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_QuestionCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Number1
            // 
            this.Lbl_Number1.AutoSize = true;
            this.Lbl_Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.Lbl_Number1.Location = new System.Drawing.Point(45, 48);
            this.Lbl_Number1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Number1.Name = "Lbl_Number1";
            this.Lbl_Number1.Size = new System.Drawing.Size(0, 51);
            this.Lbl_Number1.TabIndex = 0;
            // 
            // Lbl_Type
            // 
            this.Lbl_Type.AutoSize = true;
            this.Lbl_Type.ContextMenuStrip = this.contextMenuStrip1;
            this.Lbl_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.Lbl_Type.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Type.Location = new System.Drawing.Point(119, 48);
            this.Lbl_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Type.Name = "Lbl_Type";
            this.Lbl_Type.Size = new System.Drawing.Size(47, 51);
            this.Lbl_Type.TabIndex = 1;
            this.Lbl_Type.Text = "+";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tOPLAMAToolStripMenuItem,
            this.çIKARMAToolStripMenuItem,
            this.çARPMAToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 82);
            // 
            // tOPLAMAToolStripMenuItem
            // 
            this.tOPLAMAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tOPLAMAToolStripMenuItem.Image")));
            this.tOPLAMAToolStripMenuItem.Name = "tOPLAMAToolStripMenuItem";
            this.tOPLAMAToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.tOPLAMAToolStripMenuItem.Text = "TOPLAMA";
            this.tOPLAMAToolStripMenuItem.Click += new System.EventHandler(this.tOPLAMAToolStripMenuItem_Click);
            // 
            // çIKARMAToolStripMenuItem
            // 
            this.çIKARMAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çIKARMAToolStripMenuItem.Image")));
            this.çIKARMAToolStripMenuItem.Name = "çIKARMAToolStripMenuItem";
            this.çIKARMAToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.çIKARMAToolStripMenuItem.Text = "ÇIKARMA";
            this.çIKARMAToolStripMenuItem.Click += new System.EventHandler(this.çIKARMAToolStripMenuItem_Click);
            // 
            // çARPMAToolStripMenuItem
            // 
            this.çARPMAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çARPMAToolStripMenuItem.Image")));
            this.çARPMAToolStripMenuItem.Name = "çARPMAToolStripMenuItem";
            this.çARPMAToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.çARPMAToolStripMenuItem.Text = "ÇARPMA";
            this.çARPMAToolStripMenuItem.Click += new System.EventHandler(this.çARPMAToolStripMenuItem_Click);
            // 
            // Lbl_Number2
            // 
            this.Lbl_Number2.AutoSize = true;
            this.Lbl_Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.Lbl_Number2.Location = new System.Drawing.Point(173, 48);
            this.Lbl_Number2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Number2.Name = "Lbl_Number2";
            this.Lbl_Number2.Size = new System.Drawing.Size(0, 51);
            this.Lbl_Number2.TabIndex = 2;
            // 
            // Txt_Result
            // 
            this.Txt_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Txt_Result.Location = new System.Drawing.Point(307, 53);
            this.Txt_Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Result.MaxLength = 4;
            this.Txt_Result.Name = "Txt_Result";
            this.Txt_Result.Size = new System.Drawing.Size(180, 34);
            this.Txt_Result.TabIndex = 3;
            this.Txt_Result.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Result_KeyDown);
            this.Txt_Result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Result_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(249, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Appearance.BackColor = System.Drawing.Color.Green;
            this.Btn_Start.Appearance.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.Btn_Start.Appearance.Options.UseBackColor = true;
            this.Btn_Start.Appearance.Options.UseFont = true;
            this.Btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Start.Location = new System.Drawing.Point(0, 303);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(608, 33);
            this.Btn_Start.TabIndex = 5;
            this.Btn_Start.Text = "BAŞLAT";
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Txt_Result);
            this.groupControl1.Controls.Add(this.Lbl_Number1);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.Lbl_Type);
            this.groupControl1.Controls.Add(this.Lbl_Number2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(608, 146);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "TOPLAMA İŞLEMİ";
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.Lbl_timer);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 146);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(267, 157);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "SAYAÇ";
            // 
            // Lbl_timer
            // 
            this.Lbl_timer.AutoSize = true;
            this.Lbl_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Lbl_timer.ForeColor = System.Drawing.Color.Red;
            this.Lbl_timer.Location = new System.Drawing.Point(183, 42);
            this.Lbl_timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_timer.Name = "Lbl_timer";
            this.Lbl_timer.Size = new System.Drawing.Size(24, 25);
            this.Lbl_timer.TabIndex = 6;
            this.Lbl_timer.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "KALAN SÜRE:";
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.Lbl_true);
            this.groupControl3.Controls.Add(this.Lbl_FalseCount);
            this.groupControl3.Controls.Add(this.label9);
            this.groupControl3.Controls.Add(this.label7);
            this.groupControl3.Controls.Add(this.Lbl_QuestionCount);
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl3.Location = new System.Drawing.Point(341, 146);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(267, 157);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "SONUÇ";
            this.groupControl3.Visible = false;
            // 
            // Lbl_true
            // 
            this.Lbl_true.AutoSize = true;
            this.Lbl_true.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Lbl_true.ForeColor = System.Drawing.Color.Red;
            this.Lbl_true.Location = new System.Drawing.Point(183, 81);
            this.Lbl_true.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_true.Name = "Lbl_true";
            this.Lbl_true.Size = new System.Drawing.Size(24, 25);
            this.Lbl_true.TabIndex = 11;
            this.Lbl_true.Text = "0";
            // 
            // Lbl_FalseCount
            // 
            this.Lbl_FalseCount.AutoSize = true;
            this.Lbl_FalseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Lbl_FalseCount.ForeColor = System.Drawing.Color.Red;
            this.Lbl_FalseCount.Location = new System.Drawing.Point(183, 123);
            this.Lbl_FalseCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_FalseCount.Name = "Lbl_FalseCount";
            this.Lbl_FalseCount.Size = new System.Drawing.Size(24, 25);
            this.Lbl_FalseCount.TabIndex = 10;
            this.Lbl_FalseCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(8, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "YANLIŞ SAYISI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(8, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "DOĞRU SAYISI";
            // 
            // Lbl_QuestionCount
            // 
            this.Lbl_QuestionCount.AutoSize = true;
            this.Lbl_QuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Lbl_QuestionCount.ForeColor = System.Drawing.Color.Red;
            this.Lbl_QuestionCount.Location = new System.Drawing.Point(183, 42);
            this.Lbl_QuestionCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_QuestionCount.Name = "Lbl_QuestionCount";
            this.Lbl_QuestionCount.Size = new System.Drawing.Size(24, 25);
            this.Lbl_QuestionCount.TabIndex = 6;
            this.Lbl_QuestionCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(8, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "SORU SAYISI";
            // 
            // MathFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(608, 336);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Btn_Start);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MathFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞLEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MathFrm_FormClosing);
            this.Load += new System.EventHandler(this.Plus_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Number1;
        private System.Windows.Forms.Label Lbl_Type;
        private System.Windows.Forms.Label Lbl_Number2;
        private System.Windows.Forms.TextBox Txt_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton Btn_Start;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_timer;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label Lbl_FalseCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_QuestionCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_true;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tOPLAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKARMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çARPMAToolStripMenuItem;
    }
}