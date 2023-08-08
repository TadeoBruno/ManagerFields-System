namespace ManagerFields_System.Vista
{
    partial class MainVista
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.btnCanchas = new System.Windows.Forms.Button();
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnIE = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnED = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnED);
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Controls.Add(this.btnIE);
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Controls.Add(this.btnSocios);
            this.panel1.Controls.Add(this.btnCanchas);
            this.panel1.Controls.Add(this.btnTurnos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnTurnos
            // 
            this.btnTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnos.Location = new System.Drawing.Point(0, 27);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(200, 53);
            this.btnTurnos.TabIndex = 1;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.UseVisualStyleBackColor = true;
            // 
            // btnCanchas
            // 
            this.btnCanchas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanchas.Location = new System.Drawing.Point(0, 86);
            this.btnCanchas.Name = "btnCanchas";
            this.btnCanchas.Size = new System.Drawing.Size(200, 53);
            this.btnCanchas.TabIndex = 2;
            this.btnCanchas.Text = "Canchas";
            this.btnCanchas.UseVisualStyleBackColor = true;
            // 
            // btnSocios
            // 
            this.btnSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocios.Location = new System.Drawing.Point(0, 263);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(200, 53);
            this.btnSocios.TabIndex = 3;
            this.btnSocios.Text = "Socios";
            this.btnSocios.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(0, 322);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(200, 53);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnIE
            // 
            this.btnIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIE.Location = new System.Drawing.Point(0, 381);
            this.btnIE.Name = "btnIE";
            this.btnIE.Size = new System.Drawing.Size(200, 53);
            this.btnIE.TabIndex = 2;
            this.btnIE.Text = "Ingresos/egresos";
            this.btnIE.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(0, 145);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(200, 53);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnED
            // 
            this.btnED.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnED.Location = new System.Drawing.Point(0, 204);
            this.btnED.Name = "btnED";
            this.btnED.Size = new System.Drawing.Size(200, 53);
            this.btnED.TabIndex = 6;
            this.btnED.Text = "Eventos Deportivos";
            this.btnED.UseVisualStyleBackColor = true;
            // 
            // MainVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainVista";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnED;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnIE;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button btnCanchas;
        private System.Windows.Forms.Button btnTurnos;
    }
}