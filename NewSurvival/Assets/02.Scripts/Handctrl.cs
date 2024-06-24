using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handctrl : MonoBehaviour
{
    public Animation CombatSGAni;
    public Light flashLight;
    public AudioClip flashSound; //��������
    public AudioSource A_source;  //�Ҹ��� ���� ����� �ҽ�
    void Start() //���� ������ ȣ��Ǵ� ����
    {
        
    }

    
    void Update() //���� ������ ��� ȣ��Ǵ� ����
    {
        GunCtrl();
        FlashLightOnOff();
    }

    private void FlashLightOnOff()
    {
        //Ű���� FŰ�� �����ٸ�
            if (Input.GetKeyDown(KeyCode.F))
            {
                flashLight.enabled = !flashLight.enabled;
                A_source.PlayOneShot(flashSound, 1.0f);
                //�ѹ��� ����� �Ҹ�����, �Ҹ�����(1.0�� ����ŭ)
            }
    }

    private void GunCtrl()
    {
        //���� ����ƮŰ�� WŰ�� ���ÿ������ٸ�
        if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
            CombatSGAni.Play("running");
        //���� ����Ʈ Ű�� ����ٸ�
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            CombatSGAni.Play("runStop");
        //GetKey() ������ ����
        //GetKeyDown() �����ٸ��Ѿ� �߻��
        //GetKeyup() ���� �� ����ٸ�
        //��ũ��Ʈ���� �ִϸ��̼��� ȣ���ϴ� ����� ���Ž� ���
    }
}
