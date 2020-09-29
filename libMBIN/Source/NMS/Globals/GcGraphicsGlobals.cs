﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x9C0, GUID = 0xFAB86A9BD3A6E265)]
    public class GcGraphicsGlobals : NMSTemplate
    {
        /* 0x000 */ public float LUTDistanceFlightMultiplier;
        /* 0x004 */ public float SunLightIntensity;
        /* 0x008 */ public float SunLightBlendTime;
        /* 0x00C */ public float HBAOBias;
        /* 0x010 */ public float HBAORadius;
        /* 0x014 */ public float HBAOIntensity;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x018 */ public byte[] Padding18;
        /* 0x020 */ public GcLightShaftProperties LightShaftProperties;
        /* 0x050 */ public GcLightShaftProperties StormLightShaftProperties;
        /* 0x080 */ public float SunRayDensity;
        /* 0x084 */ public float SunRayDecay;
        /* 0x088 */ public float SunRayExposure;
        /* 0x08C */ public float SunRayWeight;
        /* 0x090 */ public float Brightness;
        /* 0x094 */ public float Contrast;
        /* 0x098 */ public float Saturation;
        /* 0x09C */ public bool Redo_On;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x09D */ public byte[] Padding9D;
        /* 0x0A0 */ public float Redo_LightIntensity;
        /* 0x0A4 */ public float Redo_SkyIntensity;
        /* 0x0A8 */ public float Redo_BounceIntensity;
        /* 0x0AC */ public float New_BounceLightWarp;
        /* 0x0B0 */ public float New_BounceLightPower;
        /* 0x0B4 */ public float New_BounceLightIntensity;
        /* 0x0B8 */ public float New_SkyLightWarp;
        /* 0x0BC */ public float New_SkyLightPower;
        /* 0x0C0 */ public float New_SkyLightIntensity;
        /* 0x0C4 */ public float New_SideRimWarp;
        /* 0x0C8 */ public float New_SideRimColourMixer;
        /* 0x0CC */ public float New_TopRimWarp;
        /* 0x0D0 */ public float New_TopRimColourMixer;
        /* 0x0D4 */ public float New_TopRimPower;
        /* 0x0D8 */ public float New_TopRimIntensity;
        /* 0x0DC */ public float Old_BounceLightWarp;
        /* 0x0E0 */ public float Old_BounceLightPower;
        /* 0x0E4 */ public float Old_BounceLightIntensity;
        /* 0x0E8 */ public float Old_SkyLightWarp;
        /* 0x0EC */ public float Old_SkyLightPower;
        /* 0x0F0 */ public float Old_SkyLightIntensity;
        /* 0x0F4 */ public float Old_SideRimWarp;
        /* 0x0F8 */ public float Old_SideRimColourMixer;
        /* 0x0FC */ public float Old_TopRimWarp;
        /* 0x100 */ public float Old_TopRimColourMixer;
        /* 0x104 */ public float Old_TopRimPower;
        /* 0x108 */ public float Old_TopRimIntensity;
        /* 0x10C */ public float ModelRendererLightIntensity;
        /* 0x110 */ public float ScanFresnel;
        /* 0x114 */ public float ScanClamp;
        /* 0x118 */ public float ScanAlpha;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x11C */ public byte[] Padding11C;
        /* 0x120 */ public Colour ScanColour;
        /* 0x130 */ public bool DebugLinesDepthTest;
        /* 0x131 */ public bool CenterRenderSpaceOffset;
        [NMS(Size = 0xE, Ignore = true)]
        /* 0x132 */ public byte[] Padding132;
        /* 0x140 */ public TkImGuiSettings ImGui;
        /* 0x2D0 */ public Colour UIColour;
        /* 0x2E0 */ public Colour UIShipColour;
        /* 0x2F0 */ public float HUDMotionXSpring;
        /* 0x2F4 */ public float HUDMotionYSpring;
        /* 0x2F8 */ public float HUDMotionPosSpring;
        /* 0x2FC */ public float HUDMotionX;
        /* 0x300 */ public float HUDMotionY;
        /* 0x304 */ public float HUDMotionPos;
        /* 0x308 */ public float HUDDistance;
        /* 0x30C */ public float NearClipDistance;
        /* 0x310 */ public float FarClipDistance;
        /* 0x314 */ public float WarpK;
        /* 0x318 */ public float WarpKCube;
        /* 0x31C */ public float WarpScale;
        /* 0x320 */ public float WarpKDispersion;
        /* 0x324 */ public int ShadowMapSize;
        /* 0x328 */ public float DirectionLightRadius;
        /* 0x32C */ public float DirectionLightFOV;
        /* 0x330 */ public float DirectionLightShadowBias;
        /* 0x334 */ public float ShadowLength;
        /* 0x338 */ public float ShadowLengthShip;
        /* 0x33C */ public float ShadowLengthSpace;
        /* 0x340 */ public float ShadowLengthStation;
        /* 0x344 */ public float ShadowLengthFreighterAbandoned;
        /* 0x348 */ public float ShadowLengthCameraView;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x34C */ public byte[] Padding34C;
        /* 0x350 */ public Vector4f ShadowSplit;
        /* 0x360 */ public Vector4f ShadowSplitShip;
        /* 0x370 */ public Vector4f ShadowSplitSpace;
        /* 0x380 */ public Vector4f ShadowSplitStation;
        /* 0x390 */ public Vector4f ShadowSplitCameraView;
        /* 0x3A0 */ public Vector4f ShadowBias;
        /* 0x3B0 */ public bool ShadowQuantized;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x3B1 */ public byte[] Padding3B1;
        /* 0x3B4 */ public float ShadowBillboardOffset;
        /* 0x3B8 */ public float QuantizeTime;
        /* 0x3BC */ public float QuantizeTimeShip;
        /* 0x3C0 */ public float QuantizeTimeSpace;
        /* 0x3C4 */ public float QuantizeTimeCameraView;
        /* 0x3C8 */ public float ToneMapExposure;
        /* 0x3CC */ public float HDRExposure;
        /* 0x3D0 */ public float HDRGamma;
        /* 0x3D4 */ public float HDRLutExposure;
        /* 0x3D8 */ public float HDRLutGamma;
        /* 0x3DC */ public float HDRLutToe;
        /* 0x3E0 */ public float HDRThreshold;
        /* 0x3E4 */ public float HDROffset;
        /* 0x3E8 */ public float LensThreshold;
        /* 0x3EC */ public float LensOffset;
        /* 0x3F0 */ public float LensScale;
        /* 0x3F4 */ public float LensDirt;
        /* 0x3F8 */ public float ToneMapExposureCave;
        /* 0x3FC */ public float HDRExposureCave;
        /* 0x400 */ public float HDRThresholdCave;
        /* 0x404 */ public float HDROffsetCave;
        /* 0x408 */ public float LensThresholdCave;
        /* 0x40C */ public float LensOffsetCave;
        /* 0x410 */ public float LensScaleCave;
        /* 0x414 */ public float LensDirtCave;
        /* 0x418 */ public float DOFNearPlane;
        /* 0x41C */ public float DOFFarPlane;
        /* 0x420 */ public float DOFAmountManual;
        /* 0x424 */ public float DOFAmountManualLightIndoor;
        /* 0x428 */ public float DOFAmountManualFullIndoor;
        /* 0x42C */ public float DOFAmountManualLight;
        /* 0x430 */ public float DOFAmountManualFull;
        /* 0x434 */ public float DOFNearFadeDistance;
        /* 0x438 */ public float DOFNearFadeDistanceManual;
        /* 0x43C */ public float DOFFarFadeDistance;
        /* 0x440 */ public float DOFFarPlaneCave;
        /* 0x444 */ public float DOFFarFadeDistanceCave;
        /* 0x448 */ public float DOFFarPlaneSpace;
        /* 0x44C */ public float DOFFarFadeDistanceSpace;
        /* 0x450 */ public float DOFFarStrengthWater;
        /* 0x454 */ public float DOFFarPlaneWater;
        /* 0x458 */ public float DOFFarFadeDistanceWater;
        /* 0x45C */ public float DOFFarPlaneManual;
        /* 0x460 */ public float DOFFarFadeDistanceManualIndoor;
        /* 0x464 */ public float DOFFarFadeDistanceManual;
        /* 0x468 */ public float DOFAutoFarAmount;
        /* 0x46C */ public float DOFAutoFarFarPlaneFade;
        /* 0x470 */ public float DOFAutoFarFarPlane;
        /* 0x474 */ public float DOFAutoFarNearPlane;
        /* 0x478 */ public float DOFNearMinInteraction;
        /* 0x47C */ public float DOFNearAdjustInteraction;
        /* 0x480 */ public float DOFFarPlaneInteraction;
        /* 0x484 */ public float DOFFarFadeDistanceInteraction;
        /* 0x488 */ public bool DOFEnableBokeh;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x489 */ public byte[] Padding489;
        /* 0x48C */ public float VignetteStart;
        /* 0x490 */ public float VignetteEnd;
        /* 0x494 */ public float VignetteStartTurnVR;
        /* 0x498 */ public float VignetteEndTurnVR;
        /* 0x49C */ public float VignetteStartMoveVR;
        /* 0x4A0 */ public float VignetteEndMoveVR;
        /* 0x4A4 */ public float VignetteVRTurnInterpTime;
        /* 0x4A8 */ public float VignetteVRMoveInterpTime;
        /* 0x4AC */ public float VignetteStartMoveVRShip;
        /* 0x4B0 */ public float VignetteEndMoveVRShip;
        /* 0x4B4 */ public float VignetteVRMoveInterpTimeShip;
        /* 0x4B8 */ public float VignetteStartTurnVRShip;
        /* 0x4BC */ public float VignetteEndTurnVRShip;
        /* 0x4C0 */ public float VignetteVRTurnInterpTimeShip;
        /* 0x4C4 */ public float VignetteStartTurnRidingVR;
        /* 0x4C8 */ public float VignetteEndTurnRidingVR;
        /* 0x4CC */ public float VignetteVRTurnRidingInterpTime;
        /* 0x4D0 */ public float VignetteStartRidingVR;
        /* 0x4D4 */ public float VignetteEndRidingVR;
        /* 0x4D8 */ public float VignetteVRRidingInterpTime;
        /* 0x4DC */ public float LowHealthVignetteStart;
        /* 0x4E0 */ public float LowHealthVignetteEnd;
        /* 0x4E4 */ public float LowHealthDesaturationIntensity;
        /* 0x4E8 */ public float LowHealthOverlayIntensity;
        /* 0x4EC */ public float LowHealthFadeInTime;
        /* 0x4F0 */ public float LowHealthFadeOutTime;
        /* 0x4F4 */ public float LowHealthPulseRateLowShield;
        /* 0x4F8 */ public float LowHealthPulseRateFullShield;
        /* 0x4FC */ public float LowHealthStrengthLowShield;
        /* 0x500 */ public float LowHealthStrengthFullShield;
        /* 0x504 */ public float ShieldDownScanlineTime;
        /* 0x508 */ public bool FullscreenScanEffect;
        /* 0x509 */ public bool UseImposters;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x50A */ public byte[] Padding50A;
        /* 0x510 */ public Vector4f MipLevelDebug;
        /* 0x520 */ public Vector4f LensParams;
        /* 0x530 */ public Colour VerticalColourTop;
        /* 0x540 */ public Colour VerticalColourBottom;
        /* 0x550 */ public Vector4f VerticalGradient;
        /* 0x560 */ public float ScanFadeInTime;
        /* 0x564 */ public float ScanFadeOutTime;
        /* 0x568 */ public float ScanEffectSpeed;
        /* 0x56C */ public float ScanObjectFade;
        /* 0x570 */ public float ScanBandWidth;
        /* 0x574 */ public float ScanHeightScale;
        /* 0x578 */ public float ScanDistance;
        /* 0x57C */ public float ScanHorizontalScale;
        /* 0x580 */ public float Single1ScanTime;
        /* 0x584 */ public float Single1ScanHeightScale;
        /* 0x588 */ public float Single1ScanBandWidth;
        /* 0x58C */ public float Single1ScanEffectSpeed;
        /* 0x590 */ public float Single1ScanObjectFade;
        /* 0x594 */ public float Single1ScanHorizontalScale;
        /* 0x598 */ public float Single2ScanTime;
        /* 0x59C */ public float Single2ScanHeightScale;
        /* 0x5A0 */ public float Single2ScanBandWidth;
        /* 0x5A4 */ public float Single2ScanEffectSpeed;
        /* 0x5A8 */ public float Single2ScanObjectFade;
        /* 0x5AC */ public float Single2ScanHorizontalScale;
        /* 0x5B0 */ public float TeleportFlashTime;
        /* 0x5B4 */ public Vector2f WindDir1;
        /* 0x5BC */ public Vector2f WindDir2;
        /* 0x5C4 */ public float AtmosphereSize;
        /* 0x5C8 */ public float RingSize;
        /* 0x5CC */ public float RingRadius;
        /* 0x5D0 */ public float HueVariance;
        /* 0x5D4 */ public float SaturationVariance;
        /* 0x5D8 */ public float ValueVariance;
        /* 0x5DC */ public float FoliageSaturationMin;
        /* 0x5E0 */ public float FoliageSaturationMax;
        /* 0x5E4 */ public float FoliageValueMin;
        /* 0x5E8 */ public float FoliageValueMax;
        /* 0x5EC */ public float GrassSaturationMin;
        /* 0x5F0 */ public float GrassSaturationMax;
        /* 0x5F4 */ public float GrassValueMin;
        /* 0x5F8 */ public float GrassValueMax;
        /* 0x5FC */ public float SkySaturationMin;
        /* 0x600 */ public float SkySaturationMax;
        /* 0x604 */ public float SkyValueMin;
        /* 0x608 */ public float SkyValueMax;
        /* 0x60C */ public float SpaceScale;
        /* 0x610 */ public float SpaceMieFactor;
        /* 0x614 */ public float SpaceSunFactor;
        /* 0x618 */ public float MaxSpaceFogStrength;
        /* 0x61C */ public float ReflectionStrength;
        /* 0x620 */ public float AlphaCutoutMin;
        /* 0x624 */ public float AlphaCutoutMax;
        /* 0x628 */ public float WaterHueShift;
        /* 0x62C */ public float WaterSaturation;
        /* 0x630 */ public float WaterValue;
        /* 0x634 */ public float MaxParticleRenderRange;
        /* 0x638 */ public float MaxParticleRenderRangeSpace;
        /* 0x63C */ public float MotionBlurShutterSpeed;
        /* 0x640 */ public float MotionBlurShutterAngle;
        /* 0x644 */ public float TaaLowFreqConstant;
        /* 0x648 */ public float TaaHighFreqConstant;
        /* 0x64C */ public float TaaAccumDelay;
        /* 0x650 */ public float FrustumJitterAmount;
        /* 0x654 */ public bool UseTaaResolve;
        /* 0x655 */ public bool ApplyTaaTest;
        /* 0x656 */ public bool ShowTaaBuf;
        /* 0x657 */ public bool TonemapInLuminance;
        /* 0x658 */ public bool ShowTaaVarianceBuf;
        /* 0x659 */ public bool ShowTaaNVarianceBuf;
        /* 0x65A */ public bool ShowTaaCVarianceBuf;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x65B */ public byte[] Padding65B;
        /* 0x660 */ public Vector4f TaaSettings;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x670 */ public Vector4f[] TessSettings;
        /* 0x6B0 */ public Vector4f TerrainMipDistanceLow;
        /* 0x6C0 */ public Vector4f TerrainMipDistanceMed;
        /* 0x6D0 */ public Vector4f TerrainMipDistanceHigh;
        /* 0x6E0 */ public Vector4f TerrainMipDistanceUlt;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x6F0 */ public Vector4f[] ShellsSettings;
        /* 0x730 */ public int TerrainAnisoLow;
        /* 0x734 */ public int TerrainAnisoMed;
        /* 0x738 */ public int TerrainAnisoHi;
        /* 0x73C */ public int TerrainAnisoUlt;
        /* 0x740 */ public int TerrainDroppedMipsLow;
        /* 0x744 */ public int TerrainDroppedMipsMed;
        /* 0x748 */ public float TerrainMipBiasLow;
        /* 0x74C */ public float TerrainMipBiasMed;
        /* 0x750 */ public int TerrainBlocksPerFrameLow;
        /* 0x754 */ public int TerrainBlocksPerFrameMed;
        /* 0x758 */ public int TerrainBlocksPerFrameHi;
        /* 0x75C */ public int TerrainBlocksPerFrameUlt;
        /* 0x760 */ public int TerrainBlocksPerFramePs430;
        /* 0x764 */ public int TerrainBlocksPerFramePs460;
        /* 0x768 */ public int TerrainBlocksPerFrameXb130;
        /* 0x76C */ public int TerrainBlocksPerFrameXb160;
        /* 0x770 */ public int TerrainBlocksPerFrameOberon;
        /* 0x774 */ public bool EnableTerrainCachePs4Base;
        /* 0x775 */ public bool EnableTerrainCachePs4Pro;
        /* 0x776 */ public bool EnableTerrainCacheXb1Base;
        /* 0x777 */ public bool EnableTerrainCacheXb1X;
        /* 0x778 */ public bool ForceCachedTerrain;
        /* 0x779 */ public bool ForceUncachedTerrain;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x77A */ public byte[] Padding77A;
        /* 0x77C */ public float MinPixelSizeOfObjectsInShadowsSpace;
        /* 0x780 */ public float MinPixelSizeOfObjectsInShadowsPlanet;
        /* 0x784 */ public float MinPixelSizeOfObjectsInShadowsCockpitOnPlanet;
        /* 0x788 */ public bool AllowPartialCascadeRender;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x789 */ public byte[] Padding789;
        [NMS(Size = 0x4)]
        /* 0x78C */ public int[] CascadeRenderSequence;
        /* 0x79C */ public int SupersamplingLevel;
        /* 0x7A0 */ public bool EnableTextureStreaming;
        /* 0x7A1 */ public bool ForceStreamAllTextures;
        /* 0x7A2 */ public bool ForceEvictAllTextures;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x7A3 */ public byte[] Padding7A3;
        /* 0x7A4 */ public int TargetTextureMemUsageMB;
        /* 0x7A8 */ public float MotionBlurThresholdOnFoot;
        /* 0x7AC */ public float MotionBlurThresholdInVehicle;
        /* 0x7B0 */ public float MotionBlurThresholdSpace;
        /* 0x7B4 */ public float MotionBlurThresholdDefault;
        /* 0x7B8 */ public float SpaceIBLBlendStart;
        /* 0x7BC */ public float SpaceIBLBlendDistance;
        /* 0x7C0 */ public float NoFocusMaxFPS;
        /* 0x7C4 */ public bool EnableCrossPipeSharing;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x7C5 */ public byte[] Padding7C5;
        /* 0x7C8 */ public float SharpenFilterAmount;
        /* 0x7CC */ public float SharpenFilterDepthFactorStart;
        /* 0x7D0 */ public float SharpenFilterDepthFactorEnd;
        [NMS(Size = 0x4, EnumType = typeof( TkGraphicsDetailTypes.GraphicDetailEnum ))]
        /* 0x7D4 */ public TkGraphicsDetailPreset[] GraphicsDetailPresetsPC;
        /* 0x884 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4;
        /* 0x8B0 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4VR;
        /* 0x8DC */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4Pro;
        /* 0x908 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4ProVR;
        /* 0x934 */ public TkGraphicsDetailPreset GraphicsDetailPresetXB1;
        /* 0x960 */ public TkGraphicsDetailPreset GraphicsDetailPresetXB1X;
        /* 0x98C */ public TkGraphicsDetailPreset GraphicsDetailPresetOberon;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x9B8 */ public byte[] EndPadding;
    }
}
