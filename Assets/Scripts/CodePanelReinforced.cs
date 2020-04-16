using UnityEngine;
using UnityEngine.UI;
public class CodePanelReinforced : MonoBehaviour
{
	[SerializeField] OpenReinforced openReinforced;
	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	void Update()
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "ФЛЕТЧЕР")
			openReinforced.OpenBox();


		if (codeTextValue.Length >= 7)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}
