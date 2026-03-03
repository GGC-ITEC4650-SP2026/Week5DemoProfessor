using UnityEngine;

public class MiniMapController : MonoBehaviour
{
    Transform playerTran;
    Camera myCam;
    private Vector3 deltaPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTran = GameObject.Find("Player").transform;
        deltaPos = transform.position - playerTran.position;
        myCam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTran.position + deltaPos;
    }

    public void toggleMap()
    {
        myCam.enabled = !myCam.enabled;
    }
}
