using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonTextShower : MonoBehaviour
{
    public void ShowText(TextMeshProUGUI text)
    {
        text.gameObject.SetActive(true);
    }
}
