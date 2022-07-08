using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCrackScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Eggs"))
            return;


        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        Destroy(GetComponent<Rigidbody2D>());

        Transform child = transform.GetChild(0);
        child.GetComponent<SpriteRenderer>().enabled = true;
        child.gameObject.AddComponent<CapsuleCollider2D>();
        child.gameObject.AddComponent<Rigidbody2D>();

        Destroy(gameObject, 5.0f);
    }
}
