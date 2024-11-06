using UnityEngine;

public class SeatPlan : MonoBehaviour
{
    [SerializeField] private GameObject menschPrefab;
    [SerializeField] private GameObject myParent;

    void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            Instantiate(menschPrefab, myParent.transform);  // Erstelle einen Sitzplatz aus dem Prefab
        }  
    }
}
