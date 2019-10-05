using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilhaEstaticaVisual
{
    public partial class Form1 : Form
    {
        // Projeto de Gabriel Gregório da Silva.
        // github: https://github.com/gabrielogregorio

        string link_img_cor = "roxo.png";
        
        HPilha Cores;

        public Form1()
        {
            Cores = new HPilha(6);
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            titulo.ForeColor = Color.FromArgb(255, 112, 48, 160);
        }

        private void pic_paleta_roxa_Click(object sender, EventArgs e)
        {
            link_img_cor = "roxo.png";
            titulo.ForeColor = Color.FromArgb(255, 112, 48, 160);
        }

        private void pic_paleta_azul_forte_Click(object sender, EventArgs e)
        {
            link_img_cor = "azul_forte.png";
            titulo.ForeColor = Color.FromArgb(255, 0, 32, 96);
        }

        private void pic_paleta_azul_medio_Click(object sender, EventArgs e)
        {
            link_img_cor = "azul_medio.png";
            titulo.ForeColor = Color.FromArgb(255, 0, 112, 192);
        }

        private void pic_paleta_azul_fraco_Click(object sender, EventArgs e)
        {
            link_img_cor = "azul_fraco.png";
            titulo.ForeColor = Color.FromArgb(255, 0, 176, 240);
        }

        private void pic_paleta_verde_medio_Click(object sender, EventArgs e)
        {
            link_img_cor = "verde_medio.png";
            titulo.ForeColor = Color.FromArgb(255, 0, 176, 80);
        }

        private void pic_paleta_verde_fraco_Click(object sender, EventArgs e)
        {
            link_img_cor = "verde_fraco.png";
            titulo.ForeColor = Color.FromArgb(255, 104, 208, 80);
        }

        private void pic_paleta_amarelo_Click(object sender, EventArgs e)
        {
            link_img_cor = "amarelo.png";
            titulo.ForeColor = Color.FromArgb(255, 255, 255, 0);
        }

        private void pic_paleta_laranja_Click(object sender, EventArgs e)
        {
            link_img_cor = "laranja.png";
            titulo.ForeColor = Color.FromArgb(255, 255, 192, 0);
        }

        private void pic_paleta_vermelho_Click(object sender, EventArgs e)
        {
            link_img_cor = "vermelho.png";
            titulo.ForeColor = Color.FromArgb(255, 255, 0, 0);
        }

        private void pic_paleta_preto_Click(object sender, EventArgs e)
        {
            link_img_cor = "preto.png";
            titulo.ForeColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void pic_paleta_escuro_Click(object sender, EventArgs e)
        {
            link_img_cor = "escuro.png";
            titulo.ForeColor = Color.FromArgb(255, 34, 42, 53);
        }

        private void pic_paleta_cinza_Click(object sender, EventArgs e)
        {
            link_img_cor = "cinza.png";
            titulo.ForeColor = Color.FromArgb(255, 127, 127, 127);
        }

        public void pic_btn_adicionar_Click(object sender, EventArgs e)
        {
            Atualiza_Pilhas(Cores.Inserir(link_img_cor));
            lbl_valor_atual.Text = Cores.RetornaTopo().ToString();
            lbl_topo.Text = "Topo = " + Cores.RetornaTopo().ToString();
        }

        public void Atualiza_Pilhas(string[] vetor)
        {
            int topo = Cores.RetornaTopo();
            for (int i = 0; i < vetor.Length; i++)
            {
                if ((vetor[i] == "") || (vetor[i] == "vazia.png") || (vetor[i] == null) || (i > topo))
                {
                    Vetor_Em_Analise(i, Define_Imagem("vazia.png"));
                }
                else
                {
                    Vetor_Em_Analise(i, Define_Imagem(vetor[i]));
                }
            }

            if (Cores.Cheio() == false) // parece estranho né? Vou Atualizar...
            {
                lbl_status.Text = "Status = Pilha Cheia";
            }
            else if (Cores.RetornaTopo() == -1)
            {
                lbl_status.Text = "Status = Pilha Vazia";
            }
            else
            {
                lbl_status.Text = "Status = Normal";
            }
        }

        private Image Define_Imagem(String link)
        {
            Image img = Image.FromFile("imagens/pilhas/" + link);
            return img;
        }

        public void Vetor_Em_Analise(int i, Image nova)
        {
            if (i == 0)
            {
                pic_1.Image = nova;
            }
            else if (i == 1)
            {
                pic_2.Image = nova;
            }
            else if (i == 2)
            {
                pic_3.Image = nova;
            }
            else if (i == 3)
            {
                pic_4.Image = nova;
            }
            else if (i == 4)
            {
                pic_5.Image = nova;
            }
            else if (i == 5)
            {
                pic_6.Image = nova;
            }

        }

        private void pic_btn_excluir_Click(object sender, EventArgs e)
        {
            Atualiza_Pilhas(Cores.Excluir());
            lbl_valor_atual.Text = Cores.RetornaTopo().ToString();
            lbl_topo.Text = "Topo = " + Cores.RetornaTopo().ToString();
        }

        private void pic_atual_Click(object sender, EventArgs e)
        {

        }
    }
}
