namespace bol
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
            BerekenButton = new Button();
            label1 = new Label();
            OppervlakteRadioButton = new RadioButton();
            InhoudRadioButton = new RadioButton();
            StraalTextBox = new TextBox();
            SuspendLayout();
            // 
            // BerekenButton
            // 
            BerekenButton.Location = new Point(12, 35);
            BerekenButton.Name = "BerekenButton";
            BerekenButton.Size = new Size(158, 23);
            BerekenButton.TabIndex = 0;
            BerekenButton.Text = "Bereken";
            BerekenButton.UseVisualStyleBackColor = true;
            BerekenButton.Click += BerekenButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Straal";
            // 
            // OppervlakteRadioButton
            // 
            OppervlakteRadioButton.AutoSize = true;
            OppervlakteRadioButton.Location = new Point(12, 64);
            OppervlakteRadioButton.Name = "OppervlakteRadioButton";
            OppervlakteRadioButton.Size = new Size(89, 19);
            OppervlakteRadioButton.TabIndex = 2;
            OppervlakteRadioButton.TabStop = true;
            OppervlakteRadioButton.Text = "Oppervlakte";
            OppervlakteRadioButton.UseVisualStyleBackColor = true;
            // 
            // InhoudRadioButton
            // 
            InhoudRadioButton.AutoSize = true;
            InhoudRadioButton.Location = new Point(107, 64);
            InhoudRadioButton.Name = "InhoudRadioButton";
            InhoudRadioButton.Size = new Size(63, 19);
            InhoudRadioButton.TabIndex = 3;
            InhoudRadioButton.TabStop = true;
            InhoudRadioButton.Text = "Inhoud";
            InhoudRadioButton.UseVisualStyleBackColor = true;
            // 
            // StraalTextBox
            // 
            StraalTextBox.Location = new Point(54, 6);
            StraalTextBox.Name = "StraalTextBox";
            StraalTextBox.Size = new Size(116, 23);
            StraalTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(183, 91);
            Controls.Add(StraalTextBox);
            Controls.Add(InhoudRadioButton);
            Controls.Add(OppervlakteRadioButton);
            Controls.Add(label1);
            Controls.Add(BerekenButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BerekenButton;
        private Label label1;
        private RadioButton OppervlakteRadioButton;
        private RadioButton InhoudRadioButton;
        private TextBox StraalTextBox;
    }
}
