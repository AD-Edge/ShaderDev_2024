using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

//Tutorial credit:
//https://www.youtube.com/watch?v=oLyv3NSpPeg

[Serializable, VolumeComponentMenuForRenderPipeline
    ("Shaders2024/00_CustomPostScreenASCII", typeof(UniversalRenderPipeline))]

public class CustomPostScreenASCII : VolumeComponent, IPostProcessComponent
{
    public FloatParameter tintIntensity = new FloatParameter(1);
    public ColorParameter tintColor = new ColorParameter(Color.white);

    public bool IsActive() => true;
    public bool IsTileCompatible() => true;
}