using UnityEngine;
using UnityEngine.UI;

public class MenuStart : MonoBehaviour
{
    [SerializeField] private GameObject[] _menuCanvases;

    [SerializeField] private int _dontFirstInGame;

    [SerializeField] private Text _nameInputText;
    [SerializeField] private Text _surnameInputText;
    [SerializeField] private Text _fatherstvoInputText;

    [SerializeField] private string _name;
    [SerializeField] private string _surname;
    [SerializeField] private string _fatherstvo;


///////// 0 - buttons ////// 1 - menu //////// 2 - dataOfPlayer //////
    private void Start()
    {
        _dontFirstInGame = PlayerPrefs.GetInt("GameUser");

        _menuCanvases[0].SetActive(false);
        _menuCanvases[2].SetActive(false);
        _menuCanvases[1].SetActive(true);

        _name = PlayerPrefs.GetString("DataOfName");
        _surname = PlayerPrefs.GetString("DataOfSurName");
        _fatherstvo = PlayerPrefs.GetString("DataOfFatherstvo");
    }

    public void StartGame()
    {
        if(_dontFirstInGame == 0)
        {
            _menuCanvases[1].SetActive(false);
            _menuCanvases[2].SetActive(true);
        }


        else
        {
            Destroy(_menuCanvases[2]);
            _menuCanvases[1].SetActive(false);
            _menuCanvases[0].SetActive(true); 
        }  
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            PlayerPrefs.DeleteAll();
        }
    }

    ///////////////DATA//OF//PLAYER////////////

    public void SaveDataOfPlayer()
    {
        PlayerPrefs.SetInt("GameUser", 1);  

        _name = _nameInputText.text;
        _surname = _surnameInputText.text;
        _fatherstvo = _fatherstvoInputText.text;
    
        PlayerPrefs.SetString("DataOfName", _name);
        PlayerPrefs.SetString("DataOfSurName", _surname);
        PlayerPrefs.SetString("DataOfFatherstvo", _fatherstvo);

        _menuCanvases[2].SetActive(false);
        _menuCanvases[0].SetActive(true);
    }

}
