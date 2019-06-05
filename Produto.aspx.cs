using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Produto : System.Web.UI.Page
{
    ProdutoBLL Prod = new ProdutoBLL();

    protected void Page_Load(object sender, EventArgs e)
    {
        carregarCategoria();
        carregarGrid();
    }

    private void carregarCategoria()
    {
        ddlCategoriaProduto.DataSource = Prod.retornarCategoriaProd();
        ddlCategoriaProduto.DataValueField = "id";
        ddlCategoriaProduto.DataTextField = "nome";
        ddlCategoriaProduto.DataBind();

    }

    private void carregarGrid() {
        GridProd.DataSource = Prod.retornarListaProd();
        GridProd.DataBind();
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        Prod.Nome = txtNome.Text;
        Prod.Descricao = txtDesc.Text;
        Prod.Preco_custo = decimal.Parse(txtPC.Text);
        Prod.Preco_venda = decimal.Parse(txtPV.Text);
        Prod.Quantidade = double.Parse(txtQuant.Text);
        Prod.Unidade_medida = txtUn.Text;
        Prod.Categoria_id = int.Parse(ddlCategoriaProduto.SelectedValue.ToString());
        Prod.inserirProduto();
        if (String.IsNullOrEmpty(txtID.Text))
        {
            Prod.inserirProduto();
        }
        else {
            Prod.alterarProduto(txtID.Text);

        }
        limparTela();
        carregarGrid();
    }

    protected void btnCarregar_Click(object sender, EventArgs e)
    {
        DataTable data = Prod.carregarProd(txtID.Text);
        txtNome.Text = data.Rows[0]["nome"].ToString();
        txtDesc.Text = data.Rows[1]["Descrição"].ToString();
        txtPC.Text = data.Rows[2]["Preço custo"].ToString();
        txtPV.Text = data.Rows[3]["Preço venda"].ToString();
        txtQuant.Text = data.Rows[4]["Quantidade"].ToString();
        txtUn.Text = data.Rows[5]["Unidade de medida"].ToString();
        ddlCategoriaProduto.SelectedValue = data.Rows[5]["categoria_id"].ToString();
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        Prod.excluirProduto(txtID.Text);
        carregarGrid();

    }

    protected void btnLimpar_Click(object sender, EventArgs e)
    {
        limparTela();
    }

    private void limparTela() {
        txtID.Text = String.Empty;
        txtNome.Text = String.Empty;
        txtDesc.Text = String.Empty;
        txtPC.Text = String.Empty;
        txtPV.Text = String.Empty;
        txtQuant.Text = String.Empty;
        txtUn.Text = String.Empty;
        
    }
}