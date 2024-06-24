using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public Light StairLight;
    public AudioSource source;
    public AudioClip clip;
    
    void Start()
    {
        

    }

    //is Trigger 했을 떄 통과하면서 충돌 감지
    // 하는 함수 콜백 함수라고 함 스스로 호출 하기때문 (콜백 함수 : 알아서 스스로 호출함)
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player")
        {
            StairLight.enabled = true;
            //충돌체의 테그검사를 한 후 맞으면 라이트 온
            source.PlayOneShot(clip,1.0f);
        }
    }

    // 콜라이더 범위에 들어왔다가 빠져 나갔을 떄
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        { StairLight.enabled = false;
            source.PlayOneShot(clip, 1.0f);
        }
    }
    void Update()
    {
        
    }
}
