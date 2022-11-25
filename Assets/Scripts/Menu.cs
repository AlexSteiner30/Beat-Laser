using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public XRController controller = null;
    InputDevice device;

    private void Start()
    {

    }

    void Update()
    {
        XPressed();

    }

    public void XPressed()
    {
        bool press;

        device.TryGetFeatureValue(CommonUsages.primaryButton, out press);

        if(press)
        {
            SceneManager.LoadScene(1);
        }
    }
}
