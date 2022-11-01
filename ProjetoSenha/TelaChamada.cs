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
    public partial class TelaChamada : Form
    {
        public TelaChamada()
        {
            InitializeComponent();
        }
        string tipo;
        int minSenha;
        Conexao conn;
        private void btnchamar_Click(object sender, EventArgs e)
        {
            tipo = "P";
            BuscarSenha();
            if (minSenha == 0)
            {
                tipo = "N";
                BuscarSenha();
                if (minSenha == 0)
                {

                    lbtela.Text = "Aguardando retirada da senha";
                }
                else
                {

                    Atualiza();
                    lbtela.Text = tipo + minSenha;
                }
            }
            else
            {
                Atualiza();
                lbtela.Text = tipo + minSenha;
            }
            
        }
        private void Atualiza()
        {
            string sql = "update tb_senha set atendido=1 where tipo='" + tipo + "' and seq==" + minSenha;
            conn  = new Conexao();
            conn.Conectar();
            conn.ExecSql(sql);
            conn.Desconectar();
      
        }
        private void BuscarSenha()
        {
            string sql = "select min(seq) from tb_senh where tipo='" + tipo + "'and atendido=0";
            conn = new Conexao();
            conn.Conectar();
            int minSenha = Convert.ToInt32(conn.ExecEscalar(sql));
            conn.Desconectar();
        }
    }
}
