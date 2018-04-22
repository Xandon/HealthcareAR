using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour {

    public Transform medicalObject;

    public void CreateGameObject(GameObject obj)
    {
        Instantiate(obj, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
