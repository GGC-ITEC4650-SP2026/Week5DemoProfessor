using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float jumpPower;
    public float gravity;
    private Vector3 airVel;

    public float speed;

    public float rotSpeed;

    private Vector3 myRot;

    CharacterController myCC;

    GameObject[] allEnemies;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRot = Vector3.zero;
        myCC = GetComponent<CharacterController>();
        allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        print("There are " + allEnemies.Length + " bad guys here!");
    }

    // Update is called once per frame
    void Update()
    {   
        
        if(myCC.isGrounded)
        {
            if(Input.GetButtonDown("Jump"))
            {
                airVel = Vector3.up * jumpPower;
            }
            else
            {
                airVel = Vector3.up * -2;
            }
        }
        else
        {
            //in the air
            airVel += Vector3.up * gravity * Time.deltaTime;
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = transform.forward * v + transform.right * h;
        //transform.position += (dir * speed * Time.deltaTime);
        Vector3 total = (dir * speed) + airVel;
        myCC.Move(total * Time.deltaTime);

        //rotation
        float mx = Input.GetAxis("Mouse X");
        Vector3 rotDir = Vector3.up * mx;
        myRot += rotDir * rotSpeed * Time.deltaTime;
        transform.localEulerAngles = myRot;
    }
}
