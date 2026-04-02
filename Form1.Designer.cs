namespace Dicey_Chances
{
    partial class GameWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonThrowDice = new System.Windows.Forms.Button();
            this.panelDiceBox = new System.Windows.Forms.Panel();
            this.panelScoring = new System.Windows.Forms.Panel();
            this.panelNeededScore = new System.Windows.Forms.Panel();
            this.buttonCountScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonThrowDice
            // 
            this.buttonThrowDice.Location = new System.Drawing.Point(463, 827);
            this.buttonThrowDice.Name = "buttonThrowDice";
            this.buttonThrowDice.Size = new System.Drawing.Size(572, 132);
            this.buttonThrowDice.TabIndex = 1;
            this.buttonThrowDice.Text = "Throw all your dice";
            this.buttonThrowDice.UseVisualStyleBackColor = true;
            this.buttonThrowDice.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelDiceBox
            // 
            this.panelDiceBox.BackgroundImage = global::Dicey_Chances.Properties.Resources.Texture_Wood_Background;
            this.panelDiceBox.Location = new System.Drawing.Point(464, 354);
            this.panelDiceBox.Name = "panelDiceBox";
            this.panelDiceBox.Size = new System.Drawing.Size(1150, 467);
            this.panelDiceBox.TabIndex = 2;
            // 
            // panelScoring
            // 
            this.panelScoring.Location = new System.Drawing.Point(463, 3);
            this.panelScoring.Name = "panelScoring";
            this.panelScoring.Size = new System.Drawing.Size(1150, 345);
            this.panelScoring.TabIndex = 3;
            // 
            // panelNeededScore
            // 
            this.panelNeededScore.Location = new System.Drawing.Point(12, 3);
            this.panelNeededScore.Name = "panelNeededScore";
            this.panelNeededScore.Size = new System.Drawing.Size(445, 206);
            this.panelNeededScore.TabIndex = 4;
            // 
            // buttonCountScore
            // 
            this.buttonCountScore.Location = new System.Drawing.Point(1042, 827);
            this.buttonCountScore.Name = "buttonCountScore";
            this.buttonCountScore.Size = new System.Drawing.Size(572, 132);
            this.buttonCountScore.TabIndex = 5;
            this.buttonCountScore.Text = "Submit the throw";
            this.buttonCountScore.UseVisualStyleBackColor = true;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 971);
            this.Controls.Add(this.buttonCountScore);
            this.Controls.Add(this.panelNeededScore);
            this.Controls.Add(this.panelScoring);
            this.Controls.Add(this.panelDiceBox);
            this.Controls.Add(this.buttonThrowDice);
            this.Name = "GameWindow";
            this.Text = "Dicey Chances";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonThrowDice;
        private System.Windows.Forms.Panel panelDiceBox;
        private System.Windows.Forms.Panel panelScoring;
        private System.Windows.Forms.Panel panelNeededScore;
        private System.Windows.Forms.Button buttonCountScore;
    }
}

