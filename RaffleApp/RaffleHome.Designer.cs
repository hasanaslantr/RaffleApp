namespace RaffleApp
{
    partial class RaffleHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaffleHome));
            this.panelHead = new DevExpress.XtraEditors.PanelControl();
            this.panelControlFooter = new DevExpress.XtraEditors.PanelControl();
            this.BtnFileUpload = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDraw = new DevExpress.XtraEditors.SimpleButton();
            this.txtParticipants = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtReserves = new DevExpress.XtraEditors.TextEdit();
            this.lstWinners = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lstReserves = new DevExpress.XtraEditors.ListBoxControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveWinners = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveReserves = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelHead)).BeginInit();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFooter)).BeginInit();
            this.panelControlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParticipants.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReserves.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstWinners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstReserves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.Controls.Add(this.btnDraw);
            this.panelHead.Controls.Add(this.BtnFileUpload);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1184, 83);
            this.panelHead.TabIndex = 0;
            // 
            // panelControlFooter
            // 
            this.panelControlFooter.Controls.Add(this.pictureBox1);
            this.panelControlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlFooter.Location = new System.Drawing.Point(0, 624);
            this.panelControlFooter.Name = "panelControlFooter";
            this.panelControlFooter.Size = new System.Drawing.Size(1184, 196);
            this.panelControlFooter.TabIndex = 2;
            // 
            // BtnFileUpload
            // 
            this.BtnFileUpload.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFileUpload.Appearance.Options.UseFont = true;
            this.BtnFileUpload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage1")));
            this.BtnFileUpload.Location = new System.Drawing.Point(12, 12);
            this.BtnFileUpload.Name = "BtnFileUpload";
            this.BtnFileUpload.Size = new System.Drawing.Size(288, 40);
            this.BtnFileUpload.TabIndex = 0;
            this.BtnFileUpload.Text = "Çekiliş Listesini İçe AL";
            this.BtnFileUpload.Click += new System.EventHandler(this.BtnFileUpload_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(15, 76);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(484, 536);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(505, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(673, 97);
            this.button1.TabIndex = 4;
            this.button1.Text = "Çekilişe Katılacak Kişi Sayısı ???";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Appearance.Options.UseFont = true;
            this.btnDraw.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnDraw.Location = new System.Drawing.Point(890, 12);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(288, 40);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Çekilişi Başlat";
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // txtParticipants
            // 
            this.txtParticipants.EditValue = "";
            this.txtParticipants.Location = new System.Drawing.Point(526, 230);
            this.txtParticipants.Name = "txtParticipants";
            this.txtParticipants.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticipants.Properties.Appearance.Options.UseFont = true;
            this.txtParticipants.Size = new System.Drawing.Size(276, 32);
            this.txtParticipants.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(526, 199);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(264, 25);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Çekilşi Kazanacak Kişi Sayıs Giriniz";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(843, 199);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(150, 25);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Yedek Sayısı Giriniz";
            // 
            // txtReserves
            // 
            this.txtReserves.Location = new System.Drawing.Point(843, 230);
            this.txtReserves.Name = "txtReserves";
            this.txtReserves.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReserves.Properties.Appearance.Options.UseFont = true;
            this.txtReserves.Size = new System.Drawing.Size(276, 32);
            this.txtReserves.TabIndex = 7;
            // 
            // lstWinners
            // 
            this.lstWinners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstWinners.Location = new System.Drawing.Point(2, 28);
            this.lstWinners.Name = "lstWinners";
            this.lstWinners.Size = new System.Drawing.Size(298, 299);
            this.lstWinners.TabIndex = 9; 
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSaveWinners);
            this.groupControl1.Controls.Add(this.lstWinners);
            this.groupControl1.Location = new System.Drawing.Point(526, 283);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(302, 329);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Kazananlar";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnSaveReserves);
            this.groupControl2.Controls.Add(this.lstReserves);
            this.groupControl2.Location = new System.Drawing.Point(843, 283);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(302, 329);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Yedekler";
            // 
            // lstReserves
            // 
            this.lstReserves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstReserves.Location = new System.Drawing.Point(2, 28);
            this.lstReserves.Name = "lstReserves";
            this.lstReserves.Size = new System.Drawing.Size(298, 299);
            this.lstReserves.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1180, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveWinners
            // 
            this.btnSaveWinners.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWinners.Appearance.Options.UseFont = true;
            this.btnSaveWinners.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSaveWinners.Location = new System.Drawing.Point(222, 2);
            this.btnSaveWinners.Name = "btnSaveWinners";
            this.btnSaveWinners.Size = new System.Drawing.Size(75, 22);
            this.btnSaveWinners.TabIndex = 2;
            this.btnSaveWinners.Text = "Kaydet";
            this.btnSaveWinners.Click += new System.EventHandler(this.btnSaveWinners_Click);
            // 
            // btnSaveReserves
            // 
            this.btnSaveReserves.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReserves.Appearance.Options.UseFont = true;
            this.btnSaveReserves.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnSaveReserves.Location = new System.Drawing.Point(222, 2);
            this.btnSaveReserves.Name = "btnSaveReserves";
            this.btnSaveReserves.Size = new System.Drawing.Size(75, 22);
            this.btnSaveReserves.TabIndex = 10;
            this.btnSaveReserves.Text = "Kaydet";
            this.btnSaveReserves.Click += new System.EventHandler(this.btnSaveReserves_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Melik Berşah";
            // 
            // RaffleHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 820);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtReserves);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtParticipants);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControlFooter);
            this.Controls.Add(this.panelHead);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("RaffleHome.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RaffleHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Melik Berşah Yotube Kanalı Çekilişi Hediye Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.panelHead)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFooter)).EndInit();
            this.panelControlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParticipants.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReserves.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstWinners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstReserves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelHead;
        private DevExpress.XtraEditors.PanelControl panelControlFooter;
        private DevExpress.XtraEditors.SimpleButton BtnFileUpload;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnDraw;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit txtParticipants;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtReserves;
        private DevExpress.XtraEditors.ListBoxControl lstWinners;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ListBoxControl lstReserves;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnSaveWinners;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSaveReserves;
    }
}