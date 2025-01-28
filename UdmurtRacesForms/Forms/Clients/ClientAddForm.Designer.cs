namespace UdmurtFlights.Forms.Clients
{
    partial class ClientAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientAddForm));
            AddBtn = new Button();
            LastNameInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            FirstNameInput = new TextBox();
            label3 = new Label();
            MiddleNameInput = new TextBox();
            label4 = new Label();
            AddressInput = new TextBox();
            label5 = new Label();
            EmailInput = new TextBox();
            label6 = new Label();
            PhoneNumberInput = new TextBox();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Enabled = false;
            AddBtn.Location = new Point(90, 399);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(100, 50);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // LastNameInput
            // 
            LastNameInput.Location = new Point(12, 66);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(260, 29);
            LastNameInput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 3;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(40, 23);
            label2.TabIndex = 5;
            label2.Text = "Имя";
            // 
            // FirstNameInput
            // 
            FirstNameInput.Location = new Point(12, 126);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(260, 29);
            FirstNameInput.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 7;
            label3.Text = "Отчество";
            // 
            // MiddleNameInput
            // 
            MiddleNameInput.Location = new Point(12, 185);
            MiddleNameInput.Name = "MiddleNameInput";
            MiddleNameInput.Size = new Size(260, 29);
            MiddleNameInput.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 338);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 9;
            label4.Text = "Адрес";
            // 
            // AddressInput
            // 
            AddressInput.Location = new Point(12, 364);
            AddressInput.Name = "AddressInput";
            AddressInput.Size = new Size(260, 29);
            AddressInput.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 217);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(12, 243);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(260, 29);
            EmailInput.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 280);
            label6.Name = "label6";
            label6.Size = new Size(77, 23);
            label6.TabIndex = 13;
            label6.Text = "Телефон";
            // 
            // PhoneNumberInput
            // 
            PhoneNumberInput.Location = new Point(12, 306);
            PhoneNumberInput.Name = "PhoneNumberInput";
            PhoneNumberInput.Size = new Size(260, 29);
            PhoneNumberInput.TabIndex = 10;
            // 
            // ClientsAddForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(284, 461);
            Controls.Add(label6);
            Controls.Add(PhoneNumberInput);
            Controls.Add(label5);
            Controls.Add(EmailInput);
            Controls.Add(label4);
            Controls.Add(AddressInput);
            Controls.Add(label3);
            Controls.Add(MiddleNameInput);
            Controls.Add(label2);
            Controls.Add(FirstNameInput);
            Controls.Add(label1);
            Controls.Add(LastNameInput);
            Controls.Add(AddBtn);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "ClientsAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление клиента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clientsBtn;
        private Button AddBtn;
        private TextBox LastNameInput;
        private Label label1;
        private Label label2;
        private TextBox FirstNameInput;
        private Label label3;
        private TextBox MiddleNameInput;
        private Label label4;
        private TextBox AddressInput;
        private Label label5;
        private TextBox EmailInput;
        private Label label6;
        private TextBox PhoneNumberInput;
        private Button flightsBtn;
    }
}