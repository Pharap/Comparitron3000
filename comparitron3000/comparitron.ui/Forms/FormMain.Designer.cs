namespace comparitron.ui
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCompare = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.btnAddDivide = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGoto = new System.Windows.Forms.Button();
            this.btnSetFrame = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxInput = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.splitContainerMain.SplitterDistance = 919;
            this.splitContainerMain.TabIndex = 2;
            // 
            // tableLayoutLeft
            // 
            this.tableLayoutLeft.AutoSize = true;
            this.tableLayoutLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutLeft.ColumnCount = 2;
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeft.Controls.Add(this.comparisonViewer, 0, 1);
            this.tableLayoutLeft.Controls.Add(this.comboBoxViewMode, 0, 0);
            this.tableLayoutLeft.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutLeft.Controls.Add(this.trackbarFrame, 0, 3);
            this.tableLayoutLeft.Controls.Add(this.trackBar1, 1, 0);
            this.tableLayoutLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutLeft.Name = "tableLayoutLeft";
            this.tableLayoutLeft.RowCount = 4;
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutLeft.Size = new System.Drawing.Size(917, 695);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(256, 636);
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
            this.btnTrackLeft.Click += new System.EventHandler(this.btnTrackLeft_Click);
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
            this.btnTrackRight.Click += new System.EventHandler(this.btnTrackRight_Click);
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
            this.trackbarFrame.Size = new System.Drawing.Size(911, 24);
            this.trackbarFrame.TabIndex = 4;
            this.trackbarFrame.Scroll += new System.EventHandler(this.trackbarFrame_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(131, 3);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(783, 24);
            this.trackBar1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInput, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 695);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.btnAddCompare);
            this.flowLayoutPanel2.Controls.Add(this.btnAddText);
            this.flowLayoutPanel2.Controls.Add(this.btnAddImage);
            this.flowLayoutPanel2.Controls.Add(this.btnAddVideo);
            this.flowLayoutPanel2.Controls.Add(this.btnAddDivide);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(101, 637);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(405, 29);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnAddCompare
            // 
            this.btnAddCompare.Location = new System.Drawing.Point(3, 3);
            this.btnAddCompare.Name = "btnAddCompare";
            this.btnAddCompare.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompare.TabIndex = 0;
            this.btnAddCompare.Text = "Add Frame";
            this.btnAddCompare.UseVisualStyleBackColor = true;
            this.btnAddCompare.Click += new System.EventHandler(this.btnAddCompare_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.Location = new System.Drawing.Point(84, 3);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(75, 23);
            this.btnAddText.TabIndex = 1;
            this.btnAddText.Text = "Add Text";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(165, 3);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(75, 23);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Location = new System.Drawing.Point(246, 3);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(75, 23);
            this.btnAddVideo.TabIndex = 4;
            this.btnAddVideo.Text = "Add Video";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // btnAddDivide
            // 
            this.btnAddDivide.Location = new System.Drawing.Point(327, 3);
            this.btnAddDivide.Name = "btnAddDivide";
            this.btnAddDivide.Size = new System.Drawing.Size(75, 23);
            this.btnAddDivide.TabIndex = 3;
            this.btnAddDivide.Text = "Add Split";
            this.btnAddDivide.UseVisualStyleBackColor = true;
            this.btnAddDivide.Click += new System.EventHandler(this.btnAddDivide_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.btnMoveUp);
            this.flowLayoutPanel3.Controls.Add(this.btnMoveDown);
            this.flowLayoutPanel3.Controls.Add(this.btnDelete);
            this.flowLayoutPanel3.Controls.Add(this.btnGoto);
            this.flowLayoutPanel3.Controls.Add(this.btnSetFrame);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(101, 666);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(405, 29);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(3, 3);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 0;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(84, 3);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 1;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGoto
            // 
            this.btnGoto.Location = new System.Drawing.Point(246, 3);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(75, 23);
            this.btnGoto.TabIndex = 3;
            this.btnGoto.Text = "Goto Frame";
            this.btnGoto.UseVisualStyleBackColor = true;
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            // 
            // btnSetFrame
            // 
            this.btnSetFrame.Location = new System.Drawing.Point(327, 3);
            this.btnSetFrame.Name = "btnSetFrame";
            this.btnSetFrame.Size = new System.Drawing.Size(75, 23);
            this.btnSetFrame.TabIndex = 4;
            this.btnSetFrame.Text = "Set Frame";
            this.btnSetFrame.UseVisualStyleBackColor = true;
            this.btnSetFrame.Click += new System.EventHandler(this.btnSetFrame_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(601, 605);
            this.dataGridView.TabIndex = 3;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(3, 614);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(601, 20);
            this.textBoxInput.TabIndex = 4;
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
            this.comparisonViewer.Size = new System.Drawing.Size(911, 600);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.BindingSource comparitronCoreBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAddCompare;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnAddDivide;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.Button btnSetFrame;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

