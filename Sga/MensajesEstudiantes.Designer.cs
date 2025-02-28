namespace Sga
{
    partial class MensajesEstudiantes
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
            this.lblTituloM = new System.Windows.Forms.Label();
            this.panelcontendorpalabras = new System.Windows.Forms.Panel();
            this.rtbMensaje = new System.Windows.Forms.RichTextBox();
            this.panelcontendorpalabras.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloM
            // 
            this.lblTituloM.AutoSize = true;
            this.lblTituloM.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTituloM.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloM.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTituloM.Location = new System.Drawing.Point(6, 43);
            this.lblTituloM.Name = "lblTituloM";
            this.lblTituloM.Size = new System.Drawing.Size(700, 24);
            this.lblTituloM.TabIndex = 0;
            this.lblTituloM.Text = "AQUI SE MOSTRARAN LOS NUEVOS MENSAJES DE TU MAESTRO";
            // 
            // panelcontendorpalabras
            // 
            this.panelcontendorpalabras.BackColor = System.Drawing.Color.LightCyan;
            this.panelcontendorpalabras.Controls.Add(this.rtbMensaje);
            this.panelcontendorpalabras.Location = new System.Drawing.Point(117, 122);
            this.panelcontendorpalabras.Name = "panelcontendorpalabras";
            this.panelcontendorpalabras.Size = new System.Drawing.Size(501, 255);
            this.panelcontendorpalabras.TabIndex = 1;
            // 
            // rtbMensaje
            // 
            this.rtbMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMensaje.Location = new System.Drawing.Point(0, 0);
            this.rtbMensaje.Name = "rtbMensaje";
            this.rtbMensaje.ReadOnly = true;
            this.rtbMensaje.Size = new System.Drawing.Size(501, 255);
            this.rtbMensaje.TabIndex = 0;
            this.rtbMensaje.TabStop = false;
            this.rtbMensaje.Text = "";
            // 
            // MensajesEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sga.Properties.Resources.Mensajeria_fondo;
            this.ClientSize = new System.Drawing.Size(718, 516);
            this.Controls.Add(this.panelcontendorpalabras);
            this.Controls.Add(this.lblTituloM);
            this.Name = "MensajesEstudiantes";
            this.Text = "MensajesEstudiantes";
            this.Load += new System.EventHandler(this.MensajesEstudiantes_Load);
            this.panelcontendorpalabras.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloM;
        private System.Windows.Forms.Panel panelcontendorpalabras;
        private System.Windows.Forms.RichTextBox rtbMensaje;
    }
}