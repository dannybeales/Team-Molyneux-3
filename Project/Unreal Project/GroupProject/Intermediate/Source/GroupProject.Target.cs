using UnrealBuildTool;

public class GroupProjectTarget : TargetRules
{
	public GroupProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("GroupProject");
	}
}
