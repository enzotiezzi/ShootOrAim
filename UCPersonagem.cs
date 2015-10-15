using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootAndAim
{
    public partial class UCPersonagem : UserControl
    {
        private Personagem p;

        public UCPersonagem(Personagem p)
        {
            this.p = p;

            this.p.SetAtualizaLabelVida(AtualizaLabelVida);
            this.p.SetAtualizaLabelEstado(AtualizaLabelEstado);

            InitializeComponent();

            this.p.AtualizarEstado();
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            this.p.EnviarDano();
        }

        private void btnDefender_Click(object sender, EventArgs e)
        {
            p.Defender();
        }

        private void AtualizaLabelVida()
        {
            lblNumVidas.Text = p.Vida.ToString();
        }

        private void AtualizaLabelEstado()
        {
            string estados = string.Empty;

            if (p.Estado == Personagem.DEFENDENDO)
            {
                estados = "DEFENDENDO";
            }
            else
            {
                if (p.Estado == Personagem.MORTO)
                {
                    estados = "MORTO";
                }
                else
                {
                    estados = "VIVO";
                }
            }

            lblEstado.Text = estados;
        }
    }
}
