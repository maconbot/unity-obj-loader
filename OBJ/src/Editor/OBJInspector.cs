using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(OBJ))]
public class OBJInspector : Editor{
	public override void OnInspectorGUI() {
		DrawDefaultInspector();
		OBJ O = (OBJ)target;
		if(GUILayout.Button("Build")) {
			O.BuildMesh();
		}
	}
}
