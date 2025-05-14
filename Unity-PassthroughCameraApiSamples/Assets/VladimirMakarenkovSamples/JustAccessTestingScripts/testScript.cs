using PassthroughCameraSamples;
using System.Collections;
using UnityEngine;
using Unity.Sentis;

public class testScript : MonoBehaviour
{
    [SerializeField] private WebCamTextureManager m_webCamTextureManager;
    private WebCamTexture webCamTexture = null;



//    [SerializeField] private RawImage m_image;

    public IEnumerator Start()
    {
        while (m_webCamTextureManager.WebCamTexture == null)
        {
            yield return null;
        }
        webCamTexture = m_webCamTextureManager.WebCamTexture;




        GetComponent<Renderer>().material.mainTexture = webCamTexture;
    }


}
