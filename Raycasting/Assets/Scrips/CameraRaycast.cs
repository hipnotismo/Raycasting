using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraRaycast : MonoBehaviour
{
    [SerializeField] private Transform playerCam;
    public LayerMask terrainLayer;
    public Material newMat;
    public Material oldMat;
    private List<RaycastHit> roofHits = new List<RaycastHit>();
    public void Update()
    {
        if (Physics.Linecast(this.transform.position, playerCam.position, out RaycastHit hitInfo, terrainLayer))
        {
            hitInfo.collider.gameObject.GetComponent<MeshRenderer>().material = newMat;
            roofHits.Add(hitInfo);
        }

        if (roofHits.Count > 0 && !Physics.Linecast(this.transform.position, playerCam.position, terrainLayer))
        {
            for (int i = 0; i < roofHits.Count; i++)
            {
                roofHits[i].collider.gameObject.GetComponent<MeshRenderer>().material = oldMat;
            }
            roofHits.Clear();
        }
    }
}
