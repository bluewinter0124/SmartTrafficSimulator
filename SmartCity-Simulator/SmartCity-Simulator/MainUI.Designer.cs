﻿using System;
using System.Net;
using System.Windows.Forms;
using SmartCitySimulator.GraphicUnit;
using SmartCitySimulator.SystemUnit;
namespace SmartCitySimulator
{
    partial class MainUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void SimulatorInfoInitialize()
        {
            String strHostName = Dns.GetHostName();
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
            IPAddress localIP = iphostentry.AddressList[0];

            label_localIP.Text = ("IP : " + localIP.ToString());
            Console.WriteLine(localIP);
        }

        //改變狀態顯示
       public void ChangeMapFileStatus(Boolean status)
        {
            if (status)
                this.pictureBox_mapFileStatus.Image = global::SmartCitySimulator.Properties.Resources.linked;
            else
                this.pictureBox_mapFileStatus.Image = global::SmartCitySimulator.Properties.Resources.NOlink;
        }

        public void ChangeSimulationFileStatus(Boolean status)
        {
            if (status)
                this.pictureBox_simulationFileStatus.Image = global::SmartCitySimulator.Properties.Resources.linked;
            else
                this.pictureBox_simulationFileStatus.Image = global::SmartCitySimulator.Properties.Resources.NOlink;
        }

        public void ChangePrototypeStatus(Boolean status)
        {
            if (status)
                this.pictureBox_cameraLinkStatus.Image = global::SmartCitySimulator.Properties.Resources.linked;
            else
                this.pictureBox_cameraLinkStatus.Image = global::SmartCitySimulator.Properties.Resources.NOlink;
        }

        public void ChangeAIStatus(Boolean status)
        {
            if (status)
                this.pictureBox_AILinkStatus.Image = global::SmartCitySimulator.Properties.Resources.linked;
            else
                this.pictureBox_AILinkStatus.Image = global::SmartCitySimulator.Properties.Resources.NOlink;
        }
        //改變狀態顯示

        public void RoadInfomationInitialize()
        {
            int roads = Simulator.RoadManager.roadList.Count;
            for (int i = 0; i < roads; i++)
            {
                this.dataGridView_RoadState.Rows.Add();
                this.dataGridView_RoadState.Rows[i].Cells[0].Value = Simulator.RoadManager.roadList[i].roadName;
                this.dataGridView_RoadState.Rows[i].Cells[1].Value = Simulator.RoadManager.roadList[i].currentCars;
                this.dataGridView_RoadState.Rows[i].Cells[2].Value = global::SmartCitySimulator.Properties.Resources.Light_State_Red;
            }
        }

        private delegate void RefreshRoadInfomationCallBack(int mode);

        public void RefreshRoadInfomation(int mode)// 0 = noweight , 1 weight
        {
            if (this.InvokeRequired)
            {
                RefreshRoadInfomationCallBack myUpdate = new RefreshRoadInfomationCallBack(RefreshRoadInfomation);
                this.Invoke(myUpdate,mode);
            }
            else
            {
                int roads = Simulator.RoadManager.roadList.Count;

                for (int i = 0; i < roads; i++)
                {
                    int cars = 0;

                    if (mode == 0)
                        cars = Simulator.RoadManager.roadList[i].TotalCars_NoWeight();
                    else if (mode == 1)
                        cars = Simulator.RoadManager.roadList[i].TotalCars_Weight();

                    double roadDensity = ((double)cars * Simulator.carLength * 1.5) / (double)Simulator.RoadManager.roadList[i].RoadLength();
                    //AddMessage("System","Road" + SimulatorConfiguration.RoadManager.roadList[i].roadID + " : " + roadDensity);

                        this.dataGridView_RoadState.Rows[i].Cells[1].Value = cars;

                        if (roadDensity >= 0.6)
                            this.dataGridView_RoadState.Rows[i].Cells[2].Value = global::SmartCitySimulator.Properties.Resources.Light_State_Red;
                        else if (roadDensity >= 0.3)
                            this.dataGridView_RoadState.Rows[i].Cells[2].Value = global::SmartCitySimulator.Properties.Resources.Light_State_Yellow;
                        else
                        this.dataGridView_RoadState.Rows[i].Cells[2].Value = global::SmartCitySimulator.Properties.Resources.Light_State_Green;
                    
                    //AddMessage("System", SimulatorConfiguration.RoadManager.roadList[i].roadName + " : " + SimulatorConfiguration.RoadManager.roadList[i].currentCars);

                }
            }
        }

