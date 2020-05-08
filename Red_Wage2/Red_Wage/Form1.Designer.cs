namespace Red_Wage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.lblTamanhoOriginal = new System.Windows.Forms.Label();
            this.lblTamanhoFinal = new System.Windows.Forms.Label();
            this.lblImagemOriginal = new System.Windows.Forms.Label();
            this.lblImagemFinal = new System.Windows.Forms.Label();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.txtDiretorio2 = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnRedimensionar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "JPG";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Arquivos JPG|*.jpg|Todos os arquivos|*.*";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.ReadOnlyChecked = true;
            this.openFileDialog.Title = "Localizar Imagens";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "JPG";
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.Transparent;
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagem.InitialImage = null;
            this.picImagem.Location = new System.Drawing.Point(5, 93);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(812, 612);
            this.picImagem.TabIndex = 11;
            this.picImagem.TabStop = false;
            // 
            // lblTamanhoOriginal
            // 
            this.lblTamanhoOriginal.BackColor = System.Drawing.Color.Transparent;
            this.lblTamanhoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanhoOriginal.Location = new System.Drawing.Point(7, 71);
            this.lblTamanhoOriginal.Name = "lblTamanhoOriginal";
            this.lblTamanhoOriginal.Size = new System.Drawing.Size(216, 19);
            this.lblTamanhoOriginal.TabIndex = 12;
            this.lblTamanhoOriginal.Text = "Tamanho Original: ";
            this.lblTamanhoOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTamanhoFinal
            // 
            this.lblTamanhoFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblTamanhoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanhoFinal.Location = new System.Drawing.Point(225, 71);
            this.lblTamanhoFinal.Name = "lblTamanhoFinal";
            this.lblTamanhoFinal.Size = new System.Drawing.Size(216, 19);
            this.lblTamanhoFinal.TabIndex = 13;
            this.lblTamanhoFinal.Text = "Tamanho Final: ";
            this.lblTamanhoFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImagemOriginal
            // 
            this.lblImagemOriginal.BackColor = System.Drawing.Color.Transparent;
            this.lblImagemOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemOriginal.Location = new System.Drawing.Point(142, 12);
            this.lblImagemOriginal.Name = "lblImagemOriginal";
            this.lblImagemOriginal.Size = new System.Drawing.Size(83, 23);
            this.lblImagemOriginal.TabIndex = 14;
            this.lblImagemOriginal.Text = "Imagem Original";
            this.lblImagemOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImagemFinal
            // 
            this.lblImagemFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblImagemFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemFinal.Location = new System.Drawing.Point(142, 42);
            this.lblImagemFinal.Name = "lblImagemFinal";
            this.lblImagemFinal.Size = new System.Drawing.Size(81, 23);
            this.lblImagemFinal.TabIndex = 15;
            this.lblImagemFinal.Text = "Imagem Final";
            this.lblImagemFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(228, 14);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(412, 20);
            this.txtDiretorio.TabIndex = 16;
            // 
            // txtDiretorio2
            // 
            this.txtDiretorio2.Location = new System.Drawing.Point(228, 44);
            this.txtDiretorio2.Name = "txtDiretorio2";
            this.txtDiretorio2.Size = new System.Drawing.Size(412, 20);
            this.txtDiretorio2.TabIndex = 17;
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrir.BackgroundImage = global::Red_Wage.Properties.Resources.imagem;
            this.btnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.Location = new System.Drawing.Point(12, 14);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(80, 50);
            this.btnAbrir.TabIndex = 18;
            this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnRedimensionar
            // 
            this.btnRedimensionar.BackColor = System.Drawing.Color.Transparent;
            this.btnRedimensionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedimensionar.Image = global::Red_Wage.Properties.Resources.editar_imagem;
            this.btnRedimensionar.Location = new System.Drawing.Point(646, 14);
            this.btnRedimensionar.Name = "btnRedimensionar";
            this.btnRedimensionar.Size = new System.Drawing.Size(49, 50);
            this.btnRedimensionar.TabIndex = 19;
            this.btnRedimensionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRedimensionar.UseVisualStyleBackColor = false;
            this.btnRedimensionar.Click += new System.EventHandler(this.btnRedimensionar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Image = global::Red_Wage.Properties.Resources.salvar;
            this.btnSalvar.Location = new System.Drawing.Point(701, 14);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(49, 50);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Red_Wage.Properties.Resources.Fundo_de_Tela_Wage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 709);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnRedimensionar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtDiretorio2);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.lblImagemFinal);
            this.Controls.Add(this.lblImagemOriginal);
            this.Controls.Add(this.lblTamanhoFinal);
            this.Controls.Add(this.lblTamanhoOriginal);
            this.Controls.Add(this.picImagem);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(838, 748);
            this.MinimumSize = new System.Drawing.Size(838, 726);
            this.Name = "Form1";
            this.Text = "Wage Sistemas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblTamanhoOriginal;
        private System.Windows.Forms.Label lblTamanhoFinal;
        private System.Windows.Forms.Label lblImagemOriginal;
        private System.Windows.Forms.Label lblImagemFinal;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.TextBox txtDiretorio2;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnRedimensionar;
        private System.Windows.Forms.Button btnSalvar;
    }
}

