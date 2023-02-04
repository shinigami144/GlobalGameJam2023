using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ManageVision : MonoBehaviour
{

    [SerializeField]
    private EnnemyMouvementScript enemy;



    public EnnemyMouvementScript theEnnemy
    {
        get
        {
            return this.enemy;
        }
        set
        {
            enemy = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalDistance = transform.position.y - enemy.transform.position.y;
        float horizontalDistance = transform.position.x - enemy.transform.position.x;
        float distanceBetweenEnemyAndPlayer = Mathf.Sqrt(Mathf.Pow(verticalDistance,2) + Mathf.Pow(horizontalDistance,2));

        transform.localScale = 0.5f * distanceBetweenEnemyAndPlayer * new Vector2(1, 1);
    }
}
