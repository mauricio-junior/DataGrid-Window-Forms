﻿using System;
using System.Data;
using System.Windows.Forms;

namespace Conexao_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chama o método para preencher o grid
            preencherGrid();
        }

        private void preencherGrid()
        {
            //instancia a classe DAL e chama o método
            //o resultado do método é o datasource do grid
            ProdutoDAL produtoDAL = new ProdutoDAL();
            DataTable dtTable = produtoDAL.BuscaTodosProdutos().Tables[0];

            dtProduto.DataSource = dtTable;
            lblTotalRegistros.Text = "Total de registros: "+ dtTable.Rows.Count.ToString();

        }
    }
}
