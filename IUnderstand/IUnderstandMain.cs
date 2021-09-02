using System;
using UnityEngine;
using UI;

namespace IUnderstand
{
    public class IUnderstandMain : MonoBehaviour
    {
        int frameCountdown = 50;

        public void Start()
        {
        }

        public void Update()
        {
            if (frameCountdown > 0)
            {
                frameCountdown--;
                if (frameCountdown == 0)
                {
                    GameObject[] gos = GameObject.FindObjectsOfType<GameObject>();
                    GameObject goButton = null;
                    foreach (GameObject go in gos)
                    {
                        if (go.name == "button_template(Clone)")
                        {
                            goButton = go;
                        }
                    }
                    goButton?.GetComponent<UIButton>()?.onClick.Invoke();
                    Destroy(this);
                }
            }
        }
    }
}
