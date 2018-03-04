using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ObjectShaker))]
public class ShakerInspector : Editor {

	public override void OnInspectorGUI() {
		DrawDefaultInspector();

		if(GUILayout.Button("Shake Object")) {
			ObjectShaker objectShaker = (ObjectShaker)target;
			objectShaker.ShakeForDuration (1.0f);
		}
	}
}
