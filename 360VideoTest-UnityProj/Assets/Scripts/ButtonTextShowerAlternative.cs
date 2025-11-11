using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonTextShowerAlternative : MonoBehaviour
{
    public Button computerButton;
    public Button robotButton;

    public TextMeshProUGUI computerText;
    public TextMeshProUGUI robotText;
    private void OnEnable()
    {
        computerButton.onClick.AddListener(() => ShowText(computerText));
        robotButton.onClick.AddListener(() => ShowText(robotText));
    }

    private void OnDisable()
    {
        computerButton.onClick.RemoveAllListeners();
        robotButton.onClick.RemoveAllListeners();
    }

    private void ShowText(TextMeshProUGUI text)
    {
        text.gameObject.SetActive(true);
    }

}
