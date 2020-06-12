using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    
    public Rigidbody rb;    
    public float forwardForce = 400f;
    public float sidewayForce = 200f;

    // Start is called before the first frame update
    //void Start()
    //{
    //    rb.AddForce(0, 20, 400);
    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, forwardForce *Time.deltaTime);

        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce*Time.deltaTime, 0 ,0, ForceMode.VelocityChange);
        }

        if( Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce*Time.deltaTime, 0 ,0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
