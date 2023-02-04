using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ManageVision : MonoBehaviour
{
    [SerializeField]
    private GameObject viewFieldObject;

    [SerializeField]
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalDistance = viewFieldObject.transform.position.y - enemy.transform.position.y;
        float horizontalDistance = viewFieldObject.transform.position.x - enemy.transform.position.x;
        float distanceBetweenEnemyAndPlayer = Mathf.Sqrt(Mathf.Pow(verticalDistance,2) + Mathf.Pow(horizontalDistance,2));

        viewFieldObject.transform.localScale = 0.5f * distanceBetweenEnemyAndPlayer * new Vector2(1, 1);
    }
}
