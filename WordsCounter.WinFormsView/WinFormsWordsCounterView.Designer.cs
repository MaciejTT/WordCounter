namespace WordsCounter.WinFormsView
{
	partial class WinFormsWordsCounterView
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbInput = new System.Windows.Forms.TextBox();
			this.btnAnalyzeText = new System.Windows.Forms.Button();
			this.lvResults = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// tbInput
			// 
			this.tbInput.Location = new System.Drawing.Point(12, 12);
			this.tbInput.Multiline = true;
			this.tbInput.Name = "tbInput";
			this.tbInput.Size = new System.Drawing.Size(518, 162);
			this.tbInput.TabIndex = 0;
			// 
			// btnAnalyzeText
			// 
			this.btnAnalyzeText.Location = new System.Drawing.Point(12, 194);
			this.btnAnalyzeText.Name = "btnAnalyzeText";
			this.btnAnalyzeText.Size = new System.Drawing.Size(120, 32);
			this.btnAnalyzeText.TabIndex = 2;
			this.btnAnalyzeText.Text = "Analyze";
			this.btnAnalyzeText.UseVisualStyleBackColor = true;
			this.btnAnalyzeText.Click += new System.EventHandler(this.btnAnalyzeText_Click);
			// 
			// lvResults
			// 
			this.lvResults.AutoArrange = false;
			this.lvResults.GridLines = true;
			this.lvResults.Location = new System.Drawing.Point(156, 194);
			this.lvResults.MaximumSize = new System.Drawing.Size(374, 260);
			this.lvResults.MinimumSize = new System.Drawing.Size(374, 260);
			this.lvResults.Name = "lvResults";
			this.lvResults.ShowGroups = false;
			this.lvResults.Size = new System.Drawing.Size(374, 260);
			this.lvResults.TabIndex = 1;
			this.lvResults.UseCompatibleStateImageBehavior = false;
			this.lvResults.View = System.Windows.Forms.View.List;
			// 
			// WinFormsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 468);
			this.Controls.Add(this.btnAnalyzeText);
			this.Controls.Add(this.lvResults);
			this.Controls.Add(this.tbInput);
			this.MaximumSize = new System.Drawing.Size(888, 507);
			this.Name = "WinFormsView";
			this.Text = "WordsCounter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbInput;
		private System.Windows.Forms.Button btnAnalyzeText;
		private System.Windows.Forms.ListView lvResults;
	}
}

