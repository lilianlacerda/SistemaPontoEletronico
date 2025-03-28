using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPontoEletronico.Views;

namespace SistemaPontoEletronico
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBoxLogin.Text) || !String.IsNullOrEmpty(textBoxSenha.Text))
            {
                if (textBoxLogin.Text == "admin" && textBoxSenha.Text == "1234")
                {
                    MessageBox.Show("Login efetuado com sucesso!", "Login Aprovado!");
                    this.Hide();
                    new TelaRegistroPonto().Show();
                }
                else
                {
                    MessageBox.Show("Login ou senha Incorretos!", "Erro de Login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você precisa preencher todos os campos para acessar", "Campos Vazios!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
