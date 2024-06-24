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

    //is Trigger ���� �� ����ϸ鼭 �浹 ����
    // �ϴ� �Լ� �ݹ� �Լ���� �� ������ ȣ�� �ϱ⶧�� (�ݹ� �Լ� : �˾Ƽ� ������ ȣ����)
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player")
        {
            StairLight.enabled = true;
            //�浹ü�� �ױװ˻縦 �� �� ������ ����Ʈ ��
            source.PlayOneShot(clip,1.0f);
        }
    }

    // �ݶ��̴� ������ ���Դٰ� ���� ������ ��
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
