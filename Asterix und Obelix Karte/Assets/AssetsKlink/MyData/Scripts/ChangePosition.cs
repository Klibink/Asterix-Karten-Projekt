using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script um Objekte von Punkt A nach Punkt B zu bewegen
public class ChangePosition : MonoBehaviour
{
    public Transform target;
    public Vector3 startPos;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameObject.activeSelf)
        {
            transform.position = startPos;
        }


        if (transform.position != target.position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
    }
}
