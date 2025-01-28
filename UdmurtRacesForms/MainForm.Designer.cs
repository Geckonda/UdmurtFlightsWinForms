namespace UdmurtFlights
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            clientsBtn = new Button();
            ticketsBtn = new Button();
            flightsBtn = new Button();
            SuspendLayout();
            // 
            // clientsBtn
            // 
            clientsBtn.Location = new Point(90, 50);
            clientsBtn.Name = "clientsBtn";
            clientsBtn.Size = new Size(100, 50);
            clientsBtn.TabIndex = 0;
            clientsBtn.Text = "Клиенты";
            clientsBtn.UseVisualStyleBackColor = true;
            clientsBtn.Click += ClientsBtn_Click;
            // 
            // ticketsBtn
            // 
            ticketsBtn.Location = new Point(90, 162);
            ticketsBtn.Name = "ticketsBtn";
            ticketsBtn.Size = new Size(100, 50);
            ticketsBtn.TabIndex = 1;
            ticketsBtn.Text = "Билеты";
            ticketsBtn.UseVisualStyleBackColor = true;
            ticketsBtn.Click += TicketsBtn_Click;
            // 
            // flightsBtn
            // 
            flightsBtn.Location = new Point(90, 106);
            flightsBtn.Name = "flightsBtn";
            flightsBtn.Size = new Size(100, 50);
            flightsBtn.TabIndex = 2;
            flightsBtn.Text = "Рейсы";
            flightsBtn.UseVisualStyleBackColor = true;
            flightsBtn.Click += FlightsBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(284, 261);
            Controls.Add(flightsBtn);
            Controls.Add(ticketsBtn);
            Controls.Add(clientsBtn);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            ResumeLayout(false);
        }

        #endregion

        private Button clientsBtn;
        private Button ticketsBtn;
        private Button flightsBtn;
    }
}