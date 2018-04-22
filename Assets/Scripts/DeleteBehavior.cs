using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBehavior : MonoBehaviour {

    [SerializeField] GameObject equipmentObject;
    [SerializeField] GameObject inactiveEquipmentObjects;

	public void Delete()
    {
        // Only delete if unlocked
        bool locked = equipmentObject.GetComponent<ObjectLockBehavior>().GetLockedState();

        if (!locked)
        {
            // Reparent object to camera
            equipmentObject.transform.SetParent(inactiveEquipmentObjects.transform);

            // Make object inactive
            equipmentObject.SetActive(false);
        }
    }
}
