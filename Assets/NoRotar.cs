using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRotar : MonoBehaviour {

    void FixedUpdate() { Vector3 oldRot = transform.rotation.eulerAngles; transform.rotation = Quaternion.Euler(oldRot.x, 90, oldRot.z); }
}
