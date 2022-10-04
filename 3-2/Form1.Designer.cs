namespace _3_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.startGame_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stack1_textbox = new System.Windows.Forms.TextBox();
            this.stack3_textbox = new System.Windows.Forms.TextBox();
            this.stack4_textbox = new System.Windows.Forms.TextBox();
            this.stack2_textbox = new System.Windows.Forms.TextBox();
            this.backToMenu_button = new System.Windows.Forms.Button();
            this.status_text = new System.Windows.Forms.Label();
            this.selectStack1_button = new System.Windows.Forms.Button();
            this.selectStack2_button = new System.Windows.Forms.Button();
            this.selectStack3_button = new System.Windows.Forms.Button();
            this.selectStack4_button = new System.Windows.Forms.Button();
            this.stack1_text = new System.Windows.Forms.Label();
            this.stack2_text = new System.Windows.Forms.Label();
            this.stack3_text = new System.Windows.Forms.Label();
            this.stack4_text = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startGame_button
            // 
            this.startGame_button.BackColor = System.Drawing.SystemColors.Control;
            this.startGame_button.Location = new System.Drawing.Point(143, 265);
            this.startGame_button.Name = "startGame_button";
            this.startGame_button.Size = new System.Drawing.Size(149, 37);
            this.startGame_button.TabIndex = 0;
            this.startGame_button.Text = "開始遊戲";
            this.startGame_button.UseVisualStyleBackColor = false;
            this.startGame_button.Click += new System.EventHandler(this.startGame_button_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "請輸入測資";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "堆疊1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "堆疊2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "堆疊3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "堆疊4";
            // 
            // stack1_textbox
            // 
            this.stack1_textbox.Location = new System.Drawing.Point(94, 86);
            this.stack1_textbox.Name = "stack1_textbox";
            this.stack1_textbox.Size = new System.Drawing.Size(285, 25);
            this.stack1_textbox.TabIndex = 6;
            // 
            // stack3_textbox
            // 
            this.stack3_textbox.Location = new System.Drawing.Point(94, 172);
            this.stack3_textbox.Name = "stack3_textbox";
            this.stack3_textbox.Size = new System.Drawing.Size(285, 25);
            this.stack3_textbox.TabIndex = 7;
            // 
            // stack4_textbox
            // 
            this.stack4_textbox.Location = new System.Drawing.Point(94, 217);
            this.stack4_textbox.Name = "stack4_textbox";
            this.stack4_textbox.Size = new System.Drawing.Size(285, 25);
            this.stack4_textbox.TabIndex = 8;
            // 
            // stack2_textbox
            // 
            this.stack2_textbox.Location = new System.Drawing.Point(94, 129);
            this.stack2_textbox.Name = "stack2_textbox";
            this.stack2_textbox.Size = new System.Drawing.Size(285, 25);
            this.stack2_textbox.TabIndex = 9;
            // 
            // backToMenu_button
            // 
            this.backToMenu_button.BackColor = System.Drawing.SystemColors.Control;
            this.backToMenu_button.Location = new System.Drawing.Point(228, 480);
            this.backToMenu_button.Name = "backToMenu_button";
            this.backToMenu_button.Size = new System.Drawing.Size(154, 37);
            this.backToMenu_button.TabIndex = 10;
            this.backToMenu_button.Text = "回主畫面";
            this.backToMenu_button.UseVisualStyleBackColor = false;
            this.backToMenu_button.Click += new System.EventHandler(this.backToMenu_button_Click);
            // 
            // status_text
            // 
            this.status_text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.status_text.Location = new System.Drawing.Point(45, 480);
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(154, 37);
            this.status_text.TabIndex = 11;
            this.status_text.Text = "...";
            // 
            // selectStack1_button
            // 
            this.selectStack1_button.BackColor = System.Drawing.Color.White;
            this.selectStack1_button.Location = new System.Drawing.Point(48, 424);
            this.selectStack1_button.Name = "selectStack1_button";
            this.selectStack1_button.Size = new System.Drawing.Size(64, 37);
            this.selectStack1_button.TabIndex = 12;
            this.selectStack1_button.Tag = "";
            this.selectStack1_button.Text = "選取";
            this.selectStack1_button.UseVisualStyleBackColor = false;
            this.selectStack1_button.Click += new System.EventHandler(this.selectStack1_button_Click);
            // 
            // selectStack2_button
            // 
            this.selectStack2_button.BackColor = System.Drawing.Color.White;
            this.selectStack2_button.Location = new System.Drawing.Point(135, 424);
            this.selectStack2_button.Name = "selectStack2_button";
            this.selectStack2_button.Size = new System.Drawing.Size(64, 37);
            this.selectStack2_button.TabIndex = 13;
            this.selectStack2_button.Tag = "";
            this.selectStack2_button.Text = "選取";
            this.selectStack2_button.UseVisualStyleBackColor = false;
            this.selectStack2_button.Click += new System.EventHandler(this.selectStack2_button_Click);
            // 
            // selectStack3_button
            // 
            this.selectStack3_button.BackColor = System.Drawing.Color.White;
            this.selectStack3_button.Location = new System.Drawing.Point(228, 424);
            this.selectStack3_button.Name = "selectStack3_button";
            this.selectStack3_button.Size = new System.Drawing.Size(64, 37);
            this.selectStack3_button.TabIndex = 14;
            this.selectStack3_button.Tag = "";
            this.selectStack3_button.Text = "選取";
            this.selectStack3_button.UseVisualStyleBackColor = false;
            this.selectStack3_button.Click += new System.EventHandler(this.selectStack3_button_Click);
            // 
            // selectStack4_button
            // 
            this.selectStack4_button.BackColor = System.Drawing.Color.White;
            this.selectStack4_button.Location = new System.Drawing.Point(314, 424);
            this.selectStack4_button.Name = "selectStack4_button";
            this.selectStack4_button.Size = new System.Drawing.Size(64, 37);
            this.selectStack4_button.TabIndex = 15;
            this.selectStack4_button.Tag = "";
            this.selectStack4_button.Text = "選取";
            this.selectStack4_button.UseVisualStyleBackColor = false;
            this.selectStack4_button.Click += new System.EventHandler(this.selectStack4_button_Click);
            // 
            // stack1_text
            // 
            this.stack1_text.BackColor = System.Drawing.Color.White;
            this.stack1_text.Location = new System.Drawing.Point(45, 65);
            this.stack1_text.Name = "stack1_text";
            this.stack1_text.Size = new System.Drawing.Size(64, 335);
            this.stack1_text.TabIndex = 16;
            this.stack1_text.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // stack2_text
            // 
            this.stack2_text.BackColor = System.Drawing.Color.White;
            this.stack2_text.Location = new System.Drawing.Point(132, 65);
            this.stack2_text.Name = "stack2_text";
            this.stack2_text.Size = new System.Drawing.Size(64, 335);
            this.stack2_text.TabIndex = 17;
            this.stack2_text.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // stack3_text
            // 
            this.stack3_text.BackColor = System.Drawing.Color.White;
            this.stack3_text.Location = new System.Drawing.Point(225, 65);
            this.stack3_text.Name = "stack3_text";
            this.stack3_text.Size = new System.Drawing.Size(64, 335);
            this.stack3_text.TabIndex = 18;
            this.stack3_text.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // stack4_text
            // 
            this.stack4_text.BackColor = System.Drawing.Color.White;
            this.stack4_text.Location = new System.Drawing.Point(311, 65);
            this.stack4_text.Name = "stack4_text";
            this.stack4_text.Size = new System.Drawing.Size(64, 335);
            this.stack4_text.TabIndex = 19;
            this.stack4_text.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "堆疊1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "堆疊2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "堆疊3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "堆疊4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 535);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stack4_text);
            this.Controls.Add(this.stack3_text);
            this.Controls.Add(this.stack2_text);
            this.Controls.Add(this.stack1_text);
            this.Controls.Add(this.selectStack4_button);
            this.Controls.Add(this.selectStack3_button);
            this.Controls.Add(this.selectStack2_button);
            this.Controls.Add(this.selectStack1_button);
            this.Controls.Add(this.status_text);
            this.Controls.Add(this.backToMenu_button);
            this.Controls.Add(this.stack2_textbox);
            this.Controls.Add(this.stack4_textbox);
            this.Controls.Add(this.stack3_textbox);
            this.Controls.Add(this.stack1_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startGame_button);
            this.Name = "Form1";
            this.Text = "Stack Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGame_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox stack1_textbox;
        public System.Windows.Forms.TextBox stack3_textbox;
        public System.Windows.Forms.TextBox stack4_textbox;
        public System.Windows.Forms.TextBox stack2_textbox;
        private System.Windows.Forms.Button backToMenu_button;
        private System.Windows.Forms.Label status_text;
        private System.Windows.Forms.Button selectStack1_button;
        private System.Windows.Forms.Button selectStack2_button;
        private System.Windows.Forms.Button selectStack3_button;
        private System.Windows.Forms.Button selectStack4_button;
        private System.Windows.Forms.Label stack1_text;
        private System.Windows.Forms.Label stack2_text;
        private System.Windows.Forms.Label stack3_text;
        private System.Windows.Forms.Label stack4_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

