using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour {
	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	void Update () 
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "54375")
			UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController.isSafeOpened = true;
		if (codeTextValue.Length >= 5)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}
