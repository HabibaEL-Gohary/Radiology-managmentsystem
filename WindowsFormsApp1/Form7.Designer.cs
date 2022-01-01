
namespace WindowsFormsApp1
{
    partial class Form7
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label doctorLabel;
            System.Windows.Forms.Label caseLabel;
            System.Windows.Forms.Label departmentLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.databsesystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.caseTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.rSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r_SystemDataSet = new WindowsFormsApp1.R_SystemDataSet();
            this.p_TableAdapter1 = new WindowsFormsApp1.R_SystemDataSetTableAdapters.P_TableAdapter();
            this.databsesystemTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.DatabsesystemTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            doctorLabel = new System.Windows.Forms.Label();
            caseLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databsesystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(8, 317);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(26, 20);
            idLabel.TabIndex = 29;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(219, 317);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(54, 20);
            nameLabel.TabIndex = 31;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(219, 350);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(67, 20);
            addressLabel.TabIndex = 33;
            addressLabel.Text = "Address:";
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Location = new System.Drawing.Point(7, 348);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new System.Drawing.Size(61, 20);
            doctorLabel.TabIndex = 35;
            doctorLabel.Text = "Doctor:";
            // 
            // caseLabel
            // 
            caseLabel.AutoSize = true;
            caseLabel.Location = new System.Drawing.Point(219, 387);
            caseLabel.Name = "caseLabel";
            caseLabel.Size = new System.Drawing.Size(42, 20);
            caseLabel.TabIndex = 37;
            caseLabel.Text = "case:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(7, 387);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(93, 20);
            departmentLabel.TabIndex = 39;
            departmentLabel.Text = "department:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 57);
            this.panel1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Teal;
            this.textBox3.Location = new System.Drawing.Point(157, 6);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(273, 33);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "           Welcome at radiology system";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2021_12_13_at_1_13_42_PM;
            this.pictureBox1.Location = new System.Drawing.Point(513, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(doctorLabel);
            this.groupBox1.Controls.Add(this.doctorTextBox);
            this.groupBox1.Controls.Add(caseLabel);
            this.groupBox1.Controls.Add(this.caseTextBox);
            this.groupBox1.Controls.Add(departmentLabel);
            this.groupBox1.Controls.Add(this.departmentTextBox);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(4, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 488);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "N. page";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databsesystemBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(106, 317);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 27);
            this.idTextBox.TabIndex = 30;
            // 
            // databsesystemBindingSource
            // 
            this.databsesystemBindingSource.DataMember = "Databsesystem";
            this.databsesystemBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databsesystemBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(292, 317);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 27);
            this.nameTextBox.TabIndex = 32;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databsesystemBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(292, 350);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 27);
            this.addressTextBox.TabIndex = 34;
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databsesystemBindingSource, "Doctor", true));
            this.doctorTextBox.Location = new System.Drawing.Point(106, 351);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(100, 27);
            this.doctorTextBox.TabIndex = 36;
            // 
            // caseTextBox
            // 
            this.caseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databsesystemBindingSource, "case", true));
            this.caseTextBox.Location = new System.Drawing.Point(292, 387);
            this.caseTextBox.Name = "caseTextBox";
            this.caseTextBox.Size = new System.Drawing.Size(100, 27);
            this.caseTextBox.TabIndex = 38;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databsesystemBindingSource, "department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(106, 384);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(100, 27);
            this.departmentTextBox.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.caseDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.databsesystemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 270);
            this.dataGridView1.TabIndex = 29;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            // 
            // caseDataGridViewTextBoxColumn
            // 
            this.caseDataGridViewTextBoxColumn.DataPropertyName = "case";
            this.caseDataGridViewTextBoxColumn.HeaderText = "case";
            this.caseDataGridViewTextBoxColumn.Name = "caseDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Teal;
            this.textBox4.Location = new System.Drawing.Point(432, 322);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 33);
            this.textBox4.TabIndex = 24;
            this.textBox4.Text = "https://mail.google.com/mail/u/0/#inbox";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(479, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "View QR code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(483, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Contact(N-P):";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Teal;
            this.textBox5.Location = new System.Drawing.Point(432, 389);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(240, 33);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "https://mail.google.com/mail/u/0/#inbox";
            // 
            // rSystemDataSetBindingSource
            // 
            this.rSystemDataSetBindingSource.AllowNew = true;
            this.rSystemDataSetBindingSource.DataSource = this.r_SystemDataSet;
            this.rSystemDataSetBindingSource.Position = 0;
            // 
            // r_SystemDataSet
            // 
            this.r_SystemDataSet.DataSetName = "R_SystemDataSet";
            this.r_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_TableAdapter1
            // 
            this.p_TableAdapter1.ClearBeforeFill = true;
            // 
            // databsesystemTableAdapter
            // 
            this.databsesystemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DatabsesystemTableAdapter = this.databsesystemTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databsesystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_SystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource rSystemDataSetBindingSource;
        private R_SystemDataSet r_SystemDataSet;
        private R_SystemDataSetTableAdapters.P_TableAdapter p_TableAdapter1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource databsesystemBindingSource;
        private Database1DataSetTableAdapters.DatabsesystemTableAdapter databsesystemTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.TextBox caseTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
    }
}