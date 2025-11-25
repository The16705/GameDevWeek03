using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject musuh;
    [SerializeField] GameObject posawal;
    int delay = 200;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        delay--;
        if(delay == 0){
            delay = 200;
            Vector3 offset = new Vector3(1f,1f,1f);
            Instantiate(musuh, posawal.transform.position + offset, Quaternion.identity);
        }
    }
}
