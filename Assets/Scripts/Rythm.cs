using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Rythm : MonoBehaviour
{

    private float accumulatedFrame = 0;
    private bool canMove = true;

    private const float rythmTime = 0.75f;
    private const float timeCorrection = 0.2f;


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
            //Debug.Log("Boum !");
            accumulatedFrame = 0;
            canMove = true;
            rythmBar.transform.position = barStartPos;

        }

        if(Input.GetKeyUp(KeyCode.Space) && canMove)
        {
            canMove = false;
            if (accumulatedFrame < timeCorrection || accumulatedFrame > (rythmTime - timeCorrection))
            {
                float randomR = Random.Range(0, 255) / 255.0f;
                float randomG = Random.Range(0, 255) / 255.0f;
                float randomB = Random.Range(0, 255) / 255.0f;

                destinationSquare.GetComponent<Image>().color = new Color(randomR, randomG, randomB);
                //Debug.Log("Aïe");
            }
                
        }
    }
}
