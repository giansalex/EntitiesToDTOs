﻿namespace EntitiesToDTOs.UI
{
    partial class MainWindows
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
            System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstEntitySources = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbUseDefaultNamespaceDTOs = new System.Windows.Forms.CheckBox();
            this.txtNamespaceDTOs = new System.Windows.Forms.TextBox();
            this.cbServiceReadyDTOs = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSourceFileNameDTOs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbOneSourceFileDTOs = new System.Windows.Forms.RadioButton();
            this.rbSourceFilePerClassDTOs = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAssociationConfigUseKeyProperty = new System.Windows.Forms.RadioButton();
            this.rbAssociationConfigUseClassTypes = new System.Windows.Forms.RadioButton();
            this.txtCustomHeaderComment = new System.Windows.Forms.RichTextBox();
            this.cbCustomHeaderComment = new System.Windows.Forms.CheckBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.cbGenerateAssemblers = new System.Windows.Forms.CheckBox();
            this.cbGenerateDTOConstructors = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupGenerationTypeAssemblers = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSourceFileNameAssemblers = new System.Windows.Forms.TextBox();
            this.rbSourceFilePerClassAssemblers = new System.Windows.Forms.RadioButton();
            this.rbOneSourceFileAssemblers = new System.Windows.Forms.RadioButton();
            this.txtNamespaceAssemblers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUseDefaultNamespaceAssemblers = new System.Windows.Forms.CheckBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbSourceEdmx = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTypes = new System.Windows.Forms.DataGridView();
            this.colWarnings = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenerateType = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chbGenerateComplexTypes = new System.Windows.Forms.CheckBox();
            this.chbGenerateAllTypes = new System.Windows.Forms.CheckBox();
            this.chbGenerateEntityTypes = new System.Windows.Forms.CheckBox();
            this.rbSourceProject = new System.Windows.Forms.RadioButton();
            this.tabDTOs = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDTOIdentifierWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDTOIdentifierSuffix = new System.Windows.Forms.RadioButton();
            this.rbDTOIdentifierPrefix = new System.Windows.Forms.RadioButton();
            this.rbDTOIdentifierNone = new System.Windows.Forms.RadioButton();
            this.treeTargetDTOs = new System.Windows.Forms.TreeView();
            this.tabAssemblers = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.treeTargetAssemblers = new System.Windows.Forms.TreeView();
            this.groupIdentifierAssemblers = new System.Windows.Forms.GroupBox();
            this.txtAssemblerIdentifierWord = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbAssemblerIdentifierSuffix = new System.Windows.Forms.RadioButton();
            this.rbAssemblerIdentifierPrefix = new System.Windows.Forms.RadioButton();
            this.rbAssemblerIdentifierNone = new System.Windows.Forms.RadioButton();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupGenerationTypeAssemblers.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
            this.tabDTOs.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabAssemblers.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupIdentifierAssemblers.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // configToolStripMenuItem
            // 
            configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            importToolStripMenuItem,
            exportToolStripMenuItem});
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            configToolStripMenuItem.Text = "Config";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += new System.EventHandler(this.btnConfigImport_Click);
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += new System.EventHandler(this.btnConfigExport_Click);
            // 
            // lstEntitySources
            // 
            this.lstEntitySources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstEntitySources.FormattingEnabled = true;
            this.lstEntitySources.HorizontalScrollbar = true;
            this.lstEntitySources.Location = new System.Drawing.Point(6, 42);
            this.lstEntitySources.Name = "lstEntitySources";
            this.lstEntitySources.ScrollAlwaysVisible = true;
            this.lstEntitySources.Size = new System.Drawing.Size(220, 264);
            this.lstEntitySources.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(536, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGenerate.Location = new System.Drawing.Point(430, 374);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 31);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "&Generar";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbUseDefaultNamespaceDTOs
            // 
            this.cbUseDefaultNamespaceDTOs.AutoSize = true;
            this.cbUseDefaultNamespaceDTOs.Checked = true;
            this.cbUseDefaultNamespaceDTOs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseDefaultNamespaceDTOs.Location = new System.Drawing.Point(235, 19);
            this.cbUseDefaultNamespaceDTOs.Name = "cbUseDefaultNamespaceDTOs";
            this.cbUseDefaultNamespaceDTOs.Size = new System.Drawing.Size(168, 17);
            this.cbUseDefaultNamespaceDTOs.TabIndex = 6;
            this.cbUseDefaultNamespaceDTOs.Text = "Use target default namespace";
            this.cbUseDefaultNamespaceDTOs.UseVisualStyleBackColor = true;
            this.cbUseDefaultNamespaceDTOs.CheckedChanged += new System.EventHandler(this.cbUseDefaultNamespaceDTOs_CheckedChanged);
            // 
            // txtNamespaceDTOs
            // 
            this.txtNamespaceDTOs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamespaceDTOs.Enabled = false;
            this.txtNamespaceDTOs.Location = new System.Drawing.Point(305, 42);
            this.txtNamespaceDTOs.Name = "txtNamespaceDTOs";
            this.txtNamespaceDTOs.Size = new System.Drawing.Size(297, 20);
            this.txtNamespaceDTOs.TabIndex = 7;
            // 
            // cbServiceReadyDTOs
            // 
            this.cbServiceReadyDTOs.AutoSize = true;
            this.cbServiceReadyDTOs.Checked = true;
            this.cbServiceReadyDTOs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbServiceReadyDTOs.Location = new System.Drawing.Point(235, 68);
            this.cbServiceReadyDTOs.Name = "cbServiceReadyDTOs";
            this.cbServiceReadyDTOs.Size = new System.Drawing.Size(127, 17);
            this.cbServiceReadyDTOs.TabIndex = 8;
            this.cbServiceReadyDTOs.Text = "DTOs Service-Ready";
            this.cbServiceReadyDTOs.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Namespace:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSourceFileNameDTOs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbOneSourceFileDTOs);
            this.groupBox1.Controls.Add(this.rbSourceFilePerClassDTOs);
            this.groupBox1.Location = new System.Drawing.Point(235, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 73);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generation Type";
            // 
            // txtSourceFileNameDTOs
            // 
            this.txtSourceFileNameDTOs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFileNameDTOs.Location = new System.Drawing.Point(104, 42);
            this.txtSourceFileNameDTOs.Name = "txtSourceFileNameDTOs";
            this.txtSourceFileNameDTOs.Size = new System.Drawing.Size(257, 20);
            this.txtSourceFileNameDTOs.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Source File name:";
            // 
            // rbOneSourceFileDTOs
            // 
            this.rbOneSourceFileDTOs.AutoSize = true;
            this.rbOneSourceFileDTOs.Checked = true;
            this.rbOneSourceFileDTOs.Location = new System.Drawing.Point(6, 19);
            this.rbOneSourceFileDTOs.Name = "rbOneSourceFileDTOs";
            this.rbOneSourceFileDTOs.Size = new System.Drawing.Size(101, 17);
            this.rbOneSourceFileDTOs.TabIndex = 1;
            this.rbOneSourceFileDTOs.TabStop = true;
            this.rbOneSourceFileDTOs.Text = "One Source File";
            this.rbOneSourceFileDTOs.UseVisualStyleBackColor = true;
            this.rbOneSourceFileDTOs.CheckedChanged += new System.EventHandler(this.rbSourceFileGenerationTypeDTOs_CheckedChanged);
            // 
            // rbSourceFilePerClassDTOs
            // 
            this.rbSourceFilePerClassDTOs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSourceFilePerClassDTOs.AutoSize = true;
            this.rbSourceFilePerClassDTOs.Location = new System.Drawing.Point(141, 19);
            this.rbSourceFilePerClassDTOs.Name = "rbSourceFilePerClassDTOs";
            this.rbSourceFilePerClassDTOs.Size = new System.Drawing.Size(124, 17);
            this.rbSourceFilePerClassDTOs.TabIndex = 0;
            this.rbSourceFilePerClassDTOs.Text = "Source File per Class";
            this.rbSourceFilePerClassDTOs.UseVisualStyleBackColor = true;
            this.rbSourceFilePerClassDTOs.CheckedChanged += new System.EventHandler(this.rbSourceFileGenerationTypeDTOs_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbAssociationConfigUseKeyProperty);
            this.groupBox2.Controls.Add(this.rbAssociationConfigUseClassTypes);
            this.groupBox2.Location = new System.Drawing.Point(235, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 52);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Association";
            // 
            // rbAssociationConfigUseKeyProperty
            // 
            this.rbAssociationConfigUseKeyProperty.AutoSize = true;
            this.rbAssociationConfigUseKeyProperty.Checked = true;
            this.rbAssociationConfigUseKeyProperty.Location = new System.Drawing.Point(6, 22);
            this.rbAssociationConfigUseKeyProperty.Name = "rbAssociationConfigUseKeyProperty";
            this.rbAssociationConfigUseKeyProperty.Size = new System.Drawing.Size(93, 17);
            this.rbAssociationConfigUseKeyProperty.TabIndex = 1;
            this.rbAssociationConfigUseKeyProperty.TabStop = true;
            this.rbAssociationConfigUseKeyProperty.Text = "Key Properties";
            this.rbAssociationConfigUseKeyProperty.UseVisualStyleBackColor = true;
            // 
            // rbAssociationConfigUseClassTypes
            // 
            this.rbAssociationConfigUseClassTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAssociationConfigUseClassTypes.AutoSize = true;
            this.rbAssociationConfigUseClassTypes.Location = new System.Drawing.Point(141, 22);
            this.rbAssociationConfigUseClassTypes.Name = "rbAssociationConfigUseClassTypes";
            this.rbAssociationConfigUseClassTypes.Size = new System.Drawing.Size(82, 17);
            this.rbAssociationConfigUseClassTypes.TabIndex = 0;
            this.rbAssociationConfigUseClassTypes.Text = "Class Types";
            this.rbAssociationConfigUseClassTypes.UseVisualStyleBackColor = true;
            // 
            // txtCustomHeaderComment
            // 
            this.txtCustomHeaderComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomHeaderComment.Enabled = false;
            this.txtCustomHeaderComment.Location = new System.Drawing.Point(6, 42);
            this.txtCustomHeaderComment.Name = "txtCustomHeaderComment";
            this.txtCustomHeaderComment.Size = new System.Drawing.Size(608, 247);
            this.txtCustomHeaderComment.TabIndex = 12;
            this.txtCustomHeaderComment.Text = "";
            // 
            // cbCustomHeaderComment
            // 
            this.cbCustomHeaderComment.AutoSize = true;
            this.cbCustomHeaderComment.Location = new System.Drawing.Point(6, 19);
            this.cbCustomHeaderComment.Name = "cbCustomHeaderComment";
            this.cbCustomHeaderComment.Size = new System.Drawing.Size(143, 17);
            this.cbCustomHeaderComment.TabIndex = 13;
            this.cbCustomHeaderComment.Text = "Custom header comment";
            this.cbCustomHeaderComment.UseVisualStyleBackColor = true;
            this.cbCustomHeaderComment.CheckedChanged += new System.EventHandler(this.cbCustomHeaderComment_CheckedChanged);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::IMM.EntitiesToDTOs.Properties.Resources.img_help;
            this.btnHelp.Location = new System.Drawing.Point(618, 8);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 23);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.btnHelp_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.btnHelp_MouseLeave);
            // 
            // cbGenerateAssemblers
            // 
            this.cbGenerateAssemblers.AutoSize = true;
            this.cbGenerateAssemblers.Checked = true;
            this.cbGenerateAssemblers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGenerateAssemblers.Location = new System.Drawing.Point(235, 19);
            this.cbGenerateAssemblers.Name = "cbGenerateAssemblers";
            this.cbGenerateAssemblers.Size = new System.Drawing.Size(126, 17);
            this.cbGenerateAssemblers.TabIndex = 16;
            this.cbGenerateAssemblers.Text = "Generate Assemblers";
            this.cbGenerateAssemblers.UseVisualStyleBackColor = true;
            this.cbGenerateAssemblers.CheckedChanged += new System.EventHandler(this.cbGenerateAssemblers_CheckedChanged);
            // 
            // cbGenerateDTOConstructors
            // 
            this.cbGenerateDTOConstructors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGenerateDTOConstructors.AutoSize = true;
            this.cbGenerateDTOConstructors.Checked = true;
            this.cbGenerateDTOConstructors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGenerateDTOConstructors.Location = new System.Drawing.Point(432, 68);
            this.cbGenerateDTOConstructors.Name = "cbGenerateDTOConstructors";
            this.cbGenerateDTOConstructors.Size = new System.Drawing.Size(170, 17);
            this.cbGenerateDTOConstructors.TabIndex = 12;
            this.cbGenerateDTOConstructors.Text = "Generate Constructor methods";
            this.cbGenerateDTOConstructors.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.cbCustomHeaderComment);
            this.groupBox5.Controls.Add(this.txtCustomHeaderComment);
            this.groupBox5.Location = new System.Drawing.Point(0, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(620, 295);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Generated Source Files";
            // 
            // groupGenerationTypeAssemblers
            // 
            this.groupGenerationTypeAssemblers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupGenerationTypeAssemblers.Controls.Add(this.label7);
            this.groupGenerationTypeAssemblers.Controls.Add(this.txtSourceFileNameAssemblers);
            this.groupGenerationTypeAssemblers.Controls.Add(this.rbSourceFilePerClassAssemblers);
            this.groupGenerationTypeAssemblers.Controls.Add(this.rbOneSourceFileAssemblers);
            this.groupGenerationTypeAssemblers.Location = new System.Drawing.Point(235, 91);
            this.groupGenerationTypeAssemblers.Name = "groupGenerationTypeAssemblers";
            this.groupGenerationTypeAssemblers.Size = new System.Drawing.Size(367, 73);
            this.groupGenerationTypeAssemblers.TabIndex = 22;
            this.groupGenerationTypeAssemblers.TabStop = false;
            this.groupGenerationTypeAssemblers.Text = "Generation Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Source File name:";
            // 
            // txtSourceFileNameAssemblers
            // 
            this.txtSourceFileNameAssemblers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFileNameAssemblers.Location = new System.Drawing.Point(104, 42);
            this.txtSourceFileNameAssemblers.Name = "txtSourceFileNameAssemblers";
            this.txtSourceFileNameAssemblers.Size = new System.Drawing.Size(257, 20);
            this.txtSourceFileNameAssemblers.TabIndex = 2;
            // 
            // rbSourceFilePerClassAssemblers
            // 
            this.rbSourceFilePerClassAssemblers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSourceFilePerClassAssemblers.AutoSize = true;
            this.rbSourceFilePerClassAssemblers.Location = new System.Drawing.Point(141, 19);
            this.rbSourceFilePerClassAssemblers.Name = "rbSourceFilePerClassAssemblers";
            this.rbSourceFilePerClassAssemblers.Size = new System.Drawing.Size(124, 17);
            this.rbSourceFilePerClassAssemblers.TabIndex = 1;
            this.rbSourceFilePerClassAssemblers.TabStop = true;
            this.rbSourceFilePerClassAssemblers.Text = "Source File per Class";
            this.rbSourceFilePerClassAssemblers.UseVisualStyleBackColor = true;
            this.rbSourceFilePerClassAssemblers.CheckedChanged += new System.EventHandler(this.rbSourceFileGenerationTypeAssemblers_CheckedChanged);
            // 
            // rbOneSourceFileAssemblers
            // 
            this.rbOneSourceFileAssemblers.AutoSize = true;
            this.rbOneSourceFileAssemblers.Checked = true;
            this.rbOneSourceFileAssemblers.Location = new System.Drawing.Point(6, 19);
            this.rbOneSourceFileAssemblers.Name = "rbOneSourceFileAssemblers";
            this.rbOneSourceFileAssemblers.Size = new System.Drawing.Size(101, 17);
            this.rbOneSourceFileAssemblers.TabIndex = 0;
            this.rbOneSourceFileAssemblers.TabStop = true;
            this.rbOneSourceFileAssemblers.Text = "One Source File";
            this.rbOneSourceFileAssemblers.UseVisualStyleBackColor = true;
            this.rbOneSourceFileAssemblers.CheckedChanged += new System.EventHandler(this.rbSourceFileGenerationTypeAssemblers_CheckedChanged);
            // 
            // txtNamespaceAssemblers
            // 
            this.txtNamespaceAssemblers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamespaceAssemblers.Enabled = false;
            this.txtNamespaceAssemblers.Location = new System.Drawing.Point(305, 65);
            this.txtNamespaceAssemblers.Name = "txtNamespaceAssemblers";
            this.txtNamespaceAssemblers.Size = new System.Drawing.Size(297, 20);
            this.txtNamespaceAssemblers.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Namespace:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Target";
            // 
            // cbUseDefaultNamespaceAssemblers
            // 
            this.cbUseDefaultNamespaceAssemblers.AutoSize = true;
            this.cbUseDefaultNamespaceAssemblers.Checked = true;
            this.cbUseDefaultNamespaceAssemblers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseDefaultNamespaceAssemblers.Location = new System.Drawing.Point(235, 42);
            this.cbUseDefaultNamespaceAssemblers.Name = "cbUseDefaultNamespaceAssemblers";
            this.cbUseDefaultNamespaceAssemblers.Size = new System.Drawing.Size(168, 17);
            this.cbUseDefaultNamespaceAssemblers.TabIndex = 18;
            this.cbUseDefaultNamespaceAssemblers.Text = "Use target default namespace";
            this.cbUseDefaultNamespaceAssemblers.UseVisualStyleBackColor = true;
            this.cbUseDefaultNamespaceAssemblers.CheckedChanged += new System.EventHandler(this.cbUseDefaultNamespaceAssemblers_CheckedChanged);
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabSource);
            this.tabs.Controls.Add(this.tabDTOs);
            this.tabs.Controls.Add(this.tabAssemblers);
            this.tabs.Controls.Add(this.tabGeneral);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(628, 360);
            this.tabs.TabIndex = 22;
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.groupBox8);
            this.tabSource.Location = new System.Drawing.Point(4, 22);
            this.tabSource.Name = "tabSource";
            this.tabSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabSource.Size = new System.Drawing.Size(620, 334);
            this.tabSource.TabIndex = 0;
            this.tabSource.Text = "Source";
            this.tabSource.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbSourceEdmx);
            this.groupBox8.Controls.Add(this.groupBox3);
            this.groupBox8.Controls.Add(this.rbSourceProject);
            this.groupBox8.Controls.Add(this.lstEntitySources);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(614, 328);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            // 
            // rbSourceEdmx
            // 
            this.rbSourceEdmx.AutoSize = true;
            this.rbSourceEdmx.Checked = true;
            this.rbSourceEdmx.Location = new System.Drawing.Point(6, 19);
            this.rbSourceEdmx.Name = "rbSourceEdmx";
            this.rbSourceEdmx.Size = new System.Drawing.Size(85, 17);
            this.rbSourceEdmx.TabIndex = 6;
            this.rbSourceEdmx.TabStop = true;
            this.rbSourceEdmx.Text = "Edmx / Edml";
            this.rbSourceEdmx.UseVisualStyleBackColor = true;
            this.rbSourceEdmx.CheckedChanged += new System.EventHandler(this.rbSourceEdmx_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvTypes);
            this.groupBox3.Controls.Add(this.chbGenerateComplexTypes);
            this.groupBox3.Controls.Add(this.chbGenerateAllTypes);
            this.groupBox3.Controls.Add(this.chbGenerateEntityTypes);
            this.groupBox3.Location = new System.Drawing.Point(232, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 297);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customize";
            // 
            // dgvTypes
            // 
            this.dgvTypes.AllowUserToAddRows = false;
            this.dgvTypes.AllowUserToDeleteRows = false;
            this.dgvTypes.AllowUserToResizeRows = false;
            this.dgvTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWarnings,
            this.colTypeName,
            this.colType,
            this.colGenerateType});
            this.dgvTypes.Location = new System.Drawing.Point(6, 19);
            this.dgvTypes.MultiSelect = false;
            this.dgvTypes.Name = "dgvTypes";
            this.dgvTypes.RowHeadersVisible = false;
            this.dgvTypes.RowHeadersWidth = 30;
            this.dgvTypes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypes.Size = new System.Drawing.Size(358, 249);
            this.dgvTypes.TabIndex = 6;
            // 
            // colWarnings
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.colWarnings.DefaultCellStyle = dataGridViewCellStyle3;
            this.colWarnings.FillWeight = 40.60914F;
            this.colWarnings.HeaderText = "";
            this.colWarnings.Name = "colWarnings";
            this.colWarnings.ReadOnly = true;
            this.colWarnings.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTypeName
            // 
            this.colTypeName.FillWeight = 119.797F;
            this.colTypeName.HeaderText = "Name";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.FillWeight = 119.797F;
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colGenerateType
            // 
            this.colGenerateType.FillWeight = 119.797F;
            this.colGenerateType.HeaderText = "Generate";
            this.colGenerateType.Name = "colGenerateType";
            // 
            // chbGenerateComplexTypes
            // 
            this.chbGenerateComplexTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chbGenerateComplexTypes.AutoSize = true;
            this.chbGenerateComplexTypes.Location = new System.Drawing.Point(130, 274);
            this.chbGenerateComplexTypes.Name = "chbGenerateComplexTypes";
            this.chbGenerateComplexTypes.Size = new System.Drawing.Size(98, 17);
            this.chbGenerateComplexTypes.TabIndex = 0;
            this.chbGenerateComplexTypes.Text = "Complex Types";
            this.chbGenerateComplexTypes.UseVisualStyleBackColor = true;
            // 
            // chbGenerateAllTypes
            // 
            this.chbGenerateAllTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chbGenerateAllTypes.AutoSize = true;
            this.chbGenerateAllTypes.Location = new System.Drawing.Point(6, 274);
            this.chbGenerateAllTypes.Name = "chbGenerateAllTypes";
            this.chbGenerateAllTypes.Size = new System.Drawing.Size(69, 17);
            this.chbGenerateAllTypes.TabIndex = 1;
            this.chbGenerateAllTypes.Text = "All Types";
            this.chbGenerateAllTypes.UseVisualStyleBackColor = true;
            // 
            // chbGenerateEntityTypes
            // 
            this.chbGenerateEntityTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chbGenerateEntityTypes.AutoSize = true;
            this.chbGenerateEntityTypes.Location = new System.Drawing.Point(280, 274);
            this.chbGenerateEntityTypes.Name = "chbGenerateEntityTypes";
            this.chbGenerateEntityTypes.Size = new System.Drawing.Size(84, 17);
            this.chbGenerateEntityTypes.TabIndex = 2;
            this.chbGenerateEntityTypes.Text = "Entity Types";
            this.chbGenerateEntityTypes.UseVisualStyleBackColor = true;
            // 
            // rbSourceProject
            // 
            this.rbSourceProject.AutoSize = true;
            this.rbSourceProject.Location = new System.Drawing.Point(152, 19);
            this.rbSourceProject.Name = "rbSourceProject";
            this.rbSourceProject.Size = new System.Drawing.Size(58, 17);
            this.rbSourceProject.TabIndex = 7;
            this.rbSourceProject.Text = "Project";
            this.rbSourceProject.UseVisualStyleBackColor = true;
            this.rbSourceProject.CheckedChanged += new System.EventHandler(this.rbSourceProject_CheckedChanged);
            // 
            // tabDTOs
            // 
            this.tabDTOs.Controls.Add(this.groupBox9);
            this.tabDTOs.Location = new System.Drawing.Point(4, 22);
            this.tabDTOs.Name = "tabDTOs";
            this.tabDTOs.Padding = new System.Windows.Forms.Padding(3);
            this.tabDTOs.Size = new System.Drawing.Size(620, 334);
            this.tabDTOs.TabIndex = 1;
            this.tabDTOs.Text = "DTOs";
            this.tabDTOs.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Controls.Add(this.groupBox4);
            this.groupBox9.Controls.Add(this.treeTargetDTOs);
            this.groupBox9.Controls.Add(this.groupBox1);
            this.groupBox9.Controls.Add(this.cbUseDefaultNamespaceDTOs);
            this.groupBox9.Controls.Add(this.cbGenerateDTOConstructors);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.groupBox2);
            this.groupBox9.Controls.Add(this.cbServiceReadyDTOs);
            this.groupBox9.Controls.Add(this.txtNamespaceDTOs);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(614, 328);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtDTOIdentifierWord);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.rbDTOIdentifierSuffix);
            this.groupBox4.Controls.Add(this.rbDTOIdentifierPrefix);
            this.groupBox4.Controls.Add(this.rbDTOIdentifierNone);
            this.groupBox4.Location = new System.Drawing.Point(236, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 73);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Identifier";
            // 
            // txtDTOIdentifierWord
            // 
            this.txtDTOIdentifierWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDTOIdentifierWord.Location = new System.Drawing.Point(45, 42);
            this.txtDTOIdentifierWord.Name = "txtDTOIdentifierWord";
            this.txtDTOIdentifierWord.Size = new System.Drawing.Size(315, 20);
            this.txtDTOIdentifierWord.TabIndex = 4;
            this.txtDTOIdentifierWord.Text = "DTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word";
            // 
            // rbDTOIdentifierSuffix
            // 
            this.rbDTOIdentifierSuffix.AutoSize = true;
            this.rbDTOIdentifierSuffix.Checked = true;
            this.rbDTOIdentifierSuffix.Location = new System.Drawing.Point(171, 19);
            this.rbDTOIdentifierSuffix.Name = "rbDTOIdentifierSuffix";
            this.rbDTOIdentifierSuffix.Size = new System.Drawing.Size(51, 17);
            this.rbDTOIdentifierSuffix.TabIndex = 2;
            this.rbDTOIdentifierSuffix.TabStop = true;
            this.rbDTOIdentifierSuffix.Text = "Suffix";
            this.rbDTOIdentifierSuffix.UseVisualStyleBackColor = true;
            // 
            // rbDTOIdentifierPrefix
            // 
            this.rbDTOIdentifierPrefix.AutoSize = true;
            this.rbDTOIdentifierPrefix.Location = new System.Drawing.Point(91, 19);
            this.rbDTOIdentifierPrefix.Name = "rbDTOIdentifierPrefix";
            this.rbDTOIdentifierPrefix.Size = new System.Drawing.Size(51, 17);
            this.rbDTOIdentifierPrefix.TabIndex = 1;
            this.rbDTOIdentifierPrefix.Text = "Prefix";
            this.rbDTOIdentifierPrefix.UseVisualStyleBackColor = true;
            // 
            // rbDTOIdentifierNone
            // 
            this.rbDTOIdentifierNone.AutoSize = true;
            this.rbDTOIdentifierNone.Location = new System.Drawing.Point(6, 19);
            this.rbDTOIdentifierNone.Name = "rbDTOIdentifierNone";
            this.rbDTOIdentifierNone.Size = new System.Drawing.Size(51, 17);
            this.rbDTOIdentifierNone.TabIndex = 0;
            this.rbDTOIdentifierNone.Text = "None";
            this.rbDTOIdentifierNone.UseVisualStyleBackColor = true;
            this.rbDTOIdentifierNone.CheckedChanged += new System.EventHandler(this.rbDTOIdentifierNone_CheckedChanged);
            // 
            // treeTargetDTOs
            // 
            this.treeTargetDTOs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeTargetDTOs.HideSelection = false;
            this.treeTargetDTOs.HotTracking = true;
            this.treeTargetDTOs.Location = new System.Drawing.Point(6, 32);
            this.treeTargetDTOs.Name = "treeTargetDTOs";
            this.treeTargetDTOs.Size = new System.Drawing.Size(223, 284);
            this.treeTargetDTOs.TabIndex = 14;
            // 
            // tabAssemblers
            // 
            this.tabAssemblers.Controls.Add(this.groupBox10);
            this.tabAssemblers.Location = new System.Drawing.Point(4, 22);
            this.tabAssemblers.Name = "tabAssemblers";
            this.tabAssemblers.Size = new System.Drawing.Size(620, 334);
            this.tabAssemblers.TabIndex = 2;
            this.tabAssemblers.Text = "Assemblers";
            this.tabAssemblers.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.treeTargetAssemblers);
            this.groupBox10.Controls.Add(this.cbUseDefaultNamespaceAssemblers);
            this.groupBox10.Controls.Add(this.groupIdentifierAssemblers);
            this.groupBox10.Controls.Add(this.cbGenerateAssemblers);
            this.groupBox10.Controls.Add(this.groupGenerationTypeAssemblers);
            this.groupBox10.Controls.Add(this.label5);
            this.groupBox10.Controls.Add(this.txtNamespaceAssemblers);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(0, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(620, 334);
            this.groupBox10.TabIndex = 25;
            this.groupBox10.TabStop = false;
            // 
            // treeTargetAssemblers
            // 
            this.treeTargetAssemblers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeTargetAssemblers.HideSelection = false;
            this.treeTargetAssemblers.HotTracking = true;
            this.treeTargetAssemblers.Location = new System.Drawing.Point(6, 32);
            this.treeTargetAssemblers.Name = "treeTargetAssemblers";
            this.treeTargetAssemblers.Size = new System.Drawing.Size(223, 284);
            this.treeTargetAssemblers.TabIndex = 24;
            // 
            // groupIdentifierAssemblers
            // 
            this.groupIdentifierAssemblers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupIdentifierAssemblers.Controls.Add(this.txtAssemblerIdentifierWord);
            this.groupIdentifierAssemblers.Controls.Add(this.label8);
            this.groupIdentifierAssemblers.Controls.Add(this.rbAssemblerIdentifierSuffix);
            this.groupIdentifierAssemblers.Controls.Add(this.rbAssemblerIdentifierPrefix);
            this.groupIdentifierAssemblers.Controls.Add(this.rbAssemblerIdentifierNone);
            this.groupIdentifierAssemblers.Location = new System.Drawing.Point(236, 170);
            this.groupIdentifierAssemblers.Name = "groupIdentifierAssemblers";
            this.groupIdentifierAssemblers.Size = new System.Drawing.Size(366, 73);
            this.groupIdentifierAssemblers.TabIndex = 23;
            this.groupIdentifierAssemblers.TabStop = false;
            this.groupIdentifierAssemblers.Text = "Identifier";
            // 
            // txtAssemblerIdentifierWord
            // 
            this.txtAssemblerIdentifierWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssemblerIdentifierWord.Location = new System.Drawing.Point(45, 42);
            this.txtAssemblerIdentifierWord.Name = "txtAssemblerIdentifierWord";
            this.txtAssemblerIdentifierWord.Size = new System.Drawing.Size(315, 20);
            this.txtAssemblerIdentifierWord.TabIndex = 4;
            this.txtAssemblerIdentifierWord.Text = "Assembler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Word";
            // 
            // rbAssemblerIdentifierSuffix
            // 
            this.rbAssemblerIdentifierSuffix.AutoSize = true;
            this.rbAssemblerIdentifierSuffix.Checked = true;
            this.rbAssemblerIdentifierSuffix.Location = new System.Drawing.Point(171, 19);
            this.rbAssemblerIdentifierSuffix.Name = "rbAssemblerIdentifierSuffix";
            this.rbAssemblerIdentifierSuffix.Size = new System.Drawing.Size(51, 17);
            this.rbAssemblerIdentifierSuffix.TabIndex = 2;
            this.rbAssemblerIdentifierSuffix.TabStop = true;
            this.rbAssemblerIdentifierSuffix.Text = "Suffix";
            this.rbAssemblerIdentifierSuffix.UseVisualStyleBackColor = true;
            // 
            // rbAssemblerIdentifierPrefix
            // 
            this.rbAssemblerIdentifierPrefix.AutoSize = true;
            this.rbAssemblerIdentifierPrefix.Location = new System.Drawing.Point(91, 19);
            this.rbAssemblerIdentifierPrefix.Name = "rbAssemblerIdentifierPrefix";
            this.rbAssemblerIdentifierPrefix.Size = new System.Drawing.Size(51, 17);
            this.rbAssemblerIdentifierPrefix.TabIndex = 1;
            this.rbAssemblerIdentifierPrefix.Text = "Prefix";
            this.rbAssemblerIdentifierPrefix.UseVisualStyleBackColor = true;
            // 
            // rbAssemblerIdentifierNone
            // 
            this.rbAssemblerIdentifierNone.AutoSize = true;
            this.rbAssemblerIdentifierNone.Location = new System.Drawing.Point(6, 19);
            this.rbAssemblerIdentifierNone.Name = "rbAssemblerIdentifierNone";
            this.rbAssemblerIdentifierNone.Size = new System.Drawing.Size(51, 17);
            this.rbAssemblerIdentifierNone.TabIndex = 0;
            this.rbAssemblerIdentifierNone.Text = "None";
            this.rbAssemblerIdentifierNone.UseVisualStyleBackColor = true;
            this.rbAssemblerIdentifierNone.CheckedChanged += new System.EventHandler(this.rbAssemblerIdentifierNone_CheckedChanged);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.groupBox5);
            this.tabGeneral.Controls.Add(this.menuStrip1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(620, 334);
            this.tabGeneral.TabIndex = 3;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(646, 408);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCancel);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "MainWindows";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntitiesToDTOs - Entity Framework DTO Generator - v{0}";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupGenerationTypeAssemblers.ResumeLayout(false);
            this.groupGenerationTypeAssemblers.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).EndInit();
            this.tabDTOs.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabAssemblers.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupIdentifierAssemblers.ResumeLayout(false);
            this.groupIdentifierAssemblers.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEntitySources;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox cbUseDefaultNamespaceDTOs;
        private System.Windows.Forms.TextBox txtNamespaceDTOs;
        private System.Windows.Forms.CheckBox cbServiceReadyDTOs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOneSourceFileDTOs;
        private System.Windows.Forms.RadioButton rbSourceFilePerClassDTOs;
        private System.Windows.Forms.TextBox txtSourceFileNameDTOs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAssociationConfigUseKeyProperty;
        private System.Windows.Forms.RadioButton rbAssociationConfigUseClassTypes;
        private System.Windows.Forms.RichTextBox txtCustomHeaderComment;
        private System.Windows.Forms.CheckBox cbCustomHeaderComment;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckBox cbGenerateAssemblers;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbUseDefaultNamespaceAssemblers;
        private System.Windows.Forms.TextBox txtNamespaceAssemblers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupGenerationTypeAssemblers;
        private System.Windows.Forms.RadioButton rbOneSourceFileAssemblers;
        private System.Windows.Forms.RadioButton rbSourceFilePerClassAssemblers;
        private System.Windows.Forms.TextBox txtSourceFileNameAssemblers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbGenerateDTOConstructors;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.TabPage tabDTOs;
        private System.Windows.Forms.TabPage tabAssemblers;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbGenerateEntityTypes;
        private System.Windows.Forms.CheckBox chbGenerateComplexTypes;
        private System.Windows.Forms.CheckBox chbGenerateAllTypes;
        private System.Windows.Forms.DataGridView dgvTypes;
        private System.Windows.Forms.RadioButton rbSourceProject;
        private System.Windows.Forms.RadioButton rbSourceEdmx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDTOIdentifierWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDTOIdentifierSuffix;
        private System.Windows.Forms.RadioButton rbDTOIdentifierPrefix;
        private System.Windows.Forms.RadioButton rbDTOIdentifierNone;
        private System.Windows.Forms.GroupBox groupIdentifierAssemblers;
        private System.Windows.Forms.TextBox txtAssemblerIdentifierWord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbAssemblerIdentifierSuffix;
        private System.Windows.Forms.RadioButton rbAssemblerIdentifierPrefix;
        private System.Windows.Forms.RadioButton rbAssemblerIdentifierNone;
        private System.Windows.Forms.TreeView treeTargetDTOs;
        private System.Windows.Forms.TreeView treeTargetAssemblers;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewImageColumn colWarnings;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGenerateType;
    }
}