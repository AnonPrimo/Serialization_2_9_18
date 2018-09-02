namespace WinFormApp_Serial_Deserial
{
    partial class Form1
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
            this.comboBox_Services = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Clients = new System.Windows.Forms.ComboBox();
            this.button_CreateOrder = new System.Windows.Forms.Button();
            this.button_AddService = new System.Windows.Forms.Button();
            this.comboBox_S3 = new System.Windows.Forms.ComboBox();
            this.comboBox_S2 = new System.Windows.Forms.ComboBox();
            this.comboBox_S1 = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Послуги";
            // 
            // comboBox_Services
            // 
            this.comboBox_Services.FormattingEnabled = true;
            this.comboBox_Services.Location = new System.Drawing.Point(110, 31);
            this.comboBox_Services.Name = "comboBox_Services";
            this.comboBox_Services.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Services.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Клієнти";
            // 
            // comboBox_Clients
            // 
            this.comboBox_Clients.FormattingEnabled = true;
            this.comboBox_Clients.Location = new System.Drawing.Point(83, 48);
            this.comboBox_Clients.Name = "comboBox_Clients";
            this.comboBox_Clients.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Clients.TabIndex = 3;
            // 
            // button_CreateOrder
            // 
            this.button_CreateOrder.Location = new System.Drawing.Point(38, 90);
            this.button_CreateOrder.Name = "button_CreateOrder";
            this.button_CreateOrder.Size = new System.Drawing.Size(166, 23);
            this.button_CreateOrder.TabIndex = 6;
            this.button_CreateOrder.Text = "Оформити замовлення";
            this.button_CreateOrder.UseVisualStyleBackColor = true;
            this.button_CreateOrder.Click += new System.EventHandler(this.button_CreateOrder_Click);
            // 
            // button_AddService
            // 
            this.button_AddService.Location = new System.Drawing.Point(83, 19);
            this.button_AddService.Name = "button_AddService";
            this.button_AddService.Size = new System.Drawing.Size(121, 23);
            this.button_AddService.TabIndex = 7;
            this.button_AddService.Text = "Додати послугу";
            this.button_AddService.UseVisualStyleBackColor = true;
            this.button_AddService.Click += new System.EventHandler(this.button_AddService_Click);
            // 
            // comboBox_S3
            // 
            this.comboBox_S3.FormattingEnabled = true;
            this.comboBox_S3.Location = new System.Drawing.Point(110, 112);
            this.comboBox_S3.Name = "comboBox_S3";
            this.comboBox_S3.Size = new System.Drawing.Size(121, 21);
            this.comboBox_S3.TabIndex = 8;
            // 
            // comboBox_S2
            // 
            this.comboBox_S2.FormattingEnabled = true;
            this.comboBox_S2.Location = new System.Drawing.Point(110, 85);
            this.comboBox_S2.Name = "comboBox_S2";
            this.comboBox_S2.Size = new System.Drawing.Size(121, 21);
            this.comboBox_S2.TabIndex = 9;
            // 
            // comboBox_S1
            // 
            this.comboBox_S1.FormattingEnabled = true;
            this.comboBox_S1.Location = new System.Drawing.Point(110, 58);
            this.comboBox_S1.Name = "comboBox_S1";
            this.comboBox_S1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_S1.TabIndex = 10;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button_AddService);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.comboBox_Clients);
            this.groupBox.Controls.Add(this.button_CreateOrder);
            this.groupBox.Location = new System.Drawing.Point(30, 58);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(235, 127);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(307, 199);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.comboBox_S1);
            this.Controls.Add(this.comboBox_S2);
            this.Controls.Add(this.comboBox_S3);
            this.Controls.Add(this.comboBox_Services);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Services;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Clients;
        private System.Windows.Forms.Button button_CreateOrder;
        private System.Windows.Forms.Button button_AddService;
        private System.Windows.Forms.ComboBox comboBox_S3;
        private System.Windows.Forms.ComboBox comboBox_S2;
        private System.Windows.Forms.ComboBox comboBox_S1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Timer timer1;
    }
}

