//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace cfg.list
{
   
public partial class TbListTest
{
    private readonly Dictionary<int, list.ListTest> _dataMap;
    private readonly List<list.ListTest> _dataList;
    
    public TbListTest(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, list.ListTest>();
        _dataList = new List<list.ListTest>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            list.ListTest _v;
            _v = list.ListTest.DeserializeListTest(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, list.ListTest> DataMap => _dataMap;
    public List<list.ListTest> DataList => _dataList;

    public list.ListTest GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public list.ListTest Get(int key) => _dataMap[key];
    public list.ListTest this[int key] => _dataMap[key];

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