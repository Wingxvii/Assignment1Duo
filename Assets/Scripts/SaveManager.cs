using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public sealed class SaveManager
{
    #region SingletonCode
    //singleton pattern begins here
    private static readonly SaveManager instance = new SaveManager();
    static SaveManager(){}
    private SaveManager(){}
    public static SaveManager Instance{ get { return instance; }}
    //single pattern ends here
    #endregion  

    public void Save()
    {

    }
    public void Load()
    {

    }

    static List<string> tokenize(char token, string text)
    {
        List<string> temp = new List<string>();
        int lastTokenLocation = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == token)
            {
                temp.Add(text.Substring(lastTokenLocation, i - lastTokenLocation));
                lastTokenLocation = i + 1;
            }
        }
        return temp;
    }


}
