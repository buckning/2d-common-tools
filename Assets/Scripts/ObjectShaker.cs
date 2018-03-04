using UnityEngine;
using System.Collections;

/***
 * Adapted from http://unitytipsandtricks.blogspot.ie/2013/05/camera-shake.html
 */
public class ObjectShaker : MonoBehaviour {
	public float shakeMagnitude = 0.1f;

	bool startShaking = false;

	private bool shaking = false;

	Vector2 initialPosition;

	void Start() {
		initialPosition = transform.position;
	}

	void Update () {
		if (startShaking && shaking == false) {
			StartCoroutine (Shake ());
		} 
	}

	public void ShakeForDuration(float duration) {
		StartShaking ();
		StartCoroutine (StopShakingAfterDuration (duration));
	}

	public void StartShaking() {
		startShaking = true;
	}

	public void StopShaking() {
		startShaking = false;
	}

	IEnumerator Shake() {
		shaking = true;

		Vector3 originalCamPos = transform.localPosition;

		while (startShaking) {
			float damper = 1.0f - Mathf.Clamp(4.0f *  - 3.0f, 0.0f, 1.0f);

			// map value to [-1, 1]
			float x = Random.value * 2.0f - 1.0f;
			float y = Random.value * 2.0f - 1.0f;
			x *= shakeMagnitude * damper + originalCamPos.x;
			y *= shakeMagnitude * damper + originalCamPos.y;

			if (!isGamePaused()) {
				transform.localPosition = new Vector3 (x, y, originalCamPos.z);
			}
			yield return null;
		}
		shaking = false;
		transform.position = initialPosition;
	}

	IEnumerator StopShakingAfterDuration(float duration) {
		yield return new WaitForSeconds (duration);
		StopShaking ();
	}

	bool isGamePaused() {
		return Time.timeScale < 1.0f;
	}
}
