using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanevasManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    UnityEngine.UI.CanvasScaler canevasObject;
    [SerializeField]
    Sprite winImage;
    [SerializeField]
    Sprite loseImage;
    void Start()
    {
        canevasObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCanevasWithWinMessage()
    {
        GetComponentInChildren<UnityEngine.UI.Image>().sprite = winImage;
        canevasObject.gameObject.SetActive(true);
    }

    public void ShowCanevasWithLoseMessage()
    {
        GetComponentInChildren<UnityEngine.UI.Image>().sprite = loseImage;
        canevasObject.gameObject.SetActive(true);
    }
    
    public void OnclickCanevas()
    {
        MenuManagers.Instance.GoToMenu();
    }

}
