namespace ProcessDemo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.processDemo = new System.Diagnostics.Process();
            this.lstBoxRunProcess = new System.Windows.Forms.ListBox();
            this.cmbAllProcess = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.Location = new System.Drawing.Point(13, 13);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(766, 103);
            this.tbPath.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(13, 135);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(218, 57);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Run Process";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(561, 135);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(218, 57);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Close Process";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Enabled = true;
            this.timerCurrentTime.Interval = 1000;
            this.timerCurrentTime.Tick += new System.EventHandler(this.timerCurrentTime_Tick);
            // 
            // processDemo
            // 
            this.processDemo.StartInfo.Domain = "";
            this.processDemo.StartInfo.LoadUserProfile = false;
            this.processDemo.StartInfo.Password = null;
            this.processDemo.StartInfo.StandardErrorEncoding = null;
            this.processDemo.StartInfo.StandardOutputEncoding = null;
            this.processDemo.StartInfo.UserName = "";
            this.processDemo.SynchronizingObject = this;
            // 
            // lstBoxRunProcess
            // 
            this.lstBoxRunProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstBoxRunProcess.FormattingEnabled = true;
            this.lstBoxRunProcess.ItemHeight = 18;
            this.lstBoxRunProcess.Location = new System.Drawing.Point(266, 135);
            this.lstBoxRunProcess.Name = "lstBoxRunProcess";
            this.lstBoxRunProcess.Size = new System.Drawing.Size(269, 94);
            this.lstBoxRunProcess.TabIndex = 3;
            // 
            // cmbAllProcess
            // 
            this.cmbAllProcess.FormattingEnabled = true;
            this.cmbAllProcess.Location = new System.Drawing.Point(23, 251);
            this.cmbAllProcess.Name = "cmbAllProcess";
            this.cmbAllProcess.Size = new System.Drawing.Size(739, 21);
            this.cmbAllProcess.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.cmbAllProcess);
            this.Controls.Add(this.lstBoxRunProcess);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timerCurrentTime;
        private System.Diagnostics.Process processDemo;
        private System.Windows.Forms.ListBox lstBoxRunProcess;
        private System.Windows.Forms.ComboBox cmbAllProcess;
    }
}

