using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //// ประกาศ String ธรรมดา
    //public string name = "Somi";

    //// Array ที่เป็น String
    //public string[] names = { "Somi", "Ioon", "Somoon", "Simon", "Somin", "Imono" };

    //// Array ที่เป็น Int
    //public int[] scores = { 5, 7, 9, 1, 2, 6 };

    //void Start()
    //{

    //    for (int i = 3; i < scores.Length; i++)
    //    {
    //        Debug.Log(scores[i]);
    //    }
    //}
    //void Update()
    //{
        
    //}




    // Step 1: สร้าง array
    [SerializeField] int[] numbers = { 12, 7, 30, 4, 19, 25, 9, 18 };

    // Step 3: ผลรวมและค่าเฉลี่ย
    int sum;
    float average;

    // Step 4: ค่าสูงสุดและค่าต่ำสุด
    int maximum;
    int minimum;

    void Start()
    {
        // Step 2: พิมพ์ตัวเลขทุกตัว
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
