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
    [SerializeField]
    private float bpm = 60;
    [SerializeField]
    private float rythmTime = 0;
    private float timeCorrection = 0.17f;
    [SerializeField]
    private float ecouledTime = 0;

    public delegate void RC();
    public event RC RestartCycle;

    [SerializeField]
    private GameObject destinationSquare;

    [SerializeField]
    private GameObject halo;
    private Vector2 haloStartSize = new Vector2(2, 2);

    private Vector2 maxReductionSize;


    // Start is called before the first frame update
    void Awake()
    {
        rythmTime=  60.0f / bpm;
        timeCorrection = rythmTime / 4;
        ecouledTime = 0;
        StartCoroutine(DashAllowerCalculation());
        Camera.main.gameObject.GetComponent<AudioSource>().Play();

        maxReductionSize = Vector2.zero;
        
    }

    // Update is called once per frame
    void Update()
    {

        halo.transform.localScale = haloStartSize - maxReductionSize;
        /*
        accumulatedFrame += Time.deltaTime;


        halo.transform.localScale = new Vector2 (haloStartSize.x - horizontalDistanceToGrow / rythmTime * accumulatedFrame, haloStartSize.y - verticalDistanceToGrow / rythmTime * accumulatedFrame);
        halo.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.75f*accumulatedFrame/rythmTime);

        


        if (accumulatedFrame >= rythmTime)
        {
            
            accumulatedFrame = 0;
            //canInputDash = true;
            //RestartCycle.Invoke();
        }*/
    }

    private void FixedUpdate()
    {
        
    }

    IEnumerator DashAllowerCalculation()
    {
        while (true)
        {
            ecouledTime += rythmTime / 100;
            maxReductionSize = new Vector2(Mathf.Sin(ecouledTime/rythmTime), Mathf.Sin(ecouledTime / rythmTime));
            if (ecouledTime >= rythmTime - timeCorrection)
            {
                halo.GetComponent<SpriteRenderer>().color = Color.green;
                canInputDash = true;
            }
            if(ecouledTime >= rythmTime)
            {
                maxReductionSize = new Vector2(0, 0);
                ecouledTime = 0;
                RestartCycle.Invoke();
                StartCoroutine(DelayTheResetOfTheDash());
            }
            yield return new WaitForSeconds(rythmTime/100);

        }
        /*
        yield return new WaitForSeconds(rythmTime);
        while (true) {
            yield return new WaitForSeconds(rythmTime - timeCorrection);
            canInputDash = true;
            Debug.Log("Go");
            Debug.Log(Time.realtimeSinceStartup);
            halo.GetComponent<SpriteRenderer>().color = Color.green;
            yield return new WaitForSeconds(timeCorrection);
            Debug.Log("Bump");
            Debug.Log(Time.realtimeSinceStartup);

            RestartCycle.Invoke();
            Invoke(nameof(DelayedDashStop), timeCorrection);

        }*/
    }

    IEnumerator DelayTheResetOfTheDash()
    {
        yield return new WaitForSeconds(timeCorrection);
        canInputDash = false;
        halo.GetComponent<SpriteRenderer>().color = Color.white;
    }



    public bool CanDash()
    {
       
        return canInputDash;
       
    }
}
