//❓ CÂU 2 – LG STYLE
//Cho mảng số nguyên nums.
//👉 Tìm phần tử đầu tiên bị lặp lại
//(nếu không có, trả về -1).
//Yêu cầu:
//O(n)
//Không sort
//Không mutate input
//📌 Ví dụ:
//Input: [5, 1, 2, 3, 2, 4]
//Output: 2

class find_first_element_repeated
{
    int[] nums = { 5, 1, 3, 3, 2, 4 };
    public int GetFristElementRepeated()
    {
        HashSet<int> dict = new HashSet<int>();
        int found = -1;
        foreach(int i in this.nums)
        {
            if (dict.Contains(i))
            {
                found = i;
                break;
            } else
            {
                dict.Add(i);
            }
        }
        return found;
    }
}