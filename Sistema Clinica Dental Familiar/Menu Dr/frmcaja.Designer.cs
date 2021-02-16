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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvtrans = new System.Windows.Forms.DataGridView();
            this.txtdinero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.grbtipo = new System.Windows.Forms.GroupBox();
            this.rdbegreso = new System.Windows.Forms.RadioButton();
            this.rdbingreso = new System.Windows.Forms.RadioButton();
            this.btnsave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnreport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btntrans = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrans)).BeginInit();
            this.grbtipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvtrans
            // 
            this.dgvtrans.AllowUserToAddRows = false;
            this.dgvtrans.AllowUserToDeleteRows = false;
            this.dgvtrans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtrans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.dgvtrans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvtrans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvtrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtrans.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtrans.Enabled = false;
            this.dgvtrans.EnableHeadersVisualStyles = false;
            this.dgvtrans.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvtrans.Location = new System.Drawing.Point(38, 30);
            this.dgvtrans.Margin = new System.Windows.Forms.Padding(0);
            this.dgvtrans.Name = "dgvtrans";
            this.dgvtrans.ReadOnly = true;
            this.dgvtrans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtrans.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtrans.RowHeadersVisible = false;
            this.dgvtrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvtrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtrans.Size = new System.Drawing.Size(691, 309);
            this.dgvtrans.TabIndex = 0;

            // 
            // txtdinero
            // 
            this.txtdinero.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtdinero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdinero.Enabled = false;
            this.txtdinero.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdinero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.txtdinero.Location = new System.Drawing.Point(587, 370);
            this.txtdinero.Name = "txtdinero";
            this.txtdinero.Size = new System.Drawing.Size(142, 25);
            this.txtdinero.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(417, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dinero Disponible:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcantidad.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.txtcantidad.Location = new System.Drawing.Point(127, 370);
            this.txtcantidad.MaxLength = 12;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(109, 25);
            this.txtcantidad.TabIndex = 7;
            this.txtcantidad.Visible = false;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // lblcantidad
            // 
            this.lblcantidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.lblcantidad.Location = new System.Drawing.Point(34, 370);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(88, 23);
            this.lblcantidad.TabIndex = 8;
            this.lblcantidad.Text = "Cantidad:";
            this.lblcantidad.Visible = false;
            // 
            // grbtipo
            // 
            this.grbtipo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grbtipo.Controls.Add(this.rdbegreso);
            this.grbtipo.Controls.Add(this.rdbingreso);
            this.grbtipo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtipo.ForeColor = System.Drawing.Color.DarkCyan;
            this.grbtipo.Location = new System.Drawing.Point(242, 347);
            this.grbtipo.Name = "grbtipo";
            this.grbtipo.Size = new System.Drawing.Size(169, 67);
            this.grbtipo.TabIndex = 9;
            this.grbtipo.TabStop = false;
            this.grbtipo.Text = "Transacción";
            this.grbtipo.Visible = false;
            // 
            // rdbegreso
            // 
            this.rdbegreso.AutoSize = true;
            this.rdbegreso.Location = new System.Drawing.Point(95, 26);
            this.rdbegreso.Name = "rdbegreso";
            this.rdbegreso.Size = new System.Drawing.Size(70, 23);
            this.rdbegreso.TabIndex = 1;
            this.rdbegreso.TabStop = true;
            this.rdbegreso.Text = "Egreso";
            this.rdbegreso.UseVisualStyleBackColor = true;
            // 
            // rdbingreso
            // 
            this.rdbingreso.AutoSize = true;
            this.rdbingreso.Location = new System.Drawing.Point(6, 26);
            this.rdbingreso.Name = "rdbingreso";
            this.rdbingreso.Size = new System.Drawing.Size(74, 23);
            this.rdbingreso.TabIndex = 0;
            this.rdbingreso.TabStop = true;
            this.rdbingreso.Text = "Ingreso";
            this.rdbingreso.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Active = false;
            this.btnsave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.BorderRadius = 0;
            this.btnsave.ButtonText = "Guardar";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.DisabledColor = System.Drawing.Color.Gray;
            this.btnsave.Enabled = false;
            this.btnsave.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsave.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.save;
            this.btnsave.Iconimage_right = null;
            this.btnsave.Iconimage_right_Selected = null;
            this.btnsave.Iconimage_Selected = null;
            this.btnsave.IconMarginLeft = 0;
            this.btnsave.IconMarginRight = 0;
            this.btnsave.IconRightVisible = true;
            this.btnsave.IconRightZoom = 0D;
            this.btnsave.IconVisible = true;
            this.btnsave.IconZoom = 70D;
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
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Textcolor = System.Drawing.Color.White;
            this.btnsave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnreport
            // 
            this.btnreport.Active = false;
            this.btnreport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnreport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreport.BorderRadius = 0;
            this.btnreport.ButtonText = "Crear Reporte";
            this.btnreport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreport.DisabledColor = System.Drawing.Color.Gray;
            this.btnreport.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnreport.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.health;
            this.btnreport.Iconimage_right = null;
            this.btnreport.Iconimage_right_Selected = null;
            this.btnreport.Iconimage_Selected = null;
            this.btnreport.IconMarginLeft = 0;
            this.btnreport.IconMarginRight = 0;
            this.btnreport.IconRightVisible = true;
            this.btnreport.IconRightZoom = 0D;
            this.btnreport.IconVisible = true;
            this.btnreport.IconZoom = 70D;
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
            this.btnreport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnreport.Textcolor = System.Drawing.Color.White;
            this.btnreport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btntrans
            // 
            this.btntrans.Active = false;
            this.btntrans.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btntrans.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btntrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btntrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntrans.BorderRadius = 0;
            this.btntrans.ButtonText = "   Realizar Transaccion";
            this.btntrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntrans.DisabledColor = System.Drawing.Color.Gray;
            this.btntrans.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrans.Iconcolor = System.Drawing.Color.Transparent;
            this.btntrans.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.payment;
            this.btntrans.Iconimage_right = null;
            this.btntrans.Iconimage_right_Selected = null;
            this.btntrans.Iconimage_Selected = null;
            this.btntrans.IconMarginLeft = 0;
            this.btntrans.IconMarginRight = 0;
            this.btntrans.IconRightVisible = true;
            this.btntrans.IconRightZoom = 0D;
            this.btntrans.IconVisible = true;
            this.btntrans.IconZoom = 70D;
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
            this.btntrans.Text = "   Realizar Transaccion";
            this.btntrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btntrans.Textcolor = System.Drawing.Color.White;
            this.btntrans.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrans.Click += new System.EventHandler(this.btntrans_Click);
            // 
            // frmcaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 517);
            this.Controls.Add(this.grbtipo);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdinero);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btntrans);
            this.Controls.Add(this.dgvtrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcaja";
            this.Text = "frmcaja";
            this.Load += new System.EventHandler(this.frmcaja_Load);
            this.Resize += new System.EventHandler(this.frmcaja_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrans)).EndInit();
            this.grbtipo.ResumeLayout(false);
            this.grbtipo.PerformLayout();
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
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.GroupBox grbtipo;
        private System.Windows.Forms.RadioButton rdbegreso;
        private System.Windows.Forms.RadioButton rdbingreso;
    }
}