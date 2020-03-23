using System;
using System.Windows.Forms;

namespace TPCommandGenerator {
	public partial class TPCGForm : Form {
		public TPCGForm() {
			InitializeComponent();
		}

		private void RadioCheckedChanged(object sender,EventArgs e) {
			this.DestinationCharBox.Enabled = this.DestinationRadioChar.Checked;
			this.DestinationX.Enabled = this.DestinationRadioCoordinates.Checked;
			this.DestinationY.Enabled = this.DestinationRadioCoordinates.Checked;
			this.DestinationZ.Enabled = this.DestinationRadioCoordinates.Checked;
		}

		private void GenerateButton_Click(object sender,EventArgs e) {
			double x = 0, y = 0, z = 0;

			//入力値チェック
			if(!(this.TargetBox.Text.Equals("") || this.TargetBox.Text.Equals("自分") || this.TargetBox.Text.Equals("全キャラクター"))) {
				if(this.TargetBox.Text.Contains(" ")) {
					MessageBox.Show("転送させられる人にコマンドとして利用する文字が含まれています。","TP Command Generator",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
			}
			if(this.DestinationRadioChar.Checked) {
				if(this.DestinationCharBox.Text.Equals("") || this.DestinationCharBox.Text.Contains(" ")) {
					MessageBox.Show("転送先のプレイヤー名が正しくありません。","TP Command Generator",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
			} else {
				if(
					this.DestinationX.Text.Equals("") || this.DestinationY.Text.Equals("") || this.DestinationZ.Text.Equals("") || !(double.TryParse(this.DestinationX.Text,out x) && double.TryParse(this.DestinationY.Text,out y) && double.TryParse(this.DestinationZ.Text,out z))
				) {
					MessageBox.Show("転送先の座標が正しくありません。","TP Command Generator",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
			}
			if(((this.TargetBox.Text.Equals("") || this.TargetBox.Text.Equals("自分")) && this.DestinationRadioChar.Checked && this.DestinationCharBox.Text.Equals("自分")) || (this.DestinationRadioChar.Checked && this.TargetBox.Text.Equals(this.DestinationCharBox.Text))) {
				MessageBox.Show("その行動は無意味です。","TP Command Generator",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}


			//コマンド作成
			this.ResultBox.Text = "/tp ";
			if(this.TargetBox.Text.Equals("全キャラクター")) {
				this.ResultBox.Text += "@a ";
			} else if(!(this.TargetBox.Text.Equals("") || this.TargetBox.Text.Equals("自分"))) {
				this.ResultBox.Text += this.TargetBox.Text + " ";
			}
			if(this.DestinationRadioChar.Checked) {
				if(this.DestinationCharBox.Text.Equals("自分")) {
					this.ResultBox.Text += "@s";
				} else {
					this.ResultBox.Text += this.DestinationCharBox.Text;
				}
			} else {
				this.ResultBox.Text += x + " " + y + " " + z;
			}
		}

		private void CopyButton_Click(object sender,EventArgs e) {
			Clipboard.SetText(this.ResultBox.Text);
		}
	}
}
