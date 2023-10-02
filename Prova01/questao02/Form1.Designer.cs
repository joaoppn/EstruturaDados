namespace questao02
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.bt_park = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.park = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(54, 75);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(100, 22);
            this.txt_placa.TabIndex = 0;
            // 
            // bt_park
            // 
            this.bt_park.Location = new System.Drawing.Point(196, 73);
            this.bt_park.Name = "bt_park";
            this.bt_park.Size = new System.Drawing.Size(92, 23);
            this.bt_park.TabIndex = 1;
            this.bt_park.Text = "Estacionar";
            this.bt_park.UseMnemonic = false;
            this.bt_park.UseVisualStyleBackColor = true;
            this.bt_park.UseWaitCursor = true;
            this.bt_park.Click += new System.EventHandler(this.bt_park_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Retirar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // park
            // 
            this.park.AutoSize = true;
            this.park.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.park.Location = new System.Drawing.Point(63, 229);
            this.park.Name = "park";
            this.park.Size = new System.Drawing.Size(0, 25);
            this.park.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adicione a Placa do carro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.park);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_park);
            this.Controls.Add(this.txt_placa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Button bt_park;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label park;
        private System.Windows.Forms.Label label1;
    }
}

