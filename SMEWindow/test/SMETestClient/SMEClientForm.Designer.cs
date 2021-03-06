﻿namespace SMETestClient
{
    partial class SMEClientForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.errorGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nullRefErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePathErrorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nativeErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nullReferenceErrorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filePathErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpSendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handledExceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorGenToolStripMenuItem,
            this.dumpSendToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // errorGenToolStripMenuItem
            // 
            this.errorGenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalErrorToolStripMenuItem,
            this.threadToolStripMenuItem});
            this.errorGenToolStripMenuItem.Name = "errorGenToolStripMenuItem";
            this.errorGenToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.errorGenToolStripMenuItem.Text = "Error_Gen";
            // 
            // generalErrorToolStripMenuItem
            // 
            this.generalErrorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nullRefErrorToolStripMenuItem,
            this.filePathErrorToolStripMenuItem1,
            this.nativeErrorToolStripMenuItem,
            this.handledExceptionToolStripMenuItem});
            this.generalErrorToolStripMenuItem.Name = "generalErrorToolStripMenuItem";
            this.generalErrorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generalErrorToolStripMenuItem.Text = "General_Error";
            // 
            // nullRefErrorToolStripMenuItem
            // 
            this.nullRefErrorToolStripMenuItem.Name = "nullRefErrorToolStripMenuItem";
            this.nullRefErrorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.nullRefErrorToolStripMenuItem.Text = "NullRefError";
            this.nullRefErrorToolStripMenuItem.Click += new System.EventHandler(this.nullRefErrorToolStripMenuItem_Click);
            // 
            // filePathErrorToolStripMenuItem1
            // 
            this.filePathErrorToolStripMenuItem1.Name = "filePathErrorToolStripMenuItem1";
            this.filePathErrorToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.filePathErrorToolStripMenuItem1.Text = "FilePathError";
            this.filePathErrorToolStripMenuItem1.Click += new System.EventHandler(this.filePathErrorToolStripMenuItem1_Click);
            // 
            // nativeErrorToolStripMenuItem
            // 
            this.nativeErrorToolStripMenuItem.Name = "nativeErrorToolStripMenuItem";
            this.nativeErrorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.nativeErrorToolStripMenuItem.Text = "NativeError";
            this.nativeErrorToolStripMenuItem.Click += new System.EventHandler(this.nativeErrorToolStripMenuItem_Click);
            // 
            // threadToolStripMenuItem
            // 
            this.threadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nullReferenceErrorToolStripMenuItem1,
            this.filePathErrorToolStripMenuItem});
            this.threadToolStripMenuItem.Name = "threadToolStripMenuItem";
            this.threadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.threadToolStripMenuItem.Text = "Thread_Error";
            // 
            // nullReferenceErrorToolStripMenuItem1
            // 
            this.nullReferenceErrorToolStripMenuItem1.Name = "nullReferenceErrorToolStripMenuItem1";
            this.nullReferenceErrorToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.nullReferenceErrorToolStripMenuItem1.Text = "NullReferenceError";
            this.nullReferenceErrorToolStripMenuItem1.Click += new System.EventHandler(this.nullReferenceErrorToolStripMenuItem1_Click);
            // 
            // filePathErrorToolStripMenuItem
            // 
            this.filePathErrorToolStripMenuItem.Name = "filePathErrorToolStripMenuItem";
            this.filePathErrorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.filePathErrorToolStripMenuItem.Text = "FilePathError";
            this.filePathErrorToolStripMenuItem.Click += new System.EventHandler(this.filePathErrorToolStripMenuItem_Click);
            // 
            // dumpSendToolStripMenuItem
            // 
            this.dumpSendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSendToolStripMenuItem});
            this.dumpSendToolStripMenuItem.Name = "dumpSendToolStripMenuItem";
            this.dumpSendToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.dumpSendToolStripMenuItem.Text = "Dump_Send";
            // 
            // fileSendToolStripMenuItem
            // 
            this.fileSendToolStripMenuItem.Name = "fileSendToolStripMenuItem";
            this.fileSendToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.fileSendToolStripMenuItem.Text = "FileSend";
            this.fileSendToolStripMenuItem.Click += new System.EventHandler(this.fileSendToolStripMenuItem_Click);
            // 
            // handledExceptionToolStripMenuItem
            // 
            this.handledExceptionToolStripMenuItem.Name = "handledExceptionToolStripMenuItem";
            this.handledExceptionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.handledExceptionToolStripMenuItem.Text = "HandledException";
            this.handledExceptionToolStripMenuItem.Click += new System.EventHandler(this.handledExceptionToolStripMenuItem_Click);
            // 
            // SMEClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 405);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SMEClientForm";
            this.Text = "SMETestClient";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem errorGenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nullReferenceErrorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filePathErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nullRefErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filePathErrorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dumpSendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nativeErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handledExceptionToolStripMenuItem;
    }
}

