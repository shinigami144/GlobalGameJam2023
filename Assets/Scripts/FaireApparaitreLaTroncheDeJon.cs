using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class FaireApparaitreLaTroncheDeJon : MonoBehaviour
{

    public float cheatIndex = 0;

    [SerializeField]
    private GameObject johnHead;

    private void Awake()
    {

    }

    public void PressB(InputAction.CallbackContext ctx)
    {
        if(ctx.performed)
        {
            Debug.Log("B");
            if (cheatIndex == 8)
            {
                cheatIndex++;
            }
        }

    }
    
    public void PressA(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            Debug.Log("A");
            if (cheatIndex == 9)
            {
                cheatIndex = 0;
                MakeHeadAppear();
            }
        }
    }

    public void PressDirection(InputAction.CallbackContext ctx)
    {
        if (ctx.performed) 
        {
            Debug.Log(ctx.ReadValue<Vector2>());

            if(ctx.ReadValue<Vector2>() == new Vector2(-1,0) && (cheatIndex == 4 || cheatIndex == 6))
            {
                ++cheatIndex;
            }

            if (ctx.ReadValue<Vector2>() == new Vector2(1, 0) && (cheatIndex == 5 || cheatIndex == 7))
            {
                ++cheatIndex;
            }

            if (ctx.ReadValue<Vector2>() == new Vector2(0, 1) && (cheatIndex == 0 || cheatIndex == 1))
            {
                ++cheatIndex;
            }

            if (ctx.ReadValue<Vector2>() == new Vector2(0, -1) && (cheatIndex == 2 || cheatIndex == 3))
            {
                ++cheatIndex;
            }
        }
        /*if (ctx.ReadValue() 
        {
        }*/
    }

    void MakeHeadAppear()
    {
        if(johnHead.activeInHierarchy == false)
        {
            johnHead.SetActive(true);
        }
        else
        {
            johnHead.SetActive(false);
        }
    }
}
