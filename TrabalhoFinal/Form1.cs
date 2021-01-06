using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrabalhoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<FazFuncionar> Cafe { get; set; }

        //string strLinha;
        //string strNS, strID, strPeca, strIDC, strValor, strLucro, strImp;
        public void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instancia OpenFileDialog
            //Abre OFD1 para selecionar arquivo

            OpenFileDialog OFD1 = new OpenFileDialog();
            OFD1.Title = "Abrir Arquivo";
            OFD1.Filter = "Arquivos de texto (.txt) | *.txt";

            if (OFD1.ShowDialog() == DialogResult.OK) {
                using (StreamReader SR = new StreamReader(OFD1.FileName))
                {
                    
                    string linha;

                    Cafe = new List<FazFuncionar>();
                    while ((linha = SR.ReadLine()) != null)
                    {
                        Cafe.Add(new FazFuncionar(linha));
                    }
                    DGV1.DataSource = Cafe;

                }                
            }

        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
                      
            FazFuncionar lista = new FazFuncionar();
            Cafe.Add(lista);
            DGV1.DataSource = (lista.NumeroDeSerie + lista.ID + lista.Peça + lista.IDCategoria + lista.ValorCompra + lista.MargemLucro + lista.Imposto).ToString();
            DGV1.DataSource = Cafe;           
            //var source = new BindingList<FazFuncionar>();
            //DGV1.DataSource = source;        
            //source.Add(new FazFuncionar { NumeroDeSerie = " ", ID = 0, Peca = " ", IDCategoria = 0, ValorCompra = " ", MargemLucro = 0, Imposto = 0 });

            //DGV1.Rows.Add();
            //Inserir InserirForm = new Inserir();

            //InserirForm.Show();        

            //public static void updt()
            //{
            // DGV1.Rows.Clear();
            //DGV1.Columns.Clear();
            // DGV1.DataSource = Cafe;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar(DGV1);
        }
        public void Salvar(DataGridView dgv)
        {
            System.IO.StreamWriter sw = null;
            //Caractere delimitador
            string delimitador = ";";

            //Escolher onde salvar o arquivo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sfd.Filter = "arquivos txt (*.txt)|*.txt";

            //Se usuário escolher nome corretamente e clicar em salvar
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Pega o caminho do arquivo
                    string caminho = sfd.FileName;
                    //Cria um StreamWriter no local
                    sw = new System.IO.StreamWriter(caminho);

                    int qtdColunas = dgv.Columns.Count;
                    //Loop em todas as linhas para escrever na stream já com o delimitador.
                    foreach (DataGridViewRow dgvLinha in dgv.Rows)
                    {
                        string linha = null;
                        for (int i = 0; i < qtdColunas; i++)
                        {
                            linha += dgvLinha.Cells[i].Value.ToString() + delimitador;
                        }
                        sw.WriteLine(linha);
                    }

                    //Mensagem de confirmação
                    MessageBox.Show("Arquivo salvo com sucesso!", "SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão
            if (DialogResult.Yes != MessageBox.Show("Deseja mesmo sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                //Cancelar o evento
                e.Cancel = true;
            }
        }

        public static void addCafe(String txtbox) {

            Cafe.Add(new FazFuncionar(txtbox));
        }
    }
}
