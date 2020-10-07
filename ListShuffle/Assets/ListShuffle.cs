using System.Linq;
using System.Collections.Generic;

public static class ListShuffle
{
    /// <summary>
    /// 渡されたリストの中身をシャッフルして返す
    /// </summary>
    /// <param name="list">リスト</param>
    /// <returns>シャッフル後のリスト</returns>
    public static List<int> GetListShuffle( List<int> list )
    {
        return list.OrderBy( v => System.Guid.NewGuid() ).ToList();  
    }
}