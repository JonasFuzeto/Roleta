
namespace Jogo
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
            this.components = new System.ComponentModel.Container();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnGirar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.numSorte = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Jogar = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSorte)).BeginInit();
            this.Jogar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblResultado.Location = new System.Drawing.Point(141, 62);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(17, 21);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "?";
            // 
            // btnGirar
            // 
            this.btnGirar.BackColor = System.Drawing.Color.Black;
            this.btnGirar.ForeColor = System.Drawing.Color.Gold;
            this.btnGirar.Location = new System.Drawing.Point(6, 97);
            this.btnGirar.Name = "btnGirar";
            this.btnGirar.Size = new System.Drawing.Size(75, 30);
            this.btnGirar.TabIndex = 1;
            this.btnGirar.Text = "Girar Roleta";
            this.btnGirar.UseVisualStyleBackColor = false;
            this.btnGirar.Click += new System.EventHandler(this.btnGirar_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Goldenrod;
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblMensagem.Location = new System.Drawing.Point(6, 26);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(161, 21);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Escolha um número";
            // 
            // numSorte
            // 
            this.numSorte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numSorte.ForeColor = System.Drawing.SystemColors.Info;
            this.numSorte.Location = new System.Drawing.Point(6, 62);
            this.numSorte.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSorte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSorte.Name = "numSorte";
            this.numSorte.Size = new System.Drawing.Size(120, 29);
            this.numSorte.TabIndex = 3;
            this.numSorte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Jogar
            // 
            this.Jogar.Controls.Add(this.lblResultado);
            this.Jogar.Controls.Add(this.btnGirar);
            this.Jogar.Controls.Add(this.numSorte);
            this.Jogar.Controls.Add(this.lblMensagem);
            this.Jogar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Jogar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Jogar.Location = new System.Drawing.Point(33, 43);
            this.Jogar.Name = "Jogar";
            this.Jogar.Size = new System.Drawing.Size(290, 203);
            this.Jogar.TabIndex = 4;
            this.Jogar.TabStop = false;
            this.Jogar.Text = "Jogar";
            this.Jogar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources._23625236_cassino_roleta_fundo_ilustracao_ai_generativo_gratis_foto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Jogar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSorte)).EndInit();
            this.Jogar.ResumeLayout(false);
            this.Jogar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnGirar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.NumericUpDown numSorte;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox Jogar;
    }
}

