using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bulletPrefab; //총알 오브젝트 그자체
    public Transform firePos; //발사되는 위치
    public Animation FireAni; //총알발사 애니메이션
    public AudioSource source;
    public AudioClip firlclip;
    private float firlTime;
    public Handctrl handctrl;
    void Start()
    {
        handctrl = this.gameObject.GetComponent<Handctrl>();
        firlTime= Time.time;
        //       <-현재 시간을 대입
    }

    
    void Update()
    {
        #region 한발씩 발사하는 로직
        //마우스 왼쪽 버튼 눌렀을 때 0  1은 오른쪽 2는 마우스 휠
        //if (Input.GetMouseButtonDown(0))
        //    Fire();//발사 함수 호출
        #endregion
        #region 연사하는 로직 //연사는 시간단위로 조절이 필요함
        if (Input.GetMouseButton(0))
        {
            //현재시간에서 과거시간을 빼면 흘러간 시간이 된다.
            if (Time.time - firlTime > 0.1f)
            {
                if(handctrl.isRun==false)
                Fire();
                firlTime = Time.time;
            }

        }
        #endregion
    }
    void Fire()//총알 발사 함수
    {   //오브젝트 생성 함수
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        //               what         where               how
        source.PlayOneShot(firlclip, 1.0f);
        FireAni.Play("fire");
    }
}
