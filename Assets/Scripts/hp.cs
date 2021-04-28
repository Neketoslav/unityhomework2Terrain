using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour
{
    [SerializeField]
    private GUIStyle _style;
    [SerializeField]
    private GUIStyle _styleHp;
    private float hpcount = 100;
    
    private void OnGUI()
    {
        GUI.Box(new Rect(10, Screen.height*0.9f, 200, 30), "", _style);
        GUI.Box(new Rect(10, Screen.height * 0.9f, hpcount * 2, 30), "", _styleHp);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) // получить 10 урона
        {
            hpcount -= 10;
            if (hpcount < 0)
            {
                hpcount = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.E)) // получить 10 очков здоровья
        {
            hpcount += 10;
            if(hpcount > 100)
            {
                hpcount = 100;
            }
        }
    }
}
