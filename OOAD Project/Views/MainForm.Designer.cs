
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
            this.removeMember = new System.Windows.Forms.Button();
            this.deleteProjectBtn = new System.Windows.Forms.Button();
            this.projectManagementDataSetViews = new OOAD_Project.ProjectManagementDataSetViews();
            this.taskViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskViewTableAdapter = new OOAD_Project.ProjectManagementDataSetViewsTableAdapters.TaskViewTableAdapter();
            this.tableAdapterManager1 = new OOAD_Project.ProjectManagementDataSetViewsTableAdapters.TableAdapterManager();
            this.projectManagementDataSetFunctions = new OOAD_Project.ProjectManagementDataSetFunctions();
            this.viewTasksOfProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewTasksOfProjectTableAdapter = new OOAD_Project.ProjectManagementDataSetFunctionsTableAdapters.ViewTasksOfProjectTableAdapter();
            this.tableAdapterManager2 = new OOAD_Project.ProjectManagementDataSetFunctionsTableAdapters.TableAdapterManager();
            this.viewTasksOfProjectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            titleLabel = new System.Windows.Forms.Label();
            membersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSetViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSetFunctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTasksOfProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTasksOfProjectDataGridView)).BeginInit();
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
            membersLabel.Location = new System.Drawing.Point(755, 246);
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
            this.addMemberBtn.Location = new System.Drawing.Point(758, 411);
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
            this.membersListBox.Location = new System.Drawing.Point(758, 262);
            this.membersListBox.Name = "membersListBox";
            this.membersListBox.Size = new System.Drawing.Size(102, 82);
            this.membersListBox.TabIndex = 7;
            // 
            // viewMemberBtn
            // 
            this.viewMemberBtn.Location = new System.Drawing.Point(758, 351);
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
            this.logoutBtn.Location = new System.Drawing.Point(144, 411);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(101, 54);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(37, 411);
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
            // removeMember
            // 
            this.removeMember.Location = new System.Drawing.Point(642, 410);
            this.removeMember.Name = "removeMember";
            this.removeMember.Size = new System.Drawing.Size(101, 54);
            this.removeMember.TabIndex = 13;
            this.removeMember.Text = "Remove Member";
            this.removeMember.UseVisualStyleBackColor = true;
            this.removeMember.Click += new System.EventHandler(this.removeMember_Click);
            // 
            // deleteProjectBtn
            // 
            this.deleteProjectBtn.Location = new System.Drawing.Point(758, 182);
            this.deleteProjectBtn.Name = "deleteProjectBtn";
            this.deleteProjectBtn.Size = new System.Drawing.Size(101, 54);
            this.deleteProjectBtn.TabIndex = 14;
            this.deleteProjectBtn.Text = "Delete Project";
            this.deleteProjectBtn.UseVisualStyleBackColor = true;
            this.deleteProjectBtn.Click += new System.EventHandler(this.deleteProjectBtn_Click);
            // 
            // projectManagementDataSetViews
            // 
            this.projectManagementDataSetViews.DataSetName = "ProjectManagementDataSetViews";
            this.projectManagementDataSetViews.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskViewBindingSource
            // 
            this.taskViewBindingSource.DataMember = "TaskView";
            this.taskViewBindingSource.DataSource = this.projectManagementDataSetViews;
            // 
            // taskViewTableAdapter
            // 
            this.taskViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = OOAD_Project.ProjectManagementDataSetViewsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // projectManagementDataSetFunctions
            // 
            this.projectManagementDataSetFunctions.DataSetName = "ProjectManagementDataSetFunctions";
            this.projectManagementDataSetFunctions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewTasksOfProjectBindingSource
            // 
            this.viewTasksOfProjectBindingSource.DataMember = "ViewTasksOfProject";
            this.viewTasksOfProjectBindingSource.DataSource = this.projectManagementDataSetFunctions;
            // 
            // viewTasksOfProjectTableAdapter
            // 
            this.viewTasksOfProjectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = OOAD_Project.ProjectManagementDataSetFunctionsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // viewTasksOfProjectDataGridView
            // 
            this.viewTasksOfProjectDataGridView.AutoGenerateColumns = false;
            this.viewTasksOfProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTasksOfProjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn14});
            this.viewTasksOfProjectDataGridView.DataSource = this.viewTasksOfProjectBindingSource;
            this.viewTasksOfProjectDataGridView.Location = new System.Drawing.Point(38, 92);
            this.viewTasksOfProjectDataGridView.Name = "viewTasksOfProjectDataGridView";
            this.viewTasksOfProjectDataGridView.Size = new System.Drawing.Size(705, 305);
            this.viewTasksOfProjectDataGridView.TabIndex = 16;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsCompleted";
            this.dataGridViewCheckBoxColumn2.HeaderText = "IsCompleted";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn11.HeaderText = "Title";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn12.HeaderText = "Description";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Deadline";
            this.dataGridViewTextBoxColumn13.HeaderText = "Deadline";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "AssignedTo";
            this.dataGridViewTextBoxColumn15.HeaderText = "Assigned To";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn16.HeaderText = "Email";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TimeCreated";
            this.dataGridViewTextBoxColumn14.HeaderText = "Time Created";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 488);
            this.Controls.Add(this.viewTasksOfProjectDataGridView);
            this.Controls.Add(this.deleteProjectBtn);
            this.Controls.Add(this.removeMember);
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
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSetViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSetFunctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTasksOfProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTasksOfProjectDataGridView)).EndInit();
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
        private System.Windows.Forms.Button removeMember;
        private System.Windows.Forms.Button deleteProjectBtn;
        private ProjectManagementDataSetViews projectManagementDataSetViews;
        private System.Windows.Forms.BindingSource taskViewBindingSource;
        private ProjectManagementDataSetViewsTableAdapters.TaskViewTableAdapter taskViewTableAdapter;
        private ProjectManagementDataSetViewsTableAdapters.TableAdapterManager tableAdapterManager1;
        private ProjectManagementDataSetFunctions projectManagementDataSetFunctions;
        private System.Windows.Forms.BindingSource viewTasksOfProjectBindingSource;
        private ProjectManagementDataSetFunctionsTableAdapters.ViewTasksOfProjectTableAdapter viewTasksOfProjectTableAdapter;
        private ProjectManagementDataSetFunctionsTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView viewTasksOfProjectDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}

