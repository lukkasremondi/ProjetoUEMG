using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class Inserir : Form
    {
        public FazFuncionar novocadastro { get; set; }
        public Inserir()
        {
            InitializeComponent();
            novocadastro = null;
        }

        private void Inserir_Load(object sender, EventArgs e)
        {

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        public void salvarButton_Click(object sender, EventArgs e)
        {
            
            //String txtbox = numeroTxtBox.Text + ";" + idTxtBox.Text + ";" + nomeTxtBox.Text + ";" + idcTxtBox.Text + ";" + valorTxtBox.Text + ";" + lucroTxtBox.Text + ";" + impostoTxtBox.Text ;
            //Form1.addCafe(txtbox);
          

            if (DialogResult.Yes != MessageBox.Show("Informação inserida com sucesso! Deseja inserir mais um item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                //Cancelar o evento
                Close();
            }    
            limparTextBoxes(this.Controls);
            

        }
        private void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        private void idTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void idcTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void valorTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número nem backspace e nem virgula
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void lucroTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, nem backspace e nem virgula
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void impostoTxtBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, nem backspace e nem virgula
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
