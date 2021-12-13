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
                    GameObject[] gos = FindObjectsOfType<GameObject>();
                    UIButton goButton = null;
                    foreach (GameObject go in gos)
                    {
                        if (go.name == "button_template(Clone)")
                        {
                            UIButton testButton = go.GetComponent<UIButton>();
                            if (testButton?.ButtonText.text == "I Understand")
                            {
                                goButton = testButton;
                            }
                        }
                    }
                    goButton.onClick?.Invoke();
                    Destroy(this);
                }
            }
        }
    }
}
