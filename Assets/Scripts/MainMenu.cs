using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        
    }

    public List<Transform> DestroyObjects;
    public Transform canvas;
    void Update()
    {
        if (Input.anyKey)
        {
            foreach (var transform in DestroyObjects)
            {
                Destroy(transform.gameObject);
            }
            canvas.gameObject.SetActive(true);

        }
    }
}
