namespace Session07
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenAllForms = new System.Windows.Forms.Button();
            this.buttonReflection2 = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenAllForms
            // 
            this.btnOpenAllForms.Location = new System.Drawing.Point(12, 12);
            this.btnOpenAllForms.Name = "btnOpenAllForms";
            this.btnOpenAllForms.Size = new System.Drawing.Size(144, 41);
            this.btnOpenAllForms.TabIndex = 0;
            this.btnOpenAllForms.Text = "Open All Form";
            this.btnOpenAllForms.UseVisualStyleBackColor = true;
            this.btnOpenAllForms.Click += new System.EventHandler(this.btnOpenAllForms_Click);
            // 
            // buttonReflection2
            // 
            this.buttonReflection2.Location = new System.Drawing.Point(12, 59);
            this.buttonReflection2.Name = "buttonReflection2";
            this.buttonReflection2.Size = new System.Drawing.Size(144, 45);
            this.buttonReflection2.TabIndex = 1;
            this.buttonReflection2.Text = "Reflection 2";
            this.buttonReflection2.UseVisualStyleBackColor = true;
            this.buttonReflection2.Click += new System.EventHandler(this.buttonReflection2_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 272);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(144, 45);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(144, 45);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(725, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "User:";
            // 
            // toolStripStatusLabelUser
            // 
            this.toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            this.toolStripStatusLabelUser.Size = new System.Drawing.Size(14, 17);
            this.toolStripStatusLabelUser.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 420);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.buttonReflection2);
            this.Controls.Add(this.btnOpenAllForms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpenAllForms;
        private Button buttonReflection2;
        private Button btnRegister;
        private Button btnLogin;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelUser;
    }
}