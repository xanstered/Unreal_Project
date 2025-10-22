// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class My_UE_Project : ModuleRules
{
	public My_UE_Project(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"My_UE_Project",
			"My_UE_Project/Variant_Platforming",
			"My_UE_Project/Variant_Platforming/Animation",
			"My_UE_Project/Variant_Combat",
			"My_UE_Project/Variant_Combat/AI",
			"My_UE_Project/Variant_Combat/Animation",
			"My_UE_Project/Variant_Combat/Gameplay",
			"My_UE_Project/Variant_Combat/Interfaces",
			"My_UE_Project/Variant_Combat/UI",
			"My_UE_Project/Variant_SideScrolling",
			"My_UE_Project/Variant_SideScrolling/AI",
			"My_UE_Project/Variant_SideScrolling/Gameplay",
			"My_UE_Project/Variant_SideScrolling/Interfaces",
			"My_UE_Project/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
