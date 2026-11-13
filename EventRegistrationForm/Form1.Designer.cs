namespace EventRegistrationForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstEvents = new ListBox();
            btnRegister = new Button();
            txtTicket = new TextBox();
            lblEvent = new Label();
            txtLabel = new Label();
            SuspendLayout();
            // 
            // lstEvents
            // 
            lstEvents.FormattingEnabled = true;
            lstEvents.Location = new Point(35, 56);
            lstEvents.Name = "lstEvents";
            lstEvents.Size = new Size(180, 129);
            lstEvents.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(69, 191);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtTicket
            // 
            txtTicket.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTicket.Location = new Point(297, 56);
            txtTicket.Multiline = true;
            txtTicket.Name = "txtTicket";
            txtTicket.ReadOnly = true;
            txtTicket.Size = new Size(388, 158);
            txtTicket.TabIndex = 2;
            txtTicket.TextChanged += textBox1_TextChanged;
            // 
            // lblEvent
            // 
            lblEvent.AutoSize = true;
            lblEvent.Location = new Point(35, 19);
            lblEvent.Name = "lblEvent";
            lblEvent.Size = new Size(77, 25);
            lblEvent.TabIndex = 3;
            lblEvent.Text = "EVENTS:";
            // 
            // txtLabel
            // 
            txtLabel.AutoSize = true;
            txtLabel.Location = new Point(297, 19);
            txtLabel.Name = "txtLabel";
            txtLabel.Size = new Size(142, 25);
            txtLabel.TabIndex = 4;
            txtLabel.Text = "TICKET PRINTER:";
            txtLabel.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLabel);
            Controls.Add(lblEvent);
            Controls.Add(txtTicket);
            Controls.Add(btnRegister);
            Controls.Add(lstEvents);
            Name = "Form1";
            Text = "EventRegistrationSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEvents;
        private Button btnRegister;
        private TextBox txtTicket;
        private Label lblEvent;
        private Label txtLabel;
    }
}
