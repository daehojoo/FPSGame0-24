using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bulletPrefab; //�Ѿ� ������Ʈ ����ü
    public Transform firePos; //�߻�Ǵ� ��ġ
    public Animation FireAni; //�Ѿ˹߻� �ִϸ��̼�
    public AudioSource source;
    public AudioClip firlclip;
    private float firlTime;
    public Handctrl handctrl;
    void Start()
    {
        handctrl = this.gameObject.GetComponent<Handctrl>();
        firlTime= Time.time;
        //       <-���� �ð��� ����
    }

    
    void Update()
    {
        #region �ѹ߾� �߻��ϴ� ����
        //���콺 ���� ��ư ������ �� 0  1�� ������ 2�� ���콺 ��
        //if (Input.GetMouseButtonDown(0))
        //    Fire();//�߻� �Լ� ȣ��
        #endregion
        #region �����ϴ� ���� //����� �ð������� ������ �ʿ���
        if (Input.GetMouseButton(0))
        {
            //����ð����� ���Žð��� ���� �귯�� �ð��� �ȴ�.
            if (Time.time - firlTime > 0.1f)
            {
                if(handctrl.isRun==false)
                Fire();
                firlTime = Time.time;
            }

        }
        #endregion
    }
    void Fire()//�Ѿ� �߻� �Լ�
    {   //������Ʈ ���� �Լ�
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        //               what         where               how
        source.PlayOneShot(firlclip, 1.0f);
        FireAni.Play("fire");
    }
}
