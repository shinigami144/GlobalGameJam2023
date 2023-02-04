using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnnemyMouvementScript : Character
{
    // Start is called before the first frame update
    [SerializeField]
    private PlayerScript player;


    private void Awake()
    {
        DataInit();
        dashRange *= 0.7f;
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


    private void EnnemyDash()
    {
        direction = new Vector2(player.transform.position.x - transform.position.x, player.transform.position.y - transform.position.y).normalized;
        StartCoroutine(Dash());
    }

    private void OnEnable()
    {
        FindObjectOfType<Rythm>().RestartCycle += EnnemyDash;
    }


    private void OnDisable()
    {
        FindObjectOfType<Rythm>().RestartCycle -= EnnemyDash;
    }
}
