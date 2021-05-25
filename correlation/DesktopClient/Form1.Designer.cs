namespace DesktopClient
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
            this.LogCorrelatedEventsFromChainedTasksbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RadiustextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogstextBox = new System.Windows.Forms.TextBox();
            this.FindAreaViaWebServiceButton = new System.Windows.Forms.Button();
            this.FlushAIAndClosebutton = new System.Windows.Forms.Button();
            this.btnAspNet = new System.Windows.Forms.Button();
            this.btn2Hop = new System.Windows.Forms.Button();
            this.bntRootId2HopWcf = new System.Windows.Forms.Button();
            this.btn_Bing = new System.Windows.Forms.Button();
            this.btnBingAsync = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogCorrelatedEventsFromChainedTasksbutton
            // 
            this.LogCorrelatedEventsFromChainedTasksbutton.Location = new System.Drawing.Point(166, 13);
            this.LogCorrelatedEventsFromChainedTasksbutton.Name = "LogCorrelatedEventsFromChainedTasksbutton";
            this.LogCorrelatedEventsFromChainedTasksbutton.Size = new System.Drawing.Size(107, 20);
            this.LogCorrelatedEventsFromChainedTasksbutton.TabIndex = 0;
            this.LogCorrelatedEventsFromChainedTasksbutton.Text = "Find Area Local";
            this.LogCorrelatedEventsFromChainedTasksbutton.UseVisualStyleBackColor = true;
            this.LogCorrelatedEventsFromChainedTasksbutton.Click += new System.EventHandler(this.LogCorrelatedEventsFromChainedTasksbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radius";
            // 
            // RadiustextBox
            // 
            this.RadiustextBox.Location = new System.Drawing.Point(60, 13);
            this.RadiustextBox.Name = "RadiustextBox";
            this.RadiustextBox.Size = new System.Drawing.Size(100, 20);
            this.RadiustextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogstextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 341);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // LogstextBox
            // 
            this.LogstextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogstextBox.Location = new System.Drawing.Point(3, 16);
            this.LogstextBox.Multiline = true;
            this.LogstextBox.Name = "LogstextBox";
            this.LogstextBox.Size = new System.Drawing.Size(794, 322);
            this.LogstextBox.TabIndex = 0;
            // 
            // FindAreaViaWebServiceButton
            // 
            this.FindAreaViaWebServiceButton.Location = new System.Drawing.Point(279, 13);
            this.FindAreaViaWebServiceButton.Name = "FindAreaViaWebServiceButton";
            this.FindAreaViaWebServiceButton.Size = new System.Drawing.Size(152, 20);
            this.FindAreaViaWebServiceButton.TabIndex = 4;
            this.FindAreaViaWebServiceButton.Text = "Find Area WCF WebService";
            this.FindAreaViaWebServiceButton.UseVisualStyleBackColor = true;
            this.FindAreaViaWebServiceButton.Click += new System.EventHandler(this.FindAreaViaWebServiceButton_Click);
            // 
            // FlushAIAndClosebutton
            // 
            this.FlushAIAndClosebutton.Location = new System.Drawing.Point(615, 83);
            this.FlushAIAndClosebutton.Name = "FlushAIAndClosebutton";
            this.FlushAIAndClosebutton.Size = new System.Drawing.Size(179, 20);
            this.FlushAIAndClosebutton.TabIndex = 5;
            this.FlushAIAndClosebutton.Text = "Flush AppInsight and close";
            this.FlushAIAndClosebutton.UseVisualStyleBackColor = true;
            this.FlushAIAndClosebutton.Click += new System.EventHandler(this.FlushAIAndClosebutton_Click);
            // 
            // btnAspNet
            // 
            this.btnAspNet.Location = new System.Drawing.Point(437, 13);
            this.btnAspNet.Name = "btnAspNet";
            this.btnAspNet.Size = new System.Drawing.Size(113, 20);
            this.btnAspNet.TabIndex = 6;
            this.btnAspNet.Text = "Find Area AspNet";
            this.btnAspNet.UseVisualStyleBackColor = true;
            this.btnAspNet.Click += new System.EventHandler(this.btnAspNet_Click);
            // 
            // btn2Hop
            // 
            this.btn2Hop.Location = new System.Drawing.Point(280, 52);
            this.btn2Hop.Name = "btn2Hop";
            this.btn2Hop.Size = new System.Drawing.Size(151, 23);
            this.btn2Hop.TabIndex = 7;
            this.btn2Hop.Text = "RootId2Hop";
            this.btn2Hop.UseVisualStyleBackColor = true;
            this.btn2Hop.Click += new System.EventHandler(this.btn2Hop_Click);
            // 
            // bntRootId2HopWcf
            // 
            this.bntRootId2HopWcf.Location = new System.Drawing.Point(437, 51);
            this.bntRootId2HopWcf.Name = "bntRootId2HopWcf";
            this.bntRootId2HopWcf.Size = new System.Drawing.Size(113, 23);
            this.bntRootId2HopWcf.TabIndex = 8;
            this.bntRootId2HopWcf.Text = "RootId2Hop WCF";
            this.bntRootId2HopWcf.UseVisualStyleBackColor = true;
            this.bntRootId2HopWcf.Click += new System.EventHandler(this.bntRootId2HopWcf_Click);
            // 
            // btn_Bing
            // 
            this.btn_Bing.Location = new System.Drawing.Point(60, 51);
            this.btn_Bing.Name = "btn_Bing";
            this.btn_Bing.Size = new System.Drawing.Size(106, 23);
            this.btn_Bing.TabIndex = 9;
            this.btn_Bing.Text = "Bing sync";
            this.btn_Bing.UseVisualStyleBackColor = true;
            this.btn_Bing.Click += new System.EventHandler(this.btn_Bing_Click);
            // 
            // btnBingAsync
            // 
            this.btnBingAsync.Location = new System.Drawing.Point(60, 83);
            this.btnBingAsync.Name = "btnBingAsync";
            this.btnBingAsync.Size = new System.Drawing.Size(106, 23);
            this.btnBingAsync.TabIndex = 10;
            this.btnBingAsync.Text = "Bing async";
            this.btnBingAsync.UseVisualStyleBackColor = true;
            this.btnBingAsync.Click += new System.EventHandler(this.btnBingAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBingAsync);
            this.Controls.Add(this.btn_Bing);
            this.Controls.Add(this.bntRootId2HopWcf);
            this.Controls.Add(this.btn2Hop);
            this.Controls.Add(this.btnAspNet);
            this.Controls.Add(this.FlushAIAndClosebutton);
            this.Controls.Add(this.FindAreaViaWebServiceButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RadiustextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogCorrelatedEventsFromChainedTasksbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogCorrelatedEventsFromChainedTasksbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RadiustextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LogstextBox;
        private System.Windows.Forms.Button FindAreaViaWebServiceButton;
        private System.Windows.Forms.Button FlushAIAndClosebutton;
        private System.Windows.Forms.Button btnAspNet;
        private System.Windows.Forms.Button btn2Hop;
        private System.Windows.Forms.Button bntRootId2HopWcf;
        private System.Windows.Forms.Button btn_Bing;
        private System.Windows.Forms.Button btnBingAsync;
    }
}

