namespace TreeAnim
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
            this.ExpTb = new System.Windows.Forms.TextBox();
            this.graphCanvas1 = new GraphApp.GraphCanvas();
            this.SuspendLayout();
            // 
            // ExpTb
            // 
            this.ExpTb.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExpTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpTb.Location = new System.Drawing.Point(0, 0);
            this.ExpTb.Name = "ExpTb";
            this.ExpTb.Size = new System.Drawing.Size(715, 26);
            this.ExpTb.TabIndex = 1;
            this.ExpTb.TextChanged += new System.EventHandler(this.ExpTb_TextChanged);
            // 
            // graphCanvas1
            // 
            this.graphCanvas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphCanvas1.Location = new System.Drawing.Point(0, 26);
            this.graphCanvas1.Name = "graphCanvas1";
            this.graphCanvas1.Size = new System.Drawing.Size(715, 315);
            this.graphCanvas1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 341);
            this.Controls.Add(this.graphCanvas1);
            this.Controls.Add(this.ExpTb);
            this.Name = "Form1";
            this.Text = "Expression Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExpTb;
        private GraphApp.GraphCanvas graphCanvas1;
    }
}

