using System;
using System.Diagnostics.Tracing;
using System.Text;
using System.Xml.XPath;

namespace Questions
{
    public class Code
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var numbers = new int[nums1.Length + nums2.Length];

            if (nums1.Length == 0 && nums2.Length == 0)
            {
                return 0;
            }
            if (nums1.Length >= nums2.Length)
            {

                if (numbers.Length % 2 == 1)
                {
                    int i = 0;
                    int j = 0;
                    int index = 0;
                    while (index <= numbers.Length / 2)
                    {
                        if (i >= nums1.Length)
                        {
                            numbers[index] = nums2[j];
                            j++;
                        }
                        else if (j >= nums2.Length)
                        {
                            numbers[index] = nums1[i];
                            i++;
                        }
                        else if (nums1[i] <= nums2[j])
                        {
                            numbers[index] = nums1[i];
                            i++;
                        }
                        else
                        {
                            numbers[index] = nums2[j];
                            j++;
                        }

                        index++;
                    }

                    return numbers[(numbers.Length - 1) / 2];

                }
                else
                {
                    int i = 0;
                    int j = 0;
                    int index = 0;
                    while (index <= (numbers.Length + 1) / 2)
                    {
                        if (i >= nums1.Length )
                        {
                            numbers[index] = nums2[j];
                            j++;
                        }
                        else if (j >= nums2.Length)
                        {
                            numbers[index] = nums1[i];
                            i++;
                        }
                        else if (nums1[i] <= nums2[j])
                        {
                            numbers[index] = nums1[i];
                            i++;
                        }
                        else
                        {
                            numbers[index] = nums2[j];
                            j++;
                        }
                        index++;
                    }

                    var nu1 = Convert.ToDouble(numbers[(numbers.Length / 2) - 1]);
                    var nu2 = Convert.ToDouble(numbers[numbers.Length / 2]);
                    var result = (nu1 + nu2) / 2;
                    return result;
                }

            }
            if (nums1.Length < nums2.Length)
            {

                if (numbers.Length % 2 == 1)
                {
                    int i = 0;
                    int j = 0;
                    int index = 0;
                    while (index <= numbers.Length / 2)
                    {
                        if (i >= nums2.Length)
                        {
                            numbers[index] = nums1[j];
                            j++;
                        }
                        else if (j >= nums1.Length)
                        {
                            numbers[index] = nums2[i];
                            i++;
                        }
                        else if (nums2[i] <= nums1[j])
                        {
                            numbers[index] = nums2[i];
                            i++;
                        }
                        else
                        {
                            numbers[index] = nums1[j];
                            j++;
                        }
                        index++;
                    }

                    return numbers[(numbers.Length - 1) / 2];

                }
                else
                {
                    int i = 0;
                    int j = 0;
                    int index = 0;
                    while (index <= (numbers.Length + 1) / 2)
                    {
                        if (i >= nums2.Length)
                        {
                            numbers[index] = nums1[j];
                            j++;
                        }
                        else if (j >= nums1.Length)
                        {
                            numbers[index] = nums2[i];
                            i++;
                        }
                        else if (nums2[i] <= nums1[j])
                        {
                            numbers[index] = nums2[i];
                            i++;
                        }
                        else
                        {
                            numbers[index] = nums1[j];
                            j++;
                        }

                        index++;
                    }
                    var nu1 = Convert.ToDouble(numbers[(numbers.Length / 2) - 1]);
                    var nu2 = Convert.ToDouble(numbers[numbers.Length / 2]);
                    var result = (nu1 + nu2) / 2;
                    return result;
                }

            }

            return 0;
        }
    }
}
