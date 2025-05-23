using UnityEngine;

public class Testing : MonoBehaviour
{
    //[SerializeField] private Transform gridDebugObjectPrefab;

    //private GridSystem gridSystem;

    [SerializeField] private Unit unit;
    
    private void Start()
    {
        //gridSystem = new GridSystem(10, 10, 2f);
        //gridSystem.CreateDebugObjects(gridDebugObjectPrefab);
    }

    private void Update()
    {
        //Debug.Log(gridSystem.GetGridPosition(MouseWorld.GetPosition()));
        if (Input.GetKeyDown(KeyCode.T))
        {
            unit.GetMoveAction().GetValidActionGridPositionList();
        }
    }
}
