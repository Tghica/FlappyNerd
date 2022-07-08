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
    public bool lost = false;
    void Update()
    {
        if (lost == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<EggLayingScript>().SpawnEgg();
                currentSpeed = initialSpeed;
            }
            currentSpeed -= gravity * Time.deltaTime;
            transform.position += new Vector3(0f, currentSpeed * Time.deltaTime, 0f);
            Debug.Log(1);
            /*
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
            */
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Eggs"))
        {
            return;
        }

        lost = true;
        GetComponent<Rigidbody2D>().gravityScale = 1;
        GetComponent<Collider2D>().isTrigger = false;
    } 
}
