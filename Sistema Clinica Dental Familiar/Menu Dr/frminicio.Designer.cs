namespace Sistema_Clinica_Dental_Familiar
{
    partial class frminicio
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
            this.lblbienvenida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picuser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbienvenida
            // 
            this.lblbienvenida.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblbienvenida.AutoSize = true;
            this.lblbienvenida.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblbienvenida.Font = new System.Drawing.Font("Bahnschrift", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.lblbienvenida.Location = new System.Drawing.Point(47, 324);
            this.lblbienvenida.Name = "lblbienvenida";
            this.lblbienvenida.Size = new System.Drawing.Size(363, 81);
            this.lblbienvenida.TabIndex = 0;
            this.lblbienvenida.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(163, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Listo para trabajar hoy?";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.lblfecha.Location = new System.Drawing.Point(34, 29);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(86, 31);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "label3";
    
            // 
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(121)))), ((int)(((byte)(113)))));
            this.lblhora.Location = new System.Drawing.Point(641, 27);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(89, 33);
            this.lblhora.TabIndex = 3;
            this.lblhora.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picuser
            // 
            this.picuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picuser.Image = global::Sistema_Clinica_Dental_Familiar.Properties.Resources.user__1_;
            this.picuser.Location = new System.Drawing.Point(263, 87);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(205, 205);
            this.picuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picuser.TabIndex = 4;
            this.picuser.TabStop = false;
            // 
            // frminicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 517);
            this.Controls.Add(this.picuser);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblbienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frminicio";
            this.Text = "frminicio";
            this.Load += new System.EventHandler(this.frminicio_Load);
            this.Resize += new System.EventHandler(this.frminicio_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbienvenida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picuser;
        private System.Windows.Forms.Timer timer2;
    }
}