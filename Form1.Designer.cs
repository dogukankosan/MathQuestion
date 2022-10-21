
namespace MatematikIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_Plus = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Extraction = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Impact = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Divide = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Report = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.Btn_Plus,
            this.Btn_Extraction,
            this.Btn_Impact,
            this.Btn_Divide,
            this.Btn_Report});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(520, 150);
            // 
            // Btn_Plus
            // 
            this.Btn_Plus.Caption = "İŞLEM";
            this.Btn_Plus.Id = 1;
            this.Btn_Plus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Plus.ImageOptions.Image")));
            this.Btn_Plus.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Plus.ImageOptions.LargeImage")));
            this.Btn_Plus.Name = "Btn_Plus";
            this.Btn_Plus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Plus_ItemClick);
            // 
            // Btn_Extraction
            // 
            this.Btn_Extraction.Caption = "ÇIKARMA";
            this.Btn_Extraction.Id = 2;
            this.Btn_Extraction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Extraction.ImageOptions.Image")));
            this.Btn_Extraction.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Extraction.ImageOptions.LargeImage")));
            this.Btn_Extraction.Name = "Btn_Extraction";
            // 
            // Btn_Impact
            // 
            this.Btn_Impact.Caption = "ÇARPMA";
            this.Btn_Impact.Id = 3;
            this.Btn_Impact.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Impact.ImageOptions.Image")));
            this.Btn_Impact.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Impact.ImageOptions.LargeImage")));
            this.Btn_Impact.Name = "Btn_Impact";
            // 
            // Btn_Divide
            // 
            this.Btn_Divide.Caption = "BÖLME";
            this.Btn_Divide.Id = 4;
            this.Btn_Divide.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Divide.ImageOptions.Image")));
            this.Btn_Divide.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Divide.ImageOptions.LargeImage")));
            this.Btn_Divide.Name = "Btn_Divide";
            // 
            // Btn_Report
            // 
            this.Btn_Report.Caption = "RAPORLAMA";
            this.Btn_Report.Id = 5;
            this.Btn_Report.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Report.ImageOptions.Image")));
            this.Btn_Report.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Report.ImageOptions.LargeImage")));
            this.Btn_Report.Name = "Btn_Report";
            this.Btn_Report.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Report_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "MATEMATİK İŞLEMLERİ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Plus);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "RAPOR";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.Btn_Report);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(520, 499);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MATEMATİK İŞLEMİ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem Btn_Plus;
        private DevExpress.XtraBars.BarButtonItem Btn_Extraction;
        private DevExpress.XtraBars.BarButtonItem Btn_Impact;
        private DevExpress.XtraBars.BarButtonItem Btn_Divide;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Btn_Report;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

