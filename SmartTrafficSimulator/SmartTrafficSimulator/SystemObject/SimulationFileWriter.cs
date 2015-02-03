﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using SmartTrafficSimulator;
using System.Xml;
using SmartTrafficSimulator.Unit;
using System.Drawing;

namespace SmartTrafficSimulator.SystemObject
{
    class SimulationFileWriter
    {
        public void SaveMapFile(string mapFile)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt";
            save.Title = "Save Map Config File To";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = save.OpenFile();
                StreamWriter writer = new StreamWriter(myStream);
                writer.WriteLine("mapFilename " + mapFile);
                for (int i = 0; i < MapEditor.roadList.Count; i++)
                {
                    if (i == 0)
                        writer.WriteLine("@");
                    writer.WriteLine("Road " + MapEditor.roadList[i].roadID);
                    writer.WriteLine("{");
                    for (int j = 0; j < MapEditor.roadList[i].roadPathID.Count; j++)
                    {
                        if (j == MapEditor.roadList[i].roadPathID.Count - 1)
                            writer.WriteLine(MapEditor.roadList[i].roadNode[j].X
                                + "," + MapEditor.roadList[i].roadNode[j].Y);
                        else if (j == 0)
                            writer.Write("\tPath " + MapEditor.roadList[i].roadNode[j].X
                                + "," + MapEditor.roadList[i].roadNode[j].Y + ";");
                        else
                            writer.Write(MapEditor.roadList[i].roadNode[j].X
                                + "," + MapEditor.roadList[i].roadNode[j].Y + ";");
                    }
                    for (int j = 0; j < MapEditor.roadList[i].connectedRoadIDList.Count; j++)
                    {
                        if (MapEditor.roadList[i].connectedRoadIDList.Count == 1)
                            writer.WriteLine("\tConnect " + MapEditor.roadList[i].connectedRoadIDList[j]);
                        else if (j == MapEditor.roadList[i].connectedRoadIDList.Count - 1)
                            writer.WriteLine(MapEditor.roadList[i].connectedRoadIDList[j]);
                        else if (j == 0)
                            writer.Write("\tConnect " + MapEditor.roadList[i].connectedRoadIDList[j] + ",");
                        else
                            writer.Write(MapEditor.roadList[i].connectedRoadIDList[j] + ",");
                    }
                    writer.WriteLine("}");
                    writer.WriteLine("#");
                    writer.Flush();
                }
                for (int i = 0; i < MapEditor.intersectionList.Count; i++)
                {
                    writer.WriteLine("Intersection " + MapEditor.intersectionList[i].intersectionID);
                    writer.WriteLine("{");
                    for (int j = 0; j < MapEditor.intersectionList[i].roadListOfIntersection.Count; j++)
                    {
                        writer.WriteLine("Road " + 
                            MapEditor.intersectionList[i].roadListOfIntersection[j].roadID +
                            " " + MapEditor.intersectionList[i].roadListOfIntersection[j].roadOrder);
                    }
                    writer.WriteLine("}");
                    writer.WriteLine("#");
                    if (i == MapEditor.intersectionList.Count-1)
                        writer.Write("@");
                    writer.Flush();
                }
                writer.Close();
            }
        }

        public void SaveMapFileXML()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement map = doc.CreateElement("Map");
            doc.AppendChild(map);

            XmlElement MapName = doc.CreateElement("MapName");
            MapName.InnerText = Simulator.mapFileName;
            map.AppendChild(MapName);

            XmlElement MapPicture = doc.CreateElement("MapPicture");
            MapPicture.InnerText = Simulator.mapPicture;
            map.AppendChild(MapPicture);

            XmlElement ContainsRoads = doc.CreateElement("ContainRoads");
            map.AppendChild(ContainsRoads);

            foreach (Road road in Simulator.RoadManager.GetRoadList())
            {
                XmlElement roadInfo = doc.CreateElement("Road");

                XmlElement ID = doc.CreateElement("ID");
                ID.InnerText = road.roadID + "";
                roadInfo.AppendChild(ID);

                XmlElement Name = doc.CreateElement("Name");
                Name.InnerText = road.roadName;
                roadInfo.AppendChild(Name);

                XmlElement Nodes = doc.CreateElement("Nodes");
                roadInfo.AppendChild(Nodes);

                XmlElement Node;
                foreach (Point p in road.roadNode)
                {
                    Node = doc.CreateElement("Node");
                    Node.SetAttribute("X", p.X+"");
                    Node.SetAttribute("Y", p.Y+"");
                    Nodes.AppendChild(Node);
                }

                XmlElement ConnectedRoad = doc.CreateElement("ConnectedRoad");
                if (road.connectedRoadIDList.Count > 0)
                {
                    roadInfo.AppendChild(ConnectedRoad);

                    string connectedRoadID = "";
                    for (int i = 0; i < road.connectedRoadIDList.Count; i++)
                    {
                        connectedRoadID += road.connectedRoadIDList[i];
                        if (i < road.connectedRoadIDList.Count - 1)
                            connectedRoadID += ",";
                    }
                    ConnectedRoad.InnerText = connectedRoadID;
                }
                ContainsRoads.AppendChild(roadInfo);
            }

            XmlElement IntersectionConfiguration = doc.CreateElement("IntersectionConfiguration");
            map.AppendChild(IntersectionConfiguration);

            foreach (Intersection intersection in Simulator.IntersectionManager.GetIntersectionList())
            {
                XmlElement intersectionInfo = doc.CreateElement("Intersection");

                XmlElement ID = doc.CreateElement("ID");
                ID.InnerText = intersection.intersectionID + "";
                Simulator.UI.AddMessage("System", intersection.intersectionID + "");
                intersectionInfo.AppendChild(ID);

                XmlElement Name = doc.CreateElement("Name");
                Name.InnerText = intersection.intersectionName;
                intersectionInfo.AppendChild(Name);

                XmlElement composedRoads = doc.CreateElement("ComposedRoads");
                intersectionInfo.AppendChild(composedRoads);

                XmlElement composedRoad;
                foreach (Road road in intersection.roadList)
                {
                    composedRoad = doc.CreateElement("ComposedRoad");
                    composedRoad.SetAttribute("ID", road.roadID+"");
                    composedRoad.SetAttribute("ConfigNo",road.order+"");
                    composedRoads.AppendChild(composedRoad);
                }

                IntersectionConfiguration.AppendChild(intersectionInfo);
            }


            doc.Save(Simulator.mapFileFolder+"\\"+Simulator.mapName+".xml");
        }
    }
}
