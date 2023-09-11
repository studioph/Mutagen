using Mutagen.Bethesda.Starfield;

namespace Loqui;

internal class ProtocolDefinition_Starfield : IProtocolRegistration
{
    public static readonly ProtocolKey ProtocolKey = new("Starfield");
    void IProtocolRegistration.Register() => Register();
    public static void Register()
    {
        LoquiRegistration.Register(
            ModStats_Registration.Instance,
            TransientType_Registration.Instance,
            LocationReferenceType_Registration.Instance,
            StarfieldGroup_Registration.Instance,
            StarfieldMajorRecord_Registration.Instance,
            StarfieldMod_Registration.Instance,
            Npc_Registration.Instance,
            Weapon_Registration.Instance,
            Model_Registration.Instance,
            StarfieldModHeader_Registration.Instance,
            GameSetting_Registration.Instance,
            GameSettingInt_Registration.Instance,
            GameSettingFloat_Registration.Instance,
            GameSettingString_Registration.Instance,
            GameSettingBool_Registration.Instance,
            GameSettingUInt_Registration.Instance,
            Keyword_Registration.Instance,
            AttractionRule_Registration.Instance,
            FFKWRecord_Registration.Instance,
            Component_Registration.Instance,
            ActionRecord_Registration.Instance,
            Transform_Registration.Instance,
            ObjectBounds_Registration.Instance,
            TextureSet_Registration.Instance,
            Global_Registration.Instance,
            Attack_Registration.Instance,
            AttackData_Registration.Instance,
            DamageTypeItem_Registration.Instance,
            DamageType_Registration.Instance,
            ObjectProperty_Registration.Instance,
            ActorValueInformation_Registration.Instance,
            Class_Registration.Instance,
            CurveTable_Registration.Instance,
            LocationTargetRadius_Registration.Instance,
            ALocationTarget_Registration.Instance,
            LocationTarget_Registration.Instance,
            LocationCell_Registration.Instance,
            LocationObjectId_Registration.Instance,
            LocationObjectType_Registration.Instance,
            LocationKeyword_Registration.Instance,
            LocationFallback_Registration.Instance,
            Relation_Registration.Instance,
            Cell_Registration.Instance,
            Faction_Registration.Instance,
            CrimeValues_Registration.Instance,
            VendorValues_Registration.Instance,
            FormList_Registration.Instance,
            PlacedObject_Registration.Instance,
            VoiceType_Registration.Instance,
            AffinityEvent_Registration.Instance,
            ActorReaction_Registration.Instance,
            HeadPart_Registration.Instance,
            MRPHRecord_Registration.Instance,
            Static_Registration.Instance,
            AOPFRecord_Registration.Instance,
            SeasonalIngredientProduction_Registration.Instance,
            Armor_Registration.Instance,
            BodyPartData_Registration.Instance,
            EquipType_Registration.Instance,
            ImpactDataSet_Registration.Instance,
            MaterialType_Registration.Instance,
            MovementType_Registration.Instance,
            Race_Registration.Instance,
            BodyData_Registration.Instance,
            MovementDataOverride_Registration.Instance,
            MovementData_Registration.Instance,
            MovementDirectionData_Registration.Instance,
            MovementRotationData_Registration.Instance,
            EquipmentSlot_Registration.Instance,
            Spell_Registration.Instance,
            SkeletalModel_Registration.Instance,
            AimAssistPose_Registration.Instance,
            BipedObjectData_Registration.Instance,
            HeadData_Registration.Instance,
            NeckFatAdjustmentsScale_Registration.Instance,
            MorphGroup_Registration.Instance,
            FaceMorph_Registration.Instance,
            FaceMorphItem_Registration.Instance,
            FDSIRecord_Registration.Instance
        );
    }
}
