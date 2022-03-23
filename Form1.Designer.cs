
namespace mercado
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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.lbl_valorUni = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_qtd = new System.Windows.Forms.TextBox();
            this.tb_valorUni = new System.Windows.Forms.TextBox();
            this.radioButton_aVista = new System.Windows.Forms.RadioButton();
            this.radioButton_cartao = new System.Windows.Forms.RadioButton();
            this.groupBox_formaPag = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_TotVista = new System.Windows.Forms.Label();
            this.label_TotCartao = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.tb_TotVista = new System.Windows.Forms.TextBox();
            this.tb_TotCartao = new System.Windows.Forms.TextBox();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.groupBox_formaPag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(50, 32);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(56, 18);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código";
            this.lbl_codigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtd.Location = new System.Drawing.Point(263, 32);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(32, 18);
            this.lbl_qtd.TabIndex = 1;
            this.lbl_qtd.Text = "Qtd";
            // 
            // lbl_valorUni
            // 
            this.lbl_valorUni.AutoSize = true;
            this.lbl_valorUni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_valorUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorUni.Location = new System.Drawing.Point(450, 32);
            this.lbl_valorUni.Name = "lbl_valorUni";
            this.lbl_valorUni.Size = new System.Drawing.Size(97, 18);
            this.lbl_valorUni.TabIndex = 2;
            this.lbl_valorUni.Text = "Valor Unitário";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(120, 32);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(100, 20);
            this.tb_codigo.TabIndex = 3;
            // 
            // tb_qtd
            // 
            this.tb_qtd.Location = new System.Drawing.Point(322, 32);
            this.tb_qtd.Name = "tb_qtd";
            this.tb_qtd.Size = new System.Drawing.Size(100, 20);
            this.tb_qtd.TabIndex = 4;
            // 
            // tb_valorUni
            // 
            this.tb_valorUni.Location = new System.Drawing.Point(564, 30);
            this.tb_valorUni.Name = "tb_valorUni";
            this.tb_valorUni.Size = new System.Drawing.Size(100, 20);
            this.tb_valorUni.TabIndex = 5;
            // 
            // radioButton_aVista
            // 
            this.radioButton_aVista.AutoSize = true;
            this.radioButton_aVista.Location = new System.Drawing.Point(15, 36);
            this.radioButton_aVista.Name = "radioButton_aVista";
            this.radioButton_aVista.Size = new System.Drawing.Size(70, 22);
            this.radioButton_aVista.TabIndex = 6;
            this.radioButton_aVista.TabStop = true;
            this.radioButton_aVista.Text = "à Vista";
            this.radioButton_aVista.UseVisualStyleBackColor = true;
            this.radioButton_aVista.CheckedChanged += new System.EventHandler(this.radioButton_aVista_CheckedChanged);
            // 
            // radioButton_cartao
            // 
            this.radioButton_cartao.AutoSize = true;
            this.radioButton_cartao.Location = new System.Drawing.Point(111, 36);
            this.radioButton_cartao.Name = "radioButton_cartao";
            this.radioButton_cartao.Size = new System.Drawing.Size(71, 22);
            this.radioButton_cartao.TabIndex = 7;
            this.radioButton_cartao.TabStop = true;
            this.radioButton_cartao.Text = "Cartão";
            this.radioButton_cartao.UseVisualStyleBackColor = true;
            // 
            // groupBox_formaPag
            // 
            this.groupBox_formaPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox_formaPag.Controls.Add(this.radioButton_aVista);
            this.groupBox_formaPag.Controls.Add(this.radioButton_cartao);
            this.groupBox_formaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_formaPag.Location = new System.Drawing.Point(53, 121);
            this.groupBox_formaPag.Name = "groupBox_formaPag";
            this.groupBox_formaPag.Size = new System.Drawing.Size(200, 59);
            this.groupBox_formaPag.TabIndex = 9;
            this.groupBox_formaPag.TabStop = false;
            this.groupBox_formaPag.Text = "Forma de Pagamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mercado.Properties.Resources.mercado;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 449);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label_TotVista
            // 
            this.label_TotVista.AutoSize = true;
            this.label_TotVista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_TotVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotVista.Location = new System.Drawing.Point(147, 243);
            this.label_TotVista.Name = "label_TotVista";
            this.label_TotVista.Size = new System.Drawing.Size(96, 16);
            this.label_TotVista.TabIndex = 11;
            this.label_TotVista.Text = "Total a Vista";
            // 
            // label_TotCartao
            // 
            this.label_TotCartao.AutoSize = true;
            this.label_TotCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_TotCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotCartao.Location = new System.Drawing.Point(404, 243);
            this.label_TotCartao.Name = "label_TotCartao";
            this.label_TotCartao.Size = new System.Drawing.Size(94, 16);
            this.label_TotCartao.TabIndex = 14;
            this.label_TotCartao.Text = "Total Cartão";
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalc.Location = new System.Drawing.Point(199, 351);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(167, 28);
            this.buttonCalc.TabIndex = 15;
            this.buttonCalc.Text = "Calcular";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // tb_TotVista
            // 
            this.tb_TotVista.Location = new System.Drawing.Point(266, 243);
            this.tb_TotVista.Name = "tb_TotVista";
            this.tb_TotVista.Size = new System.Drawing.Size(100, 20);
            this.tb_TotVista.TabIndex = 16;
            // 
            // tb_TotCartao
            // 
            this.tb_TotCartao.Location = new System.Drawing.Point(540, 242);
            this.tb_TotCartao.Name = "tb_TotCartao";
            this.tb_TotCartao.Size = new System.Drawing.Size(100, 20);
            this.tb_TotCartao.TabIndex = 17;
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Limpar.Location = new System.Drawing.Point(483, 351);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(157, 28);
            this.bt_Limpar.TabIndex = 18;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = false;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.tb_TotCartao);
            this.Controls.Add(this.tb_TotVista);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.label_TotCartao);
            this.Controls.Add(this.label_TotVista);
            this.Controls.Add(this.groupBox_formaPag);
            this.Controls.Add(this.tb_valorUni);
            this.Controls.Add(this.tb_qtd);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.lbl_valorUni);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_formaPag.ResumeLayout(false);
            this.groupBox_formaPag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.Label lbl_valorUni;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_qtd;
        private System.Windows.Forms.TextBox tb_valorUni;
        private System.Windows.Forms.RadioButton radioButton_aVista;
        private System.Windows.Forms.RadioButton radioButton_cartao;
        private System.Windows.Forms.GroupBox groupBox_formaPag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_TotVista;
        private System.Windows.Forms.Label label_TotCartao;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox tb_TotVista;
        private System.Windows.Forms.TextBox tb_TotCartao;
        private System.Windows.Forms.Button bt_Limpar;
    }
}

