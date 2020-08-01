using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class AngleControl : MonoBehaviour
{


    [Range(0, 360f)]
    public float angleController;
    
    private Material fanMarterial;
    private Renderer TargetRenderer;


    void Start()
    {
        
        //fanMarterial=GetComponent<MeshRenderer>().material;
      
    }


    void Update()
    {
        //fanMarterial.SetFloat("_Angle", angleController);
        
    }



    public void OnSliderUpdateBlue(SliderEventData eventData)
        {
            TargetRenderer = GetComponentInChildren<Renderer>();
            if ((TargetRenderer != null) && (TargetRenderer.material != null))
            {
                
                angleController=eventData.NewValue*360;
                TargetRenderer.material.SetFloat("_Angle", angleController);
          
                //TargetRenderer.material.color = new Color(TargetRenderer.sharedMaterial.color.r, TargetRenderer.sharedMaterial.color.g, eventData.NewValue);
            }
        }

        



}
