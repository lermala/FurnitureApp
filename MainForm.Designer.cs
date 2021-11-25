namespace FurnitureApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDcontractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isVisibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectcontractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furniture_kolDataSet = new FurnitureApp.furniture_kolDataSet();
            this.select_contractTableAdapter = new FurnitureApp.furniture_kolDataSetTableAdapters.select_contractTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сгенерироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectcontractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furniture_kolDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-CJ2K61G;Initial Catalog=furniture_kol;Integrated Security=Tru" +
    "e";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.select_contract";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.add_contract";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ID_customer", System.Data.SqlDbType.Int, 4, "ID_customer"),
            new System.Data.SqlClient.SqlParameter("@date_of_issue", System.Data.SqlDbType.Date, 3, "date_of_issue"),
            new System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.Date, 3, "due_date")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "dbo.update_contract";
            this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ID_contract", System.Data.SqlDbType.Int, 4, "ID_contract"),
            new System.Data.SqlClient.SqlParameter("@ID_customer", System.Data.SqlDbType.Int, 4, "ID_customer"),
            new System.Data.SqlClient.SqlParameter("@date_of_issue", System.Data.SqlDbType.Date, 3, "date_of_issue"),
            new System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.Date, 3, "due_date")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "dbo.delete_contract";
            this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ID_contract", System.Data.SqlDbType.Int, 4, "ID_contract")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_contract", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID_contract", "ID_contract"),
                        new System.Data.Common.DataColumnMapping("ID_customer", "ID_customer"),
                        new System.Data.Common.DataColumnMapping("date_of_issue", "date_of_issue"),
                        new System.Data.Common.DataColumnMapping("due_date", "due_date"),
                        new System.Data.Common.DataColumnMapping("isVisible", "isVisible")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcontractDataGridViewTextBoxColumn,
            this.iDcustomerDataGridViewTextBoxColumn,
            this.dateofissueDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.isVisibleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.selectcontractBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // iDcontractDataGridViewTextBoxColumn
            // 
            this.iDcontractDataGridViewTextBoxColumn.DataPropertyName = "ID_contract";
            this.iDcontractDataGridViewTextBoxColumn.HeaderText = "ID_contract";
            this.iDcontractDataGridViewTextBoxColumn.Name = "iDcontractDataGridViewTextBoxColumn";
            this.iDcontractDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDcustomerDataGridViewTextBoxColumn
            // 
            this.iDcustomerDataGridViewTextBoxColumn.DataPropertyName = "ID_customer";
            this.iDcustomerDataGridViewTextBoxColumn.HeaderText = "ID_customer";
            this.iDcustomerDataGridViewTextBoxColumn.Name = "iDcustomerDataGridViewTextBoxColumn";
            // 
            // dateofissueDataGridViewTextBoxColumn
            // 
            this.dateofissueDataGridViewTextBoxColumn.DataPropertyName = "date_of_issue";
            this.dateofissueDataGridViewTextBoxColumn.HeaderText = "date_of_issue";
            this.dateofissueDataGridViewTextBoxColumn.Name = "dateofissueDataGridViewTextBoxColumn";
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "due_date";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "due_date";
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            // 
            // isVisibleDataGridViewTextBoxColumn
            // 
            this.isVisibleDataGridViewTextBoxColumn.DataPropertyName = "isVisible";
            this.isVisibleDataGridViewTextBoxColumn.HeaderText = "isVisible";
            this.isVisibleDataGridViewTextBoxColumn.Name = "isVisibleDataGridViewTextBoxColumn";
            this.isVisibleDataGridViewTextBoxColumn.Width = 150;
            // 
            // selectcontractBindingSource
            // 
            this.selectcontractBindingSource.DataMember = "select_contract";
            this.selectcontractBindingSource.DataSource = this.furniture_kolDataSet;
            // 
            // furniture_kolDataSet
            // 
            this.furniture_kolDataSet.DataSetName = "furniture_kolDataSet";
            this.furniture_kolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // select_contractTableAdapter
            // 
            this.select_contractTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сгенерироватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сгенерироватьToolStripMenuItem
            // 
            this.сгенерироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.покупательToolStripMenuItem});
            this.сгенерироватьToolStripMenuItem.Name = "сгенерироватьToolStripMenuItem";
            this.сгенерироватьToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.сгенерироватьToolStripMenuItem.Text = "Сгенерировать";
            // 
            // покупательToolStripMenuItem
            // 
            this.покупательToolStripMenuItem.Name = "покупательToolStripMenuItem";
            this.покупательToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.покупательToolStripMenuItem.Text = "Покупатель";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectcontractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furniture_kolDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private furniture_kolDataSet furniture_kolDataSet;
        private System.Windows.Forms.BindingSource selectcontractBindingSource;
        private furniture_kolDataSetTableAdapters.select_contractTableAdapter select_contractTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcontractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isVisibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупательToolStripMenuItem;
    }
}

