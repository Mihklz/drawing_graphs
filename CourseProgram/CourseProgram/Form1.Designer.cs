namespace CourseProgram
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.xMinS = new System.Windows.Forms.TextBox();
            this.xMaxS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yMinS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yMaxS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stepS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(722, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(722, 463);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(547, 23);
            this.add.TabIndex = 21;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(722, 492);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(547, 23);
            this.delete.TabIndex = 23;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.remove_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 11);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Legend = "Legend1";
            series1.Name = "Chart";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Black;
            series2.Name = "Axis";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(703, 562);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.save.Location = new System.Drawing.Point(722, 521);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(547, 52);
            this.save.TabIndex = 30;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Xmin";
            // 
            // xMinS
            // 
            this.xMinS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xMinS.Location = new System.Drawing.Point(725, 26);
            this.xMinS.Name = "xMinS";
            this.xMinS.Size = new System.Drawing.Size(100, 20);
            this.xMinS.TabIndex = 34;
            // 
            // xMaxS
            // 
            this.xMaxS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xMaxS.Location = new System.Drawing.Point(831, 26);
            this.xMaxS.Name = "xMaxS";
            this.xMaxS.Size = new System.Drawing.Size(100, 20);
            this.xMaxS.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(828, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Xmax";
            // 
            // yMinS
            // 
            this.yMinS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.yMinS.Location = new System.Drawing.Point(1060, 26);
            this.yMinS.Name = "yMinS";
            this.yMinS.Size = new System.Drawing.Size(100, 20);
            this.yMinS.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1057, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ymin";
            // 
            // yMaxS
            // 
            this.yMaxS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.yMaxS.Location = new System.Drawing.Point(1169, 26);
            this.yMaxS.Name = "yMaxS";
            this.yMaxS.Size = new System.Drawing.Size(100, 20);
            this.yMaxS.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1166, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ymax";
            // 
            // stepS
            // 
            this.stepS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.stepS.Location = new System.Drawing.Point(937, 26);
            this.stepS.Name = "stepS";
            this.stepS.Size = new System.Drawing.Size(117, 20);
            this.stepS.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(934, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Step";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 585);
            this.Controls.Add(this.stepS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yMaxS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yMinS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xMaxS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xMinS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xMinS;
        private System.Windows.Forms.TextBox xMaxS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yMinS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yMaxS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stepS;
        private System.Windows.Forms.Label label6;
    }
}

