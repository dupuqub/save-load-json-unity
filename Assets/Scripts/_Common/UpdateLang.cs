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

      GameObject selector = GameObject.Find("AccountSelector" + index);
      GameObject inputObject = selector.transform.GetChild(5).gameObject;
      InputField input = inputObject.GetComponent<InputField>();
      Text percent = selector.transform.GetChild(3).gameObject.GetComponent<Text>();
      Text discovered = selector.transform.GetChild(4).gameObject.GetComponent<Text>();
      Text name = inputObject.transform.GetChild(0).gameObject.GetComponent<Text>();
      bool playerExists = snapPlayer.name == "null";

      percent.text = "0" + "%";
      discovered.text = snapAccount.discovered;
      name.text = playerExists ? snapAccount.newPlayer : snapPlayer.name;

      percent.color = playerExists ? percent.color : new Color(1.0f, 1.0f, 1.0f);
      name.color = playerExists ? name.color : new Color(1.0f, 1.0f, 1.0f);

      input.characterLimit = 10;
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
