using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerSpark : MonoBehaviour
{

    public GameObject SparkPrefab;
    public AudioSource source;
    public AudioClip clip;

   
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag =="BULLET")
        {
            Destroy(col.gameObject);
            source.PlayOneShot(clip, 1.0f);
                var spark = Instantiate(SparkPrefab,col.transform.position,Quaternion.identity);
            Destroy(spark, 2.0f);

        }
    }


}
