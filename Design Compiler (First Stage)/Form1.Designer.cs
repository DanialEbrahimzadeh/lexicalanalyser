namespace Design_Compiler__First_Stage_
{
    partial class Form1
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
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpenSourceStartButton = new System.Windows.Forms.Button();
            this.OpenSourceFilePanel = new System.Windows.Forms.Panel();
            this.OpenSourcePathLabel = new System.Windows.Forms.Label();
            this.OpenSourceBrowseButton = new System.Windows.Forms.Button();
            this.OpenSourceMessageLabel = new System.Windows.Forms.Label();
            this.OpenSourceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultFilesPhase1Button = new System.Windows.Forms.Button();
            this.ResultFilesErrorsButton = new System.Windows.Forms.Button();
            this.ResultFilesMessageLabel = new System.Windows.Forms.Label();
            this.ResultFileLabel = new System.Windows.Forms.Label();
            this.ResultFilesSymbleTableButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ScannerButton = new System.Windows.Forms.Button();
            this.SemanticButton = new System.Windows.Forms.Button();
            this.ScannerPanel = new System.Windows.Forms.Panel();
            this.ResultFilesErrorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ResultFilesPhase1RichTextBox = new System.Windows.Forms.RichTextBox();
            this.ResultFilesSymbleTableRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ResultFilesSorceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ResultFilesSourceButton = new System.Windows.Forms.Button();
            this.OpenSourceFilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.ScannerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(1186, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 8;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Transparent;
            this.RestartButton.FlatAppearance.BorderSize = 0;
            this.RestartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Location = new System.Drawing.Point(1222, 12);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(30, 30);
            this.RestartButton.TabIndex = 7;
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(1258, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OpenSourceStartButton
            // 
            this.OpenSourceStartButton.FlatAppearance.BorderSize = 0;
            this.OpenSourceStartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OpenSourceStartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.OpenSourceStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSourceStartButton.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OpenSourceStartButton.ForeColor = System.Drawing.Color.White;
            this.OpenSourceStartButton.Location = new System.Drawing.Point(6, 65);
            this.OpenSourceStartButton.Name = "OpenSourceStartButton";
            this.OpenSourceStartButton.Size = new System.Drawing.Size(102, 39);
            this.OpenSourceStartButton.TabIndex = 34;
            this.OpenSourceStartButton.Text = "Start";
            this.OpenSourceStartButton.UseVisualStyleBackColor = true;
            this.OpenSourceStartButton.Click += new System.EventHandler(this.OpenSourceStartButton_Click);
            this.OpenSourceStartButton.MouseLeave += new System.EventHandler(this.OpenSourceStartButton_MouseLeave);
            this.OpenSourceStartButton.MouseHover += new System.EventHandler(this.OpenSourceStartButton_MouseHover);
            // 
            // OpenSourceFilePanel
            // 
            this.OpenSourceFilePanel.BackColor = System.Drawing.Color.Transparent;
            this.OpenSourceFilePanel.Controls.Add(this.OpenSourcePathLabel);
            this.OpenSourceFilePanel.Controls.Add(this.OpenSourceBrowseButton);
            this.OpenSourceFilePanel.Controls.Add(this.OpenSourceMessageLabel);
            this.OpenSourceFilePanel.Controls.Add(this.OpenSourceLabel);
            this.OpenSourceFilePanel.Controls.Add(this.OpenSourceStartButton);
            this.OpenSourceFilePanel.Location = new System.Drawing.Point(218, 29);
            this.OpenSourceFilePanel.Name = "OpenSourceFilePanel";
            this.OpenSourceFilePanel.Size = new System.Drawing.Size(922, 111);
            this.OpenSourceFilePanel.TabIndex = 35;
            // 
            // OpenSourcePathLabel
            // 
            this.OpenSourcePathLabel.AutoSize = true;
            this.OpenSourcePathLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OpenSourcePathLabel.Location = new System.Drawing.Point(222, 77);
            this.OpenSourcePathLabel.Name = "OpenSourcePathLabel";
            this.OpenSourcePathLabel.Size = new System.Drawing.Size(0, 21);
            this.OpenSourcePathLabel.TabIndex = 38;
            // 
            // OpenSourceBrowseButton
            // 
            this.OpenSourceBrowseButton.FlatAppearance.BorderSize = 0;
            this.OpenSourceBrowseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OpenSourceBrowseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.OpenSourceBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSourceBrowseButton.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OpenSourceBrowseButton.ForeColor = System.Drawing.Color.White;
            this.OpenSourceBrowseButton.Location = new System.Drawing.Point(114, 65);
            this.OpenSourceBrowseButton.Name = "OpenSourceBrowseButton";
            this.OpenSourceBrowseButton.Size = new System.Drawing.Size(102, 39);
            this.OpenSourceBrowseButton.TabIndex = 37;
            this.OpenSourceBrowseButton.Text = "Browse";
            this.OpenSourceBrowseButton.UseVisualStyleBackColor = true;
            this.OpenSourceBrowseButton.Click += new System.EventHandler(this.OpenSourceBrowseButton_Click);
            this.OpenSourceBrowseButton.MouseLeave += new System.EventHandler(this.OpenSourceBrowseButton_MouseLeave);
            this.OpenSourceBrowseButton.MouseHover += new System.EventHandler(this.OpenSourceBrowseButton_MouseHover);
            // 
            // OpenSourceMessageLabel
            // 
            this.OpenSourceMessageLabel.AutoSize = true;
            this.OpenSourceMessageLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OpenSourceMessageLabel.ForeColor = System.Drawing.Color.White;
            this.OpenSourceMessageLabel.Location = new System.Drawing.Point(6, 32);
            this.OpenSourceMessageLabel.Name = "OpenSourceMessageLabel";
            this.OpenSourceMessageLabel.Size = new System.Drawing.Size(309, 30);
            this.OpenSourceMessageLabel.TabIndex = 36;
            this.OpenSourceMessageLabel.Text = "Browse the source file to compile.";
            // 
            // OpenSourceLabel
            // 
            this.OpenSourceLabel.AutoSize = true;
            this.OpenSourceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OpenSourceLabel.ForeColor = System.Drawing.Color.White;
            this.OpenSourceLabel.Location = new System.Drawing.Point(0, 0);
            this.OpenSourceLabel.Name = "OpenSourceLabel";
            this.OpenSourceLabel.Size = new System.Drawing.Size(198, 32);
            this.OpenSourceLabel.TabIndex = 35;
            this.OpenSourceLabel.Text = "Open Source File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 667);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 37;
            this.label1.Text = "Message Line :";
            // 
            // ResultFilesPhase1Button
            // 
            this.ResultFilesPhase1Button.FlatAppearance.BorderSize = 0;
            this.ResultFilesPhase1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResultFilesPhase1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResultFilesPhase1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultFilesPhase1Button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResultFilesPhase1Button.ForeColor = System.Drawing.Color.White;
            this.ResultFilesPhase1Button.Location = new System.Drawing.Point(568, 82);
            this.ResultFilesPhase1Button.Name = "ResultFilesPhase1Button";
            this.ResultFilesPhase1Button.Size = new System.Drawing.Size(110, 39);
            this.ResultFilesPhase1Button.TabIndex = 38;
            this.ResultFilesPhase1Button.Text = "Phase 1";
            this.ResultFilesPhase1Button.UseVisualStyleBackColor = true;
            this.ResultFilesPhase1Button.Click += new System.EventHandler(this.ResultFilesPhase1Button_Click);
            this.ResultFilesPhase1Button.MouseLeave += new System.EventHandler(this.ResultFilesPhase1Button_MouseLeave);
            this.ResultFilesPhase1Button.MouseHover += new System.EventHandler(this.ResultFilesPhase1Button_MouseHover);
            // 
            // ResultFilesErrorsButton
            // 
            this.ResultFilesErrorsButton.FlatAppearance.BorderSize = 0;
            this.ResultFilesErrorsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResultFilesErrorsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResultFilesErrorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultFilesErrorsButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResultFilesErrorsButton.ForeColor = System.Drawing.Color.White;
            this.ResultFilesErrorsButton.Location = new System.Drawing.Point(892, 82);
            this.ResultFilesErrorsButton.Name = "ResultFilesErrorsButton";
            this.ResultFilesErrorsButton.Size = new System.Drawing.Size(84, 39);
            this.ResultFilesErrorsButton.TabIndex = 37;
            this.ResultFilesErrorsButton.Text = "Errors";
            this.ResultFilesErrorsButton.UseVisualStyleBackColor = true;
            this.ResultFilesErrorsButton.Click += new System.EventHandler(this.ResultFilesErrorsButton_Click);
            this.ResultFilesErrorsButton.MouseLeave += new System.EventHandler(this.ResultFilesErrorsButton_MouseLeave);
            this.ResultFilesErrorsButton.MouseHover += new System.EventHandler(this.ResultFilesErrorsButton_MouseHover);
            // 
            // ResultFilesMessageLabel
            // 
            this.ResultFilesMessageLabel.AutoSize = true;
            this.ResultFilesMessageLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResultFilesMessageLabel.ForeColor = System.Drawing.Color.White;
            this.ResultFilesMessageLabel.Location = new System.Drawing.Point(25, 43);
            this.ResultFilesMessageLabel.Name = "ResultFilesMessageLabel";
            this.ResultFilesMessageLabel.Size = new System.Drawing.Size(451, 30);
            this.ResultFilesMessageLabel.TabIndex = 36;
            this.ResultFilesMessageLabel.Text = "In this part, you can see the result files of compile.";
            // 
            // ResultFileLabel
            // 
            this.ResultFileLabel.AutoSize = true;
            this.ResultFileLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResultFileLabel.ForeColor = System.Drawing.Color.White;
            this.ResultFileLabel.Location = new System.Drawing.Point(24, 11);
            this.ResultFileLabel.Name = "ResultFileLabel";
            this.ResultFileLabel.Size = new System.Drawing.Size(134, 32);
            this.ResultFileLabel.TabIndex = 35;
            this.ResultFileLabel.Text = "Result Files";
            // 
            // ResultFilesSymbleTableButton
            // 
            this.ResultFilesSymbleTableButton.FlatAppearance.BorderSize = 0;
            this.ResultFilesSymbleTableButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResultFilesSymbleTableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResultFilesSymbleTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultFilesSymbleTableButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResultFilesSymbleTableButton.ForeColor = System.Drawing.Color.White;
            this.ResultFilesSymbleTableButton.Location = new System.Drawing.Point(320, 82);
            this.ResultFilesSymbleTableButton.Name = "ResultFilesSymbleTableButton";
            this.ResultFilesSymbleTableButton.Size = new System.Drawing.Size(169, 39);
            this.ResultFilesSymbleTableButton.TabIndex = 34;
            this.ResultFilesSymbleTableButton.Text = "Symble Table";
            this.ResultFilesSymbleTableButton.UseVisualStyleBackColor = true;
            this.ResultFilesSymbleTableButton.Click += new System.EventHandler(this.ResultFilesSymbleTableButton_Click);
            this.ResultFilesSymbleTableButton.MouseLeave += new System.EventHandler(this.ResultFilesSymbleTableButton_MouseLeave);
            this.ResultFilesSymbleTableButton.MouseHover += new System.EventHandler(this.ResultFilesSymbleTableButton_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(140, 667);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 30);
            this.label2.TabIndex = 39;
            this.label2.Text = "...";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 14);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(200, 140);
            this.LogoPictureBox.TabIndex = 40;
            this.LogoPictureBox.TabStop = false;
            // 
            // ScannerButton
            // 
            this.ScannerButton.BackColor = System.Drawing.Color.Transparent;
            this.ScannerButton.FlatAppearance.BorderSize = 0;
            this.ScannerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ScannerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ScannerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScannerButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ScannerButton.ForeColor = System.Drawing.Color.White;
            this.ScannerButton.Location = new System.Drawing.Point(21, 174);
            this.ScannerButton.Name = "ScannerButton";
            this.ScannerButton.Size = new System.Drawing.Size(125, 48);
            this.ScannerButton.TabIndex = 41;
            this.ScannerButton.Text = "Scanner";
            this.ScannerButton.UseVisualStyleBackColor = false;
            this.ScannerButton.Click += new System.EventHandler(this.ScannerButton_Click);
            this.ScannerButton.MouseLeave += new System.EventHandler(this.ScannerButton_MouseLeave);
            this.ScannerButton.MouseHover += new System.EventHandler(this.ScannerButton_MouseHover);
            // 
            // SemanticButton
            // 
            this.SemanticButton.BackColor = System.Drawing.Color.Transparent;
            this.SemanticButton.FlatAppearance.BorderSize = 0;
            this.SemanticButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SemanticButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SemanticButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SemanticButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SemanticButton.ForeColor = System.Drawing.Color.White;
            this.SemanticButton.Location = new System.Drawing.Point(152, 174);
            this.SemanticButton.Name = "SemanticButton";
            this.SemanticButton.Size = new System.Drawing.Size(141, 48);
            this.SemanticButton.TabIndex = 42;
            this.SemanticButton.Text = "Semantic";
            this.SemanticButton.UseVisualStyleBackColor = false;
            this.SemanticButton.Click += new System.EventHandler(this.SemanticButton_Click);
            this.SemanticButton.MouseLeave += new System.EventHandler(this.SemanticButton_MouseLeave);
            this.SemanticButton.MouseHover += new System.EventHandler(this.SemanticButton_MouseHover);
            // 
            // ScannerPanel
            // 
            this.ScannerPanel.BackColor = System.Drawing.Color.Transparent;
            this.ScannerPanel.Controls.Add(this.ResultFilesErrorRichTextBox);
            this.ScannerPanel.Controls.Add(this.ResultFilesPhase1RichTextBox);
            this.ScannerPanel.Controls.Add(this.ResultFilesSymbleTableRichTextBox);
            this.ScannerPanel.Controls.Add(this.ResultFilesSorceRichTextBox);
            this.ScannerPanel.Controls.Add(this.ResultFilesSourceButton);
            this.ScannerPanel.Controls.Add(this.ResultFilesPhase1Button);
            this.ScannerPanel.Controls.Add(this.ResultFilesErrorsButton);
            this.ScannerPanel.Controls.Add(this.ResultFilesMessageLabel);
            this.ScannerPanel.Controls.Add(this.ResultFileLabel);
            this.ScannerPanel.Controls.Add(this.ResultFilesSymbleTableButton);
            this.ScannerPanel.Location = new System.Drawing.Point(50, 228);
            this.ScannerPanel.Name = "ScannerPanel";
            this.ScannerPanel.Size = new System.Drawing.Size(1200, 436);
            this.ScannerPanel.TabIndex = 43;
            // 
            // ResultFilesErrorRichTextBox
            // 
            this.ResultFilesErrorRichTextBox.BackColor = System.Drawing.Color.Black;
            this.ResultFilesErrorRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultFilesErrorRichTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResultFilesErrorRichTextBox.ForeColor = System.Drawing.Color.Gold;
            this.ResultFilesErrorRichTextBox.Location = new System.Drawing.Point(892, 130);
            this.ResultFilesErrorRichTextBox.Name = "ResultFilesErrorRichTextBox";
            this.ResultFilesErrorRichTextBox.Size = new System.Drawing.Size(274, 281);
            this.ResultFilesErrorRichTextBox.TabIndex = 44;
            this.ResultFilesErrorRichTextBox.Text = "";
            this.ResultFilesErrorRichTextBox.Visible = false;
            // 
            // ResultFilesPhase1RichTextBox
            // 
            this.ResultFilesPhase1RichTextBox.BackColor = System.Drawing.Color.Black;
            this.ResultFilesPhase1RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultFilesPhase1RichTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResultFilesPhase1RichTextBox.ForeColor = System.Drawing.Color.Gold;
            this.ResultFilesPhase1RichTextBox.Location = new System.Drawing.Point(568, 130);
            this.ResultFilesPhase1RichTextBox.Name = "ResultFilesPhase1RichTextBox";
            this.ResultFilesPhase1RichTextBox.Size = new System.Drawing.Size(302, 281);
            this.ResultFilesPhase1RichTextBox.TabIndex = 43;
            this.ResultFilesPhase1RichTextBox.Text = "";
            this.ResultFilesPhase1RichTextBox.Visible = false;
            // 
            // ResultFilesSymbleTableRichTextBox
            // 
            this.ResultFilesSymbleTableRichTextBox.BackColor = System.Drawing.Color.Black;
            this.ResultFilesSymbleTableRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultFilesSymbleTableRichTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResultFilesSymbleTableRichTextBox.ForeColor = System.Drawing.Color.Gold;
            this.ResultFilesSymbleTableRichTextBox.Location = new System.Drawing.Point(320, 129);
            this.ResultFilesSymbleTableRichTextBox.Name = "ResultFilesSymbleTableRichTextBox";
            this.ResultFilesSymbleTableRichTextBox.Size = new System.Drawing.Size(225, 281);
            this.ResultFilesSymbleTableRichTextBox.TabIndex = 42;
            this.ResultFilesSymbleTableRichTextBox.Text = "";
            this.ResultFilesSymbleTableRichTextBox.Visible = false;
            // 
            // ResultFilesSorceRichTextBox
            // 
            this.ResultFilesSorceRichTextBox.BackColor = System.Drawing.Color.Black;
            this.ResultFilesSorceRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultFilesSorceRichTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResultFilesSorceRichTextBox.ForeColor = System.Drawing.Color.Gold;
            this.ResultFilesSorceRichTextBox.Location = new System.Drawing.Point(23, 130);
            this.ResultFilesSorceRichTextBox.Name = "ResultFilesSorceRichTextBox";
            this.ResultFilesSorceRichTextBox.Size = new System.Drawing.Size(274, 281);
            this.ResultFilesSorceRichTextBox.TabIndex = 41;
            this.ResultFilesSorceRichTextBox.Text = "";
            this.ResultFilesSorceRichTextBox.Visible = false;
            // 
            // ResultFilesSourceButton
            // 
            this.ResultFilesSourceButton.FlatAppearance.BorderSize = 0;
            this.ResultFilesSourceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResultFilesSourceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResultFilesSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultFilesSourceButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResultFilesSourceButton.ForeColor = System.Drawing.Color.White;
            this.ResultFilesSourceButton.Location = new System.Drawing.Point(23, 82);
            this.ResultFilesSourceButton.Name = "ResultFilesSourceButton";
            this.ResultFilesSourceButton.Size = new System.Drawing.Size(98, 39);
            this.ResultFilesSourceButton.TabIndex = 40;
            this.ResultFilesSourceButton.Text = "Source";
            this.ResultFilesSourceButton.UseVisualStyleBackColor = true;
            this.ResultFilesSourceButton.Click += new System.EventHandler(this.ResultFilesSourceButton_Click);
            this.ResultFilesSourceButton.MouseLeave += new System.EventHandler(this.ResultFilesSourceButton_MouseLeave);
            this.ResultFilesSourceButton.MouseHover += new System.EventHandler(this.ResultFilesSourceButton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.ScannerPanel);
            this.Controls.Add(this.SemanticButton);
            this.Controls.Add(this.ScannerButton);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenSourceFilePanel);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.OpenSourceFilePanel.ResumeLayout(false);
            this.OpenSourceFilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ScannerPanel.ResumeLayout(false);
            this.ScannerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OpenSourceStartButton;
        private System.Windows.Forms.Panel OpenSourceFilePanel;
        private System.Windows.Forms.Label OpenSourceLabel;
        private System.Windows.Forms.Label OpenSourceMessageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenSourceBrowseButton;
        private System.Windows.Forms.Label ResultFilesMessageLabel;
        private System.Windows.Forms.Label ResultFileLabel;
        private System.Windows.Forms.Button ResultFilesSymbleTableButton;
        private System.Windows.Forms.Button ResultFilesPhase1Button;
        private System.Windows.Forms.Button ResultFilesErrorsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OpenSourcePathLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button ScannerButton;
        private System.Windows.Forms.Button SemanticButton;
        private System.Windows.Forms.Panel ScannerPanel;
        private System.Windows.Forms.Button ResultFilesSourceButton;
        private System.Windows.Forms.RichTextBox ResultFilesSorceRichTextBox;
        private System.Windows.Forms.RichTextBox ResultFilesErrorRichTextBox;
        private System.Windows.Forms.RichTextBox ResultFilesPhase1RichTextBox;
        private System.Windows.Forms.RichTextBox ResultFilesSymbleTableRichTextBox;
    }
}

