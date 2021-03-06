﻿using Transit.Framework;
using Transit.Framework.Texturing;

namespace Transit.Addon.RoadExtensions.Roads.SmallHeavyRoads.SmallAvenue4L
{
    public partial class SmallAvenue4LBuilder
    {
        public static void SetupTextures(NetInfo info, NetInfoVersion version)
        {
            switch (version)
            {
                case NetInfoVersion.Ground:
                    for (var i = 0; i < info.m_segments.Length; i++)
                    {
                        if (info.m_segments[i].m_mesh.name.Contains("Tram") == false)
                        {
                            info.m_segments[i].SetTextures(
                                new TextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_Segment__MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_Segment__AlphaMap.png"),
                                new LODTextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_SegmentLOD__MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_SegmentLOD__AlphaMap.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_SegmentLOD__XYS.png"));
                        }
                    }
                    break;
                case NetInfoVersion.Elevated:
                case NetInfoVersion.Bridge:
                    for (var i = 0; i < info.m_segments.Length; i++)
                    {
                        if (info.m_segments[i].m_mesh.name.Contains("Tram") == false)
                        {
                            info.m_segments[i].SetTextures(
                                new TextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Elevated_MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Elevated_Segment__APRMap.png"),
                                new LODTextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Elevated_LOD__MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Elevated_SegmentLOD__APRMap.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Elevated_LOD__XYSMap.png"));
                        }
                    }
                    for (var i = 0; i < info.m_nodes.Length; i++)
                    {
                        if (info.m_nodes[i].m_mesh.name.Contains("Tram") == false)
                        {
                            info.m_nodes[i].SetTextures(
                                new TextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Elevated_MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Elevated_Node__APRMap.png"),
                                new LODTextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Elevated_LOD__MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Elevated_NodeLOD__APRMap.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Elevated_LOD__XYSMap.png"));
                        }
                    }
                    break;
                case NetInfoVersion.Slope:
                    for (int i = 0; i < info.m_segments.Length; i++)
                    {
                        if (info.m_segments[i].m_mesh.name == "Slope")
                        {
                            info.m_segments[i].SetTextures(
                                new TextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_Segment__MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_Segment__AlphaMap.png"),
                                new LODTextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_SegmentLOD__MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_SegmentLOD__AlphaMap.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Slope_SegmentLOD2__XYSMap.png"));
                        }
                        else if(info.m_segments[i].m_mesh.name.Contains("Tram") == false)
                        {
                            info.m_segments[i].SetTextures(
                                new TextureSet
                                   (@"Roads\Highways\Highway4L\Textures\Slope_Segment__MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Slope_Segment__APRMap.png"),
                                new LODTextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Slope_SegmentLOD__MainTex.png",
                                     @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Slope_SegmentLOD__APRMap.png",
                                     @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Slope_SegmentLOD__XYSMap.png"));
                        }
                    }
                    for (int i = 0; i < info.m_nodes.Length; i++)
                    {
                        if (info.m_nodes[i].m_mesh.name == "Slope_Node")
                        {
                            info.m_nodes[i].SetTextures(
                                new TextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_Segment__MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_Node__AlphaMap.png"),
                                new LODTextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_SegmentLOD__MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_SegmentLOD__AlphaMap.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Ground_SegmentLOD__XYS.png"));
                        }
                        else if(info.m_nodes[i].m_mesh.name.Contains("Tram") == false)
                        {
                            info.m_nodes[i].SetTextures(
                                new TextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_Segment__MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_Node__APRMap.png"),
                                new LODTextureSet
                                    (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_NodeLOD__MainTex.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_LOD__APRMap.png",
                                    @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_LOD__XYSMap.png"));
                        }
                    }
                    //info.SetAllNodesTexture(
                    //new TextureSet
                    //    (@"Roads\Highways\Highway4L\Textures\Slope_Node__MainTex.png",
                    //    @"Roads\Highways\Highway4L\Textures\Ground_Node__APRMap.png"),
                    //new LODTextureSet
                    //    (@"Roads\Highways\Highway4L\Textures\Ground_NodeLOD__MainTex.png",
                    //    @"Roads\Highways\Highway4L\Textures\Ground_NodeLOD__APRMap.png",
                    //    @"Roads\Highways\Highway4L\Textures\Ground_LOD__XYSMap.png"));
                    break;
                case NetInfoVersion.Tunnel:
                    {
                        for (var i = 0; i < info.m_segments.Length; i++)
                        {
                            if (info.m_segments[i].m_mesh.name.Contains("Tram") == false)
                            {
                                info.m_segments[i].SetTextures(
                            new TextureSet
                                (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_Segment__MainTex.png",
                                @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_Segment__APRMap.png"),
                            new LODTextureSet
                                (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_NodeLOD__MainTex.png",
                                @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_LOD__APRMap.png",
                                @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_LOD__XYSMap.png"));
                            }
                        }
                        for (var i = 0; i < info.m_nodes.Length; i++)
                        {
                            if (info.m_nodes[i].m_mesh.name.Contains("Tram") == false)
                            {
                                info.m_nodes[i].SetTextures(
                                    new TextureSet
                                        (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_Segment__MainTex.png",
                                        @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_Node__APRMap.png"),
                                    new LODTextureSet
                                        (@"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_NodeLOD__MainTex.png",
                                        @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_LOD__APRMap.png",
                                        @"Roads\SmallHeavyRoads\SmallAvenue4L\Textures\Tunnel_LOD__XYSMap.png"));
                            }
                        }
                        break;
                    }
            }
        }
    }
}

