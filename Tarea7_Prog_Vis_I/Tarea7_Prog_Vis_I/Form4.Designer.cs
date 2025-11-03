namespace Tarea7_Prog_Vis_I
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.bd_ventasDataSet = new Tarea7_Prog_Vis_I.bd_ventasDataSet();
            this.catalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogoTableAdapter = new Tarea7_Prog_Vis_I.bd_ventasDataSetTableAdapters.CatalogoTableAdapter();
            this.tableAdapterManager = new Tarea7_Prog_Vis_I.bd_ventasDataSetTableAdapters.TableAdapterManager();
            this.catalogoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.catalogoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.catalogoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ventasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingNavigator)).BeginInit();
            this.catalogoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bd_ventasDataSet
            // 
            this.bd_ventasDataSet.DataSetName = "bd_ventasDataSet";
            this.bd_ventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catalogoBindingSource
            // 
            this.catalogoBindingSource.DataMember = "Catalogo";
            this.catalogoBindingSource.DataSource = this.bd_ventasDataSet;
            // 
            // catalogoTableAdapter
            // 
            this.catalogoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CatalogoTableAdapter = this.catalogoTableAdapter;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tarea7_Prog_Vis_I.bd_ventasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // catalogoBindingNavigator
            // 
            this.catalogoBindingNavigator.AddNewItem = null;
            this.catalogoBindingNavigator.BindingSource = this.catalogoBindingSource;
            this.catalogoBindingNavigator.CountItem = null;
            this.catalogoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.catalogoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.catalogoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.catalogoBindingNavigatorSaveItem});
            this.catalogoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.catalogoBindingNavigator.MoveFirstItem = null;
            this.catalogoBindingNavigator.MoveLastItem = null;
            this.catalogoBindingNavigator.MoveNextItem = null;
            this.catalogoBindingNavigator.MovePreviousItem = null;
            this.catalogoBindingNavigator.Name = "catalogoBindingNavigator";
            this.catalogoBindingNavigator.PositionItem = null;
            this.catalogoBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.catalogoBindingNavigator.TabIndex = 0;
            this.catalogoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // catalogoBindingNavigatorSaveItem
            // 
            this.catalogoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.catalogoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("catalogoBindingNavigatorSaveItem.Image")));
            this.catalogoBindingNavigatorSaveItem.Name = "catalogoBindingNavigatorSaveItem";
            this.catalogoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.catalogoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.catalogoBindingNavigatorSaveItem.Click += new System.EventHandler(this.catalogoBindingNavigatorSaveItem_Click);
            // 
            // catalogoDataGridView
            // 
            this.catalogoDataGridView.AutoGenerateColumns = false;
            this.catalogoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.catalogoDataGridView.DataSource = this.catalogoBindingSource;
            this.catalogoDataGridView.Location = new System.Drawing.Point(212, 86);
            this.catalogoDataGridView.Name = "catalogoDataGridView";
            this.catalogoDataGridView.RowHeadersWidth = 51;
            this.catalogoDataGridView.RowTemplate.Height = 24;
            this.catalogoDataGridView.Size = new System.Drawing.Size(300, 220);
            this.catalogoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catalogoDataGridView);
            this.Controls.Add(this.catalogoBindingNavigator);
            this.Name = "Form4";
            this.Text = "Catalogo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_ventasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingNavigator)).EndInit();
            this.catalogoBindingNavigator.ResumeLayout(false);
            this.catalogoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_ventasDataSet bd_ventasDataSet;
        private System.Windows.Forms.BindingSource catalogoBindingSource;
        private bd_ventasDataSetTableAdapters.CatalogoTableAdapter catalogoTableAdapter;
        private bd_ventasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator catalogoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton catalogoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView catalogoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}