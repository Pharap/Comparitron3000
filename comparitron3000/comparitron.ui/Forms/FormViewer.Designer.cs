namespace comparitron.ui
{
    partial class FormViewer
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
            this.comparisonViewer = new comparitron.ui.ComparisonViewer();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // comparisonViewer
            // 
            this.comparisonViewer.BasePath = "";
            this.comparisonViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.comparisonViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comparisonViewer.Frame = 1;
            this.comparisonViewer.Location = new System.Drawing.Point(0, 0);
            this.comparisonViewer.Name = "comparisonViewer";
            this.comparisonViewer.pathBD = null;
            this.comparisonViewer.pathMX = null;
            this.comparisonViewer.pathTV = null;
            this.comparisonViewer.settings = null;
            this.comparisonViewer.Size = new System.Drawing.Size(878, 457);
            this.comparisonViewer.Slave = false;
            this.comparisonViewer.TabIndex = 1;
            this.comparisonViewer.TabStop = false;
            this.comparisonViewer.Transition = 50F;
            this.comparisonViewer.DoubleClick += new System.EventHandler(this.comparisonViewer_MouseDoubleClick);
            // 
            // FormViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 457);
            this.Controls.Add(this.comparisonViewer);
            this.Name = "FormViewer";
            this.ShowIcon = false;
            this.Text = "FormViewer";
            this.Load += new System.EventHandler(this.FormViewer_Load);
            this.ResizeEnd += new System.EventHandler(this.FormViewer_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.comparisonViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComparisonViewer comparisonViewer;
    }
}