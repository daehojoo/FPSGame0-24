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
    {                     //Vector3.forward �۷ι���ǥ
        rb.AddForce(transform.forward * Speed);
        //���� ��ǥ�� ���ǵ� ��ŭ ������.
        Destroy(this.gameObject, 3.0f);
        //�ڱ��ڽ��� ������Ʈ�� 3���Ŀ� �޸𸮿��� �����Ѵ�.
                  
    }

    // Update is called once per frame
   
}
