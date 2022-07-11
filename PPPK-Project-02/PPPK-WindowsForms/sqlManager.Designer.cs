
namespace PPPK_WindowsForms
{
    partial class sqlManager
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
            this.components = new System.ComponentModel.Container();
            this.TbQuery = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.flpResults = new System.Windows.Forms.FlowLayoutPanel();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.TbMessages = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabResults.SuspendLayout();
            this.tabMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbQuery
            // 
            this.TbQuery.Location = new System.Drawing.Point(12, 59);
            this.TbQuery.Multiline = true;
            this.TbQuery.Name = "TbQuery";
            this.TbQuery.Size = new System.Drawing.Size(899, 222);
            this.TbQuery.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(813, 301);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(98, 40);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "Send Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Databases";
            // 
            // CbDatabases
            // 
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(77, 21);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(190, 21);
            this.CbDatabases.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabResults);
            this.tabControl1.Controls.Add(this.tabMessages);
            this.tabControl1.Location = new System.Drawing.Point(15, 337);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 297);
            this.tabControl1.TabIndex = 4;
            // 
            // tabResults
            // 
            this.tabResults.AutoScroll = true;
            this.tabResults.Controls.Add(this.flpResults);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabResults.Size = new System.Drawing.Size(888, 271);
            this.tabResults.TabIndex = 0;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // flpResults
            // 
            this.flpResults.AutoScroll = true;
            this.flpResults.Location = new System.Drawing.Point(6, 6);
            this.flpResults.Name = "flpResults";
            this.flpResults.Size = new System.Drawing.Size(876, 259);
            this.flpResults.TabIndex = 0;
            // 
            // tabMessages
            // 
            this.tabMessages.Controls.Add(this.TbMessages);
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessages.Size = new System.Drawing.Size(888, 271);
            this.tabMessages.TabIndex = 1;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // TbMessages
            // 
            this.TbMessages.Location = new System.Drawing.Point(7, 7);
            this.TbMessages.Multiline = true;
            this.TbMessages.Name = "TbMessages";
            this.TbMessages.ReadOnly = true;
            this.TbMessages.Size = new System.Drawing.Size(875, 258);
            this.TbMessages.TabIndex = 0;
            // 
            // sqlManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 646);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.TbQuery);
            this.Name = "sqlManager";
            this.Text = "SQL Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosed);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabResults.ResumeLayout(false);
            this.tabMessages.ResumeLayout(false);
            this.tabMessages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbQuery;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.TextBox TbMessages;
        public System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.FlowLayoutPanel flpResults;
    }
}

