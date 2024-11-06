List<int> unsortedNumbers = new List<int>() {1, 23, 3, 100, 34, 333, 234, 2, 34};

static List<int> QuickSort(List<int> array)
{
    if (array.Count < 2)
    {
        return array;
    }
    
    int pivotIndex = new Random().Next(0, array.Count - 1);
    int pivot = array[pivotIndex];
    List<int> middle = new List<int>(){ pivot };
    List<int> left = new List<int>();
    List<int> right = new List<int>();

    foreach (var i in array)
    {
        if (i < pivot)
        {
            left.Add(i);
        }
        if (i > pivot)
        {
            right.Add(i);
        }
    }

    List<int> rtrn = new List<int>();
    rtrn = rtrn.Concat(QuickSort(left).Concat(middle.Concat(QuickSort(right)))).ToList();
    return rtrn;
}

List<int> sortednumbers = QuickSort(unsortedNumbers);
Console.WriteLine(string.Join(" ", sortednumbers));