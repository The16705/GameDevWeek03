using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace test
{
    public class Targetting1 : MonoBehaviour
    {
        public List<GameObject> targetlist = new List<GameObject>();
        public GameObject target;
        int noList = 0;

        void Update()
        {
            if (targetlist.Count > 0 && target != null)
            {
                Vector3 targetpos = target.transform.position - this.transform.position;
                this.transform.rotation = Quaternion.LookRotation(targetpos);
            }
            if (Input.GetKeyDown(KeyCode.Space)) {
            noList++;
            if (noList >= targetlist.Count) {
            noList = 0;
            }
            pindahtarget();
                }

        }

        private void pindahtarget()
        {
            if (targetlist.Count > 0)
            {
                target = targetlist[noList];
            }
            else
            {
                target = null;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("musuh"))
            {
                noList = 0;
                targetlist.Remove(other.gameObject);
                pindahtarget();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("musuh"))
            {
                targetlist.Add(other.gameObject);
                pindahtarget();

            }
        }

        

        public void RemoveTarget(GameObject other)
        {
            if (other.gameObject.CompareTag("musuh"))
            {
                targetlist.Remove(other.gameObject);
                pindahtarget();
            }
        }

    }
}
