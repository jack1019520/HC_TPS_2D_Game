using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour
{
    
    [Range(1, 100)]
    public int HP;
    private void Update()
    {
        if (HP>0&&HP<=20)
        {
            print("快死了");
        }
        else if(HP>20&&HP<=50)
        {
            print("危險");
        }
        else if(HP>50&&HP<=70)
        {
            print("警告");
        }
        else if(HP>70&&HP<=100)
        {
            print("安全");
        }        

        
    }
}
