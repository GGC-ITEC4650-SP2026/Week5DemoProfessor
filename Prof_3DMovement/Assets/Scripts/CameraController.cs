using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotSpeed;
    public float minRotAngle;
    public float maxRotAngle;
    private Vector3 myRot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRot = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //rotation
        float my = Input.GetAxis("Mouse Y");
        Vector3 rotDir = Vector3.right * my;
        myRot += rotDir * rotSpeed * Time.deltaTime;
        if(myRot.x > maxRotAngle)
        {
            myRot.x = maxRotAngle;
        }
        if(myRot.x < minRotAngle)
        {
            myRot.x = minRotAngle;
        }

        transform.localEulerAngles = myRot;
    }
}
