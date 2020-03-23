namespace TPCommandGenerator {
	partial class TPCGForm {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.Title = new System.Windows.Forms.Label();
			this.Hint1 = new System.Windows.Forms.Label();
			this.TargetBox = new System.Windows.Forms.ComboBox();
			this.Hint2 = new System.Windows.Forms.Label();
			this.DestinationRadioChar = new System.Windows.Forms.RadioButton();
			this.DestinationRadioCoordinates = new System.Windows.Forms.RadioButton();
			this.DestinationCharBox = new System.Windows.Forms.ComboBox();
			this.DestinationX = new System.Windows.Forms.TextBox();
			this.DestinationY = new System.Windows.Forms.TextBox();
			this.DestinationZ = new System.Windows.Forms.TextBox();
			this.HrBar1 = new System.Windows.Forms.Label();
			this.HrBar2 = new System.Windows.Forms.Label();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.ResultBox = new System.Windows.Forms.TextBox();
			this.CopyButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Title.Location = new System.Drawing.Point(12, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(235, 28);
			this.Title.TabIndex = 0;
			this.Title.Text = "TP Command Generator";
			// 
			// Hint1
			// 
			this.Hint1.AutoSize = true;
			this.Hint1.Location = new System.Drawing.Point(15, 71);
			this.Hint1.Name = "Hint1";
			this.Hint1.Size = new System.Drawing.Size(87, 12);
			this.Hint1.TabIndex = 1;
			this.Hint1.Text = "転送させられる人";
			// 
			// TargetBox
			// 
			this.TargetBox.FormattingEnabled = true;
			this.TargetBox.Items.AddRange(new object[] {
            "",
            "自分",
            "全キャラクター"});
			this.TargetBox.Location = new System.Drawing.Point(129, 68);
			this.TargetBox.Name = "TargetBox";
			this.TargetBox.Size = new System.Drawing.Size(222, 20);
			this.TargetBox.TabIndex = 2;
			// 
			// Hint2
			// 
			this.Hint2.AutoSize = true;
			this.Hint2.Location = new System.Drawing.Point(15, 112);
			this.Hint2.Name = "Hint2";
			this.Hint2.Size = new System.Drawing.Size(41, 12);
			this.Hint2.TabIndex = 3;
			this.Hint2.Text = "転送先";
			// 
			// DestinationRadioChar
			// 
			this.DestinationRadioChar.AutoSize = true;
			this.DestinationRadioChar.Checked = true;
			this.DestinationRadioChar.Location = new System.Drawing.Point(37, 139);
			this.DestinationRadioChar.Name = "DestinationRadioChar";
			this.DestinationRadioChar.Size = new System.Drawing.Size(75, 16);
			this.DestinationRadioChar.TabIndex = 4;
			this.DestinationRadioChar.TabStop = true;
			this.DestinationRadioChar.Text = "キャラクター";
			this.DestinationRadioChar.UseVisualStyleBackColor = true;
			this.DestinationRadioChar.CheckedChanged += new System.EventHandler(this.RadioCheckedChanged);
			// 
			// DestinationRadioCoordinates
			// 
			this.DestinationRadioCoordinates.AutoSize = true;
			this.DestinationRadioCoordinates.Location = new System.Drawing.Point(37, 166);
			this.DestinationRadioCoordinates.Name = "DestinationRadioCoordinates";
			this.DestinationRadioCoordinates.Size = new System.Drawing.Size(76, 16);
			this.DestinationRadioCoordinates.TabIndex = 5;
			this.DestinationRadioCoordinates.TabStop = true;
			this.DestinationRadioCoordinates.Text = "座標(x,y,z)";
			this.DestinationRadioCoordinates.UseVisualStyleBackColor = true;
			this.DestinationRadioCoordinates.CheckedChanged += new System.EventHandler(this.RadioCheckedChanged);
			// 
			// DestinationCharBox
			// 
			this.DestinationCharBox.FormattingEnabled = true;
			this.DestinationCharBox.Items.AddRange(new object[] {
            "",
            "自分"});
			this.DestinationCharBox.Location = new System.Drawing.Point(129, 138);
			this.DestinationCharBox.Name = "DestinationCharBox";
			this.DestinationCharBox.Size = new System.Drawing.Size(222, 20);
			this.DestinationCharBox.TabIndex = 6;
			// 
			// DestinationX
			// 
			this.DestinationX.Enabled = false;
			this.DestinationX.Location = new System.Drawing.Point(129, 165);
			this.DestinationX.Name = "DestinationX";
			this.DestinationX.Size = new System.Drawing.Size(70, 19);
			this.DestinationX.TabIndex = 7;
			// 
			// DestinationY
			// 
			this.DestinationY.Enabled = false;
			this.DestinationY.Location = new System.Drawing.Point(205, 165);
			this.DestinationY.Name = "DestinationY";
			this.DestinationY.Size = new System.Drawing.Size(70, 19);
			this.DestinationY.TabIndex = 8;
			// 
			// DestinationZ
			// 
			this.DestinationZ.Enabled = false;
			this.DestinationZ.Location = new System.Drawing.Point(281, 165);
			this.DestinationZ.Name = "DestinationZ";
			this.DestinationZ.Size = new System.Drawing.Size(70, 19);
			this.DestinationZ.TabIndex = 9;
			// 
			// HrBar1
			// 
			this.HrBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.HrBar1.Location = new System.Drawing.Point(12, 45);
			this.HrBar1.Name = "HrBar1";
			this.HrBar1.Size = new System.Drawing.Size(345, 1);
			this.HrBar1.TabIndex = 10;
			// 
			// HrBar2
			// 
			this.HrBar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.HrBar2.Location = new System.Drawing.Point(12, 205);
			this.HrBar2.Name = "HrBar2";
			this.HrBar2.Size = new System.Drawing.Size(345, 1);
			this.HrBar2.TabIndex = 11;
			// 
			// GenerateButton
			// 
			this.GenerateButton.Location = new System.Drawing.Point(17, 218);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(334, 31);
			this.GenerateButton.TabIndex = 12;
			this.GenerateButton.Text = "作る！";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// ResultBox
			// 
			this.ResultBox.Location = new System.Drawing.Point(17, 264);
			this.ResultBox.Name = "ResultBox";
			this.ResultBox.Size = new System.Drawing.Size(258, 19);
			this.ResultBox.TabIndex = 13;
			// 
			// CopyButton
			// 
			this.CopyButton.Location = new System.Drawing.Point(281, 262);
			this.CopyButton.Name = "CopyButton";
			this.CopyButton.Size = new System.Drawing.Size(70, 23);
			this.CopyButton.TabIndex = 14;
			this.CopyButton.Text = "コピー";
			this.CopyButton.UseVisualStyleBackColor = true;
			this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
			// 
			// TPCGForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(369, 297);
			this.Controls.Add(this.CopyButton);
			this.Controls.Add(this.ResultBox);
			this.Controls.Add(this.GenerateButton);
			this.Controls.Add(this.HrBar2);
			this.Controls.Add(this.HrBar1);
			this.Controls.Add(this.DestinationZ);
			this.Controls.Add(this.DestinationY);
			this.Controls.Add(this.DestinationX);
			this.Controls.Add(this.DestinationCharBox);
			this.Controls.Add(this.DestinationRadioCoordinates);
			this.Controls.Add(this.DestinationRadioChar);
			this.Controls.Add(this.Hint2);
			this.Controls.Add(this.TargetBox);
			this.Controls.Add(this.Hint1);
			this.Controls.Add(this.Title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "TPCGForm";
			this.Text = "TP Command Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label Hint1;
		private System.Windows.Forms.ComboBox TargetBox;
		private System.Windows.Forms.Label Hint2;
		private System.Windows.Forms.RadioButton DestinationRadioChar;
		private System.Windows.Forms.RadioButton DestinationRadioCoordinates;
		private System.Windows.Forms.ComboBox DestinationCharBox;
		private System.Windows.Forms.TextBox DestinationX;
		private System.Windows.Forms.TextBox DestinationY;
		private System.Windows.Forms.TextBox DestinationZ;
		private System.Windows.Forms.Label HrBar1;
		private System.Windows.Forms.Label HrBar2;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.TextBox ResultBox;
		private System.Windows.Forms.Button CopyButton;
	}
}

