namespace cooperativa_presentacion_desktop
{
    partial class Frm_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleado));
            this.sOCIOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sOCIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.FILTROlabel = new System.Windows.Forms.Label();
            this.eMPLEADODataGridView = new System.Windows.Forms.DataGridView();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.btnbuscarempleado = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOBindingNavigator)).BeginInit();
            this.sOCIOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sOCIOBindingNavigator
            // 
            this.sOCIOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sOCIOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sOCIOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sOCIOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sOCIOBindingNavigatorSaveItem});
            this.sOCIOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sOCIOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sOCIOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sOCIOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sOCIOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sOCIOBindingNavigator.Name = "sOCIOBindingNavigator";
            this.sOCIOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sOCIOBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.sOCIOBindingNavigator.TabIndex = 1;
            this.sOCIOBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sOCIOBindingNavigatorSaveItem
            // 
            this.sOCIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sOCIOBindingNavigatorSaveItem.Enabled = false;
            this.sOCIOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sOCIOBindingNavigatorSaveItem.Image")));
            this.sOCIOBindingNavigatorSaveItem.Name = "sOCIOBindingNavigatorSaveItem";
            this.sOCIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sOCIOBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // FILTROlabel
            // 
            this.FILTROlabel.AutoSize = true;
            this.FILTROlabel.Location = new System.Drawing.Point(12, 39);
            this.FILTROlabel.Name = "FILTROlabel";
            this.FILTROlabel.Size = new System.Drawing.Size(45, 13);
            this.FILTROlabel.TabIndex = 5;
            this.FILTROlabel.Text = "FILTRO";
            // 
            // eMPLEADODataGridView
            // 
            this.eMPLEADODataGridView.AutoGenerateColumns = false;
            this.eMPLEADODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMPLEADODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.eMPLEADODataGridView.DataSource = this.eMPLEADOBindingSource;
            this.eMPLEADODataGridView.Location = new System.Drawing.Point(12, 73);
            this.eMPLEADODataGridView.Name = "eMPLEADODataGridView";
            this.eMPLEADODataGridView.Size = new System.Drawing.Size(722, 288);
            this.eMPLEADODataGridView.TabIndex = 7;
            // 
            // txtempleado
            // 
            this.txtempleado.Location = new System.Drawing.Point(63, 36);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(100, 20);
            this.txtempleado.TabIndex = 8;
            this.txtempleado.TextChanged += new System.EventHandler(this.textBoxempleado_TextChanged);
            // 
            // btnbuscarempleado
            // 
            this.btnbuscarempleado.Location = new System.Drawing.Point(185, 34);
            this.btnbuscarempleado.Name = "btnbuscarempleado";
            this.btnbuscarempleado.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarempleado.TabIndex = 9;
            this.btnbuscarempleado.Text = "BUSCAR";
            this.btnbuscarempleado.UseVisualStyleBackColor = true;
            this.btnbuscarempleado.Click += new System.EventHandler(this.btnbuscarempleado_Click_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PersonaID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "EmpleadoEstado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "EmpleadoEstado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmpleadoFechaRegistro";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmpleadoFechaRegistro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmpleadoFechaBaja";
            this.dataGridViewTextBoxColumn3.HeaderText = "EmpleadoFechaBaja";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EmpleadoNotas";
            this.dataGridViewTextBoxColumn4.HeaderText = "EmpleadoNotas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // eMPLEADOBindingSource
            // 
            this.eMPLEADOBindingSource.DataSource = typeof(cooperativa_datos.EMPLEADO);
            // 
            // Frm_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbuscarempleado);
            this.Controls.Add(this.txtempleado);
            this.Controls.Add(this.eMPLEADODataGridView);
            this.Controls.Add(this.FILTROlabel);
            this.Controls.Add(this.sOCIOBindingNavigator);
            this.Name = "Frm_Empleado";
            this.Text = "Frm_Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOBindingNavigator)).EndInit();
            this.sOCIOBindingNavigator.ResumeLayout(false);
            this.sOCIOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator sOCIOBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sOCIOBindingNavigatorSaveItem;
        private System.Windows.Forms.Label FILTROlabel;
        private System.Windows.Forms.BindingSource eMPLEADOBindingSource;
        private System.Windows.Forms.DataGridView eMPLEADODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.Button btnbuscarempleado;
    }
}