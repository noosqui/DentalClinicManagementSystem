namespace Sistema_Clinica_Dental_Familiar
{
    partial class frmtratamiento
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
            this.dgvmateriales = new System.Windows.Forms.DataGridView();
            this.cmbpaciente = new System.Windows.Forms.ComboBox();
            this.cmbtrat = new System.Windows.Forms.ComboBox();
            this.txtcantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaterial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btncancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnedit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnrealizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmateriales
            // 
            this.dgvmateriales.AllowUserToAddRows = false;
            this.dgvmateriales.AllowUserToDeleteRows = false;
            this.dgvmateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmateriales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvmateriales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.dgvmateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvmateriales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvmateriales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvmateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmateriales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvmateriales.EnableHeadersVisualStyles = false;
            this.dgvmateriales.Location = new System.Drawing.Point(22, 209);
            this.dgvmateriales.Name = "dgvmateriales";
            this.dgvmateriales.ReadOnly = true;
            this.dgvmateriales.RowHeadersVisible = false;
            this.dgvmateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmateriales.Size = new System.Drawing.Size(453, 286);
            this.dgvmateriales.TabIndex = 0;
          
            this.dgvmateriales.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmateriales_CellEnter);
            // 
            // cmbpaciente
            // 
            this.cmbpaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbpaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbpaciente.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpaciente.FormattingEnabled = true;
            this.cmbpaciente.Location = new System.Drawing.Point(22, 43);
            this.cmbpaciente.Name = "cmbpaciente";
            this.cmbpaciente.Size = new System.Drawing.Size(477, 32);
            this.cmbpaciente.TabIndex = 1;
            this.cmbpaciente.SelectedIndexChanged += new System.EventHandler(this.cmbpaciente_SelectedIndexChanged);
            // 
            // cmbtrat
            // 
            this.cmbtrat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbtrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbtrat.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtrat.FormattingEnabled = true;
            this.cmbtrat.Location = new System.Drawing.Point(22, 127);
            this.cmbtrat.Name = "cmbtrat";
            this.cmbtrat.Size = new System.Drawing.Size(704, 32);
            this.cmbtrat.TabIndex = 3;
            this.cmbtrat.SelectedIndexChanged += new System.EventHandler(this.cmbtrat_SelectedIndexChanged);
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
            this.txtcantidad.Location = new System.Drawing.Point(635, 252);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidad.MaxLength = 4;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(95, 36);
            this.txtcantidad.TabIndex = 8;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(481, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Material:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(481, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad:";
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
            this.txtmaterial.Location = new System.Drawing.Point(579, 197);
            this.txtmaterial.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaterial.MaxLength = 40;
            this.txtmaterial.Name = "txtmaterial";
            this.txtmaterial.Size = new System.Drawing.Size(151, 36);
            this.txtmaterial.TabIndex = 13;
            this.txtmaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.label3.Location = new System.Drawing.Point(18, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Paciente:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(30, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tratamiento";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.label5.Location = new System.Drawing.Point(30, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Materiales a utilizar:";
            // 
            // btncancel
            // 
            this.btncancel.Active = false;
            this.btncancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancel.BorderRadius = 7;
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
            this.btncancel.Location = new System.Drawing.Point(485, 403);
            this.btncancel.Name = "btncancel";
            this.btncancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btncancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btncancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btncancel.selected = false;
            this.btncancel.Size = new System.Drawing.Size(245, 43);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "Cancelar";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancel.Textcolor = System.Drawing.Color.White;
            this.btncancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnedit
            // 
            this.btnedit.Active = false;
            this.btnedit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnedit.BorderRadius = 7;
            this.btnedit.ButtonText = "Editar";
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.DisabledColor = System.Drawing.Color.Gray;
            this.btnedit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnedit.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.edit;
            this.btnedit.Iconimage_right = null;
            this.btnedit.Iconimage_right_Selected = null;
            this.btnedit.Iconimage_Selected = null;
            this.btnedit.IconMarginLeft = 0;
            this.btnedit.IconMarginRight = 0;
            this.btnedit.IconRightVisible = true;
            this.btnedit.IconRightZoom = 0D;
            this.btnedit.IconVisible = true;
            this.btnedit.IconZoom = 50D;
            this.btnedit.IsTab = false;
            this.btnedit.Location = new System.Drawing.Point(485, 306);
            this.btnedit.Name = "btnedit";
            this.btnedit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnedit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btnedit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnedit.selected = false;
            this.btnedit.Size = new System.Drawing.Size(245, 43);
            this.btnedit.TabIndex = 12;
            this.btnedit.Text = "Editar";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnedit.Textcolor = System.Drawing.Color.White;
            this.btnedit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // btnrealizar
            // 
            this.btnrealizar.Active = false;
            this.btnrealizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btnrealizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrealizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnrealizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrealizar.BorderRadius = 7;
            this.btnrealizar.ButtonText = "Realizar";
            this.btnrealizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrealizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnrealizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnrealizar.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.treatment;
            this.btnrealizar.Iconimage_right = null;
            this.btnrealizar.Iconimage_right_Selected = null;
            this.btnrealizar.Iconimage_Selected = null;
            this.btnrealizar.IconMarginLeft = 0;
            this.btnrealizar.IconMarginRight = 0;
            this.btnrealizar.IconRightVisible = true;
            this.btnrealizar.IconRightZoom = 0D;
            this.btnrealizar.IconVisible = true;
            this.btnrealizar.IconZoom = 70D;
            this.btnrealizar.IsTab = false;
            this.btnrealizar.Location = new System.Drawing.Point(485, 452);
            this.btnrealizar.Name = "btnrealizar";
            this.btnrealizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnrealizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btnrealizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnrealizar.selected = false;
            this.btnrealizar.Size = new System.Drawing.Size(245, 43);
            this.btnrealizar.TabIndex = 7;
            this.btnrealizar.Text = "Realizar";
            this.btnrealizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrealizar.Textcolor = System.Drawing.Color.White;
            this.btnrealizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrealizar.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Active = false;
            this.btnguardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.BorderRadius = 7;
            this.btnguardar.ButtonText = "Guardar";
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnguardar.Enabled = false;
            this.btnguardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnguardar.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.save;
            this.btnguardar.Iconimage_right = null;
            this.btnguardar.Iconimage_right_Selected = null;
            this.btnguardar.Iconimage_Selected = null;
            this.btnguardar.IconMarginLeft = 0;
            this.btnguardar.IconMarginRight = 0;
            this.btnguardar.IconRightVisible = true;
            this.btnguardar.IconRightZoom = 0D;
            this.btnguardar.IconVisible = true;
            this.btnguardar.IconZoom = 50D;
            this.btnguardar.IsTab = false;
            this.btnguardar.Location = new System.Drawing.Point(485, 355);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.btnguardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.btnguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardar.selected = false;
            this.btnguardar.Size = new System.Drawing.Size(245, 43);
            this.btnguardar.TabIndex = 18;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnguardar.Textcolor = System.Drawing.Color.White;
            this.btnguardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtnombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtnombre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.txtnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtnombre.HintText = "";
            this.txtnombre.isPassword = false;
            this.txtnombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.txtnombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.txtnombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.txtnombre.LineThickness = 2;
            this.txtnombre.Location = new System.Drawing.Point(525, 39);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.MaxLength = 32767;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(201, 36);
            this.txtnombre.TabIndex = 19;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmtratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 517);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaterial);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.btnrealizar);
            this.Controls.Add(this.cmbtrat);
            this.Controls.Add(this.cmbpaciente);
            this.Controls.Add(this.dgvmateriales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtratamiento";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmtratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmateriales;
        private System.Windows.Forms.ComboBox cmbpaciente;
        private System.Windows.Forms.ComboBox cmbtrat;
        private Bunifu.Framework.UI.BunifuFlatButton btnrealizar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnedit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtmaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btncancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnguardar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
    }
}