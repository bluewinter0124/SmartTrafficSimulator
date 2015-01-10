﻿namespace SmartCitySimulator
{
    partial class VehicleConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleConfig));
            this.comboBox_generateRoads = new System.Windows.Forms.ComboBox();
            this.groupBox_generateRoads = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_addGenerateRoad = new System.Windows.Forms.Button();
            this.comboBox_otherRoads = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_removeGenerateRoad = new System.Windows.Forms.Button();
            this.comboBox_generateLevel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_vehicleConfig = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_VehicleSpeed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button_applyVehicleConfig = new System.Windows.Forms.Button();
            this.numericUpDown_VehicleSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_vehicleGraphicDemo = new System.Windows.Forms.PictureBox();
            this.groupBox_generateSchedule = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_addSchedule = new System.Windows.Forms.Button();
            this.numericUpDown_hour = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_minute = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_level = new System.Windows.Forms.NumericUpDown();
            this.button_removeSchedule = new System.Windows.Forms.Button();
            this.listBox_generateSchedule = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_drivingPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_nextRoad = new System.Windows.Forms.ComboBox();
            this.numericUpDown_drivingPathWeight = new System.Windows.Forms.NumericUpDown();
            this.button_nextRoad = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_addDrivingPath = new System.Windows.Forms.Button();
            this.button_removePath = new System.Windows.Forms.Button();
            this.listBox_DrivingPath = new System.Windows.Forms.ListBox();
            this.groupBox_generateRoads.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_vehicleConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VehicleSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VehicleSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vehicleGraphicDemo)).BeginInit();
            this.groupBox_generateSchedule.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_level)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_drivingPathWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_generateRoads
            // 
            this.comboBox_generateRoads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_generateRoads.FormattingEnabled = true;
            this.comboBox_generateRoads.Location = new System.Drawing.Point(76, 30);
            this.comboBox_generateRoads.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_generateRoads.Name = "comboBox_generateRoads";
            this.comboBox_generateRoads.Size = new System.Drawing.Size(125, 25);
            this.comboBox_generateRoads.TabIndex = 0;
            this.comboBox_generateRoads.SelectedIndexChanged += new System.EventHandler(this.comboBox_generateRoad_SelectedIndexChanged);
            // 
            // groupBox_generateRoads
            // 
            this.groupBox_generateRoads.Controls.Add(this.groupBox2);
            this.groupBox_generateRoads.Controls.Add(this.button_removeGenerateRoad);
            this.groupBox_generateRoads.Controls.Add(this.comboBox_generateLevel);
            this.groupBox_generateRoads.Controls.Add(this.label2);
            this.groupBox_generateRoads.Controls.Add(this.label1);
            this.groupBox_generateRoads.Controls.Add(this.comboBox_generateRoads);
            this.groupBox_generateRoads.Location = new System.Drawing.Point(13, 13);
            this.groupBox_generateRoads.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_generateRoads.Name = "groupBox_generateRoads";
            this.groupBox_generateRoads.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_generateRoads.Size = new System.Drawing.Size(369, 224);
            this.groupBox_generateRoads.TabIndex = 1;
            this.groupBox_generateRoads.TabStop = false;
            this.groupBox_generateRoads.Text = "Generator Road";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_addGenerateRoad);
            this.groupBox2.Controls.Add(this.comboBox_otherRoads);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(8, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 86);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New";
            // 
            // button_addGenerateRoad
            // 
            this.button_addGenerateRoad.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_addGenerateRoad.Location = new System.Drawing.Point(252, 25);
            this.button_addGenerateRoad.Margin = new System.Windows.Forms.Padding(4);
            this.button_addGenerateRoad.Name = "button_addGenerateRoad";
            this.button_addGenerateRoad.Size = new System.Drawing.Size(90, 35);
            this.button_addGenerateRoad.TabIndex = 7;
            this.button_addGenerateRoad.Text = "Add";
            this.button_addGenerateRoad.UseVisualStyleBackColor = true;
            this.button_addGenerateRoad.Click += new System.EventHandler(this.button_addGenerateRoad_Click);
            // 
            // comboBox_otherRoads
            // 
            this.comboBox_otherRoads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_otherRoads.FormattingEnabled = true;
            this.comboBox_otherRoads.Location = new System.Drawing.Point(68, 31);
            this.comboBox_otherRoads.Name = "comboBox_otherRoads";
            this.comboBox_otherRoads.Size = new System.Drawing.Size(125, 25);
            this.comboBox_otherRoads.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "RoadID";
            // 
            // button_removeGenerateRoad
            // 
            this.button_removeGenerateRoad.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_removeGenerateRoad.Location = new System.Drawing.Point(260, 24);
            this.button_removeGenerateRoad.Margin = new System.Windows.Forms.Padding(4);
            this.button_removeGenerateRoad.Name = "button_removeGenerateRoad";
            this.button_removeGenerateRoad.Size = new System.Drawing.Size(90, 35);
            this.button_removeGenerateRoad.TabIndex = 4;
            this.button_removeGenerateRoad.Text = "Remove";
            this.button_removeGenerateRoad.UseVisualStyleBackColor = true;
            this.button_removeGenerateRoad.Click += new System.EventHandler(this.button_removeGenerateRoad_Click);
            // 
            // comboBox_generateLevel
            // 
            this.comboBox_generateLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_generateLevel.FormattingEnabled = true;
            this.comboBox_generateLevel.Items.AddRange(new object[] {
            "0 (not generate)",
            "1 (Very Few)",
            "2 (Few)",
            "3 (Normal)",
            "4 (Much)",
            "5 (Very Much)"});
            this.comboBox_generateLevel.Location = new System.Drawing.Point(76, 78);
            this.comboBox_generateLevel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_generateLevel.Name = "comboBox_generateLevel";
            this.comboBox_generateLevel.Size = new System.Drawing.Size(125, 25);
            this.comboBox_generateLevel.TabIndex = 3;
            this.comboBox_generateLevel.SelectedIndexChanged += new System.EventHandler(this.comboBox_rate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "RoadID : ";
            // 
            // groupBox_vehicleConfig
            // 
            this.groupBox_vehicleConfig.Controls.Add(this.label6);
            this.groupBox_vehicleConfig.Controls.Add(this.numericUpDown_VehicleSpeed);
            this.groupBox_vehicleConfig.Controls.Add(this.label5);
            this.groupBox_vehicleConfig.Controls.Add(this.button_applyVehicleConfig);
            this.groupBox_vehicleConfig.Controls.Add(this.numericUpDown_VehicleSize);
            this.groupBox_vehicleConfig.Controls.Add(this.label4);
            this.groupBox_vehicleConfig.Controls.Add(this.pictureBox_vehicleGraphicDemo);
            this.groupBox_vehicleConfig.Location = new System.Drawing.Point(13, 245);
            this.groupBox_vehicleConfig.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_vehicleConfig.Name = "groupBox_vehicleConfig";
            this.groupBox_vehicleConfig.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_vehicleConfig.Size = new System.Drawing.Size(369, 202);
            this.groupBox_vehicleConfig.TabIndex = 2;
            this.groupBox_vehicleConfig.TabStop = false;
            this.groupBox_vehicleConfig.Text = "Vehicle Custom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "- Preview -";
            // 
            // numericUpDown_VehicleSpeed
            // 
            this.numericUpDown_VehicleSpeed.Location = new System.Drawing.Point(305, 70);
            this.numericUpDown_VehicleSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_VehicleSpeed.Name = "numericUpDown_VehicleSpeed";
            this.numericUpDown_VehicleSpeed.Size = new System.Drawing.Size(45, 25);
            this.numericUpDown_VehicleSpeed.TabIndex = 10;
            this.numericUpDown_VehicleSpeed.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Speed (km/H) : ";
            // 
            // button_applyVehicleConfig
            // 
            this.button_applyVehicleConfig.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_applyVehicleConfig.Location = new System.Drawing.Point(260, 156);
            this.button_applyVehicleConfig.Margin = new System.Windows.Forms.Padding(4);
            this.button_applyVehicleConfig.Name = "button_applyVehicleConfig";
            this.button_applyVehicleConfig.Size = new System.Drawing.Size(90, 35);
            this.button_applyVehicleConfig.TabIndex = 8;
            this.button_applyVehicleConfig.Text = "Apply";
            this.button_applyVehicleConfig.UseVisualStyleBackColor = true;
            this.button_applyVehicleConfig.Click += new System.EventHandler(this.button_applyConfig_Click);
            // 
            // numericUpDown_VehicleSize
            // 
            this.numericUpDown_VehicleSize.Location = new System.Drawing.Point(305, 25);
            this.numericUpDown_VehicleSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_VehicleSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_VehicleSize.Name = "numericUpDown_VehicleSize";
            this.numericUpDown_VehicleSize.Size = new System.Drawing.Size(45, 25);
            this.numericUpDown_VehicleSize.TabIndex = 3;
            this.numericUpDown_VehicleSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_VehicleSize.ValueChanged += new System.EventHandler(this.numericUpDown_VehicleLength_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Size : ";
            // 
            // pictureBox_vehicleGraphicDemo
            // 
            this.pictureBox_vehicleGraphicDemo.Image = global::SmartCitySimulator.Properties.Resources.vehicle0;
            this.pictureBox_vehicleGraphicDemo.Location = new System.Drawing.Point(14, 25);
            this.pictureBox_vehicleGraphicDemo.Name = "pictureBox_vehicleGraphicDemo";
            this.pictureBox_vehicleGraphicDemo.Size = new System.Drawing.Size(24, 12);
            this.pictureBox_vehicleGraphicDemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_vehicleGraphicDemo.TabIndex = 0;
            this.pictureBox_vehicleGraphicDemo.TabStop = false;
            // 
            // groupBox_generateSchedule
            // 
            this.groupBox_generateSchedule.Controls.Add(this.groupBox4);
            this.groupBox_generateSchedule.Controls.Add(this.button_removeSchedule);
            this.groupBox_generateSchedule.Controls.Add(this.listBox_generateSchedule);
            this.groupBox_generateSchedule.Location = new System.Drawing.Point(389, 14);
            this.groupBox_generateSchedule.Name = "groupBox_generateSchedule";
            this.groupBox_generateSchedule.Size = new System.Drawing.Size(242, 433);
            this.groupBox_generateSchedule.TabIndex = 3;
            this.groupBox_generateSchedule.TabStop = false;
            this.groupBox_generateSchedule.Text = "Schedule";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.button_addSchedule);
            this.groupBox4.Controls.Add(this.numericUpDown_hour);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.numericUpDown_minute);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numericUpDown_level);
            this.groupBox4.Location = new System.Drawing.Point(6, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 161);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "New Schedule";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hour : ";
            // 
            // button_addSchedule
            // 
            this.button_addSchedule.Location = new System.Drawing.Point(70, 114);
            this.button_addSchedule.Name = "button_addSchedule";
            this.button_addSchedule.Size = new System.Drawing.Size(90, 35);
            this.button_addSchedule.TabIndex = 8;
            this.button_addSchedule.Text = "Add";
            this.button_addSchedule.UseVisualStyleBackColor = true;
            this.button_addSchedule.Click += new System.EventHandler(this.button_addSchedule_Click);
            // 
            // numericUpDown_hour
            // 
            this.numericUpDown_hour.Location = new System.Drawing.Point(60, 34);
            this.numericUpDown_hour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_hour.Name = "numericUpDown_hour";
            this.numericUpDown_hour.Size = new System.Drawing.Size(43, 25);
            this.numericUpDown_hour.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Level : ";
            // 
            // numericUpDown_minute
            // 
            this.numericUpDown_minute.Location = new System.Drawing.Point(176, 34);
            this.numericUpDown_minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_minute.Name = "numericUpDown_minute";
            this.numericUpDown_minute.Size = new System.Drawing.Size(43, 25);
            this.numericUpDown_minute.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Minute : ";
            // 
            // numericUpDown_level
            // 
            this.numericUpDown_level.Location = new System.Drawing.Point(60, 65);
            this.numericUpDown_level.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_level.Name = "numericUpDown_level";
            this.numericUpDown_level.Size = new System.Drawing.Size(43, 25);
            this.numericUpDown_level.TabIndex = 4;
            // 
            // button_removeSchedule
            // 
            this.button_removeSchedule.Location = new System.Drawing.Point(76, 231);
            this.button_removeSchedule.Name = "button_removeSchedule";
            this.button_removeSchedule.Size = new System.Drawing.Size(90, 35);
            this.button_removeSchedule.TabIndex = 1;
            this.button_removeSchedule.Text = "Remove";
            this.button_removeSchedule.UseVisualStyleBackColor = true;
            this.button_removeSchedule.Click += new System.EventHandler(this.button_removeSchedule_Click);
            // 
            // listBox_generateSchedule
            // 
            this.listBox_generateSchedule.FormattingEnabled = true;
            this.listBox_generateSchedule.ItemHeight = 17;
            this.listBox_generateSchedule.Items.AddRange(new object[] {
            "no-schedule"});
            this.listBox_generateSchedule.Location = new System.Drawing.Point(6, 19);
            this.listBox_generateSchedule.Name = "listBox_generateSchedule";
            this.listBox_generateSchedule.Size = new System.Drawing.Size(230, 208);
            this.listBox_generateSchedule.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button_removePath);
            this.groupBox1.Controls.Add(this.listBox_DrivingPath);
            this.groupBox1.Location = new System.Drawing.Point(637, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 433);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drive Path";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_drivingPath);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comboBox_nextRoad);
            this.groupBox3.Controls.Add(this.numericUpDown_drivingPathWeight);
            this.groupBox3.Controls.Add(this.button_nextRoad);
            this.groupBox3.Controls.Add(this.button_clear);
            this.groupBox3.Controls.Add(this.button_addDrivingPath);
            this.groupBox3.Location = new System.Drawing.Point(6, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 155);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Path";
            // 
            // textBox_drivingPath
            // 
            this.textBox_drivingPath.BackColor = System.Drawing.Color.White;
            this.textBox_drivingPath.Location = new System.Drawing.Point(6, 29);
            this.textBox_drivingPath.Name = "textBox_drivingPath";
            this.textBox_drivingPath.ReadOnly = true;
            this.textBox_drivingPath.Size = new System.Drawing.Size(312, 25);
            this.textBox_drivingPath.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Weight : ";
            // 
            // comboBox_nextRoad
            // 
            this.comboBox_nextRoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nextRoad.FormattingEnabled = true;
            this.comboBox_nextRoad.Location = new System.Drawing.Point(7, 72);
            this.comboBox_nextRoad.Name = "comboBox_nextRoad";
            this.comboBox_nextRoad.Size = new System.Drawing.Size(108, 25);
            this.comboBox_nextRoad.TabIndex = 11;
            // 
            // numericUpDown_drivingPathWeight
            // 
            this.numericUpDown_drivingPathWeight.Location = new System.Drawing.Point(80, 121);
            this.numericUpDown_drivingPathWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_drivingPathWeight.Name = "numericUpDown_drivingPathWeight";
            this.numericUpDown_drivingPathWeight.Size = new System.Drawing.Size(41, 25);
            this.numericUpDown_drivingPathWeight.TabIndex = 14;
            this.numericUpDown_drivingPathWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_nextRoad
            // 
            this.button_nextRoad.Location = new System.Drawing.Point(127, 67);
            this.button_nextRoad.Name = "button_nextRoad";
            this.button_nextRoad.Size = new System.Drawing.Size(89, 35);
            this.button_nextRoad.TabIndex = 12;
            this.button_nextRoad.Text = "Next Road";
            this.button_nextRoad.UseVisualStyleBackColor = true;
            this.button_nextRoad.Click += new System.EventHandler(this.button_nextRoad_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(228, 66);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(89, 35);
            this.button_clear.TabIndex = 13;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_addDrivingPath
            // 
            this.button_addDrivingPath.Enabled = false;
            this.button_addDrivingPath.Location = new System.Drawing.Point(229, 114);
            this.button_addDrivingPath.Name = "button_addDrivingPath";
            this.button_addDrivingPath.Size = new System.Drawing.Size(89, 35);
            this.button_addDrivingPath.TabIndex = 9;
            this.button_addDrivingPath.Text = "Add";
            this.button_addDrivingPath.UseVisualStyleBackColor = true;
            this.button_addDrivingPath.Click += new System.EventHandler(this.button_addDrivingPath_Click);
            // 
            // button_removePath
            // 
            this.button_removePath.Location = new System.Drawing.Point(124, 233);
            this.button_removePath.Name = "button_removePath";
            this.button_removePath.Size = new System.Drawing.Size(89, 35);
            this.button_removePath.TabIndex = 9;
            this.button_removePath.Text = "Remove";
            this.button_removePath.UseVisualStyleBackColor = true;
            this.button_removePath.Click += new System.EventHandler(this.button_removePath_Click);
            // 
            // listBox_DrivingPath
            // 
            this.listBox_DrivingPath.FormattingEnabled = true;
            this.listBox_DrivingPath.ItemHeight = 17;
            this.listBox_DrivingPath.Items.AddRange(new object[] {
            "no-DrivingPath"});
            this.listBox_DrivingPath.Location = new System.Drawing.Point(6, 19);
            this.listBox_DrivingPath.Name = "listBox_DrivingPath";
            this.listBox_DrivingPath.Size = new System.Drawing.Size(324, 208);
            this.listBox_DrivingPath.TabIndex = 0;
            // 
            // VehicleConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_generateSchedule);
            this.Controls.Add(this.groupBox_vehicleConfig);
            this.Controls.Add(this.groupBox_generateRoads);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VehicleConfig";
            this.Text = "VehicleGenerateConfig";
            this.groupBox_generateRoads.ResumeLayout(false);
            this.groupBox_generateRoads.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_vehicleConfig.ResumeLayout(false);
            this.groupBox_vehicleConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VehicleSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VehicleSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vehicleGraphicDemo)).EndInit();
            this.groupBox_generateSchedule.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_level)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_drivingPathWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_generateRoads;
        private System.Windows.Forms.GroupBox groupBox_generateRoads;
        private System.Windows.Forms.ComboBox comboBox_generateLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_vehicleConfig;
        private System.Windows.Forms.Button button_removeGenerateRoad;
        private System.Windows.Forms.Button button_addGenerateRoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_otherRoads;
        private System.Windows.Forms.NumericUpDown numericUpDown_VehicleSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_vehicleGraphicDemo;
        private System.Windows.Forms.Button button_applyVehicleConfig;
        private System.Windows.Forms.NumericUpDown numericUpDown_VehicleSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_generateSchedule;
        private System.Windows.Forms.ListBox listBox_generateSchedule;
        private System.Windows.Forms.Button button_removeSchedule;
        private System.Windows.Forms.Button button_addSchedule;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_level;
        private System.Windows.Forms.NumericUpDown numericUpDown_minute;
        private System.Windows.Forms.NumericUpDown numericUpDown_hour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_DrivingPath;
        private System.Windows.Forms.ComboBox comboBox_nextRoad;
        private System.Windows.Forms.TextBox textBox_drivingPath;
        private System.Windows.Forms.Button button_removePath;
        private System.Windows.Forms.Button button_addDrivingPath;
        private System.Windows.Forms.Button button_nextRoad;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown_drivingPathWeight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}