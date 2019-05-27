using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DestroyTimeout : MonoBehaviour
{
     public float timer = 6.0f;
    void Start()
    {
        Destroy(gameObject, timer);

    }
}