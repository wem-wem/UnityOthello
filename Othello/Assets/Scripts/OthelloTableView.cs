using UnityEngine;
using System.Collections;

public class OthelloTableView : MonoBehaviour
{
    [SerializeField]
    private GameObject _cell = null;
    public GameObject Cell
    {
        get
        {
            if (_cell != null) { return _cell; }
            _cell = Resources.Load<GameObject>("Cell/Cell");
            return _cell;
        }
    }

    void Start()
    {
        const float offset = 1.05f;
        for (var x = 0; x < 8; ++x)
        {
            for (var z = 0; z < 8; ++z)
            {
                var cell = Instantiate(Cell);
                cell.name = Cell.name + "(" + x + "," + z + ")";
                cell.transform.Translate((x * offset), 0, (z * offset));
                cell.transform.parent = transform;
            }
        }
    }

    void Update()
    {

    }
}
