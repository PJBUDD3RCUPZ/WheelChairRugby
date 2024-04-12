using UnrealBuildTool;

public class WheelchairRugbyTarget : TargetRules
{
	public WheelchairRugbyTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("WheelchairRugby");
	}
}
