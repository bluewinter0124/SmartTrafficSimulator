﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartCitySimulator.Unit;
using System.Collections;
using SmartCitySimulator.GraphicUnit;
using SmartCitySimulator.SystemUnit;
using System.Drawing;
using System.Windows.Forms;

namespace SmartCitySimulator.SystemUnit
{
    class RoadManager
    {
        public List<Road> roadList = new List<Road>();
        public List<Road> GenerateCarRoadList = new List<Road>();
    
        public void AllRoadInitialize()
        {
            GenerateCompleteRoadPath();
            GenerateCompleteMap();
            DeployLightToAllRoads();
        }

        public void GenerateCompleteRoadPath()
        {
            foreach (Road road in SimulatorConfiguration.RoadManager.roadList)
            {
                road.CalculateCompletePath();
            }
        }

        public void GenerateCompleteMap()
        {
            foreach (Road road in SimulatorConfiguration.RoadManager.roadList)
            {
                road.CalculateConnectPath();
            }
        }

        public void DeployLightToAllRoads()
        {
            foreach (Road road in SimulatorConfiguration.RoadManager.roadList)
            {
                if (road.connectedRoadID.Count > 0)
                {
                    Light light = new Light();
                    light.trafficLight_ID = Convert.ToInt32(road.roadID);

                    road.DeployLight(light);         //配置紅綠燈給road

                    road.DeployLight(light);         //配置紅綠燈給road
                    light.deployRoad = road;

                    if (road.roadPath[road.roadPath.Count - 1].Y == road.roadPath[road.roadPath.Count - 2].Y)
                        light.LightRotate(90);

                    light.setLocation(road.roadNode[road.roadNode.Count - 1]);

                    SimulatorConfiguration.UI.splitContainer1.Panel2.Controls.Add(light);
                    SimulatorConfiguration.UI.splitContainer1.Panel2.Controls.Add(light.ownCounter);
                    
                }
            }
        }
    }
}
