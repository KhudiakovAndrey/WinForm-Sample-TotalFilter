
namespace WinForm_Sample_TotalFilter
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
            this.label1 = new System.Windows.Forms.Label();
            this.RequestsLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requestServicesDataSet = new WinForm_Sample_TotalFilter.RequestServicesDataSet();
            this.cLIENTSTableAdapter = new WinForm_Sample_TotalFilter.RequestServicesDataSetTableAdapters.CLIENTSTableAdapter();
            this.tableAdapterManager = new WinForm_Sample_TotalFilter.RequestServicesDataSetTableAdapters.TableAdapterManager();
            this.eQUIPMENTSTableAdapter = new WinForm_Sample_TotalFilter.RequestServicesDataSetTableAdapters.EQUIPMENTSTableAdapter();
            this.eXECUTORSTableAdapter = new WinForm_Sample_TotalFilter.RequestServicesDataSetTableAdapters.EXECUTORSTableAdapter();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new WinForm_Sample_TotalFilter.RequestServicesDataSetTableAdapters.USERSTableAdapter();
            this.rEQUESTSTableAdapter = new WinForm_Sample_TotalFilter.RequestServicesDataSetTableAdapters.REQUESTSTableAdapter();
            this.NumberFilterTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriorityFilterTB = new System.Windows.Forms.TextBox();
            this.EquipmentFilterCB = new System.Windows.Forms.ComboBox();
            this.ClientFilterCB = new System.Windows.Forms.ComboBox();
            this.ExecutorFilterCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requestServicesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(925, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заявки на ремонт оборудования";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RequestsLV
            // 
            this.RequestsLV.CheckBoxes = true;
            this.RequestsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.RequestsLV.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestsLV.FullRowSelect = true;
            this.RequestsLV.HideSelection = false;
            this.RequestsLV.Location = new System.Drawing.Point(5, 180);
            this.RequestsLV.Name = "RequestsLV";
            this.RequestsLV.Size = new System.Drawing.Size(895, 254);
            this.RequestsLV.TabIndex = 1;
            this.RequestsLV.UseCompatibleStateImageBehavior = false;
            this.RequestsLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата добавления";
            this.columnHeader2.Width = 164;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Приоритет";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Оборудования";
            this.columnHeader4.Width = 151;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Клиент";
            this.columnHeader5.Width = 127;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Исполнитель";
            this.columnHeader6.Width = 151;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Статус";
            this.columnHeader7.Width = 109;
            // 
            // requestServicesDataSet
            // 
            this.requestServicesDataSet.DataSetName = "RequestServicesDataSet";
            this.requestServicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTSTableAdapter
            // 
            this.cLIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTSTableAdapter = this.cLIENTSTableAdapter;
            this.tableAdapterManager.EQUIPMENTSTableAdapter = this.eQUIPMENTSTableAdapter;
            this.tableAdapterManager.EXECUTORSTableAdapter = this.eXECUTORSTableAdapter;
            this.tableAdapterManager.FEEDBACKSTableAdapter = null;
            this.tableAdapterManager.ORDER_SPARE_PARTTableAdapter = null;
            this.tableAdapterManager.RELEASE_REQUESTSTableAdapter = null;
            this.tableAdapterManager.REQUESTSTableAdapter = null;
            this.tableAdapterManager.ROLETableAdapter = null;
            this.tableAdapterManager.SPARE_PARTSTableAdapter = null;
            this.tableAdapterManager.TYPE_PROBLEMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WinForm_Sample_TotalFilter.RequestServicesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // eQUIPMENTSTableAdapter
            // 
            this.eQUIPMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // eXECUTORSTableAdapter
            // 
            this.eXECUTORSTableAdapter.ClearBeforeFill = true;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.requestServicesDataSet;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // rEQUESTSTableAdapter
            // 
            this.rEQUESTSTableAdapter.ClearBeforeFill = true;
            // 
            // NumberFilterTB
            // 
            this.NumberFilterTB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.NumberFilterTB.Location = new System.Drawing.Point(6, 94);
            this.NumberFilterTB.Name = "NumberFilterTB";
            this.NumberFilterTB.Size = new System.Drawing.Size(105, 24);
            this.NumberFilterTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label2.Location = new System.Drawing.Point(2, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label3.Location = new System.Drawing.Point(113, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Приоритет";
            // 
            // PriorityFilterTB
            // 
            this.PriorityFilterTB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.PriorityFilterTB.Location = new System.Drawing.Point(117, 94);
            this.PriorityFilterTB.Name = "PriorityFilterTB";
            this.PriorityFilterTB.Size = new System.Drawing.Size(77, 24);
            this.PriorityFilterTB.TabIndex = 4;
            // 
            // EquipmentFilterCB
            // 
            this.EquipmentFilterCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.EquipmentFilterCB.FormattingEnabled = true;
            this.EquipmentFilterCB.Location = new System.Drawing.Point(6, 147);
            this.EquipmentFilterCB.Name = "EquipmentFilterCB";
            this.EquipmentFilterCB.Size = new System.Drawing.Size(188, 27);
            this.EquipmentFilterCB.TabIndex = 6;
            // 
            // ClientFilterCB
            // 
            this.ClientFilterCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.ClientFilterCB.FormattingEnabled = true;
            this.ClientFilterCB.Location = new System.Drawing.Point(208, 147);
            this.ClientFilterCB.Name = "ClientFilterCB";
            this.ClientFilterCB.Size = new System.Drawing.Size(221, 27);
            this.ClientFilterCB.TabIndex = 7;
            // 
            // ExecutorFilterCB
            // 
            this.ExecutorFilterCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.ExecutorFilterCB.FormattingEnabled = true;
            this.ExecutorFilterCB.Location = new System.Drawing.Point(444, 147);
            this.ExecutorFilterCB.Name = "ExecutorFilterCB";
            this.ExecutorFilterCB.Size = new System.Drawing.Size(221, 27);
            this.ExecutorFilterCB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label4.Location = new System.Drawing.Point(4, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Оборудования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label5.Location = new System.Drawing.Point(204, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Клиент";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label6.Location = new System.Drawing.Point(440, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Исполнитель";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 536);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExecutorFilterCB);
            this.Controls.Add(this.ClientFilterCB);
            this.Controls.Add(this.EquipmentFilterCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriorityFilterTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberFilterTB);
            this.Controls.Add(this.RequestsLV);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Ремонт оборудования";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestServicesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView RequestsLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private RequestServicesDataSet requestServicesDataSet;
        private RequestServicesDataSetTableAdapters.CLIENTSTableAdapter cLIENTSTableAdapter;
        private RequestServicesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RequestServicesDataSetTableAdapters.EQUIPMENTSTableAdapter eQUIPMENTSTableAdapter;
        private RequestServicesDataSetTableAdapters.EXECUTORSTableAdapter eXECUTORSTableAdapter;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private RequestServicesDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private RequestServicesDataSetTableAdapters.REQUESTSTableAdapter rEQUESTSTableAdapter;
        private System.Windows.Forms.TextBox NumberFilterTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriorityFilterTB;
        private System.Windows.Forms.ComboBox EquipmentFilterCB;
        private System.Windows.Forms.ComboBox ClientFilterCB;
        private System.Windows.Forms.ComboBox ExecutorFilterCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

