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
    public partial class Form_Cadastro_Curso : MaterialForm
    {
        string cursosFileName = "cursos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;
        public Form_Cadastro_Curso()
        {
            InitializeComponent();
        }

        private void Form_Cadastro_Curso_Load(object sender, EventArgs e)
        {

        }

        private void LimpaCampos()
        {
            foreach (var c in TabCadastro.Controls)
            {
                if (c is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)c).Clear();
                }
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar?\n Seus dados serão perdidos", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                Carrega_Cursos();
                TabControl2.SelectedIndex = 1;
            }
        }

        private void Salva_Curso()
        {
            var line =
                       $"{TextNome.Text};" +
                       $"{TextMatricula.Text};" +
                       $"{ComboNivel.Text};" +
                       $"{ComboPeriodo.Text};" +
                       $"{ComboArea.Text};" +
                       $"{ComboSemestre.Text};";
            if (!isAlteracao)
            {
                var file = new StreamWriter(cursosFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else
            {
                string[] Alunos = File.ReadAllLines(cursosFileName);
                Alunos[indexSelecionado] = line;
                File.WriteAllLines(cursosFileName, Alunos);
            }
            LimpaCampos();
        }

        private bool Valida_Campos()
        {
            if (string.IsNullOrEmpty(TextNome.Text))
            {
                MessageBox.Show("O campo Nome precisa ter um valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(TextMatricula.Text))
            {
                MessageBox.Show("O campo Matrícula precisa ter um valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (Valida_Campos())
            {
                Salva_Curso();
                Carrega_Cursos();
                TabControl2.SelectedIndex = 1;
            }
        }
        private void Carrega_Cursos()
        {
            Cursor.Current = Cursors.WaitCursor;
            LVCursos.Columns.Clear();
            LVCursos.Items.Clear();
            LVCursos.Columns.Add("Nome");
            LVCursos.Columns.Add("Matrícula");
            LVCursos.Columns.Add("Nível");
            LVCursos.Columns.Add("Período");
            LVCursos.Columns.Add("Área");
            LVCursos.Columns.Add("Duração");

            string[] Cursos = File.ReadAllLines(cursosFileName);
            foreach (string curso in Cursos)
            {
                var c = curso.Split(";");
                LVCursos.Items.Add(new ListViewItem(c));
            }
            LVCursos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;
        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControl2.SelectedIndex = 0;
            TextNome.Focus();
        }

        private void TabConsulta_Enter(object sender, EventArgs e)
        {
            LimpaCampos();
            Carrega_Cursos();
            TabControl2.SelectedIndex = 1;
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            if (LVCursos.SelectedIndices.Count > 0)
            {
                indexSelecionado = LVCursos.SelectedItems[0].Index;
                isAlteracao = true;
                TextNome.Text = LVCursos.SelectedItems[0].SubItems[0].Text;
                ComboNivel.Text = LVCursos.SelectedItems[0].SubItems[1].Text;
                ComboPeriodo.Text = LVCursos.SelectedItems[0].SubItems[2].Text;
                ComboArea.Text = LVCursos.SelectedItems[0].SubItems[3].Text;
                ComboSemestre.Text = LVCursos.SelectedItems[0].SubItems[4].Text;
                TextMatricula.Text = LVCursos.SelectedItems[0].SubItems[5].Text;
                TabControl2.SelectedIndex = 0;
            }
        }

        private void LVCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LVCursos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            indexSelecionado = LVCursos.SelectedItems[0].Index;
            isAlteracao = true;
            TextNome.Text = LVCursos.SelectedItems[0].SubItems[0].Text;
            ComboNivel.Text = LVCursos.SelectedItems[0].SubItems[1].Text;
            ComboPeriodo.Text = LVCursos.SelectedItems[0].SubItems[2].Text;
            ComboArea.Text = LVCursos.SelectedItems[0].SubItems[3].Text;
            ComboSemestre.Text = LVCursos.SelectedItems[0].SubItems[4].Text;
            TextMatricula.Text = LVCursos.SelectedItems[0].SubItems[5].Text;
            TabControl2.SelectedIndex = 0;
        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            if (LVCursos.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que quer excluir todos os dados do curso?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    indexSelecionado = LVCursos.SelectedIndices[0];
                    Excluir();
                    Carrega_Cursos();
                }
            }
        }

        private void Excluir()
        {
            List<string> lista = File.ReadAllLines(cursosFileName).ToList();
            lista.RemoveAt(indexSelecionado);
            File.WriteAllLines(cursosFileName, lista);
        }

        private void ComboArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
