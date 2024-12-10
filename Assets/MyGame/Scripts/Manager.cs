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
        Transform chairPos1 = table.transform.Find("chairPos1");
        Transform chairPos2 = table.transform.Find("chairPos2");

        if (chairPos1 != null)
        {
            GameObject chair1 = Instantiate(chairPrefab, chairPos1.position, chairPos1.rotation, table.transform);
            chair1.transform.localPosition = chairPos1.localPosition; // Ensure local alignment
        }
        else
        {
            Debug.LogWarning("ChairPos1 not found");
        }

        if (chairPos2 != null)
        {
            GameObject chair2 = Instantiate(chairPrefab, chairPos2.position, chairPos2.rotation, table.transform);
            chair2.transform.localPosition = chairPos2.localPosition; // Ensure local alignment
        }
        else
        {
            Debug.LogWarning("ChairPos2 not found");
        }
    }

}
