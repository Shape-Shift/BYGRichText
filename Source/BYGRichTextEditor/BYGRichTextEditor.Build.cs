using UnrealBuildTool;

public class BYGRichTextEditor : ModuleRules
{
	public BYGRichTextEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateIncludePathModuleNames.AddRange(
			new string[] {
			}
		);

 

		PrivateDependencyModuleNames.AddRange(
			new string[] {
				"Core",
				"CoreUObject",
				"Engine",
				"Slate",
				"UnrealEd",
				"UMG",
                "SlateCore",
				"BYGRichText",
                "EditorStyle",
				"SlateCore",
                "Projects",
				"PropertyEditor",
				"EditorSubsystem",
				"EditorWidgets",
				"DeveloperSettings",
				"RenderCore",
				"FunctionalTesting",
				"DataValidation",
				"KismetCompiler",
				"BlueprintGraph"
            }
        );

		DynamicallyLoadedModuleNames.AddRange(
			new string[] {
			}
		);
	}
}
