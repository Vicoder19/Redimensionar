using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red_Wage
{
    public partial class Form1 : Form
    {
        int larguraFinal;
        int alturaFinal;
        int larguraOriginal;
        int alturaOriginal;
        Image Redimensionar(Image img)
        {
            int larguraOriginal = img.Width;
            int alturaOriginal = img.Height;
            if (larguraOriginal >= 800 && alturaOriginal >= 480)
            {
                larguraFinal = 812;
                alturaFinal = 480;
            }
            else 
            if(larguraOriginal < 800 && larguraOriginal > 406 && alturaOriginal < 480 && alturaOriginal > 240)
            {
                larguraFinal = 609;
                alturaFinal = 360;
            }
            else{
                larguraFinal = 406;
                alturaFinal = 240;
            }
            Bitmap bmImagem = new Bitmap(larguraFinal, alturaFinal, PixelFormat.Format24bppRgb);
            bmImagem.SetResolution(img.HorizontalResolution, img.VerticalResolution);
            Graphics gerarImagem = Graphics.FromImage(bmImagem);
            gerarImagem.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gerarImagem.DrawImage(img, new Rectangle(0, 0, larguraFinal, alturaFinal), new Rectangle(0, 0, larguraOriginal, alturaOriginal), GraphicsUnit.Pixel);
            gerarImagem.Dispose();
            return bmImagem;
        }
        public void RegistraLog(Exception ex)
        {
            Directory.CreateDirectory(@"C:\Imagens");
            string caminhoLog = @"C:\Imagens\log.txt";
            if (!File.Exists(caminhoLog))
            {
                FileStream log = File.Create(caminhoLog);
                log.Close();
            }                        
            using (StreamWriter w = File.AppendText(caminhoLog))
            {
                w.Write(DateTime.Now.ToString()+": ");
                w.WriteLine(ex.Message);
            }           
        }

        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnRedimensionar.Enabled = false;
        }

        public void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagem = new OpenFileDialog();
            abrirImagem.DefaultExt = "jpg";
            abrirImagem.Filter = "jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg";
            DialogResult resultado = abrirImagem.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                picImagem.Load(abrirImagem.FileName);
                txtDiretorio.Text = abrirImagem.FileName;
                larguraOriginal = picImagem.Image.Width;
                alturaOriginal = picImagem.Image.Height;
                string resolucaoOriginal = larguraOriginal + " x " + alturaOriginal;
                lblTamanhoOriginal.Text = "Tamanho Original: " + resolucaoOriginal;
                btnSalvar.Enabled = true;
                btnRedimensionar.Enabled = true;
                lblTamanhoFinal.Text = "Tamanho Final: ";
            }
        }
        public void btnRedimensionar_Click(object sender, EventArgs e)
        {
            Image imagemFinal = Redimensionar(picImagem.Image);
            picImagem.Image = imagemFinal;
            larguraFinal = imagemFinal.Width;
            alturaFinal = imagemFinal.Height;
            lblTamanhoFinal.Text = "Tamanho Final: " + larguraFinal + " X " + alturaFinal;
            picImagem.BackColor = Color.White;
            
        }
        public void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "jpg files (*.jpg)|*.jpg";
            salvar.DefaultExt = ".jpeg";
            DialogResult resultado = salvar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                try
                {                    
                    string nomeArquivo = salvar.FileName;
                    txtDiretorio2.Text = nomeArquivo;
                    Bitmap imgImagem = new Bitmap(picImagem.Image, larguraFinal, alturaFinal);
                    imgImagem.Save(nomeArquivo, ImageFormat.Jpeg);
                    
                }
                catch (Exception ex)
                {
                    RegistraLog(ex);
                    MessageBox.Show("Erro ao salvar. Verifique com o Suporte", "Erro ao Salvar", MessageBoxButtons.OK,MessageBoxIcon.Error);                    
                }
            }
            lblTamanhoOriginal.Text = "Tamanho Original: ";
            lblTamanhoFinal.Text = "Tamanho Final: ";
        }
    }
}