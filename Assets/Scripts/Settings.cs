using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject Container;

    // Update is called once per frame
    public void OpenSettings() //Creates opensettings method
    {
        Container.SetActive(true); //Displays container(settings menu)
    }
    public void SoundOn() //No sound yet
    {

    }
    public void SoundOff()
    {

    }


    public void BackButton() //Creates backbutton method
    {
        Container.SetActive(false); //Removes container
    }
}
