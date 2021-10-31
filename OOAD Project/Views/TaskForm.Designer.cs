
namespace OOAD_Project
{
    partial class TaskForm
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
            System.Windows.Forms.Label deadlineLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label assignedToLabel;
            this.projectManagementDataSet = new OOAD_Project.ProjectManagementDataSet();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new OOAD_Project.ProjectManagementDataSetTableAdapters.TasksTableAdapter();
            this.tableAdapterManager = new OOAD_Project.ProjectManagementDataSetTableAdapters.TableAdapterManager();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.deadlineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.assignedToComboBox = new System.Windows.Forms.ComboBox();
            titleLabel = new System.Windows.Forms.Label();
            deadlineLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            assignedToLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(41, 38);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title:";
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.Location = new System.Drawing.Point(41, 183);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new System.Drawing.Size(52, 13);
            deadlineLabel.TabIndex = 4;
            deadlineLabel.Text = "Deadline:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(41, 91);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // assignedToLabel
            // 
            assignedToLabel.AutoSize = true;
            assignedToLabel.Location = new System.Drawing.Point(41, 64);
            assignedToLabel.Name = "assignedToLabel";
            assignedToLabel.Size = new System.Drawing.Size(69, 13);
            assignedToLabel.TabIndex = 8;
            assignedToLabel.Text = "Assigned To:";
            // 
            // projectManagementDataSet
            // 
            this.projectManagementDataSet.DataSetName = "ProjectManagementDataSet";
            this.projectManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProjectMembersTableAdapter = null;
            this.tableAdapterManager.ProjectsTableAdapter = null;
            this.tableAdapterManager.ProjectUsersTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = this.tasksTableAdapter;
            this.tableAdapterManager.UpdateOrder = OOAD_Project.ProjectManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(147, 35);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(225, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // deadlineDateTimePicker
            // 
            this.deadlineDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tasksBindingSource, "Deadline", true));
            this.deadlineDateTimePicker.Location = new System.Drawing.Point(147, 177);
            this.deadlineDateTimePicker.Name = "deadlineDateTimePicker";
            this.deadlineDateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.deadlineDateTimePicker.TabIndex = 5;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "Description", true));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(147, 88);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(225, 83);
            this.descriptionRichTextBox.TabIndex = 6;
            this.descriptionRichTextBox.Text = "";
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(44, 220);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(328, 44);
            this.addTaskBtn.TabIndex = 7;
            this.addTaskBtn.Text = "Add Task";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(44, 270);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(328, 44);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // assignedToComboBox
            // 
            this.assignedToComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "AssignedTo", true));
            this.assignedToComboBox.FormattingEnabled = true;
            this.assignedToComboBox.Location = new System.Drawing.Point(147, 61);
            this.assignedToComboBox.Name = "assignedToComboBox";
            this.assignedToComboBox.Size = new System.Drawing.Size(225, 21);
            this.assignedToComboBox.TabIndex = 9;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 339);
            this.Controls.Add(assignedToLabel);
            this.Controls.Add(this.assignedToComboBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addTaskBtn);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(deadlineLabel);
            this.Controls.Add(this.deadlineDateTimePicker);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Name = "TaskForm";
            this.Text = "New Task";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaskForm_FormClosed);
            this.Load += new System.EventHandler(this.NewTaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectManagementDataSet projectManagementDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private ProjectManagementDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private ProjectManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker deadlineDateTimePicker;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox assignedToComboBox;
    }
}