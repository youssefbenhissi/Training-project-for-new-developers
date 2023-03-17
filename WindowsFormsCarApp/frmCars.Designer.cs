namespace WindowsFormsCarApp
{
    partial class frmCars
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorsePower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfWheels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfLeters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.Price,
            this.Brand,
            this.HorsePower,
            this.Mileage,
            this.NumberOfWheels,
            this.Color,
            this.SerialNumber,
            this.NumberOfLeters,
            this.Age});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 431);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Car ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // HorsePower
            // 
            this.HorsePower.DataPropertyName = "HorsePower";
            this.HorsePower.HeaderText = "HorsePower";
            this.HorsePower.Name = "HorsePower";
            this.HorsePower.ReadOnly = true;
            // 
            // Mileage
            // 
            this.Mileage.DataPropertyName = "Mileage";
            this.Mileage.HeaderText = "Mileage";
            this.Mileage.Name = "Mileage";
            this.Mileage.ReadOnly = true;
            // 
            // NumberOfWheels
            // 
            this.NumberOfWheels.DataPropertyName = "NumberOfWheels";
            this.NumberOfWheels.HeaderText = "NumberOfWheels";
            this.NumberOfWheels.Name = "NumberOfWheels";
            this.NumberOfWheels.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataPropertyName = "SerialNumber";
            this.SerialNumber.HeaderText = "SerialNumber";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            // 
            // NumberOfLeters
            // 
            this.NumberOfLeters.DataPropertyName = "NumberOfLeters";
            this.NumberOfLeters.HeaderText = "NumberOfLeters";
            this.NumberOfLeters.Name = "NumberOfLeters";
            this.NumberOfLeters.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 501);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCars";
            this.Text = "frmCars";
            this.Load += new System.EventHandler(this.frmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorsePower;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfWheels;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfLeters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
    }
}