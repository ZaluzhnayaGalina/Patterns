namespace Strategy
{
    class InsertSort : ISortable
    {
        public double[] Sort(double[] unsorted)
        {
            for(var i=1;i<unsorted.Length; i++)
            {
                InsertInSortedArray(unsorted, i);

            }
            return unsorted;
        }
        private void InsertInSortedArray(double[] array, int SortedLength)
        {
            int CurrentIndex = SortedLength - 1;
            double InsertingElement = array[SortedLength];
            var key = array[CurrentIndex];
            while (CurrentIndex>=0 && array[CurrentIndex]> InsertingElement)
            {
                array[CurrentIndex + 1] = array[CurrentIndex];
                CurrentIndex--;
            }
            array[CurrentIndex + 1] = InsertingElement;
        }
    }
}
 