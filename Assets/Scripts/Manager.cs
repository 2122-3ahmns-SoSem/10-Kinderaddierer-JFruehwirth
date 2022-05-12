using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public enum MyScenes
{
    Welcome,
    Main,
    End
}
// Hilfsstruktur

public class Manager : MonoBehaviour
{
    public TMP_InputField ipfKidsName;

    public TMP_Text displayKidsName;

    private SoRuntimeData runtimeData;

    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

        /* if (SceneManager.GetActiveScene().buildIndex == MyScenes.Welcome)
        {
            displayKidsName.text = runtimeData.nameKid;
        } */

        if (SceneManager.GetActiveScene().buildIndex == (int)MyScenes.Main)
        {
            Debug.Log("In Scene Main" + runtimeData.nameKid);
            displayKidsName.text = runtimeData.nameKid;
        }
    }

    public void SwitchTheScene(int x)
    {
        Debug.Log("BTN pressed, get kidsname " + ipfKidsName.text);
        runtimeData.nameKid = ipfKidsName.text;

        SceneManager.LoadScene(x);    
    }
    // aus einem Skript wird eine Szene geladen


    public void SwitchTheScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    // ---


    public void SwitchToMain()
    {
        SceneManager.LoadScene((int)MyScenes.Main);
    }
        public void SwitchToEnd()
    {
        SceneManager.LoadScene((int)MyScenes.End);
    }
    // Jede Szene wird einzeln aufgerufen, muss dann auch für jede Scene eine Methode aufschreiben
}
