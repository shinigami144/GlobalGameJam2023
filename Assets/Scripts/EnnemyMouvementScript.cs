using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnnemyMouvementScript : Character
{
    // Start is called before the first frame update
    [SerializeField]
    private PlayerScript TargetPlayer;


    private void Awake()
    {
        DataInit();
        dashRange *= 0.7f;
        TargetPlayer.TheEnnemyFollowMe = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerScript>() != null)
        {
            MenuManagers.Instance.GoToLoseScene();
        }
    }

    private void EnnemyDash()
    {
        direction = new Vector2(TargetPlayer.transform.position.x - transform.position.x, TargetPlayer.transform.position.y - transform.position.y).normalized;
        StartCoroutine(Dash());
    }

    private void OnEnable()
    {
        FindObjectOfType<Rythm>().RestartCycle += EnnemyDash;
    }


   
}
