using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace Projeto_Cadastro
{
    public partial class Form_Cadastro_Aluno : MaterialForm
    {
        string alunosFileName = "alunos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;
        public Form_Cadastro_Aluno()
        {
            InitializeComponent();
        }

        private void Form_Cadastro_Aluno_Load(object sender, EventArgs e)
        {

        }

        private void tabPageCadastro_Click(object sender, EventArgs e)
        {

        }

        private void ComboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(TextNome.Text))
            {
                MessageBox.Show("Nome inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TextMatricula.Text))
            {
                MessageBox.Show("Matricula inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TextEndereco.Text))
            {
                MessageBox.Show("Endereço inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TextBairro.Text))
            {
                MessageBox.Show("Bairro inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBairro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TextCidade.Text))
            {
                MessageBox.Show("Cidade inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TextSenha.Text))
            {
                MessageBox.Show("Senha inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextSenha.Focus();
                return false;
            }
            if (!DateTime.TryParse(TextDataNasc.Text, out DateTime _))
            {
                MessageBox.Show("Data inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextDataNasc.Focus();
                return false;
            }
            return true;
        }

        private void Salvar()
        {
            var line = $"{TextMatricula.Text};" +
                       $"{TextDataNasc.Text};" +
                       $"{TextNome.Text};" +
                       $"{TextEndereco.Text};" +
                       $"{TextBairro.Text};" +
                       $"{TextCidade.Text};" +
                       $"{ComboEstado.Text};" +
                       $"{TextSenha.Text};";
            if (!isAlteracao)
            {
                var file = new StreamWriter(alunosFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else
            {
                string[] Alunos = File.ReadAllLines(alunosFileName);
                Alunos[indexSelecionado] = line;
                File.WriteAllLines(alunosFileName, Alunos);
            }
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var c in tabPageCadastro.Controls)
            {
                if (c is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)c).Clear();
                }
                if (c is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)c).Clear();
                }
            }
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                CarregaLista();
                TabControl.SelectedIndex = 1;
            }
        }

        private void CarregaLista()
        {
            Cursor.Current = Cursors.WaitCursor;
            MLVAlunos.Columns.Clear();
            MLVAlunos.Items.Clear();
            MLVAlunos.Columns.Add("Matrícula");
            MLVAlunos.Columns.Add("Data de Nascimento");
            MLVAlunos.Columns.Add("Nome");
            MLVAlunos.Columns.Add("Endereço");
            MLVAlunos.Columns.Add("Bairro");
            MLVAlunos.Columns.Add("Cidade");
            MLVAlunos.Columns.Add("UF");


            string[] Alunos = File.ReadAllLines(alunosFileName);
            foreach (string Aluno in Alunos)
            {
                var campos = Aluno.Split(';');
                MLVAlunos.Items.Add(new ListViewItem(campos));
            }
            MLVAlunos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaLista();
        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControl.SelectedIndex = 0;
            TextMatricula.Focus();
        }

        private void Editar()
        {
            if (MLVAlunos.SelectedIndices.Count > 0)
            {
                indexSelecionado = MLVAlunos.SelectedItems[0].Index;
                isAlteracao = true;
                var item = MLVAlunos.SelectedItems[0];
                TextMatricula.Text = item.SubItems[0].Text;
                TextDataNasc.Text = item.SubItems[1].Text;
                TextNome.Text = item.SubItems[2].Text;
                TextEndereco.Text = item.SubItems[3].Text;
                TextBairro.Text = item.SubItems[4].Text;
                TextCidade.Text = item.SubItems[5].Text;
                ComboEstado.Text = item.SubItems[6].Text;
                TextSenha.Text = item.SubItems[7].Text;
                TabControl.SelectedIndex = 0;
                TextMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um Aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas. \r\n" + "Deseja cancelar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControl.SelectedIndex = 1;
            }
        }

        private void Excluir()
        {
            List<string> lista = File.ReadAllLines(alunosFileName).ToList();
            lista.RemoveAt(indexSelecionado);
            File.WriteAllLines(alunosFileName, lista);
        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            if (MLVAlunos.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show(this, "Atenção: Os dados excluídos não podem ser recuperados. \r\n" + "Deseja excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = MLVAlunos.SelectedItems[0].Index;
                    Excluir();
                    CarregaLista();
                }
            }
            else
            {
                MessageBox.Show("Selecione um aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MLVAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MLVAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }
    }
}
