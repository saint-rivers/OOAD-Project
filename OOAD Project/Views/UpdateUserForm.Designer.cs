namespace OOAD_Project.Views
{
    partial class UpdateUserForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label userSecretLabel;
            System.Windows.Forms.Label label1;
            this.projectManagementDataSet = new OOAD_Project.ProjectManagementDataSet();
            this.projectUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectUsersTableAdapter = new OOAD_Project.ProjectManagementDataSetTableAdapters.ProjectUsersTableAdapter();
            this.tableAdapterManager = new OOAD_Project.ProjectManagementDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.userSecretTextBox = new System.Windows.Forms.TextBox();
            this.secretConfirmationTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            userSecretLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(43, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(43, 77);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(55, 13);
            firstnameLabel.TabIndex = 3;
            firstnameLabel.Text = "Firstname:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(43, 115);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(56, 13);
            lastnameLabel.TabIndex = 5;
            lastnameLabel.Text = "Lastname:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(43, 153);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // userSecretLabel
            // 
            userSecretLabel.AutoSize = true;
            userSecretLabel.Location = new System.Drawing.Point(43, 192);
            userSecretLabel.Name = "userSecretLabel";
            userSecretLabel.Size = new System.Drawing.Size(66, 13);
            userSecretLabel.TabIndex = 9;
            userSecretLabel.Text = "User Secret:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(43, 232);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 13);
            label1.TabIndex = 12;
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
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectUsersBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(159, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(195, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectUsersBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(159, 74);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(195, 20);
            this.firstnameTextBox.TabIndex = 4;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectUsersBindingSource, "Lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(159, 112);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(195, 20);
            this.lastnameTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectUsersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(159, 150);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(195, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // userSecretTextBox
            // 
            this.userSecretTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectUsersBindingSource, "UserSecret", true));
            this.userSecretTextBox.HideSelection = false;
            this.userSecretTextBox.Location = new System.Drawing.Point(159, 189);
            this.userSecretTextBox.Name = "userSecretTextBox";
            this.userSecretTextBox.PasswordChar = '*';
            this.userSecretTextBox.Size = new System.Drawing.Size(195, 20);
            this.userSecretTextBox.TabIndex = 10;
            // 
            // secretConfirmationTextBox
            // 
            this.secretConfirmationTextBox.Location = new System.Drawing.Point(159, 229);
            this.secretConfirmationTextBox.Name = "secretConfirmationTextBox";
            this.secretConfirmationTextBox.PasswordChar = '*';
            this.secretConfirmationTextBox.Size = new System.Drawing.Size(195, 20);
            this.secretConfirmationTextBox.TabIndex = 11;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(46, 339);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(308, 41);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(46, 281);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(308, 41);
            this.registerBtn.TabIndex = 13;
            this.registerBtn.Text = "Update";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 405);
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
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "UpdateUserForm";
            this.Text = "UpdateUserForm";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
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
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox userSecretTextBox;
        private System.Windows.Forms.TextBox secretConfirmationTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button registerBtn;
    }
}