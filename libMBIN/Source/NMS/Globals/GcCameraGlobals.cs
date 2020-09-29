using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x5460, GUID = 0x1A02711A23594976)]
    public class GcCameraGlobals : NMSTemplate
    {
        /* 0x0000 */ public TkModelRendererData FreighterCustomisationStandardCamera;
        /* 0x00B0 */ public GcCameraFollowSettings VehicleCamHmd;
        /* 0x01B0 */ public GcCameraFollowSettings VehicleCam;
        /* 0x02B0 */ public float SpecialVehicleMouseRecentreTime;
        /* 0x02B4 */ public float SpecialVehicleMouseRecentreWeaponTime;
        /* 0x02B8 */ public float HmdEyeLookAngle;
        /* 0x02BC */ public float HmdEyeExtraTurnAngle;
        /* 0x02C0 */ public float HmdEyeExtraTurnMinHeadAngle;
        /* 0x02C4 */ public float HmdEyeExtraTurnHeadAngleRange;
        /* 0x02C8 */ public bool PauseThirdPersonCamInPause;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x02C9 */ public byte[] Padding2C9;
        /* 0x02CC */ public float DebugPlanetJumpNearHeight;
        /* 0x02D0 */ public float DebugPlanetJumpFarHeight;
        /* 0x02D4 */ public float TogglePerspectiveBlendTime;
        /* 0x02D8 */ public float UnderwaterCameraSurfaceOffset;
        /* 0x02DC */ public float ThirdPersonAfterIntroCamBlendTime;
        /* 0x02E0 */ public float ThirdPersonSkipIntroCamBlendTime;
        /* 0x02E4 */ public float VehicleExitFlashTime;
        /* 0x02E8 */ public float VehicleExitFlashStrength;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x02EC */ public byte[] Padding2EC;
        /* 0x02F0 */ public Colour VehicleExitFlashColour;
        /* 0x0300 */ public float VehicleFirstToThirdExitOffsetY;
        /* 0x0304 */ public float VehicleFirstToThirdExitOffsetZ;
        /* 0x0308 */ public float ShipThirdPersonBlendTime;
        /* 0x030C */ public float ShipThirdPersonBlendWithOffsetTime;
        /* 0x0310 */ public float ShipThirdPersonBlendOffset;
        /* 0x0314 */ public float ShipThirdPersonBlendOutTime;
        /* 0x0318 */ public float ShipThirdPersonBlendOutOffset;
        /* 0x031C */ public float ShipFirstPersonBlendTime;
        /* 0x0320 */ public float ShipFirstPersonBlendOffset;
        /* 0x0324 */ public float ShipThirdPersonEnterBlendTime;
        /* 0x0328 */ public float ShipThirdPersonEnterBlendOffset;
        /* 0x032C */ public float FlybyMinRange;
        /* 0x0330 */ public float FlybyRange;
        /* 0x0334 */ public float FlybyMinRelativeSpeed;
        /* 0x0338 */ public float FlybyRelativeSpeedRange;
        /* 0x033C */ public float FlybyInVehicleDamper;
        /* 0x0340 */ public float BinocularFlashTime;
        /* 0x0344 */ public float BinocularFlashStrength;
        /* 0x0348 */ public float MinFirstPersonCameraPitch;
        /* 0x034C */ public float MaxFirstPersonCameraPitch;
        /* 0x0350 */ public float MaxCreatureRidingYaw;
        /* 0x0354 */ public float ThirdPersonRotationBackAdjustAngleMin;
        /* 0x0358 */ public float ThirdPersonRotationBackAdjustAngleMax;
        /* 0x035C */ public float ThirdPersonUphillAdjustSpringTimeMin;
        /* 0x0360 */ public float ThirdPersonUphillAdjustSpringTimeMax;
        /* 0x0364 */ public float ThirdPersonDownhillAdjustSpringTimeMin;
        /* 0x0368 */ public float ThirdPersonDownhillAdjustSpringTimeMax;
        /* 0x036C */ public float ThirdPersonDownhillAdjustMinAngle;
        /* 0x0370 */ public float ThirdPersonDownhillAdjustMaxAngle;
        /* 0x0374 */ public float ThirdPersonUphillAdjustMinAngle;
        /* 0x0378 */ public float ThirdPersonUphillAdjustMaxAngle;
        /* 0x037C */ public float ThirdPersonDownhillAdjustMinAnglePrime;
        /* 0x0380 */ public float ThirdPersonDownhillAdjustMaxAnglePrime;
        /* 0x0384 */ public float ThirdPersonUphillAdjustMinAnglePrime;
        /* 0x0388 */ public float ThirdPersonUphillAdjustMaxAnglePrime;
        /* 0x038C */ public float ThirdPersonUphillAdjustCrossSlopeMinAngle;
        /* 0x0390 */ public float ThirdPersonUphillAdjustCrossSlopeMaxAngle;
        /* 0x0394 */ public float VehicleThirdPersonShootOffsetReturnTime;
        /* 0x0398 */ public float VehicleThirdPersonShootOffsetBlendOutTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x039C */ public byte[] Padding39C;
        [NMSDescription("Camera settings for idling/walking player in outdoors")]
        /* 0x03A0 */ public GcCameraFollowSettings CharacterUnarmedCam;
        [NMSDescription("Camera settings for when the player is running")]
        /* 0x04A0 */ public GcCameraFollowSettings CharacterRunCam;
        [NMSDescription("Camera settings for when the player is using weapons")]
        /* 0x05A0 */ public GcCameraFollowSettings CharacterCombatCam;
        [NMSDescription("Camera settings for idling/walking player in indoors")]
        /* 0x06A0 */ public GcCameraFollowSettings CharacterIndoorCam;
        /* 0x07A0 */ public GcCameraFollowSettings CharacterAbandCombatCam;
        /* 0x08A0 */ public GcCameraFollowSettings CharacterAbandCam;
        /* 0x09A0 */ public GcCameraFollowSettings CharacterNexusCam;
        [NMSDescription("Camera settings for when the player uses the jetpack")]
        /* 0x0AA0 */ public GcCameraFollowSettings CharacterAirborneCam;
        /* 0x0BA0 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        /* 0x0CA0 */ public GcCameraFollowSettings CharacterRocketBootsCam;
        /* 0x0DA0 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
        [NMSDescription("Camera settings for when the player is falling. This also includes when the player deactivates the jetpack in mid-air")]
        /* 0x0EA0 */ public GcCameraFollowSettings CharacterFallingCam;
        /* 0x0FA0 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        /* 0x10A0 */ public GcCameraFollowSettings CharacterSpaceCam;
        [NMSDescription("Camera settings for when the player is climbing or riding a slope")]
        /* 0x11A0 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        [NMSDescription("Camera settings for when the player is underwater")]
        /* 0x12A0 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        /* 0x13A0 */ public GcCameraFollowSettings CharacterUnderwaterCombatCam;
        /* 0x14A0 */ public GcCameraFollowSettings CharacterUnderwaterJetpackCam;
        /* 0x15A0 */ public GcCameraFollowSettings CharacterGrabbedCam;
        /* 0x16A0 */ public GcCameraFollowSettings CharacterSitCam;
        /* 0x17A0 */ public GcCameraFollowSettings CharacterRideCam;
        /* 0x18A0 */ public GcCameraFollowSettings CharacterRideCamMedium;
        /* 0x19A0 */ public GcCameraFollowSettings CharacterRideCamLarge;
        /* 0x1AA0 */ public GcCameraFollowSettings CharacterRideCamHuge;
        /* 0x1BA0 */ public float ThirdPersonCameraChangeBlendTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1BA4 */ public byte[] Padding1BA4;
        /* 0x1BA8 */ public GcCameraFollowSettings BuggyFollowCam;
        /* 0x1CA8 */ public GcCameraFollowSettings HovercraftFollowCam;
        /* 0x1DA8 */ public GcCameraFollowSettings SubmarineFollowCam;
        /* 0x1EA8 */ public GcCameraFollowSettings BikeFollowCam;
        /* 0x1FA8 */ public GcCameraFollowSettings WheeledBikeFollowCam;
        /* 0x20A8 */ public GcCameraFollowSettings TruckFollowCam;
        /* 0x21A8 */ public GcCameraFollowSettings MechFollowCam;
        /* 0x22A8 */ public GcCameraFollowSettings MechShootCam;
        /* 0x23A8 */ public GcCameraFollowSettings MechJetpackCam;
        /* 0x24A8 */ public GcCameraFollowSettings SpaceshipFollowCam;
        /* 0x25A8 */ public GcCameraFollowSettings DropshipFollowCam;
        /* 0x26A8 */ public GcCameraFollowSettings ShuttleFollowCam;
        /* 0x27A8 */ public GcCameraFollowSettings RoyalShipFollowCam;
        /* 0x28A8 */ public GcCameraFollowSettings ScienceShipFollowCam;
        /* 0x29A8 */ public GcCameraFollowSettings AlienShipFollowCam;
        /* 0x2AA8 */ public float FrontendModelCameraSpringTime;
        /* 0x2AAC */ public float ModelViewFlashTime;
        /* 0x2AB0 */ public Vector3f ModelViewOffset;
        /* 0x2AC0 */ public Vector2f ModelViewFocusOffset;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x2AC8 */ public byte[] Padding2AC8;
        /* 0x2AD0 */ public Vector3f InteractionOffset;
        /* 0x2AE0 */ public Vector3f InteractionOffsetExtraVR;
        /* 0x2AF0 */ public Vector3f InteractionOffsetExtraVRSeated;
        /* 0x2B00 */ public Vector3f InteractionOffsetDefault;
        /* 0x2B10 */ public Vector3f InteractionOffsetGek;
        /* 0x2B20 */ public Vector3f InteractionShipFocusOffset;
        /* 0x2B30 */ public Vector3f InteractionHailingFocusOffset;
        /* 0x2B40 */ public float InteractionHeadHeightDefault;
        /* 0x2B44 */ public float InteractionHeadHeightGek;
        /* 0x2B48 */ public float InteractionHeadHeightVykeen;
        /* 0x2B4C */ public float InteractionPitchAdjustTime;
        /* 0x2B50 */ public float InteractionPitchAdjustStrength;
        /* 0x2B54 */ public float InteractionPitchAdjustDeadZone;
        /* 0x2B58 */ public float InteractionHeadPosHeightAdjust;
        /* 0x2B5C */ public float NPCTradeLateralShiftAmount;
        /* 0x2B60 */ public float NPCTradeLateralShiftTime;
        /* 0x2B64 */ public float DistanceForFleetInteraction;
        /* 0x2B68 */ public float DistanceForFrigateInteraction;
        /* 0x2B6C */ public float DistanceForFrigatePurchaseInteraction;
        /* 0x2B70 */ public Vector3f OffsetForFleetInteraction;
        /* 0x2B80 */ public Vector3f OffsetForFrigateInteraction;
        /* 0x2B90 */ public float FleetUIOrbitRate;
        /* 0x2B94 */ public float FleetUIVerticalMotionDuration;
        /* 0x2B98 */ public float FleetUIVerticalMotionAmplitude;
        /* 0x2B9C */ public Vector2f PitchForFrigateInteraction;
        /* 0x2BA4 */ public Vector2f RotationForFrigateInteraction;
        /* 0x2BAC */ public float InteractionModeBlendTime;
        /* 0x2BB0 */ public float InteractionModeFocusCamBlend;
        /* 0x2BB4 */ public float InteractionModeFoV;
        /* 0x2BB8 */ public float MinInteractFocusAngle;
        /* 0x2BBC */ public float ModelViewInterpTime;
        /* 0x2BC0 */ public float ThirdPersonBlendInTime;
        /* 0x2BC4 */ public float ThirdPersonBlendOutTime;
        /* 0x2BC8 */ public float ThirdPersonCollisionPushOffsetReducerStart;
        /* 0x2BCC */ public float ThirdPersonOffsetSpringTime;
        /* 0x2BD0 */ public bool MaxBob;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x2BD1 */ public byte[] Padding2BD1;
        [NMSDescription("Speed of the camera when photo mode is active")]
        /* 0x2BD4 */ public float PhotoModeMoveSpeed;
        [NMSDescription("Turning speed of the camera when photo mode is active")]
        /* 0x2BD8 */ public float PhotoModeTurnSpeed;
        [NMSDescription("Boundary distance of the photo camera relative to the player on planet")]
        /* 0x2BDC */ public float PhotoModeMaxDistance;
        [NMSDescription("Boundary distance of the photo camera relative to the player in space")]
        /* 0x2BE0 */ public float PhotoModeMaxDistanceSpace;
        /* 0x2BE4 */ public float PhotoModeMaxDistanceClampForce;
        /* 0x2BE8 */ public float PhotoModeMaxDistanceClampBuffer;
        /* 0x2BEC */ public float PhotoModeCollisionRadius;
        /* 0x2BF0 */ public float PhotoModeRollSpeed;
        /* 0x2BF4 */ public float PhotoModeFlashDuration;
        /* 0x2BF8 */ public float PhotoModeFlashIntensity;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2BFC */ public byte[] Padding2BFC;
        /* 0x2C00 */ public Vector3f PhotoModeShipOffset;
        /* 0x2C10 */ public Vector3f BuildingModeInitialOffset;
        /* 0x2C20 */ public float BuildingModeMaxDistance;
        /* 0x2C24 */ public float RunningFoVAdjust;
        /* 0x2C28 */ public float MeleeBoostedFoV;
        /* 0x2C2C */ public float MeleeFoV;
        /* 0x2C30 */ public float AerialViewDownDistance;
        /* 0x2C34 */ public float AerialViewPause;
        /* 0x2C38 */ public float AerialViewStartTime;
        /* 0x2C3C */ public float AerialViewBackTime;
        /* 0x2C40 */ public float AerialViewBlendTime;
        /* 0x2C44 */ public TkCurveType AerialViewCurve;
        /* 0x2C48 */ public GcCameraAerialViewData BeaconTransition;
        /* 0x2C78 */ public GcCameraAerialViewData SignalTransition;
        /* 0x2CA8 */ public GcCameraAerialViewData WaypointTransition;
        /* 0x2CD8 */ public GcCameraAerialViewData RadioTowerTransition;
        /* 0x2D08 */ public float ScreenshotHorizonHeight;
        /* 0x2D0C */ public float ScreenshotHorizonFaceFactor;
        /* 0x2D10 */ public float ScreenshotBendDownAmount;
        /* 0x2D14 */ public float ScreenshotRightDistance;
        /* 0x2D18 */ public float ScreenshotBackDistance;
        /* 0x2D1C */ public float ScreenshotInTime;
        /* 0x2D20 */ public float ScreenshotOutTime;
        /* 0x2D24 */ public float ShipCamSpringStrengthMin;
        /* 0x2D28 */ public float ShipCamSpringStrengthMax;
        /* 0x2D2C */ public float ShipCamTurn;
        /* 0x2D30 */ public float ShipCamPitch;
        /* 0x2D34 */ public float ShipCamPitchMod;
        /* 0x2D38 */ public float ShipCamLookInterp;
        /* 0x2D3C */ public float ShipCamMinReturnTime;
        /* 0x2D40 */ public float ShipCamReturnTime;
        /* 0x2D44 */ public float ShipCamMotionTurn;
        /* 0x2D48 */ public float ShipCamMotionPitch;
        /* 0x2D4C */ public float ShipCamMotionPitchMod;
        /* 0x2D50 */ public float ShipCamMotionMaxLagTurnAngle;
        /* 0x2D54 */ public float ShipCamMotionMaxLagPitchAngle;
        /* 0x2D58 */ public float ShipCamMotionInterp;
        /* 0x2D5C */ public float ShipCamRollAmountMin;
        /* 0x2D60 */ public float ShipCamRollAmountMax;
        /* 0x2D64 */ public float ShipCamRollSpeedScaler;
        /* 0x2D68 */ public float ShipCamAimFOV;
        /* 0x2D6C */ public float MouseSensitivity;
        /* 0x2D70 */ public float ModelViewRotateSpeed;
        /* 0x2D74 */ public float ModelViewMouseRotateSpeed;
        /* 0x2D78 */ public float ModelViewMouseRotateSnapStrength;
        /* 0x2D7C */ public float ModelViewMouseMoveSpeed;
        /* 0x2D80 */ public float ModelViewDistSpeed;
        /* 0x2D84 */ public float ModelViewMinDist;
        /* 0x2D88 */ public float ModelViewMaxDist;
        /* 0x2D8C */ public float ModelViewDefaultPitch;
        /* 0x2D90 */ public float ModelViewDefaultYaw;
        /* 0x2D94 */ public bool DebugMoveCam;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x2D95 */ public byte[] Padding2D95;
        /* 0x2D98 */ public float DebugMoveCamSpeed;
        /* 0x2D9C */ public float DebugMoveCamHeight;
        /* 0x2DA0 */ public bool DebugAICam;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x2DA1 */ public byte[] Padding2DA1;
        /* 0x2DA4 */ public float DebugAICamUp;
        /* 0x2DA8 */ public float DebugAICamAt;
        /* 0x2DAC */ public float PainShakeTime;
        /* 0x2DB0 */ public float ShipShakeDamper;
        /* 0x2DB4 */ public float IndoorCamShakeDamper;
        /* 0x2DB8 */ public float FirstPersonSlerpAway;
        /* 0x2DBC */ public float FirstPersonSlerpTowards;
        [NMS(Size = 0x2C)]
        /* 0x2DC0 */ public GcCameraShakeData[] CameraShakeTable;
        /* 0x4EC0 */ public float BobAmountAbandFreighter;
        /* 0x4EC4 */ public float BobFactorAbandFreighter;
        /* 0x4EC8 */ public float BobAmount;
        /* 0x4ECC */ public float BobFactor;
        /* 0x4ED0 */ public float BobFocus;
        /* 0x4ED4 */ public float BobRollFactor;
        /* 0x4ED8 */ public float BobRollAmount;
        /* 0x4EDC */ public float BobRollOffset;
        /* 0x4EE0 */ public float BobFwdAmount;
        /* 0x4EE4 */ public float CamSeed1;
        /* 0x4EE8 */ public float CamSeed2;
        /* 0x4EEC */ public float CamWander1Phase;
        /* 0x4EF0 */ public float CamWander2Phase;
        /* 0x4EF4 */ public float CamWander1Amplitude;
        /* 0x4EF8 */ public float CamWander2Amplitude;
        /* 0x4EFC */ public float DebugSpaceStationTeleportOffset;
        /* 0x4F00 */ public float DebugCameraSlowFactor;
        /* 0x4F04 */ public float DebugCameraFastFactor;
        /* 0x4F08 */ public float DebugCameraSpaceFastFactor;
        /* 0x4F0C */ public float OffsetCamFOV;
        /* 0x4F10 */ public Vector3f OffsetCamOffset;
        /* 0x4F20 */ public Vector3f OffsetCamRotation;
        /* 0x4F30 */ public float ObjectFocusTime;
        /* 0x4F34 */ public float CharCamFocusHeight;
        /* 0x4F38 */ public float CharCamMaxDistance;
        /* 0x4F3C */ public float CharCamMinDistance;
        /* 0x4F40 */ public float CharCamHeight;
        /* 0x4F44 */ public float CharCamOffsetTime;
        /* 0x4F48 */ public float CharCamAutoDirStartTime;
        /* 0x4F4C */ public float CharCamLookOffset;
        /* 0x4F50 */ public float CharCamLookOffsetFactor;
        /* 0x4F54 */ public float CharCamDeflectSpeed;
        /* 0x4F58 */ public float CharCamMinSpeed;
        /* 0x4F5C */ public float CharCamRightStickX;
        /* 0x4F60 */ public float CharCamRightStickY;
        /* 0x4F64 */ public float FirstPersonCamHeight;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x4F68 */ public byte[] Padding4F68;
        [NMS(Size = 0x8)]
        /* 0x4F70 */ public Vector3f[] FirstPersonCamOffset;
        /* 0x4FF0 */ public Vector3f FirstPersonInShipCamOffset;
        /* 0x5000 */ public float FirstPersonFoV;
        /* 0x5004 */ public float ThirdPersonFoV;
        /* 0x5008 */ public float CombatFoV;
        /* 0x500C */ public float FirstPersonZoom1FoV;
        /* 0x5010 */ public float FirstPersonZoom2FoV;
        /* 0x5014 */ public float ShipFoVMin;
        /* 0x5018 */ public float ShipFoVMin2;
        /* 0x501C */ public float ShipFoVMax;
        /* 0x5020 */ public float ShipWarpFoV;
        /* 0x5024 */ public float ShipFoVMin3rdPerson;
        /* 0x5028 */ public float ShipFoVMax3rdPerson;
        /* 0x502C */ public float ShipFoVBoost;
        /* 0x5030 */ public float ShipFoVMiniJump;
        /* 0x5034 */ public float ShipFoVSpring;
        /* 0x5038 */ public float ShipMiniJumpFoVSpring;
        /* 0x503C */ public float FoVSpring;
        /* 0x5040 */ public float FoVSpringSights;
        /* 0x5044 */ public float FoVAdjust;
        /* 0x5048 */ public bool FollowDrawCamProbes;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x5049 */ public byte[] Padding5049;
        /* 0x504C */ public GcCameraAnimationData AmbientCameraAnimations;
        /* 0x50D0 */ public TkTextureResource AmbientDroneAnimations;
        [NMS(Size = 0x80)]
        /* 0x5154 */ public string CameraAmbientAnimationsData;
        /* 0x51D4 */ public float CameraAmbientAutoSwitchMinTime;
        /* 0x51D8 */ public float CameraAmbientAutoSwitchMaxTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x51DC */ public byte[] Padding51DC;
        /* 0x51E0 */ public TkModelRendererData CameraNPCShipInteraction;
        /* 0x5290 */ public TkModelRendererData CameraNPCShopInteraction;
        [NMS(Size = 0x4)]
        /* 0x5340 */ public TkPhysRelVectorData[] SavedCameraPositions;
        [NMS(Size = 0x4)]
        /* 0x53C0 */ public Vector3f[] SavedCameraFacing;
        /* 0x5400 */ public GcCameraWarpSettings WarpSettings;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x5454 */ public byte[] EndPadding;
    }
}
