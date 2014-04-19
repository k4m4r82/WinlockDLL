namespace WinlockDLLCSharp
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
            this.btnDisableTaskManager = new System.Windows.Forms.Button();
            this.btnEnableTaskManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisableTaskManager
            // 
            this.btnDisableTaskManager.Location = new System.Drawing.Point(37, 27);
            this.btnDisableTaskManager.Name = "btnDisableTaskManager";
            this.btnDisableTaskManager.Size = new System.Drawing.Size(124, 23);
            this.btnDisableTaskManager.TabIndex = 0;
            this.btnDisableTaskManager.Text = "Disable Task Manager";
            this.btnDisableTaskManager.UseVisualStyleBackColor = true;
            this.btnDisableTaskManager.Click += new System.EventHandler(this.btnDisableTaskManager_Click);
            // 
            // btnEnableTaskManager
            // 
            this.btnEnableTaskManager.Location = new System.Drawing.Point(167, 27);
            this.btnEnableTaskManager.Name = "btnEnableTaskManager";
            this.btnEnableTaskManager.Size = new System.Drawing.Size(140, 23);
            this.btnEnableTaskManager.TabIndex = 1;
            this.btnEnableTaskManager.Text = "Enable Task Manager";
            this.btnEnableTaskManager.UseVisualStyleBackColor = true;
            this.btnEnableTaskManager.Click += new System.EventHandler(this.btnEnableTaskManager_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 82);
            this.Controls.Add(this.btnEnableTaskManager);
            this.Controls.Add(this.btnDisableTaskManager);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disable/Enable Windows Task Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisableTaskManager;
        private System.Windows.Forms.Button btnEnableTaskManager;
    }
}

