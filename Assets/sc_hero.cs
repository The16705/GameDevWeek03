using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = Quaternion.Euler(new Vector3(0,30,0));

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        this.transform.Translate(new Vector3(0,0,v) * Time.deltaTime * 3f, Space.Self);
        this.transform.Rotate(new Vector3(0,h,0) * 5f, Space.Self);

    }
}
