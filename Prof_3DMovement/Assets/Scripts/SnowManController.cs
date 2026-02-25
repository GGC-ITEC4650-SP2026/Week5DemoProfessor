using UnityEngine;

public class SnowManController : MonoBehaviour
{
    public float timeToLive;
    //Collider[] myCols;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //myCols = GetComponentsInChildren<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        timeToLive -= Time.deltaTime;
        if(timeToLive <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);
    }

    /*
    void OnTriggerExit(Collider other)
    {
        foreach(Collider c in myCols)
            c.isTrigger = false;
    }
    */
}
