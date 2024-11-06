using ReaLTaiizor.Forms;

namespace Projeto_Cadastro
{
    public partial class Form_Principal : MaterialForm
    {
        public Form_Principal()
        {
            InitializeComponent();
        }
        private void Form_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cadastro_Aluno formAluno = new Form_Cadastro_Aluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cadastro_Curso formCurso = new Form_Cadastro_Curso();
            formCurso.MdiParent = this;
            formCurso.Show();
        }
    }
}