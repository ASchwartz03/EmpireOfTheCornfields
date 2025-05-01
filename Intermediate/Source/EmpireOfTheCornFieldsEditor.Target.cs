using UnrealBuildTool;

public class EmpireOfTheCornFieldsEditorTarget : TargetRules
{
	public EmpireOfTheCornFieldsEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("EmpireOfTheCornFields");
	}
}
