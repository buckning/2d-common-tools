using UnityEngine;
using System.Collections;

/***
 * Class that plays an audio clip when the player is colliding with this object.
 * When the player stops colliding with this object, the audio clip is stopped
 */
[RequireComponent (typeof(AudioSource))]
public class AudioTrigger : MonoBehaviour {
	//if oneShot is true, the audio is played once at the time of collision. Otherwise the audio acts in continuous mode, 
	//where audio is played when there is a collision with the object and audio is stopped when there is no collision
	public bool oneShot = true;	
	
	bool wasTriggered = false;	//internal tracking for continuous mode

	AudioSource audioSource;

	void Start() {
		audioSource = GetComponent<AudioSource> ();
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if (oneShot && !wasTriggered) {
			audioSource.Play ();
			wasTriggered = true;
		} else if (!oneShot) {
			audioSource.Play ();
		}
	}

	public void OnTriggerExit2D(Collider2D other) {
		if (!oneShot) {
			audioSource.Stop ();
		}
	}
	
	public void Reset() {
		wasTriggered = false;
	}
}
