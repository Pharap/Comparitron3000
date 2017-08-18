﻿namespace comparitron.ui
{
    partial class FormMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxViewMode = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTrackLeftFar = new System.Windows.Forms.Button();
            this.btnTrackLeft = new System.Windows.Forms.Button();
            this.btnJumpFrame = new System.Windows.Forms.Button();
            this.btnTrackRight = new System.Windows.Forms.Button();
            this.btnTrackRightFar = new System.Windows.Forms.Button();
            this.trackbarFrame = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comparitronCoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comparisonViewer = new comparitron.ui.ComparisonViewer();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tableLayoutLeft.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarFrame)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparitronCoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.engageToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(1532, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.loadToolStripMenuItem1,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "New";
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // engageToolStripMenuItem
            // 
            this.engageToolStripMenuItem.Name = "engageToolStripMenuItem";
            this.engageToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.engageToolStripMenuItem.Text = "Engage!";
            this.engageToolStripMenuItem.Click += new System.EventHandler(this.engageToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 721);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1532, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutLeft);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerMain.Size = new System.Drawing.Size(1532, 697);
            this.splitContainerMain.SplitterDistance = 739;
            this.splitContainerMain.TabIndex = 2;
            // 
            // tableLayoutLeft
            // 
            this.tableLayoutLeft.AutoSize = true;
            this.tableLayoutLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutLeft.ColumnCount = 2;
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLeft.Controls.Add(this.comparisonViewer, 0, 1);
            this.tableLayoutLeft.Controls.Add(this.comboBoxViewMode, 0, 0);
            this.tableLayoutLeft.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutLeft.Controls.Add(this.trackbarFrame, 0, 3);
            this.tableLayoutLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutLeft.Name = "tableLayoutLeft";
            this.tableLayoutLeft.RowCount = 4;
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutLeft.Size = new System.Drawing.Size(737, 695);
            this.tableLayoutLeft.TabIndex = 0;
            // 
            // comboBoxViewMode
            // 
            this.comboBoxViewMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxViewMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxViewMode.FormattingEnabled = true;
            this.comboBoxViewMode.Location = new System.Drawing.Point(3, 4);
            this.comboBoxViewMode.Name = "comboBoxViewMode";
            this.comboBoxViewMode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxViewMode.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutLeft.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnTrackLeftFar);
            this.flowLayoutPanel1.Controls.Add(this.btnTrackLeft);
            this.flowLayoutPanel1.Controls.Add(this.btnJumpFrame);
            this.flowLayoutPanel1.Controls.Add(this.btnTrackRight);
            this.flowLayoutPanel1.Controls.Add(this.btnTrackRightFar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(167, 635);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(405, 29);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnTrackLeftFar
            // 
            this.btnTrackLeftFar.Location = new System.Drawing.Point(3, 3);
            this.btnTrackLeftFar.Name = "btnTrackLeftFar";
            this.btnTrackLeftFar.Size = new System.Drawing.Size(75, 23);
            this.btnTrackLeftFar.TabIndex = 0;
            this.btnTrackLeftFar.Text = "<--";
            this.btnTrackLeftFar.UseVisualStyleBackColor = true;
            // 
            // btnTrackLeft
            // 
            this.btnTrackLeft.Location = new System.Drawing.Point(84, 3);
            this.btnTrackLeft.Name = "btnTrackLeft";
            this.btnTrackLeft.Size = new System.Drawing.Size(75, 23);
            this.btnTrackLeft.TabIndex = 1;
            this.btnTrackLeft.Text = "<";
            this.btnTrackLeft.UseVisualStyleBackColor = true;
            // 
            // btnJumpFrame
            // 
            this.btnJumpFrame.Location = new System.Drawing.Point(165, 3);
            this.btnJumpFrame.Name = "btnJumpFrame";
            this.btnJumpFrame.Size = new System.Drawing.Size(75, 23);
            this.btnJumpFrame.TabIndex = 2;
            this.btnJumpFrame.Text = "Frame";
            this.btnJumpFrame.UseVisualStyleBackColor = true;
            // 
            // btnTrackRight
            // 
            this.btnTrackRight.Location = new System.Drawing.Point(246, 3);
            this.btnTrackRight.Name = "btnTrackRight";
            this.btnTrackRight.Size = new System.Drawing.Size(75, 23);
            this.btnTrackRight.TabIndex = 3;
            this.btnTrackRight.Text = ">";
            this.btnTrackRight.UseVisualStyleBackColor = true;
            // 
            // btnTrackRightFar
            // 
            this.btnTrackRightFar.Location = new System.Drawing.Point(327, 3);
            this.btnTrackRightFar.Name = "btnTrackRightFar";
            this.btnTrackRightFar.Size = new System.Drawing.Size(75, 23);
            this.btnTrackRightFar.TabIndex = 4;
            this.btnTrackRightFar.Text = "-->";
            this.btnTrackRightFar.UseVisualStyleBackColor = true;
            // 
            // trackbarFrame
            // 
            this.tableLayoutLeft.SetColumnSpan(this.trackbarFrame, 2);
            this.trackbarFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackbarFrame.Location = new System.Drawing.Point(3, 668);
            this.trackbarFrame.Name = "trackbarFrame";
            this.trackbarFrame.Size = new System.Drawing.Size(733, 24);
            this.trackbarFrame.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 695);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 635);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(787, 30);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button2);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 665);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(787, 30);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(781, 629);
            this.dataGridView.TabIndex = 3;
            // 
            // comparitronCoreBindingSource
            // 
            this.comparitronCoreBindingSource.DataSource = typeof(comparitron.ComparitronCore);
            // 
            // comparisonViewer
            // 
            this.comparisonViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutLeft.SetColumnSpan(this.comparisonViewer, 2);
            this.comparisonViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comparisonViewer.Location = new System.Drawing.Point(3, 33);
            this.comparisonViewer.Name = "comparisonViewer";
            this.comparisonViewer.Size = new System.Drawing.Size(733, 599);
            this.comparisonViewer.TabIndex = 0;
            this.comparisonViewer.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 743);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.Text = "Comparitron 3000";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tableLayoutLeft.ResumeLayout(false);
            this.tableLayoutLeft.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackbarFrame)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparitronCoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLeft;
        private ComparisonViewer comparisonViewer;
        private System.Windows.Forms.ComboBox comboBoxViewMode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TrackBar trackbarFrame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTrackLeftFar;
        private System.Windows.Forms.Button btnTrackLeft;
        private System.Windows.Forms.Button btnJumpFrame;
        private System.Windows.Forms.Button btnTrackRight;
        private System.Windows.Forms.Button btnTrackRightFar;
        private System.Windows.Forms.ToolStripMenuItem engageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.BindingSource comparitronCoreBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

