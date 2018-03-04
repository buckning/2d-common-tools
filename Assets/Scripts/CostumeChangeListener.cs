using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumeChangeListener : MonoBehaviour {
	
	public CharacterReskin character;
	public Skin characterSkin;

	Skin currentSkin;

	public enum Skin {
		Normal,
		Red,
		Green,
		Blue
	}

	void Start () {
		currentSkin = characterSkin;
	}

	void Update () {
		if (characterSkin != currentSkin) {
			character.ChangeCostume (characterSkin.ToString());
			currentSkin = characterSkin;
		}
	}
}
