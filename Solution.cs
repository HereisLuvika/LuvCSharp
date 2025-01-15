using System.Formats.Asn1;

class Solution 

{
    public double solution0115(int[] numbers)
    {
        double answer = 0;
        double store = 0;

        //Linq 버전
        // return numbers.Average();

        // for 버전
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     store += numbers[i];
        // }
        // answer = store / numbers.Length;

        // foreach 버전
        foreach(int elem in numbers)
        {
            store += elem;
        }
        answer = store / numbers.Length;

        return answer ;
    }
    public int solution01142(int n, int k)
    {
        int answer = 0;
        int ser = n / 10;
        answer = (12000 * n) + (2000 * (k - ser));
        return answer;
    }
    public int solution0114(int n)
    {
        int answer = 0;
        for(int i = 0; i <= n; i++)
        {
            if (i % 2 == 0) 
            {
                answer += i;   
            }
        }
        return answer;
    }
    public int solution0113(int num1, int num2)
    {
        int answer = num1 == num2 ? 1:-1;
        return answer;
    }
    public int solution01102(int age)
    {
        int answer = 0;
        int nowYear = 2022;
        answer = nowYear - age + 1;
        return answer;
    }
    public int solution0110(int num1, int num2)
    {
        return num1 % num2;
    }
    public int solution0109(int num1, int num2)
    {
        return num1 - num2;
    }
    public int solution0108(int num1, int num2)
    {
        return num1 * num2;
    }
}
