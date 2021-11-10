
namespace OOAD_Project
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label userSecretLabel;
            System.Windows.Forms.Label label1;
            this.projectManagementDataSet = new OOAD_Project.ProjectManagementDataSet();
            this.projectUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectUsersTableAdapter = new OOAD_Project.ProjectManagementDataSetTableAdapters.ProjectUsersTableAdapter();
            this.tableAdapterManager = new OOAD_Project.ProjectManagementDataSetTableAdapters.TableAdapterManager();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.userSecretTextBox = new System.Windows.Forms.TextBox();
            this.secretConfirmationTextBox = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            firstnameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            userSecretLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(45, 32);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(55, 13);
            firstnameLabel.TabIndex = 1;
            firstnameLabel.Text = "Firstname:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(44, 73);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(56, 13);
            lastnameLabel.TabIndex = 3;
            lastnameLabel.Text = "Lastname:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(44, 117);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // userSecretLabel
            // 
            userSecretLabel.AutoSize = true;
            userSecretLabel.Location = new System.Drawing.Point(45, 160);
            userSecretLabel.Name = "userSecretLabel";
            userSecretLabel.Size = new System.Drawing.Size(56, 13);
            userSecretLabel.TabIndex = 7;
            userSecretLabel.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(45, 201);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 13);
            label1.TabIndex = 10;
            label1.Text = "Confirm Password:";
            // 
            // projectManagementDataSet
            // 
            this.projectManagementDataSet.DataSetName = "ProjectManagementDataSet";
            this.projectManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectUsersBindingSource
            // 
            this.projectUsersBindingSource.DataMember = "ProjectUsers";
            this.projectUsersBindingSource.DataSource = this.projectManagementDataSet;
            // 
            // projectUsersTableAdapter
            // 
            this.projectUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProjectMembersTableAdapter = null;
            this.tableAdapterManager.ProjectsTableAdapter = null;
            this.tableAdapterManager.ProjectUsersTableAdapter = this.projectUsersTableAdapter;
            this.tableAdapterManager.TasksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OOAD_Project.ProjectManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectUsersBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(148, 29);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(207, 20);
            this.firstnameTextBox.TabIndex = 2;
            this.firstnameTextBox.Text = " ";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectUsersBindingSource, "Lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(148, 70);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(207, 20);
            this.lastnameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectUsersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(148, 114);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(207, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // userSecretTextBox
            // 
            this.userSecretTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectUsersBindingSource, "UserSecret", true));
            this.userSecretTextBox.Location = new System.Drawing.Point(148, 157);
            this.userSecretTextBox.Name = "userSecretTextBox";
            this.userSecretTextBox.PasswordChar = '*';
            this.userSecretTextBox.Size = new System.Drawing.Size(207, 20);
            this.userSecretTextBox.TabIndex = 8;
            // 
            // secretConfirmationTextBox
            // 
            this.secretConfirmationTextBox.Location = new System.Drawing.Point(148, 198);
            this.secretConfirmationTextBox.Name = "secretConfirmationTextBox";
            this.secretConfirmationTextBox.PasswordChar = '*';
            this.secretConfirmationTextBox.Size = new System.Drawing.Size(207, 20);
            this.secretConfirmationTextBox.TabIndex = 9;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(47, 248);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(308, 41);
            this.registerBtn.TabIndex = 11;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(47, 306);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(308, 41);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 375);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(label1);
            this.Controls.Add(this.secretConfirmationTextBox);
            this.Controls.Add(userSecretLabel);
            this.Controls.Add(this.userSecretTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(lastnameLabel);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Name = "RegistrationForm";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectManagementDataSet projectManagementDataSet;
        private System.Windows.Forms.BindingSource projectUsersBindingSource;
        private ProjectManagementDataSetTableAdapters.ProjectUsersTableAdapter projectUsersTableAdapter;
        private ProjectManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox userSecretTextBox;
        private System.Windows.Forms.TextBox secretConfirmationTextBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}