using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogBoxUIScript : MonoBehaviour
{
    // Initial Set-up
    // Game Objects for the dialog buttons
    public GameObject dialogButtonChoiceGroup;
    public GameObject dialogButtonChoice0;
    public GameObject dialogButtonChoice1;
    public GameObject dialogButtonChoice2;
    public GameObject dialogButtonChoice3;
    public GameObject dialogButtonChoice4;
    public GameObject dialogButtonChoice5;
    public GameObject dialogButtonChoice6;
    public GameObject dialogButtonChoice7;
    public GameObject dialogButtonChoice8;
    public GameObject dialogButtonChoice9;

    // TMP Text for the dialog texts
    public TMP_Text dialogTextChoice0;
    public TMP_Text dialogTextChoice1;
    public TMP_Text dialogTextChoice2;
    public TMP_Text dialogTextChoice3;
    public TMP_Text dialogTextChoice4;
    public TMP_Text dialogTextChoice5;
    public TMP_Text dialogTextChoice6;
    public TMP_Text dialogTextChoice7;
    public TMP_Text dialogTextChoice8;
    public TMP_Text dialogTextChoice9;

    // Misc
    public Slider dialogSlider; // Scroller Object

    private void Update()
    {
        DialogBoxScrolling();
    }

    void DialogBoxScrolling()
    {
        float dialogSliderValueFloat = dialogSlider.value;
        Debug.Log(dialogSliderValueFloat);
        //dialogButtonChoiceGroup.transform.Translate(0, 0+dialogSliderValueFloat, 0);
        // 0.666... covers entire 3 line dialog box, so 0.222... covers 1 dialog box
        dialogButtonChoiceGroup.transform.position = new Vector3((this.transform.localPosition.x + 37.5481f), ((this.transform.localPosition.y - 7.72261f) * dialogSliderValueFloat), (this.transform.localPosition.z - 46.44915f));
        Debug.Log(this.transform.localPosition.x);
        Debug.Log(this.transform.localPosition.z);
    }
}
