using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CelularCTI.Model;
using CelularCTI.Model.Entidades;
using CelularCTI.Model.Suporte;
//using Npgsql;


namespace CelularCTI.Desktop

{
    public partial class frmPrincipal : Form
    {
        private List<Aparelho> aparelhos = new List<Aparelho>();
        private List<Fabricante> fabricantes = new List<Fabricante>();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            fabricantes = Servico.ListarFabricante();
            cmbFabricante.DataSource = fabricantes;
            cmbFabricante.DisplayMember = "Nome"; //Valor (coluna) que será mostrada ao usuário.
            cmbFabricante.ValueMember = "id_fabricante"; //Valor enviado pro sistema uma vez escolhido. 

            aparelhos = Servico.BuscarAparelho("");
            lstCelulares.DataSource = aparelhos;
        }

        private void btn_PesqPreco_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho(num_PrecoMin.Value, num_PrecoMax.Value);
        }

        private void btn_PesquisarFabricante_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho(cmbFabricante.Text);
        }

        private void btn_PesquisarNome_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho(txt_PesqNome.Text);

        }
    }
}
