namespace practicarapida
{
    partial class frmPractica1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            label2 = new Label();
            txtResultado = new TextBox();
            label3 = new Label();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicacion = new Button();
            btnDivision = new Button();
            lstLista = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 46);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero 1:";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(119, 43);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 1;
            txtN1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(119, 83);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 3;
            txtN2.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 83);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Numero 2:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(119, 121);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 6;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 121);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Resultado:";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(264, 47);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(97, 23);
            btnSumar.TabIndex = 7;
            btnSumar.Text = "Suma";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += button1_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(367, 47);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(85, 23);
            btnRestar.TabIndex = 8;
            btnRestar.Text = "Resta";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Location = new Point(264, 83);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(97, 23);
            btnMultiplicacion.TabIndex = 9;
            btnMultiplicacion.Text = "Multiplicacion";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(367, 83);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(85, 23);
            btnDivision.TabIndex = 10;
            btnDivision.Text = "Division";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(508, 42);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(155, 139);
            lstLista.TabIndex = 11;
            lstLista.SelectedIndexChanged += lstLista_SelectedIndexChanged;
            // 
            // frmPractica1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(702, 274);
            Controls.Add(lstLista);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtResultado);
            Controls.Add(label3);
            Controls.Add(txtN2);
            Controls.Add(label2);
            Controls.Add(txtN1);
            Controls.Add(label1);
            Name = "frmPractica1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Practica";
            Load += frmPractica1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtN1;
        private TextBox txtN2;
        private Label label2;
        private TextBox txtResultado;
        private Label label3;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicacion;
        private Button btnDivision;
        private ListBox lstLista;
    }
}
