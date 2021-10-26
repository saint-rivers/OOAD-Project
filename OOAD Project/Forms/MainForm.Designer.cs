
namespace OOAD_Project
{
    partial class MainForm
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label firstnameLabel;
            this.newTaskBtn = new System.Windows.Forms.Button();
            this.projectManagementDataSet = new OOAD_Project.ProjectManagementDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new OOAD_Project.ProjectManagementDataSetTableAdapters.ProjectsTableAdapter();
            this.tableAdapterManager = new OOAD_Project.ProjectManagementDataSetTableAdapters.TableAdapterManager();
            this.projectTitleComboBox = new System.Windows.Forms.ComboBox();
            this.newProjectBtn = new System.Windows.Forms.Button();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.projectUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectUsersTableAdapter = new OOAD_Project.ProjectManagementDataSetTableAdapters.ProjectUsersTableAdapter();
            this.firstnameListBox = new System.Windows.Forms.ListBox();
            this.viewMemberBtn = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.projectIdTextBox = new System.Windows.Forms.TextBox();
            titleLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(35, 68);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(43, 13);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Project:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(653, 65);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(55, 13);
            firstnameLabel.TabIndex = 6;
            firstnameLabel.Text = "Firstname:";
            // 
            // newTaskBtn
            // 
            this.newTaskBtn.Location = new System.Drawing.Point(38, 246);
            this.newTaskBtn.Name = "newTaskBtn";
            this.newTaskBtn.Size = new System.Drawing.Size(101, 54);
            this.newTaskBtn.TabIndex = 0;
            this.newTaskBtn.Text = "New Task";
            this.newTaskBtn.UseVisualStyleBackColor = true;
            this.newTaskBtn.Click += new System.EventHandler(this.newTaskBtn_Click);
            // 
            // projectManagementDataSet
            // 
            this.projectManagementDataSet.DataSetName = "ProjectManagementDataSet";
            this.projectManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.projectManagementDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProjectMembersTableAdapter = null;
            this.tableAdapterManager.ProjectsTableAdapter = this.projectsTableAdapter;
            this.tableAdapterManager.ProjectUsersTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OOAD_Project.ProjectManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // projectTitleComboBox
            // 
            this.projectTitleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "Title", true));
            this.projectTitleComboBox.FormattingEnabled = true;
            this.projectTitleComboBox.Location = new System.Drawing.Point(162, 65);
            this.projectTitleComboBox.Name = "projectTitleComboBox";
            this.projectTitleComboBox.Size = new System.Drawing.Size(317, 21);
            this.projectTitleComboBox.TabIndex = 3;
            this.projectTitleComboBox.SelectedIndexChanged += new System.EventHandler(this.projectTitleComboBox_SelectedIndexChanged);
            // 
            // newProjectBtn
            // 
            this.newProjectBtn.Location = new System.Drawing.Point(38, 306);
            this.newProjectBtn.Name = "newProjectBtn";
            this.newProjectBtn.Size = new System.Drawing.Size(101, 54);
            this.newProjectBtn.TabIndex = 4;
            this.newProjectBtn.Text = "New Project";
            this.newProjectBtn.UseVisualStyleBackColor = true;
            this.newProjectBtn.Click += new System.EventHandler(this.newProjectBtn_Click);
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.Location = new System.Drawing.Point(656, 246);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(120, 58);
            this.addMemberBtn.TabIndex = 6;
            this.addMemberBtn.Text = "Add Member";
            this.addMemberBtn.UseVisualStyleBackColor = true;
            this.addMemberBtn.Click += new System.EventHandler(this.addMemberBtn_Click);
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
            // firstnameListBox
            // 
            this.firstnameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.projectUsersBindingSource, "Firstname", true));
            this.firstnameListBox.FormattingEnabled = true;
            this.firstnameListBox.Location = new System.Drawing.Point(656, 81);
            this.firstnameListBox.Name = "firstnameListBox";
            this.firstnameListBox.Size = new System.Drawing.Size(120, 95);
            this.firstnameListBox.TabIndex = 7;
            // 
            // viewMemberBtn
            // 
            this.viewMemberBtn.Location = new System.Drawing.Point(656, 182);
            this.viewMemberBtn.Name = "viewMemberBtn";
            this.viewMemberBtn.Size = new System.Drawing.Size(120, 58);
            this.viewMemberBtn.TabIndex = 8;
            this.viewMemberBtn.Text = "View Member";
            this.viewMemberBtn.UseVisualStyleBackColor = true;
            this.viewMemberBtn.Click += new System.EventHandler(this.viewMemberBtn_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.welcomeLabel.Location = new System.Drawing.Point(33, 24);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(79, 29);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "label1";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(376, 302);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(120, 58);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(250, 302);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(120, 58);
            this.settingsBtn.TabIndex = 11;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // projectIdTextBox
            // 
            this.projectIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "Id", true));
            this.projectIdTextBox.Location = new System.Drawing.Point(104, 65);
            this.projectIdTextBox.Name = "projectIdTextBox";
            this.projectIdTextBox.ReadOnly = true;
            this.projectIdTextBox.Size = new System.Drawing.Size(52, 20);
            this.projectIdTextBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.viewMemberBtn);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameListBox);
            this.Controls.Add(this.addMemberBtn);
            this.Controls.Add(this.projectIdTextBox);
            this.Controls.Add(this.newProjectBtn);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.projectTitleComboBox);
            this.Controls.Add(this.newTaskBtn);
            this.Name = "MainForm";
            this.Text = "Project Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newTaskBtn;
        private ProjectManagementDataSet projectManagementDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private ProjectManagementDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private ProjectManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox projectTitleComboBox;
        private System.Windows.Forms.Button newProjectBtn;
        private System.Windows.Forms.Button addMemberBtn;
        private System.Windows.Forms.BindingSource projectUsersBindingSource;
        private ProjectManagementDataSetTableAdapters.ProjectUsersTableAdapter projectUsersTableAdapter;
        private System.Windows.Forms.ListBox firstnameListBox;
        private System.Windows.Forms.Button viewMemberBtn;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.TextBox projectIdTextBox;
    }
}

