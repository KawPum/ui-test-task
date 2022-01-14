using UnityEngine;
using UnityEngine.UI;

public class WindowsController : MonoBehaviour {
    [SerializeField] private Button openWindow1;
    [SerializeField] private Button openWindow2;
    [SerializeField] private Button openMenu;
    [SerializeField] private Button crossWindow1;
    [SerializeField] private Button useWindow1;
    [SerializeField] private Button crossWindow2;
    [SerializeField] private Button useWindow2;

    [SerializeField] private GameObject window1;
    [SerializeField] private GameObject window2;
    [SerializeField] private GameObject menu;
    
    private void Awake() {
        openWindow1.onClick.AddListener(OpenWindow1);
        crossWindow1.onClick.AddListener(OpenMenu);
        useWindow1.onClick.AddListener(OpenMenu);

        openWindow2.onClick.AddListener(OpenWindow2);
        //crossWindow2.onClick.AddListener(OpenMenu);
        //useWindow2.onClick.AddListener(OpenMenu);

        openMenu.onClick.AddListener(OpenMenu);
    }

    private void OpenWindow1() {
        window1.SetActive(true);
        openMenu.gameObject.SetActive(true);
        window2.SetActive(false);
        menu.SetActive(false);
    }
    
    private void OpenWindow2() {
        window1.SetActive(false);
        openMenu.gameObject.SetActive(true);
        window2.SetActive(true);
        menu.SetActive(false);
    }
    
    private void OpenMenu() {
        window1.SetActive(false);
        window2.SetActive(false);
        menu.SetActive(true);
        openMenu.gameObject.SetActive(false);
    }
}
