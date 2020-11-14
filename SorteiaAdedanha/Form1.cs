using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SorteiaAdedanha
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private List<int> numerosSorteados { get; set; } = new List<int>();

        private void btnSorteio_Click(object sender, System.EventArgs e)
        {
            AnimarSorteio();

            var numeroAleatorio = GeraNumeroAleatorio();

            AtualizaInterface(numeroAleatorio);
        }

        private void AnimarSorteio()
        {
            spinner.Visible = true;
            Application.DoEvents();
            Thread.Sleep(3000);
            spinner.Visible = false;
        }

        private void AtualizaInterface(int numeroAleatorio)
        {
            numerosSorteados.Add(numeroAleatorio);

            var letraSorteada = (char)numeroAleatorio;

            lblLetraSorteada.Text = letraSorteada.ToString();
            lstSorteados.Items.Add(letraSorteada);
            lstSorteados.SelectedIndex = numerosSorteados.Count - 1;

            if (lstSorteados.Items.Count == 26)
            {
                btnSorteio.Enabled = false;
            }
        }

        private int GeraNumeroAleatorio()
        {
            var gerador = new Random();
            var numeroAleatorio = 0;

            do
            {
                numeroAleatorio = gerador.Next(65, 91);

            } while (numerosSorteados.Contains(numeroAleatorio));
            
            return numeroAleatorio;
        }
    }
}
