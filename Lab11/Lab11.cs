/*
 * Student ID :1690700115
 * Name       :jiraroj Ieowsuwan
 * Section    :129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
using UnityEngine;

public class Lab11 : MonoBehaviour
{
    [SerializeField] int[] numbers = { 12, 7, 30, 4, 19, 25, 9, 18 };

    int sum;
    float average;
    int maximum;
    int minimum;

    void Start()
    {      
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log("Number " + (i + 1) + ": " + numbers[i]);
        }

        // Step 3: ผลรวมและค่าเฉลี่ย
        sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        average = (float)sum / numbers.Length;
        Debug.Log("Sum: " + sum);
        Debug.Log("Average: " + average);

        // Step 4: ค่าสูงสุดและค่าต่ำสุด
        maximum = numbers[0];
        minimum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
            if (numbers[i] < minimum)
            {
                minimum = numbers[i];
            }
        }
        Debug.Log("Maximum: " + maximum);
        Debug.Log("Minimum: " + minimum);

        // Step 5: เรียงลำดับแล้วพิมพ์อีกครั้ง
        System.Array.Sort(numbers);
        foreach (int n in numbers)
        {
            Debug.Log("Sorted: " + n);
        }
    }
}
