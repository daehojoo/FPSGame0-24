using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{

    public float Speed = 1500f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {                     //Vector3.forward 글로벌좌표
        rb.AddForce(transform.forward * Speed);
        //로컬 좌표로 스피드 만큼 나간다.
        Destroy(this.gameObject, 3.0f);
        //자기자신의 오브젝트를 3초후에 메모리에서 삭제한다.
                  
    }

    // Update is called once per frame
   
}
