using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class Form1 : Form
    {
        bool x = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn11.Click += new EventHandler(BClick);
            btn12.Click += new EventHandler(BClick);
            btn13.Click += new EventHandler(BClick);
            btn21.Click += new EventHandler(BClick);
            btn22.Click += new EventHandler(BClick);
            btn23.Click += new EventHandler(BClick);
            btn31.Click += new EventHandler(BClick);
            btn32.Click += new EventHandler(BClick);
            btn33.Click += new EventHandler(BClick);

            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.TabStop = false;
                }
            }
        }
        private void BClick(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.x ? "x" : "o";
            ((Button)sender).Enabled = false;
            VerificarGanhador();
            x = !x;
            label1.Text = string.Format("{0}, é a sua vez", this.x ? "x" : "o");
        }
        private void VerificarGanhador()
        {
            if (
                btn11.Text != string.Empty && btn11.Text == btn12.Text && btn12.Text == btn13.Text ||
                btn21.Text != string.Empty && btn21.Text == btn22.Text && btn22.Text == btn23.Text ||
                btn31.Text != string.Empty && btn31.Text == btn32.Text && btn32.Text == btn33.Text ||

                btn11.Text != string.Empty && btn11.Text == btn21.Text && btn21.Text == btn31.Text ||
                btn12.Text != string.Empty && btn12.Text == btn22.Text && btn22.Text == btn32.Text ||
                btn13.Text != string.Empty && btn13.Text == btn23.Text && btn23.Text == btn33.Text ||

                btn11.Text != string.Empty && btn11.Text == btn22.Text && btn22.Text == btn33.Text ||
                btn13.Text != string.Empty && btn13.Text == btn22.Text && btn22.Text == btn31.Text
               )
            {
                MessageBox.Show(string.Format("O ganhador é: {0} ", x ? "x" : "o"), "Temos um vencedor!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reiniciar();
            }
            else
            {
                VerificarEmpate();
            }


        }

        private void VerificarEmpate()
        {
            bool todosDesabilitados = true;

            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Enabled)
                {
                    todosDesabilitados = false;
                    break;
                }
            }
            if (todosDesabilitados)
            {
                MessageBox.Show(string.Format("Deu velha."), "Velhaaa!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Reiniciar();
            }
        }

        private void Reiniciar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                    item.Text = string.Empty;
                }
            }
        }
    }
}



