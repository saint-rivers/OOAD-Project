
namespace OOAD_Project
{
    partial class AddMemberForm
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
            this.nonMembersListBox = new System.Windows.Forms.ListBox();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nonMembersListBox
            // 
            this.nonMembersListBox.FormattingEnabled = true;
            this.nonMembersListBox.Location = new System.Drawing.Point(53, 27);
            this.nonMembersListBox.Name = "nonMembersListBox";
            this.nonMembersListBox.Size = new System.Drawing.Size(173, 160);
            this.nonMembersListBox.TabIndex = 8;
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.Location = new System.Drawing.Point(53, 208);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(173, 55);
            this.addMemberBtn.TabIndex = 9;
            this.addMemberBtn.Text = "Add Member";
            this.addMemberBtn.UseVisualStyleBackColor = true;
            this.addMemberBtn.Click += new System.EventHandler(this.addMemberBtn_Click);
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 288);
            this.Controls.Add(this.addMemberBtn);
            this.Controls.Add(this.nonMembersListBox);
            this.Name = "AddMemberForm";
            this.Text = "Add Member";
            this.Load += new System.EventHandler(this.AddMemberForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox nonMembersListBox;
        private System.Windows.Forms.Button addMemberBtn;
    }
}