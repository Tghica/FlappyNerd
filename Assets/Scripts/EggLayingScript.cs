using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggLayingScript : MonoBehaviour
{
    public GameObject egg;
    public void SpawnEgg()
    {
        Instantiate(egg, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), Quaternion.identity);
    }
}
