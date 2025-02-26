namespace Sga
{
    partial class Registro_profesor
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
            this.bt_crearCuenta_profesor = new System.Windows.Forms.Button();
            this.txtbox_profesor_nombres = new System.Windows.Forms.TextBox();
            this.lbl_profesor_nombre = new System.Windows.Forms.Label();
            this.lbl_profesor_cédula = new System.Windows.Forms.Label();
            this.lbl_profesor_gmail = new System.Windows.Forms.Label();
            this.txtbox_profesor_teléfono = new System.Windows.Forms.TextBox();
            this.txtbox_profesor_cédula = new System.Windows.Forms.TextBox();
            this.txtbox_profesor_apellidos = new System.Windows.Forms.TextBox();
            this.lbl_profesor_teléfono = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_profesor_apellidos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbox_profesor_gmail = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblRegistroDocente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_CerrarRegis_profesor = new System.Windows.Forms.Button();
            this.btnMiniRegisProfe = new System.Windows.Forms.Button();
            this.btnMaxiRegisProfe = new System.Windows.Forms.Button();
            this.btnRestauRegisProfe = new System.Windows.Forms.Button();
            this.panel_sga = new System.Windows.Forms.Panel();
            this.txtbox_profesor_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_profesor_contraseña = new System.Windows.Forms.Label();
            this.bt_regresar_profesor = new System.Windows.Forms.Button();
            this.panel_sga.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_crearCuenta_profesor
            // 
            this.bt_crearCuenta_profesor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_crearCuenta_profesor.BackColor = System.Drawing.Color.Transparent;
            this.bt_crearCuenta_profesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_crearCuenta_profesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_crearCuenta_profesor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_crearCuenta_profesor.Location = new System.Drawing.Point(74, 376);
            this.bt_crearCuenta_profesor.Name = "bt_crearCuenta_profesor";
            this.bt_crearCuenta_profesor.Size = new System.Drawing.Size(166, 53);
            this.bt_crearCuenta_profesor.TabIndex = 7;
            this.bt_crearCuenta_profesor.Text = "Crear cuenta";
            this.bt_crearCuenta_profesor.UseVisualStyleBackColor = false;
            this.bt_crearCuenta_profesor.Click += new System.EventHandler(this.bt_crearCuenta_profesor_Click);
            // 
            // txtbox_profesor_nombres
            // 
            this.txtbox_profesor_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbox_profesor_nombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_profesor_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_profesor_nombres.Location = new System.Drawing.Point(348, 153);
            this.txtbox_profesor_nombres.Name = "txtbox_profesor_nombres";
            this.txtbox_profesor_nombres.Size = new System.Drawing.Size(175, 19);
            this.txtbox_profesor_nombres.TabIndex = 2;
            // 
            // lbl_profesor_nombre
            // 
            this.lbl_profesor_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_profesor_nombre.AutoSize = true;
            this.lbl_profesor_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profesor_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor_nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_profesor_nombre.Location = new System.Drawing.Point(70, 152);
            this.lbl_profesor_nombre.Name = "lbl_profesor_nombre";
            this.lbl_profesor_nombre.Size = new System.Drawing.Size(85, 20);
            this.lbl_profesor_nombre.TabIndex = 72;
            this.lbl_profesor_nombre.Text = "Nombres ";
            // 
            // lbl_profesor_cédula
            // 
            this.lbl_profesor_cédula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_profesor_cédula.AutoSize = true;
            this.lbl_profesor_cédula.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profesor_cédula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor_cédula.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_profesor_cédula.Location = new System.Drawing.Point(70, 219);
            this.lbl_profesor_cédula.Name = "lbl_profesor_cédula";
            this.lbl_profesor_cédula.Size = new System.Drawing.Size(65, 20);
            this.lbl_profesor_cédula.TabIndex = 71;
            this.lbl_profesor_cédula.Text = "Cédula";
            // 
            // lbl_profesor_gmail
            // 
            this.lbl_profesor_gmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_profesor_gmail.AutoSize = true;
            this.lbl_profesor_gmail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profesor_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor_gmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_profesor_gmail.Location = new System.Drawing.Point(70, 291);
            this.lbl_profesor_gmail.Name = "lbl_profesor_gmail";
            this.lbl_profesor_gmail.Size = new System.Drawing.Size(55, 20);
            this.lbl_profesor_gmail.TabIndex = 70;
            this.lbl_profesor_gmail.Text = "Gmail";
            // 
            // txtbox_profesor_teléfono
            // 
            this.txtbox_profesor_teléfono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbox_profesor_teléfono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_profesor_teléfono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_profesor_teléfono.Location = new System.Drawing.Point(348, 258);
            this.txtbox_profesor_teléfono.Name = "txtbox_profesor_teléfono";
            this.txtbox_profesor_teléfono.Size = new System.Drawing.Size(175, 19);
            this.txtbox_profesor_teléfono.TabIndex = 5;
            // 
            // txtbox_profesor_cédula
            // 
            this.txtbox_profesor_cédula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbox_profesor_cédula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_profesor_cédula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_profesor_cédula.Location = new System.Drawing.Point(348, 220);
            this.txtbox_profesor_cédula.Name = "txtbox_profesor_cédula";
            this.txtbox_profesor_cédula.Size = new System.Drawing.Size(175, 19);
            this.txtbox_profesor_cédula.TabIndex = 4;
            // 
            // txtbox_profesor_apellidos
            // 
            this.txtbox_profesor_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbox_profesor_apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_profesor_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_profesor_apellidos.Location = new System.Drawing.Point(348, 186);
            this.txtbox_profesor_apellidos.Name = "txtbox_profesor_apellidos";
            this.txtbox_profesor_apellidos.Size = new System.Drawing.Size(175, 19);
            this.txtbox_profesor_apellidos.TabIndex = 3;
            // 
            // lbl_profesor_teléfono
            // 
            this.lbl_profesor_teléfono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_profesor_teléfono.AutoSize = true;
            this.lbl_profesor_teléfono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profesor_teléfono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor_teléfono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_profesor_teléfono.Location = new System.Drawing.Point(70, 257);
            this.lbl_profesor_teléfono.Name = "lbl_profesor_teléfono";
            this.lbl_profesor_teléfono.Size = new System.Drawing.Size(79, 20);
            this.lbl_profesor_teléfono.TabIndex = 66;
            this.lbl_profesor_teléfono.Text = "Teléfono";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 65;
            // 
            // lbl_profesor_apellidos
            // 
            this.lbl_profesor_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_profesor_apellidos.AutoSize = true;
            this.lbl_profesor_apellidos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profesor_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor_apellidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_profesor_apellidos.Location = new System.Drawing.Point(70, 185);
            this.lbl_profesor_apellidos.Name = "lbl_profesor_apellidos";
            this.lbl_profesor_apellidos.Size = new System.Drawing.Size(82, 20);
            this.lbl_profesor_apellidos.TabIndex = 64;
            this.lbl_profesor_apellidos.Text = "Apellidos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 63;
            // 
            // txtbox_profesor_gmail
            // 
            this.txtbox_profesor_gmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbox_profesor_gmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_profesor_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_profesor_gmail.Location = new System.Drawing.Point(348, 292);
            this.txtbox_profesor_gmail.Name = "txtbox_profesor_gmail";
            this.txtbox_profesor_gmail.Size = new System.Drawing.Size(175, 19);
            this.txtbox_profesor_gmail.TabIndex = 6;
            // 
            // lblRegistroDocente
            // 
            this.lblRegistroDocente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRegistroDocente.AutoSize = true;
            this.lblRegistroDocente.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistroDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroDocente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistroDocente.Location = new System.Drawing.Point(153, 85);
            this.lblRegistroDocente.Name = "lblRegistroDocente";
            this.lblRegistroDocente.Size = new System.Drawing.Size(314, 31);
            this.lblRegistroDocente.TabIndex = 80;
            this.lblRegistroDocente.Text = "Registro de Profesores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "SGA";
            // 
            // bt_CerrarRegis_profesor
            // 
            this.bt_CerrarRegis_profesor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_CerrarRegis_profesor.BackColor = System.Drawing.Color.Silver;
            this.bt_CerrarRegis_profesor.BackgroundImage = global::Sga.Properties.Resources.Icono_cerrar_FN;
            this.bt_CerrarRegis_profesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_CerrarRegis_profesor.FlatAppearance.BorderSize = 0;
            this.bt_CerrarRegis_profesor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bt_CerrarRegis_profesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_CerrarRegis_profesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CerrarRegis_profesor.Location = new System.Drawing.Point(563, 0);
            this.bt_CerrarRegis_profesor.Name = "bt_CerrarRegis_profesor";
            this.bt_CerrarRegis_profesor.Size = new System.Drawing.Size(40, 40);
            this.bt_CerrarRegis_profesor.TabIndex = 1;
            this.bt_CerrarRegis_profesor.UseVisualStyleBackColor = false;
            this.bt_CerrarRegis_profesor.Click += new System.EventHandler(this.bt_CerrarRegis_profesor_Click);
            // 
            // btnMiniRegisProfe
            // 
            this.btnMiniRegisProfe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniRegisProfe.BackColor = System.Drawing.Color.Silver;
            this.btnMiniRegisProfe.BackgroundImage = global::Sga.Properties.Resources.Icono_Minimizar;
            this.btnMiniRegisProfe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiniRegisProfe.FlatAppearance.BorderSize = 0;
            this.btnMiniRegisProfe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMiniRegisProfe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMiniRegisProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniRegisProfe.Location = new System.Drawing.Point(493, 0);
            this.btnMiniRegisProfe.Name = "btnMiniRegisProfe";
            this.btnMiniRegisProfe.Size = new System.Drawing.Size(40, 40);
            this.btnMiniRegisProfe.TabIndex = 2;
            this.btnMiniRegisProfe.UseVisualStyleBackColor = false;
            this.btnMiniRegisProfe.Click += new System.EventHandler(this.btnMiniRegisProfe_Click);
            // 
            // btnMaxiRegisProfe
            // 
            this.btnMaxiRegisProfe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxiRegisProfe.BackColor = System.Drawing.Color.Silver;
            this.btnMaxiRegisProfe.BackgroundImage = global::Sga.Properties.Resources.Icono_Maximizar;
            this.btnMaxiRegisProfe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxiRegisProfe.FlatAppearance.BorderSize = 0;
            this.btnMaxiRegisProfe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMaxiRegisProfe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaxiRegisProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxiRegisProfe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMaxiRegisProfe.Location = new System.Drawing.Point(526, 0);
            this.btnMaxiRegisProfe.Name = "btnMaxiRegisProfe";
            this.btnMaxiRegisProfe.Size = new System.Drawing.Size(40, 40);
            this.btnMaxiRegisProfe.TabIndex = 3;
            this.btnMaxiRegisProfe.UseVisualStyleBackColor = false;
            this.btnMaxiRegisProfe.Click += new System.EventHandler(this.btnMaxiRegisProfe_Click);
            // 
            // btnRestauRegisProfe
            // 
            this.btnRestauRegisProfe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestauRegisProfe.BackColor = System.Drawing.Color.Silver;
            this.btnRestauRegisProfe.BackgroundImage = global::Sga.Properties.Resources.Icono_Restaurar;
            this.btnRestauRegisProfe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestauRegisProfe.FlatAppearance.BorderSize = 0;
            this.btnRestauRegisProfe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRestauRegisProfe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRestauRegisProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestauRegisProfe.Location = new System.Drawing.Point(526, 0);
            this.btnRestauRegisProfe.Name = "btnRestauRegisProfe";
            this.btnRestauRegisProfe.Size = new System.Drawing.Size(40, 40);
            this.btnRestauRegisProfe.TabIndex = 4;
            this.btnRestauRegisProfe.UseVisualStyleBackColor = false;
            this.btnRestauRegisProfe.Visible = false;
            this.btnRestauRegisProfe.Click += new System.EventHandler(this.btnRestauRegisProfe_Click);
            // 
            // panel_sga
            // 
            this.panel_sga.BackColor = System.Drawing.Color.Transparent;
            this.panel_sga.Controls.Add(this.label1);
            this.panel_sga.Controls.Add(this.btnRestauRegisProfe);
            this.panel_sga.Controls.Add(this.btnMiniRegisProfe);
            this.panel_sga.Controls.Add(this.btnMaxiRegisProfe);
            this.panel_sga.Controls.Add(this.bt_CerrarRegis_profesor);
            this.panel_sga.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_sga.Location = new System.Drawing.Point(0, 0);
            this.panel_sga.Name = "panel_sga";
            this.panel_sga.Size = new System.Drawing.Size(603, 70);
            this.panel_sga.TabIndex = 81;
            this.panel_sga.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_sga_MouseMove);
            // 
            // txtbox_profesor_contraseña
            // 
            this.txtbox_profesor_contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbox_profesor_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_profesor_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_profesor_contraseña.Location = new System.Drawing.Point(348, 325);
            this.txtbox_profesor_contraseña.Name = "txtbox_profesor_contraseña";
            this.txtbox_profesor_contraseña.Size = new System.Drawing.Size(175, 19);
            this.txtbox_profesor_contraseña.TabIndex = 82;
            // 
            // lbl_profesor_contraseña
            // 
            this.lbl_profesor_contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_profesor_contraseña.AutoSize = true;
            this.lbl_profesor_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profesor_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor_contraseña.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_profesor_contraseña.Location = new System.Drawing.Point(70, 324);
            this.lbl_profesor_contraseña.Name = "lbl_profesor_contraseña";
            this.lbl_profesor_contraseña.Size = new System.Drawing.Size(102, 20);
            this.lbl_profesor_contraseña.TabIndex = 83;
            this.lbl_profesor_contraseña.Text = "Contraseña";
            // 
            // bt_regresar_profesor
            // 
            this.bt_regresar_profesor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_regresar_profesor.BackColor = System.Drawing.Color.Transparent;
            this.bt_regresar_profesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_regresar_profesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_regresar_profesor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_regresar_profesor.Location = new System.Drawing.Point(348, 376);
            this.bt_regresar_profesor.Name = "bt_regresar_profesor";
            this.bt_regresar_profesor.Size = new System.Drawing.Size(176, 53);
            this.bt_regresar_profesor.TabIndex = 84;
            this.bt_regresar_profesor.Text = "Regresar";
            this.bt_regresar_profesor.UseVisualStyleBackColor = false;
            this.bt_regresar_profesor.Click += new System.EventHandler(this.bt_regresar_profesor_Click);
            // 
            // Registro_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sga.Properties.Resources.modern_apartment_with_clean_bright_design_abstract_wallpaper_generated_by_ai_modified__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 569);
            this.Controls.Add(this.bt_regresar_profesor);
            this.Controls.Add(this.txtbox_profesor_contraseña);
            this.Controls.Add(this.lbl_profesor_contraseña);
            this.Controls.Add(this.panel_sga);
            this.Controls.Add(this.lblRegistroDocente);
            this.Controls.Add(this.txtbox_profesor_gmail);
            this.Controls.Add(this.bt_crearCuenta_profesor);
            this.Controls.Add(this.txtbox_profesor_nombres);
            this.Controls.Add(this.lbl_profesor_nombre);
            this.Controls.Add(this.lbl_profesor_cédula);
            this.Controls.Add(this.lbl_profesor_gmail);
            this.Controls.Add(this.txtbox_profesor_teléfono);
            this.Controls.Add(this.txtbox_profesor_cédula);
            this.Controls.Add(this.txtbox_profesor_apellidos);
            this.Controls.Add(this.lbl_profesor_teléfono);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_profesor_apellidos);
            this.Controls.Add(this.label16);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_profesor";
            this.panel_sga.ResumeLayout(false);
            this.panel_sga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_crearCuenta_profesor;
        private System.Windows.Forms.TextBox txtbox_profesor_nombres;
        private System.Windows.Forms.Label lbl_profesor_nombre;
        private System.Windows.Forms.Label lbl_profesor_cédula;
        private System.Windows.Forms.Label lbl_profesor_gmail;
        private System.Windows.Forms.TextBox txtbox_profesor_teléfono;
        private System.Windows.Forms.TextBox txtbox_profesor_cédula;
        private System.Windows.Forms.TextBox txtbox_profesor_apellidos;
        private System.Windows.Forms.Label lbl_profesor_teléfono;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_profesor_apellidos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbox_profesor_gmail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblRegistroDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_CerrarRegis_profesor;
        private System.Windows.Forms.Button btnMiniRegisProfe;
        private System.Windows.Forms.Button btnMaxiRegisProfe;
        private System.Windows.Forms.Button btnRestauRegisProfe;
        private System.Windows.Forms.Panel panel_sga;
        private System.Windows.Forms.TextBox txtbox_profesor_contraseña;
        private System.Windows.Forms.Label lbl_profesor_contraseña;
        private System.Windows.Forms.Button bt_regresar_profesor;
    }
}