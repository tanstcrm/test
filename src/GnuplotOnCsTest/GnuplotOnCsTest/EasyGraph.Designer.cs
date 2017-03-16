namespace GnuplotOnCsTest
{
    partial class EasyGraph
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mainPictBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.analyseFileNameTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.graphTitleTbx = new System.Windows.Forms.TextBox();
            this.graphXlabelTbx = new System.Windows.Forms.TextBox();
            this.graphYlabelTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.graphCommentTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.graphHistMinTbx = new System.Windows.Forms.TextBox();
            this.graphHistMaxTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.graphHistWidthTbx = new System.Windows.Forms.TextBox();
            this.graphMakeBtn = new System.Windows.Forms.Button();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "sin(x)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1009, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "reflesh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainPictBox
            // 
            this.mainPictBox.Location = new System.Drawing.Point(486, 21);
            this.mainPictBox.Name = "mainPictBox";
            this.mainPictBox.Size = new System.Drawing.Size(733, 523);
            this.mainPictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictBox.TabIndex = 3;
            this.mainPictBox.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "cos(y)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // analyseFileNameTbx
            // 
            this.analyseFileNameTbx.AllowDrop = true;
            this.analyseFileNameTbx.Location = new System.Drawing.Point(12, 12);
            this.analyseFileNameTbx.Name = "analyseFileNameTbx";
            this.analyseFileNameTbx.Size = new System.Drawing.Size(442, 25);
            this.analyseFileNameTbx.TabIndex = 6;
            this.analyseFileNameTbx.Text = "D&D file here";
            this.analyseFileNameTbx.DragDrop += new System.Windows.Forms.DragEventHandler(this.analyseFileNameTbx_DragDrop);
            this.analyseFileNameTbx.DragEnter += new System.Windows.Forms.DragEventHandler(this.analyseFileNameTbx_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // graphTitleTbx
            // 
            this.graphTitleTbx.Location = new System.Drawing.Point(12, 94);
            this.graphTitleTbx.Name = "graphTitleTbx";
            this.graphTitleTbx.Size = new System.Drawing.Size(442, 25);
            this.graphTitleTbx.TabIndex = 8;
            this.graphTitleTbx.Text = "DriftTimeSpectrum";
            // 
            // graphXlabelTbx
            // 
            this.graphXlabelTbx.Location = new System.Drawing.Point(12, 150);
            this.graphXlabelTbx.Name = "graphXlabelTbx";
            this.graphXlabelTbx.Size = new System.Drawing.Size(178, 25);
            this.graphXlabelTbx.TabIndex = 9;
            this.graphXlabelTbx.Text = "Time[ns]";
            // 
            // graphYlabelTbx
            // 
            this.graphYlabelTbx.Location = new System.Drawing.Point(263, 150);
            this.graphYlabelTbx.Name = "graphYlabelTbx";
            this.graphYlabelTbx.Size = new System.Drawing.Size(191, 25);
            this.graphYlabelTbx.TabIndex = 10;
            this.graphYlabelTbx.Text = "Counts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "yLabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "xLabel";
            // 
            // graphCommentTbx
            // 
            this.graphCommentTbx.Location = new System.Drawing.Point(12, 207);
            this.graphCommentTbx.Name = "graphCommentTbx";
            this.graphCommentTbx.Size = new System.Drawing.Size(442, 25);
            this.graphCommentTbx.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "comment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Max";
            // 
            // graphHistMinTbx
            // 
            this.graphHistMinTbx.Location = new System.Drawing.Point(12, 309);
            this.graphHistMinTbx.Name = "graphHistMinTbx";
            this.graphHistMinTbx.Size = new System.Drawing.Size(84, 25);
            this.graphHistMinTbx.TabIndex = 17;
            this.graphHistMinTbx.Text = "-200";
            // 
            // graphHistMaxTbx
            // 
            this.graphHistMaxTbx.Location = new System.Drawing.Point(135, 309);
            this.graphHistMaxTbx.Name = "graphHistMaxTbx";
            this.graphHistMaxTbx.Size = new System.Drawing.Size(84, 25);
            this.graphHistMaxTbx.TabIndex = 16;
            this.graphHistMaxTbx.Text = "200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Width";
            // 
            // graphHistWidthTbx
            // 
            this.graphHistWidthTbx.Location = new System.Drawing.Point(263, 309);
            this.graphHistWidthTbx.Name = "graphHistWidthTbx";
            this.graphHistWidthTbx.Size = new System.Drawing.Size(84, 25);
            this.graphHistWidthTbx.TabIndex = 20;
            this.graphHistWidthTbx.Text = "5";
            // 
            // graphMakeBtn
            // 
            this.graphMakeBtn.Location = new System.Drawing.Point(12, 382);
            this.graphMakeBtn.Name = "graphMakeBtn";
            this.graphMakeBtn.Size = new System.Drawing.Size(114, 37);
            this.graphMakeBtn.TabIndex = 22;
            this.graphMakeBtn.Text = "Make";
            this.graphMakeBtn.UseVisualStyleBackColor = true;
            this.graphMakeBtn.Click += new System.EventHandler(this.graphMakeBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(533, 551);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(114, 37);
            this.saveFileBtn.TabIndex = 23;
            this.saveFileBtn.Text = "Save";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(187, 417);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(110, 33);
            this.resetBtn.TabIndex = 24;
            this.resetBtn.Text = "reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // EasyGraph
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 598);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.graphMakeBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.graphHistWidthTbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.graphHistMinTbx);
            this.Controls.Add(this.graphHistMaxTbx);
            this.Controls.Add(this.graphCommentTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.graphYlabelTbx);
            this.Controls.Add(this.graphXlabelTbx);
            this.Controls.Add(this.graphTitleTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.analyseFileNameTbx);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mainPictBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EasyGraph";
            this.Text = "Easy Hist";
            this.Load += new System.EventHandler(this.EasyGraph_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.EasyGraph_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.EasyGraph_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox mainPictBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox analyseFileNameTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox graphTitleTbx;
        private System.Windows.Forms.TextBox graphXlabelTbx;
        private System.Windows.Forms.TextBox graphYlabelTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox graphCommentTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox graphHistMinTbx;
        private System.Windows.Forms.TextBox graphHistMaxTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox graphHistWidthTbx;
        private System.Windows.Forms.Button graphMakeBtn;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}

