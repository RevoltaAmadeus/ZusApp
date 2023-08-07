namespace ZusApp
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
            components = new System.ComponentModel.Container();
            panel = new Panel();
            boxik = new Panel();
            datumText = new TextBox();
            text2 = new Label();
            text1 = new Label();
            kolonkaObor = new ComboBox();
            nadpis2 = new Label();
            vysledek = new TextBox();
            nadpis1 = new Label();
            enterButton = new Button();
            toolTips = new ToolTip(components);
            panel.SuspendLayout();
            boxik.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.Violet;
            panel.Controls.Add(boxik);
            panel.Controls.Add(nadpis2);
            panel.Controls.Add(vysledek);
            panel.Controls.Add(nadpis1);
            panel.Controls.Add(enterButton);
            panel.Location = new Point(-3, -2);
            panel.Margin = new Padding(0);
            panel.Name = "panel";
            panel.Size = new Size(361, 294);
            panel.TabIndex = 0;
            // 
            // boxik
            // 
            boxik.Controls.Add(datumText);
            boxik.Controls.Add(text2);
            boxik.Controls.Add(text1);
            boxik.Controls.Add(kolonkaObor);
            boxik.Location = new Point(19, 43);
            boxik.Name = "boxik";
            boxik.Size = new Size(323, 76);
            boxik.TabIndex = 11;
            // 
            // datumText
            // 
            datumText.BackColor = Color.White;
            datumText.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            datumText.Location = new Point(20, 35);
            datumText.Name = "datumText";
            datumText.Size = new Size(175, 32);
            datumText.TabIndex = 13;
            datumText.Text = "00.00.0000";
            datumText.TextAlign = HorizontalAlignment.Center;
            toolTips.SetToolTip(datumText, "Sem napište datum narození žáka ve formátu dd.mm.rrrr (oddělujte prosím tečkami).");
            datumText.TextChanged += datumText_TextChanged;
            // 
            // text2
            // 
            text2.AutoSize = true;
            text2.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text2.Location = new Point(250, 5);
            text2.Name = "text2";
            text2.Size = new Size(49, 21);
            text2.TabIndex = 10;
            text2.Text = "Obor:";
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text1.Location = new Point(42, 5);
            text1.Name = "text1";
            text1.Size = new Size(133, 21);
            text1.TabIndex = 9;
            text1.Text = "Datum narození:";
            // 
            // kolonkaObor
            // 
            kolonkaObor.Font = new Font("Bahnschrift", 17F, FontStyle.Regular, GraphicsUnit.Point);
            kolonkaObor.Items.AddRange(new object[] { "HO", "VO" });
            kolonkaObor.Location = new Point(237, 28);
            kolonkaObor.Name = "kolonkaObor";
            kolonkaObor.Size = new Size(74, 42);
            kolonkaObor.TabIndex = 1;
            kolonkaObor.Text = "HO";
            toolTips.SetToolTip(kolonkaObor, "Vyberte z následujících oborů: HO, VO");
            // 
            // nadpis2
            // 
            nadpis2.AutoSize = true;
            nadpis2.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nadpis2.Location = new Point(73, 205);
            nadpis2.Name = "nadpis2";
            nadpis2.Size = new Size(210, 36);
            nadpis2.TabIndex = 5;
            nadpis2.Text = "Zařazení žáka:";
            // 
            // vysledek
            // 
            vysledek.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vysledek.Location = new Point(13, 246);
            vysledek.Name = "vysledek";
            vysledek.Size = new Size(337, 32);
            vysledek.TabIndex = 4;
            // 
            // nadpis1
            // 
            nadpis1.AutoSize = true;
            nadpis1.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nadpis1.Location = new Point(25, 5);
            nadpis1.Name = "nadpis1";
            nadpis1.Size = new Size(313, 36);
            nadpis1.TabIndex = 3;
            nadpis1.Text = "Zadej parametry žáka:";
            // 
            // enterButton
            // 
            enterButton.BackColor = Color.MediumOrchid;
            enterButton.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            enterButton.Location = new Point(12, 130);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(337, 69);
            enterButton.TabIndex = 2;
            enterButton.Text = "Určit";
            toolTips.SetToolTip(enterButton, "Potvrďte vybrané parametry žáka a zjistěte jeho zařazení.");
            enterButton.UseVisualStyleBackColor = false;
            enterButton.Click += enterButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(357, 293);
            Controls.Add(panel);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            MinimumSize = new Size(375, 340);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZusApp v1.0";
            ClientSizeChanged += Form1_ClientSizeChanged;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            boxik.ResumeLayout(false);
            boxik.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private MonthCalendar monthCalendar1;
        private Button enterButton;
        private ComboBox kolonkaObor;
        private TextBox vysledek;
        private Label nadpis1;
        private ToolTip toolTips;
        private Label nadpis2;
        private Label text2;
        private Label text1;
        private Panel boxik;
        private TextBox datumText;
    }
}