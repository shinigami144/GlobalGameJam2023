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
    private Image rythmBar;

    private Vector2 barStartPos = new Vector2(-300, 0);

    [SerializeField]
    private Image destinationSquare;

    private float distanceToTravel = 0;

    [SerializeField]
    private Image haloSquare;
    private Vector2 haloStartSize = new Vector2(200, 200);

    private float verticalDistanceToGrow = 0;
    private float horizontalDistanceToGrow = 0;


    // Start is called before the first frame update
    void Start()
    {
        rythmTime=  60.0f / bpm;
        distanceToTravel = destinationSquare.rectTransform.position.x - barStartPos.x;

        verticalDistanceToGrow = haloStartSize.y - destinationSquare.rectTransform.sizeDelta.y;
        horizontalDistanceToGrow = haloStartSize.x - destinationSquare.rectTransform.sizeDelta.x;
    }

    // Update is called once per frame
    void Update()
    {
        accumulatedFrame += Time.deltaTime;
        rythmBar.rectTransform.position = new Vector2(barStartPos.x + distanceToTravel / rythmTime * accumulatedFrame, 0);


        haloSquare.rectTransform.sizeDelta = new Vector2 (haloStartSize.x - horizontalDistanceToGrow / rythmTime * accumulatedFrame, haloStartSize.y - verticalDistanceToGrow / rythmTime * accumulatedFrame);
        haloSquare.GetComponent<Image>().color = new Color(1, 1, 1, accumulatedFrame/rythmTime);

        


        if (accumulatedFrame >= rythmTime)
        {
            accumulatedFrame = 0;
            canInputDash = true;
            rythmBar.transform.position = barStartPos;
            RestartCycle.Invoke();
        }
    }


    public bool CanDash()
    {
        //bool canDash = true;
        bool canDash = (accumulatedFrame < timeCorrection || accumulatedFrame > (rythmTime - timeCorrection)&& canInputDash);
        canInputDash = false;
        if (canDash)
        {
            float randomR = Random.Range(0, 255) / 255.0f;
            float randomG = Random.Range(0, 255) / 255.0f;
            float randomB = Random.Range(0, 255) / 255.0f;

            destinationSquare.GetComponent<Image>().color = new Color(randomR, randomG, randomB,0);
            //Debug.Log("Aïe");
        }
        return canDash;
    }
}
