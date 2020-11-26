namespace GroupProjectIdea
{
    partial class ProjectView
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
            this.labelProjectName = new System.Windows.Forms.Label();
            this.textBoxMembers = new System.Windows.Forms.TextBox();
            this.listMembers = new System.Windows.Forms.ListBox();
            this.listFunctionalities = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.buttonAddMembers = new System.Windows.Forms.Button();
            this.buttonAdd4 = new System.Windows.Forms.Button();
            this.buttonAddFunctionalities = new System.Windows.Forms.Button();
            this.buttonAdd3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxFunctionalities = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Location = new System.Drawing.Point(628, 9);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(63, 13);
            this.labelProjectName.TabIndex = 0;
            this.labelProjectName.Text = "ProjectView";
            this.labelProjectName.Click += new System.EventHandler(this.labelProjectName_Click);
            // 
            // textBoxMembers
            // 
            this.textBoxMembers.Location = new System.Drawing.Point(10, 40);
            this.textBoxMembers.Name = "textBoxMembers";
            this.textBoxMembers.Size = new System.Drawing.Size(289, 20);
            this.textBoxMembers.TabIndex = 1;
            // 
            // listMembers
            // 
            this.listMembers.FormattingEnabled = true;
            this.listMembers.Location = new System.Drawing.Point(10, 66);
            this.listMembers.Name = "listMembers";
            this.listMembers.Size = new System.Drawing.Size(289, 511);
            this.listMembers.TabIndex = 2;
            this.listMembers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listMembers_MouseDoubleClick);
            // 
            // listFunctionalities
            // 
            this.listFunctionalities.FormattingEnabled = true;
            this.listFunctionalities.Location = new System.Drawing.Point(347, 66);
            this.listFunctionalities.Name = "listFunctionalities";
            this.listFunctionalities.Size = new System.Drawing.Size(289, 511);
            this.listFunctionalities.TabIndex = 3;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(683, 66);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(289, 511);
            this.listBox3.TabIndex = 3;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(1006, 66);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(289, 511);
            this.listBox4.TabIndex = 3;
            // 
            // buttonAddMembers
            // 
            this.buttonAddMembers.Location = new System.Drawing.Point(10, 583);
            this.buttonAddMembers.Name = "buttonAddMembers";
            this.buttonAddMembers.Size = new System.Drawing.Size(289, 23);
            this.buttonAddMembers.TabIndex = 4;
            this.buttonAddMembers.Text = "Add";
            this.buttonAddMembers.UseVisualStyleBackColor = true;
            this.buttonAddMembers.Click += new System.EventHandler(this.buttonAddMembers_Click);
            // 
            // buttonAdd4
            // 
            this.buttonAdd4.Location = new System.Drawing.Point(1006, 583);
            this.buttonAdd4.Name = "buttonAdd4";
            this.buttonAdd4.Size = new System.Drawing.Size(289, 23);
            this.buttonAdd4.TabIndex = 5;
            this.buttonAdd4.Text = "Add";
            this.buttonAdd4.UseVisualStyleBackColor = true;
            // 
            // buttonAddFunctionalities
            // 
            this.buttonAddFunctionalities.Location = new System.Drawing.Point(347, 583);
            this.buttonAddFunctionalities.Name = "buttonAddFunctionalities";
            this.buttonAddFunctionalities.Size = new System.Drawing.Size(289, 23);
            this.buttonAddFunctionalities.TabIndex = 5;
            this.buttonAddFunctionalities.Text = "Add";
            this.buttonAddFunctionalities.UseVisualStyleBackColor = true;
            // 
            // buttonAdd3
            // 
            this.buttonAdd3.Location = new System.Drawing.Point(683, 583);
            this.buttonAdd3.Name = "buttonAdd3";
            this.buttonAdd3.Size = new System.Drawing.Size(289, 23);
            this.buttonAdd3.TabIndex = 6;
            this.buttonAdd3.Text = "Add";
            this.buttonAdd3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(683, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(289, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBoxFunctionalities
            // 
            this.textBoxFunctionalities.Location = new System.Drawing.Point(347, 40);
            this.textBoxFunctionalities.Name = "textBoxFunctionalities";
            this.textBoxFunctionalities.Size = new System.Drawing.Size(289, 20);
            this.textBoxFunctionalities.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1006, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(289, 20);
            this.textBox4.TabIndex = 8;
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 620);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxFunctionalities);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonAdd3);
            this.Controls.Add(this.buttonAddFunctionalities);
            this.Controls.Add(this.buttonAdd4);
            this.Controls.Add(this.buttonAddMembers);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listFunctionalities);
            this.Controls.Add(this.listMembers);
            this.Controls.Add(this.textBoxMembers);
            this.Controls.Add(this.labelProjectName);
            this.Name = "ProjectView";
            this.Text = "ProjectView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.TextBox textBoxMembers;
        private System.Windows.Forms.ListBox listMembers;
        private System.Windows.Forms.ListBox listFunctionalities;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button buttonAddMembers;
        private System.Windows.Forms.Button buttonAdd4;
        private System.Windows.Forms.Button buttonAddFunctionalities;
        private System.Windows.Forms.Button buttonAdd3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxFunctionalities;
        private System.Windows.Forms.TextBox textBox4;
    }
}