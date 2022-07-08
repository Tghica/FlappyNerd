using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChangeScript : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene(1);
    }
}
