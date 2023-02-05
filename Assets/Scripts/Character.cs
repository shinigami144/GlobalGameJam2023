using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    protected float dashRange;
    [SerializeField]
    protected float speed;
    [SerializeField]
    protected Vector2 direction;
    [SerializeField]
    protected Rigidbody2D myRigidbody2D;
    protected bool isDashing;
    private void Awake()
    {
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    virtual protected void DataInit()
    {
        dashRange = 2.5f;
        speed = 12;
        direction = new Vector2(1, 0);
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myRigidbody2D.gravityScale = 0;
        isDashing = false;
    }
    virtual public IEnumerator Dash()
    {
        isDashing = true;
        myRigidbody2D.velocity = new Vector2(direction.x, direction.y) * dashRange * speed * transform.localScale.x;
        yield return new WaitForSeconds(1 / speed);
        isDashing = false;
        myRigidbody2D.velocity = new Vector2(0, 0);
    }
}
