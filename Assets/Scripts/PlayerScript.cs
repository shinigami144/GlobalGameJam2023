using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : Character
{

    // ref to behaviour of the object
    private PlayerInput myPlayerInput;
    private Camera theMainCamera;
    private ManageVision myVisionScript;
    private Animator myAnimator;
    public GameObject arrow;
    // var from input

    private EnnemyMouvementScript theEnnemyFollowMe;

    public EnnemyMouvementScript TheEnnemyFollowMe
    {
        get
        {
            return theEnnemyFollowMe;
        }
        set
        {
            theEnnemyFollowMe = value;
        }
    }

    private void Awake()
    {
        
        DataInit();
        theMainCamera = FindAnyObjectByType<Camera>();
        myVisionScript = GetComponentInChildren<ManageVision>();
        myVisionScript.theEnnemy = theEnnemyFollowMe;
        myAnimator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //myVisionScript.theEnnemy = theEnnemyFollowMe;
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

    private string GetCorrectAnimationForTheMovement()
    {
        string nameAnimationToPlay = "Base Layer.Idle";
        if(direction.x > 0.5)
        {
            nameAnimationToPlay = "Base Layer.DashRight";
        }
        else if (direction.y > 0.5)
        {
            nameAnimationToPlay = "Base Layer.DashUp";
        }
        else if (direction.x < -0.5)
        {
            nameAnimationToPlay = "Base Layer.DashLeft";
        }
        else if (direction.y < -0.5)
        {
            nameAnimationToPlay = "Base Layer.DashDown";
        }
        return nameAnimationToPlay;

    }


    override public IEnumerator Dash()
    {
        isDashing = true;
        myAnimator.Play(GetCorrectAnimationForTheMovement());
        myRigidbody2D.velocity = new Vector2(direction.x, direction.y) * dashRange * speed * transform.localScale.x;
        yield return new WaitForSeconds(1/speed);
        isDashing = false;
        myRigidbody2D.velocity = new Vector2(0, 0);
        myAnimator.Play("Base Layer.Idle");

    }

    private void ChangeColor(Color theNewPlayerColor)
    {
        //GetComponent<SpriteRenderer>().color = theNewPlayerColor;
    }

    public void OnDash(InputAction.CallbackContext ctx)
    {
        
        if (ctx.started)
        {
            Debug.Log("Pressed");
            Debug.Log(Time.realtimeSinceStartup);
            if (this.GetComponentInChildren<Rythm>().CanDash())
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
