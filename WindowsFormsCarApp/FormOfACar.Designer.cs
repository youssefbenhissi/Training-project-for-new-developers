namespace WindowsFormsCarApp
{
    partial class FormOfACar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxHorsePower = new System.Windows.Forms.TextBox();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfWheels = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfLeters = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "HorsePower";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mileage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "NumberOfWheels";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "SerialNumber";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "NumberOfLeters";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Age";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(355, 7);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(355, 60);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 22);
            this.textBoxBrand.TabIndex = 11;
            // 
            // textBoxHorsePower
            // 
            this.textBoxHorsePower.Location = new System.Drawing.Point(355, 118);
            this.textBoxHorsePower.Name = "textBoxHorsePower";
            this.textBoxHorsePower.Size = new System.Drawing.Size(100, 22);
            this.textBoxHorsePower.TabIndex = 12;
            this.textBoxHorsePower.TextChanged += new System.EventHandler(this.textBoxHorsePower_TextChanged);
            this.textBoxHorsePower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.horse_powerkey_press);
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Location = new System.Drawing.Point(355, 175);
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(100, 22);
            this.textBoxMileage.TabIndex = 13;
            this.textBoxMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.horse_powerkey_press);
            // 
            // textBoxNumberOfWheels
            // 
            this.textBoxNumberOfWheels.Location = new System.Drawing.Point(355, 238);
            this.textBoxNumberOfWheels.Name = "textBoxNumberOfWheels";
            this.textBoxNumberOfWheels.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberOfWheels.TabIndex = 14;
            this.textBoxNumberOfWheels.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.horse_powerkey_press);
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(355, 302);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 22);
            this.textBoxColor.TabIndex = 15;
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(355, 358);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxSerialNumber.TabIndex = 16;
            this.textBoxSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.horse_powerkey_press);
            // 
            // textBoxNumberOfLeters
            // 
            this.textBoxNumberOfLeters.Location = new System.Drawing.Point(355, 406);
            this.textBoxNumberOfLeters.Name = "textBoxNumberOfLeters";
            this.textBoxNumberOfLeters.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberOfLeters.TabIndex = 17;
            this.textBoxNumberOfLeters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.horse_powerkey_press);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(355, 445);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxAge.TabIndex = 18;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.horse_powerkey_press);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(574, 502);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 19;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormOfACar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 537);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxNumberOfLeters);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxNumberOfWheels);
            this.Controls.Add(this.textBoxMileage);
            this.Controls.Add(this.textBoxHorsePower);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormOfACar";
            this.Text = "FormOfACar";
            this.Load += new System.EventHandler(this.FormOfACar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxHorsePower;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.TextBox textBoxNumberOfWheels;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxNumberOfLeters;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonConfirm;
    }
}