using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class RotateObject : MonoBehaviour
{
    public float rotateSpeed=1;
    public bool isRotating = true;

    public GameObject fanAngle;


    void Start() {

        isRotating=true;
        
    }
    

    void Update() {

            if(Input.GetMouseButtonDown(2)){
                if(isRotating==true){
                    isRotating=false;
                }
                else{
                    isRotating=true;
                }

            }
            if(isRotating==true){


            purification();

  


            }
            
        }

        public void OnSliderUpdate(SliderEventData eventData)
        {
         
                rotateSpeed=eventData.NewValue;

        }
    
    public void purification(){


            float rotateAngleY = fanAngle.GetComponent<AngleControl>().angleController/2;
            float rotateY = Mathf.SmoothStep(-180-rotateAngleY, -180+rotateAngleY, Mathf.PingPong(Time.time*rotateSpeed, 1));
            transform.rotation=Quaternion.Euler(0, rotateY, 0);

            }


    }








