// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class HorizonTweenDemoTarget : TargetRules
{
	public HorizonTweenDemoTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;

        ExtraModuleNames.AddRange(new string[] { "HorizonTweenDemo" });
        DefaultBuildSettings = BuildSettingsVersion.V2;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        // ShadowVariableWarningLevel = WarningLevel.Error;
    }

}
