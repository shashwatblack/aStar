namespace aStar
{
    partial class MapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            this.buttonFindPath = new System.Windows.Forms.Button();
            this.pictureBoxMapArea = new System.Windows.Forms.PictureBox();
            this.groupBoxDrawType = new System.Windows.Forms.GroupBox();
            this.radioErase = new System.Windows.Forms.RadioButton();
            this.radioWall = new System.Windows.Forms.RadioButton();
            this.radioGoal = new System.Windows.Forms.RadioButton();
            this.radioStart = new System.Windows.Forms.RadioButton();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxGridSize = new System.Windows.Forms.GroupBox();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.labelCost = new System.Windows.Forms.Label();
            this.checkBoxDiagonal = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapArea)).BeginInit();
            this.groupBoxDrawType.SuspendLayout();
            this.groupBoxGridSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFindPath
            // 
            this.buttonFindPath.Location = new System.Drawing.Point(3, 3);
            this.buttonFindPath.Name = "buttonFindPath";
            this.buttonFindPath.Size = new System.Drawing.Size(75, 23);
            this.buttonFindPath.TabIndex = 0;
            this.buttonFindPath.Text = "Find Path";
            this.buttonFindPath.UseVisualStyleBackColor = true;
            this.buttonFindPath.Click += new System.EventHandler(this.buttonFindPath_Click);
            // 
            // pictureBoxMapArea
            // 
            this.pictureBoxMapArea.BackColor = System.Drawing.Color.Khaki;
            this.pictureBoxMapArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMapArea.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMapArea.Name = "pictureBoxMapArea";
            this.pictureBoxMapArea.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBoxMapArea.Size = new System.Drawing.Size(334, 334);
            this.pictureBoxMapArea.TabIndex = 1;
            this.pictureBoxMapArea.TabStop = false;
            this.pictureBoxMapArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMapArea_MouseClick);
            // 
            // groupBoxDrawType
            // 
            this.groupBoxDrawType.Controls.Add(this.radioErase);
            this.groupBoxDrawType.Controls.Add(this.radioWall);
            this.groupBoxDrawType.Controls.Add(this.radioGoal);
            this.groupBoxDrawType.Controls.Add(this.radioStart);
            this.groupBoxDrawType.Location = new System.Drawing.Point(3, 63);
            this.groupBoxDrawType.Name = "groupBoxDrawType";
            this.groupBoxDrawType.Size = new System.Drawing.Size(75, 104);
            this.groupBoxDrawType.TabIndex = 2;
            this.groupBoxDrawType.TabStop = false;
            this.groupBoxDrawType.Text = "Draw type";
            // 
            // radioErase
            // 
            this.radioErase.AutoSize = true;
            this.radioErase.Location = new System.Drawing.Point(6, 85);
            this.radioErase.Name = "radioErase";
            this.radioErase.Size = new System.Drawing.Size(52, 17);
            this.radioErase.TabIndex = 3;
            this.radioErase.TabStop = true;
            this.radioErase.Text = "Erase";
            this.radioErase.UseVisualStyleBackColor = true;
            // 
            // radioWall
            // 
            this.radioWall.AutoSize = true;
            this.radioWall.Checked = true;
            this.radioWall.Location = new System.Drawing.Point(6, 19);
            this.radioWall.Name = "radioWall";
            this.radioWall.Size = new System.Drawing.Size(46, 17);
            this.radioWall.TabIndex = 2;
            this.radioWall.TabStop = true;
            this.radioWall.Text = "Wall";
            this.radioWall.UseVisualStyleBackColor = true;
            // 
            // radioGoal
            // 
            this.radioGoal.AutoSize = true;
            this.radioGoal.Location = new System.Drawing.Point(6, 63);
            this.radioGoal.Name = "radioGoal";
            this.radioGoal.Size = new System.Drawing.Size(47, 17);
            this.radioGoal.TabIndex = 1;
            this.radioGoal.Text = "Goal";
            this.radioGoal.UseVisualStyleBackColor = true;
            // 
            // radioStart
            // 
            this.radioStart.AutoSize = true;
            this.radioStart.Location = new System.Drawing.Point(6, 41);
            this.radioStart.Name = "radioStart";
            this.radioStart.Size = new System.Drawing.Size(47, 17);
            this.radioStart.TabIndex = 0;
            this.radioStart.Text = "Start";
            this.radioStart.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(3, 33);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBoxGridSize
            // 
            this.groupBoxGridSize.Controls.Add(this.numericUpDownHeight);
            this.groupBoxGridSize.Controls.Add(this.numericUpDownWidth);
            this.groupBoxGridSize.Location = new System.Drawing.Point(3, 203);
            this.groupBoxGridSize.Name = "groupBoxGridSize";
            this.groupBoxGridSize.Size = new System.Drawing.Size(75, 75);
            this.groupBoxGridSize.TabIndex = 4;
            this.groupBoxGridSize.TabStop = false;
            this.groupBoxGridSize.Text = "Grid Size";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(7, 45);
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownHeight.TabIndex = 1;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.numericUpDownHeight_ValueChanged);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(7, 19);
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownWidth.TabIndex = 0;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(3, 285);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(0, 13);
            this.labelCost.TabIndex = 5;
            // 
            // checkBoxDiagonal
            // 
            this.checkBoxDiagonal.AutoSize = true;
            this.checkBoxDiagonal.Location = new System.Drawing.Point(3, 178);
            this.checkBoxDiagonal.Name = "checkBoxDiagonal";
            this.checkBoxDiagonal.Size = new System.Drawing.Size(68, 17);
            this.checkBoxDiagonal.TabIndex = 6;
            this.checkBoxDiagonal.Text = "Diagonal";
            this.checkBoxDiagonal.UseVisualStyleBackColor = true;
            this.checkBoxDiagonal.CheckedChanged += new System.EventHandler(this.checkBoxDiagonal_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxMapArea, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 340);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonFindPath, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelCost, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxDiagonal, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxGridSize, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonReset, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxDrawType, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(343, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(94, 334);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 340);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(456, 379);
            this.Name = "MapForm";
            this.Text = "A Star Path Finding";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MapForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapArea)).EndInit();
            this.groupBoxDrawType.ResumeLayout(false);
            this.groupBoxDrawType.PerformLayout();
            this.groupBoxGridSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFindPath;
        private System.Windows.Forms.PictureBox pictureBoxMapArea;
        private System.Windows.Forms.GroupBox groupBoxDrawType;
        private System.Windows.Forms.RadioButton radioWall;
        private System.Windows.Forms.RadioButton radioGoal;
        private System.Windows.Forms.RadioButton radioStart;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RadioButton radioErase;
        private System.Windows.Forms.GroupBox groupBoxGridSize;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.CheckBox checkBoxDiagonal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

