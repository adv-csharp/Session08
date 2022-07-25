namespace Session07.UI
{
    partial class FormPermission
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
            this.listBoxForms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkedListBoxControls = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // listBoxForms
            // 
            this.listBoxForms.FormattingEnabled = true;
            this.listBoxForms.ItemHeight = 15;
            this.listBoxForms.Location = new System.Drawing.Point(12, 69);
            this.listBoxForms.Name = "listBoxForms";
            this.listBoxForms.Size = new System.Drawing.Size(326, 289);
            this.listBoxForms.TabIndex = 0;
            this.listBoxForms.SelectedIndexChanged += new System.EventHandler(this.listBoxForms_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forms:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Controls";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(48, 12);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(620, 23);
            this.comboBoxRoles.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Role";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(593, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkedListBoxControls
            // 
            this.checkedListBoxControls.CheckOnClick = true;
            this.checkedListBoxControls.FormattingEnabled = true;
            this.checkedListBoxControls.Location = new System.Drawing.Point(344, 69);
            this.checkedListBoxControls.Name = "checkedListBoxControls";
            this.checkedListBoxControls.Size = new System.Drawing.Size(324, 292);
            this.checkedListBoxControls.TabIndex = 7;
            this.checkedListBoxControls.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxControls_ItemCheck);
            // 
            // FormPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 394);
            this.Controls.Add(this.checkedListBoxControls);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxForms);
            this.Name = "FormPermission";
            this.Text = "FormPermission";
            this.Load += new System.EventHandler(this.FormPermission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxForms;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxRoles;
        private Label label3;
        private Button btnSave;
        private CheckedListBox checkedListBoxControls;
    }
}