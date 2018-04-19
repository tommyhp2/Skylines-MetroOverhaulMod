﻿using MetroOverhaul.NEXT;
using MetroOverhaul.NEXT.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetroOverhaul.InitializationSteps
{
    partial class SetupSteelMesh
    {
        public static void Setup16mSteelStationMesh(NetInfo prefab, NetInfoVersion version, NetInfo elevatedInfo, NetInfo metroStationInfo)
        {
            var elevatedMaterial = elevatedInfo.m_segments[0].m_material;
            var elevatedLODMaterial = elevatedInfo.m_segments[0].m_lodMaterial;

            switch (version)
            {
                case NetInfoVersion.Ground:
                    {
                        var segment0 = prefab.m_segments[0].ShallowClone();
                        var segment1 = prefab.m_segments[1].ShallowClone();
                        var segment2 = prefab.m_segments[0].ShallowClone();
                        var node0 = prefab.m_nodes[0].ShallowClone();
                        var node1 = prefab.m_nodes[1].ShallowClone();
                        var node2 = prefab.m_nodes[2].ShallowClone();
                        var node3 = prefab.m_nodes[1].ShallowClone();
                        var node4 = prefab.m_nodes[0].ShallowClone();
                        var node5 = prefab.m_nodes[2].ShallowClone();
                        var node6 = prefab.m_nodes[1].ShallowClone();
                        var nodeList = new List<NetInfo.Node>();
                        nodeList.Add(node0);
                        nodeList.Add(node1);
                        nodeList.Add(node2);
                        nodeList.Add(node3);
                        nodeList.Add(node4);
                        nodeList.Add(node5);
                        nodeList.Add(node6);
                        segment0
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\16m\Ground_Station_Pavement.obj",
                                @"Meshes\16m\Ground_Station_Pavement_LOD.obj");

                        node0
                            .SetMeshes
                            (@"Meshes\16m\Ground_Station_Node_Pavement.obj",
                                @"Meshes\16m\Ground_Station_Node_Pavement_LOD.obj")
                            .SetConsistentUVs(true);

                        segment1
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\16m\Station_Rail.obj",
                            @"Meshes\16m\Station_Rail_LOD.obj")
                            .SetConsistentUVs();
                        segment2
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\16m\Station_ThirdRail.obj", @"Meshes\10m\Blank.obj")
                            .SetConsistentUVs();
                        node1
                            .SetMeshes
                            (@"Meshes\16m\Station_Node_Boosted_Rail.obj",
                             @"Meshes\16m\Station_Node_Rail_LOD.obj")
                            .SetConsistentUVs();
                        node2
                            .SetMeshes
                            (@"Meshes\10m\LevelCrossing_Pavement.obj")
                            .SetConsistentUVs();
                        node3
                            .SetMeshes
                            (@"Meshes\10m\LevelCrossing_Rail.obj");
                        node4
                            .SetMeshes
                            (@"Meshes\16m\Station_Node_ThirdRail.obj", @"Meshes\10m\Blank.obj")
                            .SetConsistentUVs();
                        node5
                            .SetMeshes
                            (@"Meshes\10m\ThirdRail_LevelCrossing.obj", @"Meshes\10m\Blank.obj")
                            .SetConsistentUVs();
                        node6
                            .SetMeshes
                            (@"Meshes\16m\Station_Node_Boosted_Rail_Merge.obj",
                             @"Meshes\16m\Station_Node_Rail_LOD.obj")
                            .SetConsistentUVs();
                        node1.m_flagsForbidden = NetNode.Flags.LevelCrossing;
                        node3.m_flagsRequired = NetNode.Flags.LevelCrossing;
                        node6.m_connectGroup = NetInfo.ConnectGroup.CenterTram | (NetInfo.ConnectGroup)16;
                        prefab.m_segments = new[] { segment0, segment1, segment2 };
                        prefab.m_nodes = nodeList.ToArray();
                        break;
                    }
                case NetInfoVersion.Elevated:
                    {
                        var segment0 = prefab.m_segments[0].ShallowClone();
                        var segment1 = prefab.m_segments[1].ShallowClone();
                        var segment2 = prefab.m_segments[0].ShallowClone();
                        var node0 = prefab.m_nodes[0].ShallowClone();
                        var node1 = prefab.m_nodes[1].ShallowClone();
                        var node2 = prefab.m_nodes[0].ShallowClone();
                        var node3 = prefab.m_nodes[1].ShallowClone();
                        var node4 = prefab.m_nodes[0].ShallowClone();
                        var node5 = prefab.m_nodes[0].ShallowClone();
                        var node6 = prefab.m_nodes[0].ShallowClone();
                        var node7 = prefab.m_nodes[0].ShallowClone();
                        var nodeList = new List<NetInfo.Node>();
                        nodeList.Add(node0);
                        nodeList.Add(node1);
                        nodeList.Add(node2);
                        nodeList.Add(node3);
                        nodeList.Add(node4);
                        nodeList.Add(node5);
                        nodeList.Add(node6);
                        nodeList.Add(node7);
                        segment0
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\16m\Elevated_Station_Pavement_Steel.obj",
                                @"Meshes\16m\Elevated_Station_Pavement_Steel_LOD.obj");

                        segment1
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\16m\Station_Rail.obj",
                            @"Meshes\16m\Station_Rail_LOD.obj")
                            .SetConsistentUVs();
                        segment2
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\16m\Station_ThirdRail.obj", @"Meshes\10m\Blank.obj")
                            .SetConsistentUVs();
                        node0
                            .SetMeshes
                            (@"Meshes\16m\Elevated_Station_Node_Pavement_Steel.obj",
                                @"Meshes\16m\Elevated_Station_Node_Pavement_Steel_LOD.obj")
                            .SetConsistentUVs();
                        node1
                            .SetMeshes
                            (@"Meshes\16m\Station_Node_Rail.obj",
                             @"Meshes\16m\Station_Node_Rail_LOD.obj")
                             .SetConsistentUVs();
                        node2
                            .SetMeshes
                            (@"Meshes\16m\Station_Node_Insert_Steel.obj",
                            @"Meshes\10m\Boosted_Rail_Steel_LOD.obj")
                            .SetConsistentUVs();
                        node3
                            .SetMeshes
                            (@"Meshes\16m\Station_Node_Rail_Merge.obj",
                             @"Meshes\16m\Station_Node_Rail_LOD.obj")
                             .SetConsistentUVs();
                        node4
                            .SetMeshes
                            (@"Meshes\16m\Station_Node_Insert_Steel_Merge.obj",
                            @"Meshes\10m\Boosted_Rail_Steel_LOD.obj")
                            .SetConsistentUVs();
                        node5
                            .SetMeshes
                            (@"Meshes\16m\Elevated_Station_Node_Pavement_Insert_Steel_Merge.obj",
                            @"Meshes\10m\Boosted_Rail_Steel_LOD.obj")
                            .SetConsistentUVs();
                        node6
                            .SetMeshes
                            (@"Meshes\16m\Elevated_Station_Node_Pavement_Insert_Steel.obj",
                            @"Meshes\10m\Boosted_Rail_Steel_LOD.obj")
                            .SetConsistentUVs();
                        node7
                           .SetMeshes
                            (@"Meshes\16m\Station_Node_ThirdRail.obj", @"Meshes\10m\Blank.obj")
                            .SetConsistentUVs();
                        segment0.m_material = elevatedMaterial;
                        segment0.m_lodMaterial = elevatedLODMaterial;
                        node0.m_material = elevatedMaterial;
                        node0.m_lodMaterial = elevatedLODMaterial;
                        node2.m_material = elevatedMaterial;
                        node2.m_lodMaterial = elevatedLODMaterial;
                        node2.m_directConnect = true;
                        node2.m_connectGroup = NetInfo.ConnectGroup.NarrowTram | (NetInfo.ConnectGroup)32;
                        node3.m_directConnect = true;
                        node3.m_connectGroup = NetInfo.ConnectGroup.CenterTram | (NetInfo.ConnectGroup)16;
                        node4.m_connectGroup = NetInfo.ConnectGroup.CenterTram | (NetInfo.ConnectGroup)16;
                        node5.m_connectGroup = NetInfo.ConnectGroup.CenterTram | (NetInfo.ConnectGroup)16;
                        node6.m_connectGroup = NetInfo.ConnectGroup.NarrowTram | (NetInfo.ConnectGroup)32;
                        node4.m_directConnect = true;
                        node5.m_directConnect = true;
                        node6.m_directConnect = true;
                        //nodeList.AddRange(GenerateSplitTracks(prefab, version));

                        prefab.m_segments = new[] { segment0, segment1, segment2 };
                        prefab.m_nodes = nodeList.ToArray();
                        break;
                    }
                case NetInfoVersion.Tunnel:
                    {
                        var segment0 = metroStationInfo.m_segments[0].ShallowClone();
                        var segment1 = metroStationInfo.m_segments[0].ShallowClone();
                        var segment2 = metroStationInfo.m_segments[0].ShallowClone();
                        var segment3 = metroStationInfo.m_segments[0].ShallowClone();
                        var node0 = metroStationInfo.m_nodes[0].ShallowClone();
                        var node1 = metroStationInfo.m_nodes[0].ShallowClone();
                        var node2 = metroStationInfo.m_nodes[0].ShallowClone();
                        var node3 = metroStationInfo.m_nodes[0].ShallowClone();
                        var node4 = metroStationInfo.m_nodes[0].ShallowClone();
                        var nodeList = new List<NetInfo.Node>();
                        nodeList.Add(node0);
                        nodeList.Add(node1);
                        nodeList.Add(node2);
                        nodeList.Add(node3);
                        nodeList.Add(node4);
                        segment1
                            .SetMeshes
                            (@"Meshes\16m\Tunnel_Station_Pavement.obj",
                                @"Meshes\10m\Tunnel_Pavement_LOD.obj")
                                .SetConsistentUVs();
                        segment2
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\16m\Station_Boosted_Rail.obj",
                            @"Meshes\16m\Station_Rail_LOD.obj")
                            .SetConsistentUVs();
                        segment3
                            .SetFlagsDefault()
                            .SetMeshes
                            (@"Meshes\16m\ThirdRail.obj", @"Meshes\10m\Blank.obj")
                            .SetConsistentUVs();
                        node1
                            .SetMeshes
                            (@"Meshes\16m\Tunnel_Station_Node_Pavement.obj",
                                @"Meshes\10m\Tunnel_Node_Pavement_LOD.obj")
                                .SetConsistentUVs();
                        node2
                            .SetMeshes
                            (@"Meshes\16m\Station_Node_Boosted_Rail.obj",
                             @"Meshes\16m\Station_Node_Rail_LOD.obj")
                            .SetConsistentUVs();
                        node3
                            .SetMeshes
                            (@"Meshes\16m\Station_Node_ThirdRail.obj", @"Meshes\10m\Blank.obj")
                            .SetConsistentUVs();
                        node4
                            .SetMeshes
                            (@"Meshes\16m\Station_Node_Boosted_Rail_Merge.obj",
                             @"Meshes\16m\Station_Node_Rail_LOD.obj")
                            .SetConsistentUVs();
                        segment1.m_material = elevatedMaterial;
                        segment1.m_lodMaterial = elevatedLODMaterial;
                        segment2.m_material = elevatedMaterial;
                        segment2.m_lodMaterial = elevatedLODMaterial;
                        segment3.m_material = elevatedMaterial;
                        segment3.m_lodMaterial = elevatedLODMaterial;
                        node1.m_material = elevatedMaterial;
                        node1.m_lodMaterial = elevatedLODMaterial;
                        node2.m_material = elevatedMaterial;
                        node2.m_lodMaterial = elevatedLODMaterial;
                        node3.m_material = elevatedMaterial;
                        node3.m_lodMaterial = elevatedLODMaterial;
                        node4.m_connectGroup = NetInfo.ConnectGroup.CenterTram | (NetInfo.ConnectGroup)16;
                        prefab.m_segments = new[] { segment0, segment1, segment2, segment3 };
                        prefab.m_nodes = nodeList.ToArray();
                        break;
                    }
            }
        }
    }
}
