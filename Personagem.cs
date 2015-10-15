using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootAndAim
{
    public class Personagem
    {
        public static int VIVO = 0;
        public static int MORTO = 1;
        public static int DEFENDENDO = 2;

        private int estado;

        public int Estado { get{return this.estado;} }

        private Personagem[] vizinhos;

        public delegate void AtualizaLabelVida();
        private AtualizaLabelVida atualizarLabelVida;

        public void SetAtualizaLabelVida(AtualizaLabelVida atualizar)
        {
            this.atualizarLabelVida = atualizar;
        }

        public delegate void AtualizaLabelEstado();
        private AtualizaLabelEstado atualizarLabelEstado;

        public void SetAtualizaLabelEstado(AtualizaLabelEstado atualizar)
        {
            this.atualizarLabelEstado = atualizar;
        }

        private int vida;

        public int Vida
        {
            get { return vida; }
        }

        public Personagem()
        {
            this.vizinhos = new Personagem[3];
            this.vida = 5;
            this.estado = VIVO;
        }

        public void SetVizinho(int pos, Personagem p)
        {
            vizinhos[pos] = p;
        }

        public void EnviarDano()
        {
            if (estado != MORTO)
            {
                foreach (Personagem vizinho in vizinhos)
                {
                    vizinho.ReceberDano();
                }   
            }
        }

        private void ReceberDano()
        {
            if (estado == VIVO)
            {
                vida--;
                atualizarLabelVida();
            }
            else
            {
                if (estado == DEFENDENDO)
                {
                    estado = VIVO;
                }
            }

            AtualizarEstado();
        }

        public void AtualizarEstado()
        {
            if (vida == 0 && estado != MORTO)
            {
                estado = MORTO;
                EnviarDano();
            }

            atualizarLabelEstado();
        }

        public void Defender()
        {
            if (estado != MORTO)
            {
                estado ^= 2;
            }
            
            AtualizarEstado();
        }
    }
}
