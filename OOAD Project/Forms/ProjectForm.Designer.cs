
namespace OOAD_Project
{
    partial class ProjectForm
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
            System.Windows.Forms.Label dateCreatedLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.projectManagementDataSet = new OOAD_Project.ProjectManagementDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new OOAD_Project.ProjectManagementDataSetTableAdapters.ProjectsTableAdapter();
            this.tableAdapterManager = new OOAD_Project.ProjectManagementDataSetTableAdapters.TableAdapterManager();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dateCreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.createProjectBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            titleLabel = new System.Windows.Forms.Label();
            dateCreatedLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(34, 46);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(138, 43);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(210, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // dateCreatedLabel
            // 
            dateCreatedLabel.AutoSize = true;
            dateCreatedLabel.Location = new System.Drawing.Point(34, 217);
            dateCreatedLabel.Name = "dateCreatedLabel";
            dateCreatedLabel.Size = new System.Drawing.Size(73, 13);
            dateCreatedLabel.TabIndex = 3;
            dateCreatedLabel.Text = "Date Created:";
            // 
            // dateCreatedDateTimePicker
            // 
            this.dateCreatedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.projectsBindingSource, "DateCreated", true));
            this.dateCreatedDateTimePicker.Location = new System.Drawing.Point(138, 211);
            this.dateCreatedDateTimePicker.Name = "dateCreatedDateTimePicker";
            this.dateCreatedDateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.dateCreatedDateTimePicker.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(34, 72);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "Description", true));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(138, 69);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(210, 136);
            this.descriptionRichTextBox.TabIndex = 6;
            this.descriptionRichTextBox.Text = "";
            // 
            // createProjectBtn
            // 
            this.createProjectBtn.Location = new System.Drawing.Point(37, 260);
            this.createProjectBtn.Name = "createProjectBtn";
            this.createProjectBtn.Size = new System.Drawing.Size(311, 40);
            this.createProjectBtn.TabIndex = 9;
            this.createProjectBtn.Text = "Create Project";
            this.createProjectBtn.UseVisualStyleBackColor = true;
            this.createProjectBtn.Click += new System.EventHandler(this.createProjectBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(37, 306);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(311, 40);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 370);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createProjectBtn);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(dateCreatedLabel);
            this.Controls.Add(this.dateCreatedDateTimePicker);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Name = "ProjectForm";
            this.Text = "ProjectForm";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectManagementDataSet projectManagementDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private ProjectManagementDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private ProjectManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker dateCreatedDateTimePicker;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button createProjectBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}