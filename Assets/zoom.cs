using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Hero");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 jarak = target.transform.position - this.transform.position;
        Debug.DrawRay(this.transform.position, jarak, Color.red);
         float speed = 0f;
    if (Input.GetKey(KeyCode.Alpha1)) {
    speed = 1;
    }
    if (Input.GetKey(KeyCode.Alpha2)) {
    speed = -1;
    }
        this.transform.Translate(jarak * speed *
        Time.deltaTime);
        this.transform.LookAt(target.transform);
        
        
    }
}
