using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LightOnOff : MonoBehaviour
{
    public Animation CombatSGAni;
    public Light Light;
    public AudioSource source;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NewMethod();
        if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
            CombatSGAni.Play("running");
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            CombatSGAni.Play("runStop");


    }

    private void NewMethod()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Light.enabled = !Light.enabled;
            source.PlayOneShot(clip, 1.0f);
        }
    }
}
