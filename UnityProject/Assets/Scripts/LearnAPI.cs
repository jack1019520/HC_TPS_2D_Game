using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform transformA;
    public Transform transformB;
    public Camera cam;
    public AudioSource aud;

    

    private void Start()
    {
        //使用靜態成員
        print("隨機:"+Random.value);

        //使用靜態成員-屬性 數學類別.PI(Mathf)
        print("PI:" + Mathf.PI);

        //使用靜態成員-方法
        print("隨機範圍:" + Random.Range(1, 100));

        print("絕對值:" + Mathf.Abs(-99));

        //非靜態成員-屬性
        //需要先給予欄位存放時體物件
        print("物件A的座標:" + transformA.position);
        print("物件A的座標:" + transformB.position);

        print("攝影機的深度:" + cam.depth);

        aud.Stop();
         
    }


}
