using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateLang
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

    Text settings = GameObject.Find("ButtonSettingsText").GetComponent<Text>();
    Text exit = GameObject.Find("ButtonExitText").GetComponent<Text>();

    settings.text = snap.settings;
    exit.text = snap.exit;
  }
}
