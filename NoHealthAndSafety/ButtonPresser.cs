using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace NoHealthAndSafety
{
    class ButtonPresser : MonoBehaviour
    {
        private IEnumerator clickIt()
        {
            yield return new WaitForSeconds(.5f);
            foreach (HMUI.NoTransitionsButton button in FindObjectsOfType<HMUI.NoTransitionsButton>())
            {
                //Resources.FindObjectsOfTypeAll<HMUI.NoTransitionsButton>()
                if (button.name == "Continue")
                {
                    button.onClick.Invoke();
                }
            }
        }

        void Start()
        {
            StartCoroutine(clickIt());
        }
    }
}