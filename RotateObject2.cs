using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject2 : MonoBehaviour
{
public float rotateSpeed=0.09f;    
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


    
    public void purification(){


            float rotateAngleY = fanAngle.GetComponent<Renderer>().material.GetFloat("_Angle")/2;
            float rotateY = Mathf.SmoothStep(-180-rotateAngleY, -180+rotateAngleY, Mathf.PingPong(Time.time*rotateSpeed, 1));
            transform.rotation=Quaternion.Euler(0, rotateY, 0);

            }

}
