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
            this.labelThrowScore = new System.Windows.Forms.Label();
            this.panelNeededScore = new System.Windows.Forms.Panel();
            this.labelTotalScore = new System.Windows.Forms.Label();
            this.buttonCountScore = new System.Windows.Forms.Button();
            this.panelScoring.SuspendLayout();
            this.panelNeededScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonThrowDice
            // 
            this.buttonThrowDice.Location = new System.Drawing.Point(232, 430);
            this.buttonThrowDice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThrowDice.Name = "buttonThrowDice";
            this.buttonThrowDice.Size = new System.Drawing.Size(286, 69);
            this.buttonThrowDice.TabIndex = 1;
            this.buttonThrowDice.Text = "Throw all your dice";
            this.buttonThrowDice.UseVisualStyleBackColor = true;
            this.buttonThrowDice.Click += new System.EventHandler(this.buttonThrowDice_Click);
            // 
            // panelDiceBox
            // 
            this.panelDiceBox.BackgroundImage = global::Dicey_Chances.Properties.Resources.Texture_Wood_Background;
            this.panelDiceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDiceBox.Location = new System.Drawing.Point(232, 184);
            this.panelDiceBox.Margin = new System.Windows.Forms.Padding(2);
            this.panelDiceBox.Name = "panelDiceBox";
            this.panelDiceBox.Size = new System.Drawing.Size(575, 243);
            this.panelDiceBox.TabIndex = 2;
            // 
            // panelScoring
            // 
            this.panelScoring.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelScoring.Controls.Add(this.labelThrowScore);
            this.panelScoring.Location = new System.Drawing.Point(232, 2);
            this.panelScoring.Margin = new System.Windows.Forms.Padding(2);
            this.panelScoring.Name = "panelScoring";
            this.panelScoring.Size = new System.Drawing.Size(575, 179);
            this.panelScoring.TabIndex = 3;
            // 
            // labelThrowScore
            // 
            this.labelThrowScore.AutoSize = true;
            this.labelThrowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThrowScore.Location = new System.Drawing.Point(3, 7);
            this.labelThrowScore.Name = "labelThrowScore";
            this.labelThrowScore.Size = new System.Drawing.Size(150, 55);
            this.labelThrowScore.TabIndex = 0;
            this.labelThrowScore.Text = "Score";
            // 
            // panelNeededScore
            // 
            this.panelNeededScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNeededScore.Controls.Add(this.labelTotalScore);
            this.panelNeededScore.Location = new System.Drawing.Point(6, 2);
            this.panelNeededScore.Margin = new System.Windows.Forms.Padding(2);
            this.panelNeededScore.Name = "panelNeededScore";
            this.panelNeededScore.Size = new System.Drawing.Size(222, 107);
            this.panelNeededScore.TabIndex = 4;
            // 
            // labelTotalScore
            // 
            this.labelTotalScore.AutoSize = true;
            this.labelTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalScore.Location = new System.Drawing.Point(3, 6);
            this.labelTotalScore.Name = "labelTotalScore";
            this.labelTotalScore.Size = new System.Drawing.Size(125, 76);
            this.labelTotalScore.TabIndex = 1;
            this.labelTotalScore.Text = "0/0";
            // 
            // buttonCountScore
            // 
            this.buttonCountScore.Location = new System.Drawing.Point(521, 430);
            this.buttonCountScore.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCountScore.Name = "buttonCountScore";
            this.buttonCountScore.Size = new System.Drawing.Size(286, 69);
            this.buttonCountScore.TabIndex = 5;
            this.buttonCountScore.Text = "Submit the throw";
            this.buttonCountScore.UseVisualStyleBackColor = true;
            this.buttonCountScore.Click += new System.EventHandler(this.buttonCountScore_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 505);
            this.Controls.Add(this.buttonCountScore);
            this.Controls.Add(this.panelNeededScore);
            this.Controls.Add(this.panelScoring);
            this.Controls.Add(this.panelDiceBox);
            this.Controls.Add(this.buttonThrowDice);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameWindow";
            this.Text = "Dicey Chances";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.panelScoring.ResumeLayout(false);
            this.panelScoring.PerformLayout();
            this.panelNeededScore.ResumeLayout(false);
            this.panelNeededScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonThrowDice;
        private System.Windows.Forms.Panel panelDiceBox;
        private System.Windows.Forms.Panel panelScoring;
        private System.Windows.Forms.Panel panelNeededScore;
        private System.Windows.Forms.Button buttonCountScore;
        private System.Windows.Forms.Label labelThrowScore;
        private System.Windows.Forms.Label labelTotalScore;
    }
}

