using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handctrl : MonoBehaviour
{
    public Animation CombatSGAni;
    public Light flashLight;
    public AudioClip flashSound; //사운드파일
    public AudioSource A_source;  //소리가 난곳 오디오 소스
    void Start() //게임 시작전 호출되는 공간
    {
        
    }

    
    void Update() //게임 시작후 계속 호출되는 공간
    {
        GunCtrl();
        FlashLightOnOff();
    }

    private void FlashLightOnOff()
    {
        //키보드 F키를 눌렀다면
            if (Input.GetKeyDown(KeyCode.F))
            {
                flashLight.enabled = !flashLight.enabled;
                A_source.PlayOneShot(flashSound, 1.0f);
                //한번만 울려라 소리파일, 소리볼륨(1.0이 가장큼)
            }
    }

    private void GunCtrl()
    {
        //왼쪽 쉬프트키와 W키를 동시에눌렀다면
        if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
            CombatSGAni.Play("running");
        //왼쪽 쉬프트 키를 띄었다면
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            CombatSGAni.Play("runStop");
        //GetKey() 누르는 동안
        //GetKeyDown() 눌렀다면총알 발사시
        //GetKeyup() 누른 후 띄었다면
        //스크립트에서 애니메이션을 호출하는 방식이 레거시 방식
    }
}
