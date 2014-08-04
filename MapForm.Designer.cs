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
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapArea)).BeginInit();
            this.groupBoxDrawType.SuspendLayout();
            this.groupBoxGridSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFindPath
            // 
            this.buttonFindPath.Location = new System.Drawing.Point(348, 10);
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
            this.pictureBoxMapArea.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxMapArea.Name = "pictureBoxMapArea";
            this.pictureBoxMapArea.Size = new System.Drawing.Size(320, 320);
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
            this.groupBoxDrawType.Location = new System.Drawing.Point(348, 68);
            this.groupBoxDrawType.Name = "groupBoxDrawType";
            this.groupBoxDrawType.Size = new System.Drawing.Size(75, 108);
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
            this.buttonReset.Location = new System.Drawing.Point(348, 39);
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
            this.groupBoxGridSize.Location = new System.Drawing.Point(348, 183);
            this.groupBoxGridSize.Name = "groupBoxGridSize";
            this.groupBoxGridSize.Size = new System.Drawing.Size(75, 72);
            this.groupBoxGridSize.TabIndex = 4;
            this.groupBoxGridSize.TabStop = false;
            this.groupBoxGridSize.Text = "Grid Size";
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
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 340);
            this.Controls.Add(this.groupBoxGridSize);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBoxDrawType);
            this.Controls.Add(this.pictureBoxMapArea);
            this.Controls.Add(this.buttonFindPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MapForm";
            this.Text = "A Star Path Finding";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapArea)).EndInit();
            this.groupBoxDrawType.ResumeLayout(false);
            this.groupBoxDrawType.PerformLayout();
            this.groupBoxGridSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
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
    }
}

