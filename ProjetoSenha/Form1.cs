using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSenha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string tipo;
        int seq;
        Conexao conexao;
        private void btnNormal_Click(object sender, EventArgs e)
        {
            tipo = "N";
            PegaSenha();
            GravaSenha();
            lbSenha.Text = tipo + seq;
        }

        private void btnPreferencial_Click(object sender, EventArgs e)
        {
            tipo = "P";
            PegaSenha();
            GravaSenha();
            lbSenha.Text = tipo + seq;
        }
        private void GravaSenha()
        {
            string sql="insert into tb_senha values("+seq+",'"+tipo+"',now(),0)";
            conexao = new Conexao();
            conexao.Conectar();
            conexao.ExecSql(sql);
            conexao.Desconectar();
        }
        private void PegaSenha()
        {
            string sql= "select max(seq) from tb_senha where tipo='"+tipo+"'";
            conexao = new Conexao();
            conexao.Conectar();
            int maxsenha = Convert.ToInt32(conexao.ExecEscalar(sql));
            if(maxsenha > 0)
            {
                seq = maxsenha + 1;
            }
            else
            {
                seq = 1;
            }
            conexao.Desconectar();
        }
    }
}
