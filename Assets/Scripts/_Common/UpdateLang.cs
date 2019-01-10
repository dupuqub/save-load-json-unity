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
      Text percent = selector.transform.GetChild(3).gameObject.GetComponent<Text>();
      Text discovered = selector.transform.GetChild(4).gameObject.GetComponent<Text>();

      GameObject input = selector.transform.GetChild(5).gameObject;
      InputField field = input.GetComponent<InputField>();
      Text placeholder = field.placeholder.GetComponent<Text>();
      bool playerExists = snapPlayer.name != "";

      percent.text = "0" + "%";
      discovered.text = snapAccount.discovered;
      placeholder.text = playerExists ? snapPlayer.name : snapAccount.newPlayer;

      percent.color = playerExists ? new Color(1.0f, 1.0f, 1.0f) : percent.color;
      placeholder.color = playerExists ? new Color(1.0f, 1.0f, 1.0f) : placeholder.color;

      field.characterLimit = 10;
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
