//❓ CÂU 4
//Cho một mảng số nguyên nums.
//👉 Hãy tìm cặp số có tổng bằng target
//(trả về chỉ số index, không phải giá trị).
//Yêu cầu:
//O(n)
//Không sort
//Không mutate input
//📌 Ví dụ:
//nums = [2, 7, 11, 15]
//target = 9
//Output = [0, 1]

class DoubleNumberEqualsToTarget
{
    int[] nums = { 2, 7, 11, 15 };
    int target = 9;
    public int[] GetDoubleEqualsToTarget() // -> O(n²)
    // Vòng i chạy tối đa n lần
    // Với mỗi i, vòng j chạy trung bình (n - i) lần
    {
        int n = this.nums.Length;
        for(int i = 0; i < n; i ++)
        {
            for(int j = i+1; j < n; j++)
            {
                if (this.nums[i] + this.nums[j] == target)
                {
                    return new int[] { nums[i], nums[j] };
                }
            }
        }
        return Array.Empty<int>();
    }
    public int[] GetDoubleEqualsTarget2() // optimized
    {
        Dictionary<int, int> filter = new Dictionary<int, int>();
        int n = this.nums.Length;
        for(int i = 0;i < n; i ++)
        {
            int need = this.target - this.nums[i];
            if (filter.ContainsKey(need))
            {
                return new int[] { filter[need], i };
            }
            filter.Add(this.nums[i], i);
        }
        return Array.Empty<int>();
    }
}