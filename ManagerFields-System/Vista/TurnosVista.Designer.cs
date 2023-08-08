namespace ManagerFields_System.Vista
{
    partial class TurnosVistaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTurnosLista = new System.Windows.Forms.TabPage();
            this.btnEditarTurno = new System.Windows.Forms.Button();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscarTurno = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageDetalleTurnos = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardarTurno = new System.Windows.Forms.Button();
            this.btnCancelarTurno = new System.Windows.Forms.Button();
            this.txtFechaTurno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoraTurno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionTurno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTurno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbPelota = new System.Windows.Forms.TextBox();
            this.txtbPecheras = new System.Windows.Forms.TextBox();
            this.txtbCancha = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTurnosLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageDetalleTurnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 55);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(823, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(107, 26);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageTurnosLista);
            this.tabControl1.Controls.Add(this.tabPageDetalleTurnos);
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 434);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageTurnosLista
            // 
            this.tabPageTurnosLista.Controls.Add(this.btnEditarTurno);
            this.tabPageTurnosLista.Controls.Add(this.btnEliminarTurno);
            this.tabPageTurnosLista.Controls.Add(this.btnAgregarTurno);
            this.tabPageTurnosLista.Controls.Add(this.dataGridView1);
            this.tabPageTurnosLista.Controls.Add(this.btnBuscarTurno);
            this.tabPageTurnosLista.Controls.Add(this.txtSearch);
            this.tabPageTurnosLista.Controls.Add(this.label1);
            this.tabPageTurnosLista.Location = new System.Drawing.Point(4, 29);
            this.tabPageTurnosLista.Name = "tabPageTurnosLista";
            this.tabPageTurnosLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTurnosLista.Size = new System.Drawing.Size(934, 401);
            this.tabPageTurnosLista.TabIndex = 0;
            this.tabPageTurnosLista.Text = "Lista Turnos";
            this.tabPageTurnosLista.UseVisualStyleBackColor = true;
            // 
            // btnEditarTurno
            // 
            this.btnEditarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnEliminarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnAgregarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(25, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(775, 316);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnBuscarTurno
            // 
            this.btnBuscarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(25, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(662, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar turno";
            // 
            // tabPageDetalleTurnos
            // 
            this.tabPageDetalleTurnos.Controls.Add(this.txtbCancha);
            this.tabPageDetalleTurnos.Controls.Add(this.txtbPecheras);
            this.tabPageDetalleTurnos.Controls.Add(this.label6);
            this.tabPageDetalleTurnos.Controls.Add(this.txtbPelota);
            this.tabPageDetalleTurnos.Controls.Add(this.label7);
            this.tabPageDetalleTurnos.Controls.Add(this.label8);
            this.tabPageDetalleTurnos.Controls.Add(this.btnGuardarTurno);
            this.tabPageDetalleTurnos.Controls.Add(this.btnCancelarTurno);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cancha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pecheras:";
            // 
            // btnGuardarTurno
            // 
            this.btnGuardarTurno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardarTurno.Location = new System.Drawing.Point(37, 289);
            this.btnGuardarTurno.Name = "btnGuardarTurno";
            this.btnGuardarTurno.Size = new System.Drawing.Size(139, 50);
            this.btnGuardarTurno.TabIndex = 9;
            this.btnGuardarTurno.Text = "Guardar";
            this.btnGuardarTurno.UseVisualStyleBackColor = true;
            // 
            // btnCancelarTurno
            // 
            this.btnCancelarTurno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelarTurno.Location = new System.Drawing.Point(284, 289);
            this.btnCancelarTurno.Name = "btnCancelarTurno";
            this.btnCancelarTurno.Size = new System.Drawing.Size(139, 50);
            this.btnCancelarTurno.TabIndex = 8;
            this.btnCancelarTurno.Text = "Cancelar";
            this.btnCancelarTurno.UseVisualStyleBackColor = true;
            // 
            // txtFechaTurno
            // 
            this.txtFechaTurno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFechaTurno.Location = new System.Drawing.Point(37, 130);
            this.txtFechaTurno.Name = "txtFechaTurno";
            this.txtFechaTurno.Size = new System.Drawing.Size(158, 26);
            this.txtFechaTurno.TabIndex = 7;
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
            // txtHoraTurno
            // 
            this.txtHoraTurno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHoraTurno.Location = new System.Drawing.Point(265, 130);
            this.txtHoraTurno.Name = "txtHoraTurno";
            this.txtHoraTurno.Size = new System.Drawing.Size(158, 26);
            this.txtHoraTurno.TabIndex = 5;
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
            // txtDescripcionTurno
            // 
            this.txtDescripcionTurno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcionTurno.Location = new System.Drawing.Point(37, 212);
            this.txtDescripcionTurno.Name = "txtDescripcionTurno";
            this.txtDescripcionTurno.Size = new System.Drawing.Size(386, 26);
            this.txtDescripcionTurno.TabIndex = 3;
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
            this.txtIdTurno.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pelota:";
            // 
            // txtbPelota
            // 
            this.txtbPelota.Location = new System.Drawing.Point(315, 32);
            this.txtbPelota.Name = "txtbPelota";
            this.txtbPelota.Size = new System.Drawing.Size(43, 26);
            this.txtbPelota.TabIndex = 20;
            // 
            // txtbPecheras
            // 
            this.txtbPecheras.Location = new System.Drawing.Point(488, 32);
            this.txtbPecheras.Name = "txtbPecheras";
            this.txtbPecheras.Size = new System.Drawing.Size(43, 26);
            this.txtbPecheras.TabIndex = 21;
            // 
            // txtbCancha
            // 
            this.txtbCancha.Location = new System.Drawing.Point(646, 32);
            this.txtbCancha.Name = "txtbCancha";
            this.txtbCancha.Size = new System.Drawing.Size(41, 26);
            this.txtbCancha.TabIndex = 22;
            // 
            // TurnosVistaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 489);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TurnosVistaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageTurnosLista.ResumeLayout(false);
            this.tabPageTurnosLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageDetalleTurnos.ResumeLayout(false);
            this.tabPageDetalleTurnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTurnosLista;
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
        private System.Windows.Forms.Button btnGuardarTurno;
        private System.Windows.Forms.Button btnCancelarTurno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtbCancha;
        private System.Windows.Forms.TextBox txtbPecheras;
        private System.Windows.Forms.TextBox txtbPelota;
        private System.Windows.Forms.Label label7;
    }
}