
namespace Alumnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.btnAcepta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbAula = new System.Windows.Forms.ListBox();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.btnRetira = new System.Windows.Forms.Button();
            this.btnExpulsado = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsbLab = new System.Windows.Forms.ListBox();
            this.lblCantidadAula = new System.Windows.Forms.Label();
            this.lblCantidadLaboratorio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAcepta);
            this.groupBox1.Controls.Add(this.txtAlumno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno";
            // 
            // txtAlumno
            // 
            this.txtAlumno.ForeColor = System.Drawing.Color.Blue;
            this.txtAlumno.Location = new System.Drawing.Point(17, 31);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(402, 23);
            this.txtAlumno.TabIndex = 0;
            // 
            // btnAcepta
            // 
            this.btnAcepta.Location = new System.Drawing.Point(450, 31);
            this.btnAcepta.Name = "btnAcepta";
            this.btnAcepta.Size = new System.Drawing.Size(75, 23);
            this.btnAcepta.TabIndex = 1;
            this.btnAcepta.Text = "Acepta";
            this.btnAcepta.UseVisualStyleBackColor = true;
            this.btnAcepta.Click += new System.EventHandler(this.btnAcepta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblCantidadAula);
            this.groupBox2.Controls.Add(this.lsbAula);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(21, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aula";
            // 
            // lsbAula
            // 
            this.lsbAula.ForeColor = System.Drawing.Color.Blue;
            this.lsbAula.FormattingEnabled = true;
            this.lsbAula.ItemHeight = 16;
            this.lsbAula.Location = new System.Drawing.Point(17, 31);
            this.lsbAula.Name = "lsbAula";
            this.lsbAula.Size = new System.Drawing.Size(164, 148);
            this.lsbAula.TabIndex = 0;
            // 
            // btnAgrega
            // 
            this.btnAgrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgrega.Location = new System.Drawing.Point(241, 124);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(105, 23);
            this.btnAgrega.TabIndex = 2;
            this.btnAgrega.Text = ">>";
            this.btnAgrega.UseVisualStyleBackColor = true;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // btnRetira
            // 
            this.btnRetira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetira.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRetira.Location = new System.Drawing.Point(241, 153);
            this.btnRetira.Name = "btnRetira";
            this.btnRetira.Size = new System.Drawing.Size(105, 23);
            this.btnRetira.TabIndex = 3;
            this.btnRetira.Text = "<<";
            this.btnRetira.UseVisualStyleBackColor = true;
            this.btnRetira.Click += new System.EventHandler(this.btnRetira_Click);
            // 
            // btnExpulsado
            // 
            this.btnExpulsado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpulsado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExpulsado.Location = new System.Drawing.Point(241, 222);
            this.btnExpulsado.Name = "btnExpulsado";
            this.btnExpulsado.Size = new System.Drawing.Size(105, 28);
            this.btnExpulsado.TabIndex = 4;
            this.btnExpulsado.Text = "Expulsado";
            this.btnExpulsado.UseVisualStyleBackColor = true;
            this.btnExpulsado.Click += new System.EventHandler(this.btnExpulsado_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblCantidadLaboratorio);
            this.groupBox3.Controls.Add(this.lsbLab);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(365, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 232);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Laboratorio";
            // 
            // lsbLab
            // 
            this.lsbLab.ForeColor = System.Drawing.Color.Blue;
            this.lsbLab.FormattingEnabled = true;
            this.lsbLab.ItemHeight = 16;
            this.lsbLab.Location = new System.Drawing.Point(17, 31);
            this.lsbLab.Name = "lsbLab";
            this.lsbLab.Size = new System.Drawing.Size(164, 148);
            this.lsbLab.TabIndex = 0;
            // 
            // lblCantidadAula
            // 
            this.lblCantidadAula.Location = new System.Drawing.Point(14, 195);
            this.lblCantidadAula.Name = "lblCantidadAula";
            this.lblCantidadAula.Size = new System.Drawing.Size(167, 21);
            this.lblCantidadAula.TabIndex = 1;
            // 
            // lblCantidadLaboratorio
            // 
            this.lblCantidadLaboratorio.Location = new System.Drawing.Point(14, 195);
            this.lblCantidadLaboratorio.Name = "lblCantidadLaboratorio";
            this.lblCantidadLaboratorio.Size = new System.Drawing.Size(167, 21);
            this.lblCantidadLaboratorio.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alumnos.Properties.Resources.main_bg10;
            this.ClientSize = new System.Drawing.Size(588, 346);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExpulsado);
            this.Controls.Add(this.btnRetira);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAcepta;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbAula;
        private System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.Label lblCantidadAula;
        private System.Windows.Forms.Button btnRetira;
        private System.Windows.Forms.Button btnExpulsado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCantidadLaboratorio;
        private System.Windows.Forms.ListBox lsbLab;
    }
}

