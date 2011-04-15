namespace LorD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.bnStart = new System.Windows.Forms.Button();
            this.lbChg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnStart
            // 
            this.bnStart.Location = new System.Drawing.Point(81, 191);
            this.bnStart.Name = "bnStart";
            this.bnStart.Size = new System.Drawing.Size(72, 20);
            this.bnStart.TabIndex = 0;
            this.bnStart.Text = "开始";
            this.bnStart.Click += new System.EventHandler(this.bnStart_Click);
            // 
            // lbChg
            // 
            this.lbChg.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular);
            this.lbChg.Location = new System.Drawing.Point(44, 54);
            this.lbChg.Name = "lbChg";
            this.lbChg.Size = new System.Drawing.Size(146, 109);
            this.lbChg.Text = "正";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.Text = "先想好正和反是什么点再点开始";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbChg);
            this.Controls.Add(this.bnStart);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "不再犹豫";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnStart;
        private System.Windows.Forms.Label lbChg;
        private System.Windows.Forms.Label label2;
    }
}

