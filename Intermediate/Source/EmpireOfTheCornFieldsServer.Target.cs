using UnrealBuildTool;

public class EmpireOfTheCornFieldsServerTarget : TargetRules
{
	public EmpireOfTheCornFieldsServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("EmpireOfTheCornFields");
	}
}
