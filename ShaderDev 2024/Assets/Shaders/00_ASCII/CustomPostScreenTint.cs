using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

//Tutorial credit:
//https://www.youtube.com/watch?v=oLyv3NSpPeg

[Serializable, VolumeComponentMenuForRenderPipeline
    ("Testing/CustomPostScreenTint", typeof(UniversalRenderPipeline))]

public class CustomPostScreenTint : VolumeComponent, IPostProcessComponent
{
    public FloatParameter tintIntensity = new FloatParameter(1);
    public ColorParameter tintColor = new ColorParameter(Color.white);

    public bool IsActive() => true;
    public bool IsTileCompatible() => true;
}