using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyBlockBehaviourScript : MonoBehaviour
{
    [SerializeField] private Color myColor;
    private MaterialPropertyBlock materialPropertyBlock;

    void Start()
    {
        UpdateColor();
    }

    void OnValidate()
    {
        UpdateColor();
    }

    private void UpdateColor()
    {
        // 作られていなければ作成
        materialPropertyBlock = (materialPropertyBlock == null) ? new MaterialPropertyBlock() : materialPropertyBlock;

        Renderer renderer = GetComponent<Renderer>();

        // この時点ですでにほかのスクリプトなどからMaterialPropertyBlockが
        // セットされているかもしれないので、まずは取得する
        renderer.GetPropertyBlock(materialPropertyBlock);

        // MaterialPropertyBlockに対して色をセットする
        materialPropertyBlock.SetColor("_Color", myColor);

        // MaterialPropertyBlockをセットする
        renderer.SetPropertyBlock(materialPropertyBlock);
    }
}


