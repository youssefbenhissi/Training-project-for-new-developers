using System.Windows.Forms;

namespace WindowsFormsCarApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnMyCars = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem2);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.RecentItemsCaption = null;
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 160);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbText = null;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.AltKey = null;
            this.ribbon1.QuickAcessToolbar.CheckedGroup = null;
            this.ribbon1.QuickAcessToolbar.Image = null;
            this.ribbon1.QuickAcessToolbar.Tag = null;
            this.ribbon1.QuickAcessToolbar.Text = null;
            this.ribbon1.QuickAcessToolbar.ToolTip = null;
            this.ribbon1.QuickAcessToolbar.ToolTipTitle = null;
            this.ribbon1.QuickAcessToolbar.Value = null;
            this.ribbon1.Size = new System.Drawing.Size(1003, 187);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.TabSpacing = 6;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.AltKey = null;
            this.ribbonOrbMenuItem1.CheckedGroup = null;
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonOrbMenuItem1.Tag = null;
            this.ribbonOrbMenuItem1.Text = "ribbonOrbMenuItem1";
            this.ribbonOrbMenuItem1.ToolTip = null;
            this.ribbonOrbMenuItem1.ToolTipTitle = null;
            this.ribbonOrbMenuItem1.Value = null;
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.AltKey = null;
            this.ribbonOrbMenuItem2.CheckedGroup = null;
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonOrbMenuItem2.Tag = null;
            this.ribbonOrbMenuItem2.Text = "ribbonOrbMenuItem2";
            this.ribbonOrbMenuItem2.ToolTip = null;
            this.ribbonOrbMenuItem2.ToolTipTitle = null;
            this.ribbonOrbMenuItem2.Value = null;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Tag = null;
            this.ribbonTab1.Text = "ribbonTab1";
            this.ribbonTab1.ToolTip = null;
            this.ribbonTab1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ribbonTab1.ToolTipImage = null;
            this.ribbonTab1.ToolTipTitle = null;
            this.ribbonTab1.Value = null;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.btnMyCars);
            this.ribbonPanel1.Items.Add(this.ribbonButton1);
            this.ribbonPanel1.Tag = null;
            this.ribbonPanel1.Text = "Cars";
            // 
            // btnMyCars
            // 
            this.btnMyCars.AltKey = null;
            this.btnMyCars.CheckedGroup = null;
            this.btnMyCars.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnMyCars.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnMyCars.Image = global::WindowsFormsCarApp.Properties.Resources.lock_24px;
            this.btnMyCars.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnMyCars.SmallImage")));
            this.btnMyCars.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnMyCars.Tag = null;
            this.btnMyCars.Text = "My cars";
            this.btnMyCars.ToolTip = null;
            this.btnMyCars.ToolTipTitle = null;
            this.btnMyCars.Value = null;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.AltKey = null;
            this.ribbonButton1.CheckedGroup = null;
            this.ribbonButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton1.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton1.Image = global::WindowsFormsCarApp.Properties.Resources.name_24px;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton1.Tag = null;
            this.ribbonButton1.Text = "Add A Car";
            this.ribbonButton1.ToolTip = null;
            this.ribbonButton1.ToolTipTitle = null;
            this.ribbonButton1.Value = null;
            this.ribbonButton1.Click += new System.EventHandler(this.addACar);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 52);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 376);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 563);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ribbon1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ribbon ribbon1;
        private RibbonOrbMenuItem ribbonOrbMenuItem1;
        private RibbonOrbMenuItem ribbonOrbMenuItem2;
        private RibbonTab ribbonTab1;
        private RibbonPanel ribbonPanel1;
        private RibbonButton btnMyCars;
        private RibbonButton ribbonButton1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteRowToolStripMenuItem;
        private ToolStripMenuItem modifyToolStripMenuItem;
        private DataGridView dataGridView1;
    }
}