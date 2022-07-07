using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundRotationsScript : MonoBehaviour
{
    public float speed = 3;

    private float limitx = -17.90f;
    private Vector3 p;
    public Vector3 pos;
    void Update()
    {
        pos = transform.position;
        pos.x -= speed * Time.deltaTime;
        transform.position = pos;
        if (transform.position.x <= limitx)
        {
            p = transform.position;
            p.x = -p.x;
            transform.position = p;
        }
    }
}
