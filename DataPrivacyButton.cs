using System;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UnityEngine.Analytics
{
    public class DataPrivacyButton : Button
    {
        private bool urlOpened;

        private DataPrivacyButton()
        {
            return;
        }

        private void OnFailure(string reason)
        {
            return;
        }

        private void OpenUrl(string url)
        {
            return;
        }

        private void OpenDataPrivacyUrl()
        {
            this.interactable = false;
            DataPrivacy.FetchPrivacyUrl(new Action<string>(this.OpenUrl), new Action<string>(this.OnFailure));
        }

        private void OnApplicationFocus(bool hasFocus)
        {
            return;
        }
    }
}
