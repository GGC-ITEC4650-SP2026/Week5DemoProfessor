using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public float rotSpeed;

    private Vector3 myRot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRot = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = transform.forward * v + transform.right * h;
        transform.position += dir * speed * Time.deltaTime;

        float mx = Input.GetAxis("Mouse X");
        Vector3 rotDir = Vector3.up * mx;
        myRot += rotDir * rotSpeed * Time.deltaTime;
        transform.localEulerAngles = myRot;

    }
}
