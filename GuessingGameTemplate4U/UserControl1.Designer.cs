namespace GuessingGameTemplate4U
{
    partial class ResultScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultLabel = new System.Windows.Forms.Label();
            this.origionalGuessOrder = new System.Windows.Forms.Label();
            this.sortedGuessOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.ForeColor = System.Drawing.Color.Snow;
            this.resultLabel.Location = new System.Drawing.Point(66, 56);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 0;
            // 
            // origionalGuessOrder
            // 
            this.origionalGuessOrder.AutoSize = true;
            this.origionalGuessOrder.BackColor = System.Drawing.Color.Transparent;
            this.origionalGuessOrder.ForeColor = System.Drawing.Color.Snow;
            this.origionalGuessOrder.Location = new System.Drawing.Point(66, 157);
            this.origionalGuessOrder.Name = "origionalGuessOrder";
            this.origionalGuessOrder.Size = new System.Drawing.Size(0, 13);
            this.origionalGuessOrder.TabIndex = 1;
            // 
            // sortedGuessOrder
            // 
            this.sortedGuessOrder.AutoSize = true;
            this.sortedGuessOrder.BackColor = System.Drawing.Color.Transparent;
            this.sortedGuessOrder.ForeColor = System.Drawing.Color.Snow;
            this.sortedGuessOrder.Location = new System.Drawing.Point(66, 234);
            this.sortedGuessOrder.Name = "sortedGuessOrder";
            this.sortedGuessOrder.Size = new System.Drawing.Size(0, 13);
            this.sortedGuessOrder.TabIndex = 2;
            // 
            // ResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.sortedGuessOrder);
            this.Controls.Add(this.origionalGuessOrder);
            this.Controls.Add(this.resultLabel);
            this.Name = "ResultScreen";
            this.Size = new System.Drawing.Size(370, 350);
            this.Load += new System.EventHandler(this.ResultScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label origionalGuessOrder;
        private System.Windows.Forms.Label sortedGuessOrder;
    }
}
