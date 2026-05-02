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
            this.buttonScoreReset = new System.Windows.Forms.Button();
            this.listBoxDice = new System.Windows.Forms.ListBox();
            this.buttonDiceGenerator = new System.Windows.Forms.Button();
            this.panelScoring.SuspendLayout();
            this.panelNeededScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonThrowDice
            // 
            this.buttonThrowDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThrowDice.Location = new System.Drawing.Point(464, 827);
            this.buttonThrowDice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThrowDice.Name = "buttonThrowDice";
            this.buttonThrowDice.Size = new System.Drawing.Size(572, 133);
            this.buttonThrowDice.TabIndex = 1;
            this.buttonThrowDice.Text = "Throw all your dice";
            this.buttonThrowDice.UseVisualStyleBackColor = true;
            this.buttonThrowDice.Click += new System.EventHandler(this.buttonThrowDice_Click);
            // 
            // panelDiceBox
            // 
            this.panelDiceBox.BackgroundImage = global::Dicey_Chances.Properties.Resources.Texture_Wood_Background;
            this.panelDiceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDiceBox.Location = new System.Drawing.Point(464, 354);
            this.panelDiceBox.Margin = new System.Windows.Forms.Padding(4);
            this.panelDiceBox.Name = "panelDiceBox";
            this.panelDiceBox.Size = new System.Drawing.Size(1148, 465);
            this.panelDiceBox.TabIndex = 2;
            // 
            // panelScoring
            // 
            this.panelScoring.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelScoring.Controls.Add(this.labelThrowScore);
            this.panelScoring.Location = new System.Drawing.Point(464, 4);
            this.panelScoring.Margin = new System.Windows.Forms.Padding(4);
            this.panelScoring.Name = "panelScoring";
            this.panelScoring.Size = new System.Drawing.Size(1148, 342);
            this.panelScoring.TabIndex = 3;
            // 
            // labelThrowScore
            // 
            this.labelThrowScore.AutoSize = true;
            this.labelThrowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThrowScore.Location = new System.Drawing.Point(6, 13);
            this.labelThrowScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelThrowScore.Name = "labelThrowScore";
            this.labelThrowScore.Size = new System.Drawing.Size(295, 108);
            this.labelThrowScore.TabIndex = 0;
            this.labelThrowScore.Text = "Score";
            // 
            // panelNeededScore
            // 
            this.panelNeededScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNeededScore.Controls.Add(this.labelTotalScore);
            this.panelNeededScore.Location = new System.Drawing.Point(12, 4);
            this.panelNeededScore.Margin = new System.Windows.Forms.Padding(4);
            this.panelNeededScore.Name = "panelNeededScore";
            this.panelNeededScore.Size = new System.Drawing.Size(442, 204);
            this.panelNeededScore.TabIndex = 4;
            // 
            // labelTotalScore
            // 
            this.labelTotalScore.AutoSize = true;
            this.labelTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalScore.Location = new System.Drawing.Point(19, 13);
            this.labelTotalScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTotalScore.Name = "labelTotalScore";
            this.labelTotalScore.Size = new System.Drawing.Size(140, 153);
            this.labelTotalScore.TabIndex = 1;
            this.labelTotalScore.Text = "0";
            // 
            // buttonCountScore
            // 
            this.buttonCountScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCountScore.Location = new System.Drawing.Point(1042, 827);
            this.buttonCountScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCountScore.Name = "buttonCountScore";
            this.buttonCountScore.Size = new System.Drawing.Size(572, 133);
            this.buttonCountScore.TabIndex = 5;
            this.buttonCountScore.Text = "Submit the throw";
            this.buttonCountScore.UseVisualStyleBackColor = true;
            this.buttonCountScore.Click += new System.EventHandler(this.buttonCountScore_Click);
            // 
            // buttonScoreReset
            // 
            this.buttonScoreReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScoreReset.Location = new System.Drawing.Point(12, 215);
            this.buttonScoreReset.Name = "buttonScoreReset";
            this.buttonScoreReset.Size = new System.Drawing.Size(442, 75);
            this.buttonScoreReset.TabIndex = 6;
            this.buttonScoreReset.Text = "Reset score";
            this.buttonScoreReset.UseVisualStyleBackColor = true;
            this.buttonScoreReset.Click += new System.EventHandler(this.buttonScoreReset_Click);
            // 
            // listBoxDice
            // 
            this.listBoxDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDice.FormattingEnabled = true;
            this.listBoxDice.ItemHeight = 61;
            this.listBoxDice.Location = new System.Drawing.Point(12, 354);
            this.listBoxDice.Name = "listBoxDice";
            this.listBoxDice.Size = new System.Drawing.Size(442, 492);
            this.listBoxDice.TabIndex = 7;
            // 
            // buttonDiceGenerator
            // 
            this.buttonDiceGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiceGenerator.Location = new System.Drawing.Point(12, 852);
            this.buttonDiceGenerator.Name = "buttonDiceGenerator";
            this.buttonDiceGenerator.Size = new System.Drawing.Size(441, 107);
            this.buttonDiceGenerator.TabIndex = 8;
            this.buttonDiceGenerator.Text = "Open Dice Generator";
            this.buttonDiceGenerator.UseVisualStyleBackColor = true;
            this.buttonDiceGenerator.Click += new System.EventHandler(this.buttonDiceGenerator_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 971);
            this.Controls.Add(this.buttonDiceGenerator);
            this.Controls.Add(this.listBoxDice);
            this.Controls.Add(this.buttonScoreReset);
            this.Controls.Add(this.buttonCountScore);
            this.Controls.Add(this.panelNeededScore);
            this.Controls.Add(this.panelScoring);
            this.Controls.Add(this.panelDiceBox);
            this.Controls.Add(this.buttonThrowDice);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button buttonScoreReset;
        private System.Windows.Forms.ListBox listBoxDice;
        private System.Windows.Forms.Button buttonDiceGenerator;
    }
}

