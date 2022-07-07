using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnimation : MonoBehaviour
{
    public Sprite[] state = new Sprite[3];
    private int cur = 0;
    public float limitSprite;
    private float timerSprite;
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = state[cur];
    }
    
    void Update()
    {
        timerSprite += Time.deltaTime;
        if(timerSprite > limitSprite)
        {
            cur = (cur + 1) % 3;
            GetComponent<SpriteRenderer>().sprite = state[cur];
            timerSprite = 0f;
        }
    }
}
