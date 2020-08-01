using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreSetAngleControl : MonoBehaviour
{
    
    private int preSetFanAngle;

    private Material fanMarterial;
    private Renderer TargetRenderer;
    public GameObject customizedFan;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        
    }


        public void preSetFanAngle0()
        {
                customizedFan.SetActive(false);

                TargetRenderer = GetComponentInChildren<Renderer>();
                if ((TargetRenderer != null) && (TargetRenderer.material != null))
            {

                TargetRenderer.material.SetFloat("_Angle", 0);
          
               
            }
                

        }
        public void preSetFanAngle45()
        {
            customizedFan.SetActive(false);
                TargetRenderer = GetComponentInChildren<Renderer>();
                if ((TargetRenderer != null) && (TargetRenderer.material != null))
            {

                TargetRenderer.material.SetFloat("_Angle", 45);
          
               
            }

        }

        public void preSetFanAngle90()
        {
            customizedFan.SetActive(false);
                TargetRenderer = GetComponentInChildren<Renderer>();
                if ((TargetRenderer != null) && (TargetRenderer.material != null))
            {

                TargetRenderer.material.SetFloat("_Angle", 90);
          
               
            }

        }

         public void preSetFanAngle135()
        {
            customizedFan.SetActive(false);
                TargetRenderer = GetComponentInChildren<Renderer>();
                if ((TargetRenderer != null) && (TargetRenderer.material != null))
            {

                TargetRenderer.material.SetFloat("_Angle", 135);
          
               
            }

        }

        public void preSetFanAngle180()
        {
            customizedFan.SetActive(false);
                TargetRenderer = GetComponentInChildren<Renderer>();
                if ((TargetRenderer != null) && (TargetRenderer.material != null))
            {

                TargetRenderer.material.SetFloat("_Angle", 180);
          
               
            }

        }

        public void preSetFanAngle225()
        {
            customizedFan.SetActive(false);
                TargetRenderer = GetComponentInChildren<Renderer>();
                if ((TargetRenderer != null) && (TargetRenderer.material != null))
            {

                TargetRenderer.material.SetFloat("_Angle", 225);
          
               
            }

        }

        public void preSetFanAngle270()
        {
            customizedFan.SetActive(false);
                TargetRenderer = GetComponentInChildren<Renderer>();
                if ((TargetRenderer != null) && (TargetRenderer.material != null))
            {

                TargetRenderer.material.SetFloat("_Angle", 270);
          
               
            }

        }

        public void preSetFanAngle315()
        {
            customizedFan.SetActive(false);
                TargetRenderer = GetComponentInChildren<Renderer>();
                if ((TargetRenderer != null) && (TargetRenderer.material != null))
            {

                TargetRenderer.material.SetFloat("_Angle", 315);
          
               
            }

        }

        
}
