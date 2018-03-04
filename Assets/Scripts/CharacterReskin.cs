using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterReskin : MonoBehaviour {

	SpriteRenderer[] allRenderers;	//All the SpriteRenderers in this GameObject

	void Start () {
		allRenderers = GetComponentsInChildren<SpriteRenderer> ();
	}

	public void ChangeCostume(string spriteSheet) {
		Sprite[] sprites = Resources.LoadAll<Sprite> (spriteSheet);

		foreach (Sprite sprite in sprites) {
			List<SpriteRenderer> renderers = GetSpriteRenderersWithName (sprite.name, allRenderers);
			SetSpriteForRenderers (sprite, renderers);
		}
	}

	/***
	 * Loop through the SpriteRenderers and set the sprite for them
	 */
	public void SetSpriteForRenderers(Sprite sprite, List<SpriteRenderer> renderers) {
		foreach (SpriteRenderer renderer in renderers) {
			renderer.sprite = sprite;
		}
	}

	/***
	 * Get a list of all the SpriteRenderers with a specific name
	 */
	List<SpriteRenderer> GetSpriteRenderersWithName(string rendererName, SpriteRenderer[] renderers) {
		List<SpriteRenderer> spriteRenderers = new List<SpriteRenderer> ();
		foreach (SpriteRenderer renderer in renderers) {
			if (renderer.name == rendererName) {
				spriteRenderers.Add (renderer);
			}
		}
		return spriteRenderers;
	}
}
