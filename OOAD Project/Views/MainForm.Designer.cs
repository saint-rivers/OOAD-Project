﻿
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
            System.Windows.Forms.Label membersLabel;
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
            this.membersListBox = new System.Windows.Forms.ListBox();
            this.viewMemberBtn = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.projectIdTextBox = new System.Windows.Forms.TextBox();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new OOAD_Project.ProjectManagementDataSetTableAdapters.TasksTableAdapter();
            this.tasksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeMember = new System.Windows.Forms.Button();
            titleLabel = new System.Windows.Forms.Label();
            membersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).BeginInit();
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
            // membersLabel
            // 
            membersLabel.AutoSize = true;
            membersLabel.Location = new System.Drawing.Point(755, 193);
            membersLabel.Name = "membersLabel";
            membersLabel.Size = new System.Drawing.Size(53, 13);
            membersLabel.TabIndex = 6;
            membersLabel.Text = "Members:";
            // 
            // newTaskBtn
            // 
            this.newTaskBtn.Location = new System.Drawing.Point(758, 122);
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
            this.projectTitleComboBox.Size = new System.Drawing.Size(581, 21);
            this.projectTitleComboBox.TabIndex = 3;
            this.projectTitleComboBox.SelectedIndexChanged += new System.EventHandler(this.projectTitleComboBox_SelectedIndexChanged);
            // 
            // newProjectBtn
            // 
            this.newProjectBtn.Location = new System.Drawing.Point(758, 65);
            this.newProjectBtn.Name = "newProjectBtn";
            this.newProjectBtn.Size = new System.Drawing.Size(101, 54);
            this.newProjectBtn.TabIndex = 4;
            this.newProjectBtn.Text = "New Project";
            this.newProjectBtn.UseVisualStyleBackColor = true;
            this.newProjectBtn.Click += new System.EventHandler(this.newProjectBtn_Click);
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.Location = new System.Drawing.Point(758, 404);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(101, 54);
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
            // membersListBox
            // 
            this.membersListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.projectUsersBindingSource, "Firstname", true));
            this.membersListBox.FormattingEnabled = true;
            this.membersListBox.Location = new System.Drawing.Point(758, 210);
            this.membersListBox.Name = "membersListBox";
            this.membersListBox.Size = new System.Drawing.Size(102, 121);
            this.membersListBox.TabIndex = 7;
            // 
            // viewMemberBtn
            // 
            this.viewMemberBtn.Location = new System.Drawing.Point(758, 344);
            this.viewMemberBtn.Name = "viewMemberBtn";
            this.viewMemberBtn.Size = new System.Drawing.Size(101, 54);
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
            this.logoutBtn.Location = new System.Drawing.Point(144, 404);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(101, 54);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(37, 404);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(101, 54);
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
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.projectManagementDataSet;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // tasksDataGridView
            // 
            this.tasksDataGridView.AutoGenerateColumns = false;
            this.tasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6});
            this.tasksDataGridView.DataSource = this.tasksBindingSource;
            this.tasksDataGridView.Location = new System.Drawing.Point(38, 110);
            this.tasksDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.tasksDataGridView.Name = "tasksDataGridView";
            this.tasksDataGridView.RowHeadersWidth = 51;
            this.tasksDataGridView.RowTemplate.Height = 24;
            this.tasksDataGridView.Size = new System.Drawing.Size(704, 288);
            this.tasksDataGridView.TabIndex = 12;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsCompleted";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsCompleted";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn4.HeaderText = "Title";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AssignedTo";
            this.dataGridViewTextBoxColumn3.HeaderText = "AssignedTo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Deadline";
            this.dataGridViewTextBoxColumn6.HeaderText = "Deadline";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // removeMember
            // 
            this.removeMember.Location = new System.Drawing.Point(642, 403);
            this.removeMember.Name = "removeMember";
            this.removeMember.Size = new System.Drawing.Size(101, 54);
            this.removeMember.TabIndex = 13;
            this.removeMember.Text = "Remove Member";
            this.removeMember.UseVisualStyleBackColor = true;
            this.removeMember.Click += new System.EventHandler(this.removeMember_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 486);
            this.Controls.Add(this.removeMember);
            this.Controls.Add(this.tasksDataGridView);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.viewMemberBtn);
            this.Controls.Add(membersLabel);
            this.Controls.Add(this.membersListBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).EndInit();
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
        private System.Windows.Forms.ListBox membersListBox;
        private System.Windows.Forms.Button viewMemberBtn;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.TextBox projectIdTextBox;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private ProjectManagementDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.DataGridView tasksDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button removeMember;
    }
}

