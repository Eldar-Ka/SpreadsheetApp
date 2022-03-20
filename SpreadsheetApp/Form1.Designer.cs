
namespace SpreadsheetApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbRow = new System.Windows.Forms.TextBox();
            this.btnGetCell = new System.Windows.Forms.Button();
            this.btnSetCell = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbCol = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchInRow = new System.Windows.Forms.Button();
            this.btnSearchInCol = new System.Windows.Forms.Button();
            this.tbRow1 = new System.Windows.Forms.TextBox();
            this.tbCol2 = new System.Windows.Forms.TextBox();
            this.tbCol1 = new System.Windows.Forms.TextBox();
            this.tbRow2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchInRange = new System.Windows.Forms.Button();
            this.btnExchangeCols = new System.Windows.Forms.Button();
            this.btnExchangeRows = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnAddCol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddRow = new System.Windows.Forms.TextBox();
            this.tbAddCol = new System.Windows.Forms.TextBox();
            this.btnGetSize = new System.Windows.Forms.Button();
            this.tbDataR = new System.Windows.Forms.TextBox();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Green;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(21, 21);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 56);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Location = new System.Drawing.Point(150, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 56);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbRow
            // 
            this.tbRow.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRow.Location = new System.Drawing.Point(21, 135);
            this.tbRow.Name = "tbRow";
            this.tbRow.Size = new System.Drawing.Size(90, 32);
            this.tbRow.TabIndex = 2;
            // 
            // btnGetCell
            // 
            this.btnGetCell.Location = new System.Drawing.Point(125, 147);
            this.btnGetCell.Name = "btnGetCell";
            this.btnGetCell.Padding = new System.Windows.Forms.Padding(1);
            this.btnGetCell.Size = new System.Drawing.Size(125, 44);
            this.btnGetCell.TabIndex = 4;
            this.btnGetCell.Text = "Get Cell";
            this.btnGetCell.UseVisualStyleBackColor = true;
            this.btnGetCell.Click += new System.EventHandler(this.btnGetCell_Click);
            // 
            // btnSetCell
            // 
            this.btnSetCell.Location = new System.Drawing.Point(125, 196);
            this.btnSetCell.Name = "btnSetCell";
            this.btnSetCell.Padding = new System.Windows.Forms.Padding(1);
            this.btnSetCell.Size = new System.Drawing.Size(125, 44);
            this.btnSetCell.TabIndex = 6;
            this.btnSetCell.Text = "Set Cell";
            this.btnSetCell.UseVisualStyleBackColor = true;
            this.btnSetCell.Click += new System.EventHandler(this.btnSetCell_Click);
            // 
            // tbData
            // 
            this.tbData.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbData.Location = new System.Drawing.Point(21, 217);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(90, 32);
            this.tbData.TabIndex = 7;
            // 
            // tbCol
            // 
            this.tbCol.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCol.Location = new System.Drawing.Point(21, 176);
            this.tbCol.Name = "tbCol";
            this.tbCol.Size = new System.Drawing.Size(90, 32);
            this.tbCol.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(21, 269);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 41);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchInRow
            // 
            this.btnSearchInRow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchInRow.Location = new System.Drawing.Point(21, 316);
            this.btnSearchInRow.Name = "btnSearchInRow";
            this.btnSearchInRow.Size = new System.Drawing.Size(202, 40);
            this.btnSearchInRow.TabIndex = 10;
            this.btnSearchInRow.Text = "Search In Row";
            this.btnSearchInRow.UseVisualStyleBackColor = false;
            this.btnSearchInRow.Click += new System.EventHandler(this.btnSearchInRow_Click);
            // 
            // btnSearchInCol
            // 
            this.btnSearchInCol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchInCol.Location = new System.Drawing.Point(21, 362);
            this.btnSearchInCol.Name = "btnSearchInCol";
            this.btnSearchInCol.Size = new System.Drawing.Size(202, 40);
            this.btnSearchInCol.TabIndex = 11;
            this.btnSearchInCol.Text = "Search In Column";
            this.btnSearchInCol.UseVisualStyleBackColor = false;
            this.btnSearchInCol.Click += new System.EventHandler(this.btnSearchInCol_Click);
            // 
            // tbRow1
            // 
            this.tbRow1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRow1.Location = new System.Drawing.Point(21, 492);
            this.tbRow1.Name = "tbRow1";
            this.tbRow1.Size = new System.Drawing.Size(102, 32);
            this.tbRow1.TabIndex = 13;
            // 
            // tbCol2
            // 
            this.tbCol2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCol2.Location = new System.Drawing.Point(160, 533);
            this.tbCol2.Name = "tbCol2";
            this.tbCol2.Size = new System.Drawing.Size(100, 32);
            this.tbCol2.TabIndex = 16;
            // 
            // tbCol1
            // 
            this.tbCol1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCol1.Location = new System.Drawing.Point(21, 533);
            this.tbCol1.Name = "tbCol1";
            this.tbCol1.Size = new System.Drawing.Size(102, 32);
            this.tbCol1.TabIndex = 15;
            // 
            // tbRow2
            // 
            this.tbRow2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRow2.Location = new System.Drawing.Point(160, 492);
            this.tbRow2.Name = "tbRow2";
            this.tbRow2.Size = new System.Drawing.Size(100, 32);
            this.tbRow2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "to";
            // 
            // btnSearchInRange
            // 
            this.btnSearchInRange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchInRange.Location = new System.Drawing.Point(21, 674);
            this.btnSearchInRange.Name = "btnSearchInRange";
            this.btnSearchInRange.Size = new System.Drawing.Size(239, 40);
            this.btnSearchInRange.TabIndex = 20;
            this.btnSearchInRange.Text = "Search In Range";
            this.btnSearchInRange.UseVisualStyleBackColor = false;
            this.btnSearchInRange.Click += new System.EventHandler(this.btnSearchInRange_Click);
            // 
            // btnExchangeCols
            // 
            this.btnExchangeCols.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExchangeCols.BackgroundImage")));
            this.btnExchangeCols.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExchangeCols.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExchangeCols.ForeColor = System.Drawing.Color.Red;
            this.btnExchangeCols.Location = new System.Drawing.Point(21, 625);
            this.btnExchangeCols.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnExchangeCols.Name = "btnExchangeCols";
            this.btnExchangeCols.Size = new System.Drawing.Size(239, 40);
            this.btnExchangeCols.TabIndex = 21;
            this.btnExchangeCols.Text = "Exchange Columns";
            this.btnExchangeCols.UseVisualStyleBackColor = true;
            this.btnExchangeCols.Click += new System.EventHandler(this.btnExchangeCols_Click);
            // 
            // btnExchangeRows
            // 
            this.btnExchangeRows.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExchangeRows.BackgroundImage")));
            this.btnExchangeRows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExchangeRows.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExchangeRows.ForeColor = System.Drawing.Color.Red;
            this.btnExchangeRows.Location = new System.Drawing.Point(21, 579);
            this.btnExchangeRows.Name = "btnExchangeRows";
            this.btnExchangeRows.Size = new System.Drawing.Size(239, 40);
            this.btnExchangeRows.TabIndex = 22;
            this.btnExchangeRows.Text = "Exchange Rows";
            this.btnExchangeRows.UseVisualStyleBackColor = true;
            this.btnExchangeRows.Click += new System.EventHandler(this.btnExchangeRows_Click);
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(273, 23);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 72;
            this.dataGridView.RowTemplate.Height = 37;
            this.dataGridView.Size = new System.Drawing.Size(782, 585);
            this.dataGridView.TabIndex = 23;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(621, 622);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Padding = new System.Windows.Forms.Padding(1);
            this.btnAddRow.Size = new System.Drawing.Size(166, 43);
            this.btnAddRow.TabIndex = 24;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnAddCol
            // 
            this.btnAddCol.Location = new System.Drawing.Point(621, 671);
            this.btnAddCol.Name = "btnAddCol";
            this.btnAddCol.Padding = new System.Windows.Forms.Padding(1);
            this.btnAddCol.Size = new System.Drawing.Size(166, 43);
            this.btnAddCol.TabIndex = 25;
            this.btnAddCol.Text = "Add Column";
            this.btnAddCol.UseVisualStyleBackColor = true;
            this.btnAddCol.Click += new System.EventHandler(this.btnAddCol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 676);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "after";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(793, 625);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "after";
            // 
            // tbAddRow
            // 
            this.tbAddRow.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAddRow.Location = new System.Drawing.Point(854, 623);
            this.tbAddRow.Name = "tbAddRow";
            this.tbAddRow.Size = new System.Drawing.Size(90, 32);
            this.tbAddRow.TabIndex = 28;
            // 
            // tbAddCol
            // 
            this.tbAddCol.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAddCol.Location = new System.Drawing.Point(854, 674);
            this.tbAddCol.Name = "tbAddCol";
            this.tbAddCol.Size = new System.Drawing.Size(90, 32);
            this.tbAddCol.TabIndex = 29;
            // 
            // btnGetSize
            // 
            this.btnGetSize.BackColor = System.Drawing.Color.Wheat;
            this.btnGetSize.Location = new System.Drawing.Point(961, 623);
            this.btnGetSize.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.btnGetSize.Name = "btnGetSize";
            this.btnGetSize.Size = new System.Drawing.Size(94, 85);
            this.btnGetSize.TabIndex = 30;
            this.btnGetSize.Text = "Get Size";
            this.btnGetSize.UseVisualStyleBackColor = false;
            this.btnGetSize.Click += new System.EventHandler(this.btnGetSize_Click);
            // 
            // tbDataR
            // 
            this.tbDataR.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDataR.Location = new System.Drawing.Point(273, 680);
            this.tbDataR.Name = "tbDataR";
            this.tbDataR.Size = new System.Drawing.Size(160, 32);
            this.tbDataR.TabIndex = 31;
            // 
            // tbFile
            // 
            this.tbFile.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFile.Location = new System.Drawing.Point(21, 89);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(239, 32);
            this.tbFile.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(125, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 732);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.tbDataR);
            this.Controls.Add(this.btnGetSize);
            this.Controls.Add(this.tbAddCol);
            this.Controls.Add(this.tbAddRow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddCol);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnExchangeRows);
            this.Controls.Add(this.btnExchangeCols);
            this.Controls.Add(this.btnSearchInRange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRow2);
            this.Controls.Add(this.tbCol2);
            this.Controls.Add(this.tbCol1);
            this.Controls.Add(this.tbRow1);
            this.Controls.Add(this.btnSearchInCol);
            this.Controls.Add(this.btnSearchInRow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbCol);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.btnSetCell);
            this.Controls.Add(this.btnGetCell);
            this.Controls.Add(this.tbRow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "SpreadSheet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbRow;
        private System.Windows.Forms.Button btnGetCell;
        private System.Windows.Forms.Button btnSetCell;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbCol;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchInRow;
        private System.Windows.Forms.Button btnSearchInCol;
        private System.Windows.Forms.TextBox tbRow1;
        private System.Windows.Forms.TextBox tbCol2;
        private System.Windows.Forms.TextBox tbCol1;
        private System.Windows.Forms.TextBox tbRow2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchInRange;
        private System.Windows.Forms.Button btnExchangeCols;
        private System.Windows.Forms.Button btnExchangeRows;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnAddCol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddRow;
        private System.Windows.Forms.TextBox tbAddCol;
        private System.Windows.Forms.Button btnGetSize;
        private System.Windows.Forms.TextBox tbDataR;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

