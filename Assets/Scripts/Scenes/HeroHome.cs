using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Objects;
using Models;
using System.Collections;

namespace Scenes
{
    public class HeroHome : MonoBehaviour
    {

        public Text CharacterName;
        public Text CharacterLevel;
        public Text CharacterClass;
        public Image CharacterClassIcon;
        public ProgressBar ExpBar;
        public ProgressBar HPBar;
        public ProgressBar MPBar;

        public Text STR;
        public Text CON;
        public Text DEX;
        public Text INT;
        public Text MEN;
        public Text WIT;

        public Text PAtk;
        public Text PDef;
        public Text ASpd;
        public Text Crit;
        public Text MAtk;
        public Text MDef;
        public Text Cast;
        public Text MCri;

        void Start()
        {
            HPBar.setValues(Player.Instance.GetHero().GetHP(), Player.Instance.GetHero().GetMaxHP());
            MPBar.setValues(Player.Instance.GetHero().GetMP(), Player.Instance.GetHero().GetMaxMP());
            //ExpBar.setValues(player.GetActiveCharacter().exp, player.GetActiveCharacter().GetMaxLevelExperience());

            GameObject menuButton = GameObject.Find("MenuButton");
            Button b = menuButton.GetComponent<Button>();
            b.onClick.AddListener(onMenuClick);

            //Sprite characterIcon = Resources.Load<Sprite>("Images/icons/" + player.GetActiveCharacter().GetClassName());
            //CharacterClassIcon.sprite = characterIcon;
        }

        void onMenuClick()
        {
            SceneManager.LoadScene("main-menu");
        }
    }
}
