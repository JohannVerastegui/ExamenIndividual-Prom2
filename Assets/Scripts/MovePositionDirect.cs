using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePositionDirect : MonoBehaviour
{
    private Vector3 movePosition;

    private void Awake()
    {
        movePosition = transform.position;
    }

    public void SetMovePosition(Vector3 movePosition)
    {
        this.movePosition = movePosition;
    }

    private void Update()
    {
        Vector3 moveDir = (movePosition - transform.position).normalized;
        if (Vector3.Distance(movePosition, transform.position) < 1f) moveDir = Vector3D.zero;
        GetComponent<IMoveVelocity>().SetVelocity(moveDir);
    }
}
