using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    private float timer = 0;
    private string s;
    private int val = 10, sec = 2;
    void Update()
    {
        timer += Time.deltaTime;
        if ( timer >= sec ) {
            s = val.ToString();
            GetComponent<TMP_Text>().text = s;
            sec += 2;
            val += 10;
        }
    }
}
