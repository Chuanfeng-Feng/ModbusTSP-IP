namespace Курсач
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
            this.button_conect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ipbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.portbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_conect
            // 
            this.button_conect.Location = new System.Drawing.Point(113, 260);
            this.button_conect.Name = "button_conect";
            this.button_conect.Size = new System.Drawing.Size(192, 47);
            this.button_conect.TabIndex = 1;
            this.button_conect.Text = "Подключиться";
            this.button_conect.UseVisualStyleBackColor = true;
            this.button_conect.Click += new System.EventHandler(this.button_conect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(113, 313);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(192, 47);
            this.button_disconnect.TabIndex = 2;
            this.button_disconnect.Text = "Отключиться";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Подключение к серверу";
            // 
            // ipbox
            // 
            this.ipbox.Location = new System.Drawing.Point(186, 107);
            this.ipbox.Name = "ipbox";
            this.ipbox.Size = new System.Drawing.Size(198, 20);
            this.ipbox.TabIndex = 4;
            this.ipbox.Text = "Ваш ip";
            this.ipbox.TextChanged += new System.EventHandler(this.ipbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите ip адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Состояние:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.ForeColor = System.Drawing.Color.Crimson;
            this.status.Location = new System.Drawing.Point(230, 206);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(55, 19);
            this.status.TabIndex = 6;
            this.status.Text = "offline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Введите порт:";
            // 
            // portbox
            // 
            this.portbox.Location = new System.Drawing.Point(186, 145);
            this.portbox.Name = "portbox";
            this.portbox.Size = new System.Drawing.Size(198, 20);
            this.portbox.TabIndex = 4;
            this.portbox.Text = "Ваш порт";
            this.portbox.TextChanged += new System.EventHandler(this.portbox_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 436);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portbox);
            this.Controls.Add(this.ipbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_conect);
            this.Name = "Form2";
            this.Text = "Подключение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_conect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox portbox;
    }
}