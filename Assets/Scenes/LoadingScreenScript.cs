using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenScript : MonoBehaviour
{
    public int phase = 0;
    public RawImage loadingObj;
    public GameObject loadingGameObj;
    public RawImage logoObj;
    public float speed;
    bool isDestroyed = false;
    

    void Update()
    {
        if(loadingObj.color == Color.white) phase = 1;
        if ((loadingObj.color == Color.black) && (phase == 1)){ phase = 2; if(!isDestroyed){GameObject.Destroy(loadingGameObj); isDestroyed = true; }}
        if ((logoObj.color == Color.white) && (phase == 2)) phase = 3;
        if ((logoObj.color == Color.black) && (phase == 3)) phase = 4;
        if (phase == 4); //Presun na hlavnu scenu

        switch (phase){
            case 0: loadingObj.color = Color.Lerp(loadingObj.color, Color.white, speed * Time.deltaTime); break;
            case 1: loadingObj.color = Color.Lerp(loadingObj.color, Color.black, speed * Time.deltaTime); break;
            case 2: logoObj.color = Color.Lerp(logoObj.color, Color.white, speed * Time.deltaTime); break;
            case 3: logoObj.color = Color.Lerp(logoObj.color, Color.black, speed * Time.deltaTime); break;
        }
    }
}
