namespace CoreBuildInternshipProblem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.heroLife = new System.Windows.Forms.Label();
            this.villainLife = new System.Windows.Forms.Label();
            this.warButton = new System.Windows.Forms.Button();
            this.heroComboBox = new System.Windows.Forms.ComboBox();
            this.villainComboBox = new System.Windows.Forms.ComboBox();
            this.planetComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.avengersList = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadCharactersFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadPlanetsFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadCharactersFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadPlanetsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a superhero";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose a villain";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose a planet";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Villan health";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Superhero health";
            // 
            // heroLife
            // 
            this.heroLife.BackColor = System.Drawing.Color.Transparent;
            this.heroLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroLife.Location = new System.Drawing.Point(481, 56);
            this.heroLife.Name = "heroLife";
            this.heroLife.Size = new System.Drawing.Size(61, 28);
            this.heroLife.TabIndex = 5;
            this.heroLife.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // villainLife
            // 
            this.villainLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villainLife.Location = new System.Drawing.Point(690, 60);
            this.villainLife.Name = "villainLife";
            this.villainLife.Size = new System.Drawing.Size(47, 23);
            this.villainLife.TabIndex = 6;
            // 
            // warButton
            // 
            this.warButton.Location = new System.Drawing.Point(63, 146);
            this.warButton.Name = "warButton";
            this.warButton.Size = new System.Drawing.Size(75, 23);
            this.warButton.TabIndex = 7;
            this.warButton.Text = "Battle";
            this.warButton.UseVisualStyleBackColor = true;
            this.warButton.Click += new System.EventHandler(this.warButton_Click);
            // 
            // heroComboBox
            // 
            this.heroComboBox.FormattingEnabled = true;
            this.heroComboBox.Location = new System.Drawing.Point(206, 33);
            this.heroComboBox.Name = "heroComboBox";
            this.heroComboBox.Size = new System.Drawing.Size(121, 21);
            this.heroComboBox.TabIndex = 8;
            this.heroComboBox.SelectedIndexChanged += new System.EventHandler(this.heroComboBox_SelectedIndexChanged);
            // 
            // villainComboBox
            // 
            this.villainComboBox.FormattingEnabled = true;
            this.villainComboBox.Location = new System.Drawing.Point(206, 65);
            this.villainComboBox.Name = "villainComboBox";
            this.villainComboBox.Size = new System.Drawing.Size(121, 21);
            this.villainComboBox.TabIndex = 9;
            this.villainComboBox.SelectedIndexChanged += new System.EventHandler(this.villainComboBox_SelectedIndexChanged);
            // 
            // planetComboBox
            // 
            this.planetComboBox.FormattingEnabled = true;
            this.planetComboBox.Location = new System.Drawing.Point(206, 100);
            this.planetComboBox.Name = "planetComboBox";
            this.planetComboBox.Size = new System.Drawing.Size(121, 21);
            this.planetComboBox.TabIndex = 10;
            this.planetComboBox.SelectedIndexChanged += new System.EventHandler(this.planetComboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 101);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 268);
            this.textBox1.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(369, 60);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(109, 28);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(575, 60);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(109, 28);
            this.progressBar2.TabIndex = 13;
            this.progressBar2.Value = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Call Avengers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // avengersList
            // 
            this.avengersList.Location = new System.Drawing.Point(63, 180);
            this.avengersList.Multiline = true;
            this.avengersList.Name = "avengersList";
            this.avengersList.Size = new System.Drawing.Size(287, 189);
            this.avengersList.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadCharactersFileToolStripMenuItem1,
            this.uploadPlanetsFileToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // uploadCharactersFileToolStripMenuItem1
            // 
            this.uploadCharactersFileToolStripMenuItem1.Name = "uploadCharactersFileToolStripMenuItem1";
            this.uploadCharactersFileToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.uploadCharactersFileToolStripMenuItem1.Text = "Upload characters file";
            this.uploadCharactersFileToolStripMenuItem1.Click += new System.EventHandler(this.uploadCharactersFileToolStripMenuItem1_Click);
            // 
            // uploadPlanetsFileToolStripMenuItem1
            // 
            this.uploadPlanetsFileToolStripMenuItem1.Name = "uploadPlanetsFileToolStripMenuItem1";
            this.uploadPlanetsFileToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.uploadPlanetsFileToolStripMenuItem1.Text = "Upload planets  file";
            this.uploadPlanetsFileToolStripMenuItem1.Click += new System.EventHandler(this.uploadPlanetsFileToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // uploadCharactersFileToolStripMenuItem
            // 
            this.uploadCharactersFileToolStripMenuItem.Name = "uploadCharactersFileToolStripMenuItem";
            this.uploadCharactersFileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // uploadPlanetsFileToolStripMenuItem
            // 
            this.uploadPlanetsFileToolStripMenuItem.Name = "uploadPlanetsFileToolStripMenuItem";
            this.uploadPlanetsFileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.avengersList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.heroLife);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.planetComboBox);
            this.Controls.Add(this.villainComboBox);
            this.Controls.Add(this.heroComboBox);
            this.Controls.Add(this.warButton);
            this.Controls.Add(this.villainLife);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Avengers Battle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label heroLife;
        private System.Windows.Forms.Label villainLife;
        private System.Windows.Forms.Button warButton;
        private System.Windows.Forms.ComboBox heroComboBox;
        private System.Windows.Forms.ComboBox villainComboBox;
        private System.Windows.Forms.ComboBox planetComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox avengersList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadCharactersFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadPlanetsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uploadCharactersFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uploadPlanetsFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

