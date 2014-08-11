namespace ImageOrganizing
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.movePathTextBox1 = new System.Windows.Forms.TextBox();
            this.moveButton1 = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.selectionCopyButton = new System.Windows.Forms.Button();
            this.moveButton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.movePathTextBox2 = new System.Windows.Forms.TextBox();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.selectionPathTextBox = new System.Windows.Forms.TextBox();
            this.nextImageButton = new System.Windows.Forms.Button();
            this.moveButton4 = new System.Windows.Forms.Button();
            this.moveButton3 = new System.Windows.Forms.Button();
            this.moveButton6 = new System.Windows.Forms.Button();
            this.moveButton5 = new System.Windows.Forms.Button();
            this.moveButton8 = new System.Windows.Forms.Button();
            this.moveButton7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.movePathTextBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.movePathTextBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.movePathTextBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.movePathTextBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.movePathTextBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.movePathTextBox5 = new System.Windows.Forms.TextBox();
            this.moveButton10 = new System.Windows.Forms.Button();
            this.moveButton9 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.movePathTextBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.movePathTextBox9 = new System.Windows.Forms.TextBox();
            this.copyButton1 = new System.Windows.Forms.Button();
            this.copyButton2 = new System.Windows.Forms.Button();
            this.copyButton3 = new System.Windows.Forms.Button();
            this.copyButton4 = new System.Windows.Forms.Button();
            this.copyButton5 = new System.Windows.Forms.Button();
            this.copyButton6 = new System.Windows.Forms.Button();
            this.copyButton7 = new System.Windows.Forms.Button();
            this.copyButton8 = new System.Windows.Forms.Button();
            this.copyButton9 = new System.Windows.Forms.Button();
            this.copyButton10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1108, 568);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // movePathTextBox1
            // 
            this.movePathTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movePathTextBox1.Location = new System.Drawing.Point(1127, 35);
            this.movePathTextBox1.Multiline = true;
            this.movePathTextBox1.Name = "movePathTextBox1";
            this.movePathTextBox1.Size = new System.Drawing.Size(161, 27);
            this.movePathTextBox1.TabIndex = 1;
            // 
            // moveButton1
            // 
            this.moveButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveButton1.Enabled = false;
            this.moveButton1.Location = new System.Drawing.Point(128, 585);
            this.moveButton1.Name = "moveButton1";
            this.moveButton1.Size = new System.Drawing.Size(177, 33);
            this.moveButton1.TabIndex = 2;
            this.moveButton1.Text = "button1";
            this.moveButton1.UseVisualStyleBackColor = true;
            this.moveButton1.Click += new System.EventHandler(this.moveButton1_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(1093, 585);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(62, 33);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "画面更新";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(13, 585);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(98, 33);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // selectionCopyButton
            // 
            this.selectionCopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectionCopyButton.Enabled = false;
            this.selectionCopyButton.Location = new System.Drawing.Point(13, 619);
            this.selectionCopyButton.Name = "selectionCopyButton";
            this.selectionCopyButton.Size = new System.Drawing.Size(98, 33);
            this.selectionCopyButton.TabIndex = 5;
            this.selectionCopyButton.Text = "お気にへcopy";
            this.selectionCopyButton.UseVisualStyleBackColor = true;
            this.selectionCopyButton.Click += new System.EventHandler(this.selectionCopyButton_Click);
            // 
            // moveButton2
            // 
            this.moveButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveButton2.Enabled = false;
            this.moveButton2.Location = new System.Drawing.Point(128, 619);
            this.moveButton2.Name = "moveButton2";
            this.moveButton2.Size = new System.Drawing.Size(177, 33);
            this.moveButton2.TabIndex = 6;
            this.moveButton2.Text = "button2";
            this.moveButton2.UseVisualStyleBackColor = true;
            this.moveButton2.Click += new System.EventHandler(this.moveButton2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1128, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "ボタン1に対応するパスを記述";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1128, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "ボタン2に対応するパスを記述";
            // 
            // movePathTextBox2
            // 
            this.movePathTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movePathTextBox2.Location = new System.Drawing.Point(1127, 86);
            this.movePathTextBox2.Multiline = true;
            this.movePathTextBox2.Name = "movePathTextBox2";
            this.movePathTextBox2.Size = new System.Drawing.Size(161, 27);
            this.movePathTextBox2.TabIndex = 8;
            // 
            // selectionLabel
            // 
            this.selectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(1166, 589);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(157, 12);
            this.selectionLabel.TabIndex = 10;
            this.selectionLabel.Text = "お気に入りディレクトリパスを記述";
            // 
            // selectionPathTextBox
            // 
            this.selectionPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionPathTextBox.Location = new System.Drawing.Point(1161, 604);
            this.selectionPathTextBox.Multiline = true;
            this.selectionPathTextBox.Name = "selectionPathTextBox";
            this.selectionPathTextBox.Size = new System.Drawing.Size(171, 48);
            this.selectionPathTextBox.TabIndex = 11;
            // 
            // nextImageButton
            // 
            this.nextImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextImageButton.Enabled = false;
            this.nextImageButton.Location = new System.Drawing.Point(1093, 619);
            this.nextImageButton.Name = "nextImageButton";
            this.nextImageButton.Size = new System.Drawing.Size(62, 33);
            this.nextImageButton.TabIndex = 12;
            this.nextImageButton.Text = "次の画像";
            this.nextImageButton.UseVisualStyleBackColor = true;
            this.nextImageButton.Click += new System.EventHandler(this.nextImageButton_Click);
            // 
            // moveButton4
            // 
            this.moveButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveButton4.Enabled = false;
            this.moveButton4.Location = new System.Drawing.Point(322, 619);
            this.moveButton4.Name = "moveButton4";
            this.moveButton4.Size = new System.Drawing.Size(177, 33);
            this.moveButton4.TabIndex = 14;
            this.moveButton4.Text = "button4";
            this.moveButton4.UseVisualStyleBackColor = true;
            this.moveButton4.Click += new System.EventHandler(this.moveButton4_Click);
            // 
            // moveButton3
            // 
            this.moveButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveButton3.Enabled = false;
            this.moveButton3.Location = new System.Drawing.Point(322, 585);
            this.moveButton3.Name = "moveButton3";
            this.moveButton3.Size = new System.Drawing.Size(177, 33);
            this.moveButton3.TabIndex = 13;
            this.moveButton3.Text = "button3";
            this.moveButton3.UseVisualStyleBackColor = true;
            this.moveButton3.Click += new System.EventHandler(this.moveButton3_Click);
            // 
            // moveButton6
            // 
            this.moveButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveButton6.Enabled = false;
            this.moveButton6.Location = new System.Drawing.Point(515, 619);
            this.moveButton6.Name = "moveButton6";
            this.moveButton6.Size = new System.Drawing.Size(177, 33);
            this.moveButton6.TabIndex = 16;
            this.moveButton6.Text = "button6";
            this.moveButton6.UseVisualStyleBackColor = true;
            this.moveButton6.Click += new System.EventHandler(this.moveButton6_Click);
            // 
            // moveButton5
            // 
            this.moveButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveButton5.Enabled = false;
            this.moveButton5.Location = new System.Drawing.Point(515, 585);
            this.moveButton5.Name = "moveButton5";
            this.moveButton5.Size = new System.Drawing.Size(177, 33);
            this.moveButton5.TabIndex = 15;
            this.moveButton5.Text = "button5";
            this.moveButton5.UseVisualStyleBackColor = true;
            this.moveButton5.Click += new System.EventHandler(this.moveButton5_Click);
            // 
            // moveButton8
            // 
            this.moveButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveButton8.Enabled = false;
            this.moveButton8.Location = new System.Drawing.Point(709, 619);
            this.moveButton8.Name = "moveButton8";
            this.moveButton8.Size = new System.Drawing.Size(177, 33);
            this.moveButton8.TabIndex = 18;
            this.moveButton8.Text = "button8";
            this.moveButton8.UseVisualStyleBackColor = true;
            this.moveButton8.Click += new System.EventHandler(this.moveButton8_Click);
            // 
            // moveButton7
            // 
            this.moveButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveButton7.Enabled = false;
            this.moveButton7.Location = new System.Drawing.Point(709, 585);
            this.moveButton7.Name = "moveButton7";
            this.moveButton7.Size = new System.Drawing.Size(177, 33);
            this.moveButton7.TabIndex = 17;
            this.moveButton7.Text = "button7";
            this.moveButton7.UseVisualStyleBackColor = true;
            this.moveButton7.Click += new System.EventHandler(this.moveButton7_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1128, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "ボタン4に対応するパスを記述";
            // 
            // movePathTextBox4
            // 
            this.movePathTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movePathTextBox4.Location = new System.Drawing.Point(1127, 199);
            this.movePathTextBox4.Multiline = true;
            this.movePathTextBox4.Name = "movePathTextBox4";
            this.movePathTextBox4.Size = new System.Drawing.Size(161, 27);
            this.movePathTextBox4.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1128, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "ボタン3に対応するパスを記述";
            // 
            // movePathTextBox3
            // 
            this.movePathTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movePathTextBox3.Location = new System.Drawing.Point(1127, 142);
            this.movePathTextBox3.Multiline = true;
            this.movePathTextBox3.Name = "movePathTextBox3";
            this.movePathTextBox3.Size = new System.Drawing.Size(161, 27);
            this.movePathTextBox3.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1128, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "ボタン8に対応するパスを記述";
            // 
            // movePathTextBox8
            // 
            this.movePathTextBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movePathTextBox8.Location = new System.Drawing.Point(1127, 425);
            this.movePathTextBox8.Multiline = true;
            this.movePathTextBox8.Name = "movePathTextBox8";
            this.movePathTextBox8.Size = new System.Drawing.Size(161, 27);
            this.movePathTextBox8.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1128, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "ボタン7に対応するパスを記述";
            // 
            // movePathTextBox7
            // 
            this.movePathTextBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movePathTextBox7.Location = new System.Drawing.Point(1127, 368);
            this.movePathTextBox7.Multiline = true;
            this.movePathTextBox7.Name = "movePathTextBox7";
            this.movePathTextBox7.Size = new System.Drawing.Size(161, 27);
            this.movePathTextBox7.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1128, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "ボタン6に対応するパスを記述";
            // 
            // movePathTextBox6
            // 
            this.movePathTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movePathTextBox6.Location = new System.Drawing.Point(1127, 311);
            this.movePathTextBox6.Multiline = true;
            this.movePathTextBox6.Name = "movePathTextBox6";
            this.movePathTextBox6.Size = new System.Drawing.Size(161, 27);
            this.movePathTextBox6.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1128, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "ボタン5に対応するパスを記述";
            // 
            // movePathTextBox5
            // 
            this.movePathTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movePathTextBox5.Location = new System.Drawing.Point(1127, 257);
            this.movePathTextBox5.Multiline = true;
            this.movePathTextBox5.Name = "movePathTextBox5";
            this.movePathTextBox5.Size = new System.Drawing.Size(161, 27);
            this.movePathTextBox5.TabIndex = 23;
            // 
            // moveButton10
            // 
            this.moveButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveButton10.Enabled = false;
            this.moveButton10.Location = new System.Drawing.Point(901, 619);
            this.moveButton10.Name = "moveButton10";
            this.moveButton10.Size = new System.Drawing.Size(177, 33);
            this.moveButton10.TabIndex = 32;
            this.moveButton10.Text = "button10";
            this.moveButton10.UseVisualStyleBackColor = true;
            this.moveButton10.Click += new System.EventHandler(this.moveButton10_Click);
            // 
            // moveButton9
            // 
            this.moveButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveButton9.Enabled = false;
            this.moveButton9.Location = new System.Drawing.Point(901, 585);
            this.moveButton9.Name = "moveButton9";
            this.moveButton9.Size = new System.Drawing.Size(177, 33);
            this.moveButton9.TabIndex = 31;
            this.moveButton9.Text = "button9";
            this.moveButton9.UseVisualStyleBackColor = true;
            this.moveButton9.Click += new System.EventHandler(this.moveButton9_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1128, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 12);
            this.label9.TabIndex = 36;
            this.label9.Text = "ボタン10に対応するパスを記述";
            // 
            // movePathTextBox10
            // 
            this.movePathTextBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movePathTextBox10.Location = new System.Drawing.Point(1127, 540);
            this.movePathTextBox10.Multiline = true;
            this.movePathTextBox10.Name = "movePathTextBox10";
            this.movePathTextBox10.Size = new System.Drawing.Size(161, 27);
            this.movePathTextBox10.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1128, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 12);
            this.label10.TabIndex = 34;
            this.label10.Text = "ボタン9に対応するパスを記述";
            // 
            // movePathTextBox9
            // 
            this.movePathTextBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movePathTextBox9.Location = new System.Drawing.Point(1127, 482);
            this.movePathTextBox9.Multiline = true;
            this.movePathTextBox9.Name = "movePathTextBox9";
            this.movePathTextBox9.Size = new System.Drawing.Size(161, 27);
            this.movePathTextBox9.TabIndex = 33;
            // 
            // copyButton1
            // 
            this.copyButton1.Location = new System.Drawing.Point(1294, 35);
            this.copyButton1.Name = "copyButton1";
            this.copyButton1.Size = new System.Drawing.Size(38, 27);
            this.copyButton1.TabIndex = 37;
            this.copyButton1.Text = "copy";
            this.copyButton1.UseVisualStyleBackColor = true;
            this.copyButton1.Click += new System.EventHandler(this.copyButton1_Click);
            // 
            // copyButton2
            // 
            this.copyButton2.Location = new System.Drawing.Point(1294, 86);
            this.copyButton2.Name = "copyButton2";
            this.copyButton2.Size = new System.Drawing.Size(38, 27);
            this.copyButton2.TabIndex = 38;
            this.copyButton2.Text = "copy";
            this.copyButton2.UseVisualStyleBackColor = true;
            this.copyButton2.Click += new System.EventHandler(this.copyButton2_Click);
            // 
            // copyButton3
            // 
            this.copyButton3.Location = new System.Drawing.Point(1294, 142);
            this.copyButton3.Name = "copyButton3";
            this.copyButton3.Size = new System.Drawing.Size(38, 27);
            this.copyButton3.TabIndex = 39;
            this.copyButton3.Text = "copy";
            this.copyButton3.UseVisualStyleBackColor = true;
            this.copyButton3.Click += new System.EventHandler(this.copyButton3_Click);
            // 
            // copyButton4
            // 
            this.copyButton4.Location = new System.Drawing.Point(1294, 199);
            this.copyButton4.Name = "copyButton4";
            this.copyButton4.Size = new System.Drawing.Size(38, 27);
            this.copyButton4.TabIndex = 40;
            this.copyButton4.Text = "copy";
            this.copyButton4.UseVisualStyleBackColor = true;
            this.copyButton4.Click += new System.EventHandler(this.copyButton4_Click);
            // 
            // copyButton5
            // 
            this.copyButton5.Location = new System.Drawing.Point(1294, 257);
            this.copyButton5.Name = "copyButton5";
            this.copyButton5.Size = new System.Drawing.Size(38, 27);
            this.copyButton5.TabIndex = 41;
            this.copyButton5.Text = "copy";
            this.copyButton5.UseVisualStyleBackColor = true;
            this.copyButton5.Click += new System.EventHandler(this.copyButton5_Click);
            // 
            // copyButton6
            // 
            this.copyButton6.Location = new System.Drawing.Point(1294, 311);
            this.copyButton6.Name = "copyButton6";
            this.copyButton6.Size = new System.Drawing.Size(38, 27);
            this.copyButton6.TabIndex = 42;
            this.copyButton6.Text = "copy";
            this.copyButton6.UseVisualStyleBackColor = true;
            this.copyButton6.Click += new System.EventHandler(this.copyButton6_Click);
            // 
            // copyButton7
            // 
            this.copyButton7.Location = new System.Drawing.Point(1294, 368);
            this.copyButton7.Name = "copyButton7";
            this.copyButton7.Size = new System.Drawing.Size(38, 27);
            this.copyButton7.TabIndex = 43;
            this.copyButton7.Text = "copy";
            this.copyButton7.UseVisualStyleBackColor = true;
            this.copyButton7.Click += new System.EventHandler(this.copyButton7_Click);
            // 
            // copyButton8
            // 
            this.copyButton8.Location = new System.Drawing.Point(1294, 426);
            this.copyButton8.Name = "copyButton8";
            this.copyButton8.Size = new System.Drawing.Size(38, 27);
            this.copyButton8.TabIndex = 44;
            this.copyButton8.Text = "copy";
            this.copyButton8.UseVisualStyleBackColor = true;
            this.copyButton8.Click += new System.EventHandler(this.copyButton8_Click);
            // 
            // copyButton9
            // 
            this.copyButton9.Location = new System.Drawing.Point(1294, 482);
            this.copyButton9.Name = "copyButton9";
            this.copyButton9.Size = new System.Drawing.Size(38, 27);
            this.copyButton9.TabIndex = 45;
            this.copyButton9.Text = "copy";
            this.copyButton9.UseVisualStyleBackColor = true;
            this.copyButton9.Click += new System.EventHandler(this.copyButton9_Click);
            // 
            // copyButton10
            // 
            this.copyButton10.Location = new System.Drawing.Point(1294, 540);
            this.copyButton10.Name = "copyButton10";
            this.copyButton10.Size = new System.Drawing.Size(38, 27);
            this.copyButton10.TabIndex = 46;
            this.copyButton10.Text = "copy";
            this.copyButton10.UseVisualStyleBackColor = true;
            this.copyButton10.Click += new System.EventHandler(this.copyButton10_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 660);
            this.Controls.Add(this.copyButton10);
            this.Controls.Add(this.copyButton9);
            this.Controls.Add(this.copyButton8);
            this.Controls.Add(this.copyButton7);
            this.Controls.Add(this.copyButton6);
            this.Controls.Add(this.copyButton5);
            this.Controls.Add(this.copyButton4);
            this.Controls.Add(this.copyButton3);
            this.Controls.Add(this.copyButton2);
            this.Controls.Add(this.copyButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.movePathTextBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.movePathTextBox9);
            this.Controls.Add(this.moveButton10);
            this.Controls.Add(this.moveButton9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.movePathTextBox8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.movePathTextBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.movePathTextBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.movePathTextBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.movePathTextBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.movePathTextBox3);
            this.Controls.Add(this.moveButton8);
            this.Controls.Add(this.moveButton7);
            this.Controls.Add(this.moveButton6);
            this.Controls.Add(this.moveButton5);
            this.Controls.Add(this.moveButton4);
            this.Controls.Add(this.moveButton3);
            this.Controls.Add(this.nextImageButton);
            this.Controls.Add(this.selectionPathTextBox);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.movePathTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moveButton2);
            this.Controls.Add(this.selectionCopyButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.moveButton1);
            this.Controls.Add(this.movePathTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "画像整理するぉ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox movePathTextBox1;
        private System.Windows.Forms.Button moveButton1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button moveButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox movePathTextBox2;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.TextBox selectionPathTextBox;
        private System.Windows.Forms.Button nextImageButton;
        private System.Windows.Forms.Button moveButton4;
        private System.Windows.Forms.Button moveButton3;
        private System.Windows.Forms.Button moveButton6;
        private System.Windows.Forms.Button moveButton5;
        private System.Windows.Forms.Button moveButton8;
        private System.Windows.Forms.Button moveButton7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox movePathTextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox movePathTextBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox movePathTextBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox movePathTextBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox movePathTextBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox movePathTextBox5;
        private System.Windows.Forms.Button selectionCopyButton;
        private System.Windows.Forms.Button moveButton10;
        private System.Windows.Forms.Button moveButton9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox movePathTextBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox movePathTextBox9;
        private System.Windows.Forms.Button copyButton1;
        private System.Windows.Forms.Button copyButton2;
        private System.Windows.Forms.Button copyButton3;
        private System.Windows.Forms.Button copyButton4;
        private System.Windows.Forms.Button copyButton5;
        private System.Windows.Forms.Button copyButton6;
        private System.Windows.Forms.Button copyButton7;
        private System.Windows.Forms.Button copyButton8;
        private System.Windows.Forms.Button copyButton9;
        private System.Windows.Forms.Button copyButton10;
    }
}

