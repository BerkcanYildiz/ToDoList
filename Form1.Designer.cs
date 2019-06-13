namespace todolist
{
    partial class ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.btnYeni = new System.Windows.Forms.ToolStripButton();
            this.btnDüzelt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnKes = new System.Windows.Forms.ToolStripButton();
            this.btnKopyala = new System.Windows.Forms.ToolStripButton();
            this.btnYapistir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnYardim = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDüzen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHakkimda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUygHakkında = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYardim = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpYeniGörev = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYapilacaklarListesi = new System.Windows.Forms.Label();
            this.clbYapilacaklarListesi = new System.Windows.Forms.CheckedListBox();
            this.lblTamamlananlarListesi = new System.Windows.Forms.Label();
            this.lstTamamlananlarListesi = new System.Windows.Forms.ListBox();
            this.txtYeniGörev = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpYeniGörev.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeni,
            this.btnDüzelt,
            this.btnSil,
            this.toolStripSeparator,
            this.btnKes,
            this.btnKopyala,
            this.btnYapistir,
            this.toolStripSeparator1,
            this.btnYardim});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSil
            // 
            this.btnSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(23, 22);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(23, 22);
            this.btnYeni.Text = "Yeni Görev";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnDüzelt
            // 
            this.btnDüzelt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDüzelt.Image = ((System.Drawing.Image)(resources.GetObject("btnDüzelt.Image")));
            this.btnDüzelt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDüzelt.Name = "btnDüzelt";
            this.btnDüzelt.Size = new System.Drawing.Size(23, 22);
            this.btnDüzelt.Text = "Düzenle";
            this.btnDüzelt.Click += new System.EventHandler(this.btnDüzelt_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btnKes
            // 
            this.btnKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKes.Image = ((System.Drawing.Image)(resources.GetObject("btnKes.Image")));
            this.btnKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(23, 22);
            this.btnKes.Text = "Kes";
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKopyala.Image = ((System.Drawing.Image)(resources.GetObject("btnKopyala.Image")));
            this.btnKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(23, 22);
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYapistir.Image = ((System.Drawing.Image)(resources.GetObject("btnYapistir.Image")));
            this.btnYapistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(23, 22);
            this.btnYapistir.Text = "Yapıştır";
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnYardim
            // 
            this.btnYardim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYardim.Image = ((System.Drawing.Image)(resources.GetObject("btnYardim.Image")));
            this.btnYardim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(23, 22);
            this.btnYardim.Text = "He&lp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDosya,
            this.mnuToDo,
            this.mnuHakkimda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDosya
            // 
            this.mnuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCikis});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(51, 20);
            this.mnuDosya.Text = "Dosya";
            // 
            // mnuCikis
            // 
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.Size = new System.Drawing.Size(180, 22);
            this.mnuCikis.Text = "Çıkış";
            // 
            // mnuToDo
            // 
            this.mnuToDo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYeni,
            this.mnuDüzen,
            this.mnuSil});
            this.mnuToDo.Name = "mnuToDo";
            this.mnuToDo.Size = new System.Drawing.Size(50, 20);
            this.mnuToDo.Text = "To Do";
            // 
            // mnuYeni
            // 
            this.mnuYeni.Image = global::todolist.Properties.Resources.iconfinder_plus_24_103172;
            this.mnuYeni.Name = "mnuYeni";
            this.mnuYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuYeni.Size = new System.Drawing.Size(180, 22);
            this.mnuYeni.Text = "Yeni";
            // 
            // mnuDüzen
            // 
            this.mnuDüzen.Image = global::todolist.Properties.Resources.iconfinder_new_24_103173;
            this.mnuDüzen.Name = "mnuDüzen";
            this.mnuDüzen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuDüzen.Size = new System.Drawing.Size(180, 22);
            this.mnuDüzen.Text = "Düzen";
            // 
            // mnuSil
            // 
            this.mnuSil.Image = global::todolist.Properties.Resources.iconfinder_cross_24_103181;
            this.mnuSil.Name = "mnuSil";
            this.mnuSil.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuSil.Size = new System.Drawing.Size(180, 22);
            this.mnuSil.Text = "Sil";
            // 
            // mnuHakkimda
            // 
            this.mnuHakkimda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUygHakkında,
            this.mnuYardim});
            this.mnuHakkimda.Name = "mnuHakkimda";
            this.mnuHakkimda.Size = new System.Drawing.Size(73, 20);
            this.mnuHakkimda.Text = "Hakkımda";
            // 
            // mnuUygHakkında
            // 
            this.mnuUygHakkında.Name = "mnuUygHakkında";
            this.mnuUygHakkında.Size = new System.Drawing.Size(181, 22);
            this.mnuUygHakkında.Text = "Uygulama Hakkında";
            // 
            // mnuYardim
            // 
            this.mnuYardim.Name = "mnuYardim";
            this.mnuYardim.Size = new System.Drawing.Size(181, 22);
            this.mnuYardim.Text = "Yardım";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clbYapilacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.lblYapilacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.grpYeniGörev);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstTamamlananlarListesi);
            this.splitContainer1.Panel2.Controls.Add(this.lblTamamlananlarListesi);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(800, 401);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 2;
            // 
            // grpYeniGörev
            // 
            this.grpYeniGörev.Controls.Add(this.txtYeniGörev);
            this.grpYeniGörev.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpYeniGörev.Location = new System.Drawing.Point(5, 5);
            this.grpYeniGörev.Name = "grpYeniGörev";
            this.grpYeniGörev.Size = new System.Drawing.Size(364, 54);
            this.grpYeniGörev.TabIndex = 0;
            this.grpYeniGörev.TabStop = false;
            this.grpYeniGörev.Text = "Yeni Görev";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 19);
            this.panel1.TabIndex = 1;
            // 
            // lblYapilacaklarListesi
            // 
            this.lblYapilacaklarListesi.AutoSize = true;
            this.lblYapilacaklarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYapilacaklarListesi.Location = new System.Drawing.Point(5, 78);
            this.lblYapilacaklarListesi.Name = "lblYapilacaklarListesi";
            this.lblYapilacaklarListesi.Padding = new System.Windows.Forms.Padding(5);
            this.lblYapilacaklarListesi.Size = new System.Drawing.Size(107, 23);
            this.lblYapilacaklarListesi.TabIndex = 2;
            this.lblYapilacaklarListesi.Text = "Yapılacaklar Listesi";
            // 
            // clbYapilacaklarListesi
            // 
            this.clbYapilacaklarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbYapilacaklarListesi.FormattingEnabled = true;
            this.clbYapilacaklarListesi.Location = new System.Drawing.Point(5, 101);
            this.clbYapilacaklarListesi.Name = "clbYapilacaklarListesi";
            this.clbYapilacaklarListesi.Size = new System.Drawing.Size(364, 295);
            this.clbYapilacaklarListesi.TabIndex = 3;
            this.clbYapilacaklarListesi.SelectedIndexChanged += new System.EventHandler(this.clbYapilacaklarListesi_SelectedIndexChanged);
            // 
            // lblTamamlananlarListesi
            // 
            this.lblTamamlananlarListesi.AutoSize = true;
            this.lblTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTamamlananlarListesi.Location = new System.Drawing.Point(5, 5);
            this.lblTamamlananlarListesi.Name = "lblTamamlananlarListesi";
            this.lblTamamlananlarListesi.Padding = new System.Windows.Forms.Padding(5);
            this.lblTamamlananlarListesi.Size = new System.Drawing.Size(121, 23);
            this.lblTamamlananlarListesi.TabIndex = 3;
            this.lblTamamlananlarListesi.Text = "Tamamlananlar Listesi";
            // 
            // lstTamamlananlarListesi
            // 
            this.lstTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTamamlananlarListesi.FormattingEnabled = true;
            this.lstTamamlananlarListesi.Location = new System.Drawing.Point(5, 28);
            this.lstTamamlananlarListesi.Name = "lstTamamlananlarListesi";
            this.lstTamamlananlarListesi.Size = new System.Drawing.Size(412, 368);
            this.lstTamamlananlarListesi.TabIndex = 4;
            // 
            // txtYeniGörev
            // 
            this.txtYeniGörev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYeniGörev.Location = new System.Drawing.Point(3, 16);
            this.txtYeniGörev.Multiline = true;
            this.txtYeniGörev.Name = "txtYeniGörev";
            this.txtYeniGörev.Size = new System.Drawing.Size(358, 35);
            this.txtYeniGörev.TabIndex = 0;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpYeniGörev.ResumeLayout(false);
            this.grpYeniGörev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYeni;
        private System.Windows.Forms.ToolStripButton btnDüzelt;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnKes;
        private System.Windows.Forms.ToolStripButton btnKopyala;
        private System.Windows.Forms.ToolStripButton btnYapistir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnYardim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDosya;
        private System.Windows.Forms.ToolStripMenuItem mnuCikis;
        private System.Windows.Forms.ToolStripMenuItem mnuToDo;
        private System.Windows.Forms.ToolStripMenuItem mnuYeni;
        private System.Windows.Forms.ToolStripMenuItem mnuDüzen;
        private System.Windows.Forms.ToolStripMenuItem mnuSil;
        private System.Windows.Forms.ToolStripMenuItem mnuHakkimda;
        private System.Windows.Forms.ToolStripMenuItem mnuUygHakkında;
        private System.Windows.Forms.ToolStripMenuItem mnuYardim;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox clbYapilacaklarListesi;
        private System.Windows.Forms.Label lblYapilacaklarListesi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpYeniGörev;
        private System.Windows.Forms.TextBox txtYeniGörev;
        private System.Windows.Forms.ListBox lstTamamlananlarListesi;
        private System.Windows.Forms.Label lblTamamlananlarListesi;
    }
}

