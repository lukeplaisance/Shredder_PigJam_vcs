using UnityEngine;

public class PigjamTrackspawnII : MonoBehaviour
{


    public GameObject _block1;
    public GameObject _block2;
    public GameObject _block3;
    private GameObject _block1inst;
    private GameObject _block2inst;
    private GameObject _block3inst;
    private Vector3 vecInstance1 = new Vector3(0, 0, 0);
    private Vector3 vecInstance2 = new Vector3(0, 0, 10);
    private Vector3 vecInstance3 = new Vector3(0, 0, 20);



    void Start()
    {
        _block1inst = Instantiate(_block1, vecInstance1, Quaternion.identity);
        _block2inst = Instantiate(_block2, vecInstance2, Quaternion.identity);
        _block3inst = Instantiate(_block3, vecInstance3, Quaternion.identity);

    }
    void Update()
    {
        if(_block1inst.transform.position.z < -10f)
        {
            Destroy(_block1inst.gameObject);
            _block1inst = Instantiate(_block1, vecInstance3, Quaternion.identity);
        }
        if (_block2inst.transform.position.z < -10f)
        {
            Destroy(_block2inst.gameObject);
            _block2inst = Instantiate(_block2, vecInstance3, Quaternion.identity);
        }
        if (_block3inst.transform.position.z < -10f)
        {
            Destroy(_block3inst.gameObject);
            _block3inst = Instantiate(_block3, vecInstance3, Quaternion.identity);
        }
    }

}
