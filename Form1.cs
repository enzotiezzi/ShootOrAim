using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootAndAim
{
    public partial class Form1 : Form
    {
        private Personagem p1;
        private Personagem p2;
        private Personagem p3;
        private Personagem p4;

        public Form1()
        {
            p1 = new Personagem();
            p2 = new Personagem();
            p3 = new Personagem();
            p4 = new Personagem();

            p1.SetVizinho(0, p2);
            p1.SetVizinho(1, p3);
            p1.SetVizinho(2, p4);

            p2.SetVizinho(0, p1);
            p2.SetVizinho(1, p3);
            p2.SetVizinho(2, p4);

            p3.SetVizinho(0, p1);
            p3.SetVizinho(1, p2);
            p3.SetVizinho(2, p4);

            p4.SetVizinho(0, p1);
            p4.SetVizinho(1, p2);
            p4.SetVizinho(2, p3);

            ucPersonagem1 = new UCPersonagem(p1);
            ucPersonagem2 = new UCPersonagem(p2);
            ucPersonagem3 = new UCPersonagem(p3);
            ucPersonagem4 = new UCPersonagem(p4);

            InitializeComponent();
        }
    }
}
