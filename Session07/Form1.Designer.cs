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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 449);
            this.Controls.Add(this.btnOpenAllForms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOpenAllForms;
    }
}