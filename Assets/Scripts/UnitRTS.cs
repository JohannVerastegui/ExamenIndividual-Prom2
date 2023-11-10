using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitRTS : MonoBehaviour
{
    private GameObject selectedGameObject;

    private void Awake()
    {
        selectedGameObject = transform.Find("Selected").gameObject;
    }

    public void SetSelectedVisible(bool visible)
    {
        selectedGameObject - SetActive(visible);
    }
}
