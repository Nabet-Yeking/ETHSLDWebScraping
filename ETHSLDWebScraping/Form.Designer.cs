namespace ETHSLDWebScraping
{
    partial class Form
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
            label1 = new Label();
            wordLbl = new Label();
            countLbl = new Label();
            scrapingPrBar = new ProgressBar();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            wordURILbl = new Label();
            wordDetailURILbl = new Label();
            videoDataURILbl = new Label();
            startBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gagalin", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(189, 28);
            label1.Name = "label1";
            label1.Size = new Size(485, 48);
            label1.TabIndex = 0;
            label1.Text = "ETHSLD Web Scarping Tool";
            // 
            // wordLbl
            // 
            wordLbl.AutoSize = true;
            wordLbl.Location = new Point(47, 175);
            wordLbl.Name = "wordLbl";
            wordLbl.Size = new Size(53, 25);
            wordLbl.TabIndex = 1;
            wordLbl.Text = "word";
            // 
            // countLbl
            // 
            countLbl.AutoSize = true;
            countLbl.Location = new Point(741, 176);
            countLbl.Name = "countLbl";
            countLbl.Size = new Size(22, 25);
            countLbl.TabIndex = 2;
            countLbl.Text = "0";
            // 
            // scrapingPrBar
            // 
            scrapingPrBar.Location = new Point(47, 113);
            scrapingPrBar.Name = "scrapingPrBar";
            scrapingPrBar.Size = new Size(761, 49);
            scrapingPrBar.Step = 1;
            scrapingPrBar.Style = ProgressBarStyle.Continuous;
            scrapingPrBar.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 317);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 10;
            label4.Text = "Video Data URI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 275);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 9;
            label3.Text = "Word Detail URI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 233);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 8;
            label2.Text = "Word URI:";
            // 
            // wordURILbl
            // 
            wordURILbl.AutoSize = true;
            wordURILbl.Location = new Point(146, 233);
            wordURILbl.Name = "wordURILbl";
            wordURILbl.Size = new Size(0, 25);
            wordURILbl.TabIndex = 12;
            // 
            // wordDetailURILbl
            // 
            wordDetailURILbl.AutoSize = true;
            wordDetailURILbl.Location = new Point(196, 275);
            wordDetailURILbl.Name = "wordDetailURILbl";
            wordDetailURILbl.Size = new Size(0, 25);
            wordDetailURILbl.TabIndex = 13;
            // 
            // videoDataURILbl
            // 
            videoDataURILbl.AutoSize = true;
            videoDataURILbl.Location = new Point(189, 317);
            videoDataURILbl.Name = "videoDataURILbl";
            videoDataURILbl.Size = new Size(0, 25);
            videoDataURILbl.TabIndex = 14;
            // 
            // startBtn
            // 
            startBtn.Cursor = Cursors.Hand;
            startBtn.Location = new Point(735, 346);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(73, 34);
            startBtn.TabIndex = 15;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 401);
            Controls.Add(startBtn);
            Controls.Add(videoDataURILbl);
            Controls.Add(wordDetailURILbl);
            Controls.Add(wordURILbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(scrapingPrBar);
            Controls.Add(countLbl);
            Controls.Add(wordLbl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form";
            Text = "ETHSLD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label wordLbl;
        private Label countLbl;
        private ProgressBar scrapingPrBar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label wordURILbl;
        private Label wordDetailURILbl;
        private Label videoDataURILbl;
        private Button startBtn;
    }
}
