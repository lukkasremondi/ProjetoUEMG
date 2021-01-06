namespace TrabalhoFinal
{
    partial class Inserir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inserir));
            this.numerodeserieLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nomedapecaLabel = new System.Windows.Forms.Label();
            this.idcategoriaLabel = new System.Windows.Forms.Label();
            this.valordacompraLabel = new System.Windows.Forms.Label();
            this.margemdelucroLabel = new System.Windows.Forms.Label();
            this.impostoLabel = new System.Windows.Forms.Label();
            this.numeroTxtBox = new System.Windows.Forms.TextBox();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.idcTxtBox = new System.Windows.Forms.TextBox();
            this.valorTxtBox = new System.Windows.Forms.TextBox();
            this.lucroTxtBox = new System.Windows.Forms.TextBox();
            this.impostoTxtBox = new System.Windows.Forms.TextBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numerodeserieLabel
            // 
            this.numerodeserieLabel.AutoSize = true;
            this.numerodeserieLabel.Location = new System.Drawing.Point(13, 13);
            this.numerodeserieLabel.Name = "numerodeserieLabel";
            this.numerodeserieLabel.Size = new System.Drawing.Size(165, 25);
            this.numerodeserieLabel.TabIndex = 0;
            this.numerodeserieLabel.Text = "Numero de Série:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(13, 54);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(37, 25);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID:";
            // 
            // nomedapecaLabel
            // 
            this.nomedapecaLabel.AutoSize = true;
            this.nomedapecaLabel.Location = new System.Drawing.Point(13, 93);
            this.nomedapecaLabel.Name = "nomedapecaLabel";
            this.nomedapecaLabel.Size = new System.Drawing.Size(145, 25);
            this.nomedapecaLabel.TabIndex = 2;
            this.nomedapecaLabel.Text = "Nome da peça:";
            // 
            // idcategoriaLabel
            // 
            this.idcategoriaLabel.AutoSize = true;
            this.idcategoriaLabel.Location = new System.Drawing.Point(13, 140);
            this.idcategoriaLabel.Name = "idcategoriaLabel";
            this.idcategoriaLabel.Size = new System.Drawing.Size(127, 25);
            this.idcategoriaLabel.TabIndex = 3;
            this.idcategoriaLabel.Text = "ID Categoria:";
            // 
            // valordacompraLabel
            // 
            this.valordacompraLabel.AutoSize = true;
            this.valordacompraLabel.Location = new System.Drawing.Point(13, 183);
            this.valordacompraLabel.Name = "valordacompraLabel";
            this.valordacompraLabel.Size = new System.Drawing.Size(166, 25);
            this.valordacompraLabel.TabIndex = 4;
            this.valordacompraLabel.Text = "Valor da Compra:";
            // 
            // margemdelucroLabel
            // 
            this.margemdelucroLabel.AutoSize = true;
            this.margemdelucroLabel.Location = new System.Drawing.Point(18, 228);
            this.margemdelucroLabel.Name = "margemdelucroLabel";
            this.margemdelucroLabel.Size = new System.Drawing.Size(171, 25);
            this.margemdelucroLabel.TabIndex = 5;
            this.margemdelucroLabel.Text = "Margem de Lucro:";
            // 
            // impostoLabel
            // 
            this.impostoLabel.AutoSize = true;
            this.impostoLabel.Location = new System.Drawing.Point(18, 273);
            this.impostoLabel.Name = "impostoLabel";
            this.impostoLabel.Size = new System.Drawing.Size(87, 25);
            this.impostoLabel.TabIndex = 6;
            this.impostoLabel.Text = "Imposto:";
            // 
            // numeroTxtBox
            // 
            this.numeroTxtBox.Location = new System.Drawing.Point(196, 13);
            this.numeroTxtBox.Name = "numeroTxtBox";
            this.numeroTxtBox.Size = new System.Drawing.Size(425, 29);
            this.numeroTxtBox.TabIndex = 7;
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(196, 54);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(425, 29);
            this.idTxtBox.TabIndex = 8;
            this.idTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTxtBox_KeyPress);
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.Location = new System.Drawing.Point(196, 93);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(425, 29);
            this.nomeTxtBox.TabIndex = 9;
            // 
            // idcTxtBox
            // 
            this.idcTxtBox.Location = new System.Drawing.Point(196, 140);
            this.idcTxtBox.Name = "idcTxtBox";
            this.idcTxtBox.Size = new System.Drawing.Size(425, 29);
            this.idcTxtBox.TabIndex = 10;
            this.idcTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idcTxtBox_KeyPress);
            // 
            // valorTxtBox
            // 
            this.valorTxtBox.Location = new System.Drawing.Point(196, 183);
            this.valorTxtBox.Name = "valorTxtBox";
            this.valorTxtBox.Size = new System.Drawing.Size(424, 29);
            this.valorTxtBox.TabIndex = 11;
            this.valorTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorTxtBox_KeyPress);
            // 
            // lucroTxtBox
            // 
            this.lucroTxtBox.Location = new System.Drawing.Point(196, 228);
            this.lucroTxtBox.Name = "lucroTxtBox";
            this.lucroTxtBox.Size = new System.Drawing.Size(424, 29);
            this.lucroTxtBox.TabIndex = 12;
            this.lucroTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lucroTxtBox_KeyPress);
            // 
            // impostoTxtBox
            // 
            this.impostoTxtBox.Location = new System.Drawing.Point(196, 273);
            this.impostoTxtBox.Name = "impostoTxtBox";
            this.impostoTxtBox.Size = new System.Drawing.Size(424, 29);
            this.impostoTxtBox.TabIndex = 13;
            this.impostoTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impostoTxtBox_KeyPress_1);
            // 
            // salvarButton
            // 
            this.salvarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salvarButton.BackgroundImage")));
            this.salvarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salvarButton.Location = new System.Drawing.Point(540, 319);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(80, 66);
            this.salvarButton.TabIndex = 14;
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelarButton.BackgroundImage")));
            this.cancelarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelarButton.Location = new System.Drawing.Point(453, 319);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(81, 66);
            this.cancelarButton.TabIndex = 15;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 400);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.impostoTxtBox);
            this.Controls.Add(this.lucroTxtBox);
            this.Controls.Add(this.valorTxtBox);
            this.Controls.Add(this.idcTxtBox);
            this.Controls.Add(this.nomeTxtBox);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.numeroTxtBox);
            this.Controls.Add(this.impostoLabel);
            this.Controls.Add(this.margemdelucroLabel);
            this.Controls.Add(this.valordacompraLabel);
            this.Controls.Add(this.idcategoriaLabel);
            this.Controls.Add(this.nomedapecaLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.numerodeserieLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inserir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir";
            this.Load += new System.EventHandler(this.Inserir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numerodeserieLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nomedapecaLabel;
        private System.Windows.Forms.Label idcategoriaLabel;
        private System.Windows.Forms.Label valordacompraLabel;
        private System.Windows.Forms.Label margemdelucroLabel;
        private System.Windows.Forms.Label impostoLabel;
        private System.Windows.Forms.TextBox numeroTxtBox;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private System.Windows.Forms.TextBox idcTxtBox;
        private System.Windows.Forms.TextBox valorTxtBox;
        private System.Windows.Forms.TextBox lucroTxtBox;
        private System.Windows.Forms.TextBox impostoTxtBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}