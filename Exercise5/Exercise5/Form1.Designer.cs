namespace Exercise5
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
            this.Clear = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SecretL = new System.Windows.Forms.Label();
            this.InputTextL = new System.Windows.Forms.Label();
            this.OutputTextL = new System.Windows.Forms.Label();
            this.SecretTB = new System.Windows.Forms.TextBox();
            this.InputTB = new System.Windows.Forms.TextBox();
            this.Translate = new System.Windows.Forms.Button();
            this.OutputTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(261, 331);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(81, 33);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(597, 341);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // SecretL
            // 
            this.SecretL.AutoSize = true;
            this.SecretL.Location = new System.Drawing.Point(83, 64);
            this.SecretL.Name = "SecretL";
            this.SecretL.Size = new System.Drawing.Size(146, 17);
            this.SecretL.TabIndex = 2;
            this.SecretL.Text = "Cipher \"Secret\" Word:";
            this.SecretL.Click += new System.EventHandler(this.SecretL_Click);
            // 
            // InputTextL
            // 
            this.InputTextL.AutoSize = true;
            this.InputTextL.Location = new System.Drawing.Point(155, 134);
            this.InputTextL.Name = "InputTextL";
            this.InputTextL.Size = new System.Drawing.Size(74, 17);
            this.InputTextL.TabIndex = 3;
            this.InputTextL.Text = "Input Text:";
            this.InputTextL.Click += new System.EventHandler(this.InputTextL_Click);
            // 
            // OutputTextL
            // 
            this.OutputTextL.AutoSize = true;
            this.OutputTextL.Location = new System.Drawing.Point(143, 204);
            this.OutputTextL.Name = "OutputTextL";
            this.OutputTextL.Size = new System.Drawing.Size(86, 17);
            this.OutputTextL.TabIndex = 4;
            this.OutputTextL.Text = "Output Text:";
            this.OutputTextL.Click += new System.EventHandler(this.OutputTextL_Click);
            // 
            // SecretTB
            // 
            this.SecretTB.Location = new System.Drawing.Point(250, 61);
            this.SecretTB.Name = "SecretTB";
            this.SecretTB.Size = new System.Drawing.Size(422, 22);
            this.SecretTB.TabIndex = 5;
            this.SecretTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Secret_KeyPress);
            // 
            // InputTB
            // 
            this.InputTB.Location = new System.Drawing.Point(250, 129);
            this.InputTB.Name = "InputTB";
            this.InputTB.Size = new System.Drawing.Size(422, 22);
            this.InputTB.TabIndex = 6;
            this.InputTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(82, 341);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(147, 23);
            this.Translate.TabIndex = 8;
            this.Translate.Text = "Translate Text";
            this.Translate.UseVisualStyleBackColor = true;
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // OutputTB
            // 
            this.OutputTB.Location = new System.Drawing.Point(250, 199);
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.ReadOnly = true;
            this.OutputTB.Size = new System.Drawing.Size(422, 22);
            this.OutputTB.TabIndex = 9;
            this.OutputTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OutputTB_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputTB);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.InputTB);
            this.Controls.Add(this.SecretTB);
            this.Controls.Add(this.OutputTextL);
            this.Controls.Add(this.InputTextL);
            this.Controls.Add(this.SecretL);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Close;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label SecretL;
        private System.Windows.Forms.Label InputTextL;
        private System.Windows.Forms.Label OutputTextL;
        private System.Windows.Forms.TextBox SecretTB;
        private System.Windows.Forms.TextBox InputTB;
        private System.Windows.Forms.Button Translate;
        private System.Windows.Forms.TextBox OutputTB;
    }
}

