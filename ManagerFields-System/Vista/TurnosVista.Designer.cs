namespace ManagerFields_System.Vista
{
    partial class TurnosVista
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEditarTurno = new System.Windows.Forms.Button();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscarTurno = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageDetalleTurnos = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTurno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionTurno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoraTurno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaTurno = new System.Windows.Forms.TextBox();
            this.btbCancelarTurno = new System.Windows.Forms.Button();
            this.btbGuardarTurno = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageDetalleTurnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(36, 16);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(74, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Turnos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 55);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageDetalleTurnos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 434);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEditarTurno);
            this.tabPage1.Controls.Add(this.btnEliminarTurno);
            this.tabPage1.Controls.Add(this.btnAgregarTurno);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnBuscarTurno);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(934, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista Turnos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEditarTurno
            // 
            this.btnEditarTurno.BackColor = System.Drawing.Color.White;
            this.btnEditarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTurno.Location = new System.Drawing.Point(818, 179);
            this.btnEditarTurno.Name = "btnEditarTurno";
            this.btnEditarTurno.Size = new System.Drawing.Size(99, 26);
            this.btnEditarTurno.TabIndex = 6;
            this.btnEditarTurno.Text = "Editar";
            this.btnEditarTurno.UseVisualStyleBackColor = false;
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.BackColor = System.Drawing.Color.White;
            this.btnEliminarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTurno.Location = new System.Drawing.Point(818, 129);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(99, 26);
            this.btnEliminarTurno.TabIndex = 5;
            this.btnEliminarTurno.Text = "Eliminar";
            this.btnEliminarTurno.UseVisualStyleBackColor = false;
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.BackColor = System.Drawing.Color.White;
            this.btnAgregarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTurno.Location = new System.Drawing.Point(818, 77);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(99, 26);
            this.btnAgregarTurno.TabIndex = 4;
            this.btnAgregarTurno.Text = "Agregar";
            this.btnAgregarTurno.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 316);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnBuscarTurno
            // 
            this.btnBuscarTurno.BackColor = System.Drawing.Color.White;
            this.btnBuscarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTurno.Location = new System.Drawing.Point(693, 35);
            this.btnBuscarTurno.Name = "btnBuscarTurno";
            this.btnBuscarTurno.Size = new System.Drawing.Size(107, 26);
            this.btnBuscarTurno.TabIndex = 2;
            this.btnBuscarTurno.Text = "Buscar";
            this.btnBuscarTurno.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(25, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(662, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar turno";
            // 
            // tabPageDetalleTurnos
            // 
            this.tabPageDetalleTurnos.Controls.Add(this.btbGuardarTurno);
            this.tabPageDetalleTurnos.Controls.Add(this.btbCancelarTurno);
            this.tabPageDetalleTurnos.Controls.Add(this.txtFechaTurno);
            this.tabPageDetalleTurnos.Controls.Add(this.label5);
            this.tabPageDetalleTurnos.Controls.Add(this.txtHoraTurno);
            this.tabPageDetalleTurnos.Controls.Add(this.label4);
            this.tabPageDetalleTurnos.Controls.Add(this.txtDescripcionTurno);
            this.tabPageDetalleTurnos.Controls.Add(this.label3);
            this.tabPageDetalleTurnos.Controls.Add(this.txtIdTurno);
            this.tabPageDetalleTurnos.Controls.Add(this.label2);
            this.tabPageDetalleTurnos.Location = new System.Drawing.Point(4, 29);
            this.tabPageDetalleTurnos.Name = "tabPageDetalleTurnos";
            this.tabPageDetalleTurnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetalleTurnos.Size = new System.Drawing.Size(934, 401);
            this.tabPageDetalleTurnos.TabIndex = 1;
            this.tabPageDetalleTurnos.Text = "Detalle Turnos";
            this.tabPageDetalleTurnos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // txtIdTurno
            // 
            this.txtIdTurno.Location = new System.Drawing.Point(37, 58);
            this.txtIdTurno.Name = "txtIdTurno";
            this.txtIdTurno.Size = new System.Drawing.Size(158, 26);
            this.txtIdTurno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id:";
            // 
            // txtDescripcionTurno
            // 
            this.txtDescripcionTurno.Location = new System.Drawing.Point(37, 212);
            this.txtDescripcionTurno.Name = "txtDescripcionTurno";
            this.txtDescripcionTurno.Size = new System.Drawing.Size(386, 26);
            this.txtDescripcionTurno.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora inicio:";
            // 
            // txtHoraTurno
            // 
            this.txtHoraTurno.Location = new System.Drawing.Point(265, 130);
            this.txtHoraTurno.Name = "txtHoraTurno";
            this.txtHoraTurno.Size = new System.Drawing.Size(158, 26);
            this.txtHoraTurno.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha:";
            // 
            // txtFechaTurno
            // 
            this.txtFechaTurno.Location = new System.Drawing.Point(37, 130);
            this.txtFechaTurno.Name = "txtFechaTurno";
            this.txtFechaTurno.Size = new System.Drawing.Size(158, 26);
            this.txtFechaTurno.TabIndex = 7;
            // 
            // btbCancelarTurno
            // 
            this.btbCancelarTurno.Location = new System.Drawing.Point(284, 289);
            this.btbCancelarTurno.Name = "btbCancelarTurno";
            this.btbCancelarTurno.Size = new System.Drawing.Size(139, 50);
            this.btbCancelarTurno.TabIndex = 8;
            this.btbCancelarTurno.Text = "Cancelar";
            this.btbCancelarTurno.UseVisualStyleBackColor = true;
            // 
            // btbGuardarTurno
            // 
            this.btbGuardarTurno.Location = new System.Drawing.Point(37, 289);
            this.btbGuardarTurno.Name = "btbGuardarTurno";
            this.btbGuardarTurno.Size = new System.Drawing.Size(139, 50);
            this.btbGuardarTurno.TabIndex = 9;
            this.btbGuardarTurno.Text = "Guardar";
            this.btbGuardarTurno.UseVisualStyleBackColor = true;
            // 
            // TurnosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 489);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TurnosVista";
            this.Text = "Turnos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageDetalleTurnos.ResumeLayout(false);
            this.tabPageDetalleTurnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscarTurno;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageDetalleTurnos;
        private System.Windows.Forms.Button btnEditarTurno;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.Button btnAgregarTurno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoraTurno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionTurno;
        private System.Windows.Forms.Button btbGuardarTurno;
        private System.Windows.Forms.Button btbCancelarTurno;
    }
}