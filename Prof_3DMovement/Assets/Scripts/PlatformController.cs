using UnityEngine;

public class PlatformController : MonoBehaviour
{
    Collider myCol;

    public Vector3 dir;
    public float speed;

    private float distLeftToMove;
    public float moveDist;

    public bool airLocked;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myCol = GetComponent<Collider>();
        distLeftToMove = moveDist;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 frameStep = dir * Time.deltaTime * speed;
        distLeftToMove -= frameStep.magnitude;
        Vector3 temp = transform.position + frameStep;
        if(distLeftToMove > 0)
        {
            transform.position = temp;
        }
        else
        {
            distLeftToMove = moveDist;
            // reverse direction
            dir = -1 * dir;
        }        
    }
    void OnCollisionEnter(Collision collision)
    {
        GameObject otherGO = collision.gameObject;
        /*
        if(otherGO.tag == "Snowman")
        {
            myCol.enabled = false;
        }
        */
    }

    /*
    public Vector3 adjustGroundPlayerMotion()
    {
        
    }
    public Vector3 adjustAirPlayerMotion()
    {
        
    }
    */

}
