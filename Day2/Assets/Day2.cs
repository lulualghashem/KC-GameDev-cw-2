using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DAY2 : MonoBehaviour
{

    string Heroname = "Lulu";
    int Heropower = 200;
    //
    string villainName = "Shadow";
    int villainPower = 140;
    float playerspeed = 2.7f;
    // Start is called before the first frame update
    void Start()
    {
        if (Heropower >= villainPower)
        {
            print("heroPower stronger than villainPower");
        }
        else if (Heropower < villainPower)
        {
            print("villainPower stronger than heroPower");
        }
        SetSpeed(2.5F);
    }

    // Update is called once per frame
    void Update()
    {

    }





    void SetSpeed(float speed)
    {
        playerspeed = speed;
    }
    void CompareSpeed(float speed1, float speed2)
    {
        if (speed1 > speed2)
        {
            print("speed1 is faster than speed2");
        }
        else if (speed1 < speed2)
        {
            print("speed2 is fastest than speed1");
        }
        else if (speed1 == speed2) ;
        {
            print("speed1 = speed2");
        }
    }
}















