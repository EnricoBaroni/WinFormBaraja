
namespace WinFormBaraja
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
            this.btnCrearBaraja = new System.Windows.Forms.Button();
            this.lstContenido = new System.Windows.Forms.ListBox();
            this.btnRobar = new System.Windows.Forms.Button();
            this.btnMezclar = new System.Windows.Forms.Button();
            this.lblTextoNumCartas = new System.Windows.Forms.Label();
            this.lblNumCartas = new System.Windows.Forms.Label();
            this.btnCogerCarta = new System.Windows.Forms.Button();
            this.txtCogerCarta = new System.Windows.Forms.TextBox();
            this.btnCogerCartaRandom = new System.Windows.Forms.Button();
            this.pictureBoxCarta = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearBaraja
            // 
            this.btnCrearBaraja.Location = new System.Drawing.Point(38, 49);
            this.btnCrearBaraja.Name = "btnCrearBaraja";
            this.btnCrearBaraja.Size = new System.Drawing.Size(75, 23);
            this.btnCrearBaraja.TabIndex = 0;
            this.btnCrearBaraja.Text = "Crear Baraja";
            this.btnCrearBaraja.UseVisualStyleBackColor = true;
            this.btnCrearBaraja.Click += new System.EventHandler(this.btnCrearBaraja_Click);
            // 
            // lstContenido
            // 
            this.lstContenido.FormattingEnabled = true;
            this.lstContenido.Location = new System.Drawing.Point(149, 29);
            this.lstContenido.Name = "lstContenido";
            this.lstContenido.Size = new System.Drawing.Size(168, 173);
            this.lstContenido.TabIndex = 1;
            // 
            // btnRobar
            // 
            this.btnRobar.Enabled = false;
            this.btnRobar.Location = new System.Drawing.Point(38, 104);
            this.btnRobar.Name = "btnRobar";
            this.btnRobar.Size = new System.Drawing.Size(75, 23);
            this.btnRobar.TabIndex = 2;
            this.btnRobar.Text = "Robar";
            this.btnRobar.UseVisualStyleBackColor = true;
            this.btnRobar.Click += new System.EventHandler(this.btnRobar_Click);
            // 
            // btnMezclar
            // 
            this.btnMezclar.Enabled = false;
            this.btnMezclar.Location = new System.Drawing.Point(38, 162);
            this.btnMezclar.Name = "btnMezclar";
            this.btnMezclar.Size = new System.Drawing.Size(75, 23);
            this.btnMezclar.TabIndex = 3;
            this.btnMezclar.Text = "Mezclar";
            this.btnMezclar.UseVisualStyleBackColor = true;
            this.btnMezclar.Click += new System.EventHandler(this.btnMezclar_Click);
            // 
            // lblTextoNumCartas
            // 
            this.lblTextoNumCartas.AutoSize = true;
            this.lblTextoNumCartas.Location = new System.Drawing.Point(146, 9);
            this.lblTextoNumCartas.Name = "lblTextoNumCartas";
            this.lblTextoNumCartas.Size = new System.Drawing.Size(98, 13);
            this.lblTextoNumCartas.TabIndex = 4;
            this.lblTextoNumCartas.Text = "Numero de Cartas: ";
            // 
            // lblNumCartas
            // 
            this.lblNumCartas.AutoSize = true;
            this.lblNumCartas.Location = new System.Drawing.Point(250, 9);
            this.lblNumCartas.Name = "lblNumCartas";
            this.lblNumCartas.Size = new System.Drawing.Size(13, 13);
            this.lblNumCartas.TabIndex = 5;
            this.lblNumCartas.Text = "0";
            // 
            // btnCogerCarta
            // 
            this.btnCogerCarta.Enabled = false;
            this.btnCogerCarta.Location = new System.Drawing.Point(38, 220);
            this.btnCogerCarta.Name = "btnCogerCarta";
            this.btnCogerCarta.Size = new System.Drawing.Size(75, 23);
            this.btnCogerCarta.TabIndex = 6;
            this.btnCogerCarta.Text = "Coger Carta";
            this.btnCogerCarta.UseVisualStyleBackColor = true;
            this.btnCogerCarta.Click += new System.EventHandler(this.btnCogerCarta_Click);
            // 
            // txtCogerCarta
            // 
            this.txtCogerCarta.Enabled = false;
            this.txtCogerCarta.Location = new System.Drawing.Point(129, 222);
            this.txtCogerCarta.Name = "txtCogerCarta";
            this.txtCogerCarta.Size = new System.Drawing.Size(37, 20);
            this.txtCogerCarta.TabIndex = 7;
            // 
            // btnCogerCartaRandom
            // 
            this.btnCogerCartaRandom.Enabled = false;
            this.btnCogerCartaRandom.Location = new System.Drawing.Point(242, 212);
            this.btnCogerCartaRandom.Name = "btnCogerCartaRandom";
            this.btnCogerCartaRandom.Size = new System.Drawing.Size(75, 39);
            this.btnCogerCartaRandom.TabIndex = 8;
            this.btnCogerCartaRandom.Text = "Coger Carta Random";
            this.btnCogerCartaRandom.UseVisualStyleBackColor = true;
            this.btnCogerCartaRandom.Click += new System.EventHandler(this.btnCogerCartaRandom_Click);
            // 
            // pictureBoxCarta
            // 
            this.pictureBoxCarta.Location = new System.Drawing.Point(374, 29);
            this.pictureBoxCarta.Name = "pictureBoxCarta";
            this.pictureBoxCarta.Size = new System.Drawing.Size(179, 244);
            this.pictureBoxCarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarta.TabIndex = 9;
            this.pictureBoxCarta.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tu Carta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCarta);
            this.Controls.Add(this.btnCogerCartaRandom);
            this.Controls.Add(this.txtCogerCarta);
            this.Controls.Add(this.btnCogerCarta);
            this.Controls.Add(this.lblNumCartas);
            this.Controls.Add(this.lblTextoNumCartas);
            this.Controls.Add(this.btnMezclar);
            this.Controls.Add(this.btnRobar);
            this.Controls.Add(this.lstContenido);
            this.Controls.Add(this.btnCrearBaraja);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearBaraja;
        private System.Windows.Forms.ListBox lstContenido;
        private System.Windows.Forms.Button btnRobar;
        private System.Windows.Forms.Button btnMezclar;
        private System.Windows.Forms.Label lblTextoNumCartas;
        private System.Windows.Forms.Label lblNumCartas;
        private System.Windows.Forms.Button btnCogerCarta;
        private System.Windows.Forms.TextBox txtCogerCarta;
        private System.Windows.Forms.Button btnCogerCartaRandom;
        private System.Windows.Forms.PictureBox pictureBoxCarta;
        private System.Windows.Forms.Label label1;
    }
}

