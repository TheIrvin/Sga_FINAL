namespace Sga
{
    partial class Tareas
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
            this.lblActividades = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTemaActividad = new System.Windows.Forms.TextBox();
            this.btnGuardarTarea = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.pnl_Tareas = new System.Windows.Forms.Panel();
            this.dvg_Gestion_actividades = new System.Windows.Forms.DataGridView();
            this.pnl_Tareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Gestion_actividades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.BackColor = System.Drawing.Color.Transparent;
            this.lblActividades.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividades.Location = new System.Drawing.Point(228, 11);
            this.lblActividades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(264, 31);
            this.lblActividades.TabIndex = 12;
            this.lblActividades.Text = "Gestionar Actividades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tema Actividad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripcion de la actividad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(74, 172);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(400, 140);
            this.txtDescripcion.TabIndex = 22;
            // 
            // txtTemaActividad
            // 
            this.txtTemaActividad.Location = new System.Drawing.Point(174, 106);
            this.txtTemaActividad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTemaActividad.Name = "txtTemaActividad";
            this.txtTemaActividad.Size = new System.Drawing.Size(319, 20);
            this.txtTemaActividad.TabIndex = 23;
            // 
            // btnGuardarTarea
            // 
            this.btnGuardarTarea.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardarTarea.Location = new System.Drawing.Point(533, 184);
            this.btnGuardarTarea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarTarea.Name = "btnGuardarTarea";
            this.btnGuardarTarea.Size = new System.Drawing.Size(76, 44);
            this.btnGuardarTarea.TabIndex = 28;
            this.btnGuardarTarea.Text = "Guardar tarea";
            this.btnGuardarTarea.UseVisualStyleBackColor = false;
            this.btnGuardarTarea.Click += new System.EventHandler(this.btnConfirmarTarea_Click);
            this.btnGuardarTarea.MouseEnter += new System.EventHandler(this.btnConfirmarTarea_MouseEnter);
            this.btnGuardarTarea.MouseLeave += new System.EventHandler(this.btnConfirmarTarea_MouseLeave);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminarTarea.Location = new System.Drawing.Point(533, 260);
            this.btnEliminarTarea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(76, 38);
            this.btnEliminarTarea.TabIndex = 29;
            this.btnEliminarTarea.Text = "Eliminar tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnConfirmarEliminacion_Click);
            this.btnEliminarTarea.MouseEnter += new System.EventHandler(this.btnConfirmarEliminacion_MouseEnter);
            this.btnEliminarTarea.MouseLeave += new System.EventHandler(this.btnConfirmarEliminacion_MouseLeave);
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(174, 74);
            this.txtMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(102, 20);
            this.txtMateria.TabIndex = 30;
            // 
            // pnl_Tareas
            // 
            this.pnl_Tareas.BackgroundImage = global::Sga.Properties.Resources.fondo_formularios;
            this.pnl_Tareas.Controls.Add(this.dvg_Gestion_actividades);
            this.pnl_Tareas.Controls.Add(this.lblActividades);
            this.pnl_Tareas.Controls.Add(this.txtMateria);
            this.pnl_Tareas.Controls.Add(this.btnGuardarTarea);
            this.pnl_Tareas.Controls.Add(this.btnEliminarTarea);
            this.pnl_Tareas.Controls.Add(this.txtTemaActividad);
            this.pnl_Tareas.Controls.Add(this.label3);
            this.pnl_Tareas.Controls.Add(this.txtDescripcion);
            this.pnl_Tareas.Controls.Add(this.label2);
            this.pnl_Tareas.Controls.Add(this.label1);
            this.pnl_Tareas.Location = new System.Drawing.Point(0, -1);
            this.pnl_Tareas.Name = "pnl_Tareas";
            this.pnl_Tareas.Size = new System.Drawing.Size(735, 556);
            this.pnl_Tareas.TabIndex = 31;
            // 
            // dvg_Gestion_actividades
            // 
            this.dvg_Gestion_actividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Gestion_actividades.Location = new System.Drawing.Point(0, 339);
            this.dvg_Gestion_actividades.Name = "dvg_Gestion_actividades";
            this.dvg_Gestion_actividades.Size = new System.Drawing.Size(735, 217);
            this.dvg_Gestion_actividades.TabIndex = 31;
            // 
            // Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 555);
            this.Controls.Add(this.pnl_Tareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tareas";
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.Actividades_Load);
            this.pnl_Tareas.ResumeLayout(false);
            this.pnl_Tareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Gestion_actividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTemaActividad;
        private System.Windows.Forms.Button btnGuardarTarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Panel pnl_Tareas;
        private System.Windows.Forms.DataGridView dvg_Gestion_actividades;
    }
}