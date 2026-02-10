using UnityEngine;

public class CannonController : MonoBehaviour
{

    public GameObject bulletPrefab;

    public float bulletSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject g = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            g.GetComponent<Rigidbody>().linearVelocity = transform.forward * bulletSpeed;
        }
    }
}
