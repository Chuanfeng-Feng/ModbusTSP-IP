namespace Курсач
{
    partial class Form3
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
            this.label_data = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_givedata = new System.Windows.Forms.Button();
            this.button_changedata = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioInput = new System.Windows.Forms.RadioButton();
            this.RadioHolding = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.startingAddress = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_data.Location = new System.Drawing.Point(98, 9);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(234, 21);
            this.label_data.TabIndex = 4;
            this.label_data.Text = "Чтение/изменение данных";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adress,
            this.data});
            this.dataGridView1.Location = new System.Drawing.Point(91, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(248, 212);
            this.dataGridView1.TabIndex = 5;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Adress";
            this.Adress.Name = "Adress";
            // 
            // data
            // 
            this.data.DataPropertyName = "cels_data";
            this.data.HeaderText = "data";
            this.data.Name = "data";
            // 
            // button_givedata
            // 
            this.button_givedata.Location = new System.Drawing.Point(23, 143);
            this.button_givedata.Name = "button_givedata";
            this.button_givedata.Size = new System.Drawing.Size(192, 47);
            this.button_givedata.TabIndex = 6;
            this.button_givedata.Text = "Получить данные";
            this.button_givedata.UseVisualStyleBackColor = true;
            this.button_givedata.Click += new System.EventHandler(this.button_givedata_Click);
            // 
            // button_changedata
            // 
            this.button_changedata.Enabled = false;
            this.button_changedata.Location = new System.Drawing.Point(221, 143);
            this.button_changedata.Name = "button_changedata";
            this.button_changedata.Size = new System.Drawing.Size(192, 47);
            this.button_changedata.TabIndex = 6;
            this.button_changedata.Text = "Изменить данные";
            this.button_changedata.UseVisualStyleBackColor = true;
            this.button_changedata.Click += new System.EventHandler(this.button_changedata_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioInput);
            this.groupBox1.Controls.Add(this.RadioHolding);
            this.groupBox1.Location = new System.Drawing.Point(102, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 40);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // RadioInput
            // 
            this.RadioInput.AutoSize = true;
            this.RadioInput.Location = new System.Drawing.Point(131, 16);
            this.RadioInput.Name = "RadioInput";
            this.RadioInput.Size = new System.Drawing.Size(99, 17);
            this.RadioInput.TabIndex = 9;
            this.RadioInput.TabStop = true;
            this.RadioInput.Text = "Input Registers ";
            this.RadioInput.UseVisualStyleBackColor = true;
            // 
            // RadioHolding
            // 
            this.RadioHolding.AutoSize = true;
            this.RadioHolding.Location = new System.Drawing.Point(14, 16);
            this.RadioHolding.Name = "RadioHolding";
            this.RadioHolding.Size = new System.Drawing.Size(111, 17);
            this.RadioHolding.TabIndex = 8;
            this.RadioHolding.TabStop = true;
            this.RadioHolding.Text = "Holding Registers ";
            this.RadioHolding.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите начальный адресс";
            // 
            // startingAddress
            // 
            this.startingAddress.Location = new System.Drawing.Point(242, 86);
            this.startingAddress.Name = "startingAddress";
            this.startingAddress.Size = new System.Drawing.Size(166, 20);
            this.startingAddress.TabIndex = 6;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(221, 113);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(187, 20);
            this.quantity.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ваш конечный адресс";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.startingAddress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_changedata);
            this.Controls.Add(this.button_givedata);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_data);
            this.Name = "Form3";
            this.Text = "Работа с данными";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_givedata;
        private System.Windows.Forms.Button button_changedata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startingAddress;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.RadioButton RadioInput;
        private System.Windows.Forms.RadioButton RadioHolding;
    }
}