using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (FieldOfView))]
public class FieldOfViewEditor : Editor
{
    void OnSceneGUI()
    {
        FieldOfView fow = (FieldOfView)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(fow.transform.position, Vector3.up, Vector3.forward, 360, fow._viewRadius);
        Vector3 viewAngleA = fow.DirFromAngle(-fow._viewAngle / 2, false);
        Vector3 viewAngleB = fow.DirFromAngle(fow._viewAngle / 2, false);

    }
}
