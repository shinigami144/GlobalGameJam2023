using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{

    // ref to behaviour of the object
    private PlayerInput myPlayerInput;
    [SerializeField]
    private Camera theMainCamera;
    public GameObject arrow;
    public float dashRange;
    private Rigidbody2D myRigidbody2D;
    public float speed;
    // var from input
    public Vector2 direction;

    // var for the communication between function
    private bool isDashing;


    private void Awake()
    {
        dashRange = 2.5f;
        speed = 12;
        direction = new Vector2(1, 0);
        myRigidbody2D = GetComponent<Rigidbody2D>();
        isDashing = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        ChangeDirectionOfTheArrow();
        theMainCamera.transform.position = transform.position + Vector3.forward * -20;
    }

    private void ChangeDirectionOfTheArrow()
    {
        arrow.transform.position = new Vector3(this.transform.position.x + direction.x*transform.localScale.x, this.transform.position.y + direction.y * transform.localScale.y, arrow.transform.position.z);
        float angle;
        angle = Mathf.Atan2(-direction.x, direction.y);
        angle = Mathf.Rad2Deg*angle;
        Vector3 rotationVector = new Vector3(0, 0, angle);
        arrow.transform.rotation = Quaternion.Euler(rotationVector);

    }

    public IEnumerator Dash()
    {
        isDashing = true;
        myRigidbody2D.velocity = new Vector2(direction.x, direction.y) * dashRange * speed*transform.localScale.x;
        yield return new WaitForSeconds(1/speed);
        isDashing = false;
        myRigidbody2D.velocity = new Vector2(0, 0);
    }

    public void OnDash(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            if (!isDashing)
            {
                StartCoroutine(Dash());
            }
        }
    }

    public void OnChangeDirection( InputAction.CallbackContext ctx)
    {
        direction = ctx.ReadValue<Vector2>().magnitude != 0 ? ctx.ReadValue<Vector2>().normalized : direction;
        
    }
    

}
