using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GoldCurrency : MonoBehaviour
{
    public CurrencyData GoldData;
    public TMP_Text GoldText;
    private void Awake()
    {
        GoldText = GetComponentInChildren<TMP_Text>();
    }
    private void Update()
    {
        HandleAllDailyInfo();
    }
    public void HandleAllDailyInfo()
    {
        ShowGoldInfo(GoldData);
    }
    private void ShowGoldInfo(CurrencyData Gold)
    {
        GoldText.text = GoldData.Count.ToString();
    }
}
