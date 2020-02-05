namespace Курсач
{
    partial class Main_Page
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
            this.button_menu_conect = new System.Windows.Forms.Button();
            this.button_give_data = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioServer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioKlient = new System.Windows.Forms.RadioButton();
            this.statusServer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_menu_conect
            // 
            this.button_menu_conect.Enabled = false;
            this.button_menu_conect.Location = new System.Drawing.Point(109, 212);
            this.button_menu_conect.Name = "button_menu_conect";
            this.button_menu_conect.Size = new System.Drawing.Size(192, 47);
            this.button_menu_conect.TabIndex = 0;
            this.button_menu_conect.Text = "Подключение";
            this.button_menu_conect.UseVisualStyleBackColor = true;
            this.button_menu_conect.Click += new System.EventHandler(this.button_conect_Click);
            // 
            // button_give_data
            // 
            this.button_give_data.Enabled = false;
            this.button_give_data.Location = new System.Drawing.Point(109, 265);
            this.button_give_data.Name = "button_give_data";
            this.button_give_data.Size = new System.Drawing.Size(192, 47);
            this.button_give_data.TabIndex = 0;
            this.button_give_data.Text = "Чтение/изменение данных";
            this.button_give_data.UseVisualStyleBackColor = true;
            this.button_give_data.Click += new System.EventHandler(this.button_give);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Программа обмена данными \r\n  по протоколу MODBUS TCP";
            // 
            // RadioServer
            // 
            this.RadioServer.AutoSize = true;
            this.RadioServer.Location = new System.Drawing.Point(6, 17);
            this.RadioServer.Name = "RadioServer";
            this.RadioServer.Size = new System.Drawing.Size(78, 17);
            this.RadioServer.TabIndex = 2;
            this.RadioServer.TabStop = true;
            this.RadioServer.Text = "TCP server";
            this.RadioServer.UseVisualStyleBackColor = true;
            this.RadioServer.CheckedChanged += new System.EventHandler(this.RadioServer_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioKlient);
            this.groupBox1.Controls.Add(this.RadioServer);
            this.groupBox1.Location = new System.Drawing.Point(103, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 40);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // RadioKlient
            // 
            this.RadioKlient.AutoSize = true;
            this.RadioKlient.Location = new System.Drawing.Point(112, 17);
            this.RadioKlient.Name = "RadioKlient";
            this.RadioKlient.Size = new System.Drawing.Size(74, 17);
            this.RadioKlient.TabIndex = 3;
            this.RadioKlient.TabStop = true;
            this.RadioKlient.Text = "TCP client";
            this.RadioKlient.UseVisualStyleBackColor = true;
            // 
            // statusServer
            // 
            this.statusServer.AutoSize = true;
            this.statusServer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusServer.ForeColor = System.Drawing.Color.Crimson;
            this.statusServer.Location = new System.Drawing.Point(267, 106);
            this.statusServer.Name = "statusServer";
            this.statusServer.Size = new System.Drawing.Size(55, 19);
            this.statusServer.TabIndex = 7;
            this.statusServer.Text = "offline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Состояние сервера:";
            // 
            // buttonServer
            // 
            this.buttonServer.Enabled = false;
            this.buttonServer.Location = new System.Drawing.Point(109, 159);
            this.buttonServer.Name = "buttonServer";
            this.buttonServer.Size = new System.Drawing.Size(192, 47);
            this.buttonServer.TabIndex = 9;
            this.buttonServer.Text = "Запуск/Остановка сервера";
            this.buttonServer.UseVisualStyleBackColor = true;
            this.buttonServer.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(267, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "disabled";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Состояние подключения:";
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonServer);
            this.Controls.Add(this.statusServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_give_data);
            this.Controls.Add(this.button_menu_conect);
            this.Name = "Main_Page";
            this.Text = "ModbusTCP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_menu_conect;
        private System.Windows.Forms.Button button_give_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioKlient;
        private System.Windows.Forms.Label statusServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

