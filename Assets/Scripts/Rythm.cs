using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

public class Rythm : MonoBehaviour
{

    private float accumulatedFrame = 0;
    private bool canInputDash = true;

    private float bpm = 80.0f;
    private  float rythmTime = 0;
    private const float timeCorrection = 0.2f;


    public delegate void RC();
    public event RC RestartCycle;

    [SerializeField]
    private GameObject destinationSquare;

    [SerializeField]
    private GameObject halo;
    private Vector2 haloStartSize = new Vector2(2, 2);

    private float verticalDistanceToGrow = 0;
    private float horizontalDistanceToGrow = 0;


    // Start is called before the first frame update
    void Start()
    {
        rythmTime=  60.0f / bpm;

        verticalDistanceToGrow = haloStartSize.y - destinationSquare.transform.localScale.y;
        horizontalDistanceToGrow = haloStartSize.x - destinationSquare.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        accumulatedFrame += Time.deltaTime;


        halo.transform.localScale = new Vector2 (haloStartSize.x - horizontalDistanceToGrow / rythmTime * accumulatedFrame, haloStartSize.y - verticalDistanceToGrow / rythmTime * accumulatedFrame);
        halo.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.75f*accumulatedFrame/rythmTime);

        


        if (accumulatedFrame >= rythmTime)
        {
            accumulatedFrame = 0;
            canInputDash = true;
            RestartCycle.Invoke();
        }
    }


    public bool CanDash()
    {
        //bool canDash = true;
        bool canDash = (accumulatedFrame < timeCorrection || accumulatedFrame > (rythmTime - timeCorrection)&& canInputDash);
        canInputDash = false;
        return canDash;
    }
}
