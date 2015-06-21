#region Assembly Assembly-CSharp.dll, v1.0.0.0
// C:\Users\boone\KSP_Lite\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

public class RDArchivesController : MonoBehaviour
{
    public BTButton btnExpand;
    public BTButton btnReset;
    public RDDropDownListContainer dropdownListContainer;
    public UIButton instructorComponent;
    public int instructorPortraitSize;
    public GameObject instructorPrefab;
    public SpriteTextRich instructorText;
    public RenderTexture instructorTexture;
    public UIScrollList planetList;
    public GameObject planetListItemPrefab;
    public RDScrollbar planetListScrollbar;
    public GameObject reportItemContainer;
    public RomfarerScrollList reportList;
    public ScrollListResizer reportListResizer;
    public RomfarerSlider reportListScrollbar;
    public int reportListSizeMax;
    public SpriteText reportsFoundLabel;
    public UIStateToggleBtn reportSortData;
    public UIStateToggleBtn reportSortName;
    public UIStateToggleBtn reportSortScience;
    public UIStateToggleBtn reportSortValue;
    public PSystem systemPrefab;

    public extern RDArchivesController();

    public extern static Func<T, bool> And<T>(params Func<T, bool>[] predicates);

    public struct Filter
    {
        public string key;
        public string value;

        public extern Filter(string key, string value);
    }

    public struct ReportData
    {
        public float data;
        public string description;
        public string id;
        public float science;
        public float value;

        public extern ReportData(string id, string description, float data, float value, float science);
    }
}
