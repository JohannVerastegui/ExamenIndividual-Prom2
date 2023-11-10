using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSController : MonoBehaviour
{
    private Vector3 startPosition;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPosition = GetMouseWorldPosition();
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log(GetMouseWorldPosition() + "" + startPosition);
            Collider[] colliderArray = Physics.OverlapBox(startPosition, (GetMouseWorldPosition() - startPosition) * 0.5f);
            Debug.Log("###");
            foreach (Collider collider in colliderArray)
            {
                Debug.Log(collider);
            }
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            return hit.point;
        }
        return Vector3.zero;
    }
}
