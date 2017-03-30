using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Objects
{
    public class ProgressBar : MonoBehaviour
    {

        public Image foregroundImage;
        public Text text;

        public void setValues(int actual, int total)
        {
            text.text = actual + " / " + total;
            foregroundImage.fillAmount = (actual * 100 / total) / 100f;
        }
    }
}
