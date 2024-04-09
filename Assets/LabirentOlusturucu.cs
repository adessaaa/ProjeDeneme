using UnityEngine;

public class LabirentOlusturucu : MonoBehaviour
{
    public GameObject kutuPrefab;
    public int labirentBoyutu = 10;
    public float kutuBoyutu = 1.0f;
    public float kenarBosluk = 0.2f;

    private void Start()
    {
        OlusturLabirent();
    }

    private void OlusturLabirent()
    {
        for (int i = 0; i < labirentBoyutu; i++)
        {
            for (int j = 0; j < labirentBoyutu; j++)
            {
                if (i % 2 == 0 && j % 2 == 0)
                {
                    GameObject kutu = Instantiate(kutuPrefab, new Vector3(i * kutuBoyutu + kenarBosluk * (i + 1), 0, j * kutuBoyutu + kenarBosluk * (j + 1)), Quaternion.identity);
                    kutu.transform.localScale = new Vector3(kutuBoyutu - 2 * kenarBosluk, 1, kutuBoyutu - 2 * kenarBosluk);
                }
            }
        }
    }
}