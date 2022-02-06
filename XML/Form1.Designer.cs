namespace XML
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
            this.btn_temizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.lbl_bildirim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_xml_dosya_olustur = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xml_kaydet = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMIDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(898, 59);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(6);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(236, 138);
            this.btn_temizle.TabIndex = 26;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 254);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1402, 351);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(506, 159);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(6);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(342, 26);
            this.txt_soyad.TabIndex = 25;
            // 
            // lbl_bildirim
            // 
            this.lbl_bildirim.AutoSize = true;
            this.lbl_bildirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bildirim.ForeColor = System.Drawing.Color.Red;
            this.lbl_bildirim.Location = new System.Drawing.Point(24, 9);
            this.lbl_bildirim.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_bildirim.Name = "lbl_bildirim";
            this.lbl_bildirim.Size = new System.Drawing.Size(76, 26);
            this.lbl_bildirim.TabIndex = 17;
            this.lbl_bildirim.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Soyadı";
            // 
            // btn_xml_dosya_olustur
            // 
            this.btn_xml_dosya_olustur.Location = new System.Drawing.Point(24, 59);
            this.btn_xml_dosya_olustur.Margin = new System.Windows.Forms.Padding(6);
            this.btn_xml_dosya_olustur.Name = "btn_xml_dosya_olustur";
            this.btn_xml_dosya_olustur.Size = new System.Drawing.Size(342, 138);
            this.btn_xml_dosya_olustur.TabIndex = 16;
            this.btn_xml_dosya_olustur.Text = "XML Dosya Oku";
            this.btn_xml_dosya_olustur.UseVisualStyleBackColor = true;
            this.btn_xml_dosya_olustur.Click += new System.EventHandler(this.btn_xml_dosya_olustur_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(506, 109);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(6);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(342, 26);
            this.txt_ad.TabIndex = 23;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(506, 59);
            this.txt_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(342, 26);
            this.txt_id.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // btn_xml_kaydet
            // 
            this.btn_xml_kaydet.Location = new System.Drawing.Point(1146, 59);
            this.btn_xml_kaydet.Margin = new System.Windows.Forms.Padding(6);
            this.btn_xml_kaydet.Name = "btn_xml_kaydet";
            this.btn_xml_kaydet.Size = new System.Drawing.Size(236, 138);
            this.btn_xml_kaydet.TabIndex = 20;
            this.btn_xml_kaydet.Text = "Kaydet";
            this.btn_xml_kaydet.UseVisualStyleBackColor = true;
            this.btn_xml_kaydet.Click += new System.EventHandler(this.btn_xml_kaydet_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIDelete,
            this.TSMIGuncelle});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 101);
            // 
            // TSMIDelete
            // 
            this.TSMIDelete.Name = "TSMIDelete";
            this.TSMIDelete.Size = new System.Drawing.Size(150, 32);
            this.TSMIDelete.Text = "Sil";
            this.TSMIDelete.Click += new System.EventHandler(this.TSMIDelete_Click);
            // 
            // TSMIGuncelle
            // 
            this.TSMIGuncelle.Name = "TSMIGuncelle";
            this.TSMIGuncelle.Size = new System.Drawing.Size(240, 32);
            this.TSMIGuncelle.Text = "Güncelle";
            this.TSMIGuncelle.Click += new System.EventHandler(this.TSMIGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 605);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.lbl_bildirim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_xml_dosya_olustur);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xml_kaydet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label lbl_bildirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_xml_dosya_olustur;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xml_kaydet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMIDelete;
        private System.Windows.Forms.ToolStripMenuItem TSMIGuncelle;
    }
}

