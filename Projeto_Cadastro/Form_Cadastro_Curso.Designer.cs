namespace Projeto_Cadastro
{
    partial class Form_Cadastro_Curso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cadastro_Curso));
            TabControl2 = new ReaLTaiizor.Controls.MaterialTabControl();
            TabCadastro = new TabPage();
            ButtonSalvar = new ReaLTaiizor.Controls.MaterialButton();
            ButtonCancelar = new ReaLTaiizor.Controls.MaterialButton();
            ComboArea = new ReaLTaiizor.Controls.MaterialComboBox();
            ComboSemestre = new ReaLTaiizor.Controls.MaterialComboBox();
            ComboPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            ComboNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            TextMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TabConsulta = new TabPage();
            ButtonNovo = new ReaLTaiizor.Controls.MaterialButton();
            ButtonEditar = new ReaLTaiizor.Controls.MaterialButton();
            ButtonExcluir = new ReaLTaiizor.Controls.MaterialButton();
            LVCursos = new ListView();
            imageList1 = new ImageList(components);
            TabControl2.SuspendLayout();
            TabCadastro.SuspendLayout();
            TabConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl2
            // 
            TabControl2.Controls.Add(TabCadastro);
            TabControl2.Controls.Add(TabConsulta);
            TabControl2.Depth = 0;
            TabControl2.Dock = DockStyle.Fill;
            TabControl2.ImageList = imageList1;
            TabControl2.Location = new Point(3, 64);
            TabControl2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControl2.Multiline = true;
            TabControl2.Name = "TabControl2";
            TabControl2.RightToLeftLayout = true;
            TabControl2.SelectedIndex = 0;
            TabControl2.Size = new Size(794, 453);
            TabControl2.TabIndex = 0;
            // 
            // TabCadastro
            // 
            TabCadastro.Controls.Add(ButtonSalvar);
            TabCadastro.Controls.Add(ButtonCancelar);
            TabCadastro.Controls.Add(ComboArea);
            TabCadastro.Controls.Add(ComboSemestre);
            TabCadastro.Controls.Add(ComboPeriodo);
            TabCadastro.Controls.Add(ComboNivel);
            TabCadastro.Controls.Add(TextMatricula);
            TabCadastro.Controls.Add(TextNome);
            TabCadastro.ImageKey = "form.png";
            TabCadastro.Location = new Point(4, 55);
            TabCadastro.Name = "TabCadastro";
            TabCadastro.Padding = new Padding(3);
            TabCadastro.Size = new Size(786, 394);
            TabCadastro.TabIndex = 0;
            TabCadastro.Text = "Cadastro";
            TabCadastro.UseVisualStyleBackColor = true;
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSalvar.Depth = 0;
            ButtonSalvar.HighEmphasis = true;
            ButtonSalvar.Icon = null;
            ButtonSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonSalvar.Location = new Point(7, 337);
            ButtonSalvar.Margin = new Padding(4, 6, 4, 6);
            ButtonSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.NoAccentTextColor = Color.Empty;
            ButtonSalvar.Size = new Size(76, 36);
            ButtonSalvar.TabIndex = 7;
            ButtonSalvar.Text = "Salvar";
            ButtonSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSalvar.UseAccentColor = false;
            ButtonSalvar.UseVisualStyleBackColor = true;
            ButtonSalvar.Click += ButtonSalvar_Click;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonCancelar.Depth = 0;
            ButtonCancelar.HighEmphasis = true;
            ButtonCancelar.Icon = null;
            ButtonCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonCancelar.Location = new Point(91, 337);
            ButtonCancelar.Margin = new Padding(4, 6, 4, 6);
            ButtonCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.NoAccentTextColor = Color.Empty;
            ButtonCancelar.Size = new Size(96, 36);
            ButtonCancelar.TabIndex = 6;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonCancelar.UseAccentColor = false;
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ComboArea
            // 
            ComboArea.AutoResize = false;
            ComboArea.BackColor = Color.FromArgb(255, 255, 255);
            ComboArea.Depth = 0;
            ComboArea.DrawMode = DrawMode.OwnerDrawVariable;
            ComboArea.DropDownHeight = 174;
            ComboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboArea.DropDownWidth = 121;
            ComboArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboArea.FormattingEnabled = true;
            ComboArea.Hint = "Área";
            ComboArea.IntegralHeight = false;
            ComboArea.ItemHeight = 43;
            ComboArea.Items.AddRange(new object[] { "Licenciatura", "Informática", "Indústria", "Administração" });
            ComboArea.Location = new Point(6, 224);
            ComboArea.MaxDropDownItems = 4;
            ComboArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboArea.Name = "ComboArea";
            ComboArea.Size = new Size(774, 49);
            ComboArea.StartIndex = 0;
            ComboArea.TabIndex = 4;
            ComboArea.SelectedIndexChanged += ComboArea_SelectedIndexChanged;
            // 
            // ComboSemestre
            // 
            ComboSemestre.AutoResize = false;
            ComboSemestre.BackColor = Color.FromArgb(255, 255, 255);
            ComboSemestre.Depth = 0;
            ComboSemestre.DrawMode = DrawMode.OwnerDrawVariable;
            ComboSemestre.DropDownHeight = 174;
            ComboSemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboSemestre.DropDownWidth = 121;
            ComboSemestre.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboSemestre.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboSemestre.FormattingEnabled = true;
            ComboSemestre.Hint = "Duração";
            ComboSemestre.IntegralHeight = false;
            ComboSemestre.ItemHeight = 43;
            ComboSemestre.Items.AddRange(new object[] { "2 Semestres", "4 Semestres", "6 Semestres", "8 Semestres", "10 Semestres", "12 Semestres", "" });
            ComboSemestre.Location = new Point(6, 279);
            ComboSemestre.MaxDropDownItems = 4;
            ComboSemestre.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboSemestre.Name = "ComboSemestre";
            ComboSemestre.Size = new Size(774, 49);
            ComboSemestre.StartIndex = 0;
            ComboSemestre.TabIndex = 5;
            // 
            // ComboPeriodo
            // 
            ComboPeriodo.AutoResize = false;
            ComboPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            ComboPeriodo.Depth = 0;
            ComboPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            ComboPeriodo.DropDownHeight = 174;
            ComboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboPeriodo.DropDownWidth = 121;
            ComboPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboPeriodo.FormattingEnabled = true;
            ComboPeriodo.Hint = "Período";
            ComboPeriodo.IntegralHeight = false;
            ComboPeriodo.ItemHeight = 43;
            ComboPeriodo.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno", "Integral" });
            ComboPeriodo.Location = new Point(7, 169);
            ComboPeriodo.MaxDropDownItems = 4;
            ComboPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboPeriodo.Name = "ComboPeriodo";
            ComboPeriodo.Size = new Size(774, 49);
            ComboPeriodo.StartIndex = 0;
            ComboPeriodo.TabIndex = 3;
            // 
            // ComboNivel
            // 
            ComboNivel.AutoResize = false;
            ComboNivel.BackColor = Color.FromArgb(255, 255, 255);
            ComboNivel.Depth = 0;
            ComboNivel.DrawMode = DrawMode.OwnerDrawVariable;
            ComboNivel.DropDownHeight = 174;
            ComboNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboNivel.DropDownWidth = 121;
            ComboNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboNivel.FormattingEnabled = true;
            ComboNivel.Hint = "Nível";
            ComboNivel.IntegralHeight = false;
            ComboNivel.ItemHeight = 43;
            ComboNivel.Items.AddRange(new object[] { "Técnico", "Superior" });
            ComboNivel.Location = new Point(6, 114);
            ComboNivel.MaxDropDownItems = 4;
            ComboNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboNivel.Name = "ComboNivel";
            ComboNivel.Size = new Size(774, 49);
            ComboNivel.StartIndex = 0;
            ComboNivel.TabIndex = 2;
            // 
            // TextMatricula
            // 
            TextMatricula.AnimateReadOnly = false;
            TextMatricula.AutoCompleteMode = AutoCompleteMode.None;
            TextMatricula.AutoCompleteSource = AutoCompleteSource.None;
            TextMatricula.BackgroundImageLayout = ImageLayout.None;
            TextMatricula.CharacterCasing = CharacterCasing.Normal;
            TextMatricula.Depth = 0;
            TextMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextMatricula.HideSelection = true;
            TextMatricula.Hint = "Matrícula";
            TextMatricula.LeadingIcon = null;
            TextMatricula.Location = new Point(6, 60);
            TextMatricula.MaxLength = 32767;
            TextMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextMatricula.Name = "TextMatricula";
            TextMatricula.PasswordChar = '\0';
            TextMatricula.PrefixSuffixText = null;
            TextMatricula.ReadOnly = false;
            TextMatricula.RightToLeft = RightToLeft.No;
            TextMatricula.SelectedText = "";
            TextMatricula.SelectionLength = 0;
            TextMatricula.SelectionStart = 0;
            TextMatricula.ShortcutsEnabled = true;
            TextMatricula.Size = new Size(774, 48);
            TextMatricula.TabIndex = 1;
            TextMatricula.TabStop = false;
            TextMatricula.TextAlign = HorizontalAlignment.Left;
            TextMatricula.TrailingIcon = null;
            TextMatricula.UseSystemPasswordChar = false;
            // 
            // TextNome
            // 
            TextNome.AllowDrop = true;
            TextNome.AnimateReadOnly = false;
            TextNome.AutoCompleteMode = AutoCompleteMode.None;
            TextNome.AutoCompleteSource = AutoCompleteSource.None;
            TextNome.BackgroundImageLayout = ImageLayout.None;
            TextNome.CharacterCasing = CharacterCasing.Normal;
            TextNome.Depth = 0;
            TextNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextNome.HideSelection = true;
            TextNome.Hint = "Nome";
            TextNome.LeadingIcon = null;
            TextNome.Location = new Point(6, 6);
            TextNome.MaxLength = 32767;
            TextNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextNome.Name = "TextNome";
            TextNome.PasswordChar = '\0';
            TextNome.PrefixSuffixText = null;
            TextNome.ReadOnly = false;
            TextNome.RightToLeft = RightToLeft.No;
            TextNome.SelectedText = "";
            TextNome.SelectionLength = 0;
            TextNome.SelectionStart = 0;
            TextNome.ShortcutsEnabled = true;
            TextNome.Size = new Size(774, 48);
            TextNome.TabIndex = 0;
            TextNome.TabStop = false;
            TextNome.TextAlign = HorizontalAlignment.Left;
            TextNome.TrailingIcon = null;
            TextNome.UseSystemPasswordChar = false;
            // 
            // TabConsulta
            // 
            TabConsulta.Controls.Add(ButtonNovo);
            TabConsulta.Controls.Add(ButtonEditar);
            TabConsulta.Controls.Add(ButtonExcluir);
            TabConsulta.Controls.Add(LVCursos);
            TabConsulta.ImageKey = "search.png";
            TabConsulta.Location = new Point(4, 55);
            TabConsulta.Name = "TabConsulta";
            TabConsulta.Padding = new Padding(3);
            TabConsulta.Size = new Size(786, 394);
            TabConsulta.TabIndex = 1;
            TabConsulta.Text = "Consulta";
            TabConsulta.UseVisualStyleBackColor = true;
            TabConsulta.Enter += TabConsulta_Enter;
            // 
            // ButtonNovo
            // 
            ButtonNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonNovo.Depth = 0;
            ButtonNovo.HighEmphasis = true;
            ButtonNovo.Icon = null;
            ButtonNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonNovo.Location = new Point(4, 352);
            ButtonNovo.Margin = new Padding(4, 6, 4, 6);
            ButtonNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonNovo.Name = "ButtonNovo";
            ButtonNovo.NoAccentTextColor = Color.Empty;
            ButtonNovo.Size = new Size(64, 36);
            ButtonNovo.TabIndex = 3;
            ButtonNovo.Text = "Novo";
            ButtonNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonNovo.UseAccentColor = false;
            ButtonNovo.UseVisualStyleBackColor = true;
            ButtonNovo.Click += ButtonNovo_Click;
            // 
            // ButtonEditar
            // 
            ButtonEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonEditar.Depth = 0;
            ButtonEditar.HighEmphasis = true;
            ButtonEditar.Icon = null;
            ButtonEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonEditar.Location = new Point(76, 352);
            ButtonEditar.Margin = new Padding(4, 6, 4, 6);
            ButtonEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.NoAccentTextColor = Color.Empty;
            ButtonEditar.Size = new Size(71, 36);
            ButtonEditar.TabIndex = 2;
            ButtonEditar.Text = "Editar";
            ButtonEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonEditar.UseAccentColor = false;
            ButtonEditar.UseVisualStyleBackColor = true;
            ButtonEditar.Click += ButtonEditar_Click;
            // 
            // ButtonExcluir
            // 
            ButtonExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonExcluir.Depth = 0;
            ButtonExcluir.HighEmphasis = true;
            ButtonExcluir.Icon = null;
            ButtonExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonExcluir.Location = new Point(155, 352);
            ButtonExcluir.Margin = new Padding(4, 6, 4, 6);
            ButtonExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonExcluir.Name = "ButtonExcluir";
            ButtonExcluir.NoAccentTextColor = Color.Empty;
            ButtonExcluir.Size = new Size(80, 36);
            ButtonExcluir.TabIndex = 1;
            ButtonExcluir.Text = "Excluir";
            ButtonExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonExcluir.UseAccentColor = false;
            ButtonExcluir.UseVisualStyleBackColor = true;
            ButtonExcluir.Click += ButtonExcluir_Click;
            // 
            // LVCursos
            // 
            LVCursos.Location = new Point(0, 0);
            LVCursos.Name = "LVCursos";
            LVCursos.Size = new Size(790, 347);
            LVCursos.TabIndex = 0;
            LVCursos.UseCompatibleStateImageBehavior = false;
            LVCursos.View = View.Details;
            LVCursos.SelectedIndexChanged += LVCursos_SelectedIndexChanged;
            LVCursos.MouseDoubleClick += LVCursos_MouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // Form_Cadastro_Curso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(TabControl2);
            DrawerTabControl = TabControl2;
            Name = "Form_Cadastro_Curso";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Curso - IFSP Birigui";
            Load += Form_Cadastro_Curso_Load;
            TabControl2.ResumeLayout(false);
            TabCadastro.ResumeLayout(false);
            TabCadastro.PerformLayout();
            TabConsulta.ResumeLayout(false);
            TabConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControl2;
        private TabPage TabCadastro;
        private TabPage TabConsulta;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialComboBox ComboArea;
        private ReaLTaiizor.Controls.MaterialComboBox ComboSemestre;
        private ReaLTaiizor.Controls.MaterialComboBox ComboPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox ComboNivel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextMatricula;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextNome;
        private ReaLTaiizor.Controls.MaterialButton ButtonSalvar;
        private ReaLTaiizor.Controls.MaterialButton ButtonCancelar;
        private ReaLTaiizor.Controls.MaterialButton ButtonNovo;
        private ReaLTaiizor.Controls.MaterialButton ButtonEditar;
        private ReaLTaiizor.Controls.MaterialButton ButtonExcluir;
        private ListView LVCursos;
    }
}