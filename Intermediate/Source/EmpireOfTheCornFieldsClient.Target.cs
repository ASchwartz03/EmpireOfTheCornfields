using UnrealBuildTool;

public class EmpireOfTheCornFieldsClientTarget : TargetRules
{
	public EmpireOfTheCornFieldsClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("EmpireOfTheCornFields");
	}
}
