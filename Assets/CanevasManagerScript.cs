using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanevasManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnclickCanevas()
    {
        MenuManagers.Instance.GoToMenu();
    }

}
