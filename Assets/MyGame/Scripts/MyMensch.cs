using UnityEditor.Media;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class MyMensch : MonoBehaviour
{
    // Instanzvariablen
    public string namePerson;
    public string rolleInKlasse;
    public Color augenfarbe;

    [SerializeField] private AudioSource myAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mein Name: " + namePerson);
        Debug.Log("Meine Rolle in der Klasse: " + rolleInKlasse);
        Debug.Log("Meine Augenfarbe: " + augenfarbe);

        // Hole die Komponente AudioSource
        myAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Sobald die Leertaste gedrueckt wird
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Leertaste gedrückt!");
            myAudioSource.Play();
        } else if(Input.GetKeyUp(KeyCode.Space))
        {
            myAudioSource.Stop();
        }
    }
}
