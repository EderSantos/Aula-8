﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoDesktop
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            InserirCliente formInserirCliente = new InserirCliente();
            formInserirCliente.MdiParent = this.MdiParent;
            formInserirCliente.Show();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Manutenção!");
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Manutenção!");
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Manutenção!");
            
        }
    }
}
