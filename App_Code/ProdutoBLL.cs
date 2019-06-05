using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

using MySql.Data.MySqlClient;


/// <summary>
/// Summary description for ProdutoBLL
/// </summary>
public class ProdutoBLL
{
    DAL objDal = new DAL();
    public string Nome{ get; set; }
    public string Descricao { get; set; }
    public decimal Preco_custo { get; set; }
    public double Quantidade { get; set; }
    public decimal Preco_venda { get; set; }
    public string Unidade_medida { get; set; }
    public int Categoria_id { get; set; }
    
    public DataTable retornarCategoriaProd() {
    
        return objDal.RetDataTable("select * from categoria");
    }

    public DataTable retornarListaProd()
    {
        return objDal.RetDataTable("select * from produtos");
    }

    public void inserirProduto() {
        string sql = "insert into produto(nome, descricao, preco_custo, preco_venda, quantidade, unidade_medida,categoria_id)" +
           "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')" ;
        sql = String.Format(sql, Nome, Descricao, Preco_custo, Preco_venda, Quantidade, Unidade_medida, Categoria_id);
        objDal.ExecutarComandoSql(sql);
    }

    public DataTable carregarProd(string id){

        return objDal.RetDataTable("select * from produtos where id = " + id);

    }

    public void alterarProduto(string id) {
        string sql = "update produto set nome='{0}'descricao='{1}',preco_venda='{2}',"+
            "preco_custo='{3}',quantidade='{4}',unidade_medida='{5}',categoria_id='{6}' where id = '{0}'";
        sql = String.Format(sql, Nome, Descricao, Preco_custo, Preco_venda, Quantidade, Unidade_medida, Categoria_id, id);
        objDal.ExecutarComandoSql(sql);
    }

    public void excluirProduto(string id)
    {
        string sql = string.Format("delete from produto where id = '{0}'",id);
        objDal.ExecutarComandoSql(sql);
    }

}