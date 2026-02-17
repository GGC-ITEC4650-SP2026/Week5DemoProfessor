using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    Transform playerTran;
    NavMeshAgent myAgent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTran = GameObject.Find("Player").GetComponent<Transform>();
        myAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        myAgent.SetDestination(playerTran.position);
        /*
        Vector3 v = playerTran.position - transform.position;
        transform.forward = v.normalized;
        transform.position += transform.forward * Time.deltaTime;
        */
    }
}
