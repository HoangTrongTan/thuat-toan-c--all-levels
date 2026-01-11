//❓ CÂU 1
//Cho một mảng số nguyên nums.
//👉 Hãy trả về mảng các phần tử xuất hiện đúng 1 lần,
//giữ nguyên thứ tự xuất hiện ban đầu.
//Yêu cầu:
//Thời gian: O(n)
//Không dùng sort
//Không mutate mảng input
using System.Collections.Generic;
using System.ComponentModel;
class UniqueElements
{
    int[] items = { 4, 3, 2, 7, 3, 4, 8 };
    public int[] getUniqueElements(int[] items)
    {
        List<int> number = new List<int>();
        int n = items.Length;
        for(int i = 0; i < n; i ++)
        {
            if (!number.Contains(items[i])) //Contains của List là O(n)  trong vòng for → O(n²)
            {
                number.Add(items[i]);
            } else
            {
                number.Remove(items[i]);
            }
        }
        return number.ToArray();
    }

    public int[] GetUniqueElements(int[] items)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> results = new List<int>();
        foreach(int x in items)
        {
            if (dict.ContainsKey(x))
            {
                dict[x]++;
            } else
            {
                dict[x] = 1;
            }
        }
        //return dict.Where(x => x.Value == 1).Select(x => x.Key).ToArray(); //Dictionary KHÔNG đảm bảo thứ tự items
        foreach(var i in items) // phải duyệt qua arr ban đầu để giữ thứ tự
        //“Để đảm bảo thứ tự xuất hiện theo input, vì Dictionary không guarantee order.”
        {
            if (dict[i] == 1) results.Add(i);
        }
        return results.ToArray();
    }
};