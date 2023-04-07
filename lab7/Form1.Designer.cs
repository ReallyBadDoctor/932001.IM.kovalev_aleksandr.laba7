namespace lab7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btstart = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.persqua = new System.Windows.Forms.NumericUpDown();
            this.crimeLevel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Sbudget = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Srate = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cli_come = new System.Windows.Forms.NumericUpDown();
            this.budget_out = new System.Windows.Forms.NumericUpDown();
            this.room_cost_out = new System.Windows.Forms.NumericUpDown();
            this.rate_out = new System.Windows.Forms.NumericUpDown();
            this.cli_inside = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.Day_out = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cli_out = new System.Windows.Forms.NumericUpDown();
            this.budg_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.persqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimeLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sbudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Srate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_come)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_cost_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_inside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budg_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btstart
            // 
            this.btstart.Location = new System.Drawing.Point(938, 252);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(141, 49);
            this.btstart.TabIndex = 0;
            this.btstart.Text = "Continue/Stop";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(938, 146);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(141, 49);
            this.btreset.TabIndex = 1;
            this.btreset.Text = "Reset/Start";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // persqua
            // 
            this.persqua.DecimalPlaces = 2;
            this.persqua.Location = new System.Drawing.Point(160, 57);
            this.persqua.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.persqua.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.persqua.Name = "persqua";
            this.persqua.Size = new System.Drawing.Size(120, 22);
            this.persqua.TabIndex = 2;
            this.persqua.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // crimeLevel
            // 
            this.crimeLevel.DecimalPlaces = 2;
            this.crimeLevel.Location = new System.Drawing.Point(160, 12);
            this.crimeLevel.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.crimeLevel.Name = "crimeLevel";
            this.crimeLevel.Size = new System.Drawing.Size(120, 22);
            this.crimeLevel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Crime level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Personnel qualification";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Starting budget";
            // 
            // Sbudget
            // 
            this.Sbudget.DecimalPlaces = 2;
            this.Sbudget.Location = new System.Drawing.Point(160, 98);
            this.Sbudget.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Sbudget.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Sbudget.Name = "Sbudget";
            this.Sbudget.Size = new System.Drawing.Size(120, 22);
            this.Sbudget.TabIndex = 7;
            this.Sbudget.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Starting rate";
            // 
            // Srate
            // 
            this.Srate.DecimalPlaces = 2;
            this.Srate.Location = new System.Drawing.Point(160, 144);
            this.Srate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Srate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Srate.Name = "Srate";
            this.Srate.Size = new System.Drawing.Size(120, 22);
            this.Srate.TabIndex = 9;
            this.Srate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Clients inside";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Clients come";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Budget";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Room cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Rate";
            // 
            // cli_come
            // 
            this.cli_come.Enabled = false;
            this.cli_come.Location = new System.Drawing.Point(473, 43);
            this.cli_come.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cli_come.Name = "cli_come";
            this.cli_come.Size = new System.Drawing.Size(120, 22);
            this.cli_come.TabIndex = 18;
            // 
            // budget_out
            // 
            this.budget_out.DecimalPlaces = 2;
            this.budget_out.Enabled = false;
            this.budget_out.Location = new System.Drawing.Point(474, 118);
            this.budget_out.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.budget_out.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.budget_out.Name = "budget_out";
            this.budget_out.Size = new System.Drawing.Size(120, 22);
            this.budget_out.TabIndex = 19;
            // 
            // room_cost_out
            // 
            this.room_cost_out.DecimalPlaces = 2;
            this.room_cost_out.Enabled = false;
            this.room_cost_out.Location = new System.Drawing.Point(474, 156);
            this.room_cost_out.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.room_cost_out.Name = "room_cost_out";
            this.room_cost_out.Size = new System.Drawing.Size(120, 22);
            this.room_cost_out.TabIndex = 20;
            // 
            // rate_out
            // 
            this.rate_out.DecimalPlaces = 2;
            this.rate_out.Enabled = false;
            this.rate_out.Location = new System.Drawing.Point(474, 189);
            this.rate_out.Name = "rate_out";
            this.rate_out.Size = new System.Drawing.Size(120, 22);
            this.rate_out.TabIndex = 21;
            // 
            // cli_inside
            // 
            this.cli_inside.Enabled = false;
            this.cli_inside.Location = new System.Drawing.Point(474, 12);
            this.cli_inside.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cli_inside.Name = "cli_inside";
            this.cli_inside.Size = new System.Drawing.Size(120, 22);
            this.cli_inside.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(918, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Day:";
            // 
            // Day_out
            // 
            this.Day_out.Enabled = false;
            this.Day_out.Location = new System.Drawing.Point(959, 39);
            this.Day_out.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Day_out.Name = "Day_out";
            this.Day_out.Size = new System.Drawing.Size(120, 22);
            this.Day_out.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Clients out";
            // 
            // cli_out
            // 
            this.cli_out.Enabled = false;
            this.cli_out.Location = new System.Drawing.Point(473, 78);
            this.cli_out.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cli_out.Name = "cli_out";
            this.cli_out.Size = new System.Drawing.Size(120, 22);
            this.cli_out.TabIndex = 26;
            // 
            // budg_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.budg_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.budg_chart.Legends.Add(legend1);
            this.budg_chart.Location = new System.Drawing.Point(42, 256);
            this.budg_chart.Name = "budg_chart";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Income";
            this.budg_chart.Series.Add(series1);
            this.budg_chart.Size = new System.Drawing.Size(861, 220);
            this.budg_chart.TabIndex = 27;
            this.budg_chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 556);
            this.Controls.Add(this.budg_chart);
            this.Controls.Add(this.cli_out);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Day_out);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cli_inside);
            this.Controls.Add(this.rate_out);
            this.Controls.Add(this.room_cost_out);
            this.Controls.Add(this.budget_out);
            this.Controls.Add(this.cli_come);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Srate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sbudget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crimeLevel);
            this.Controls.Add(this.persqua);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btstart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.persqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimeLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sbudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Srate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_come)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_cost_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_inside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budg_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.NumericUpDown persqua;
        private System.Windows.Forms.NumericUpDown crimeLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Sbudget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Srate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown cli_come;
        private System.Windows.Forms.NumericUpDown budget_out;
        private System.Windows.Forms.NumericUpDown room_cost_out;
        private System.Windows.Forms.NumericUpDown rate_out;
        private System.Windows.Forms.NumericUpDown cli_inside;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown Day_out;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown cli_out;
        private System.Windows.Forms.DataVisualization.Charting.Chart budg_chart;
    }
}