        private delegate void AddMessageCallBack(String messageType, string input);

        public void AddMessage(String messageType, string input)
        {
            if (this.InvokeRequired)
            {
                AddMessageCallBack myUpdate = new AddMessageCallBack(AddMessage);
                this.Invoke(myUpdate, messageType, input);
            }
            else
            {
                switch (messageType)
                {
                    case "Prototype":
                        this.textBox_prototype.AppendText(input + "\n");
                        break;
                    case "AI":
                        this.textBox_AI.AppendText(input + "\n");
                        break;
                    case "System":
                        this.textBox_system.AppendText(input + "\n");
                        break;
                }
                this.textBox_all.AppendText(messageType + " : " + input + "\n");
            }
        }

        private delegate void AddCarCallBack(Car car);

        public void AddCar(Car car)
        {
            if (this.InvokeRequired)
            {
                AddCarCallBack myAddCar = new AddCarCallBack(AddCar);
                this.Invoke(myAddCar, car);
            }
            else
            {             
                this.splitContainer1.Panel2.Controls.Add(car);
            }
        }

        private delegate void RemoveCarCallBack(Car car);

        public void RemoveCar(Car car)
        {
            if (this.InvokeRequired)
            {
                RemoveCarCallBack myRemoveCar = new RemoveCarCallBack(RemoveCar);
                this.Invoke(myRemoveCar, car);
            }
            else
            {
                this.splitContainer1.Panel2.Controls.Remove(car);
            }
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_system = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_AILinkStatus = new System.Windows.Forms.PictureBox();
            this.pictureBox_mapFileStatus = new System.Windows.Forms.PictureBox();
            this.pictureBox_cameraLinkStatus = new System.Windows.Forms.PictureBox();
            this.AiLinkStatus = new System.Windows.Forms.Label();
            this.label_localIP = new System.Windows.Forms.Label();
            this.pictureBox_simulationFileStatus = new System.Windows.Forms.PictureBox();
            this.cameraLinkStatus = new System.Windows.Forms.Label();
            this.MapFileStatus = new System.Windows.Forms.Label();
            this.simulationFileStatus = new System.Windows.Forms.Label();
            this.dataGridView_RoadState = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Road = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl_Message = new System.Windows.Forms.TabControl();
            this.tabPage_All = new System.Windows.Forms.TabPage();
            this.textBox_all = new System.Windows.Forms.TextBox();
            this.tabPage_System = new System.Windows.Forms.TabPage();
            this.textBox_system = new System.Windows.Forms.TextBox();
            this.tabPage_Prototype = new System.Windows.Forms.TabPage();
            this.textBox_prototype = new System.Windows.Forms.TextBox();
            this.tabPage_AI = new System.Windows.Forms.TabPage();
            this.textBox_AI = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地圖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟模擬檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.路口設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.燈號設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_simRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_simStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_TrafficLightConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_IntersectionConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_CarGenerateConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton_SpeedAdjust = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_TrafficDataDisplay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_SimulatorConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Zoom = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟地圖檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟模擬設定檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_Run = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Stop = new System.Windows.Forms.ToolStripButton();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.CarTimer = new System.Windows.Forms.Timer(this.components);
            this.UIInformationTimer = new System.Windows.Forms.Timer(this.components);
            this.CarGraphicTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_system.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AILinkStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mapFileStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cameraLinkStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_simulationFileStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RoadState)).BeginInit();
            this.tabControl_Message.SuspendLayout();
            this.tabPage_All.SuspendLayout();
            this.tabPage_System.SuspendLayout();
            this.tabPage_Prototype.SuspendLayout();
            this.tabPage_AI.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 56);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_system);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2MinSize = 800;
            this.splitContainer1.Size = new System.Drawing.Size(1635, 664);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.TabStop = false;
            // 
            // groupBox_system
            // 
            this.groupBox_system.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox_system.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_system.Controls.Add(this.dataGridView_RoadState);
            this.groupBox_system.Controls.Add(this.tabControl_Message);
            this.groupBox_system.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_system.Location = new System.Drawing.Point(0, 0);
            this.groupBox_system.Name = "groupBox_system";
            this.groupBox_system.Size = new System.Drawing.Size(303, 664);
            this.groupBox_system.TabIndex = 0;
            this.groupBox_system.TabStop = false;
            this.groupBox_system.Text = "系統資訊";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.00837F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.99163F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AILinkStatus, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_mapFileStatus, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_cameraLinkStatus, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.AiLinkStatus, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_localIP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_simulationFileStatus, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cameraLinkStatus, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MapFileStatus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.simulationFileStatus, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 138);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox_AILinkStatus
            // 
            this.pictureBox_AILinkStatus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_AILinkStatus.Image")));
            this.pictureBox_AILinkStatus.Location = new System.Drawing.Point(240, 111);
            this.pictureBox_AILinkStatus.Name = "pictureBox_AILinkStatus";
            this.pictureBox_AILinkStatus.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_AILinkStatus.TabIndex = 5;
            this.pictureBox_AILinkStatus.TabStop = false;
            // 
            // pictureBox_mapFileStatus
            // 
            this.pictureBox_mapFileStatus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_mapFileStatus.Image")));
            this.pictureBox_mapFileStatus.Location = new System.Drawing.Point(240, 30);
            this.pictureBox_mapFileStatus.Name = "pictureBox_mapFileStatus";
            this.pictureBox_mapFileStatus.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_mapFileStatus.TabIndex = 7;
            this.pictureBox_mapFileStatus.TabStop = false;
            // 
            // pictureBox_cameraLinkStatus
            // 
            this.pictureBox_cameraLinkStatus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_cameraLinkStatus.Image")));
            this.pictureBox_cameraLinkStatus.Location = new System.Drawing.Point(240, 84);
            this.pictureBox_cameraLinkStatus.Name = "pictureBox_cameraLinkStatus";
            this.pictureBox_cameraLinkStatus.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_cameraLinkStatus.TabIndex = 3;
            this.pictureBox_cameraLinkStatus.TabStop = false;
            // 
            // AiLinkStatus
            // 
            this.AiLinkStatus.AutoSize = true;
            this.AiLinkStatus.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.AiLinkStatus.Location = new System.Drawing.Point(3, 111);
            this.AiLinkStatus.Margin = new System.Windows.Forms.Padding(3);
            this.AiLinkStatus.Name = "AiLinkStatus";
            this.AiLinkStatus.Size = new System.Drawing.Size(50, 18);
            this.AiLinkStatus.TabIndex = 4;
            this.AiLinkStatus.Text = "AI啟動";
            // 
            // label_localIP
            // 
            this.label_localIP.AutoSize = true;
            this.label_localIP.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.label_localIP.Location = new System.Drawing.Point(3, 3);
            this.label_localIP.Margin = new System.Windows.Forms.Padding(3);
            this.label_localIP.Name = "label_localIP";
            this.label_localIP.Size = new System.Drawing.Size(63, 18);
            this.label_localIP.TabIndex = 0;
            this.label_localIP.Text = "本機 IP : ";
            // 
            // pictureBox_simulationFileStatus
            // 
            this.pictureBox_simulationFileStatus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_simulationFileStatus.Image")));
            this.pictureBox_simulationFileStatus.Location = new System.Drawing.Point(240, 57);
            this.pictureBox_simulationFileStatus.Name = "pictureBox_simulationFileStatus";
            this.pictureBox_simulationFileStatus.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_simulationFileStatus.TabIndex = 6;
            this.pictureBox_simulationFileStatus.TabStop = false;
            // 
            // cameraLinkStatus
            // 
            this.cameraLinkStatus.AutoSize = true;
            this.cameraLinkStatus.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cameraLinkStatus.Location = new System.Drawing.Point(3, 84);
            this.cameraLinkStatus.Margin = new System.Windows.Forms.Padding(3);
            this.cameraLinkStatus.Name = "cameraLinkStatus";
            this.cameraLinkStatus.Size = new System.Drawing.Size(101, 18);
            this.cameraLinkStatus.TabIndex = 2;
            this.cameraLinkStatus.Text = "Prototype連線";
            // 
            // MapFileStatus
            // 
            this.MapFileStatus.AutoSize = true;
            this.MapFileStatus.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.MapFileStatus.Location = new System.Drawing.Point(3, 30);
            this.MapFileStatus.Margin = new System.Windows.Forms.Padding(3);
            this.MapFileStatus.Name = "MapFileStatus";
            this.MapFileStatus.Size = new System.Drawing.Size(78, 18);
            this.MapFileStatus.TabIndex = 8;
            this.MapFileStatus.Text = "地圖檔讀取";
            // 
            // simulationFileStatus
            // 
            this.simulationFileStatus.AutoSize = true;
            this.simulationFileStatus.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.simulationFileStatus.Location = new System.Drawing.Point(3, 57);
            this.simulationFileStatus.Margin = new System.Windows.Forms.Padding(3);
            this.simulationFileStatus.Name = "simulationFileStatus";
            this.simulationFileStatus.Size = new System.Drawing.Size(78, 18);
            this.simulationFileStatus.TabIndex = 9;
            this.simulationFileStatus.Text = "模擬檔讀取";
            // 
            // dataGridView_RoadState
            // 
            this.dataGridView_RoadState.AllowUserToAddRows = false;
            this.dataGridView_RoadState.AllowUserToDeleteRows = false;
            this.dataGridView_RoadState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_RoadState.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_RoadState.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_RoadState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RoadState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Speed,
            this.Road});
            this.dataGridView_RoadState.Location = new System.Drawing.Point(6, 411);
            this.dataGridView_RoadState.Name = "dataGridView_RoadState";
            this.dataGridView_RoadState.ReadOnly = true;
            this.dataGridView_RoadState.RowTemplate.Height = 24;
            this.dataGridView_RoadState.Size = new System.Drawing.Size(303, 247);
            this.dataGridView_RoadState.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "SimulatorConfiguration.id";
            this.ID.FillWeight = 40F;
            this.ID.HeaderText = "Road";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 92;
            // 
            // Speed
            // 
            this.Speed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Speed.FillWeight = 30F;
            this.Speed.HeaderText = "Cars";
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            this.Speed.Width = 50;
            // 
            // Road
            // 
            this.Road.FillWeight = 30F;
            this.Road.HeaderText = "State";
            this.Road.Name = "Road";
            this.Road.ReadOnly = true;
            this.Road.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Road.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabControl_Message
            // 
            this.tabControl_Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Message.Controls.Add(this.tabPage_All);
            this.tabControl_Message.Controls.Add(this.tabPage_System);
            this.tabControl_Message.Controls.Add(this.tabPage_Prototype);
            this.tabControl_Message.Controls.Add(this.tabPage_AI);
            this.tabControl_Message.Location = new System.Drawing.Point(6, 162);
            this.tabControl_Message.Name = "tabControl_Message";
            this.tabControl_Message.SelectedIndex = 0;
            this.tabControl_Message.Size = new System.Drawing.Size(294, 243);
            this.tabControl_Message.TabIndex = 7;
            // 
            // tabPage_All
            // 
            this.tabPage_All.Controls.Add(this.textBox_all);
            this.tabPage_All.Location = new System.Drawing.Point(4, 22);
            this.tabPage_All.Name = "tabPage_All";
            this.tabPage_All.Size = new System.Drawing.Size(286, 217);
            this.tabPage_All.TabIndex = 0;
            this.tabPage_All.Text = "All";
            this.tabPage_All.UseVisualStyleBackColor = true;
            // 
            // textBox_all
            // 
            this.textBox_all.BackColor = System.Drawing.Color.White;
            this.textBox_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_all.Location = new System.Drawing.Point(0, 0);
            this.textBox_all.Multiline = true;
            this.textBox_all.Name = "textBox_all";
            this.textBox_all.ReadOnly = true;
            this.textBox_all.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_all.Size = new System.Drawing.Size(286, 217);
            this.textBox_all.TabIndex = 1;
            // 
            // tabPage_System
            // 
            this.tabPage_System.Controls.Add(this.textBox_system);
            this.tabPage_System.Location = new System.Drawing.Point(4, 22);
            this.tabPage_System.Name = "tabPage_System";
            this.tabPage_System.Size = new System.Drawing.Size(286, 217);
            this.tabPage_System.TabIndex = 3;
            this.tabPage_System.Text = "System";
            this.tabPage_System.UseVisualStyleBackColor = true;
            // 
            // textBox_system
            // 
            this.textBox_system.BackColor = System.Drawing.Color.White;
            this.textBox_system.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_system.Location = new System.Drawing.Point(0, 0);
            this.textBox_system.Multiline = true;
            this.textBox_system.Name = "textBox_system";
            this.textBox_system.ReadOnly = true;
            this.textBox_system.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_system.Size = new System.Drawing.Size(286, 217);
            this.textBox_system.TabIndex = 0;
            // 
            // tabPage_Prototype
            // 
            this.tabPage_Prototype.Controls.Add(this.textBox_prototype);
            this.tabPage_Prototype.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Prototype.Name = "tabPage_Prototype";
            this.tabPage_Prototype.Size = new System.Drawing.Size(286, 217);
            this.tabPage_Prototype.TabIndex = 1;
            this.tabPage_Prototype.Text = "Prototype";
            this.tabPage_Prototype.UseVisualStyleBackColor = true;
            // 
            // textBox_prototype
            // 
            this.textBox_prototype.BackColor = System.Drawing.Color.White;
            this.textBox_prototype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_prototype.Location = new System.Drawing.Point(0, 0);
            this.textBox_prototype.Multiline = true;
            this.textBox_prototype.Name = "textBox_prototype";
            this.textBox_prototype.ReadOnly = true;
            this.textBox_prototype.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_prototype.Size = new System.Drawing.Size(286, 217);
            this.textBox_prototype.TabIndex = 0;
            // 
            // tabPage_AI
            // 
            this.tabPage_AI.Controls.Add(this.textBox_AI);
            this.tabPage_AI.Controls.Add(this.textBox1);
            this.tabPage_AI.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AI.Name = "tabPage_AI";
            this.tabPage_AI.Size = new System.Drawing.Size(286, 217);
            this.tabPage_AI.TabIndex = 2;
            this.tabPage_AI.Text = "AI";
            this.tabPage_AI.UseVisualStyleBackColor = true;
            // 
            // textBox_AI
            // 
            this.textBox_AI.BackColor = System.Drawing.Color.White;
            this.textBox_AI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_AI.Location = new System.Drawing.Point(0, 0);
            this.textBox_AI.Multiline = true;
            this.textBox_AI.Name = "textBox_AI";
            this.textBox_AI.ReadOnly = true;
            this.textBox_AI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_AI.Size = new System.Drawing.Size(286, 217);
            this.textBox_AI.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 217);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // 開啟ToolStripMenuItem
            // 
            this.開啟ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.地圖ToolStripMenuItem,
            this.開啟模擬檔ToolStripMenuItem,
            this.toolStripSeparator1,
            this.離開ToolStripMenuItem,
            this.toolStripSeparator2,
            this.結束ToolStripMenuItem});
            this.開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem";
            this.開啟ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.開啟ToolStripMenuItem.Text = "檔案";
            // 
            // 地圖ToolStripMenuItem
            // 
            this.地圖ToolStripMenuItem.Name = "地圖ToolStripMenuItem";
            this.地圖ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.地圖ToolStripMenuItem.Text = "開啟地圖";
            // 
            // 開啟模擬檔ToolStripMenuItem
            // 
            this.開啟模擬檔ToolStripMenuItem.Name = "開啟模擬檔ToolStripMenuItem";
            this.開啟模擬檔ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.開啟模擬檔ToolStripMenuItem.Text = "開啟模擬檔";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.離開ToolStripMenuItem.Text = "儲存模擬檔";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.結束ToolStripMenuItem.Text = "結束";
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.路口設定ToolStripMenuItem,
            this.燈號設定ToolStripMenuItem});
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // 路口設定ToolStripMenuItem
            // 
            this.路口設定ToolStripMenuItem.Name = "路口設定ToolStripMenuItem";
            this.路口設定ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.路口設定ToolStripMenuItem.Text = "路口設定";
            // 
            // 燈號設定ToolStripMenuItem
            // 
            this.燈號設定ToolStripMenuItem.Name = "燈號設定ToolStripMenuItem";
            this.燈號設定ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.燈號設定ToolStripMenuItem.Text = "燈號設定";
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.關於ToolStripMenuItem.Text = "關於";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "State";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_simRun,
            this.toolStripButton_simStop,
            this.toolStripSeparator4,
            this.toolStripButton_TrafficLightConfig,
            this.toolStripButton_IntersectionConfig,
            this.toolStripButton_CarGenerateConfig,
            this.toolStripSplitButton_SpeedAdjust,
            this.toolStripSeparator5,
            this.toolStripButton_TrafficDataDisplay,
            this.toolStripButton_SimulatorConfig,
            this.toolStripSeparator6,
            this.toolStripButton_Zoom});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1635, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "工具列";
            // 
            // toolStripButton_simRun
            // 
            this.toolStripButton_simRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_simRun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_simRun.Image")));
            this.toolStripButton_simRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_simRun.Name = "toolStripButton_simRun";
            this.toolStripButton_simRun.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton_simRun.Text = "模擬器開始";
            this.toolStripButton_simRun.Click += new System.EventHandler(this.toolStripButton_simRun_Click);
            // 
            // toolStripButton_simStop
            // 
            this.toolStripButton_simStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_simStop.Image = global::SmartCitySimulator.Properties.Resources.stop1;
            this.toolStripButton_simStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_simStop.Name = "toolStripButton_simStop";
            this.toolStripButton_simStop.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton_simStop.Text = "模擬器暫停";
            this.toolStripButton_simStop.Click += new System.EventHandler(this.toolStripButton_simStop_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton_TrafficLightConfig
            // 
            this.toolStripButton_TrafficLightConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_TrafficLightConfig.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_TrafficLightConfig.Image")));
            this.toolStripButton_TrafficLightConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_TrafficLightConfig.Name = "toolStripButton_TrafficLightConfig";
            this.toolStripButton_TrafficLightConfig.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton_TrafficLightConfig.Text = "燈號設定";
            this.toolStripButton_TrafficLightConfig.Click += new System.EventHandler(this.toolStripButton_TrafficLightConfig_Click);
            // 
            // toolStripButton_IntersectionConfig
            // 
            this.toolStripButton_IntersectionConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_IntersectionConfig.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_IntersectionConfig.Image")));
            this.toolStripButton_IntersectionConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_IntersectionConfig.Name = "toolStripButton_IntersectionConfig";
            this.toolStripButton_IntersectionConfig.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton_IntersectionConfig.Text = "路口設定";
            this.toolStripButton_IntersectionConfig.Click += new System.EventHandler(this.toolStripButton_IntersectionConfig_Click);
            // 
            // toolStripButton_CarGenerateConfig
            // 
            this.toolStripButton_CarGenerateConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_CarGenerateConfig.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CarGenerateConfig.Image")));
            this.toolStripButton_CarGenerateConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CarGenerateConfig.Name = "toolStripButton_CarGenerateConfig";
            this.toolStripButton_CarGenerateConfig.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton_CarGenerateConfig.Text = "車輛產生設定";
            this.toolStripButton_CarGenerateConfig.Click += new System.EventHandler(this.toolStripButton_CarGenerateConfig_Click);
            // 
            // toolStripSplitButton_SpeedAdjust
            // 
            this.toolStripSplitButton_SpeedAdjust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton_SpeedAdjust.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.toolStripSplitButton_SpeedAdjust.Image = global::SmartCitySimulator.Properties.Resources.speed3;
            this.toolStripSplitButton_SpeedAdjust.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton_SpeedAdjust.Name = "toolStripSplitButton_SpeedAdjust";
            this.toolStripSplitButton_SpeedAdjust.Size = new System.Drawing.Size(41, 29);
            this.toolStripSplitButton_SpeedAdjust.Text = "速度調整";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem4.Text = "1";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.setSimulatorSpeed);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem5.Text = "2";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.setSimulatorSpeed);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.setSimulatorSpeed);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem7.Text = "10";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.setSimulatorSpeed);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem8.Text = "20";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.setSimulatorSpeed);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem9.Text = "50";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.setSimulatorSpeed);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton_TrafficDataDisplay
            // 
            this.toolStripButton_TrafficDataDisplay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_TrafficDataDisplay.Image = global::SmartCitySimulator.Properties.Resources.data;
            this.toolStripButton_TrafficDataDisplay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_TrafficDataDisplay.Name = "toolStripButton_TrafficDataDisplay";
            this.toolStripButton_TrafficDataDisplay.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton_TrafficDataDisplay.Text = "統計資料";
            this.toolStripButton_TrafficDataDisplay.Click += new System.EventHandler(this.toolStripButton_TrafficDataDisplay_Click);
            // 
            // toolStripButton_SimulatorConfig
            // 
            this.toolStripButton_SimulatorConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_SimulatorConfig.Image = global::SmartCitySimulator.Properties.Resources.Config;
            this.toolStripButton_SimulatorConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SimulatorConfig.Name = "toolStripButton_SimulatorConfig";
            this.toolStripButton_SimulatorConfig.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton_SimulatorConfig.Text = "模擬器設定";
            this.toolStripButton_SimulatorConfig.Click += new System.EventHandler(this.toolStripButton_SimulatorConfig_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton_Zoom
            // 
            this.toolStripButton_Zoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Zoom.Image = global::SmartCitySimulator.Properties.Resources.Full;
            this.toolStripButton_Zoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Zoom.Name = "toolStripButton_Zoom";
            this.toolStripButton_Zoom.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton_Zoom.Text = "全螢幕模式";
            this.toolStripButton_Zoom.Click += new System.EventHandler(this.toolStripButton_Zoom_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.關於ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1635, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟地圖檔ToolStripMenuItem,
            this.開啟模擬設定檔ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開啟地圖檔ToolStripMenuItem
            // 
            this.開啟地圖檔ToolStripMenuItem.Name = "開啟地圖檔ToolStripMenuItem";
            this.開啟地圖檔ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.開啟地圖檔ToolStripMenuItem.Text = "開啟地圖檔";
            this.開啟地圖檔ToolStripMenuItem.Click += new System.EventHandler(this.開啟地圖檔ToolStripMenuItem_Click);
            // 
            // 開啟模擬設定檔ToolStripMenuItem
            // 
            this.開啟模擬設定檔ToolStripMenuItem.Name = "開啟模擬設定檔ToolStripMenuItem";
            this.開啟模擬設定檔ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.開啟模擬設定檔ToolStripMenuItem.Text = "開啟模擬設定檔";
            this.開啟模擬設定檔ToolStripMenuItem.Click += new System.EventHandler(this.開啟模擬設定檔ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.工具ToolStripMenuItem.Text = "功能";
            // 
            // 關於ToolStripMenuItem1
            // 
            this.關於ToolStripMenuItem1.Name = "關於ToolStripMenuItem1";
            this.關於ToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.關於ToolStripMenuItem1.Text = "設置";
            // 
            // toolStripButton_Run
            // 
            this.toolStripButton_Run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Run.Name = "toolStripButton_Run";
            this.toolStripButton_Run.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton_Run.Text = "Run";
            // 
            // toolStripButton_Stop
            // 
            this.toolStripButton_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Stop.Name = "toolStripButton_Stop";
            this.toolStripButton_Stop.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton_Stop.Text = "Stop";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1635, 720);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainUI";
            this.Text = "SmartCitySimulator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_system.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AILinkStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mapFileStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cameraLinkStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_simulationFileStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RoadState)).EndInit();
            this.tabControl_Message.ResumeLayout(false);
            this.tabPage_All.ResumeLayout(false);
            this.tabPage_All.PerformLayout();
            this.tabPage_System.ResumeLayout(false);
            this.tabPage_System.PerformLayout();
            this.tabPage_Prototype.ResumeLayout(false);
            this.tabPage_Prototype.PerformLayout();
            this.tabPage_AI.ResumeLayout(false);
            this.tabPage_AI.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private SystemController systemController;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 開啟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地圖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox_system;
        private System.Windows.Forms.TextBox textBox_all;
        private ToolStripButton toolStripButton_Run;
        private ToolStripButton toolStripButton_Stop;
        private TabControl tabControl_Message;
        private TabPage tabPage_All;
        private TabPage tabPage_Prototype;
        private TabPage tabPage_AI;
        private TabPage tabPage_System;
        private TextBox textBox_prototype;
        private TextBox textBox_AI;
        private TextBox textBox1;
        private TextBox textBox_system;
        private ToolStripMenuItem 開啟模擬檔ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 離開ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 結束ToolStripMenuItem;
        private ToolStripMenuItem 路口設定ToolStripMenuItem;
        private ToolStripMenuItem 燈號設定ToolStripMenuItem;
        private ToolStripMenuItem 關於ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView_RoadState;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem 開啟地圖檔ToolStripMenuItem;
        private ToolStripMenuItem 開啟模擬設定檔ToolStripMenuItem;
        private ToolStripMenuItem 工具ToolStripMenuItem;
        private ToolStripButton toolStripButton_simRun;
        private ToolStripButton toolStripButton_simStop;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSplitButton toolStripSplitButton_SpeedAdjust;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripButton toolStripButton_TrafficLightConfig;
        private ToolStripButton toolStripButton_IntersectionConfig;
        private ToolStripButton toolStripButton_CarGenerateConfig;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem 關於ToolStripMenuItem1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox_AILinkStatus;
        private PictureBox pictureBox_mapFileStatus;
        private PictureBox pictureBox_cameraLinkStatus;
        private Label AiLinkStatus;
        protected Label label_localIP;
        private PictureBox pictureBox_simulationFileStatus;
        private Label cameraLinkStatus;
        protected Label MapFileStatus;
        protected Label simulationFileStatus;
        private ToolStripButton toolStripButton_Zoom;
        public Timer MainTimer;
        private Timer CarTimer;
        private Timer UIInformationTimer;
        private Timer CarGraphicTimer;
        private ToolStripButton toolStripButton_TrafficDataDisplay;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Speed;
        private DataGridViewImageColumn Road;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripButton toolStripButton_SimulatorConfig;
        private ToolStripSeparator toolStripSeparator6;

        public System.Windows.Forms.PaintEventHandler panel1_Paint { get; set; }
    }
}

