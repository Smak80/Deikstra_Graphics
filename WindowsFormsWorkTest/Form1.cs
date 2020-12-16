using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deikstra;

namespace WindowsFormsWorkTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFile();
        }

        private double[,] gr;

        private void LoadFile()
        {
            try
            {
                gr = GraphLoader.Load(fileName.Text);
                begSelector.Maximum = gr.GetLength(0);
                endSelector.Maximum = gr.GetLength(0);
                begSelector.Enabled = true;
                endSelector.Enabled = true;
                btnStart.Enabled = true;
            }
            catch (Exception e)
            {
                begSelector.Enabled = false;
                endSelector.Enabled = false;
                btnStart.Enabled = false;
            }
        }

        private void fileName_TextChanged(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var beg = (int) begSelector.Value - 1;
            var end = (int) endSelector.Value - 1;
            if (beg >= 0 && end >= 0)
            {
                Graph graph = new Graph(gr);
                var path = graph.GetShortestPath(beg, end);
                var length = Graph.GetShortestPathLength(path);
                lengthResult.Text = length.ToString();
                var vrtx = Graph.ShowPath(path).Split(
                    new char[] {'-', '>', '|', ' '}, 
                    StringSplitOptions.RemoveEmptyEntries);
                pathResult.Items.Clear();
                foreach (var line in vrtx)
                {
                    int v = 0;
                    int.TryParse(line, out v);
                    pathResult.Items.Add((v+1).ToString());
                }
            }
        }
    }
}
