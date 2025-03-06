namespace WinFormsApp41
{
    partial class Form1
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
            txtNombreJugador = new TextBox();
            txtNumeroJugador = new TextBox();
            txtNumHits = new TextBox();
            txtNumVeces = new TextBox();
            cbPosiciones = new ComboBox();
            btnVer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Location = new Point(93, 41);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(150, 31);
            txtNombreJugador.TabIndex = 0;
            // 
            // txtNumeroJugador
            // 
            txtNumeroJugador.Location = new Point(93, 103);
            txtNumeroJugador.Name = "txtNumeroJugador";
            txtNumeroJugador.Size = new Size(150, 31);
            txtNumeroJugador.TabIndex = 1;
            // 
            // txtNumHits
            // 
            txtNumHits.Location = new Point(93, 271);
            txtNumHits.Name = "txtNumHits";
            txtNumHits.Size = new Size(150, 31);
            txtNumHits.TabIndex = 2;
            // 
            // txtNumVeces
            // 
            txtNumVeces.Location = new Point(332, 271);
            txtNumVeces.Name = "txtNumVeces";
            txtNumVeces.Size = new Size(150, 31);
            txtNumVeces.TabIndex = 3;
            // 
            // cbPosiciones
            // 
            cbPosiciones.FormattingEnabled = true;
            cbPosiciones.Location = new Point(93, 178);
            cbPosiciones.Name = "cbPosiciones";
            cbPosiciones.Size = new Size(182, 33);
            cbPosiciones.TabIndex = 4;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(344, 153);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 34);
            btnVer.TabIndex = 5;
            btnVer.Text = "button1";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 13);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 6;
            label1.Text = "Nombre del Jugador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 75);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 7;
            label2.Text = "Numero de Jugador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 137);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 8;
            label3.Text = "posicion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 243);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 9;
            label4.Text = "Numero de Hits";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 243);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 10;
            label5.Text = "Numero Bat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(622, 277);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 11;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVer);
            Controls.Add(cbPosiciones);
            Controls.Add(txtNumVeces);
            Controls.Add(txtNumHits);
            Controls.Add(txtNumeroJugador);
            Controls.Add(txtNombreJugador);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreJugador;
        private TextBox txtNumeroJugador;
        private TextBox txtNumHits;
        private TextBox txtNumVeces;
        private ComboBox cbPosiciones;
        private Button btnVer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
