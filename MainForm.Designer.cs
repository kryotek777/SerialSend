namespace SerialSend
{
    partial class MainForm
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
            filePathTb = new TextBox();
            chooseFileBtn = new Button();
            SendButton = new Button();
            serialPortCombo = new ComboBox();
            filePathLbl = new Label();
            label2 = new Label();
            label3 = new Label();
            baudRateCombo = new ComboBox();
            label4 = new Label();
            parityCombo = new ComboBox();
            label5 = new Label();
            dataBitsCombo = new ComboBox();
            label1 = new Label();
            stopBitsCombo = new ComboBox();
            SuspendLayout();
            // 
            // filePathTb
            // 
            filePathTb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filePathTb.Location = new Point(12, 27);
            filePathTb.Name = "filePathTb";
            filePathTb.PlaceholderText = "Percorso file...";
            filePathTb.Size = new Size(171, 23);
            filePathTb.TabIndex = 0;
            // 
            // chooseFileBtn
            // 
            chooseFileBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chooseFileBtn.Location = new Point(189, 27);
            chooseFileBtn.Name = "chooseFileBtn";
            chooseFileBtn.Size = new Size(75, 23);
            chooseFileBtn.TabIndex = 1;
            chooseFileBtn.Text = "Scegli file";
            chooseFileBtn.UseVisualStyleBackColor = true;
            chooseFileBtn.Click += chooseFileBtn_Click;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(12, 276);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(253, 44);
            SendButton.TabIndex = 2;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // serialPortCombo
            // 
            serialPortCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            serialPortCombo.FormattingEnabled = true;
            serialPortCombo.Location = new Point(12, 71);
            serialPortCombo.Name = "serialPortCombo";
            serialPortCombo.Size = new Size(253, 23);
            serialPortCombo.Sorted = true;
            serialPortCombo.TabIndex = 3;
            // 
            // filePathLbl
            // 
            filePathLbl.AutoSize = true;
            filePathLbl.Location = new Point(12, 9);
            filePathLbl.Name = "filePathLbl";
            filePathLbl.Size = new Size(79, 15);
            filePathLbl.TabIndex = 5;
            filePathLbl.Text = "File da inviare";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 6;
            label2.Text = "Porta COM (Seriale)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 8;
            label3.Text = "Baud Rate (Velocità)";
            // 
            // baudRateCombo
            // 
            baudRateCombo.FormattingEnabled = true;
            baudRateCombo.Location = new Point(12, 115);
            baudRateCombo.Name = "baudRateCombo";
            baudRateCombo.Size = new Size(253, 23);
            baudRateCombo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 10;
            label4.Text = "Parity";
            // 
            // parityCombo
            // 
            parityCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            parityCombo.FormattingEnabled = true;
            parityCombo.Location = new Point(12, 159);
            parityCombo.Name = "parityCombo";
            parityCombo.Size = new Size(253, 23);
            parityCombo.Sorted = true;
            parityCombo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 12;
            label5.Text = "Data Bits";
            // 
            // dataBitsCombo
            // 
            dataBitsCombo.FormattingEnabled = true;
            dataBitsCombo.Location = new Point(12, 203);
            dataBitsCombo.Name = "dataBitsCombo";
            dataBitsCombo.Size = new Size(253, 23);
            dataBitsCombo.Sorted = true;
            dataBitsCombo.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 229);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 14;
            label1.Text = "Stop Bits";
            // 
            // stopBitsCombo
            // 
            stopBitsCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            stopBitsCombo.FormattingEnabled = true;
            stopBitsCombo.Location = new Point(12, 247);
            stopBitsCombo.Name = "stopBitsCombo";
            stopBitsCombo.Size = new Size(253, 23);
            stopBitsCombo.Sorted = true;
            stopBitsCombo.TabIndex = 13;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 334);
            Controls.Add(label1);
            Controls.Add(stopBitsCombo);
            Controls.Add(label5);
            Controls.Add(dataBitsCombo);
            Controls.Add(label4);
            Controls.Add(parityCombo);
            Controls.Add(label3);
            Controls.Add(baudRateCombo);
            Controls.Add(label2);
            Controls.Add(filePathLbl);
            Controls.Add(serialPortCombo);
            Controls.Add(SendButton);
            Controls.Add(chooseFileBtn);
            Controls.Add(filePathTb);
            Name = "MainForm";
            Text = "SerialSend";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox filePathTb;
        private Button chooseFileBtn;
        private Button SendButton;
        private ComboBox serialPortCombo;
        private Label filePathLbl;
        private Label label2;
        private Label label3;
        private ComboBox baudRateCombo;
        private Label label4;
        private ComboBox parityCombo;
        private Label label5;
        private ComboBox dataBitsCombo;
        private Label label1;
        private ComboBox stopBitsCombo;
    }
}
