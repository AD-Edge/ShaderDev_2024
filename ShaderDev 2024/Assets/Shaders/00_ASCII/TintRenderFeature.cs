using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class TintRenderFeature : ScriptableRendererFeature
{
    private TintPass tintPass;

    public override void Create()
    {
        tintPass = new TintPass();
        //throw new NotImplementedException();
    }


    public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
    {
        renderer.EnqueuePass(tintPass);
        //throw new NotImplementedException();
    }

    class TintPass : ScriptableRenderPass
    {

        private Material _mat;

        public TintPass()
        {
            if(!_mat) {
                _mat = CoreUtils.CreateEngineMaterial("Custom/SHDR_TintGreyScale");
            }
            renderPassEvent = RenderPassEvent.BeforeRenderingPostProcessing;
        }

        public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
        {
            base.OnCameraSetup(cmd, ref renderingData);
        }

        public override void OnCameraCleanup(CommandBuffer cmd)
        {
            base.OnCameraCleanup(cmd);
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {

        }
    }

}