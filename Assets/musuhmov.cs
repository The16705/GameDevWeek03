using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusuhMov : MonoBehaviour
{
    GameObject movepoint;
    List<GameObject> listPoint = new List<GameObject>();
    float speedMove = 5f;

    void Awake()
    {
        movepoint = GameObject.Find("movepoint");

        foreach (Transform child in movepoint.transform)
        {
            listPoint.Add(child.gameObject);
        }

        foreach (GameObject x in listPoint)
        {
        }
    }

    void Update()
    {
        if (listPoint.Count > 0)
        {
            Vector3 targetPos = new Vector3(listPoint[0].transform.position.x,
                                            this.transform.position.y,
                                            listPoint[0].transform.position.z);
            this.transform.position = Vector3.MoveTowards(this.transform.position, targetPos, speedMove * Time.deltaTime);

            Vector3 direction = targetPos - this.transform.position;
            if (direction != Vector3.zero) 
            {
                this.transform.rotation = Quaternion.LookRotation(direction);
            }

            Vector3 posMusuh = new Vector3(this.transform.position.x, listPoint[0].transform.position.y, this.transform.position.z);

            if (Vector3.Distance(listPoint[0].transform.position, posMusuh) < 0.1f)
            {
                listPoint.RemoveAt(0);
            }
        }
    }

}
