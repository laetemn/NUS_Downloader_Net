﻿namespace NUS_Downloader_Net
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_down_titles = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_patch_external = new System.Windows.Forms.Button();
            this.button_export_down_list = new System.Windows.Forms.Button();
            this.checkBox_auto_retry = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_download = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_downSpeed = new System.Windows.Forms.Label();
            this.progressBar_total = new System.Windows.Forms.ProgressBar();
            this.progressBar_current = new System.Windows.Forms.ProgressBar();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_down_titles
            // 
            this.textBox_down_titles.Location = new System.Drawing.Point(6, 38);
            this.textBox_down_titles.Multiline = true;
            this.textBox_down_titles.Name = "textBox_down_titles";
            this.textBox_down_titles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_down_titles.Size = new System.Drawing.Size(366, 196);
            this.textBox_down_titles.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_patch_external);
            this.groupBox1.Controls.Add(this.button_export_down_list);
            this.groupBox1.Controls.Add(this.checkBox_auto_retry);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_download);
            this.groupBox1.Controls.Add(this.textBox_down_titles);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // button_patch_external
            // 
            this.button_patch_external.Location = new System.Drawing.Point(387, 139);
            this.button_patch_external.Name = "button_patch_external";
            this.button_patch_external.Size = new System.Drawing.Size(134, 23);
            this.button_patch_external.TabIndex = 5;
            this.button_patch_external.Text = "Patch";
            this.button_patch_external.UseVisualStyleBackColor = true;
            this.button_patch_external.Visible = false;
            this.button_patch_external.Click += new System.EventHandler(this.button_patch_external_Click);
            // 
            // button_export_down_list
            // 
            this.button_export_down_list.Location = new System.Drawing.Point(387, 93);
            this.button_export_down_list.Name = "button_export_down_list";
            this.button_export_down_list.Size = new System.Drawing.Size(134, 23);
            this.button_export_down_list.TabIndex = 4;
            this.button_export_down_list.Text = "Export";
            this.button_export_down_list.UseVisualStyleBackColor = true;
            this.button_export_down_list.Visible = false;
            this.button_export_down_list.Click += new System.EventHandler(this.button_export_down_list_Click);
            // 
            // checkBox_auto_retry
            // 
            this.checkBox_auto_retry.AutoSize = true;
            this.checkBox_auto_retry.Checked = true;
            this.checkBox_auto_retry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_auto_retry.Location = new System.Drawing.Point(387, 71);
            this.checkBox_auto_retry.Name = "checkBox_auto_retry";
            this.checkBox_auto_retry.Size = new System.Drawing.Size(84, 16);
            this.checkBox_auto_retry.TabIndex = 3;
            this.checkBox_auto_retry.Text = "Auto retry";
            this.checkBox_auto_retry.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title id";
            // 
            // button_download
            // 
            this.button_download.Location = new System.Drawing.Point(387, 36);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(134, 23);
            this.button_download.TabIndex = 1;
            this.button_download.Text = "Download";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_downSpeed);
            this.groupBox2.Controls.Add(this.progressBar_total);
            this.groupBox2.Controls.Add(this.progressBar_current);
            this.groupBox2.Controls.Add(this.textBox_log);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // label_downSpeed
            // 
            this.label_downSpeed.AutoSize = true;
            this.label_downSpeed.Location = new System.Drawing.Point(512, 33);
            this.label_downSpeed.Name = "label_downSpeed";
            this.label_downSpeed.Size = new System.Drawing.Size(0, 12);
            this.label_downSpeed.TabIndex = 3;
            // 
            // progressBar_total
            // 
            this.progressBar_total.Location = new System.Drawing.Point(7, 42);
            this.progressBar_total.Name = "progressBar_total";
            this.progressBar_total.Size = new System.Drawing.Size(484, 15);
            this.progressBar_total.TabIndex = 2;
            // 
            // progressBar_current
            // 
            this.progressBar_current.Location = new System.Drawing.Point(7, 20);
            this.progressBar_current.Name = "progressBar_current";
            this.progressBar_current.Size = new System.Drawing.Size(484, 16);
            this.progressBar_current.TabIndex = 1;
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(7, 63);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(571, 137);
            this.textBox_log.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NUS Downloader .Net v0.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
 
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_down_titles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_patch_external;
        private System.Windows.Forms.Button button_export_down_list;
        private System.Windows.Forms.CheckBox checkBox_auto_retry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar_total;
        private System.Windows.Forms.ProgressBar progressBar_current;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Label label_downSpeed;
    }
}

