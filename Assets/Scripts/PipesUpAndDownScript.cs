using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesUpAndDownScript : MonoBehaviour
{
    public float speed = 4;

    private float limitx = -9.65f;
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
            p.y = Random.Range(-1.5f, 2f);
            p.x = -p.x;
            transform.position = p;
        }
    }
}
