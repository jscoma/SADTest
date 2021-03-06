﻿namespace Test
{
    partial class GraphTemplate
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.InputButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lvSearch = new System.Windows.Forms.ListView();
            this.firstNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doBCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.testSelectBox = new System.Windows.Forms.ComboBox();
            this.cbSubTest = new System.Windows.Forms.ComboBox();
            this.bGraph = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputButton
            // 
            this.InputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InputButton.Location = new System.Drawing.Point(12, 580);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 23);
            this.InputButton.TabIndex = 1;
            this.InputButton.Text = "Test Data";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Azure;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(863, 438);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lvSearch
            // 
            this.lvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lvSearch.BackColor = System.Drawing.SystemColors.Window;
            this.lvSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameCol,
            this.lastNameCol,
            this.doBCol,
            this.iDCol});
            this.lvSearch.HideSelection = false;
            this.lvSearch.Location = new System.Drawing.Point(12, 456);
            this.lvSearch.Name = "lvSearch";
            this.lvSearch.Size = new System.Drawing.Size(332, 118);
            this.lvSearch.TabIndex = 2;
            this.lvSearch.UseCompatibleStateImageBehavior = false;
            this.lvSearch.View = System.Windows.Forms.View.Details;
            this.lvSearch.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // firstNameCol
            // 
            this.firstNameCol.Text = "First Name";
            this.firstNameCol.Width = 82;
            // 
            // lastNameCol
            // 
            this.lastNameCol.Text = "Last Name";
            this.lastNameCol.Width = 82;
            // 
            // doBCol
            // 
            this.doBCol.Text = "DOB";
            this.doBCol.Width = 82;
            // 
            // iDCol
            // 
            this.iDCol.Text = "Unique ID";
            this.iDCol.Width = 82;
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchBar.Location = new System.Drawing.Point(350, 456);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(142, 20);
            this.searchBar.TabIndex = 3;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchButton.Location = new System.Drawing.Point(498, 456);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // testSelectBox
            // 
            this.testSelectBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.testSelectBox.FormattingEnabled = true;
            this.testSelectBox.Items.AddRange(new object[] {
            "Lipids",
            "Vitals"});
            this.testSelectBox.Location = new System.Drawing.Point(350, 482);
            this.testSelectBox.Name = "testSelectBox";
            this.testSelectBox.Size = new System.Drawing.Size(142, 21);
            this.testSelectBox.TabIndex = 5;
            this.testSelectBox.SelectedIndexChanged += new System.EventHandler(this.testSelectBox_SelectedIndexChanged);
            // 
            // cbSubTest
            // 
            this.cbSubTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSubTest.FormattingEnabled = true;
            this.cbSubTest.Location = new System.Drawing.Point(350, 510);
            this.cbSubTest.Name = "cbSubTest";
            this.cbSubTest.Size = new System.Drawing.Size(142, 21);
            this.cbSubTest.TabIndex = 6;
            // 
            // bGraph
            // 
            this.bGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bGraph.Location = new System.Drawing.Point(499, 510);
            this.bGraph.Name = "bGraph";
            this.bGraph.Size = new System.Drawing.Size(75, 23);
            this.bGraph.TabIndex = 7;
            this.bGraph.Text = "Graph";
            this.bGraph.UseVisualStyleBackColor = true;
            this.bGraph.Click += new System.EventHandler(this.bGraph_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(769, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Screen Shot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GraphTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(887, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bGraph);
            this.Controls.Add(this.cbSubTest);
            this.Controls.Add(this.testSelectBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.lvSearch);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.chart1);
            this.Name = "GraphTemplate";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GraphTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView lvSearch;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox testSelectBox;
        private System.Windows.Forms.ColumnHeader firstNameCol;
        private System.Windows.Forms.ColumnHeader lastNameCol;
        private System.Windows.Forms.ColumnHeader doBCol;
        private System.Windows.Forms.ColumnHeader iDCol;
        private System.Windows.Forms.ComboBox cbSubTest;
        private System.Windows.Forms.Button bGraph;
        private System.Windows.Forms.Button button1;
    }
}