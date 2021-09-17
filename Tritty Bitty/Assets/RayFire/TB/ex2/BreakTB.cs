using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
    public class BreakTB : MonoBehaviour
    {
        public Transform customPoint;
        public Camera cam;
        public int flag = 0;

        private void Update()
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.gameObject.tag == "cube")
                    {
                        customPoint.position = hit.point;
                        flag = 1;
                    }
                }
            }
            Debug.DrawRay(ray.origin, ray.direction * 50, Color.yellow);
        }
    }
}