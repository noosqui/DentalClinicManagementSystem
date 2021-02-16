namespace Sistema_Clinica_Dental_Familiar
{
    partial class frminv
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvmaterial = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvtratamientos = new System.Windows.Forms.DataGridView();
            this.txtmaterial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btneditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnreport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncancel = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmaterial
            // 
            this.dgvmaterial.AllowUserToAddRows = false;
            this.dgvmaterial.AllowUserToDeleteRows = false;
            this.dgvmaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmaterial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvmaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.dgvmaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvmaterial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvmaterial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvmaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmaterial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvmaterial.EnableHeadersVisualStyles = false;
            this.dgvmaterial.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvmaterial.Location = new System.Drawing.Point(33, 73);
            this.dgvmaterial.Name = "dgvmaterial";
            this.dgvmaterial.ReadOnly = true;
            this.dgvmaterial.RowHeadersVisible = false;
            this.dgvmaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmaterial.Size = new System.Drawing.Size(455, 253);
            this.dgvmaterial.TabIndex = 0;
            this.dgvmaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmaterial_CellClick);
            this.dgvmaterial.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvmaterial_CellFormatting);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(502, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcantidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcantidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcantidad.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcantidad.Enabled = false;
            this.txtcantidad.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.txtcantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcantidad.HintForeColor = System.Drawing.Color.Empty;
            this.txtcantidad.HintText = "";
            this.txtcantidad.isPassword = false;
            this.txtcantidad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.txtcantidad.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.txtcantidad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.txtcantidad.LineThickness = 2;
            this.txtcantidad.Location = new System.Drawing.Point(645, 156);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidad.MaxLength = 4;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(112, 36);
            this.txtcantidad.TabIndex = 14;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // dgvtratamientos
            // 
            this.dgvtratamientos.AllowUserToAddRows = false;
            this.dgvtratamientos.AllowUserToDeleteRows = false;
            this.dgvtratamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtratamientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvtratamientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.dgvtratamientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvtratamientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvtratamientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 15F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtratamientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 15F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtratamientos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtratamientos.Enabled = false;
            this.dgvtratamientos.EnableHeadersVisualStyles = false;
            this.dgvtratamientos.Location = new System.Drawing.Point(33, 364);
            this.dgvtratamientos.Name = "dgvtratamientos";
            this.dgvtratamientos.ReadOnly = true;
            this.dgvtratamientos.RowHeadersVisible = false;
            this.dgvtratamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtratamientos.Size = new System.Drawing.Size(455, 125);
            this.dgvtratamientos.TabIndex = 23;
            // 
            // txtmaterial
            // 
            this.txtmaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtmaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtmaterial.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtmaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmaterial.Enabled = false;
            this.txtmaterial.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.txtmaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmaterial.HintForeColor = System.Drawing.Color.Empty;
            this.txtmaterial.HintText = "";
            this.txtmaterial.isPassword = false;
            this.txtmaterial.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.txtmaterial.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.txtmaterial.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.txtmaterial.LineThickness = 2;
            this.txtmaterial.Location = new System.Drawing.Point(610, 73);
            this.txtmaterial.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaterial.MaxLength = 40;
            this.txtmaterial.Name = "txtmaterial";
            this.txtmaterial.Size = new System.Drawing.Size(147, 36);
            this.txtmaterial.TabIndex = 25;
            this.txtmaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(505, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Material:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.label3.Location = new System.Drawing.Point(29, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Materiales:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(29, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tratamientos:";
            // 
            // btneditar
            // 
            this.btneditar.Active = false;
            this.btneditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btneditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneditar.BorderRadius = 0;
            this.btneditar.ButtonText = "Editar";
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.DisabledColor = System.Drawing.Color.Gray;
            this.btneditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btneditar.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.edit;
            this.btneditar.Iconimage_right = null;
            this.btneditar.Iconimage_right_Selected = null;
            this.btneditar.Iconimage_Selected = null;
            this.btneditar.IconMarginLeft = 0;
            this.btneditar.IconMarginRight = 0;
            this.btneditar.IconRightVisible = true;
            this.btneditar.IconRightZoom = 0D;
            this.btneditar.IconVisible = true;
            this.btneditar.IconZoom = 50D;
            this.btneditar.IsTab = false;
            this.btneditar.Location = new System.Drawing.Point(506, 287);
            this.btneditar.Name = "btneditar";
            this.btneditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btneditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btneditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneditar.selected = false;
            this.btneditar.Size = new System.Drawing.Size(251, 60);
            this.btneditar.TabIndex = 28;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneditar.Textcolor = System.Drawing.Color.White;
            this.btneditar.TextFont = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Click += new System.EventHandler(this.btnreabastecer_Click);
            // 
            // btnsave
            // 
            this.btnsave.Active = false;
            this.btnsave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.BorderRadius = 0;
            this.btnsave.ButtonText = "Guardar";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.DisabledColor = System.Drawing.Color.Gray;
            this.btnsave.Enabled = false;
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
            this.btnsave.IconZoom = 50D;
            this.btnsave.IsTab = false;
            this.btnsave.Location = new System.Drawing.Point(506, 429);
            this.btnsave.Name = "btnsave";
            this.btnsave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnsave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btnsave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsave.selected = false;
            this.btnsave.Size = new System.Drawing.Size(251, 60);
            this.btnsave.TabIndex = 22;
            this.btnsave.Text = "Guardar";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Textcolor = System.Drawing.Color.White;
            this.btnsave.TextFont = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnreport
            // 
            this.btnreport.Active = false;
            this.btnreport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btnreport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreport.BorderRadius = 0;
            this.btnreport.ButtonText = "Crear Reporte";
            this.btnreport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreport.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnreport.IconZoom = 90D;
            this.btnreport.IsTab = false;
            this.btnreport.Location = new System.Drawing.Point(506, 219);
            this.btnreport.Name = "btnreport";
            this.btnreport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnreport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btnreport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnreport.selected = false;
            this.btnreport.Size = new System.Drawing.Size(251, 60);
            this.btnreport.TabIndex = 21;
            this.btnreport.Text = "Crear Reporte";
            this.btnreport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnreport.Textcolor = System.Drawing.Color.White;
            this.btnreport.TextFont = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btncancel
            // 
            this.btncancel.Active = false;
            this.btncancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancel.BorderRadius = 0;
            this.btncancel.ButtonText = "Cancelar";
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.DisabledColor = System.Drawing.Color.Gray;
            this.btncancel.Enabled = false;
            this.btncancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btncancel.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.close;
            this.btncancel.Iconimage_right = null;
            this.btncancel.Iconimage_right_Selected = null;
            this.btncancel.Iconimage_Selected = null;
            this.btncancel.IconMarginLeft = 0;
            this.btncancel.IconMarginRight = 0;
            this.btncancel.IconRightVisible = true;
            this.btncancel.IconRightZoom = 0D;
            this.btncancel.IconVisible = true;
            this.btncancel.IconZoom = 50D;
            this.btncancel.IsTab = false;
            this.btncancel.Location = new System.Drawing.Point(506, 358);
            this.btncancel.Name = "btncancel";
            this.btncancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btncancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btncancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btncancel.selected = false;
            this.btncancel.Size = new System.Drawing.Size(251, 60);
            this.btncancel.TabIndex = 29;
            this.btncancel.Text = "Cancelar";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancel.Textcolor = System.Drawing.Color.White;
            this.btncancel.TextFont = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // frminv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 517);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvtratamientos);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.dgvmaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frminv";
            this.Text = "frminv";
            this.Load += new System.EventHandler(this.frminv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtratamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmaterial;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcantidad;
        private Bunifu.Framework.UI.BunifuFlatButton btnsave;
        private System.Windows.Forms.DataGridView dgvtratamientos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtmaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnreport;
        private Bunifu.Framework.UI.BunifuFlatButton btneditar;
        private Bunifu.Framework.UI.BunifuFlatButton btncancel;
    }
}