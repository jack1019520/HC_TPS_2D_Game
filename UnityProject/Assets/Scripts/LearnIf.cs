using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool test;
    public string prop;

    // 更新事件:一秒執行60次
    private void Update()
    {
        //判斷式 if 語法
        //(布林值) {陳述事或演算法}
        //()裡面的布林值為true才會執行{}
        if (test)
        {
            print("打開開關");
        }
        //()裡面的布林值為false 才會執行else{}
        else
        {
            print("關閉開關");
        }
        if( prop == "紅色藥水")
        {
            print("補血");
        }
        else if (prop == "藍色藥水")
        {
            print("補魔力");
        }
        else if (prop=="黃色藥水")
        {
            print("補體力");
        }
        else
        {
            print("沒發生什麼是");
        }
    }
}
