namespace UdmurtFlights.Forms.Clients
{
    partial class ClientListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientListForm));
            dataGridViewClients = new DataGridView();
            RefreshBtn = new Button();
            AddBtn = new Button();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(12, 68);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.Size = new Size(760, 325);
            dataGridViewClients.TabIndex = 0;
            dataGridViewClients.CellClick += dataGridViewClients_CellClick;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(672, 12);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(100, 50);
            RefreshBtn.TabIndex = 1;
            RefreshBtn.Text = "Обновить";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(12, 399);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(100, 50);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(118, 399);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(100, 50);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Удалить";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(224, 399);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(150, 50);
            UpdateBtn.TabIndex = 4;
            UpdateBtn.Text = "Редактировать";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ClientsListForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 461);
            Controls.Add(UpdateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(RefreshBtn);
            Controls.Add(dataGridViewClients);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "ClientsListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewClients;
        private Button RefreshBtn;
        private Button AddBtn;
        private Button DeleteBtn;
        private Button UpdateBtn;
    }
}