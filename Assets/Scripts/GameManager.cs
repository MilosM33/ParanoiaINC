using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float currentTime = 0;

    void Start()
    {
        
    }

    public TextMeshProUGUI timer;
    void Update()
    {
        if (timer.transform.parent.gameObject.activeInHierarchy)
        {
            timer.text = Mathf.Round(currentTime).ToString() + "s";

            currentTime += Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
