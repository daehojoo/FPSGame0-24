using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointlight : MonoBehaviour
{
    public Light Light;
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Light.enabled = true;
            source.PlayOneShot(clip,1.0f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Light.enabled = false;
            source.PlayOneShot(clip,1.0f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        
    }
}
