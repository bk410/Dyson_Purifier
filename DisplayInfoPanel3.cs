using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInfoPanel3 : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject InfoPanel3;
   public GameObject InfoPanel1;
   public GameObject InfoPanel2;
   public GameObject InfoPanel4;
    void Start()
    {
        
        InfoPanel1.SetActive(false);
        InfoPanel2.SetActive(false);
        InfoPanel3.SetActive(true);
        InfoPanel4.SetActive(false);
        
    }

    // Update is called once per frame

    public void ShowPanel1(){

        InfoPanel1.SetActive(true);
        InfoPanel2.SetActive(false);
        InfoPanel3.SetActive(false);

    }

        public void ShowPane2(){

        InfoPanel1.SetActive(false);
        InfoPanel2.SetActive(true);
        InfoPanel3.SetActive(false);

    }


        public void ShowPane3(){

        InfoPanel1.SetActive(false);
        InfoPanel2.SetActive(false);
        InfoPanel3.SetActive(true);

    }


        public void ShowPane4(){

        InfoPanel1.SetActive(false);
        InfoPanel2.SetActive(false);
        InfoPanel3.SetActive(false);
        InfoPanel3.SetActive(true);

    }
}
