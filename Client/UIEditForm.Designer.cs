namespace Client
{
    partial class UIEditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReloadBtn = new System.Windows.Forms.Button();
            this.ControlsTree = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UniqueNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IndexTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LibFilesSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PositionYTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PositionXTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UIConfigKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddAndSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReloadBtn);
            this.groupBox1.Controls.Add(this.ControlsTree);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.Location = new System.Drawing.Point(7, 385);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(282, 23);
            this.ReloadBtn.TabIndex = 1;
            this.ReloadBtn.Text = "Reload Controls";
            this.ReloadBtn.UseVisualStyleBackColor = true;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // ControlsTree
            // 
            this.ControlsTree.Location = new System.Drawing.Point(6, 20);
            this.ControlsTree.Name = "ControlsTree";
            this.ControlsTree.Size = new System.Drawing.Size(283, 359);
            this.ControlsTree.TabIndex = 0;
            this.ControlsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ControlsTree_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddAndSave);
            this.groupBox2.Controls.Add(this.UniqueNameTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.IndexTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.LibFilesSelect);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PositionYTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PositionXTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.UIConfigKeyTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(322, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // UniqueNameTextBox
            // 
            this.UniqueNameTextBox.Location = new System.Drawing.Point(97, 47);
            this.UniqueNameTextBox.Name = "UniqueNameTextBox";
            this.UniqueNameTextBox.ReadOnly = true;
            this.UniqueNameTextBox.Size = new System.Drawing.Size(224, 21);
            this.UniqueNameTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Unique Name";
            // 
            // IndexTextBox
            // 
            this.IndexTextBox.Location = new System.Drawing.Point(266, 107);
            this.IndexTextBox.Name = "IndexTextBox";
            this.IndexTextBox.Size = new System.Drawing.Size(100, 21);
            this.IndexTextBox.TabIndex = 9;
            this.IndexTextBox.TextChanged += new System.EventHandler(this.IndexTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Index";
            // 
            // LibFilesSelect
            // 
            this.LibFilesSelect.FormattingEnabled = true;
            this.LibFilesSelect.Location = new System.Drawing.Point(97, 108);
            this.LibFilesSelect.Name = "LibFilesSelect";
            this.LibFilesSelect.Size = new System.Drawing.Size(121, 20);
            this.LibFilesSelect.TabIndex = 7;
            this.LibFilesSelect.SelectedIndexChanged += new System.EventHandler(this.LibFilesSelect_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lib File";
            // 
            // PositionYTextBox
            // 
            this.PositionYTextBox.Location = new System.Drawing.Point(217, 76);
            this.PositionYTextBox.Name = "PositionYTextBox";
            this.PositionYTextBox.Size = new System.Drawing.Size(43, 21);
            this.PositionYTextBox.TabIndex = 5;
            this.PositionYTextBox.TextChanged += new System.EventHandler(this.PositionYTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Position Y";
            // 
            // PositionXTextBox
            // 
            this.PositionXTextBox.Location = new System.Drawing.Point(97, 76);
            this.PositionXTextBox.Name = "PositionXTextBox";
            this.PositionXTextBox.Size = new System.Drawing.Size(43, 21);
            this.PositionXTextBox.TabIndex = 3;
            this.PositionXTextBox.TextChanged += new System.EventHandler(this.PositionXTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position X";
            // 
            // UIConfigKeyTextBox
            // 
            this.UIConfigKeyTextBox.Location = new System.Drawing.Point(97, 20);
            this.UIConfigKeyTextBox.Name = "UIConfigKeyTextBox";
            this.UIConfigKeyTextBox.ReadOnly = true;
            this.UIConfigKeyTextBox.Size = new System.Drawing.Size(363, 21);
            this.UIConfigKeyTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "UI Config Key";
            // 
            // AddAndSave
            // 
            this.AddAndSave.Location = new System.Drawing.Point(10, 385);
            this.AddAndSave.Name = "AddAndSave";
            this.AddAndSave.Size = new System.Drawing.Size(208, 23);
            this.AddAndSave.TabIndex = 12;
            this.AddAndSave.Text = "Add And Save Override";
            this.AddAndSave.UseVisualStyleBackColor = true;
            this.AddAndSave.Click += new System.EventHandler(this.AddAndSave_Click);
            // 
            // UIEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UIEditForm";
            this.Text = "UIEditForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView ControlsTree;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox LibFilesSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PositionYTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PositionXTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UIConfigKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IndexTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ReloadBtn;
        private System.Windows.Forms.TextBox UniqueNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddAndSave;
    }
}