//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace cfg.i18n
{
   
public partial class TbLang
{
    private readonly Dictionary<int, i18n.Lang> _dataMap;
    private readonly List<i18n.Lang> _dataList;
    
    public TbLang(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, i18n.Lang>();
        _dataList = new List<i18n.Lang>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            i18n.Lang _v;
            _v = i18n.Lang.DeserializeLang(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, i18n.Lang> DataMap => _dataMap;
    public List<i18n.Lang> DataList => _dataList;

    public i18n.Lang GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public i18n.Lang Get(int key) => _dataMap[key];
    public i18n.Lang this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}