using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tableLayout;
    [SerializeField] private StudentData[] students;
    [SerializeField] private GameObject tablePrefab;
    [SerializeField] private GameObject chairPrefab;
    [SerializeField] private GameObject sitzplanPrefab;
    void Start()
    {
        for (int row = 0; row < tableLayout.rows; row++)
        {
            for (int col = 0; col < tableLayout.columns; col++)
            {
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing);
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);
                PlaceChairsAtTable(table);
            }
           
        }
    }
    private void PlaceChairsAtTable(GameObject table)
    {
        // Suche nach ChairPos1 und ChairPos2 im Tisch-Objekt
        Transform chairPos1 = table.transform.Find("ChairPos1");
        Transform chairPos2 = table.transform.Find("ChairPos2");

        // Prüfen, ob die Positionen existieren
        if (chairPos1 != null)
        {
            Instantiate(chairPrefab, chairPos1.position, chairPos1.rotation, table.transform);
        }

        if (chairPos2 != null)
        {
            Instantiate(chairPrefab, chairPos2.position, chairPos2.rotation, table.transform);
        }
        else
        {
            Debug.LogWarning("ChairPos nicht gefunden");
        }
    }
}
