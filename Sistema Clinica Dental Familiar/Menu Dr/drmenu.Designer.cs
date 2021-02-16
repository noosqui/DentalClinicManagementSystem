namespace Sistema_Clinica_Dental_Familiar
{
    partial class mnudoctor
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mnudoctor));
            this.pnltop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnmaxim = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.pnlsidemnu = new System.Windows.Forms.Panel();
            this.btnlogout = new Bunifu.Framework.UI.BunifuImageButton();
            this.fltbtnset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fltbtncaja = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fltbtninv = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fltbtnpaciente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flatbtntrat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fltbtnhome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnllogo = new System.Windows.Forms.Panel();
            this.btnmenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logodcms = new System.Windows.Forms.PictureBox();
            this.pnlchildform = new System.Windows.Forms.Panel();
            this.animacionmnu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlsidemnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogout)).BeginInit();
            this.pnllogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logodcms)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.pnltop.Controls.Add(this.pictureBox1);
            this.pnltop.Controls.Add(this.label1);
            this.pnltop.Controls.Add(this.btnmin);
            this.pnltop.Controls.Add(this.btnmaxim);
            this.pnltop.Controls.Add(this.btnexit);
            this.animacionmnu.SetDecoration(this.pnltop, BunifuAnimatorNS.DecorationType.None);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1050, 38);
            this.pnltop.TabIndex = 0;
       
            this.pnltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseDown);
            // 
            // pictureBox1
            // 
            this.animacionmnu.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.dcms_logo_diente_blanco;
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animacionmnu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "DCMS - Dental Clinic Management Software";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animacionmnu.SetDecoration(this.btnmin, BunifuAnimatorNS.DecorationType.None);
            this.btnmin.FlatAppearance.BorderSize = 0;
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmin.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.Color.White;
            this.btnmin.Location = new System.Drawing.Point(950, 1);
            this.btnmin.Margin = new System.Windows.Forms.Padding(0);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(33, 33);
            this.btnmin.TabIndex = 5;
            this.btnmin.Text = "-";
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmaxim
            // 
            this.btnmaxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animacionmnu.SetDecoration(this.btnmaxim, BunifuAnimatorNS.DecorationType.None);
            this.btnmaxim.FlatAppearance.BorderSize = 0;
            this.btnmaxim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaxim.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmaxim.ForeColor = System.Drawing.Color.White;
            this.btnmaxim.Location = new System.Drawing.Point(982, 1);
            this.btnmaxim.Margin = new System.Windows.Forms.Padding(0);
            this.btnmaxim.Name = "btnmaxim";
            this.btnmaxim.Size = new System.Drawing.Size(33, 33);
            this.btnmaxim.TabIndex = 4;
            this.btnmaxim.Text = "☐";
            this.btnmaxim.UseVisualStyleBackColor = true;
            this.btnmaxim.Click += new System.EventHandler(this.btnmaxim_Click_1);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animacionmnu.SetDecoration(this.btnexit, BunifuAnimatorNS.DecorationType.None);
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(1016, 1);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(33, 33);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "x";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pnlsidemnu
            // 
            this.pnlsidemnu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.pnlsidemnu.Controls.Add(this.btnlogout);
            this.pnlsidemnu.Controls.Add(this.fltbtnset);
            this.pnlsidemnu.Controls.Add(this.fltbtncaja);
            this.pnlsidemnu.Controls.Add(this.fltbtninv);
            this.pnlsidemnu.Controls.Add(this.fltbtnpaciente);
            this.pnlsidemnu.Controls.Add(this.flatbtntrat);
            this.pnlsidemnu.Controls.Add(this.fltbtnhome);
            this.pnlsidemnu.Controls.Add(this.pnllogo);
            this.animacionmnu.SetDecoration(this.pnlsidemnu, BunifuAnimatorNS.DecorationType.None);
            this.pnlsidemnu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlsidemnu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlsidemnu.Location = new System.Drawing.Point(0, 38);
            this.pnlsidemnu.Name = "pnlsidemnu";
            this.pnlsidemnu.Size = new System.Drawing.Size(280, 517);
            this.pnlsidemnu.TabIndex = 1;
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionmnu.SetDecoration(this.btnlogout, BunifuAnimatorNS.DecorationType.None);
            this.btnlogout.Image = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.logout__1_;
            this.btnlogout.ImageActive = null;
            this.btnlogout.Location = new System.Drawing.Point(241, 471);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(33, 46);
            this.btnlogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlogout.TabIndex = 6;
            this.btnlogout.TabStop = false;
            this.btnlogout.Zoom = 10;
            this.btnlogout.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // fltbtnset
            // 
            this.fltbtnset.Active = false;
            this.fltbtnset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.fltbtnset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.fltbtnset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fltbtnset.BorderRadius = 0;
            this.fltbtnset.ButtonText = "Ajustes";
            this.fltbtnset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionmnu.SetDecoration(this.fltbtnset, BunifuAnimatorNS.DecorationType.None);
            this.fltbtnset.DisabledColor = System.Drawing.Color.Gray;
            this.fltbtnset.Dock = System.Windows.Forms.DockStyle.Top;
            this.fltbtnset.Iconcolor = System.Drawing.Color.Transparent;
            this.fltbtnset.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.adjust;
            this.fltbtnset.Iconimage_right = null;
            this.fltbtnset.Iconimage_right_Selected = null;
            this.fltbtnset.Iconimage_Selected = null;
            this.fltbtnset.IconMarginLeft = 0;
            this.fltbtnset.IconMarginRight = 0;
            this.fltbtnset.IconRightVisible = true;
            this.fltbtnset.IconRightZoom = 0D;
            this.fltbtnset.IconVisible = true;
            this.fltbtnset.IconZoom = 75D;
            this.fltbtnset.IsTab = false;
            this.fltbtnset.Location = new System.Drawing.Point(0, 417);
            this.fltbtnset.Name = "fltbtnset";
            this.fltbtnset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.fltbtnset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.fltbtnset.OnHoverTextColor = System.Drawing.Color.White;
            this.fltbtnset.selected = false;
            this.fltbtnset.Size = new System.Drawing.Size(280, 53);
            this.fltbtnset.TabIndex = 5;
            this.fltbtnset.Text = "Ajustes";
            this.fltbtnset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fltbtnset.Textcolor = System.Drawing.Color.White;
            this.fltbtnset.TextFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fltbtnset.Click += new System.EventHandler(this.fltbtnset_Click);
            // 
            // fltbtncaja
            // 
            this.fltbtncaja.Active = false;
            this.fltbtncaja.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.fltbtncaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.fltbtncaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fltbtncaja.BorderRadius = 0;
            this.fltbtncaja.ButtonText = "Caja";
            this.fltbtncaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionmnu.SetDecoration(this.fltbtncaja, BunifuAnimatorNS.DecorationType.None);
            this.fltbtncaja.DisabledColor = System.Drawing.Color.Gray;
            this.fltbtncaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.fltbtncaja.Iconcolor = System.Drawing.Color.Transparent;
            this.fltbtncaja.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.cash_register;
            this.fltbtncaja.Iconimage_right = null;
            this.fltbtncaja.Iconimage_right_Selected = null;
            this.fltbtncaja.Iconimage_Selected = null;
            this.fltbtncaja.IconMarginLeft = 0;
            this.fltbtncaja.IconMarginRight = 0;
            this.fltbtncaja.IconRightVisible = true;
            this.fltbtncaja.IconRightZoom = 0D;
            this.fltbtncaja.IconVisible = true;
            this.fltbtncaja.IconZoom = 90D;
            this.fltbtncaja.IsTab = false;
            this.fltbtncaja.Location = new System.Drawing.Point(0, 364);
            this.fltbtncaja.Name = "fltbtncaja";
            this.fltbtncaja.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.fltbtncaja.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.fltbtncaja.OnHoverTextColor = System.Drawing.Color.White;
            this.fltbtncaja.selected = false;
            this.fltbtncaja.Size = new System.Drawing.Size(280, 53);
            this.fltbtncaja.TabIndex = 6;
            this.fltbtncaja.Text = "Caja";
            this.fltbtncaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fltbtncaja.Textcolor = System.Drawing.Color.White;
            this.fltbtncaja.TextFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fltbtncaja.Click += new System.EventHandler(this.fltbtncaja_Click);
            // 
            // fltbtninv
            // 
            this.fltbtninv.Active = false;
            this.fltbtninv.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.fltbtninv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.fltbtninv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fltbtninv.BorderRadius = 0;
            this.fltbtninv.ButtonText = "Inventario";
            this.fltbtninv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionmnu.SetDecoration(this.fltbtninv, BunifuAnimatorNS.DecorationType.None);
            this.fltbtninv.DisabledColor = System.Drawing.Color.Gray;
            this.fltbtninv.Dock = System.Windows.Forms.DockStyle.Top;
            this.fltbtninv.Iconcolor = System.Drawing.Color.Transparent;
            this.fltbtninv.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.inventory;
            this.fltbtninv.Iconimage_right = null;
            this.fltbtninv.Iconimage_right_Selected = null;
            this.fltbtninv.Iconimage_Selected = null;
            this.fltbtninv.IconMarginLeft = 0;
            this.fltbtninv.IconMarginRight = 0;
            this.fltbtninv.IconRightVisible = true;
            this.fltbtninv.IconRightZoom = 0D;
            this.fltbtninv.IconVisible = true;
            this.fltbtninv.IconZoom = 90D;
            this.fltbtninv.IsTab = false;
            this.fltbtninv.Location = new System.Drawing.Point(0, 311);
            this.fltbtninv.Name = "fltbtninv";
            this.fltbtninv.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.fltbtninv.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.fltbtninv.OnHoverTextColor = System.Drawing.Color.White;
            this.fltbtninv.selected = false;
            this.fltbtninv.Size = new System.Drawing.Size(280, 53);
            this.fltbtninv.TabIndex = 4;
            this.fltbtninv.Text = "Inventario";
            this.fltbtninv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fltbtninv.Textcolor = System.Drawing.Color.White;
            this.fltbtninv.TextFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fltbtninv.Click += new System.EventHandler(this.fltbtninv_Click);
            // 
            // fltbtnpaciente
            // 
            this.fltbtnpaciente.Active = false;
            this.fltbtnpaciente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.fltbtnpaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.fltbtnpaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fltbtnpaciente.BorderRadius = 0;
            this.fltbtnpaciente.ButtonText = "Pacientes";
            this.fltbtnpaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionmnu.SetDecoration(this.fltbtnpaciente, BunifuAnimatorNS.DecorationType.None);
            this.fltbtnpaciente.DisabledColor = System.Drawing.Color.Gray;
            this.fltbtnpaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.fltbtnpaciente.Iconcolor = System.Drawing.Color.Transparent;
            this.fltbtnpaciente.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.patient;
            this.fltbtnpaciente.Iconimage_right = null;
            this.fltbtnpaciente.Iconimage_right_Selected = null;
            this.fltbtnpaciente.Iconimage_Selected = null;
            this.fltbtnpaciente.IconMarginLeft = 0;
            this.fltbtnpaciente.IconMarginRight = 0;
            this.fltbtnpaciente.IconRightVisible = true;
            this.fltbtnpaciente.IconRightZoom = 0D;
            this.fltbtnpaciente.IconVisible = true;
            this.fltbtnpaciente.IconZoom = 75D;
            this.fltbtnpaciente.IsTab = false;
            this.fltbtnpaciente.Location = new System.Drawing.Point(0, 258);
            this.fltbtnpaciente.Name = "fltbtnpaciente";
            this.fltbtnpaciente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.fltbtnpaciente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.fltbtnpaciente.OnHoverTextColor = System.Drawing.Color.White;
            this.fltbtnpaciente.selected = false;
            this.fltbtnpaciente.Size = new System.Drawing.Size(280, 53);
            this.fltbtnpaciente.TabIndex = 3;
            this.fltbtnpaciente.Text = "Pacientes";
            this.fltbtnpaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fltbtnpaciente.Textcolor = System.Drawing.Color.White;
            this.fltbtnpaciente.TextFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fltbtnpaciente.Click += new System.EventHandler(this.fltbtnpaciente_Click);
            // 
            // flatbtntrat
            // 
            this.flatbtntrat.Active = false;
            this.flatbtntrat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.flatbtntrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.flatbtntrat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flatbtntrat.BorderRadius = 0;
            this.flatbtntrat.ButtonText = "Tratamiento";
            this.flatbtntrat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionmnu.SetDecoration(this.flatbtntrat, BunifuAnimatorNS.DecorationType.None);
            this.flatbtntrat.DisabledColor = System.Drawing.Color.Gray;
            this.flatbtntrat.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatbtntrat.Iconcolor = System.Drawing.Color.Transparent;
            this.flatbtntrat.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.dentist;
            this.flatbtntrat.Iconimage_right = null;
            this.flatbtntrat.Iconimage_right_Selected = null;
            this.flatbtntrat.Iconimage_Selected = null;
            this.flatbtntrat.IconMarginLeft = 0;
            this.flatbtntrat.IconMarginRight = 0;
            this.flatbtntrat.IconRightVisible = true;
            this.flatbtntrat.IconRightZoom = 0D;
            this.flatbtntrat.IconVisible = true;
            this.flatbtntrat.IconZoom = 95D;
            this.flatbtntrat.IsTab = false;
            this.flatbtntrat.Location = new System.Drawing.Point(0, 205);
            this.flatbtntrat.Name = "flatbtntrat";
            this.flatbtntrat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.flatbtntrat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.flatbtntrat.OnHoverTextColor = System.Drawing.Color.White;
            this.flatbtntrat.selected = false;
            this.flatbtntrat.Size = new System.Drawing.Size(280, 53);
            this.flatbtntrat.TabIndex = 2;
            this.flatbtntrat.Text = "Tratamiento";
            this.flatbtntrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.flatbtntrat.Textcolor = System.Drawing.Color.White;
            this.flatbtntrat.TextFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatbtntrat.Click += new System.EventHandler(this.flatbtntrat_Click);
            // 
            // fltbtnhome
            // 
            this.fltbtnhome.Active = false;
            this.fltbtnhome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.fltbtnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.fltbtnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fltbtnhome.BorderRadius = 0;
            this.fltbtnhome.ButtonText = "Inicio";
            this.fltbtnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionmnu.SetDecoration(this.fltbtnhome, BunifuAnimatorNS.DecorationType.None);
            this.fltbtnhome.DisabledColor = System.Drawing.Color.Gray;
            this.fltbtnhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.fltbtnhome.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fltbtnhome.Iconcolor = System.Drawing.Color.Transparent;
            this.fltbtnhome.Iconimage = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.home_run;
            this.fltbtnhome.Iconimage_right = null;
            this.fltbtnhome.Iconimage_right_Selected = null;
            this.fltbtnhome.Iconimage_Selected = null;
            this.fltbtnhome.IconMarginLeft = 5;
            this.fltbtnhome.IconMarginRight = 0;
            this.fltbtnhome.IconRightVisible = true;
            this.fltbtnhome.IconRightZoom = 0D;
            this.fltbtnhome.IconVisible = true;
            this.fltbtnhome.IconZoom = 90D;
            this.fltbtnhome.IsTab = false;
            this.fltbtnhome.Location = new System.Drawing.Point(0, 152);
            this.fltbtnhome.Name = "fltbtnhome";
            this.fltbtnhome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(165)))), ((int)(((byte)(160)))));
            this.fltbtnhome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(201)))), ((int)(((byte)(195)))));
            this.fltbtnhome.OnHoverTextColor = System.Drawing.Color.White;
            this.fltbtnhome.selected = false;
            this.fltbtnhome.Size = new System.Drawing.Size(280, 53);
            this.fltbtnhome.TabIndex = 1;
            this.fltbtnhome.Text = "Inicio";
            this.fltbtnhome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fltbtnhome.Textcolor = System.Drawing.Color.White;
            this.fltbtnhome.TextFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fltbtnhome.Click += new System.EventHandler(this.fltbtnhome_Click_1);
            // 
            // pnllogo
            // 
            this.pnllogo.Controls.Add(this.btnmenu);
            this.pnllogo.Controls.Add(this.logodcms);
            this.animacionmnu.SetDecoration(this.pnllogo, BunifuAnimatorNS.DecorationType.None);
            this.pnllogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnllogo.Location = new System.Drawing.Point(0, 0);
            this.pnllogo.Name = "pnllogo";
            this.pnllogo.Size = new System.Drawing.Size(280, 152);
            this.pnllogo.TabIndex = 0;
            // 
            // btnmenu
            // 
            this.animacionmnu.SetDecoration(this.btnmenu, BunifuAnimatorNS.DecorationType.None);
            this.btnmenu.Image = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.open_menu;
            this.btnmenu.ImageActive = null;
            this.btnmenu.Location = new System.Drawing.Point(0, 0);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(54, 54);
            this.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmenu.TabIndex = 0;
            this.btnmenu.TabStop = false;
            this.btnmenu.Zoom = 10;
            this.btnmenu.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // logodcms
            // 
            this.animacionmnu.SetDecoration(this.logodcms, BunifuAnimatorNS.DecorationType.None);
            this.logodcms.Image = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.dcms_logo_abreviado_blanco;
            this.logodcms.Location = new System.Drawing.Point(12, 52);
            this.logodcms.Name = "logodcms";
            this.logodcms.Size = new System.Drawing.Size(250, 71);
            this.logodcms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logodcms.TabIndex = 0;
            this.logodcms.TabStop = false;
            // 
            // pnlchildform
            // 
            this.animacionmnu.SetDecoration(this.pnlchildform, BunifuAnimatorNS.DecorationType.None);
            this.pnlchildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlchildform.Location = new System.Drawing.Point(280, 38);
            this.pnlchildform.Name = "pnlchildform";
            this.pnlchildform.Size = new System.Drawing.Size(770, 517);
            this.pnlchildform.TabIndex = 3;
            // 
            // animacionmnu
            // 
            this.animacionmnu.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animacionmnu.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animacionmnu.DefaultAnimation = animation1;
            // 
            // mnudoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1050, 555);
            this.Controls.Add(this.pnlchildform);
            this.Controls.Add(this.pnlsidemnu);
            this.Controls.Add(this.pnltop);
            this.animacionmnu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1050, 555);
            this.Name = "mnudoctor";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mnudoctor_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlsidemnu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnlogout)).EndInit();
            this.pnllogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logodcms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel pnlsidemnu;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnmaxim;
        private System.Windows.Forms.Panel pnllogo;
        private Bunifu.Framework.UI.BunifuFlatButton fltbtnset;
        private Bunifu.Framework.UI.BunifuFlatButton fltbtninv;
        private Bunifu.Framework.UI.BunifuFlatButton fltbtnpaciente;
        private Bunifu.Framework.UI.BunifuFlatButton flatbtntrat;
        private Bunifu.Framework.UI.BunifuFlatButton fltbtnhome;
        private Bunifu.Framework.UI.BunifuFlatButton fltbtncaja;
        private System.Windows.Forms.Panel pnlchildform;
        private BunifuAnimatorNS.BunifuTransition animacionmnu;
        private Bunifu.Framework.UI.BunifuImageButton btnmenu;
        private System.Windows.Forms.PictureBox logodcms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnlogout;
    }
}