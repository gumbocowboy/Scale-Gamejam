using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIController : MonoBehaviour
{
    public TextMeshProUGUI heightDisplay;
    public GameObject mouseoverPanel;
    public GameObject warningPanel;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        heightDisplay.text = GlobalVars.currentHeight.ToString();

    }

    public void ShowMouseOver(string text)
    {
        mouseoverPanel.SetActive(true);
        TextMeshProUGUI tmp = mouseoverPanel.GetComponentInChildren<TextMeshProUGUI>();
        tmp.text = text;
    }

    public void HideMouseOver()
    {
        mouseoverPanel.SetActive(false);
    }

    public void ShowWrongSize(int size)
    {
        TextMeshProUGUI tmp = warningPanel.GetComponentInChildren<TextMeshProUGUI>();
        tmp.text = ("You must be " + size + "' to use this.");
        warningPanel.SetActive(true);
        StartCoroutine(HideWarning());
    }

    IEnumerator HideWarning()
    {
        yield return new WaitForSeconds(5);
        warningPanel.SetActive(false);
    }


}
