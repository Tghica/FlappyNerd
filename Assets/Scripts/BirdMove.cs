using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public float initialSpeed;
    public float gravity;
    public float limitRotation;
    private float currentSpeed;
    private float timerRotation;
    private float unghi;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentSpeed = initialSpeed;
        }
        currentSpeed -= gravity * Time.deltaTime;
        transform.position += new Vector3(0f, currentSpeed * Time.deltaTime, 0f);


        timerRotation += Time.deltaTime;
        if (timerRotation > limitRotation)
        {
            timerRotation = 0f;
            if (currentSpeed < 0f)
            {
                unghi -= 20f;
                transform.rotation = Quaternion.Euler(0f, 0f, unghi);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(1);
        gravity = 0f;
        currentSpeed = 0;
        initialSpeed = 0;
    }
}
