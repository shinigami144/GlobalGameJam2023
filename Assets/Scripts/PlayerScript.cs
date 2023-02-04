using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : Character
{

    // ref to behaviour of the object
    private PlayerInput myPlayerInput;
    [SerializeField]
    private Camera theMainCamera;
    public GameObject arrow;
    // var from input



    private void Awake()
    {
        DataInit();
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


    private void ChangeColor(Color theNewPlayerColor)
    {
        GetComponent<SpriteRenderer>().color = theNewPlayerColor;
    }

    public void OnDash(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            if (theMainCamera.GetComponent<Rythm>().CanDash())
            {
                ChangeColor(Color.green);
                if (!isDashing)
                {
                    StartCoroutine(Dash());
                }
            }
            else
            {
                ChangeColor(Color.red);
            }
        }
    }

    public void OnChangeDirection( InputAction.CallbackContext ctx)
    {
        direction = ctx.ReadValue<Vector2>().magnitude != 0 ? ctx.ReadValue<Vector2>().normalized : direction;
        
    }
    

}
