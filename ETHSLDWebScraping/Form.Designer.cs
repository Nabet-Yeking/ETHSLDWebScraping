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
            progressBar1 = new ProgressBar();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gagalin", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(228, 28);
            label1.Name = "label1";
            label1.Size = new Size(485, 48);
            label1.TabIndex = 0;
            label1.Text = "ETHSLD Web Scarping Tool";
            // 
            // wordLbl
            // 
            wordLbl.AutoSize = true;
            wordLbl.Location = new Point(86, 189);
            wordLbl.Name = "wordLbl";
            wordLbl.Size = new Size(42, 25);
            wordLbl.TabIndex = 1;
            wordLbl.Text = "Test";
            // 
            // countLbl
            // 
            countLbl.AutoSize = true;
            countLbl.Location = new Point(780, 189);
            countLbl.Name = "countLbl";
            countLbl.Size = new Size(22, 25);
            countLbl.TabIndex = 2;
            countLbl.Text = "0";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(86, 113);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(761, 49);
            progressBar1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 352);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 10;
            label4.Text = "Video Data URI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 306);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 9;
            label3.Text = "Word Detail URI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 264);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 8;
            label2.Text = "Word URI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 223);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 11;
            label5.Text = "Detail";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 401);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(countLbl);
            Controls.Add(wordLbl);
            Controls.Add(label1);
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
        private ProgressBar progressBar1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}
