
namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LabelSpeed = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LabelResStep = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelResY = new System.Windows.Forms.Label();
            this.LabelResX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.NeskLiniy = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Ploshad = new System.Windows.Forms.NumericUpDown();
            this.Massa = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Shag = new System.Windows.Forms.TrackBar();
            this.Skorost = new System.Windows.Forms.NumericUpDown();
            this.Ygol = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Visota = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ploshad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Massa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skorost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ygol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Visota)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.LabelSpeed);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.LabelResStep);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.LabelResY);
            this.panel1.Controls.Add(this.LabelResX);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.NeskLiniy);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Ploshad);
            this.panel1.Controls.Add(this.Massa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Shag);
            this.panel1.Controls.Add(this.Skorost);
            this.panel1.Controls.Add(this.Ygol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Visota);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 597);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.AxisX.Maximum = 25D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Maximum = 10D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(349, 11);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series6.BorderWidth = 4;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Blue;
            series6.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series6.Legend = "Legend1";
            series6.Name = "Линия 1";
            series7.BorderWidth = 4;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series7.Legend = "Legend1";
            series7.Name = "Линия 2";
            series8.BorderWidth = 4;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series8.Legend = "Legend1";
            series8.Name = "Линия 3";
            series9.BorderWidth = 4;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series9.Legend = "Legend1";
            series9.Name = "Линия 4";
            series10.BorderWidth = 4;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series10.Legend = "Legend1";
            series10.Name = "Линия 5";
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(659, 350);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.AutoSize = true;
            this.LabelSpeed.Location = new System.Drawing.Point(208, 174);
            this.LabelSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(0, 13);
            this.LabelSpeed.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 174);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Скорость в конечной точке:";
            // 
            // LabelResStep
            // 
            this.LabelResStep.AutoSize = true;
            this.LabelResStep.Location = new System.Drawing.Point(208, 141);
            this.LabelResStep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelResStep.Name = "LabelResStep";
            this.LabelResStep.Size = new System.Drawing.Size(0, 13);
            this.LabelResStep.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 141);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Шаг:";
            // 
            // LabelResY
            // 
            this.LabelResY.AutoSize = true;
            this.LabelResY.Location = new System.Drawing.Point(208, 102);
            this.LabelResY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelResY.Name = "LabelResY";
            this.LabelResY.Size = new System.Drawing.Size(0, 13);
            this.LabelResY.TabIndex = 13;
            // 
            // LabelResX
            // 
            this.LabelResX.AutoSize = true;
            this.LabelResX.Location = new System.Drawing.Point(208, 66);
            this.LabelResX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelResX.Name = "LabelResX";
            this.LabelResX.Size = new System.Drawing.Size(0, 13);
            this.LabelResX.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Данные";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Максимальная высота:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "X:";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(349, 395);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(415, 163);
            this.Start.TabIndex = 1;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // NeskLiniy
            // 
            this.NeskLiniy.AutoSize = true;
            this.NeskLiniy.Location = new System.Drawing.Point(37, 415);
            this.NeskLiniy.Margin = new System.Windows.Forms.Padding(2);
            this.NeskLiniy.Name = "NeskLiniy";
            this.NeskLiniy.Size = new System.Drawing.Size(117, 17);
            this.NeskLiniy.TabIndex = 1;
            this.NeskLiniy.Text = "Несколько Линий";
            this.NeskLiniy.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Шаг";
            // 
            // Ploshad
            // 
            this.Ploshad.Location = new System.Drawing.Point(883, 545);
            this.Ploshad.Margin = new System.Windows.Forms.Padding(2);
            this.Ploshad.Name = "Ploshad";
            this.Ploshad.Size = new System.Drawing.Size(90, 20);
            this.Ploshad.TabIndex = 4;
            this.Ploshad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Massa
            // 
            this.Massa.Location = new System.Drawing.Point(883, 507);
            this.Massa.Margin = new System.Windows.Forms.Padding(2);
            this.Massa.Name = "Massa";
            this.Massa.Size = new System.Drawing.Size(90, 20);
            this.Massa.TabIndex = 6;
            this.Massa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(828, 507);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Масса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(828, 545);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Площадь";
            // 
            // Shag
            // 
            this.Shag.LargeChange = 1;
            this.Shag.Location = new System.Drawing.Point(85, 211);
            this.Shag.Margin = new System.Windows.Forms.Padding(2);
            this.Shag.Minimum = 1;
            this.Shag.Name = "Shag";
            this.Shag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Shag.Size = new System.Drawing.Size(168, 45);
            this.Shag.SmallChange = 10;
            this.Shag.TabIndex = 1;
            this.Shag.Value = 1;
            // 
            // Skorost
            // 
            this.Skorost.Location = new System.Drawing.Point(883, 464);
            this.Skorost.Margin = new System.Windows.Forms.Padding(2);
            this.Skorost.Name = "Skorost";
            this.Skorost.Size = new System.Drawing.Size(90, 20);
            this.Skorost.TabIndex = 2;
            this.Skorost.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Ygol
            // 
            this.Ygol.Location = new System.Drawing.Point(883, 427);
            this.Ygol.Margin = new System.Windows.Forms.Padding(2);
            this.Ygol.Name = "Ygol";
            this.Ygol.Size = new System.Drawing.Size(90, 20);
            this.Ygol.TabIndex = 3;
            this.Ygol.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(828, 427);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Угол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(828, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Скорость";
            // 
            // Visota
            // 
            this.Visota.Location = new System.Drawing.Point(883, 390);
            this.Visota.Margin = new System.Windows.Forms.Padding(2);
            this.Visota.Name = "Visota";
            this.Visota.Size = new System.Drawing.Size(90, 20);
            this.Visota.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Высота";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 597);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ploshad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Massa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skorost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ygol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Visota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar Shag;
        private System.Windows.Forms.NumericUpDown Skorost;
        private System.Windows.Forms.NumericUpDown Ygol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Visota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Ploshad;
        private System.Windows.Forms.NumericUpDown Massa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.CheckBox NeskLiniy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label LabelResY;
        private System.Windows.Forms.Label LabelResX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelResStep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LabelSpeed;
    }
}

