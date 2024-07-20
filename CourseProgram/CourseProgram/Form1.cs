using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseProgram
{
    public partial class Form1 : Form
    {
        private СhartList chartList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chartList = new СhartList(1);
            SQLiteConnection connection = new SQLiteConnection("Integrated Security = SSPI; DataSource = func.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"SELECT Name, A, B, Type FROM func";
            using (var rd1 = command.ExecuteReader())
            {
                while (rd1.Read())
                {
                    chartList.Add(new MyChart(rd1.GetString(0),rd1.GetDouble(1),rd1.GetDouble(2),(ChartType)Enum.Parse(typeof(ChartType),rd1.GetString(3))));
                }
            }
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.DataSource = chartList.Charts;

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chart1.Series["Chart"].Points.Clear();
            chart1.Series["Axis"].Points.Clear();
            MyChart chart = chartList[dataGridView1.CurrentCell.RowIndex];
            double step = !string.IsNullOrWhiteSpace(stepS.Text) ? double.Parse(stepS.Text) : 0;
            if (step == 0)
            {
                return;
            }
            double xMin = !string.IsNullOrWhiteSpace(xMinS.Text) ? double.Parse(xMinS.Text) : 0;
            double xMax = !string.IsNullOrWhiteSpace(xMaxS.Text) ? double.Parse(xMaxS.Text) : 0;
            double yMin = !string.IsNullOrWhiteSpace(yMinS.Text) ? double.Parse(yMinS.Text) : 0;
            double yMax = !string.IsNullOrWhiteSpace(yMaxS.Text) ? double.Parse(yMaxS.Text) : 0;
            for (double x = xMin; x <= xMax; x += step)
            {

                double result = chart.Func(x);
                if (result <= yMax && result >= yMin)
                {
                    chart1.Series["Chart"].Points.AddXY(x , result);
                }
            }
            for (double x = Math.Min(xMin, 0); x <= xMax; x += 0.01)
            {
                chart1.Series["Axis"].Points.AddXY(x, 0);
            }
            for(double y = Math.Min(yMin, 0); y <= yMax; y += 0.01)
            {
                chart1.Series["Axis"].Points.AddXY(0, y);
            }
            GC.Collect();
        }

        /// <summary>
        /// Сохранить в БД
        /// </summary>
        private void save_Click(object sender, EventArgs e)
        {

            SQLiteConnection connection = new SQLiteConnection("Integrated Security = SSPI; DataSource = func.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM func";
            command.ExecuteNonQuery();
            for (int i = 0; i < chartList.Count; i++)
            {
                command.CommandText = $"INSERT INTO func (Name, A, B, Type) VALUES ('{chartList[i].Name}',{chartList[i].A.ToString().Replace(",",".")},{chartList[i].B.ToString().Replace(",",".")}, '{chartList[i].Type}' )";
                command.ExecuteNonQuery();
            }

        }
        /// <summary>
        /// Удалить элемент
        /// </summary>
        private void remove_Click(object sender, EventArgs e)
        {
                chartList.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                dataGridView1.DataSource = chartList.Charts;
        }
        /// <summary>
        /// Добавить элемент
        /// </summary>
        private void add_Click(object sender, EventArgs e)
        {
            chartList.Add(new MyChart("",0,0,ChartType.Direct));
            dataGridView1.DataSource = chartList.Charts;
        }

    }
}

