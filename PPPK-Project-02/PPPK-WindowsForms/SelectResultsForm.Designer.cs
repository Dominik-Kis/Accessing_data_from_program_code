
namespace PPPK_WindowsForms
{
    partial class SelectResultsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgResults = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.DgResults)).BeginInit();
            this.SuspendLayout();
            // 
            // DgResults
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.DgResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgResults.Location = new System.Drawing.Point(12, 12);
            this.DgResults.Name = "DgResults";
            this.DgResults.Size = new System.Drawing.Size(776, 426);
            this.DgResults.TabIndex = 0;
            // 
            // SelectResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgResults);
            this.Name = "SelectResultsForm";
            this.Text = "SelectResultsForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgResults;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}