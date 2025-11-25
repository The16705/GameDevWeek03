using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_cctv2 : MonoBehaviour
{
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Hero");
        this.transform.rotation = Quaternion.AngleAxis(45,Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 jarakCctvHero = target.transform.position - this.transform.position;
        Quaternion rot = Quaternion.LookRotation(jarakCctvHero);
        //this.transform.rotation = Quaternion.Euler(0,rot.eulerAngles.y,0);
        this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, rot.eulerAngles.y, 0), 10f * Time.deltaTime);
        Debug.DrawRay(target.transform.position, jarakCctvHero, Color.red);
        if(rot.eulerAngles.y > 180){
             this.transform.rotation = Quaternion.Euler(new Vector3(0, -30, 0));
        }
    }
}
