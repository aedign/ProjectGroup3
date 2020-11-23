namespace GroupProjectIdea
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
            this.textProject = new System.Windows.Forms.TextBox();
            this.listProjects = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textProject
            // 
            this.textProject.Location = new System.Drawing.Point(12, 12);
            this.textProject.Name = "textProject";
            this.textProject.Size = new System.Drawing.Size(776, 20);
            this.textProject.TabIndex = 0;
            // 
            // listProjects
            // 
            this.listProjects.FormattingEnabled = true;
            this.listProjects.Location = new System.Drawing.Point(12, 61);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(776, 316);
            this.listProjects.TabIndex = 1;
            this.listProjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listProjects_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "View Project";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Create Project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 670);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listProjects);
            this.Controls.Add(this.textProject);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textProject;
        private System.Windows.Forms.ListBox listProjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

