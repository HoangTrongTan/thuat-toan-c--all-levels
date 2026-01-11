//❓ BÀI 3 – LG RẤT HAY HỎI
//Cho chuỗi s, tìm ký tự đầu tiên không bị lặp lại (case-sensitive).
//O(n), không LINQ.
//📌 Ví dụ:
//"aAbBABac" → 'c'
class case_string_sensitive
{
    string str = "aAbBABac";
    public string GetStringSensitive()
    {
        string result = "";
        Dictionary<char, int> filterDict = new Dictionary<char, int>();
        foreach(char i in this.str)
        {
            if (filterDict.ContainsKey(i))
            {
                filterDict[i]++;
            } else
            {
                filterDict.Add(i, 1);
            }
        }
        foreach(char i in this.str)
        {
            if (filterDict[i] == 1)
            {
                result = i.ToString();
                break;
            }
        }
        return result;
    }
}