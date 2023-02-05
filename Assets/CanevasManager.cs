using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanevasManager : MonoBehaviour
{
    [SerializeField]
    UnityEngine.UI.Image map;
    [SerializeField]
    UnityEngine.UI.RawImage video;
    [SerializeField]
    UnityEngine.UI.Image tuto;
    [SerializeField]
    UnityEngine.UI.Image exit;
    // Start is called before the first frame update
    void Start()
    {
        
        map.rectTransform.localScale = new Vector2(Screen.width/map.rectTransform.sizeDelta.x/2, 0.1f+Screen.height/map.rectTransform.sizeDelta.y); 
        map.rectTransform.position = new Vector3(Screen.width- map.rectTransform.sizeDelta.x*map.rectTransform.localScale.x/2, Screen.height/2, 0);
        tuto.rectTransform.sizeDelta = new Vector2(Screen.height / 5, Screen.height / 5);
        tuto.rectTransform.position = new Vector3(3*Screen.width/5, Screen.height / 2);
        exit.rectTransform.sizeDelta = new Vector2(Screen.height / 8, Screen.height / 8);
        exit.rectTransform.position = new Vector3(exit.rectTransform.sizeDelta.x, exit.rectTransform.sizeDelta.y);
        video.rectTransform.sizeDelta = new Vector2(Screen.width / 2, Screen.height / 2);
        video.rectTransform.position = new Vector3(video.rectTransform.sizeDelta.x/2, video.rectTransform.sizeDelta.y+Screen.height/8, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
