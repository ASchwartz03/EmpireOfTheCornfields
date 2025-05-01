using UnrealBuildTool;

public class EmpireOfTheCornFields : ModuleRules
{
	public EmpireOfTheCornFields(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
