using PCL_real.Abstraction.Models;
using PCL_real.Abstraction.Services;
using ServiceContainer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DownloadsManager
{
    public partial class Statistics_form : Form
    {
        private IEnumerable<ISavedFileModel> _files { get; set; }
        public Statistics_form(int fSize, bool labelStyle)
        {
            InitializeComponent();

            _files = CustomServiceContainer.GetService<IFileManager>().GetAllFiles(resources.targetPath);

            ChartStyle(fSize, labelStyle);
            Initialize();
        }

        private void ChartStyle(int fSize, bool labelStyle)
        {
            chart1.BackColor = Color.Transparent;
            chart1.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Transparent;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Transparent;
            chart1.ChartAreas["ChartArea1"].AxisX.LineColor = Color.FromArgb(150, 150, 150);
            chart1.ChartAreas["ChartArea1"].AxisY.LineColor = Color.FromArgb(150, 150, 150);
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.FromArgb(201, 201, 201);
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.FromArgb(201, 201, 201);
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = labelStyle;
            chart1.Legends[0].BackColor = Color.Transparent;
            chart1.Legends[0].ForeColor = Color.FromArgb(201, 201, 201);

            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;

            chart1.ChartAreas["ChartArea1"].AxisY.LabelAutoFitStyle = LabelAutoFitStyles.None;
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", fSize, System.Drawing.FontStyle.Bold);
        }

        private void Initialize()
        {
            var groups = _files.GroupBy(x => x.Creation.ToString("MM/dd/yyyy"));
            groups = groups.OrderBy(x => Convert.ToDateTime(x.Key)).Reverse().Take(10).Reverse();

            foreach (var item in groups)
            {
                chart1.Series["Downloads"].Points.AddXY(item.Key, item.Count());
                Console.WriteLine(item.Key);
            }
        }
    }
}
