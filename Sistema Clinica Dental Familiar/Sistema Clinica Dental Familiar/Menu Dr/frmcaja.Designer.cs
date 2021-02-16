namespace Sistema_Clinica_Dental_Familiar
{
    partial class frmcaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcaja));
            this.dgvtrans = new System.Windows.Forms.DataGridView();
            this.btntrans = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnreport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtdinero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrans)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtrans
            // 
            this.dgvtrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtrans.Location = new System.Drawing.Point(38, 30);
            this.dgvtrans.Name = "dgvtrans";
            this.dgvtrans.Size = new System.Drawing.Size(691, 327);
            this.dgvtrans.TabIndex = 0;
            // 
            // btntrans
            // 
            this.btntrans.Active = false;
            this.btntrans.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btntrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btntrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntrans.BorderRadius = 0;
            this.btntrans.ButtonText = "Realizar Transaccion";
            this.btntrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntrans.DisabledColor = System.Drawing.Color.Gray;
            this.btntrans.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrans.Iconcolor = System.Drawing.Color.Transparent;
            this.btntrans.Iconimage = ((System.Drawing.Image)(resources.GetObject("btntrans.Iconimage")));
            this.btntrans.Iconimage_right = null;
            this.btntrans.Iconimage_right_Selected = null;
            this.btntrans.Iconimage_Selected = null;
            this.btntrans.IconMarginLeft = 0;
            this.btntrans.IconMarginRight = 0;
            this.btntrans.IconRightVisible = true;
            this.btntrans.IconRightZoom = 0D;
            this.btntrans.IconVisible = true;
            this.btntrans.IconZoom = 90D;
            this.btntrans.IsTab = false;
            this.btntrans.Location = new System.Drawing.Point(38, 423);
            this.btntrans.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btntrans.Name = "btntrans";
            this.btntrans.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btntrans.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btntrans.OnHoverTextColor = System.Drawing.Color.White;
            this.btntrans.selected = false;
            this.btntrans.Size = new System.Drawing.Size(208, 48);
            this.btntrans.TabIndex = 1;
            this.btntrans.Text = "Realizar Transaccion";
            this.btntrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntrans.Textcolor = System.Drawing.Color.White;
            this.btntrans.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnreport
            // 
            this.btnreport.Active = false;
            this.btnreport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreport.BorderRadius = 0;
            this.btnreport.ButtonText = "Crear Reporte";
            this.btnreport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreport.DisabledColor = System.Drawing.Color.Gray;
            this.btnreport.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnreport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnreport.Iconimage")));
            this.btnreport.Iconimage_right = null;
            this.btnreport.Iconimage_right_Selected = null;
            this.btnreport.Iconimage_Selected = null;
            this.btnreport.IconMarginLeft = 0;
            this.btnreport.IconMarginRight = 0;
            this.btnreport.IconRightVisible = true;
            this.btnreport.IconRightZoom = 0D;
            this.btnreport.IconVisible = true;
            this.btnreport.IconZoom = 90D;
            this.btnreport.IsTab = false;
            this.btnreport.Location = new System.Drawing.Point(284, 423);
            this.btnreport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnreport.Name = "btnreport";
            this.btnreport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnreport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btnreport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnreport.selected = false;
            this.btnreport.Size = new System.Drawing.Size(208, 48);
            this.btnreport.TabIndex = 2;
            this.btnreport.Text = "Crear Reporte";
            this.btnreport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.Textcolor = System.Drawing.Color.White;
            this.btnreport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnsave
            // 
            this.btnsave.Active = false;
            this.btnsave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.BorderRadius = 0;
            this.btnsave.ButtonText = "Guardar";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.DisabledColor = System.Drawing.Color.Gray;
            this.btnsave.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsave.Iconimage")));
            this.btnsave.Iconimage_right = null;
            this.btnsave.Iconimage_right_Selected = null;
            this.btnsave.Iconimage_Selected = null;
            this.btnsave.IconMarginLeft = 0;
            this.btnsave.IconMarginRight = 0;
            this.btnsave.IconRightVisible = true;
            this.btnsave.IconRightZoom = 0D;
            this.btnsave.IconVisible = true;
            this.btnsave.IconZoom = 90D;
            this.btnsave.IsTab = false;
            this.btnsave.Location = new System.Drawing.Point(522, 423);
            this.btnsave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnsave.Name = "btnsave";
            this.btnsave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnsave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btnsave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsave.selected = false;
            this.btnsave.Size = new System.Drawing.Size(207, 48);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Guardar";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Textcolor = System.Drawing.Color.White;
            this.btnsave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtdinero
            // 
            this.txtdinero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdinero.Enabled = false;
            this.txtdinero.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdinero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.txtdinero.Location = new System.Drawing.Point(576, 383);
            this.txtdinero.Name = "txtdinero";
            this.txtdinero.Size = new System.Drawing.Size(153, 25);
            this.txtdinero.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(384, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dinero Disponible:";
            // 
            // frmcaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdinero);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btntrans);
            this.Controls.Add(this.dgvtrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcaja";
            this.Text = "frmcaja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtrans;
        private Bunifu.Framework.UI.BunifuFlatButton btntrans;
        private Bunifu.Framework.UI.BunifuFlatButton btnreport;
        private Bunifu.Framework.UI.BunifuFlatButton btnsave;
        private System.Windows.Forms.TextBox txtdinero;
        private System.Windows.Forms.Label label1;
    }
}