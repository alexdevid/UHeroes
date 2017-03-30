using Models;
using Scenes;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class MainMenu : MonoBehaviour {
    
    public Canvas canvas;

	// Use this for initialization
	void Start ()
    {
        this.addMenuButton("PLAY", new Vector2(0, 162), onPlayClickEvent);
        this.addMenuButton("OPTIONS", new Vector2(0, 81), onOptionsClicEvent);
        this.addMenuButton("CREDITS", new Vector2(0, 0), OnCreditsClickEvent);
        this.addMenuButton("EXIT", new Vector2(0, -81), onQuitClickEvent);

        GameObject ornamentTop = (GameObject)Instantiate(Resources.Load("prefabs/MenuOrnamentTop"));
        ornamentTop.transform.position = new Vector2(0, 162 + (81 / 2) + (21 / 2));
        ornamentTop.transform.SetParent(canvas.transform, false);

        GameObject ornamentBot = (GameObject)Instantiate(Resources.Load("prefabs/MenuOrnamentBot"));
        ornamentBot.transform.position = new Vector2(0, -81 - (81 / 2) - (21 / 2));
        ornamentBot.transform.SetParent(canvas.transform, false);
    }
    
    GameObject addMenuButton(string text, Vector2 position, UnityAction callback)
    {
        GameObject button = (GameObject)Instantiate(Resources.Load("prefabs/MenuButton"));
        button.GetComponentInChildren<Text>().text = text;
        button.transform.position = position;
        button.transform.SetParent(canvas.transform, false);

        Button b = button.GetComponent<Button>();
        b.onClick.AddListener(delegate { callback(); });

        return button;
    }

    void onPlayClickEvent()
    {
        if (Player.Instance.GetHeroes().Count > 0)
        {
            //TODO load character selection scene
            SceneDirector.LoadScene(SceneDirector.SCENE_HERO_HOME);
        } else
        {
            SceneDirector.LoadScene(SceneDirector.SCENE_HERO_CREATE);
        }

    }

    void onOptionsClicEvent()
    {
        SceneDirector.LoadScene(SceneDirector.SCENE_OPTIONS);
    }

    void OnCreditsClickEvent()
    {
        SceneDirector.LoadScene(SceneDirector.SCENE_OPTIONS);
    }

    void onQuitClickEvent()
    {
        Application.Quit();
    }
}
