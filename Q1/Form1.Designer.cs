namespace Q1
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
			this.firstTextBox = new System.Windows.Forms.TextBox();
			this.newGameBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SecondTextBox = new System.Windows.Forms.TextBox();
			this.ThirdTextBox = new System.Windows.Forms.TextBox();
			this.FouthTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// firstTextBox
			// 
			this.firstTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.firstTextBox.Location = new System.Drawing.Point(13, 103);
			this.firstTextBox.Multiline = true;
			this.firstTextBox.Name = "firstTextBox";
			this.firstTextBox.Size = new System.Drawing.Size(36, 42);
			this.firstTextBox.TabIndex = 0;
			// 
			// newGameBtn
			// 
			this.newGameBtn.BackColor = System.Drawing.SystemColors.Control;
			this.newGameBtn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.newGameBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.newGameBtn.Location = new System.Drawing.Point(33, 43);
			this.newGameBtn.Name = "newGameBtn";
			this.newGameBtn.Size = new System.Drawing.Size(97, 30);
			this.newGameBtn.TabIndex = 1;
			this.newGameBtn.Text = "New Game";
			this.newGameBtn.UseVisualStyleBackColor = false;
			this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(9, 179);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "result";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(9, 228);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(261, 123);
			this.label4.TabIndex = 6;
			this.label4.Text = "hint";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Control;
			this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox2.Location = new System.Drawing.Point(258, 118);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(61, 27);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "  Guess";
			// 
			// SecondTextBox
			// 
			this.SecondTextBox.Location = new System.Drawing.Point(74, 103);
			this.SecondTextBox.Multiline = true;
			this.SecondTextBox.Name = "SecondTextBox";
			this.SecondTextBox.Size = new System.Drawing.Size(36, 42);
			this.SecondTextBox.TabIndex = 8;
			// 
			// ThirdTextBox
			// 
			this.ThirdTextBox.Location = new System.Drawing.Point(135, 103);
			this.ThirdTextBox.Multiline = true;
			this.ThirdTextBox.Name = "ThirdTextBox";
			this.ThirdTextBox.Size = new System.Drawing.Size(36, 42);
			this.ThirdTextBox.TabIndex = 9;
			// 
			// FouthTextBox
			// 
			this.FouthTextBox.Location = new System.Drawing.Point(196, 103);
			this.FouthTextBox.Multiline = true;
			this.FouthTextBox.Name = "FouthTextBox";
			this.FouthTextBox.Size = new System.Drawing.Size(36, 42);
			this.FouthTextBox.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 386);
			this.Controls.Add(this.FouthTextBox);
			this.Controls.Add(this.ThirdTextBox);
			this.Controls.Add(this.SecondTextBox);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.newGameBtn);
			this.Controls.Add(this.firstTextBox);
			this.Name = "Form1";
			this.Text = "1A2B";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox firstTextBox;
		private System.Windows.Forms.Button newGameBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox SecondTextBox;
		private System.Windows.Forms.TextBox ThirdTextBox;
		private System.Windows.Forms.TextBox FouthTextBox;
	}
}

