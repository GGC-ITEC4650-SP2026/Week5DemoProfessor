using UnityEngine;

public class PlatformController : MonoBehaviour
{
    Collider myCol;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myCol = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        GameObject otherGO = collision.gameObject;
        if(otherGO.tag == "Snowman")
        {
            myCol.enabled = false;
        }
    }
}
