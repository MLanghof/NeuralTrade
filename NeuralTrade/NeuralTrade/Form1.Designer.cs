namespace NeuralTrade
{
    partial class Form1
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
            this.buttonTrain = new System.Windows.Forms.Button();
            this.textBoxLogging = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.textBoxIterations = new System.Windows.Forms.TextBox();
            this.labelIterations = new System.Windows.Forms.Label();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxLearningRate = new System.Windows.Forms.TextBox();
            this.labelLearningRate = new System.Windows.Forms.Label();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.groupBoxLogging = new System.Windows.Forms.GroupBox();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.groupBoxLogging.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTrain
            // 
            this.buttonTrain.Location = new System.Drawing.Point(9, 19);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(75, 23);
            this.buttonTrain.TabIndex = 0;
            this.buttonTrain.Text = "Train";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // textBoxLogging
            // 
            this.textBoxLogging.Location = new System.Drawing.Point(6, 19);
            this.textBoxLogging.Multiline = true;
            this.textBoxLogging.Name = "textBoxLogging";
            this.textBoxLogging.Size = new System.Drawing.Size(188, 190);
            this.textBoxLogging.TabIndex = 1;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(119, 19);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.AutoSize = true;
            this.groupBoxSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxSettings.Controls.Add(this.labelLearningRate);
            this.groupBoxSettings.Controls.Add(this.labelError);
            this.groupBoxSettings.Controls.Add(this.labelIterations);
            this.groupBoxSettings.Controls.Add(this.textBoxLearningRate);
            this.groupBoxSettings.Controls.Add(this.textBoxError);
            this.groupBoxSettings.Controls.Add(this.textBoxIterations);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(200, 110);
            this.groupBoxSettings.TabIndex = 2;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Training Settings";
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Location = new System.Drawing.Point(94, 19);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(100, 20);
            this.textBoxIterations.TabIndex = 0;
            this.textBoxIterations.Text = "20000";
            // 
            // labelIterations
            // 
            this.labelIterations.AutoSize = true;
            this.labelIterations.Location = new System.Drawing.Point(6, 22);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(53, 13);
            this.labelIterations.TabIndex = 1;
            this.labelIterations.Text = "Iterations:";
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(94, 45);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(100, 20);
            this.textBoxError.TabIndex = 0;
            this.textBoxError.Text = "0.005";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(6, 48);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(78, 13);
            this.labelError.TabIndex = 1;
            this.labelError.Text = "Error threshold:";
            // 
            // textBoxLearningRate
            // 
            this.textBoxLearningRate.Location = new System.Drawing.Point(94, 71);
            this.textBoxLearningRate.Name = "textBoxLearningRate";
            this.textBoxLearningRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxLearningRate.TabIndex = 0;
            this.textBoxLearningRate.Text = "0.3";
            // 
            // labelLearningRate
            // 
            this.labelLearningRate.AutoSize = true;
            this.labelLearningRate.Location = new System.Drawing.Point(6, 74);
            this.labelLearningRate.Name = "labelLearningRate";
            this.labelLearningRate.Size = new System.Drawing.Size(72, 13);
            this.labelLearningRate.TabIndex = 1;
            this.labelLearningRate.Text = "Learning rate:";
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.buttonRun);
            this.groupBoxControl.Controls.Add(this.buttonTrain);
            this.groupBoxControl.Location = new System.Drawing.Point(12, 128);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(200, 100);
            this.groupBoxControl.TabIndex = 3;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Control";
            // 
            // groupBoxLogging
            // 
            this.groupBoxLogging.Controls.Add(this.textBoxLogging);
            this.groupBoxLogging.Location = new System.Drawing.Point(219, 13);
            this.groupBoxLogging.Name = "groupBoxLogging";
            this.groupBoxLogging.Size = new System.Drawing.Size(200, 215);
            this.groupBoxLogging.TabIndex = 4;
            this.groupBoxLogging.TabStop = false;
            this.groupBoxLogging.Text = "Logging";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 293);
            this.Controls.Add(this.groupBoxLogging);
            this.Controls.Add(this.groupBoxControl);
            this.Controls.Add(this.groupBoxSettings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxLogging.ResumeLayout(false);
            this.groupBoxLogging.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.TextBox textBoxLogging;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label labelLearningRate;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.TextBox textBoxLearningRate;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.TextBox textBoxIterations;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.GroupBox groupBoxLogging;
    }
}

