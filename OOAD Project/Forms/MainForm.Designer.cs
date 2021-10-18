
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
            this.newTaskBtn = new System.Windows.Forms.Button();
            this.projectManagementDataSet = new OOAD_Project.ProjectManagementDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new OOAD_Project.ProjectManagementDataSetTableAdapters.ProjectsTableAdapter();
            this.tableAdapterManager = new OOAD_Project.ProjectManagementDataSetTableAdapters.TableAdapterManager();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.newProjectBtn = new System.Windows.Forms.Button();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(35, 43);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(43, 13);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Project:";
            // 
            // newTaskBtn
            // 
            this.newTaskBtn.Location = new System.Drawing.Point(670, 91);
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
            // titleComboBox
            // 
            this.titleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "Title", true));
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Location = new System.Drawing.Point(91, 40);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(537, 21);
            this.titleComboBox.TabIndex = 3;
            // 
            // newProjectBtn
            // 
            this.newProjectBtn.Location = new System.Drawing.Point(670, 31);
            this.newProjectBtn.Name = "newProjectBtn";
            this.newProjectBtn.Size = new System.Drawing.Size(101, 54);
            this.newProjectBtn.TabIndex = 4;
            this.newProjectBtn.Text = "New Project";
            this.newProjectBtn.UseVisualStyleBackColor = true;
            this.newProjectBtn.Click += new System.EventHandler(this.newProjectBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newProjectBtn);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleComboBox);
            this.Controls.Add(this.newTaskBtn);
            this.Name = "MainForm";
            this.Text = "Project Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newTaskBtn;
        private ProjectManagementDataSet projectManagementDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private ProjectManagementDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private ProjectManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.Button newProjectBtn;
    }
}

