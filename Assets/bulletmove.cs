using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace test
{
    public class BulletMove : MonoBehaviour
    {
        GameObject target;
        Vector3 targetpos;

        float movement = 10f;

        void Start()
        {
        }

        void Update()
        {
            if (target == null)
            {
                target = GameObject.FindWithTag("musuh");
            }
            if (target != null)
            {
                targetpos = target.transform.position;
                this.transform.position = Vector3.MoveTowards(this.transform.position, targetpos, movement * Time.deltaTime);
            }
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("musuh"))
            {
                Targetting targetting = FindObjectOfType<Targetting>();

                if (targetting != null)
                {
                    targetting.RemoveTarget(collision.gameObject);
                    Debug.Log("Target removed from list.");
                }
                else
                {
                    Debug.LogError("No Targetting instance found.");
                }

                Destroy(collision.gameObject);
                Destroy(this.gameObject); 
            }
        }
    }
}
