﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class GraphTemplate : Form
    {
        String graphName = "Default";
        public GraphTemplate()
        {
            InitializeComponent();
            removeInitalSeries();
            chart1.Series.Add(graphName);//This command can only be called with the same name once.
        }

        public GraphTemplate(String type)
        {
            InitializeComponent();
            removeInitalSeries();
            graphName = type;
            chart1.Series.Add(graphName);

        }

        private void removeInitalSeries()//Only call after initalizing the chart. This removes the "Series1" series from the chart
        {
            System.Windows.Forms.DataVisualization.Charting.Series[] initialSeries = chart1.Series.ToArray();
            chart1.Series.Remove(initialSeries[0]);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Currently using test data, replace with real data.
        {
            
            chart1.Series[graphName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;//May not be needed
            chart1.Series[graphName].Points.AddY(20);
            chart1.Series[graphName].Points.AddY(10);
            chart1.Series[graphName].Points.AddY(0);
            chart1.Series[graphName].Points.AddY(3);
            chart1.Series[graphName].Points.AddY(30);
            chart1.Series[graphName].Points.AddY(75);
            chart1.Series[graphName].ChartArea = "ChartArea1";//may not be needed
        }
    }
}
