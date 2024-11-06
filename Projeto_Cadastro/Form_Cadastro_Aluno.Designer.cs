namespace Projeto_Cadastro
{
    partial class Form_Cadastro_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cadastro_Aluno));
            TabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            ButtonSalvar = new ReaLTaiizor.Controls.MaterialButton();
            ButtonCancelar = new ReaLTaiizor.Controls.MaterialButton();
            TextSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ComboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            TextDataNasc = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            TextMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            MLVAlunos = new ListView();
            ButtonExcluir = new ReaLTaiizor.Controls.MaterialButton();
            ButtonEditar = new ReaLTaiizor.Controls.MaterialButton();
            ButtonNovo = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            TabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPageCadastro);
            TabControl.Controls.Add(tabPageConsulta);
            TabControl.Depth = 0;
            TabControl.Dock = DockStyle.Fill;
            TabControl.ImageList = imageList1;
            TabControl.Location = new Point(3, 64);
            TabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControl.Multiline = true;
            TabControl.Name = "TabControl";
            TabControl.RightToLeftLayout = true;
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(794, 453);
            TabControl.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(ButtonSalvar);
            tabPageCadastro.Controls.Add(ButtonCancelar);
            tabPageCadastro.Controls.Add(TextSenha);
            tabPageCadastro.Controls.Add(TextCidade);
            tabPageCadastro.Controls.Add(TextBairro);
            tabPageCadastro.Controls.Add(TextEndereco);
            tabPageCadastro.Controls.Add(TextNome);
            tabPageCadastro.Controls.Add(ComboEstado);
            tabPageCadastro.Controls.Add(TextDataNasc);
            tabPageCadastro.Controls.Add(TextMatricula);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.ImeMode = ImeMode.NoControl;
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(786, 418);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            tabPageCadastro.Click += tabPageCadastro_Click;
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSalvar.Depth = 0;
            ButtonSalvar.Dock = DockStyle.Bottom;
            ButtonSalvar.HighEmphasis = true;
            ButtonSalvar.Icon = null;
            ButtonSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonSalvar.Location = new Point(3, 343);
            ButtonSalvar.Margin = new Padding(4, 6, 4, 6);
            ButtonSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.NoAccentTextColor = Color.Empty;
            ButtonSalvar.Size = new Size(780, 36);
            ButtonSalvar.TabIndex = 9;
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
            ButtonCancelar.Dock = DockStyle.Bottom;
            ButtonCancelar.HighEmphasis = true;
            ButtonCancelar.Icon = null;
            ButtonCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonCancelar.Location = new Point(3, 379);
            ButtonCancelar.Margin = new Padding(4, 6, 4, 6);
            ButtonCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.NoAccentTextColor = Color.Empty;
            ButtonCancelar.Size = new Size(780, 36);
            ButtonCancelar.TabIndex = 8;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonCancelar.UseAccentColor = false;
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // TextSenha
            // 
            TextSenha.AnimateReadOnly = false;
            TextSenha.AutoCompleteMode = AutoCompleteMode.None;
            TextSenha.AutoCompleteSource = AutoCompleteSource.None;
            TextSenha.BackgroundImageLayout = ImageLayout.None;
            TextSenha.CharacterCasing = CharacterCasing.Normal;
            TextSenha.Depth = 0;
            TextSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextSenha.HideSelection = true;
            TextSenha.Hint = "Senha";
            TextSenha.LeadingIcon = Properties.Resources.baseline_fingerprint_black_24dp;
            TextSenha.Location = new Point(6, 277);
            TextSenha.MaxLength = 32767;
            TextSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextSenha.Name = "TextSenha";
            TextSenha.PasswordChar = 'ඞ';
            TextSenha.PrefixSuffixText = null;
            TextSenha.ReadOnly = false;
            TextSenha.RightToLeft = RightToLeft.No;
            TextSenha.SelectedText = "";
            TextSenha.SelectionLength = 0;
            TextSenha.SelectionStart = 0;
            TextSenha.ShortcutsEnabled = true;
            TextSenha.Size = new Size(774, 48);
            TextSenha.TabIndex = 7;
            TextSenha.TabStop = false;
            TextSenha.TextAlign = HorizontalAlignment.Left;
            TextSenha.TrailingIcon = null;
            TextSenha.UseSystemPasswordChar = false;
            // 
            // TextCidade
            // 
            TextCidade.AnimateReadOnly = false;
            TextCidade.AutoCompleteMode = AutoCompleteMode.None;
            TextCidade.AutoCompleteSource = AutoCompleteSource.None;
            TextCidade.BackgroundImageLayout = ImageLayout.None;
            TextCidade.CharacterCasing = CharacterCasing.Normal;
            TextCidade.Depth = 0;
            TextCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextCidade.HideSelection = true;
            TextCidade.Hint = "Cidade";
            TextCidade.LeadingIcon = null;
            TextCidade.Location = new Point(6, 223);
            TextCidade.MaxLength = 32767;
            TextCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCidade.Name = "TextCidade";
            TextCidade.PasswordChar = '\0';
            TextCidade.PrefixSuffixText = null;
            TextCidade.ReadOnly = false;
            TextCidade.RightToLeft = RightToLeft.No;
            TextCidade.SelectedText = "";
            TextCidade.SelectionLength = 0;
            TextCidade.SelectionStart = 0;
            TextCidade.ShortcutsEnabled = true;
            TextCidade.Size = new Size(650, 48);
            TextCidade.TabIndex = 5;
            TextCidade.TabStop = false;
            TextCidade.TextAlign = HorizontalAlignment.Left;
            TextCidade.TrailingIcon = null;
            TextCidade.UseSystemPasswordChar = false;
            // 
            // TextBairro
            // 
            TextBairro.AnimateReadOnly = false;
            TextBairro.AutoCompleteMode = AutoCompleteMode.None;
            TextBairro.AutoCompleteSource = AutoCompleteSource.None;
            TextBairro.BackgroundImageLayout = ImageLayout.None;
            TextBairro.CharacterCasing = CharacterCasing.Normal;
            TextBairro.Depth = 0;
            TextBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBairro.HideSelection = true;
            TextBairro.Hint = "Bairro";
            TextBairro.LeadingIcon = null;
            TextBairro.Location = new Point(6, 168);
            TextBairro.MaxLength = 32767;
            TextBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextBairro.Name = "TextBairro";
            TextBairro.PasswordChar = '\0';
            TextBairro.PrefixSuffixText = null;
            TextBairro.ReadOnly = false;
            TextBairro.RightToLeft = RightToLeft.No;
            TextBairro.SelectedText = "";
            TextBairro.SelectionLength = 0;
            TextBairro.SelectionStart = 0;
            TextBairro.ShortcutsEnabled = true;
            TextBairro.Size = new Size(774, 48);
            TextBairro.TabIndex = 4;
            TextBairro.TabStop = false;
            TextBairro.TextAlign = HorizontalAlignment.Left;
            TextBairro.TrailingIcon = null;
            TextBairro.UseSystemPasswordChar = false;
            // 
            // TextEndereco
            // 
            TextEndereco.AnimateReadOnly = false;
            TextEndereco.AutoCompleteMode = AutoCompleteMode.None;
            TextEndereco.AutoCompleteSource = AutoCompleteSource.None;
            TextEndereco.BackgroundImageLayout = ImageLayout.None;
            TextEndereco.CharacterCasing = CharacterCasing.Normal;
            TextEndereco.Depth = 0;
            TextEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextEndereco.HideSelection = true;
            TextEndereco.Hint = "Endereço";
            TextEndereco.LeadingIcon = null;
            TextEndereco.Location = new Point(6, 114);
            TextEndereco.MaxLength = 32767;
            TextEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextEndereco.Name = "TextEndereco";
            TextEndereco.PasswordChar = '\0';
            TextEndereco.PrefixSuffixText = null;
            TextEndereco.ReadOnly = false;
            TextEndereco.RightToLeft = RightToLeft.No;
            TextEndereco.SelectedText = "";
            TextEndereco.SelectionLength = 0;
            TextEndereco.SelectionStart = 0;
            TextEndereco.ShortcutsEnabled = true;
            TextEndereco.Size = new Size(774, 48);
            TextEndereco.TabIndex = 3;
            TextEndereco.TabStop = false;
            TextEndereco.TextAlign = HorizontalAlignment.Left;
            TextEndereco.TrailingIcon = null;
            TextEndereco.UseSystemPasswordChar = false;
            // 
            // TextNome
            // 
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
            TextNome.Location = new Point(6, 60);
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
            TextNome.TabIndex = 2;
            TextNome.TabStop = false;
            TextNome.TextAlign = HorizontalAlignment.Left;
            TextNome.TrailingIcon = null;
            TextNome.UseSystemPasswordChar = false;
            // 
            // ComboEstado
            // 
            ComboEstado.AutoResize = false;
            ComboEstado.BackColor = Color.FromArgb(255, 255, 255);
            ComboEstado.Depth = 0;
            ComboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            ComboEstado.DropDownHeight = 174;
            ComboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboEstado.DropDownWidth = 121;
            ComboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboEstado.FormattingEnabled = true;
            ComboEstado.Hint = "Estado";
            ComboEstado.IntegralHeight = false;
            ComboEstado.ItemHeight = 43;
            ComboEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            ComboEstado.Location = new Point(662, 222);
            ComboEstado.MaxDropDownItems = 4;
            ComboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboEstado.Name = "ComboEstado";
            ComboEstado.Size = new Size(121, 49);
            ComboEstado.StartIndex = 0;
            ComboEstado.TabIndex = 6;
            ComboEstado.SelectedIndexChanged += ComboEstado_SelectedIndexChanged;
            // 
            // TextDataNasc
            // 
            TextDataNasc.AllowPromptAsInput = true;
            TextDataNasc.AnimateReadOnly = false;
            TextDataNasc.AsciiOnly = false;
            TextDataNasc.BackgroundImageLayout = ImageLayout.None;
            TextDataNasc.BeepOnError = false;
            TextDataNasc.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TextDataNasc.Depth = 0;
            TextDataNasc.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextDataNasc.HidePromptOnLeave = false;
            TextDataNasc.HideSelection = true;
            TextDataNasc.Hint = "Data de Nascimento";
            TextDataNasc.InsertKeyMode = InsertKeyMode.Default;
            TextDataNasc.LeadingIcon = null;
            TextDataNasc.Location = new Point(593, 6);
            TextDataNasc.Mask = "99/99/9999";
            TextDataNasc.MaxLength = 32767;
            TextDataNasc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextDataNasc.Name = "TextDataNasc";
            TextDataNasc.PasswordChar = '\0';
            TextDataNasc.PrefixSuffixText = null;
            TextDataNasc.PromptChar = '_';
            TextDataNasc.ReadOnly = false;
            TextDataNasc.RejectInputOnFirstFailure = false;
            TextDataNasc.ResetOnPrompt = true;
            TextDataNasc.ResetOnSpace = true;
            TextDataNasc.RightToLeft = RightToLeft.No;
            TextDataNasc.SelectedText = "";
            TextDataNasc.SelectionLength = 0;
            TextDataNasc.SelectionStart = 0;
            TextDataNasc.ShortcutsEnabled = true;
            TextDataNasc.Size = new Size(187, 48);
            TextDataNasc.SkipLiterals = true;
            TextDataNasc.TabIndex = 1;
            TextDataNasc.TabStop = false;
            TextDataNasc.Text = "  /  /";
            TextDataNasc.TextAlign = HorizontalAlignment.Left;
            TextDataNasc.TextMaskFormat = MaskFormat.IncludeLiterals;
            TextDataNasc.TrailingIcon = null;
            TextDataNasc.UseSystemPasswordChar = false;
            TextDataNasc.ValidatingType = null;
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
            TextMatricula.Location = new Point(6, 6);
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
            TextMatricula.Size = new Size(581, 48);
            TextMatricula.TabIndex = 0;
            TextMatricula.TabStop = false;
            TextMatricula.TextAlign = HorizontalAlignment.Left;
            TextMatricula.TrailingIcon = null;
            TextMatricula.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(MLVAlunos);
            tabPageConsulta.Controls.Add(ButtonExcluir);
            tabPageConsulta.Controls.Add(ButtonEditar);
            tabPageConsulta.Controls.Add(ButtonNovo);
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(786, 418);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // MLVAlunos
            // 
            MLVAlunos.FullRowSelect = true;
            MLVAlunos.Location = new Point(0, 0);
            MLVAlunos.Name = "MLVAlunos";
            MLVAlunos.Size = new Size(786, 367);
            MLVAlunos.TabIndex = 4;
            MLVAlunos.UseCompatibleStateImageBehavior = false;
            MLVAlunos.View = View.Details;
            MLVAlunos.SelectedIndexChanged += MLVAlunos_SelectedIndexChanged;
            MLVAlunos.MouseDoubleClick += MLVAlunos_MouseDoubleClick;
            // 
            // ButtonExcluir
            // 
            ButtonExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonExcluir.Depth = 0;
            ButtonExcluir.HighEmphasis = true;
            ButtonExcluir.Icon = null;
            ButtonExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonExcluir.Location = new Point(699, 376);
            ButtonExcluir.Margin = new Padding(4, 6, 4, 6);
            ButtonExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonExcluir.Name = "ButtonExcluir";
            ButtonExcluir.NoAccentTextColor = Color.Empty;
            ButtonExcluir.Size = new Size(80, 36);
            ButtonExcluir.TabIndex = 3;
            ButtonExcluir.Text = "Excluir";
            ButtonExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonExcluir.UseAccentColor = false;
            ButtonExcluir.UseVisualStyleBackColor = true;
            ButtonExcluir.Click += ButtonExcluir_Click;
            // 
            // ButtonEditar
            // 
            ButtonEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonEditar.Depth = 0;
            ButtonEditar.HighEmphasis = true;
            ButtonEditar.Icon = null;
            ButtonEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonEditar.Location = new Point(620, 376);
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
            // ButtonNovo
            // 
            ButtonNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonNovo.Depth = 0;
            ButtonNovo.HighEmphasis = true;
            ButtonNovo.Icon = null;
            ButtonNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonNovo.Location = new Point(548, 376);
            ButtonNovo.Margin = new Padding(4, 6, 4, 6);
            ButtonNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonNovo.Name = "ButtonNovo";
            ButtonNovo.NoAccentTextColor = Color.Empty;
            ButtonNovo.Size = new Size(64, 36);
            ButtonNovo.TabIndex = 1;
            ButtonNovo.Text = "Novo";
            ButtonNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonNovo.UseAccentColor = false;
            ButtonNovo.UseVisualStyleBackColor = true;
            ButtonNovo.Click += ButtonNovo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // Form_Cadastro_Aluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(TabControl);
            DrawerTabControl = TabControl;
            Name = "Form_Cadastro_Aluno";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Aluno - IFSP Birigui";
            Load += Form_Cadastro_Aluno_Load;
            TabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControl;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextNome;
        private ReaLTaiizor.Controls.MaterialComboBox ComboEstado;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox TextDataNasc;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextMatricula;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextSenha;
        private ReaLTaiizor.Controls.MaterialButton ButtonSalvar;
        private ReaLTaiizor.Controls.MaterialButton ButtonCancelar;
        private ReaLTaiizor.Controls.MaterialButton ButtonExcluir;
        private ReaLTaiizor.Controls.MaterialButton ButtonEditar;
        private ReaLTaiizor.Controls.MaterialButton ButtonNovo;
        private ListView MLVAlunos;
    }
}