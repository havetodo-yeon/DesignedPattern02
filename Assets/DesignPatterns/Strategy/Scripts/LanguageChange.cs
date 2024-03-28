using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Language
{
    Korean, English
}

public class LanguageChange : MonoBehaviour
{
    public string playerName;
    private string info;
    public int playerLevel;
    public Text infoText;

    public void Korean()
    {
        ChangeLanguage(Language.Korean);
    }

    public void English()
    {
        ChangeLanguage(Language.English);
    }


    public void ChangeLanguage(Language language)
    {
        switch (language)
        {
            case Language.English:
                info = $"\nLanguage : English\n\nPlayer Name : {playerName}\nPlayer Level : {playerLevel}";
                break;
            case Language.Korean:
                info = $"\n��� : �ѱ���\n\n�÷��̾� �̸� : {playerName}\n�÷��̾� ���� : {playerLevel}";
                break;
        }
    }

    public void SelectButton()
    {
        infoText.text = info;
    }

}
