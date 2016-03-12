//MainMenu
//Attached to Main Camera
using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public Texture backgroundTexture;

    public GUIStyle ButtonTexture;

    //Might want to get rid of these because they might be better if they are private or just a coeeficent in the if statement
    public float guiPlacementY1;
    public float guiPlacementY2;

    public float guiPlacementX1;
    public float guiPlacementX2;

    void OnGUI()
    {
        //Display Background Texture
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

      /*
        //Display Buttons with GUI outline
        if (GUI.Button(new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .5f, Screen.height * .1f), "Play Game"))
        {
            print("Clicked Play Game");
        }
        if (GUI.Button(new Rect(Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .5f, Screen.height * .1f), "Options"))
        {
            print("Clicked Play Game");
        }
      */

        //Without GUI outline
        if (GUI.Button(new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .5f, Screen.height * .1f), "", ButtonTexture))
        {
            print("Clicked Play Game");
        }
        if (GUI.Button(new Rect(Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .5f, Screen.height * .1f), "Options"))
        {
            print("Clicked Play Game");
        }
    }

}
