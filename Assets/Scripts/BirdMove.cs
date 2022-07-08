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
    public GameObject music;
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
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Eggs"))
        {
            return;
        }
        if (lost == false)
         music.GetComponent<AudioSource>().Play();
        lost = true;
        GetComponent<Rigidbody2D>().gravityScale = 1;
        GetComponent<Collider2D>().isTrigger = false;
    } 
}
