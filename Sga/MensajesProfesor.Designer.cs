namespace Sga
{
    partial class MensajesProfesor
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
            this.lblTituloProfesor = new System.Windows.Forms.Label();
            this.panelCsms = new System.Windows.Forms.Panel();
            this.btnLimpiarsms = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.rtbMensajes = new System.Windows.Forms.RichTextBox();
            this.panelCsms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloProfesor
            // 
            this.lblTituloProfesor.AutoSize = true;
            this.lblTituloProfesor.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloProfesor.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProfesor.Location = new System.Drawing.Point(276, 43);
            this.lblTituloProfesor.Name = "lblTituloProfesor";
            this.lblTituloProfesor.Size = new System.Drawing.Size(171, 34);
            this.lblTituloProfesor.TabIndex = 0;
            this.lblTituloProfesor.Text = "Mensajería";
            this.lblTituloProfesor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelCsms
            // 
            this.panelCsms.BackColor = System.Drawing.Color.Transparent;
            this.panelCsms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelCsms.Controls.Add(this.btnLimpiarsms);
            this.panelCsms.Controls.Add(this.btnEnviar);
            this.panelCsms.Controls.Add(this.rtbMensajes);
            this.panelCsms.Location = new System.Drawing.Point(131, 95);
            this.panelCsms.Name = "panelCsms";
            this.panelCsms.Size = new System.Drawing.Size(471, 255);
            this.panelCsms.TabIndex = 1;
            // 
            // btnLimpiarsms
            // 
            this.btnLimpiarsms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarsms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpiarsms.FlatAppearance.BorderSize = 2;
            this.btnLimpiarsms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLimpiarsms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnLimpiarsms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarsms.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarsms.Image = global::Sga.Properties.Resources.goma_de_borrar;
            this.btnLimpiarsms.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarsms.Location = new System.Drawing.Point(296, 144);
            this.btnLimpiarsms.Name = "btnLimpiarsms";
            this.btnLimpiarsms.Size = new System.Drawing.Size(154, 74);
            this.btnLimpiarsms.TabIndex = 2;
            this.btnLimpiarsms.Text = "LIMPIAR";
            this.btnLimpiarsms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarsms.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiarsms.UseVisualStyleBackColor = true;
            this.btnLimpiarsms.Click += new System.EventHandler(this.btnLimpiarsms_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnviar.FlatAppearance.BorderSize = 2;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Image = global::Sga.Properties.Resources.enviar;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.Location = new System.Drawing.Point(296, 41);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(154, 74);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "ENVIAR \r\nMENSAJE";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // rtbMensajes
            // 
            this.rtbMensajes.BackColor = System.Drawing.Color.LightBlue;
            this.rtbMensajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMensajes.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbMensajes.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMensajes.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rtbMensajes.Location = new System.Drawing.Point(0, 0);
            this.rtbMensajes.Name = "rtbMensajes";
            this.rtbMensajes.Size = new System.Drawing.Size(269, 255);
            this.rtbMensajes.TabIndex = 0;
            this.rtbMensajes.Text = "";
            // 
            // MensajesProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sga.Properties.Resources.Mensajeria_fondo;
            this.ClientSize = new System.Drawing.Size(718, 516);
            this.Controls.Add(this.panelCsms);
            this.Controls.Add(this.lblTituloProfesor);
            this.Name = "MensajesProfesor";
            this.Text = "MensajesProfesor";
            this.panelCsms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloProfesor;
        private System.Windows.Forms.Panel panelCsms;
        private System.Windows.Forms.Button btnLimpiarsms;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox rtbMensajes;
    }
}