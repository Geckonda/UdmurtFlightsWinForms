using UdmurtFlights.Forms.Clients;

namespace UdmurtFlights.Forms.Flights
{
    partial class FlightAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightAddForm));
            AddBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            DestinationInput = new TextBox();
            label4 = new Label();
            DescriptionInput = new TextBox();
            label5 = new Label();
            label6 = new Label();
            DateInput = new DateTimePicker();
            TimeInput = new MaskedTextBox();
            SeatAmountInput = new NumericUpDown();
            TicketPriceAmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)SeatAmountInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TicketPriceAmount).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 3;
            label1.Text = "Дата рейса";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 5;
            label2.Text = "Время ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 7;
            label3.Text = "Пункт назначения";
            // 
            // DestinationInput
            // 
            DestinationInput.Location = new Point(12, 185);
            DestinationInput.Name = "DestinationInput";
            DestinationInput.Size = new Size(260, 29);
            DestinationInput.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 338);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 9;
            label4.Text = "Описание";
            // 
            // DescriptionInput
            // 
            DescriptionInput.Location = new Point(12, 364);
            DescriptionInput.Name = "DescriptionInput";
            DescriptionInput.Size = new Size(260, 29);
            DescriptionInput.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 275);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 11;
            label5.Text = "Цена билета";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 217);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 13;
            label6.Text = "Кол-во мест";
            // 
            // DateInput
            // 
            DateInput.Location = new Point(12, 68);
            DateInput.Name = "DateInput";
            DateInput.Size = new Size(260, 29);
            DateInput.TabIndex = 14;
            // 
            // TimeInput
            // 
            TimeInput.Location = new Point(12, 126);
            TimeInput.Mask = "00:00";
            TimeInput.Name = "TimeInput";
            TimeInput.Size = new Size(260, 29);
            TimeInput.TabIndex = 15;
            TimeInput.TextAlign = HorizontalAlignment.Center;
            TimeInput.ValidatingType = typeof(DateTime);
            // 
            // SeatAmountInput
            // 
            SeatAmountInput.Location = new Point(12, 243);
            SeatAmountInput.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            SeatAmountInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SeatAmountInput.Name = "SeatAmountInput";
            SeatAmountInput.Size = new Size(260, 29);
            SeatAmountInput.TabIndex = 16;
            SeatAmountInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TicketPriceAmount
            // 
            TicketPriceAmount.DecimalPlaces = 2;
            TicketPriceAmount.Location = new Point(12, 306);
            TicketPriceAmount.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            TicketPriceAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TicketPriceAmount.Name = "TicketPriceAmount";
            TicketPriceAmount.Size = new Size(260, 29);
            TicketPriceAmount.TabIndex = 17;
            TicketPriceAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FlightAddForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(284, 461);
            Controls.Add(TicketPriceAmount);
            Controls.Add(SeatAmountInput);
            Controls.Add(TimeInput);
            Controls.Add(DateInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(DescriptionInput);
            Controls.Add(label3);
            Controls.Add(DestinationInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddBtn);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FlightAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление рейса";
            ((System.ComponentModel.ISupportInitialize)SeatAmountInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)TicketPriceAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clientsBtn;
        private Button AddBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox DestinationInput;
        private Label label4;
        private TextBox DescriptionInput;
        private Label label5;
        private Label label6;
        private Button flightsBtn;
        private DateTimePicker DateInput;
        private MaskedTextBox TimeInput;
        private NumericUpDown SeatAmountInput;
        private NumericUpDown TicketPriceAmount;
    }
}