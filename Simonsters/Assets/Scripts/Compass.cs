using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour {
  private Transform controller;
  private Vector3 viewRotation;
  
  private void Start() {
    controller = Camera.main.transform;
    viewRotation = new Vector3(0, 0, 0);
  }

  private void Update() {
    viewRotation.z = Camera.main.transform.eulerAngles.y;
    transform.localEulerAngles = viewRotation;
  }
}
