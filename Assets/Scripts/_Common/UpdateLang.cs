using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateLang
{
  public static void Account()
  {
    string jsonCommon = Tools.GetFile("/Sources/_Common.json");
    Serials.SourcesCommon snapCommon = JsonUtility.FromJson<Serials.SourcesCommon>(jsonCommon);

    string jsonAccount = Tools.GetFile("/Langs/" + snapCommon.lang + "/Account.json");
    Serials.SourcesAccount snapAccount = JsonUtility.FromJson<Serials.SourcesAccount>(jsonAccount);

    for(int index = 0; index < 4; index ++)
    {
      string jsonPlayer = Tools.GetFile("/Accounts/" + index + "/Player.json");
      Serials.Player snapPlayer = JsonUtility.FromJson<Serials.Player>(jsonPlayer);

      GameObject selector0 = GameObject.Find("AccountSelector" + index);
      Text _0 = selector0.transform.GetChild(2).gameObject.GetComponent<Text>();
      Text _1 = selector0.transform.GetChild(3).gameObject.GetComponent<Text>();
      Text _2 = selector0.transform.GetChild(4).gameObject.GetComponent<Text>();
      bool playerExists = snapPlayer.name == "null";

      _0.text = "0" + "%";
      _1.text = snapAccount.discovered;
      _2.text = playerExists ? snapAccount.newPlayer : snapPlayer.name;

      _0.color = playerExists ? _0.color : new Color(1.0f, 1.0f, 1.0f);
      _2.color = playerExists ? _2.color : new Color(1.0f, 1.0f, 1.0f);
    }

    Text question = GameObject.Find("QuestionText").GetComponent<Text>();
    question.text = snapAccount.question;

    Header(snapCommon.lang);
  }

  public static void Header(string lang)
  {
    string json = Tools.GetFile("/Langs/" + lang + "/Header.json");
    Serials.LangsHeader snap = JsonUtility.FromJson<Serials.LangsHeader>(json);

    Text settings = GameObject.Find("ButtonSettingsText").GetComponent<Text>();
    Text exit = GameObject.Find("ButtonExitText").GetComponent<Text>();

    settings.text = snap.settings;
    exit.text = snap.exit;
  }
}
