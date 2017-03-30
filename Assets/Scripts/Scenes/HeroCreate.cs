using Models;
using UnityEngine;
using UnityEngine.UI;
using Scenes;
using System.Text.RegularExpressions;

public class HeroCreate : MonoBehaviour {

    public Button warrior;
    public Button rogue;
    public Button mage;
    public Button nextButton;
    public Button backButton;
    public Text characterName;
    public Sprite selectedBackground;
    public Sprite normalBackground;

    private string className;
    
    void Start ()
    {
        warrior.onClick.AddListener(warriorSelected);
        rogue.onClick.AddListener(rogueSelected);
        mage.onClick.AddListener(mageSelected);

        nextButton.interactable = false;
        nextButton.onClick.AddListener(createCharacter);
        backButton.onClick.AddListener(onBackButtonClick);
    }

    void Update()
    {
        if (isValidCharacterName() && className != null)
        {
            nextButton.interactable = true;
        } else
        {
            nextButton.interactable = false;
        }
    }

    public void onBackButtonClick()
    {
        SceneDirector.LoadScene(SceneDirector.SCENE_MAIN_MENU);
    }

    void warriorSelected()
    {
        changeSprite(warrior);
        className = Hero.CLASS_WARRIOR;
    }

    void rogueSelected()
    {
        changeSprite(rogue);
        className = Hero.CLASS_ROGUE;
    }

    void mageSelected()
    {
        changeSprite(mage);
        className = Hero.CLASS_MAGE;
    }

    void createCharacter()
    {
        var hero = Hero.Create(this.characterName.text, this.className);
        Player.Instance.AddHero(hero);
        Player.Instance.SetHero(hero);

        SceneDirector.LoadScene(SceneDirector.SCENE_HERO_HOME);
    }
    
    void changeSprite(Button button)
    {
        warrior.GetComponent<Image>().sprite = normalBackground;
        rogue.GetComponent<Image>().sprite = normalBackground;
        mage.GetComponent<Image>().sprite = normalBackground;

        button.GetComponent<Image>().sprite = selectedBackground;
    }

    bool isValidCharacterName()
    {
        return characterName.text.Length > 0 && Regex.IsMatch(characterName.text, @"^[a-zA-Zа-яА-Я]{4,16}$");
    }
}
