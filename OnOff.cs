using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    public ParticleSystem ps;

    private void Awake() {

        ps.Stop();
        
    }




    void Start () {


    }
     
    public void OnOffParticle () {

        ps = GetComponent<ParticleSystem> ();
        if (ps.isPlaying)
            ps.Stop ();
         else
            ps.Play ();
 
    }







}
