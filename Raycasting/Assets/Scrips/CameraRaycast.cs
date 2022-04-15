using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraRaycast : MonoBehaviour
{
    [SerializeField] private GameObject camera;
    [SerializeField] private GameObject target;
    [SerializeField] private LayerMask myLayerMask;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(camera.transform.position,(target.transform.position - camera.transform.position).normalized, out hit, mathf.infinity, myLayerMask))
        {
            if (hit.collider.gameObject.tag == "player")
            {
                target.SetActive(false);
            }
            else
            {
                target.SetActive(true);

            }
        }
    }
}
