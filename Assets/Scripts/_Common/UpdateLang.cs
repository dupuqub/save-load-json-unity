using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UpdateLang : MonoBehaviour
{
  public void Account()
  {
    string json = Tools.GetFile("/Sources/_Common.json");
    Serials.Sources_Common snap = JsonUtility.FromJson<Serials.Sources_Common>(json);

    Header(snap.lang);
  }

  public void Header(string lang)
  {
    string json = Tools.GetFile("/Langs/" + lang + "/Header.json");
    Serials.LangsHeader snap = JsonUtility.FromJson<Serials.LangsHeader>(json);

    Text ButtonSettingsText = GameObject.Find("ButtonSettingsText").GetComponent<Text>();
    Text ButtonExitText = GameObject.Find("ButtonExitText").GetComponent<Text>();

    ButtonSettingsText.text = snap.settings;
    ButtonExitText.text = snap.exit;
  }
}
