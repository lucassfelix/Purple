using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableSceneViewMask : MonoBehaviour
{
   void Awake() {
       gameObject.SetActive(false);
   }
}
