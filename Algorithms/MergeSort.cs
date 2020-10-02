using Entities;

namespace Algorithms
{

    /*
     *  @author GeeksforGeeks: "https://www.geeksforgeeks.org/merge-sort/"
     */
    public class MergeSort
    {

        public void merge(Node[] entityNode, int l, int m, int r)
        {

            int leftSubArrSize = m - l + 1;
            int rightSubArrSize = r - m;


            // make two sub arrays one for the left half of the sub array
            // leaving the other half of the subarray.
            // fill both sub arrays.
            Node[] L = new Node[leftSubArrSize];
            Node[] R = new Node[rightSubArrSize];
            for (int a = 0; a < leftSubArrSize; a++)
            {
                L[a] = entityNode[l + a];
            }

            for (int a = 0; a < rightSubArrSize; a++)
            {
                R[a] = entityNode[m + 1 + a];
            }


            int i = 0, j = 0, k = l;


            // Replace back in sorted order.
            while (i < leftSubArrSize && j < rightSubArrSize)
            {
                if (L[i].xVal <= R[j].xVal)
                {
                    entityNode[k] = L[i];
                    i++;
                }
                else
                {
                    entityNode[k] = R[j];
                    j++;
                }
                k++;
            }

            // Finish trailing left array values.
            while (i < leftSubArrSize)
            {
                entityNode[k] = L[i];
                i++;
                k++;
            }

            // Finish trailing right array values.
            while (j < rightSubArrSize)
            {
                entityNode[k] = R[j];
                j++;
                k++;
            }
        }


        public void sort(Node[] entityNode, int l, int r)
        {
            if (l >= r)
                return;

            int m = (l + r) / 2;

            sort(entityNode, l, m);
            sort(entityNode, m + 1, r);

            merge(entityNode, l, m, r);

        }
    }
}
